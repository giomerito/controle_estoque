using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroCategoria f = new FrmCadastroCategoria();
            f.ShowDialog();
            f.Dispose();
        }

        private void categoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultaCategoria f = new FrmConsultaCategoria();
            f.ShowDialog();
            f.Dispose();
        }

        private void subCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroSubCategoria f = new FrmCadastroSubCategoria();
            f.ShowDialog();
            f.Dispose();
        }

        private void subCategoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultaSubCategoria f = new FrmConsultaSubCategoria();
            f.ShowDialog();
            f.Dispose();
        }

        private void unidadeDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroUnidadeDeMedida f = new FrmCadastroUnidadeDeMedida();
            f.ShowDialog();
            f.Dispose();
        }

        private void unidadeDeMedidaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultaUnidadeDeMedida f = new FrmConsultaUnidadeDeMedida();
            f.ShowDialog();
            f.Dispose();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroProduto f = new FrmCadastroProduto();
            f.ShowDialog();
            f.Dispose();
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultaProduto f = new FrmConsultaProduto();
            f.ShowDialog();
            f.Dispose();
        }

        private void configuraçãodoBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConfiguracaoBancoDados f = new FrmConfiguracaoBancoDados();
            f.ShowDialog();
            f.Dispose();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            //verifica conexao com o banco
            try
            {
                StreamReader arquivo = new StreamReader("Configuracaobanco.txt");
                DadosDaConexao.servidor = arquivo.ReadLine();
                DadosDaConexao.banco = arquivo.ReadLine();
                DadosDaConexao.usuario = arquivo.ReadLine();
                DadosDaConexao.senha = arquivo.ReadLine();
                arquivo.Close();

                //testa a conexao
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = DadosDaConexao.StringDeConexao;
                conexao.Open();
                conexao.Close();

            }
            catch (SqlException errob)
            {
                MessageBox.Show("Erro ao se conectar no banco de dados \n Acesse as Configurações do banco de dados e informe os parametros de conexão" + errob);
            }                
            catch (Exception erros) 
            {
                MessageBox.Show(erros.Message);
            }
        }

        private void beckupDoBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBackupBancoDeDados f = new FrmBackupBancoDeDados();
            f.ShowDialog();
            f.Dispose();
        }

        private void tipoDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroTipoPagamento f = new FrmCadastroTipoPagamento();
            f.ShowDialog();
            f.Dispose();
        }

        private void tipoDePagamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultaTipoPagamento f = new FrmConsultaTipoPagamento();
            f.ShowDialog();
            f.Dispose();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroCliente f = new FrmCadastroCliente();
            f.ShowDialog();
            f.Dispose();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultaCliente f = new FrmConsultaCliente();
            f.ShowDialog();
            f.Dispose();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroFornecedor f = new FrmCadastroFornecedor();
            f.ShowDialog();
            f.Dispose();
        }

        private void fornecedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultaFornecedor f = new FrmConsultaFornecedor();
            f.ShowDialog();
            f.Dispose();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSobre f = new FrmSobre();
            f.ShowDialog();
            f.Dispose();
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMovimentacaoCompra f = new FrmMovimentacaoCompra();
            f.ShowDialog();
            f.Dispose();
        }

        private void compraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultaCompra f = new FrmConsultaCompra();
            f.ShowDialog();
            f.Dispose();
        }

        private void pagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPagamentoCompra f = new FrmPagamentoCompra();
            f.ShowDialog();
            f.Dispose();
        }              

        private void butVenda_Click(object sender, EventArgs e)
        {
            FrmMovimentacaoVenda fven = new FrmMovimentacaoVenda();
            fven.ShowDialog();
            fven.Dispose();
        }
                
        private void movVenda_Click(object sender, EventArgs e)
        {
            FrmMovimentacaoVenda f = new FrmMovimentacaoVenda();
            f.ShowDialog();
            f.Dispose();
        }

        private void conVenda_Click(object sender, EventArgs e)
        {
            FrmConsultaVenda venda = new FrmConsultaVenda();
            venda.ShowDialog();
            venda.Dispose();
        }
    }
}
