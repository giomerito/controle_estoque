namespace GUI
{
    partial class FrmMovimentacaoCompra
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtComCod = new System.Windows.Forms.TextBox();
            this.txtNfiscal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtDataCompra = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalCompra = new System.Windows.Forms.TextBox();
            this.cbTipoPag = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbNParcelas = new System.Windows.Forms.ComboBox();
            this.dtDataIni = new System.Windows.Forms.DateTimePicker();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.ProCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ForNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ForQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProVUnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProVTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.txtForCod = new System.Windows.Forms.TextBox();
            this.btLFor = new System.Windows.Forms.Button();
            this.LFornecedor = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtProCod = new System.Windows.Forms.TextBox();
            this.btLocProd = new System.Windows.Forms.Button();
            this.LProduto = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.dgvParcelas = new System.Windows.Forms.DataGridView();
            this.pco_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pco_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pco_datavecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnFinalizaCompra = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnCancelaParcelas = new System.Windows.Forms.Button();
            this.btnSalvarFinal = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).BeginInit();
            this.pnFinalizaCompra.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDados
            // 
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
            this.pnDados.Controls.Add(this.LFornecedor);
            this.pnDados.Controls.Add(this.btLFor);
            this.pnDados.Controls.Add(this.txtForCod);
            this.pnDados.Controls.Add(this.label6);
            this.pnDados.Controls.Add(this.dgvItens);
            this.pnDados.Controls.Add(this.dtDataIni);
            this.pnDados.Controls.Add(this.cbNParcelas);
            this.pnDados.Controls.Add(this.label5);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.cbTipoPag);
            this.pnDados.Controls.Add(this.txtTotalCompra);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.dtDataCompra);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.txtNfiscal);
            this.pnDados.Controls.Add(this.txtComCod);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // txtComCod
            // 
            this.txtComCod.Enabled = false;
            this.txtComCod.Location = new System.Drawing.Point(12, 33);
            this.txtComCod.Name = "txtComCod";
            this.txtComCod.Size = new System.Drawing.Size(100, 20);
            this.txtComCod.TabIndex = 1;
            // 
            // txtNfiscal
            // 
            this.txtNfiscal.Location = new System.Drawing.Point(137, 33);
            this.txtNfiscal.Name = "txtNfiscal";
            this.txtNfiscal.Size = new System.Drawing.Size(126, 20);
            this.txtNfiscal.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número da Nota Fiscal";
            // 
            // dtDataCompra
            // 
            this.dtDataCompra.Location = new System.Drawing.Point(286, 33);
            this.dtDataCompra.Name = "dtDataCompra";
            this.dtDataCompra.Size = new System.Drawing.Size(229, 20);
            this.dtDataCompra.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(601, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total";
            // 
            // txtTotalCompra
            // 
            this.txtTotalCompra.Enabled = false;
            this.txtTotalCompra.Location = new System.Drawing.Point(604, 379);
            this.txtTotalCompra.Name = "txtTotalCompra";
            this.txtTotalCompra.Size = new System.Drawing.Size(143, 20);
            this.txtTotalCompra.TabIndex = 12;
            // 
            // cbTipoPag
            // 
            this.cbTipoPag.FormattingEnabled = true;
            this.cbTipoPag.Location = new System.Drawing.Point(142, 379);
            this.cbTipoPag.Name = "cbTipoPag";
            this.cbTipoPag.Size = new System.Drawing.Size(121, 21);
            this.cbTipoPag.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo de Pagamento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Número de Parcelas";
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
            this.cbNParcelas.Location = new System.Drawing.Point(12, 379);
            this.cbNParcelas.Name = "cbNParcelas";
            this.cbNParcelas.Size = new System.Drawing.Size(121, 21);
            this.cbNParcelas.TabIndex = 9;
            // 
            // dtDataIni
            // 
            this.dtDataIni.Location = new System.Drawing.Point(272, 380);
            this.dtDataIni.Name = "dtDataIni";
            this.dtDataIni.Size = new System.Drawing.Size(243, 20);
            this.dtDataIni.TabIndex = 11;
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
            this.dgvItens.Location = new System.Drawing.Point(12, 192);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(735, 168);
            this.dgvItens.TabIndex = 12;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Código do Fornecedor";
            // 
            // txtForCod
            // 
            this.txtForCod.Location = new System.Drawing.Point(12, 87);
            this.txtForCod.Name = "txtForCod";
            this.txtForCod.Size = new System.Drawing.Size(109, 20);
            this.txtForCod.TabIndex = 5;
            this.txtForCod.Leave += new System.EventHandler(this.txtForCod_Leave);
            // 
            // btLFor
            // 
            this.btLFor.Location = new System.Drawing.Point(137, 85);
            this.btLFor.Name = "btLFor";
            this.btLFor.Size = new System.Drawing.Size(75, 23);
            this.btLFor.TabIndex = 15;
            this.btLFor.Text = "Localizar";
            this.btLFor.UseVisualStyleBackColor = true;
            this.btLFor.Click += new System.EventHandler(this.btLFor_Click);
            // 
            // LFornecedor
            // 
            this.LFornecedor.AutoSize = true;
            this.LFornecedor.Location = new System.Drawing.Point(221, 90);
            this.LFornecedor.Name = "LFornecedor";
            this.LFornecedor.Size = new System.Drawing.Size(284, 13);
            this.LFornecedor.TabIndex = 16;
            this.LFornecedor.Text = "Informe o código do fornecedor ou click no botão localizar!";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(283, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Data da Compra";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(745, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "_________________________________________________________________________________" +
    "__________________________________________";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(269, 363);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Data inicial do pagamento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Código do produto";
            // 
            // txtProCod
            // 
            this.txtProCod.Location = new System.Drawing.Point(11, 150);
            this.txtProCod.Name = "txtProCod";
            this.txtProCod.Size = new System.Drawing.Size(356, 20);
            this.txtProCod.TabIndex = 6;
            this.txtProCod.Leave += new System.EventHandler(this.txtProCod_Leave);
            // 
            // btLocProd
            // 
            this.btLocProd.Location = new System.Drawing.Point(373, 148);
            this.btLocProd.Name = "btLocProd";
            this.btLocProd.Size = new System.Drawing.Size(75, 23);
            this.btLocProd.TabIndex = 22;
            this.btLocProd.Text = "Localizar";
            this.btLocProd.UseVisualStyleBackColor = true;
            this.btLocProd.Click += new System.EventHandler(this.btLocProd_Click);
            // 
            // LProduto
            // 
            this.LProduto.AutoSize = true;
            this.LProduto.Location = new System.Drawing.Point(115, 131);
            this.LProduto.Name = "LProduto";
            this.LProduto.Size = new System.Drawing.Size(241, 13);
            this.LProduto.TabIndex = 23;
            this.LProduto.Text = "Informe o código do produto ou click em localizar!";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(453, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Quantidade";
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(456, 150);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(100, 20);
            this.txtQtd.TabIndex = 7;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(581, 150);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 8;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(578, 134);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(70, 13);
            this.label.TabIndex = 27;
            this.label.Text = "Valor Unitário";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Itens da compra";
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Location = new System.Drawing.Point(705, 145);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(42, 26);
            this.btAdd.TabIndex = 29;
            this.btAdd.Text = "+";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
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
            this.pnFinalizaCompra.TabIndex = 2;
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
            this.label16.Size = new System.Drawing.Size(84, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "Total da compra";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Parcelas da compra";
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
            this.btnCancelaParcelas.Click += new System.EventHandler(this.button1_Click);
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
            // FrmMovimentacaoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnFinalizaCompra);
            this.Name = "FrmMovimentacaoCompra";
            this.Text = "Movimentação - Compras";
            this.Load += new System.EventHandler(this.FrmMovimentacaoCompra_Load);
            this.Controls.SetChildIndex(this.pnFinalizaCompra, 0);
            this.Controls.SetChildIndex(this.pnBotoes, 0);
            this.Controls.SetChildIndex(this.pnDados, 0);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).EndInit();
            this.pnFinalizaCompra.ResumeLayout(false);
            this.pnFinalizaCompra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LFornecedor;
        private System.Windows.Forms.Button btLFor;
        private System.Windows.Forms.TextBox txtForCod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.DateTimePicker dtDataIni;
        private System.Windows.Forms.ComboBox cbNParcelas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTipoPag;
        private System.Windows.Forms.TextBox txtTotalCompra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtDataCompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNfiscal;
        private System.Windows.Forms.TextBox txtComCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LProduto;
        private System.Windows.Forms.Button btLocProd;
        private System.Windows.Forms.TextBox txtProCod;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ForNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ForQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProVUnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProVTotal;
        private System.Windows.Forms.DataGridView dgvParcelas;
        private System.Windows.Forms.Panel pnFinalizaCompra;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        protected System.Windows.Forms.Button btnCancelaParcelas;
        protected System.Windows.Forms.Button btnSalvarFinal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_datavecto;
        private System.Windows.Forms.Label label17;
    }
}
