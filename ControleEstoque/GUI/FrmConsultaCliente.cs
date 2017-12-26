using BLL;
using DAL;
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
    public partial class FrmConsultaCliente : Form
    {
        public int codigo = 0;

        public FrmConsultaCliente()
        {
            InitializeComponent();
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCliente bll = new BLLCliente(cx);
            if (rbNome.Checked == true)
            {
                dgvDados.DataSource = bll.LocalizarPorNome(txtValor.Text);
            }
            else 
            {
                dgvDados.DataSource = bll.LocalizarPorCPFCNPJ(txtValor.Text);
            }
        }

        private void FrmConsultaCliente_Load(object sender, EventArgs e)
        {
            btLocalizar_Click(sender, e);
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 50;
            dgvDados.Columns[1].HeaderText = "Nome";
            dgvDados.Columns[1].Width = 200;
            dgvDados.Columns[2].HeaderText = "CPF/CNPJ";
            dgvDados.Columns[2].Width = 150;
            dgvDados.Columns[3].HeaderText = "RG/IE";
            dgvDados.Columns[3].Width = 150;
            dgvDados.Columns[4].HeaderText = "Razão Social";
            dgvDados.Columns[4].Width = 200;
            dgvDados.Columns[5].HeaderText = "Tipo";
            dgvDados.Columns[5].Width = 150;
            dgvDados.Columns[6].HeaderText = "CEP";
            dgvDados.Columns[6].Width = 150;
            dgvDados.Columns[7].HeaderText = "Endereço";
            dgvDados.Columns[7].Width = 200;
            dgvDados.Columns[8].HeaderText = "Bairro";
            dgvDados.Columns[8].Width = 200;
            dgvDados.Columns[9].HeaderText = "Fone";
            dgvDados.Columns[9].Width = 150;
            dgvDados.Columns[10].HeaderText = "Celular";
            dgvDados.Columns[10].Width = 150;
            dgvDados.Columns[11].HeaderText = "E-mail";
            dgvDados.Columns[11].Width = 200;
            dgvDados.Columns[12].HeaderText = "Numero";
            dgvDados.Columns[12].Width = 50;
            dgvDados.Columns[13].HeaderText = "Cidade";
            dgvDados.Columns[13].Width = 200;
            dgvDados.Columns[14].HeaderText = "Estado";
            dgvDados.Columns[14].Width = 200;
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
