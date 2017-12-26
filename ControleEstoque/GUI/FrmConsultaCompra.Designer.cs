namespace GUI
{
    partial class FrmConsultaCompra
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbGeral = new System.Windows.Forms.RadioButton();
            this.rbParcelas = new System.Windows.Forms.RadioButton();
            this.rbData = new System.Windows.Forms.RadioButton();
            this.rbFornecedor = new System.Windows.Forms.RadioButton();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.pnFornecedor = new System.Windows.Forms.Panel();
            this.lbForNome = new System.Windows.Forms.Label();
            this.btLocFornecedor = new System.Windows.Forms.Button();
            this.txtForCod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnData = new System.Windows.Forms.Panel();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btData = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbcDados = new System.Windows.Forms.TabControl();
            this.tpCompra = new System.Windows.Forms.TabPage();
            this.tpItens = new System.Windows.Forms.TabPage();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.tpParcelas = new System.Windows.Forms.TabPage();
            this.dgvParcelas = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.pnFornecedor.SuspendLayout();
            this.pnData.SuspendLayout();
            this.tbcDados.SuspendLayout();
            this.tpCompra.SuspendLayout();
            this.tpItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.tpParcelas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbGeral);
            this.groupBox1.Controls.Add(this.rbParcelas);
            this.groupBox1.Controls.Add(this.rbData);
            this.groupBox1.Controls.Add(this.rbFornecedor);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 46);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta Pelo";
            // 
            // rbGeral
            // 
            this.rbGeral.AutoSize = true;
            this.rbGeral.Checked = true;
            this.rbGeral.Location = new System.Drawing.Point(10, 19);
            this.rbGeral.Name = "rbGeral";
            this.rbGeral.Size = new System.Drawing.Size(113, 17);
            this.rbGeral.TabIndex = 12;
            this.rbGeral.TabStop = true;
            this.rbGeral.Text = "Todas as Compras";
            this.rbGeral.UseVisualStyleBackColor = true;
            this.rbGeral.CheckedChanged += new System.EventHandler(this.rbGeral_CheckedChanged);
            // 
            // rbParcelas
            // 
            this.rbParcelas.AutoSize = true;
            this.rbParcelas.Location = new System.Drawing.Point(637, 19);
            this.rbParcelas.Name = "rbParcelas";
            this.rbParcelas.Size = new System.Drawing.Size(117, 17);
            this.rbParcelas.TabIndex = 11;
            this.rbParcelas.Text = "Parcelas em Aberto";
            this.rbParcelas.UseVisualStyleBackColor = true;
            this.rbParcelas.CheckedChanged += new System.EventHandler(this.rbGeral_CheckedChanged);
            // 
            // rbData
            // 
            this.rbData.AutoSize = true;
            this.rbData.Location = new System.Drawing.Point(442, 19);
            this.rbData.Name = "rbData";
            this.rbData.Size = new System.Drawing.Size(102, 17);
            this.rbData.TabIndex = 10;
            this.rbData.Text = "Data da Compra";
            this.rbData.UseVisualStyleBackColor = true;
            this.rbData.CheckedChanged += new System.EventHandler(this.rbGeral_CheckedChanged);
            // 
            // rbFornecedor
            // 
            this.rbFornecedor.AutoSize = true;
            this.rbFornecedor.Location = new System.Drawing.Point(240, 19);
            this.rbFornecedor.Name = "rbFornecedor";
            this.rbFornecedor.Size = new System.Drawing.Size(79, 17);
            this.rbFornecedor.TabIndex = 9;
            this.rbFornecedor.Text = "Fornecedor";
            this.rbFornecedor.UseVisualStyleBackColor = true;
            this.rbFornecedor.CheckedChanged += new System.EventHandler(this.rbGeral_CheckedChanged);
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.AllowUserToOrderColumns = true;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(6, 6);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(740, 396);
            this.dgvDados.TabIndex = 12;
            this.dgvDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellClick);
            this.dgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
            // 
            // pnFornecedor
            // 
            this.pnFornecedor.Controls.Add(this.lbForNome);
            this.pnFornecedor.Controls.Add(this.btLocFornecedor);
            this.pnFornecedor.Controls.Add(this.txtForCod);
            this.pnFornecedor.Controls.Add(this.label1);
            this.pnFornecedor.Location = new System.Drawing.Point(12, 57);
            this.pnFornecedor.Name = "pnFornecedor";
            this.pnFornecedor.Size = new System.Drawing.Size(760, 47);
            this.pnFornecedor.TabIndex = 14;
            this.pnFornecedor.Visible = false;
            // 
            // lbForNome
            // 
            this.lbForNome.AutoSize = true;
            this.lbForNome.Location = new System.Drawing.Point(196, 4);
            this.lbForNome.Name = "lbForNome";
            this.lbForNome.Size = new System.Drawing.Size(107, 13);
            this.lbForNome.TabIndex = 3;
            this.lbForNome.Text = "Nome do Fornecedor";
            // 
            // btLocFornecedor
            // 
            this.btLocFornecedor.Location = new System.Drawing.Point(196, 18);
            this.btLocFornecedor.Name = "btLocFornecedor";
            this.btLocFornecedor.Size = new System.Drawing.Size(120, 23);
            this.btLocFornecedor.TabIndex = 2;
            this.btLocFornecedor.Text = "Localizar Fornecedor";
            this.btLocFornecedor.UseVisualStyleBackColor = true;
            this.btLocFornecedor.Click += new System.EventHandler(this.btLocFornecedor_Click);
            // 
            // txtForCod
            // 
            this.txtForCod.Enabled = false;
            this.txtForCod.Location = new System.Drawing.Point(10, 20);
            this.txtForCod.Name = "txtForCod";
            this.txtForCod.Size = new System.Drawing.Size(183, 20);
            this.txtForCod.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código do Fornecedor";
            // 
            // pnData
            // 
            this.pnData.Controls.Add(this.dtpFinal);
            this.pnData.Controls.Add(this.dtpInicial);
            this.pnData.Controls.Add(this.label2);
            this.pnData.Controls.Add(this.btData);
            this.pnData.Controls.Add(this.label3);
            this.pnData.Location = new System.Drawing.Point(12, 56);
            this.pnData.Name = "pnData";
            this.pnData.Size = new System.Drawing.Size(760, 53);
            this.pnData.TabIndex = 15;
            this.pnData.Visible = false;
            // 
            // dtpFinal
            // 
            this.dtpFinal.Location = new System.Drawing.Point(325, 25);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(234, 20);
            this.dtpFinal.TabIndex = 5;
            // 
            // dtpInicial
            // 
            this.dtpInicial.Location = new System.Drawing.Point(10, 25);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(245, 20);
            this.dtpInicial.TabIndex = 4;
            this.dtpInicial.Value = new System.DateTime(2016, 7, 13, 16, 23, 3, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Final";
            // 
            // btData
            // 
            this.btData.Location = new System.Drawing.Point(575, 22);
            this.btData.Name = "btData";
            this.btData.Size = new System.Drawing.Size(120, 23);
            this.btData.TabIndex = 2;
            this.btData.Text = "Localizar por data";
            this.btData.UseVisualStyleBackColor = true;
            this.btData.Click += new System.EventHandler(this.btData_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Data Inicial";
            // 
            // tbcDados
            // 
            this.tbcDados.Controls.Add(this.tpCompra);
            this.tbcDados.Controls.Add(this.tpItens);
            this.tbcDados.Controls.Add(this.tpParcelas);
            this.tbcDados.Location = new System.Drawing.Point(12, 115);
            this.tbcDados.Name = "tbcDados";
            this.tbcDados.SelectedIndex = 0;
            this.tbcDados.Size = new System.Drawing.Size(760, 434);
            this.tbcDados.TabIndex = 16;
            // 
            // tpCompra
            // 
            this.tpCompra.Controls.Add(this.dgvDados);
            this.tpCompra.Location = new System.Drawing.Point(4, 22);
            this.tpCompra.Name = "tpCompra";
            this.tpCompra.Padding = new System.Windows.Forms.Padding(3);
            this.tpCompra.Size = new System.Drawing.Size(752, 408);
            this.tpCompra.TabIndex = 0;
            this.tpCompra.Text = "Compras";
            this.tpCompra.UseVisualStyleBackColor = true;
            // 
            // tpItens
            // 
            this.tpItens.Controls.Add(this.dgvItens);
            this.tpItens.Location = new System.Drawing.Point(4, 22);
            this.tpItens.Name = "tpItens";
            this.tpItens.Padding = new System.Windows.Forms.Padding(3);
            this.tpItens.Size = new System.Drawing.Size(752, 408);
            this.tpItens.TabIndex = 1;
            this.tpItens.Text = "Itens da Compra Selecionada";
            this.tpItens.UseVisualStyleBackColor = true;
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Location = new System.Drawing.Point(6, 6);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(740, 396);
            this.dgvItens.TabIndex = 13;
            // 
            // tpParcelas
            // 
            this.tpParcelas.Controls.Add(this.dgvParcelas);
            this.tpParcelas.Location = new System.Drawing.Point(4, 22);
            this.tpParcelas.Name = "tpParcelas";
            this.tpParcelas.Padding = new System.Windows.Forms.Padding(3);
            this.tpParcelas.Size = new System.Drawing.Size(752, 408);
            this.tpParcelas.TabIndex = 2;
            this.tpParcelas.Text = "Parcelas da Compra Selecionada";
            this.tpParcelas.UseVisualStyleBackColor = true;
            // 
            // dgvParcelas
            // 
            this.dgvParcelas.AllowUserToAddRows = false;
            this.dgvParcelas.AllowUserToDeleteRows = false;
            this.dgvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParcelas.Location = new System.Drawing.Point(6, 6);
            this.dgvParcelas.Name = "dgvParcelas";
            this.dgvParcelas.ReadOnly = true;
            this.dgvParcelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParcelas.Size = new System.Drawing.Size(740, 396);
            this.dgvParcelas.TabIndex = 13;
            // 
            // FrmConsultaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tbcDados);
            this.Controls.Add(this.pnFornecedor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnData);
            this.Name = "FrmConsultaCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Compra";
            this.Load += new System.EventHandler(this.FrmConsultaCompra_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.pnFornecedor.ResumeLayout(false);
            this.pnFornecedor.PerformLayout();
            this.pnData.ResumeLayout(false);
            this.pnData.PerformLayout();
            this.tbcDados.ResumeLayout(false);
            this.tpCompra.ResumeLayout(false);
            this.tpItens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.tpParcelas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbData;
        private System.Windows.Forms.RadioButton rbFornecedor;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.RadioButton rbGeral;
        private System.Windows.Forms.RadioButton rbParcelas;
        private System.Windows.Forms.Panel pnFornecedor;
        private System.Windows.Forms.Button btLocFornecedor;
        private System.Windows.Forms.TextBox txtForCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbForNome;
        private System.Windows.Forms.Panel pnData;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.DateTimePicker dtpInicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tbcDados;
        private System.Windows.Forms.TabPage tpCompra;
        private System.Windows.Forms.TabPage tpItens;
        private System.Windows.Forms.TabPage tpParcelas;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.DataGridView dgvParcelas;
    }
}