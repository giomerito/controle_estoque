namespace GUI
{
    partial class FrmCadastroFornecedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbValorIncorreto = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.txtIe = new System.Windows.Forms.TextBox();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.txtRsocial = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbRgIe = new System.Windows.Forms.Label();
            this.lbCpfCnpj = new System.Windows.Forms.Label();
            this.lbRsocial = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.txtNumero);
            this.pnDados.Controls.Add(this.label7);
            this.pnDados.Controls.Add(this.lbValorIncorreto);
            this.pnDados.Controls.Add(this.txtCelular);
            this.pnDados.Controls.Add(this.txtTelefone);
            this.pnDados.Controls.Add(this.txtEmail);
            this.pnDados.Controls.Add(this.label11);
            this.pnDados.Controls.Add(this.txtBairro);
            this.pnDados.Controls.Add(this.txtRua);
            this.pnDados.Controls.Add(this.txtCidade);
            this.pnDados.Controls.Add(this.label5);
            this.pnDados.Controls.Add(this.txtEstado);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.txtCep);
            this.pnDados.Controls.Add(this.txtIe);
            this.pnDados.Controls.Add(this.txtCnpj);
            this.pnDados.Controls.Add(this.txtRsocial);
            this.pnDados.Controls.Add(this.txtNome);
            this.pnDados.Controls.Add(this.txtCodigo);
            this.pnDados.Controls.Add(this.label10);
            this.pnDados.Controls.Add(this.label9);
            this.pnDados.Controls.Add(this.label8);
            this.pnDados.Controls.Add(this.label6);
            this.pnDados.Controls.Add(this.lbRgIe);
            this.pnDados.Controls.Add(this.lbCpfCnpj);
            this.pnDados.Controls.Add(this.lbRsocial);
            this.pnDados.Controls.Add(this.lbNome);
            this.pnDados.Controls.Add(this.label1);
            // 
            // btCancelar
            // 
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btLocalizar
            // 
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // btInserir
            // 
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // lbValorIncorreto
            // 
            this.lbValorIncorreto.AutoSize = true;
            this.lbValorIncorreto.ForeColor = System.Drawing.Color.Red;
            this.lbValorIncorreto.Location = new System.Drawing.Point(301, 162);
            this.lbValorIncorreto.Name = "lbValorIncorreto";
            this.lbValorIncorreto.Size = new System.Drawing.Size(76, 13);
            this.lbValorIncorreto.TabIndex = 56;
            this.lbValorIncorreto.Text = "Valor Incorreto";
            this.lbValorIncorreto.Visible = false;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(440, 374);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(309, 20);
            this.txtCelular.TabIndex = 55;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(14, 374);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(289, 20);
            this.txtTelefone.TabIndex = 54;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(334, 326);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(415, 20);
            this.txtEmail.TabIndex = 53;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(331, 310);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "E-mail";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(14, 326);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(289, 20);
            this.txtBairro.TabIndex = 52;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(14, 277);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(585, 20);
            this.txtRua.TabIndex = 50;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(413, 227);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(336, 20);
            this.txtCidade.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(410, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Cidade";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(200, 227);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(193, 20);
            this.txtEstado.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "CEP";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(14, 227);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(165, 20);
            this.txtCep.TabIndex = 44;
            this.txtCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCep_KeyPress);
            this.txtCep.Leave += new System.EventHandler(this.txtCep_Leave);
            // 
            // txtIe
            // 
            this.txtIe.Location = new System.Drawing.Point(413, 178);
            this.txtIe.Name = "txtIe";
            this.txtIe.Size = new System.Drawing.Size(336, 20);
            this.txtIe.TabIndex = 43;
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(14, 178);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(363, 20);
            this.txtCnpj.TabIndex = 42;
            this.txtCnpj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCnpj_KeyPress);
            this.txtCnpj.Leave += new System.EventHandler(this.txtCnpj_Leave);
            // 
            // txtRsocial
            // 
            this.txtRsocial.Location = new System.Drawing.Point(14, 128);
            this.txtRsocial.Name = "txtRsocial";
            this.txtRsocial.Size = new System.Drawing.Size(735, 20);
            this.txtRsocial.TabIndex = 41;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(14, 78);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(735, 20);
            this.txtNome.TabIndex = 40;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(14, 29);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(437, 358);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Celular";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 358);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Telefone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Bairro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Rua";
            // 
            // lbRgIe
            // 
            this.lbRgIe.AutoSize = true;
            this.lbRgIe.Location = new System.Drawing.Point(410, 162);
            this.lbRgIe.Name = "lbRgIe";
            this.lbRgIe.Size = new System.Drawing.Size(17, 13);
            this.lbRgIe.TabIndex = 34;
            this.lbRgIe.Text = "IE";
            // 
            // lbCpfCnpj
            // 
            this.lbCpfCnpj.AutoSize = true;
            this.lbCpfCnpj.Location = new System.Drawing.Point(11, 162);
            this.lbCpfCnpj.Name = "lbCpfCnpj";
            this.lbCpfCnpj.Size = new System.Drawing.Size(34, 13);
            this.lbCpfCnpj.TabIndex = 33;
            this.lbCpfCnpj.Text = "CNPJ";
            // 
            // lbRsocial
            // 
            this.lbRsocial.AutoSize = true;
            this.lbRsocial.Location = new System.Drawing.Point(11, 112);
            this.lbRsocial.Name = "lbRsocial";
            this.lbRsocial.Size = new System.Drawing.Size(70, 13);
            this.lbRsocial.TabIndex = 32;
            this.lbRsocial.Text = "Razão Social";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(11, 62);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 31;
            this.lbNome.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Código";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(623, 277);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(126, 20);
            this.txtNumero.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(620, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 57;
            this.label7.Text = "Número";
            // 
            // FrmCadastroFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Name = "FrmCadastroFornecedor";
            this.Text = "Cadastro de Fornecedor";
            this.Load += new System.EventHandler(this.FrmCadastroFornecedor_Load);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbValorIncorreto;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.TextBox txtIe;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.TextBox txtRsocial;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbRgIe;
        private System.Windows.Forms.Label lbCpfCnpj;
        private System.Windows.Forms.Label lbRsocial;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label7;
    }
}
