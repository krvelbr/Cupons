namespace Cupons.View
{
    partial class frmCadCupons
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mskCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConsultaCPF = new System.Windows.Forms.Button();
            this.grbDadosCF = new System.Windows.Forms.GroupBox();
            this.btnGravarCupom = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.mskDataCupom = new System.Windows.Forms.MaskedTextBox();
            this.lblFantasia = new System.Windows.Forms.Label();
            this.btnConsultaCNPJ = new System.Windows.Forms.Button();
            this.txtValorCupom = new System.Windows.Forms.TextBox();
            this.txtNSU = new System.Windows.Forms.TextBox();
            this.txtNumeroCOO = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.GrbCuponsGerados = new System.Windows.Forms.GroupBox();
            this.dgvCuponsGerados = new System.Windows.Forms.DataGridView();
            this.noCupom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbCuponsFiscaisCadastrados = new System.Windows.Forms.GroupBox();
            this.dgvCuponsFiscais = new System.Windows.Forms.DataGridView();
            this.CNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCupom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COOCUPOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorCOO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NSU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGerarCupons = new System.Windows.Forms.Button();
            this.SaldoCreditos = new System.Windows.Forms.Label();
            this.CuponsGerar = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CuponsGerados = new System.Windows.Forms.Label();
            this.lblCuponsGerar = new System.Windows.Forms.Label();
            this.lblSaldoCreditos = new System.Windows.Forms.Label();
            this.lblTotalCupons = new System.Windows.Forms.Label();
            this.lblCuponsImpressos = new System.Windows.Forms.Label();
            this.lblSaldoTotal = new System.Windows.Forms.Label();
            this.SaldoTotal = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnReimprir = new System.Windows.Forms.Button();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grbDadosCF.SuspendLayout();
            this.GrbCuponsGerados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuponsGerados)).BeginInit();
            this.grbCuponsFiscaisCadastrados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuponsFiscais)).BeginInit();
            this.SuspendLayout();
            // 
            // mskCNPJ
            // 
            this.mskCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mskCNPJ.Location = new System.Drawing.Point(53, 24);
            this.mskCNPJ.Mask = "00,000,000/0000-00";
            this.mskCNPJ.Name = "mskCNPJ";
            this.mskCNPJ.Size = new System.Drawing.Size(154, 26);
            this.mskCNPJ.TabIndex = 1;
            this.mskCNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(5, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "CNPJ:";
            // 
            // mskCPF
            // 
            this.mskCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCPF.Location = new System.Drawing.Point(107, 11);
            this.mskCPF.Mask = "000,000,000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(142, 29);
            this.mskCPF.TabIndex = 1;
            this.mskCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "CPF Cliente:";
            // 
            // btnConsultaCPF
            // 
            this.btnConsultaCPF.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaCPF.Image = global::Cupons.Properties.Resources.btnPesquisar;
            this.btnConsultaCPF.Location = new System.Drawing.Point(261, 11);
            this.btnConsultaCPF.Name = "btnConsultaCPF";
            this.btnConsultaCPF.Size = new System.Drawing.Size(33, 28);
            this.btnConsultaCPF.TabIndex = 2;
            this.btnConsultaCPF.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsultaCPF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultaCPF.UseVisualStyleBackColor = true;
            this.btnConsultaCPF.Click += new System.EventHandler(this.btnConsultaCPF_Click);
            // 
            // grbDadosCF
            // 
            this.grbDadosCF.BackColor = System.Drawing.SystemColors.Control;
            this.grbDadosCF.Controls.Add(this.btnGravarCupom);
            this.grbDadosCF.Controls.Add(this.label18);
            this.grbDadosCF.Controls.Add(this.label4);
            this.grbDadosCF.Controls.Add(this.label3);
            this.grbDadosCF.Controls.Add(this.label17);
            this.grbDadosCF.Controls.Add(this.mskDataCupom);
            this.grbDadosCF.Controls.Add(this.lblFantasia);
            this.grbDadosCF.Controls.Add(this.btnConsultaCNPJ);
            this.grbDadosCF.Controls.Add(this.txtValorCupom);
            this.grbDadosCF.Controls.Add(this.txtNSU);
            this.grbDadosCF.Controls.Add(this.txtNumeroCOO);
            this.grbDadosCF.Controls.Add(this.mskCNPJ);
            this.grbDadosCF.Controls.Add(this.label1);
            this.grbDadosCF.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDadosCF.ForeColor = System.Drawing.Color.Blue;
            this.grbDadosCF.Location = new System.Drawing.Point(4, 57);
            this.grbDadosCF.Name = "grbDadosCF";
            this.grbDadosCF.Size = new System.Drawing.Size(251, 288);
            this.grbDadosCF.TabIndex = 4;
            this.grbDadosCF.TabStop = false;
            this.grbDadosCF.Text = "Dados do Cupom Fiscal";
            // 
            // btnGravarCupom
            // 
            this.btnGravarCupom.ForeColor = System.Drawing.Color.Black;
            this.btnGravarCupom.Location = new System.Drawing.Point(73, 235);
            this.btnGravarCupom.Name = "btnGravarCupom";
            this.btnGravarCupom.Size = new System.Drawing.Size(111, 39);
            this.btnGravarCupom.TabIndex = 12;
            this.btnGravarCupom.Text = "Gravar &Cupom";
            this.btnGravarCupom.UseVisualStyleBackColor = true;
            this.btnGravarCupom.Click += new System.EventHandler(this.btnGravarCupom_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.Control;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(6, 87);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(110, 17);
            this.label18.TabIndex = 4;
            this.label18.Text = "Data da Compra:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(45, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "NSU Rede:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(7, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valor do Cupom:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(2, 120);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(114, 17);
            this.label17.TabIndex = 6;
            this.label17.Text = "Numero da Nota:";
            // 
            // mskDataCupom
            // 
            this.mskDataCupom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDataCupom.Location = new System.Drawing.Point(146, 82);
            this.mskDataCupom.Mask = "00/00/0000";
            this.mskDataCupom.Name = "mskDataCupom";
            this.mskDataCupom.Size = new System.Drawing.Size(99, 26);
            this.mskDataCupom.TabIndex = 5;
            this.mskDataCupom.ValidatingType = typeof(System.DateTime);
            this.mskDataCupom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskDataCupom_KeyPress);
            // 
            // lblFantasia
            // 
            this.lblFantasia.BackColor = System.Drawing.SystemColors.Control;
            this.lblFantasia.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblFantasia.ForeColor = System.Drawing.Color.Black;
            this.lblFantasia.Location = new System.Drawing.Point(8, 54);
            this.lblFantasia.Name = "lblFantasia";
            this.lblFantasia.Size = new System.Drawing.Size(236, 20);
            this.lblFantasia.TabIndex = 3;
            this.lblFantasia.Text = "Fantasia";
            this.lblFantasia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFantasia.Visible = false;
            // 
            // btnConsultaCNPJ
            // 
            this.btnConsultaCNPJ.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaCNPJ.Image = global::Cupons.Properties.Resources.btnPesquisar;
            this.btnConsultaCNPJ.Location = new System.Drawing.Point(212, 22);
            this.btnConsultaCNPJ.Name = "btnConsultaCNPJ";
            this.btnConsultaCNPJ.Size = new System.Drawing.Size(33, 28);
            this.btnConsultaCNPJ.TabIndex = 2;
            this.btnConsultaCNPJ.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsultaCNPJ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultaCNPJ.UseVisualStyleBackColor = true;
            this.btnConsultaCNPJ.Click += new System.EventHandler(this.btnConsultaCNPJ_Click);
            // 
            // txtValorCupom
            // 
            this.txtValorCupom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorCupom.Location = new System.Drawing.Point(118, 148);
            this.txtValorCupom.MaxLength = 7;
            this.txtValorCupom.Name = "txtValorCupom";
            this.txtValorCupom.Size = new System.Drawing.Size(127, 26);
            this.txtValorCupom.TabIndex = 9;
            this.txtValorCupom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorCupom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorCupom_KeyPress);
            // 
            // txtNSU
            // 
            this.txtNSU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNSU.Location = new System.Drawing.Point(118, 181);
            this.txtNSU.MaxLength = 10;
            this.txtNSU.Name = "txtNSU";
            this.txtNSU.Size = new System.Drawing.Size(126, 26);
            this.txtNSU.TabIndex = 11;
            this.txtNSU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNSU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroCOO_KeyPress);
            this.txtNSU.Leave += new System.EventHandler(this.txtNumeroCOO_Leave);
            this.txtNSU.Validating += new System.ComponentModel.CancelEventHandler(this.txtNSU_Validating);
            // 
            // txtNumeroCOO
            // 
            this.txtNumeroCOO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroCOO.Location = new System.Drawing.Point(118, 115);
            this.txtNumeroCOO.MaxLength = 10;
            this.txtNumeroCOO.Name = "txtNumeroCOO";
            this.txtNumeroCOO.Size = new System.Drawing.Size(127, 26);
            this.txtNumeroCOO.TabIndex = 7;
            this.txtNumeroCOO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumeroCOO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroCOO_KeyPress);
            this.txtNumeroCOO.Leave += new System.EventHandler(this.txtNumeroCOO_Leave);
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeCliente.Enabled = false;
            this.txtNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.Location = new System.Drawing.Point(306, 12);
            this.txtNomeCliente.MaxLength = 60;
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(524, 26);
            this.txtNomeCliente.TabIndex = 3;
            // 
            // GrbCuponsGerados
            // 
            this.GrbCuponsGerados.BackColor = System.Drawing.SystemColors.Control;
            this.GrbCuponsGerados.Controls.Add(this.dgvCuponsGerados);
            this.GrbCuponsGerados.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbCuponsGerados.ForeColor = System.Drawing.Color.Blue;
            this.GrbCuponsGerados.Location = new System.Drawing.Point(937, 57);
            this.GrbCuponsGerados.Name = "GrbCuponsGerados";
            this.GrbCuponsGerados.Size = new System.Drawing.Size(210, 319);
            this.GrbCuponsGerados.TabIndex = 8;
            this.GrbCuponsGerados.TabStop = false;
            this.GrbCuponsGerados.Text = "Cupons Promocionais Gerados";
            // 
            // dgvCuponsGerados
            // 
            this.dgvCuponsGerados.AllowUserToAddRows = false;
            this.dgvCuponsGerados.AllowUserToDeleteRows = false;
            this.dgvCuponsGerados.ColumnHeadersHeight = 30;
            this.dgvCuponsGerados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noCupom});
            this.dgvCuponsGerados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCuponsGerados.Location = new System.Drawing.Point(7, 25);
            this.dgvCuponsGerados.Name = "dgvCuponsGerados";
            this.dgvCuponsGerados.RowHeadersVisible = false;
            this.dgvCuponsGerados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCuponsGerados.Size = new System.Drawing.Size(197, 288);
            this.dgvCuponsGerados.TabIndex = 0;
            // 
            // noCupom
            // 
            this.noCupom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.noCupom.FillWeight = 170F;
            this.noCupom.HeaderText = "CUPOM No.";
            this.noCupom.Name = "noCupom";
            // 
            // grbCuponsFiscaisCadastrados
            // 
            this.grbCuponsFiscaisCadastrados.BackColor = System.Drawing.SystemColors.Control;
            this.grbCuponsFiscaisCadastrados.Controls.Add(this.dgvCuponsFiscais);
            this.grbCuponsFiscaisCadastrados.Controls.Add(this.btnGerarCupons);
            this.grbCuponsFiscaisCadastrados.Controls.Add(this.SaldoCreditos);
            this.grbCuponsFiscaisCadastrados.Controls.Add(this.CuponsGerar);
            this.grbCuponsFiscaisCadastrados.Controls.Add(this.label5);
            this.grbCuponsFiscaisCadastrados.Controls.Add(this.CuponsGerados);
            this.grbCuponsFiscaisCadastrados.Controls.Add(this.lblCuponsGerar);
            this.grbCuponsFiscaisCadastrados.Controls.Add(this.lblSaldoCreditos);
            this.grbCuponsFiscaisCadastrados.Controls.Add(this.lblTotalCupons);
            this.grbCuponsFiscaisCadastrados.Controls.Add(this.lblCuponsImpressos);
            this.grbCuponsFiscaisCadastrados.Controls.Add(this.lblSaldoTotal);
            this.grbCuponsFiscaisCadastrados.Controls.Add(this.SaldoTotal);
            this.grbCuponsFiscaisCadastrados.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCuponsFiscaisCadastrados.ForeColor = System.Drawing.Color.SaddleBrown;
            this.grbCuponsFiscaisCadastrados.Location = new System.Drawing.Point(261, 57);
            this.grbCuponsFiscaisCadastrados.Name = "grbCuponsFiscaisCadastrados";
            this.grbCuponsFiscaisCadastrados.Size = new System.Drawing.Size(670, 319);
            this.grbCuponsFiscaisCadastrados.TabIndex = 7;
            this.grbCuponsFiscaisCadastrados.TabStop = false;
            this.grbCuponsFiscaisCadastrados.Text = "Cupons Fiscais Cadastrados";
            // 
            // dgvCuponsFiscais
            // 
            this.dgvCuponsFiscais.AllowUserToAddRows = false;
            this.dgvCuponsFiscais.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCuponsFiscais.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCuponsFiscais.ColumnHeadersHeight = 30;
            this.dgvCuponsFiscais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CNPJ,
            this.DataCupom,
            this.COOCUPOM,
            this.ValorCOO,
            this.NSU});
            this.dgvCuponsFiscais.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCuponsFiscais.Location = new System.Drawing.Point(6, 24);
            this.dgvCuponsFiscais.Name = "dgvCuponsFiscais";
            this.dgvCuponsFiscais.RowHeadersVisible = false;
            this.dgvCuponsFiscais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCuponsFiscais.Size = new System.Drawing.Size(658, 220);
            this.dgvCuponsFiscais.TabIndex = 0;
            this.dgvCuponsFiscais.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCuponsFiscais_CellFormatting);
            // 
            // CNPJ
            // 
            this.CNPJ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.NullValue = null;
            this.CNPJ.DefaultCellStyle = dataGridViewCellStyle2;
            this.CNPJ.HeaderText = "CNPJ";
            this.CNPJ.Name = "CNPJ";
            // 
            // DataCupom
            // 
            this.DataCupom.HeaderText = "Data Cupom";
            this.DataCupom.Name = "DataCupom";
            this.DataCupom.Width = 120;
            // 
            // COOCUPOM
            // 
            this.COOCUPOM.HeaderText = "Número";
            this.COOCUPOM.Name = "COOCUPOM";
            this.COOCUPOM.Width = 115;
            // 
            // ValorCOO
            // 
            this.ValorCOO.HeaderText = "Valor";
            this.ValorCOO.Name = "ValorCOO";
            this.ValorCOO.Width = 130;
            // 
            // NSU
            // 
            this.NSU.HeaderText = "NSU Rede";
            this.NSU.Name = "NSU";
            this.NSU.Width = 115;
            // 
            // btnGerarCupons
            // 
            this.btnGerarCupons.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarCupons.ForeColor = System.Drawing.Color.Black;
            this.btnGerarCupons.Location = new System.Drawing.Point(566, 277);
            this.btnGerarCupons.Name = "btnGerarCupons";
            this.btnGerarCupons.Size = new System.Drawing.Size(98, 29);
            this.btnGerarCupons.TabIndex = 11;
            this.btnGerarCupons.Text = "&Gerar Cupons";
            this.btnGerarCupons.UseVisualStyleBackColor = true;
            this.btnGerarCupons.Visible = false;
            this.btnGerarCupons.Click += new System.EventHandler(this.btnGerarCupons_Click);
            // 
            // SaldoCreditos
            // 
            this.SaldoCreditos.AutoSize = true;
            this.SaldoCreditos.BackColor = System.Drawing.SystemColors.Control;
            this.SaldoCreditos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.SaldoCreditos.ForeColor = System.Drawing.Color.Black;
            this.SaldoCreditos.Location = new System.Drawing.Point(477, 257);
            this.SaldoCreditos.Name = "SaldoCreditos";
            this.SaldoCreditos.Size = new System.Drawing.Size(98, 17);
            this.SaldoCreditos.TabIndex = 5;
            this.SaldoCreditos.Text = "Saldo Creditos:";
            // 
            // CuponsGerar
            // 
            this.CuponsGerar.AutoSize = true;
            this.CuponsGerar.BackColor = System.Drawing.SystemColors.Control;
            this.CuponsGerar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.CuponsGerar.ForeColor = System.Drawing.Color.Black;
            this.CuponsGerar.Location = new System.Drawing.Point(385, 283);
            this.CuponsGerar.Name = "CuponsGerar";
            this.CuponsGerar.Size = new System.Drawing.Size(106, 17);
            this.CuponsGerar.TabIndex = 9;
            this.CuponsGerar.Text = "Cupons a Gerar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(232, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Saldo Total Cupons:";
            // 
            // CuponsGerados
            // 
            this.CuponsGerados.AutoSize = true;
            this.CuponsGerados.BackColor = System.Drawing.SystemColors.Control;
            this.CuponsGerados.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.CuponsGerados.ForeColor = System.Drawing.Color.Black;
            this.CuponsGerados.Location = new System.Drawing.Point(17, 283);
            this.CuponsGerados.Name = "CuponsGerados";
            this.CuponsGerados.Size = new System.Drawing.Size(123, 17);
            this.CuponsGerados.TabIndex = 7;
            this.CuponsGerados.Text = "Cupons Impressos:";
            // 
            // lblCuponsGerar
            // 
            this.lblCuponsGerar.BackColor = System.Drawing.SystemColors.Control;
            this.lblCuponsGerar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCuponsGerar.ForeColor = System.Drawing.Color.Red;
            this.lblCuponsGerar.Location = new System.Drawing.Point(489, 283);
            this.lblCuponsGerar.Name = "lblCuponsGerar";
            this.lblCuponsGerar.Size = new System.Drawing.Size(65, 17);
            this.lblCuponsGerar.TabIndex = 10;
            this.lblCuponsGerar.Text = "lblCuponsGerar";
            // 
            // lblSaldoCreditos
            // 
            this.lblSaldoCreditos.BackColor = System.Drawing.SystemColors.Control;
            this.lblSaldoCreditos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSaldoCreditos.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSaldoCreditos.Location = new System.Drawing.Point(567, 257);
            this.lblSaldoCreditos.Name = "lblSaldoCreditos";
            this.lblSaldoCreditos.Size = new System.Drawing.Size(97, 17);
            this.lblSaldoCreditos.TabIndex = 6;
            this.lblSaldoCreditos.Text = "lblSaldoCreditos";
            this.lblSaldoCreditos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalCupons
            // 
            this.lblTotalCupons.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotalCupons.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTotalCupons.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTotalCupons.Location = new System.Drawing.Point(361, 257);
            this.lblTotalCupons.Name = "lblTotalCupons";
            this.lblTotalCupons.Size = new System.Drawing.Size(67, 17);
            this.lblTotalCupons.TabIndex = 4;
            this.lblTotalCupons.Text = "lblTotalCupons";
            this.lblTotalCupons.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCuponsImpressos
            // 
            this.lblCuponsImpressos.BackColor = System.Drawing.SystemColors.Control;
            this.lblCuponsImpressos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCuponsImpressos.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblCuponsImpressos.Location = new System.Drawing.Point(137, 283);
            this.lblCuponsImpressos.Name = "lblCuponsImpressos";
            this.lblCuponsImpressos.Size = new System.Drawing.Size(64, 17);
            this.lblCuponsImpressos.TabIndex = 8;
            this.lblCuponsImpressos.Text = "lblCuponsImpressos";
            // 
            // lblSaldoTotal
            // 
            this.lblSaldoTotal.AutoSize = true;
            this.lblSaldoTotal.BackColor = System.Drawing.SystemColors.Control;
            this.lblSaldoTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSaldoTotal.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSaldoTotal.Location = new System.Drawing.Point(96, 257);
            this.lblSaldoTotal.Name = "lblSaldoTotal";
            this.lblSaldoTotal.Size = new System.Drawing.Size(84, 17);
            this.lblSaldoTotal.TabIndex = 2;
            this.lblSaldoTotal.Text = "lblSaldoTotal";
            // 
            // SaldoTotal
            // 
            this.SaldoTotal.AutoSize = true;
            this.SaldoTotal.BackColor = System.Drawing.SystemColors.Control;
            this.SaldoTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.SaldoTotal.ForeColor = System.Drawing.Color.Black;
            this.SaldoTotal.Location = new System.Drawing.Point(17, 257);
            this.SaldoTotal.Name = "SaldoTotal";
            this.SaldoTotal.Size = new System.Drawing.Size(77, 17);
            this.SaldoTotal.TabIndex = 1;
            this.SaldoTotal.Text = "Saldo Total:";
            // 
            // btnSair
            // 
            this.btnSair.CausesValidation = false;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = global::Cupons.Properties.Resources.Exit;
            this.btnSair.Location = new System.Drawing.Point(156, 351);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(95, 79);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.CausesValidation = false;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = global::Cupons.Properties.Resources.Limpar;
            this.btnLimpar.Location = new System.Drawing.Point(12, 351);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(95, 79);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnReimprir
            // 
            this.btnReimprir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReimprir.ForeColor = System.Drawing.Color.Black;
            this.btnReimprir.Location = new System.Drawing.Point(937, 384);
            this.btnReimprir.Name = "btnReimprir";
            this.btnReimprir.Size = new System.Drawing.Size(117, 46);
            this.btnReimprir.TabIndex = 10;
            this.btnReimprir.Text = "&Reimprimir Cupom";
            this.btnReimprir.UseVisualStyleBackColor = true;
            this.btnReimprir.Visible = false;
            this.btnReimprir.Click += new System.EventHandler(this.btnReimprir_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSenha.ForeColor = System.Drawing.Color.Red;
            this.lblSenha.Location = new System.Drawing.Point(1093, 384);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(48, 17);
            this.lblSenha.TabIndex = 11;
            this.lblSenha.Text = "Senha:";
            this.lblSenha.Visible = false;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(1060, 404);
            this.txtSenha.MaxLength = 20;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(81, 26);
            this.txtSenha.TabIndex = 12;
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(813, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 46);
            this.button1.TabIndex = 9;
            this.button1.Text = "&Excluir Cupom";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.btnReimprir_Click);
            // 
            // frmCadCupons
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1160, 453);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReimprir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.grbCuponsFiscaisCadastrados);
            this.Controls.Add(this.GrbCuponsGerados);
            this.Controls.Add(this.grbDadosCF);
            this.Controls.Add(this.btnConsultaCPF);
            this.Controls.Add(this.mskCPF);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmCadCupons";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Cupons Fiscais";
            this.Load += new System.EventHandler(this.frmCadCupons_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCadCupons_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmCadCupons_KeyPress);
            this.grbDadosCF.ResumeLayout(false);
            this.grbDadosCF.PerformLayout();
            this.GrbCuponsGerados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuponsGerados)).EndInit();
            this.grbCuponsFiscaisCadastrados.ResumeLayout(false);
            this.grbCuponsFiscaisCadastrados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuponsFiscais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskCNPJ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConsultaCPF;
        private System.Windows.Forms.GroupBox grbDadosCF;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtNumeroCOO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskDataCupom;
        private System.Windows.Forms.TextBox txtValorCupom;
        private System.Windows.Forms.Button btnGravarCupom;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.GroupBox GrbCuponsGerados;
        private System.Windows.Forms.GroupBox grbCuponsFiscaisCadastrados;
        private System.Windows.Forms.Label SaldoTotal;
        private System.Windows.Forms.Button btnGerarCupons;
        private System.Windows.Forms.Label SaldoCreditos;
        private System.Windows.Forms.Label CuponsGerar;
        private System.Windows.Forms.Label CuponsGerados;
        private System.Windows.Forms.Label lblCuponsGerar;
        private System.Windows.Forms.Label lblSaldoCreditos;
        private System.Windows.Forms.Label lblCuponsImpressos;
        private System.Windows.Forms.Label lblSaldoTotal;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridView dgvCuponsFiscais;
        private System.Windows.Forms.Button btnConsultaCNPJ;
        private System.Windows.Forms.DataGridView dgvCuponsGerados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalCupons;
        private System.Windows.Forms.Label lblFantasia;
        private System.Windows.Forms.DataGridViewTextBoxColumn noCupom;
        private System.Windows.Forms.Button btnReimprir;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNSU;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCupom;
        private System.Windows.Forms.DataGridViewTextBoxColumn COOCUPOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorCOO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NSU;
    }
}