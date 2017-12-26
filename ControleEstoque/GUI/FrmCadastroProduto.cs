using BLL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmCadastroProduto : GUI.FrmModeloDeFormularioDeCadastro
    {
        public string foto = "";

        public FrmCadastroProduto()
        {
            InitializeComponent();
        }

        public void LimpaTela() 
        {
            this.txtCodigo.Clear();
            this.txtNome.Clear();
            this.txtDescricao.Clear();
            this.txtQtde.Clear();
            this.txtValorPago.Clear();
            this.txtValorVenda.Clear();
            this.txtQtde.Clear();
            this.foto = "";
            this.pbFoto = null;

        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);            
        }

        private void FrmCadastroProduto_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);

            //Combo da Categoria            
            BLLCategoria bll = new BLLCategoria(cx);
            cbCategoria.DataSource = bll.Localizar("");
            cbCategoria.DisplayMember = "cat_nome";
            cbCategoria.ValueMember = "cat_cod";
            cbCategoria.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbCategoria.AutoCompleteSource = AutoCompleteSource.ListItems;

            try
            {
                //Combo da SubCategoria            
                BLLSubCategoria sbll = new BLLSubCategoria(cx);
                cbSubCategoria.DataSource = sbll.LocalizarPorCategoria((int)cbCategoria.SelectedValue);
                cbSubCategoria.DisplayMember = "scat_nome";
                cbSubCategoria.ValueMember = "scat_cod";
                cbSubCategoria.AutoCompleteMode = AutoCompleteMode.Suggest;
                cbSubCategoria.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            catch 
            {
                //MessageBox.Show("Cadastre uma subcategoria");
            }

            //Combo da Unidade de Medida            
            BLLUnidadeDeMedida ubll = new BLLUnidadeDeMedida(cx);
            cbUmed.DataSource = ubll.Localizar("");
            cbUmed.DisplayMember = "umed_nome";
            cbUmed.ValueMember = "umed_cod";
            cbUmed.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbUmed.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        //Validação dos valores numericos métodos KeyPress e Leave
        private void txtValorVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtValorVenda.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void txtValorVenda_Leave(object sender, EventArgs e)
        {
            if (txtValorVenda.Text.Contains(",") == false)
            {
                txtValorVenda.Text += ",00";
            }
            else
            {
                if (txtValorVenda.Text.IndexOf(",") == txtValorVenda.Text.Length - 1)
                {
                    txtValorVenda.Text += "00";
                }
            }
            try
            {
                Double d = Convert.ToDouble(txtValorVenda.Text);
            }
            catch
            {
                txtValorVenda.Text = "0,00";
            }
        }

        private void txtValorPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtValorPago.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void txtValorPago_Leave(object sender, EventArgs e)
        {
            if (txtValorPago.Text.Contains(",") == false)
            {
                txtValorPago.Text += ",00";
            }
            else
            {
                if (txtValorPago.Text.IndexOf(",") == txtValorPago.Text.Length - 1)
                {
                    txtValorPago.Text += "00";
                }
            }
            try
            {
                Double d = Convert.ToDouble(txtValorPago.Text);
            }
            catch
            {
                txtValorPago.Text = "0,00";
            }
        }

        private void txtQtde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtQtde.Text.Contains("."))
                {
                    e.KeyChar = '.';
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void txtQtde_Leave(object sender, EventArgs e)
        {
            if (txtQtde.Text.Contains(".") == false)
            {
                txtQtde.Text += ",00";
            }
            else
            {
                if (txtQtde.Text.IndexOf(".") == txtQtde.Text.Length - 1)
                {
                    txtQtde.Text += "00";
                }
            }
            try
            {
                Double d = Convert.ToDouble(txtQtde.Text);
            }
            catch
            {
                txtQtde.Text = "0.00";
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alteraBotoes(2);
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLProduto bll = new BLLProduto(cx);
                    bll.Excluir(Convert.ToInt32(txtCodigo.Text));
                    this.LimpaTela();
                    this.alteraBotoes(1);
                }
            }
            catch
            {
                MessageBox.Show("Impossivel excluir o registro. \n O registro esta sendo utilizado em outro local.");
                this.alteraBotoes(3);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.alteraBotoes(1);
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            try
            {
                cbSubCategoria.Text = "";
                //Combo da SubCategoria
            
                BLLSubCategoria sbll = new BLLSubCategoria(cx);
                cbSubCategoria.DataSource = sbll.LocalizarPorCategoria((int)cbCategoria.SelectedValue);
                cbSubCategoria.DisplayMember = "scat_nome";
                cbSubCategoria.ValueMember = "scat_cod";
            }
            catch
            {
                //MessageBox.Show("Cadastre uma subcategoria");
            }
        }

        private void btLoFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.ShowDialog();
            if (!string.IsNullOrEmpty(od.FileName)) 
            {
                this.foto = od.FileName;
                pbFoto.Load(this.foto);
            }
        }

        private void btRmFoto_Click(object sender, EventArgs e)
        {
            this.foto = "";
            pbFoto.Image = null;
           
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //leitura dos dados
                ModeloProduto modelo = new ModeloProduto();
                modelo.ProNome = txtNome.Text;
                modelo.ProDescricao = txtDescricao.Text;
                modelo.ProQtde = Convert.ToDouble(txtQtde.Text);
                modelo.ProValorPago = Convert.ToDouble(txtValorPago.Text);
                modelo.ProValorVenda = Convert.ToDouble(txtValorVenda.Text);               
                modelo.UmedCod = Convert.ToInt32(cbUmed.SelectedValue);
                modelo.CatCod = Convert.ToInt32(cbCategoria.SelectedValue);
                modelo.ScatCod = Convert.ToInt32(cbSubCategoria.SelectedValue);      

                
                
                //objeto para gravar os dados no banco
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);

                if (this.operacao == "inserir")
                {
                    //cadastrar um produto
                    modelo.CarregaImagem(this.foto);
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado! Código " + modelo.ProCod.ToString());
                }
                else
                {

                    //alterar um produto
                    modelo.ProCod = Convert.ToInt32(txtCodigo.Text);

                    if (this.foto == "Foto Original")
                    {
                        ModeloProduto mt = bll.CarregaModeloProduto(modelo.ProCod);
                        modelo.ProFoto = mt.ProFoto;
                    }
                    else 
                    {
                        modelo.CarregaImagem(this.foto);
                    }

                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado");
                }
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            FrmConsultaProduto f = new FrmConsultaProduto();
            f.ShowDialog();

            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);

                ModeloProduto modelo = bll.CarregaModeloProduto(f.codigo);

                //Coloca os dados na tela
                txtCodigo.Text = modelo.ProCod.ToString();
                txtDescricao.Text = modelo.ProDescricao;
                txtNome.Text = modelo.ProNome;
                txtQtde.Text = modelo.ProQtde.ToString();
                txtValorPago.Text = modelo.ProValorPago.ToString();
                txtValorVenda.Text = modelo.ProValorVenda.ToString();
                cbCategoria.SelectedValue = modelo.CatCod;
                cbSubCategoria.SelectedValue = modelo.ScatCod;
                cbUmed.SelectedValue = modelo.UmedCod;
                
                //carrega a foto
                try
                {
                    MemoryStream ms = new MemoryStream(modelo.ProFoto);
                    pbFoto.Image = Image.FromStream(ms);
                    this.foto = "Foto Original";
                }
                catch 
                {

                }

                txtQtde_Leave(sender, e);
                txtValorPago_Leave(sender, e);
                txtValorVenda_Leave(sender, e);
                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();        
        }

        private void btAddUmed_Click(object sender, EventArgs e)
        {
            FrmCadastroUnidadeDeMedida f = new FrmCadastroUnidadeDeMedida();
            f.ShowDialog();
            f.Dispose();

            //Combo da Unidade de Medida
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLUnidadeDeMedida ubll = new BLLUnidadeDeMedida(cx);
            cbUmed.DataSource = ubll.Localizar("");
            cbUmed.DisplayMember = "umed_nome";
            cbUmed.ValueMember = "umed_cod";
        }

        private void btAddCat_Click(object sender, EventArgs e)
        {
            FrmCadastroCategoria f = new FrmCadastroCategoria();
            f.ShowDialog();
            f.Dispose();

            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);

            //Combo da Categoria            
            BLLCategoria bll = new BLLCategoria(cx);
            cbCategoria.DataSource = bll.Localizar("");
            cbCategoria.DisplayMember = "cat_nome";
            cbCategoria.ValueMember = "cat_cod";

            try
            {
                //Combo da SubCategoria            
                BLLSubCategoria sbll = new BLLSubCategoria(cx);
                cbSubCategoria.DataSource = sbll.LocalizarPorCategoria((int)cbCategoria.SelectedValue);
                cbSubCategoria.DisplayMember = "scat_nome";
                cbSubCategoria.ValueMember = "scat_cod";
            }
            catch
            {
                //MessageBox.Show("Cadastre uma subcategoria");
            }
        }

        private void btAddSubCat_Click(object sender, EventArgs e)
        {
            FrmCadastroSubCategoria f = new FrmCadastroSubCategoria();
            f.ShowDialog();
            f.Dispose();

            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            
            try
            {
                //Combo da SubCategoria            
                BLLSubCategoria sbll = new BLLSubCategoria(cx);
                cbSubCategoria.DataSource = sbll.LocalizarPorCategoria((int)cbCategoria.SelectedValue);
                cbSubCategoria.DisplayMember = "scat_nome";
                cbSubCategoria.ValueMember = "scat_cod";
            }
            catch
            {
                //MessageBox.Show("Cadastre uma subcategoria");
            }
        }
    }
}
