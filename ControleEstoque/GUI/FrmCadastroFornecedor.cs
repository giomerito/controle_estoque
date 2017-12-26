using BLL;
using DAL;
using Ferramentas;
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
    public partial class FrmCadastroFornecedor : GUI.FrmModeloDeFormularioDeCadastro
    {
        public FrmCadastroFornecedor()
        {
            InitializeComponent();
        }

        public enum Campo
        {
            CPF = 1,
            CNPJ = 2,
            CEP = 3,
        }

        public void Formatar(Campo Valor, TextBox txtTexto)
        {
            switch (Valor)
            {
                case Campo.CPF:
                    txtTexto.MaxLength = 14;
                    if (txtTexto.Text.Length == 3)
                    {
                        txtTexto.Text = txtTexto.Text + ".";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 7)
                    {
                        txtTexto.Text = txtTexto.Text + ".";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 11)
                    {
                        txtTexto.Text = txtTexto.Text + "-";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    break;
                case Campo.CNPJ:
                    txtTexto.MaxLength = 18;
                    if (txtTexto.Text.Length == 2 || txtTexto.Text.Length == 6)
                    {
                        txtTexto.Text = txtTexto.Text + ".";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 10)
                    {
                        txtTexto.Text = txtTexto.Text + "/";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 15)
                    {
                        txtTexto.Text = txtTexto.Text + "-";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    break;

                case Campo.CEP:
                    txtTexto.MaxLength = 9;
                    if (txtTexto.Text.Length == 5)
                    {
                        txtTexto.Text = txtTexto.Text + "-";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    break;
            }
        }

        public void LimpaTela()
        {
            this.txtCodigo.Clear();
            this.txtNome.Clear();
            this.txtRsocial.Clear();
            this.txtBairro.Clear();
            this.txtCelular.Clear();
            this.txtCep.Clear();
            this.txtCidade.Clear();
            this.txtCnpj.Clear();
            this.txtEmail.Clear();
            this.txtEstado.Clear();
            this.txtNumero.Clear();
            this.txtIe.Clear();
            this.txtTelefone.Clear();
            this.txtRua.Clear();

            this.lbValorIncorreto.Visible = false;
                      
        }
        
        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            
            FrmConsultaFornecedor f = new FrmConsultaFornecedor();
            f.ShowDialog();

            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);

                ModeloFornecedor modelo = bll.CarregaModeloFornecedor(f.codigo);

                txtCodigo.Text = modelo.ForCod.ToString();
                txtNome.Text = modelo.ForNome;
                txtRsocial.Text = modelo.ForRsocial;
                txtCnpj.Text = modelo.ForCnpj;
                txtIe.Text = modelo.ForIe;
                txtCep.Text = modelo.ForCep;
                txtEstado.Text = modelo.ForEstado;
                txtCidade.Text = modelo.ForCidade;
                txtRua.Text = modelo.ForEndereco;
                txtNumero.Text = modelo.ForEndnumero;
                txtBairro.Text = modelo.ForBairro;
                txtEmail.Text = modelo.ForEmail;
                txtTelefone.Text = modelo.ForFone;
                txtCelular.Text = modelo.ForCel;

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
                    BLLFornecedor bll = new BLLFornecedor(cx);
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

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //leitura dos dados
                ModeloFornecedor modelo = new ModeloFornecedor();
                modelo.ForNome = txtNome.Text;
                modelo.ForRsocial = txtRsocial.Text;
                modelo.ForCnpj = txtCnpj.Text;
                modelo.ForIe = txtIe.Text;
                modelo.ForCep = txtCep.Text;
                modelo.ForEstado = txtEstado.Text;
                modelo.ForCidade = txtCidade.Text;
                modelo.ForEndereco = txtRua.Text;
                modelo.ForEndnumero = txtNumero.Text;
                modelo.ForBairro = txtBairro.Text;
                modelo.ForEmail = txtEmail.Text;
                modelo.ForFone = txtTelefone.Text;
                modelo.ForCel = txtCelular.Text;
               
                //objeto para gravar os dados no banco
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);

                if (this.operacao == "inserir")
                {
                    //cadastrar 
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado! Código " + modelo.ForCod.ToString());
                }
                else
                {
                    //alterar 
                    modelo.ForCod = Convert.ToInt32(txtCodigo.Text);
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

        private void FrmCadastroFornecedor_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            this.LimpaTela();
        }

        private void txtCnpj_Leave(object sender, EventArgs e)
        {
            lbValorIncorreto.Visible = false;

            if (Validacao.IsCnpj(txtCnpj.Text) == false)
            {
                lbValorIncorreto.Visible = true;
            }
        }

        private void txtCnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)8)
            {
                Campo edit = Campo.CNPJ;                
                Formatar(edit, txtCnpj);
            }
        }

        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)8)
            {
                Campo edit = Campo.CEP;
                Formatar(edit, txtCep);
            }
        }

        private void txtCep_Leave(object sender, EventArgs e)
        {
            if (Validacao.ValidaCep(txtCep.Text) == false)
            {
                MessageBox.Show("O CEP é inválido");
                txtBairro.Clear();
                txtEstado.Clear();
                txtCidade.Clear();
                txtRua.Clear();
            }
            else
            {
                if (BuscaEndereco.verificaCEP(txtCep.Text) == true)
                {
                    txtBairro.Text = BuscaEndereco.bairro;
                    txtEstado.Text = BuscaEndereco.estado;
                    txtCidade.Text = BuscaEndereco.cidade;
                    txtRua.Text = BuscaEndereco.endereco;
                }
            }
        }
    }
}
