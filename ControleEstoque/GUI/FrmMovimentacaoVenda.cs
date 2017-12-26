using BLL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmMovimentacaoVenda : GUI.FrmModeloDeFormularioDeCadastro
    {
        public double totalVenda = 0;

        public FrmMovimentacaoVenda()
        {
            InitializeComponent();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.totalVenda = 0;
            alteraBotoes(2);
            cbNParcelas.SelectedIndex = 0;
            cbVendaAvista.Checked = false;
        }

        public void LimpaTela() 
        {
            txtVenCod.Clear();
            txtNfiscal.Clear();
            txtCliCod.Clear();
            LProduto.Text = "Informe o código do produto ou click em localizar!";
            txtQtd.Clear();
            txtValor.Clear();
            cbNParcelas.SelectedIndex = 0;
            cbTipoPag.SelectedIndex = 0;
            cbVendaAvista.Checked = false;
            txtTotalVenda.Text = "0,00";
            dgvItens.Rows.Clear();
            labVenda.Visible = false;
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            FrmConsultaVenda f = new FrmConsultaVenda();
            f.ShowDialog();
            if (f.codigo != 0)
            {

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLVenda bllvenda = new BLLVenda(cx);
                ModeloVenda modelo = bllvenda.CarregaModeloVenda(f.codigo);

                //Carrega os dados da venda
                txtVenCod.Text = modelo.VenCod.ToString();
                txtNfiscal.Text = modelo.VenNfiscal.ToString();
                dtDataVenda.Value = modelo.VenData;
                txtCliCod.Text = modelo.CliCod.ToString();
                txtCliCod_Leave(sender, e); //serve para escrever o nome do cliente na tela
                cbTipoPag.SelectedValue = modelo.TpaCod;
                cbNParcelas.SelectedValue = modelo.VenNparcelas;
                if (modelo.VenAvista == 1) cbVendaAvista.Checked = true;
                else cbVendaAvista.Checked = false;
                txtTotalVenda.Text = modelo.VenTotal.ToString();
                this.totalVenda = modelo.VenTotal;

                //Carrega os Itens da Venda
                BLLItensVenda bllItens = new BLLItensVenda(cx);
                DataTable tabela = bllItens.Localizar(modelo.VenCod);

                for (int i = 0; i < tabela.Rows.Count; i++) 
                {
                    string icod = tabela.Rows[i]["pro_cod"].ToString();
                    string inome = tabela.Rows[i]["pro_nome"].ToString();
                    string iqtd = tabela.Rows[i]["itv_qtde"].ToString();
                    string ivu = tabela.Rows[i]["itv_valor"].ToString();
                    Double TotalLocal = Convert.ToDouble(tabela.Rows[i]["itv_qtde"]) * Convert.ToDouble(tabela.Rows[i]["itv_valor"]);

                    String [] it = new String[] { icod, inome, iqtd, ivu, TotalLocal.ToString() };
                    this.dgvItens.Rows.Add(it);
                }
                alteraBotoes(3);

                labVenda.Visible = false;
                if(modelo.VenStatus != "ativa"){
                    //labVenda.Text = "Venda cancelada";
                    labVenda.Visible = true;
                    btExcluir.Enabled = false;
                }
            }
            else 
            {
                LimpaTela();
                alteraBotoes(1);
            }
            f.Dispose();
        }

        private void btLocCli_Click(object sender, EventArgs e)
        {
            FrmConsultaCliente f = new FrmConsultaCliente();
            f.ShowDialog();
            if(f.codigo != 0)
            {
                txtCliCod.Text = f.codigo.ToString();
                txtCliCod_Leave(sender, e);
            }
        }

        private void txtCliCod_Leave(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                ModeloCliente modelo = bll.CarregaModeloCliente(Convert.ToInt32(txtCliCod.Text));
                if (modelo.CliCod <= 0)
                {
                    txtCliCod.Clear();
                    LCliente.Text = "Informe o código do cliente ou click em localizar!";
                }
                else LCliente.Text = modelo.CliNome;
                
            }
            catch 
            {
                txtCliCod.Clear();
                LCliente.Text = "Informe o código do cliente ou click em localizar!";
            }
        }

        private void btLocProd_Click(object sender, EventArgs e)
        {
            FrmConsultaProduto f = new FrmConsultaProduto();
            f.ShowDialog();
            if(f.codigo != 0)
            {
                txtProCod.Text = f.codigo.ToString();
                txtProCod_Leave(sender, e);
            }
        }

        private void txtProCod_Leave(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                ModeloProduto modelo = bll.CarregaModeloProduto(Convert.ToInt32(txtProCod.Text));
                LProduto.Text = modelo.ProNome;
                txtQtd.Text = " 1";
                txtValor.Text = modelo.ProValorVenda.ToString();
            }
            catch 
            {
                txtProCod.Clear();
                LProduto.Text = "Informe o codigo do produto ou click em localizar";
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtProCod.Text != "") && (txtQtd.Text != "") && (txtValor.Text != ""))
                {
                    Double totalLocal = Convert.ToDouble(txtQtd.Text) * Convert.ToDouble(txtValor.Text);
                    this.totalVenda = this.totalVenda + totalLocal;
                    String[] i = new String[] { txtProCod.Text, LProduto.Text, txtQtd.Text, txtValor.Text, totalLocal.ToString() };
                    this.dgvItens.Rows.Add(i);

                    txtProCod.Clear();
                    LProduto.Text = "Informe o codigo do produto ou click em localizar";
                    txtQtd.Clear();
                    txtValor.Clear();

                    txtTotalVenda.Text = this.totalVenda.ToString();
                }
            }
            catch 
            {
                MessageBox.Show("Informe apenas números nos campos referentes ao valor e quantidade do produto");
            }
        }

        private void FrmMovimentacaoVenda_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLTipoPagamento bll = new BLLTipoPagamento(cx);
            cbTipoPag.DataSource = bll.Localizar("");
            cbTipoPag.DisplayMember = "tpa_nome";
            cbTipoPag.ValueMember = "tpa_cod";

            cbNParcelas.SelectedIndex = 0;
        }

        private void cbVendaAvista_CheckedChanged(object sender, EventArgs e)
        {
            if(cbVendaAvista.Checked == true)
            {
                cbNParcelas.SelectedIndex = 0;
                cbNParcelas.Enabled = false;
            }
            else
            {
                cbNParcelas.Enabled = true;
            }
        }

        private void dgvItens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtProCod.Text = dgvItens.Rows[e.RowIndex].Cells[0].Value.ToString();
                LProduto.Text = dgvItens.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtQtd.Text = dgvItens.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtValor.Text = dgvItens.Rows[e.RowIndex].Cells[3].Value.ToString();
                Double valor = Convert.ToDouble(dgvItens.Rows[e.RowIndex].Cells[4].Value);
                this.totalVenda = this.totalVenda - valor;
                dgvItens.Rows.RemoveAt(e.RowIndex);
                txtTotalVenda.Text = this.totalVenda.ToString();

            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            //validar os dados da venda
            try
            {
                if (Convert.ToInt32(txtCliCod.Text) <= 0)
                {
                    MessageBox.Show("Informe um código valido para o cliente");
                    return;
                }

                if (Convert.ToInt32(txtNfiscal.Text) < 0)
                {
                    MessageBox.Show("Informe um número valido para a Nota Fiscal");
                    return;
                }
                if(totalVenda <= 0)
                {
                    MessageBox.Show("Insira itens em sua venda para continuar!");
                    return;
                }
                dgvParcelas.Rows.Clear(); //limpa as linhas do data grid parcelas
                int parcelas = Convert.ToInt32(cbNParcelas.Text);
                Double totalLocal = this.totalVenda;
                double valor = totalLocal / parcelas;
                DateTime dt = new DateTime();

                dt = dtDataIni.Value;
                lbTotal.Text = this.totalVenda.ToString();

                for (int i = 1; i <= parcelas; i++)
                {
                    String[] k = new String[] { i.ToString(), valor.ToString(), dt.Date.ToString() };
                    this.dgvParcelas.Rows.Add(k);
                    if (dt.Month != 12)
                    {
                        dt = new DateTime(dt.Year, dt.Month + 1, dt.Day);
                    }
                    else
                    {
                        dt = new DateTime(dt.Year + 1, 1, dt.Day);
                    }
                    pnFinalizaCompra.Visible = true;
                }
            }
            catch 
            {
                MessageBox.Show("Verificar os campos da tela de venda");
            }
            
            
            }        

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            alteraBotoes(1);
        }

        private void btnCancelaParcelas_Click(object sender, EventArgs e)
        {
            pnFinalizaCompra.Visible = false;
        }

        private void btnSalvarFinal_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            cx.Conectar();
            cx.IniciarTransacao();

            try
            {
                //leitura dos dados
                ModeloVenda modelo = new ModeloVenda();
                modelo.VenData = dtDataVenda.Value;
                modelo.VenNfiscal = Convert.ToInt32(txtNfiscal.Text);
                modelo.VenNparcelas = Convert.ToInt32(cbNParcelas.Text);
                modelo.VenStatus = "ativa";
                modelo.VenTotal = this.totalVenda;
                modelo.CliCod = Convert.ToInt32(txtCliCod.Text);
                modelo.TpaCod = Convert.ToInt32(cbTipoPag.SelectedValue);
                if (cbVendaAvista.Checked == true)
                {
                    modelo.VenAvista = 1;
                }
                else {
                    modelo.VenAvista = 0;
                }

                //objeto para gravar os dados no banco na tabela compra

                BLLVenda bll = new BLLVenda(cx);

                //objeto para gravar os dados no banco na tabela itenscompra
                ModeloItensVenda modItens = new ModeloItensVenda();
                BLLItensVenda bitens = new BLLItensVenda(cx);

                if (this.operacao == "inserir")
                {
                    //cadastrar uma venda
                    bll.Incluir(modelo);

                    //cadastrar os itens da venda
                    
                    for (int i = 0; i < dgvItens.RowCount; i++)
                    {
                        //pega os itens da tabela e grava no banco
                        modItens.ItvCod = i + 1;
                        modItens.VenCod = modelo.VenCod;
                        modItens.ProCod = Convert.ToInt32(dgvItens.Rows[i].Cells[0].Value);
                        modItens.ItvQtde = Convert.ToDouble(dgvItens.Rows[i].Cells[2].Value);
                        modItens.ItvValor = Convert.ToDouble(dgvItens.Rows[i].Cells[3].Value);
                        bitens.Incluir(modItens);
                        //alterar a quantidade de produtos na tabela de produtos
                        //trigger gatilho no banco de dados sql server
                    }
                    //inserir os itens na tabela de produto
                    
                    //cadastrar as parcelas na tabela venda
                    ModeloParcelasVenda mparcelas = new ModeloParcelasVenda();
                    BLLParcelasVenda bparcelas = new BLLParcelasVenda(cx);

                    for (int i = 0; i < dgvParcelas.RowCount; i++)
                    {
                        mparcelas.VenCod = modelo.VenCod;
                        mparcelas.PveCod = Convert.ToInt32(dgvParcelas.Rows[i].Cells[0].Value);
                        mparcelas.PveValor = Convert.ToDouble(dgvParcelas.Rows[i].Cells[1].Value);
                        mparcelas.PveDataVecto = Convert.ToDateTime(dgvParcelas.Rows[i].Cells[2].Value);
                        bparcelas.Incluir(mparcelas);
                    }                     
                    MessageBox.Show("Venda efetuada! Código " + modelo.VenCod.ToString());
                    pnFinalizaCompra.Visible = false;                    

                   
                }
                else
                {
                    /*
                    //alterar uma compra
                    modelo.ComCod = Convert.ToInt32(txtComCod.Text);
                    bll.Alterar(modelo);

                    bitens.ExcluirTodosOsItens(modelo.ComCod);

                    //cadastrar os itens da compra
                    for (int i = 0; i < dgvItens.RowCount; i++)
                    {
                        modItens.ItcCod = i + 1;
                        modItens.ComCod = modelo.ComCod;
                        modItens.ProCod = Convert.ToInt32(dgvItens.Rows[i].Cells[0].Value);
                        modItens.ItcQtde = Convert.ToDouble(dgvItens.Rows[i].Cells[2].Value);
                        modItens.ItcValor = Convert.ToDouble(dgvItens.Rows[i].Cells[3].Value);
                        bitens.Incluir(modItens);
                        //alterar a quantidade de produtos na tabela de produtos
                        //trigger gatilho no banco de dados sql server
                    }
                    //inserir os itens na tabela de produto


                    //cadastrar as parcelas na tabela compra
                    ModeloParcelasCompra mparcelas = new ModeloParcelasCompra();
                    BLLParcelasCompra bparcelas = new BLLParcelasCompra(cx);

                    bparcelas.ExcluirTodasAsParcelas(modelo.ComCod);

                    for (int i = 0; i < dgvParcelas.RowCount; i++)
                    {
                        mparcelas.ComCod = modelo.ComCod;
                        mparcelas.PcoCod = Convert.ToInt32(dgvParcelas.Rows[i].Cells[0].Value);
                        mparcelas.PcoValor = Convert.ToDouble(dgvParcelas.Rows[i].Cells[1].Value);
                        mparcelas.PcoDataVecto = Convert.ToDateTime(dgvParcelas.Rows[i].Cells[2].Value);
                        bparcelas.Incluir(mparcelas);
                    }


                    MessageBox.Show("Cadastro alterado");
                     */
                }

                //this.LimpaTela();
                this.alteraBotoes(1);
                //pnFinalizaVenda.Visible = false;
                cx.TerminarTrasacao();//Commit
                cx.Desconectar();
                LimpaTela();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                cx.CancelarTransacao();//Rollback
                cx.Desconectar();
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            //implementar o cancelamento da venda
            //alterar o campo status da tabela venda
            //retornar os itens para o estoque
            //devolver o dinheiro para o cliente (Não iremos trabalhar
            //o nosso sistema não possui caixa)
        }
    }
}
