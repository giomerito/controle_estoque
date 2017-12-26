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
    public partial class FrmConsultaVenda : Form
    {

        public int codigo = 0;

        public FrmConsultaVenda()
        {
            InitializeComponent();
        }

        private void FrmConsultaVenda_Load(object sender, EventArgs e)
        {
            rbGeral_CheckedChanged(sender, e);
        }

        private void rbGeral_CheckedChanged(object sender, EventArgs e)
        {
            //ocultar painel
            pnCliente.Visible = false;
            pnData.Visible = false;

            //limpa os grids
            dgvDados.DataSource = null;
            dgvItens.DataSource = null;
            dgvParcelas.DataSource = null;

            if (rbGeral.Checked == true)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLVenda bllvenda = new BLLVenda(cx);
                dgvDados.DataSource = bllvenda.LocalizarTudo();
                this.AtualizaCabecelhoDgVenda();
            }
            if (rbData.Checked == true)
            {
                pnData.Visible = true;
            }
            if (rbCliente.Checked == true)
            {
                pnCliente.Visible = true;
            }
            if (rbParcelas.Checked == true)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLVenda bllvenda = new BLLVenda(cx);
                dgvDados.DataSource = bllvenda.LocalizarParcelasEmAberto();
                this.AtualizaCabecelhoDgVenda();
            }
        }

        public void AtualizaCabecelhoDgVenda()
        {
            //renomeando as colunas da tabela
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 50;
            dgvDados.Columns[1].HeaderText = "Data";
            dgvDados.Columns[1].Width = 100;
            dgvDados.Columns[2].HeaderText = "Nota Fiscal";
            dgvDados.Columns[2].Width = 80;
            dgvDados.Columns[3].HeaderText = "Parcelas";
            dgvDados.Columns[3].Width = 50;
            dgvDados.Columns[4].HeaderText = "Cliente";
            dgvDados.Columns[4].Width = 150;
            dgvDados.Columns[5].HeaderText = "Status";
            dgvDados.Columns[5].Width = 80;
            dgvDados.Columns[6].HeaderText = "Código do Cliente";
            dgvDados.Columns[6].Width = 100;
            dgvDados.Columns[7].HeaderText = "Código do Tipo de Pagamento";
            dgvDados.Columns[7].Width = 100;
            dgvDados.Columns[8].HeaderText = "Modo Pagamento";
            dgvDados.Columns[8].Width = 100;
            dgvDados.Columns[9].HeaderText = "Total";
            dgvDados.Columns[9].Width = 100;
            dgvDados.Columns[9].DefaultCellStyle.Format = "c";

            //ocultamento das colunas não importantes na visibilidade
            //dgvDados.Columns[3].Visible = false;
            //dgvDados.Columns[5].Visible = false;
            dgvDados.Columns[6].Visible = false;
            dgvDados.Columns[7].Visible = false;
            dgvDados.Columns[8].Visible = false;


        }

        public void AlteraCabecelhoItensParcelas()
        {
            try
            {
                //data grid dos itens
                dgvItens.Columns[0].HeaderText = "Código Venda"; //altera nome da coluna
                dgvItens.Columns[0].Width = 100; //define tamanho da coluna
                dgvItens.Columns[1].HeaderText = "Item";
                dgvItens.Columns[1].Width = 100;
                dgvItens.Columns[2].HeaderText = "Código";
                dgvItens.Columns[2].Width = 100;
                dgvItens.Columns[3].HeaderText = "Produto";
                dgvItens.Columns[3].Width = 200;
                dgvItens.Columns[4].HeaderText = "Quantidade";
                dgvItens.Columns[4].Width = 100;
                dgvItens.Columns[5].HeaderText = "Valor";
                dgvItens.Columns[5].Width = 100;
                dgvItens.Columns[5].DefaultCellStyle.Format = "c"; //formata valor em R$ 0,00
                //ocultação da célula código da compra 
                dgvItens.Columns[0].Visible = false;

                
                //data grid das parcelas
                dgvParcelas.Columns[0].HeaderText = "Venda";
                dgvParcelas.Columns[0].Width = 100;
                dgvParcelas.Columns[1].HeaderText = "Parcela";
                dgvParcelas.Columns[1].Width = 100;                
                dgvParcelas.Columns[2].HeaderText = "Valor Parcela";
                dgvParcelas.Columns[2].Width = 150;
                dgvParcelas.Columns[2].DefaultCellStyle.Format = "c";
                dgvParcelas.Columns[3].HeaderText = "Data Pagamento";
                dgvParcelas.Columns[3].Width = 150;
                dgvParcelas.Columns[4].HeaderText = "Data Vencimento";
                dgvParcelas.Columns[4].Width = 100;
                //ocultação da celula código da compra
                //dgvParcelas.Columns[4].Visible = false;
                
            }
            catch { }
        }

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);

                //itens da venda
                BLLItensVenda bllItens = new BLLItensVenda(cx);
                dgvItens.DataSource = bllItens.Localizar(Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value));

                //parcelas da venda
                BLLParcelasVenda bllParcelas = new BLLParcelasVenda(cx);
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

        private void btLocCliente_Click(object sender, EventArgs e)
        {
            FrmConsultaCliente c = new FrmConsultaCliente();
            c.ShowDialog();

            if (c.codigo != 0)
            {
                //pesquisa um cliente
                txtCliCod.Text = c.codigo.ToString();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                ModeloCliente modelo = bll.CarregaModeloCliente(c.codigo);
                lbCliNome.Text = "Nome do cliente: " + modelo.CliNome;

                //carrega dados do Cliente no DataGrid
                BLLVenda bllvenda = new BLLVenda(cx);
                dgvDados.DataSource = bllvenda.LocalizarPorCodigo(c.codigo);
                c.Dispose();
                this.AtualizaCabecelhoDgVenda();

            }
            else
            {
                txtCliCod.Text = "";
                lbCliNome.Text = "Nome do Cliente";
            }
        }

        private void btData_Click(object sender, EventArgs e)
        {
            DateTime dtIni = dtpInicial.Value;
            DateTime dtFim = dtpFinal.Value;
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLVenda bllvenda = new BLLVenda(cx);
            dgvDados.DataSource = bllvenda.LocalizarPorData(dtIni, dtFim);
            this.AtualizaCabecelhoDgVenda();
        }
    }
}
