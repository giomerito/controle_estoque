namespace GUI
{
    partial class FrmMovimentacaoVenda
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
            this.btAdd = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.LProduto = new System.Windows.Forms.Label();
            this.btLocProd = new System.Windows.Forms.Button();
            this.txtProCod = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LCliente = new System.Windows.Forms.Label();
            this.btLocCli = new System.Windows.Forms.Button();
            this.txtCliCod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.ProCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ForNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ForQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProVUnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProVTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtDataIni = new System.Windows.Forms.DateTimePicker();
            this.cbNParcelas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTipoPag = new System.Windows.Forms.ComboBox();
            this.txtTotalVenda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtDataVenda = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNfiscal = new System.Windows.Forms.TextBox();
            this.txtVenCod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbVendaAvista = new System.Windows.Forms.CheckBox();
            this.pnFinalizaCompra = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnCancelaParcelas = new System.Windows.Forms.Button();
            this.btnSalvarFinal = new System.Windows.Forms.Button();
            this.dgvParcelas = new System.Windows.Forms.DataGridView();
            this.pco_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pco_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pco_datavecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label15 = new System.Windows.Forms.Label();
            this.labVenda = new System.Windows.Forms.Label();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.pnFinalizaCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.labVenda);
            this.pnDados.Controls.Add(this.cbVendaAvista);
            this.pnDados.Controls.Add(this.btAdd);
            this.pnDados.Controls.Add(this.label12);
            this.pnDados.Controls.Add(this.label);
            this.pnDados.Controls.Add(this.txtValor);
            this.pnDados.Controls.Add(this.txtQtd);
            this.pnDados.Controls.Add(this.label11);
            this.pnDados.Controls.Add(this.LProduto);
            this.pnDados.Controls.Add(this.btLocProd);
            this.pnDados.Controls.Add(this.txtProCod);
            this.pnDados.Controls.Add(this.label10);
            this.pnDados.Controls.Add(this.label9);
            this.pnDados.Controls.Add(this.label7);
            this.pnDados.Controls.Add(this.label8);
            this.pnDados.Controls.Add(this.LCliente);
            this.pnDados.Controls.Add(this.btLocCli);
            this.pnDados.Controls.Add(this.txtCliCod);
            this.pnDados.Controls.Add(this.label6);
            this.pnDados.Controls.Add(this.dgvItens);
            this.pnDados.Controls.Add(this.dtDataIni);
            this.pnDados.Controls.Add(this.cbNParcelas);
            this.pnDados.Controls.Add(this.label5);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.cbTipoPag);
            this.pnDados.Controls.Add(this.txtTotalVenda);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.dtDataVenda);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.txtNfiscal);
            this.pnDados.Controls.Add(this.txtVenCod);
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
            this.btExcluir.Text = "Cancelar Venda";
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Visible = false;
            // 
            // btLocalizar
            // 
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // btInserir
            // 
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Location = new System.Drawing.Point(704, 143);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(42, 23);
            this.btAdd.TabIndex = 59;
            this.btAdd.Text = "+";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 58;
            this.label12.Text = "Itens da compra";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(577, 129);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(70, 13);
            this.label.TabIndex = 57;
            this.label.Text = "Valor Unitário";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(580, 145);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 40;
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(455, 145);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(100, 20);
            this.txtQtd.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(452, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 56;
            this.label11.Text = "Quantidade";
            // 
            // LProduto
            // 
            this.LProduto.AutoSize = true;
            this.LProduto.Location = new System.Drawing.Point(115, 126);
            this.LProduto.Name = "LProduto";
            this.LProduto.Size = new System.Drawing.Size(241, 13);
            this.LProduto.TabIndex = 55;
            this.LProduto.Text = "Informe o código do produto ou click em localizar!";
            // 
            // btLocProd
            // 
            this.btLocProd.Location = new System.Drawing.Point(118, 143);
            this.btLocProd.Name = "btLocProd";
            this.btLocProd.Size = new System.Drawing.Size(75, 23);
            this.btLocProd.TabIndex = 54;
            this.btLocProd.Text = "Localizar";
            this.btLocProd.UseVisualStyleBackColor = true;
            this.btLocProd.Click += new System.EventHandler(this.btLocProd_Click);
            // 
            // txtProCod
            // 
            this.txtProCod.Location = new System.Drawing.Point(10, 145);
            this.txtProCod.Name = "txtProCod";
            this.txtProCod.Size = new System.Drawing.Size(88, 20);
            this.txtProCod.TabIndex = 37;
            this.txtProCod.Leave += new System.EventHandler(this.txtProCod_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "Código do produto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(268, 358);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "Data inicial do pagamento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(745, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "_________________________________________________________________________________" +
    "__________________________________________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(282, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Data da Venda";
            // 
            // LCliente
            // 
            this.LCliente.AutoSize = true;
            this.LCliente.Location = new System.Drawing.Point(220, 85);
            this.LCliente.Name = "LCliente";
            this.LCliente.Size = new System.Drawing.Size(284, 13);
            this.LCliente.TabIndex = 49;
            this.LCliente.Text = "Informe o código do fornecedor ou click no botão localizar!";
            // 
            // btLocCli
            // 
            this.btLocCli.Location = new System.Drawing.Point(136, 80);
            this.btLocCli.Name = "btLocCli";
            this.btLocCli.Size = new System.Drawing.Size(75, 23);
            this.btLocCli.TabIndex = 48;
            this.btLocCli.Text = "Localizar";
            this.btLocCli.UseVisualStyleBackColor = true;
            this.btLocCli.Click += new System.EventHandler(this.btLocCli_Click);
            // 
            // txtCliCod
            // 
            this.txtCliCod.Location = new System.Drawing.Point(11, 82);
            this.txtCliCod.Name = "txtCliCod";
            this.txtCliCod.Size = new System.Drawing.Size(109, 20);
            this.txtCliCod.TabIndex = 35;
            this.txtCliCod.Leave += new System.EventHandler(this.txtCliCod_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Código do Cliente";
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProCod,
            this.ForNome,
            this.ForQtd,
            this.ProVUnd,
            this.ProVTotal});
            this.dgvItens.Location = new System.Drawing.Point(11, 187);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(735, 168);
            this.dgvItens.TabIndex = 46;
            this.dgvItens.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItens_CellDoubleClick);
            // 
            // ProCod
            // 
            this.ProCod.HeaderText = "Código";
            this.ProCod.Name = "ProCod";
            this.ProCod.ReadOnly = true;
            this.ProCod.Width = 60;
            // 
            // ForNome
            // 
            this.ForNome.HeaderText = "Nome";
            this.ForNome.Name = "ForNome";
            this.ForNome.ReadOnly = true;
            this.ForNome.Width = 320;
            // 
            // ForQtd
            // 
            this.ForQtd.HeaderText = "Quantidade";
            this.ForQtd.Name = "ForQtd";
            this.ForQtd.ReadOnly = true;
            // 
            // ProVUnd
            // 
            this.ProVUnd.HeaderText = "Valor Unitário";
            this.ProVUnd.Name = "ProVUnd";
            this.ProVUnd.ReadOnly = true;
            // 
            // ProVTotal
            // 
            this.ProVTotal.HeaderText = "ValorTotal";
            this.ProVTotal.Name = "ProVTotal";
            this.ProVTotal.ReadOnly = true;
            this.ProVTotal.Width = 110;
            // 
            // dtDataIni
            // 
            this.dtDataIni.Location = new System.Drawing.Point(271, 375);
            this.dtDataIni.Name = "dtDataIni";
            this.dtDataIni.Size = new System.Drawing.Size(233, 20);
            this.dtDataIni.TabIndex = 44;
            // 
            // cbNParcelas
            // 
            this.cbNParcelas.FormattingEnabled = true;
            this.cbNParcelas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbNParcelas.Location = new System.Drawing.Point(11, 374);
            this.cbNParcelas.Name = "cbNParcelas";
            this.cbNParcelas.Size = new System.Drawing.Size(121, 21);
            this.cbNParcelas.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Número de Parcelas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Tipo de Pagamento";
            // 
            // cbTipoPag
            // 
            this.cbTipoPag.FormattingEnabled = true;
            this.cbTipoPag.Location = new System.Drawing.Point(141, 374);
            this.cbTipoPag.Name = "cbTipoPag";
            this.cbTipoPag.Size = new System.Drawing.Size(121, 21);
            this.cbTipoPag.TabIndex = 43;
            // 
            // txtTotalVenda
            // 
            this.txtTotalVenda.Enabled = false;
            this.txtTotalVenda.Location = new System.Drawing.Point(603, 374);
            this.txtTotalVenda.Name = "txtTotalVenda";
            this.txtTotalVenda.Size = new System.Drawing.Size(143, 20);
            this.txtTotalVenda.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(600, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Total";
            // 
            // dtDataVenda
            // 
            this.dtDataVenda.Location = new System.Drawing.Point(285, 28);
            this.dtDataVenda.Name = "dtDataVenda";
            this.dtDataVenda.Size = new System.Drawing.Size(229, 20);
            this.dtDataVenda.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Número da Nota Fiscal";
            // 
            // txtNfiscal
            // 
            this.txtNfiscal.Location = new System.Drawing.Point(136, 28);
            this.txtNfiscal.Name = "txtNfiscal";
            this.txtNfiscal.Size = new System.Drawing.Size(126, 20);
            this.txtNfiscal.TabIndex = 32;
            // 
            // txtVenCod
            // 
            this.txtVenCod.Enabled = false;
            this.txtVenCod.Location = new System.Drawing.Point(11, 28);
            this.txtVenCod.Name = "txtVenCod";
            this.txtVenCod.Size = new System.Drawing.Size(100, 20);
            this.txtVenCod.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Código";
            // 
            // cbVendaAvista
            // 
            this.cbVendaAvista.AutoSize = true;
            this.cbVendaAvista.Location = new System.Drawing.Point(506, 377);
            this.cbVendaAvista.Name = "cbVendaAvista";
            this.cbVendaAvista.Size = new System.Drawing.Size(91, 17);
            this.cbVendaAvista.TabIndex = 60;
            this.cbVendaAvista.Text = "Venda a vista";
            this.cbVendaAvista.UseVisualStyleBackColor = true;
            this.cbVendaAvista.CheckedChanged += new System.EventHandler(this.cbVendaAvista_CheckedChanged);
            // 
            // pnFinalizaCompra
            // 
            this.pnFinalizaCompra.Controls.Add(this.label17);
            this.pnFinalizaCompra.Controls.Add(this.lbTotal);
            this.pnFinalizaCompra.Controls.Add(this.label16);
            this.pnFinalizaCompra.Controls.Add(this.label14);
            this.pnFinalizaCompra.Controls.Add(this.label13);
            this.pnFinalizaCompra.Controls.Add(this.btnCancelaParcelas);
            this.pnFinalizaCompra.Controls.Add(this.btnSalvarFinal);
            this.pnFinalizaCompra.Controls.Add(this.dgvParcelas);
            this.pnFinalizaCompra.Controls.Add(this.label15);
            this.pnFinalizaCompra.Location = new System.Drawing.Point(12, 12);
            this.pnFinalizaCompra.Name = "pnFinalizaCompra";
            this.pnFinalizaCompra.Size = new System.Drawing.Size(760, 537);
            this.pnFinalizaCompra.TabIndex = 3;
            this.pnFinalizaCompra.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(645, 393);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(21, 13);
            this.label17.TabIndex = 22;
            this.label17.Text = "R$";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(672, 393);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(28, 13);
            this.lbTotal.TabIndex = 21;
            this.lbTotal.Text = "0,00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(550, 393);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "Total da venda";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Parcelas da venda";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Dados do pagamento";
            // 
            // btnCancelaParcelas
            // 
            this.btnCancelaParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelaParcelas.Image = global::GUI.Properties.Resources.Cancelar;
            this.btnCancelaParcelas.Location = new System.Drawing.Point(648, 430);
            this.btnCancelaParcelas.Name = "btnCancelaParcelas";
            this.btnCancelaParcelas.Size = new System.Drawing.Size(90, 90);
            this.btnCancelaParcelas.TabIndex = 7;
            this.btnCancelaParcelas.Text = "Cancelar";
            this.btnCancelaParcelas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelaParcelas.UseVisualStyleBackColor = true;
            this.btnCancelaParcelas.Click += new System.EventHandler(this.btnCancelaParcelas_Click);
            // 
            // btnSalvarFinal
            // 
            this.btnSalvarFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarFinal.Image = global::GUI.Properties.Resources.Salvar1_fw;
            this.btnSalvarFinal.Location = new System.Drawing.Point(534, 430);
            this.btnSalvarFinal.Name = "btnSalvarFinal";
            this.btnSalvarFinal.Size = new System.Drawing.Size(90, 90);
            this.btnSalvarFinal.TabIndex = 6;
            this.btnSalvarFinal.Text = "Salvar";
            this.btnSalvarFinal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvarFinal.UseVisualStyleBackColor = true;
            this.btnSalvarFinal.Click += new System.EventHandler(this.btnSalvarFinal_Click);
            // 
            // dgvParcelas
            // 
            this.dgvParcelas.AllowUserToAddRows = false;
            this.dgvParcelas.AllowUserToDeleteRows = false;
            this.dgvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pco_cod,
            this.pco_valor,
            this.pco_datavecto});
            this.dgvParcelas.Location = new System.Drawing.Point(15, 71);
            this.dgvParcelas.Name = "dgvParcelas";
            this.dgvParcelas.ReadOnly = true;
            this.dgvParcelas.Size = new System.Drawing.Size(723, 305);
            this.dgvParcelas.TabIndex = 0;
            // 
            // pco_cod
            // 
            this.pco_cod.HeaderText = "Parcela";
            this.pco_cod.Name = "pco_cod";
            this.pco_cod.ReadOnly = true;
            // 
            // pco_valor
            // 
            this.pco_valor.HeaderText = "Valor da parcela";
            this.pco_valor.Name = "pco_valor";
            this.pco_valor.ReadOnly = true;
            this.pco_valor.Width = 150;
            // 
            // pco_datavecto
            // 
            this.pco_datavecto.HeaderText = "Data do vencimento";
            this.pco_datavecto.Name = "pco_datavecto";
            this.pco_datavecto.ReadOnly = true;
            this.pco_datavecto.Width = 163;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(565, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "_________________________________________________________________________________" +
    "____________";
            // 
            // labVenda
            // 
            this.labVenda.AutoSize = true;
            this.labVenda.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labVenda.ForeColor = System.Drawing.Color.Red;
            this.labVenda.Location = new System.Drawing.Point(138, 273);
            this.labVenda.Name = "labVenda";
            this.labVenda.Size = new System.Drawing.Size(444, 63);
            this.labVenda.TabIndex = 61;
            this.labVenda.Text = "Venda cancelada";
            this.labVenda.Visible = false;
            // 
            // FrmMovimentacaoVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnFinalizaCompra);
            this.Name = "FrmMovimentacaoVenda";
            this.Text = "Movimentação - Formulário de Venda";
            this.Load += new System.EventHandler(this.FrmMovimentacaoVenda_Load);
            this.Controls.SetChildIndex(this.pnFinalizaCompra, 0);
            this.Controls.SetChildIndex(this.pnDados, 0);
            this.Controls.SetChildIndex(this.pnBotoes, 0);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.pnFinalizaCompra.ResumeLayout(false);
            this.pnFinalizaCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LProduto;
        private System.Windows.Forms.Button btLocProd;
        private System.Windows.Forms.TextBox txtProCod;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LCliente;
        private System.Windows.Forms.Button btLocCli;
        private System.Windows.Forms.TextBox txtCliCod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ForNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ForQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProVUnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProVTotal;
        private System.Windows.Forms.DateTimePicker dtDataIni;
        private System.Windows.Forms.ComboBox cbNParcelas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTipoPag;
        private System.Windows.Forms.TextBox txtTotalVenda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtDataVenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNfiscal;
        private System.Windows.Forms.TextBox txtVenCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbVendaAvista;
        private System.Windows.Forms.Panel pnFinalizaCompra;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        protected System.Windows.Forms.Button btnCancelaParcelas;
        protected System.Windows.Forms.Button btnSalvarFinal;
        private System.Windows.Forms.DataGridView dgvParcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_datavecto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labVenda;
    }
}
