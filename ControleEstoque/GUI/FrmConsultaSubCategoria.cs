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
    public partial class FrmConsultaSubCategoria : Form
    {
        public int codigo = 0;

        public FrmConsultaSubCategoria()
        {
            InitializeComponent();
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLSubCategoria bll = new BLLSubCategoria(cx);
            dgvDados.DataSource = bll.Localizar(txtCategoria.Text);
        }

        private void FrmConsultaSubCategoria_Load(object sender, EventArgs e)
        {
            btLocalizar_Click(sender, e);
            dgvDados.Columns[0].HeaderText = "Código da SubCategoria";
            dgvDados.Columns[0].Width = 140;
            dgvDados.Columns[1].HeaderText = "SubCategoria";
            dgvDados.Columns[1].Width = 300;
            dgvDados.Columns[2].HeaderText = "Código da Categoria";
            dgvDados.Columns[2].Width = 130;
            dgvDados.Columns[3].HeaderText = "Nome da Categoria";
            dgvDados.Columns[3].Width = 150;
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
