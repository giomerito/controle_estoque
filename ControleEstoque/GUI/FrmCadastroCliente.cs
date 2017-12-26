using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Ferramentas;
using Modelo;
using DAL;
using BLL;

namespace GUI
{
    public partial class FrmCadastroCliente : GUI.FrmModeloDeFormularioDeCadastro
    {
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

        public FrmCadastroCliente()
        {
            InitializeComponent();
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
            this.txtCpfCnpj.Clear();
            this.txtEmail.Clear();
            this.txtEstado.Clear();
            this.txtNumero.Clear();
            this.txtRgIe.Clear();
            this.txtTelefone.Clear();
            this.txtRua.Clear();

            this.rbFisica.Checked = true;
            this.lbValorIncorreto.Visible = false;
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alteraBotoes(2);
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            FrmConsultaCliente f = new FrmConsultaCliente();
            f.ShowDialog();

            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);

                ModeloCliente modelo = bll.CarregaModeloCliente(f.codigo);

                txtCodigo.Text = modelo.CliCod.ToString();
                txtNome.Text = modelo.CliNome;
                txtRsocial.Text = modelo.CliRsocial;
                txtCpfCnpj.Text = modelo.CliCpfCnpj;
                txtRgIe.Text = modelo.CliRgIe;
                txtCep.Text = modelo.CliCep;
                txtEstado.Text = modelo.CliEstado;
                txtCidade.Text = modelo.CliCidade;
                txtRua.Text = modelo.CliEndereco;
                txtNumero.Text = modelo.CliEndnumero;
                txtBairro.Text = modelo.CliBairro;
                txtEmail.Text = modelo.CliEmail;
                txtTelefone.Text = modelo.CliFone;
                txtCelular.Text = modelo.CliCel;

                if (modelo.CliTipo == "Fisica")
                {
                    rbFisica.Checked = true;
                }
                else
                {
                    rbJuridica.Checked = true;
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

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLCliente bll = new BLLCliente(cx);
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
                ModeloCliente modelo = new ModeloCliente();
                modelo.CliNome = txtNome.Text;
                modelo.CliRsocial = txtRsocial.Text;
                modelo.CliCpfCnpj = txtCpfCnpj.Text;
                modelo.CliRgIe = txtRgIe.Text;
                modelo.CliCep = txtCep.Text;
                modelo.CliEstado = txtEstado.Text;
                modelo.CliCidade = txtCidade.Text;
                modelo.CliEndereco = txtRua.Text;
                modelo.CliEndnumero = txtNumero.Text;
                modelo.CliBairro = txtBairro.Text;
                modelo.CliEmail = txtEmail.Text;
                modelo.CliFone = txtTelefone.Text;
                modelo.CliCel = txtCelular.Text;
                //modelo.CliTipo = rbTipo.
                if (rbFisica.Checked == true)
                {
                    modelo.CliTipo = "Fisica"; // fisica
                    modelo.CliRsocial = "";
                }
                else 
                {
                    modelo.CliTipo = "Juridica"; // juridica
                }
                //objeto para gravar os dados no banco
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);

                if (this.operacao == "inserir")
                {
                    //cadastrar uma categoria
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado! Código "+modelo.CliCod.ToString());
                }
                else
                {
                    //alterar uma categoria
                    modelo.CliCod = Convert.ToInt32(txtCodigo.Text);
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

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            this.LimpaTela();

            
        }

        private void FrmCadastroCliente_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
        }

        private void rbFisica_CheckedChanged(object sender, EventArgs e)
        {
            if(rbFisica.Checked == true)
            {
                lbRsocial.Visible = false;
                txtRsocial.Visible = false;
                lbCpfCnpj.Text = "CPF";
                lbRgIe.Text = "RG";
            }
            else
            {
                lbRsocial.Visible = true;
                txtRsocial.Visible = true;
                lbCpfCnpj.Text = "CNPJ";
                lbRgIe.Text = "IE";
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
         

        private void txtCpfCnpj_Leave(object sender, EventArgs e)
        {
            lbValorIncorreto.Visible = false;

            if (rbFisica.Checked == true)
            {
                //cpf
                if (Validacao.IsCpf(txtCpfCnpj.Text) == false) 
                {
                    lbValorIncorreto.Visible = true;
                }
            }
            else 
            {
                //cnpj
                if (Validacao.IsCnpj(txtCpfCnpj.Text) == false)
                {
                    lbValorIncorreto.Visible = true;
                }
            }
        }

        private void txtCpfCnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)8)
            {
                Campo edit = Campo.CPF;
                if (rbFisica.Checked == false) edit = Campo.CNPJ;
                Formatar(edit, txtCpfCnpj);
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
    }
}
