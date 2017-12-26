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
    public partial class FrmMovimentacaoCompra : GUI.FrmModeloDeFormularioDeCadastro
    {
        public double totalCompra = 0;

        public FrmMovimentacaoCompra()
        {
            InitializeComponent();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.totalCompra = 0;
            this.alteraBotoes(2);
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            
            FrmConsultaCompra f = new FrmConsultaCompra();
            f.ShowDialog();

            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCompra bll = new BLLCompra(cx);
                
                ModeloCompra modelo = bll.CarregaModeloCompra(f.codigo);
                //carrega dados da compra
                txtComCod.Text = modelo.ComCod.ToString();
                txtNfiscal.Text = modelo.ComNfiscal.ToString();
                dtDataCompra.Value = modelo.ComData;
                txtForCod.Text = modelo.ForCod.ToString();
                txtForCod_Leave(sender, e); //para escrever o nome do fornecedor na tela
                txtTotalCompra.Text = modelo.ComTotal.ToString();
                this.totalCompra = modelo.ComTotal; //para armazenar o valor total da compra
                cbNParcelas.Text = modelo.ComNparcelas.ToString();
                cbTipoPag.SelectedValue = modelo.TpaCod;
                
                //carrega itens da compra
                BLLItensCompra bllItens = new BLLItensCompra(cx);
                DataTable tabela = bllItens.Localizar(modelo.ComCod);
                //ModeloItensCompra modItens = bllItens.CarregaModeloItensCompra();

                for (int i = 0; i < tabela.Rows.Count; i++) 
                {
                    string icod = tabela.Rows[i]["pro_cod"].ToString();
                    string inome = tabela.Rows[i]["pro_nome"].ToString();
                    string iqtd = tabela.Rows[i]["itc_qtde"].ToString();
                    string ivu = tabela.Rows[i]["itc_valor"].ToString();

                    Double TotalLocal = Convert.ToDouble(iqtd) * Convert.ToDouble(ivu);


                    String[] it = new String[] { icod, inome, iqtd, ivu, TotalLocal.ToString() };
                    this.dgvItens.Rows.Add(it);
                }

                    this.alteraBotoes(3);
            }
            else 
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }

            f.Dispose();                      
                         
             
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            int qtde = Convert.ToInt32(cbNParcelas.Text);
            int codigo = Convert.ToInt32(txtComCod.Text);
            //conexao e bll da compra
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCompra bllc = new BLLCompra(cx);

            //verificação das parcelas se estão pagas ou não
            qtde -= bllc.QuantidadeParcelasNaoPagas(codigo);

            if (qtde == 0) //não tem parcelas pagas
            {
                this.operacao = "alterar";
                this.alteraBotoes(2);
            }
            else //caso tenha parcelas pagas
            {
                MessageBox.Show("Impossivel alterar o registro. \n O registro possui parcelas pagas.");
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            
           
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    int qtde = Convert.ToInt32(cbNParcelas.Text);
                    int codigo = Convert.ToInt32(txtComCod.Text);
                    //conexao e bll da compra
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLCompra bllc = new BLLCompra(cx);

                    //verificação das parcelas se estão pagas ou não
                    qtde -= bllc.QuantidadeParcelasNaoPagas(codigo);

                    if (qtde == 0) //não tem parcelas pagas
                    {
                        cx.Conectar();
                        cx.IniciarTransacao();
                        try
                        {
                            //excluir as parcelas da compra
                            BLLParcelasCompra bllp = new BLLParcelasCompra(cx);
                            bllp.ExcluirTodasAsParcelas(codigo);

                            //excluir itens da compra
                            BLLItensCompra blli = new BLLItensCompra(cx);
                            blli.ExcluirTodosOsItens(codigo);

                            //excluir a compra

                            bllc.Excluir(codigo);

                            MessageBox.Show("Compra excluida com sucesso");

                            this.LimpaTela();
                            this.alteraBotoes(1);
                            cx.TerminarTrasacao();
                            cx.Desconectar();
                                                        
                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show(erro.Message);
                            cx.CancelarTransacao();
                            cx.Desconectar();
                        }
                    }
                    else //caso tenha parcelas pagas
                    {
                        MessageBox.Show("Impossivel excluir o registro. \n O registro possui parcelas pagas.");
                    }                    
                }
            }
            catch
            {
                MessageBox.Show("Impossivel excluir o registro. \n O registro esta sendo utilizado em outro local.");
                this.alteraBotoes(3);
                
            }
             
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            dgvParcelas.Rows.Clear(); //limpa as linhas do data grid parcelas
            int parcelas = Convert.ToInt32(cbNParcelas.Text);
            Double totalLocal = this.totalCompra;
            double valor = totalLocal / parcelas;
            DateTime dt = new DateTime();

            dt = dtDataIni.Value;
            lbTotal.Text = this.totalCompra.ToString();

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

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            this.LimpaTela();
            this.totalCompra = 0;
            pnFinalizaCompra.Visible = false;
        }

        public void LimpaTela() 
        {
            this.txtComCod.Clear();
            this.txtNfiscal.Clear();
            this.txtForCod.Clear();
            this.txtProCod.Clear();
            this.LProduto.Text = "Informe o código do produto ou click em localizar!";
            this.LFornecedor.Text = "Informe o código do fornecedor ou click no botão localizar!";
            this.txtQtd.Clear();
            this.txtValor.Clear();
            this.txtTotalCompra.Clear();
            this.dgvItens.Rows.Clear();
        }

        private void btLFor_Click(object sender, EventArgs e)
        {
            FrmConsultaFornecedor f = new FrmConsultaFornecedor();
            f.ShowDialog();
            if (f.codigo != 0) 
            {
                //chamada do método do txtForCod
                txtForCod.Text = f.codigo.ToString();
                txtForCod_Leave(sender, e);
                
            }
        }

        private void txtForCod_Leave(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                ModeloFornecedor modelo = bll.CarregaModeloFornecedor(Convert.ToInt32(txtForCod.Text));
                if (modelo.ForCod <= 0)
                {
                    txtForCod.Clear();
                    LFornecedor.Text = "Informe o código do fornecedor ou click em localizar!";
                }
                else LFornecedor.Text = modelo.ForNome;
            }
            catch 
            {
                txtForCod.Clear();
                LFornecedor.Text = "Informe o código do fornecedor ou click no botão localizar!";
            }
        }

        private void btLocProd_Click(object sender, EventArgs e)
        {
             FrmConsultaProduto f = new FrmConsultaProduto();
            f.ShowDialog();
            if (f.codigo != 0) 
            {
                //chamada do método do txtForCod
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
                txtQtd.Text = "1";
                txtValor.Text = modelo.ProValorPago.ToString();
            }
            catch 
            {
                txtProCod.Clear();
                LProduto.Text = "Informe o código do produto ou click em localizar!";
            }        
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtProCod.Text != "") && (txtQtd.Text != "") && (txtValor.Text != ""))
                {
                    Double TotalLocal = Convert.ToDouble(txtQtd.Text) * Convert.ToDouble(txtValor.Text);
                    this.totalCompra = this.totalCompra + TotalLocal;
                    String[] i = new String[] { txtProCod.Text, LProduto.Text, txtQtd.Text, txtValor.Text, TotalLocal.ToString() };
                    this.dgvItens.Rows.Add(i);

                    txtProCod.Clear();
                    LProduto.Text = "Informe o código do produto ou click em localizar!";
                    txtQtd.Clear();
                    txtValor.Clear();

                    txtTotalCompra.Text = this.totalCompra.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Informe apenas números nos campos referentes ao valor e quantidade do produto");
            }
        }

        private void FrmMovimentacaoCompra_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            //carrega a combobox tipo de pagamento
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLTipoPagamento bll = new BLLTipoPagamento(cx);
            cbTipoPag.DataSource = bll.Localizar("");
            cbTipoPag.DisplayMember = "tpa_nome";
            cbTipoPag.ValueMember = "tpa_cod";

            cbNParcelas.SelectedIndex = 0;
        }

        private void dgvItens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                txtProCod.Text = dgvItens.Rows[e.RowIndex].Cells[0].Value.ToString();
                LProduto.Text = dgvItens.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtQtd.Text = dgvItens.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtValor.Text = dgvItens.Rows[e.RowIndex].Cells[3].Value.ToString();                
                Double valor = Convert.ToDouble(dgvItens.Rows[e.RowIndex].Cells[4].Value);                
                this.totalCompra = this.totalCompra - valor;
                dgvItens.Rows.RemoveAt(e.RowIndex);
                txtTotalCompra.Text = this.totalCompra.ToString();
                               
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
                ModeloCompra modelo = new ModeloCompra();
                modelo.ComData = dtDataCompra.Value;
                modelo.ComNfiscal = Convert.ToInt32(txtNfiscal.Text);
                modelo.ComNparcelas = Convert.ToInt32(cbNParcelas.Text);
                modelo.ComStatus = "ativa";
                modelo.ComTotal = this.totalCompra;
                modelo.ForCod = Convert.ToInt32(txtForCod.Text);
                modelo.TpaCod = Convert.ToInt32(cbTipoPag.SelectedValue);

                //objeto para gravar os dados no banco na tabela compra
                
                BLLCompra bll = new BLLCompra(cx);

                //objeto para gravar os dados no banco na tabela itenscompra
                ModeloItensCompra modItens = new ModeloItensCompra();
                BLLItensCompra bitens = new BLLItensCompra(cx);

                if (this.operacao == "inserir")
                {
                    //cadastrar uma compra
                    bll.Incluir(modelo);

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

                    for (int i = 0; i < dgvParcelas.RowCount; i++)
                    {
                        mparcelas.ComCod = modelo.ComCod;
                        mparcelas.PcoCod = Convert.ToInt32(dgvParcelas.Rows[i].Cells[0].Value);
                        mparcelas.PcoValor = Convert.ToDouble(dgvParcelas.Rows[i].Cells[1].Value);
                        mparcelas.PcoDataVecto = Convert.ToDateTime(dgvParcelas.Rows[i].Cells[2].Value);
                        bparcelas.Incluir(mparcelas);
                    }

                        MessageBox.Show("Cadastro efetuado! Código " + modelo.ComCod.ToString());
                }
                else
                {
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
                }

                this.LimpaTela();
                this.alteraBotoes(1);
                pnFinalizaCompra.Visible = false;
                cx.TerminarTrasacao();//Commit
                cx.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                cx.CancelarTransacao();//Rollback
                cx.Desconectar();
            }
        }
    }
}
