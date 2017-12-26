using BLL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmConsultaCompra : Form
    {
        public int codigo = 0;

        public FrmConsultaCompra()
        {
            InitializeComponent();
        }

        private void FrmConsultaCompra_Load(object sender, EventArgs e)
        {
            rbGeral_CheckedChanged(sender, e);
        }

        public void ExecutaConsulta(int op) 
        {
            //op = 1 consulta todas as compras
            //op = 2 consulta por fornecedor
            //op = 3 consulta por Data
            //op = 4 consulta por parcelas em aberto


        }

        public void AtualizaCabecelhoDgCompra() 
        {
            //renomeando as colunas da tabela
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 100;
            dgvDados.Columns[1].HeaderText = "Data da Compra";
            dgvDados.Columns[1].Width = 150;
            dgvDados.Columns[2].HeaderText = "Número da Nota Fiscal";
            dgvDados.Columns[2].Width = 150;
            dgvDados.Columns[3].HeaderText = "Número de Parcelas";
            dgvDados.Columns[3].Width = 150;
            dgvDados.Columns[4].HeaderText = "Total";
            dgvDados.Columns[4].Width = 100;
            dgvDados.Columns[4].DefaultCellStyle.Format = "c";
            dgvDados.Columns[5].HeaderText = "Status da Compra";
            dgvDados.Columns[5].Width = 100;
            dgvDados.Columns[6].HeaderText = "Código do Fornecedor";
            dgvDados.Columns[6].Width = 100;
            dgvDados.Columns[7].HeaderText = "Código do Tipo de Pagamento";
            dgvDados.Columns[7].Width = 100;
            dgvDados.Columns[8].HeaderText = "Fornecedor";
            dgvDados.Columns[8].Width = 300;

            //ocultamento das colunas não importantes na visibilidade
            dgvDados.Columns[3].Visible = false;
            dgvDados.Columns[5].Visible = false;
            dgvDados.Columns[6].Visible = false;
            dgvDados.Columns[7].Visible = false;


        } 
              
        private void btLocFornecedor_Click(object sender, EventArgs e)
        {
            FrmConsultaFornecedor f = new FrmConsultaFornecedor();
            f.ShowDialog();

            if (f.codigo != 0)
            {
                //pesquisa um fornecedor
                txtForCod.Text = f.codigo.ToString();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                ModeloFornecedor modelo = bll.CarregaModeloFornecedor(f.codigo);
                lbForNome.Text = "Nome do fornecedor: " + modelo.ForNome;

                //carrega dados do fornecedor no DataGrid
                BLLCompra bllcompra = new BLLCompra(cx);
                dgvDados.DataSource = bllcompra.LocalizarPorCodigo(f.codigo);
                f.Dispose();
                this.AtualizaCabecelhoDgCompra();

            }
            else 
            {
                txtForCod.Text = "";
                lbForNome.Text = "Nome do fornecedor";
            }
        }

        private void rbGeral_CheckedChanged(object sender, EventArgs e)
        {
            //ocultar painel
            pnFornecedor.Visible = false;
            pnData.Visible = false;

            //limpa os grids
            dgvDados.DataSource = null;
            dgvItens.DataSource = null;
            dgvParcelas.DataSource = null;

            if (rbGeral.Checked == true) 
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCompra bllcompra = new BLLCompra(cx);
                dgvDados.DataSource = bllcompra.Localizar();
                this.AtualizaCabecelhoDgCompra();
            }
            if (rbData.Checked == true)
            {
                pnData.Visible = true;
            }
            if (rbFornecedor.Checked == true)
            {
                pnFornecedor.Visible = true;
            }
            if (rbParcelas.Checked == true)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCompra bllcompra = new BLLCompra(cx);
                dgvDados.DataSource = bllcompra.LocalizarPorParcelasAberto();
                this.AtualizaCabecelhoDgCompra();
            }
        }

        private void btData_Click(object sender, EventArgs e)
        {
            DateTime dtini = dtpInicial.Value;
            DateTime dtfim = dtpFinal.Value;

            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCompra bllcompra = new BLLCompra(cx);
            dgvDados.DataSource = bllcompra.LocalizarPorData(dtini,dtfim);
            this.AtualizaCabecelhoDgCompra();
        }

        public void AlteraCabecelhoItensParcelas() 
        {
            try
            {
                //data grid dos itens
                dgvItens.Columns[0].HeaderText = "Código Compra"; //altera nome da coluna
                dgvItens.Columns[0].Width = 100; //define tamanho da coluna
                dgvItens.Columns[1].HeaderText = "Código do Item";
                dgvItens.Columns[1].Width = 100;
                dgvItens.Columns[2].HeaderText = "Código do Produto";
                dgvItens.Columns[2].Width = 100;
                dgvItens.Columns[3].HeaderText = "Nome do Produto";
                dgvItens.Columns[3].Width = 200;
                dgvItens.Columns[4].HeaderText = "Quantidade";
                dgvItens.Columns[4].Width = 100;
                dgvItens.Columns[5].HeaderText = "Valor";
                dgvItens.Columns[5].Width = 100;
                dgvItens.Columns[5].DefaultCellStyle.Format = "c"; //formata valor em R$ 0,00
                //ocultação da célula código da compra 
                dgvItens.Columns[0].Visible = false;


                //data grid das parcelas
                dgvParcelas.Columns[0].HeaderText = "Parcela";
                dgvParcelas.Columns[0].Width = 100;
                dgvParcelas.Columns[1].HeaderText = "Valor";
                dgvParcelas.Columns[1].Width = 100;
                dgvParcelas.Columns[1].DefaultCellStyle.Format = "c";
                dgvParcelas.Columns[2].HeaderText = "Data de Pagamento";
                dgvParcelas.Columns[2].Width = 150;
                dgvParcelas.Columns[3].HeaderText = "Data de Vencimento";
                dgvParcelas.Columns[3].Width = 150;
                dgvParcelas.Columns[4].HeaderText = "Código da Compra";
                dgvParcelas.Columns[4].Width = 100;
                //ocultação da celula código da compra
                dgvParcelas.Columns[4].Visible = false;
            }
            catch { }
        }

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);

                //itens da compra
                BLLItensCompra bllItens = new BLLItensCompra(cx);
                dgvItens.DataSource = bllItens.Localizar(Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value));

                //parcelas da compra
                BLLParcelasCompra bllParcelas = new BLLParcelasCompra(cx);
                dgvParcelas.DataSource = bllParcelas.Localizar(Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value));

                this.AlteraCabecelhoItensParcelas();
            }
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
