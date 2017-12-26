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
    public partial class FrmPagamentoCompra : Form
    {
        public int pcoCod = 0;

        public FrmPagamentoCompra()
        {
            InitializeComponent();
        }

        private void btLocalizarCompra_Click(object sender, EventArgs e)
        {
            FrmConsultaCompra f = new FrmConsultaCompra();
            f.ShowDialog();

            if(f.codigo != 0)
            {
                //dados da compra código e data da compra e Valor Total
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCompra bllc = new BLLCompra(cx);
                ModeloCompra modCompra = bllc.CarregaModeloCompra(f.codigo);
                txtCodigo.Text = modCompra.ComCod.ToString();
                dtData.Value = modCompra.ComData;
                txtValorCompra.Text = modCompra.ComTotal.ToString("C");//O "C" significa em formato Currency para mostrar o "R$".

                //pegar nome do fornecedor
                BLLFornecedor bllf = new BLLFornecedor(cx);
                ModeloFornecedor modForn = bllf.CarregaModeloFornecedor(modCompra.ForCod);
                txtForNome.Text = modForn.ForNome;

                //carreda os dados das parcelas da compra no data grid
                BLLParcelasCompra bllp = new BLLParcelasCompra(cx);
                dgvParcelas.DataSource = bllp.Localizar(modCompra.ComCod);

                //mudança do titulo das colunas do grid
                dgvParcelas.Columns[0].HeaderText = "Parcela";
                dgvParcelas.Columns[0].Width = 100;
                dgvParcelas.Columns[1].HeaderText = "Valor";
                dgvParcelas.Columns[1].Width = 200;
                dgvParcelas.Columns[1].DefaultCellStyle.Format = "c";
                dgvParcelas.Columns[2].HeaderText = "Data Pagamento";
                dgvParcelas.Columns[2].Width = 200;
                dgvParcelas.Columns[3].HeaderText = "Data Vencimento";
                dgvParcelas.Columns[3].Width = 200;
                dgvParcelas.Columns[4].HeaderText = "Código da Compra";
                dgvParcelas.Columns[4].Width = 100;
                //oculta a coluna 4 do grid
                dgvParcelas.Columns[4].Visible = false;

            }
        }

        private void btPagar_Click(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLParcelasCompra bllpc = new BLLParcelasCompra(cx);

                int comCod = Convert.ToInt32(txtCodigo.Text);
                DateTime data = dtpPagamento.Value;
                bllpc.EfetuaPagamentoParcela(comCod, this.pcoCod, data);

                MessageBox.Show("Pagamento efetuado");

                dgvParcelas.DataSource = bllpc.Localizar(comCod);

                //mudança do titulo das colunas do grid
                dgvParcelas.Columns[0].HeaderText = "Parcela";
                dgvParcelas.Columns[0].Width = 100;
                dgvParcelas.Columns[1].HeaderText = "Valor";
                dgvParcelas.Columns[1].Width = 200;
                dgvParcelas.Columns[1].DefaultCellStyle.Format = "c";
                dgvParcelas.Columns[2].HeaderText = "Data Pagamento";
                dgvParcelas.Columns[2].Width = 200;
                dgvParcelas.Columns[3].HeaderText = "Data Vencimento";
                dgvParcelas.Columns[3].Width = 200;
                dgvParcelas.Columns[4].HeaderText = "Código da Compra";
                dgvParcelas.Columns[4].Width = 100;
                //oculta a coluna 4 do grid
                dgvParcelas.Columns[4].Visible = false;

                btPagar.Enabled = false;

            }
            catch (Exception erro) 
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void dgvParcelas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btPagar.Enabled = false;
            this.pcoCod = 0;

            if (e.RowIndex >= 0 && dgvParcelas.Rows[e.RowIndex].Cells[2].Value.ToString() == "") 
            {
                btPagar.Enabled = true;
                this.pcoCod = Convert.ToInt32(dgvParcelas.Rows[e.RowIndex].Cells[0].Value);
            }
        }
    }
}
