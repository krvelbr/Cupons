namespace Cupons.View
{
    partial class frmCadCliente
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
            this.components = new System.ComponentModel.Container();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.grbSexo = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEnderecoNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEnderecoComplemento = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.grbContatos = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.mskWhatsapp = new System.Windows.Forms.MaskedTextBox();
            this.mskFoneCelular3 = new System.Windows.Forms.MaskedTextBox();
            this.mskFoneCelular2 = new System.Windows.Forms.MaskedTextBox();
            this.mskFoneCelular1 = new System.Windows.Forms.MaskedTextBox();
            this.mskFoneFixo = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTwitter = new System.Windows.Forms.TextBox();
            this.txtFacebook = new System.Windows.Forms.TextBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.mskNascimento = new System.Windows.Forms.MaskedTextBox();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.btnConsultarNome = new System.Windows.Forms.Button();
            this.btnConsultaDatasNascimento = new System.Windows.Forms.Button();
            this.grbInfo = new System.Windows.Forms.GroupBox();
            this.lblDataCadastro = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCadastradopor = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.grbSexo.SuspendLayout();
            this.grbContatos.SuspendLayout();
            this.grbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // mskCPF
            // 
            this.mskCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCPF.Location = new System.Drawing.Point(9, 22);
            this.mskCPF.Mask = "000,000,000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(153, 29);
            this.mskCPF.TabIndex = 0;
            this.mskCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskCPF.Leave += new System.EventHandler(this.mskCPF_Leave);
            // 
            // txtRG
            // 
            this.txtRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtRG.Location = new System.Drawing.Point(185, 22);
            this.txtRG.MaxLength = 12;
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(204, 29);
            this.txtRG.TabIndex = 1;
            this.txtRG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRG_KeyPress);
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Checked = true;
            this.chkAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAtivo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAtivo.Location = new System.Drawing.Point(661, 21);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(64, 24);
            this.chkAtivo.TabIndex = 3;
            this.chkAtivo.Text = "&Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "CPF:";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "RG:";
            // 
            // picFoto
            // 
            this.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFoto.Image = global::Cupons.Properties.Resources.foto_modelo;
            this.picFoto.InitialImage = global::Cupons.Properties.Resources.foto_modelo;
            this.picFoto.Location = new System.Drawing.Point(754, 3);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(150, 122);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFoto.TabIndex = 20;
            this.picFoto.TabStop = false;
            this.picFoto.Visible = false;
            this.picFoto.Click += new System.EventHandler(this.picFoto_Click);
            // 
            // btnSair
            // 
            this.btnSair.CausesValidation = false;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = global::Cupons.Properties.Resources.Exit;
            this.btnSair.Location = new System.Drawing.Point(453, 413);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(86, 66);
            this.btnSair.TabIndex = 17;
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
            this.btnLimpar.Location = new System.Drawing.Point(303, 413);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(86, 66);
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Image = global::Cupons.Properties.Resources.Gravar;
            this.btnGravar.Location = new System.Drawing.Point(152, 413);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(86, 66);
            this.btnGravar.TabIndex = 15;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGravar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(117, 19);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(87, 21);
            this.rbMasculino.TabIndex = 1;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "&Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Location = new System.Drawing.Point(26, 19);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(82, 21);
            this.rbFeminino.TabIndex = 0;
            this.rbFeminino.TabStop = true;
            this.rbFeminino.Text = "&Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // grbSexo
            // 
            this.grbSexo.Controls.Add(this.rbMasculino);
            this.grbSexo.Controls.Add(this.rbFeminino);
            this.grbSexo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSexo.Location = new System.Drawing.Point(405, 2);
            this.grbSexo.Name = "grbSexo";
            this.grbSexo.Size = new System.Drawing.Size(222, 49);
            this.grbSexo.TabIndex = 2;
            this.grbSexo.TabStop = false;
            this.grbSexo.Text = "Sexo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(9, 74);
            this.txtNome.MaxLength = 60;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(550, 26);
            this.txtNome.TabIndex = 4;
            this.txtNome.Validating += new System.ComponentModel.CancelEventHandler(this.txtNome_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(9, 131);
            this.txtEndereco.MaxLength = 50;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(425, 26);
            this.txtEndereco.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(449, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "N°:";
            // 
            // txtEnderecoNumero
            // 
            this.txtEnderecoNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoNumero.Location = new System.Drawing.Point(453, 131);
            this.txtEnderecoNumero.MaxLength = 8;
            this.txtEnderecoNumero.Name = "txtEnderecoNumero";
            this.txtEnderecoNumero.Size = new System.Drawing.Size(88, 26);
            this.txtEnderecoNumero.TabIndex = 8;
            this.txtEnderecoNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnderecoNumero_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(551, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Complemento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Bairro:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(412, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Cidade:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(803, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "CEP:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(7, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Fone Fixo:";
            // 
            // txtEnderecoComplemento
            // 
            this.txtEnderecoComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEnderecoComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoComplemento.Location = new System.Drawing.Point(555, 131);
            this.txtEnderecoComplemento.MaxLength = 30;
            this.txtEnderecoComplemento.Name = "txtEnderecoComplemento";
            this.txtEnderecoComplemento.Size = new System.Drawing.Size(349, 26);
            this.txtEnderecoComplemento.TabIndex = 9;
            // 
            // txtBairro
            // 
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(9, 178);
            this.txtBairro.MaxLength = 40;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(386, 26);
            this.txtBairro.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(748, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "UF:";
            // 
            // txtCidade
            // 
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(412, 178);
            this.txtCidade.MaxLength = 50;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(321, 26);
            this.txtCidade.TabIndex = 12;
            this.txtCidade.Text = "TERESINA";
            // 
            // txtUF
            // 
            this.txtUF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUF.Location = new System.Drawing.Point(752, 178);
            this.txtUF.MaxLength = 2;
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(34, 26);
            this.txtUF.TabIndex = 13;
            this.txtUF.Text = "PI";
            this.txtUF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUF_KeyPress);
            // 
            // grbContatos
            // 
            this.grbContatos.BackColor = System.Drawing.SystemColors.Control;
            this.grbContatos.Controls.Add(this.label19);
            this.grbContatos.Controls.Add(this.label18);
            this.grbContatos.Controls.Add(this.label20);
            this.grbContatos.Controls.Add(this.label17);
            this.grbContatos.Controls.Add(this.label16);
            this.grbContatos.Controls.Add(this.mskWhatsapp);
            this.grbContatos.Controls.Add(this.mskFoneCelular3);
            this.grbContatos.Controls.Add(this.mskFoneCelular2);
            this.grbContatos.Controls.Add(this.mskFoneCelular1);
            this.grbContatos.Controls.Add(this.mskFoneFixo);
            this.grbContatos.Controls.Add(this.label15);
            this.grbContatos.Controls.Add(this.label14);
            this.grbContatos.Controls.Add(this.label13);
            this.grbContatos.Controls.Add(this.label10);
            this.grbContatos.Controls.Add(this.txtTwitter);
            this.grbContatos.Controls.Add(this.txtFacebook);
            this.grbContatos.Controls.Add(this.txtObservacao);
            this.grbContatos.Controls.Add(this.txtEmail);
            this.grbContatos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbContatos.ForeColor = System.Drawing.Color.Blue;
            this.grbContatos.Location = new System.Drawing.Point(9, 212);
            this.grbContatos.Name = "grbContatos";
            this.grbContatos.Size = new System.Drawing.Size(895, 188);
            this.grbContatos.TabIndex = 14;
            this.grbContatos.TabStop = false;
            this.grbContatos.Text = "Formas de Contato";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(623, 65);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 17);
            this.label19.TabIndex = 16;
            this.label19.Text = "Twitter:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(324, 65);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 17);
            this.label18.TabIndex = 15;
            this.label18.Text = "Facebook:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(17, 140);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(89, 17);
            this.label20.TabIndex = 12;
            this.label20.Text = "Observações:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(8, 65);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 17);
            this.label17.TabIndex = 14;
            this.label17.Text = "Email:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(743, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 17);
            this.label16.TabIndex = 13;
            this.label16.Text = "WhatsApp:";
            // 
            // mskWhatsapp
            // 
            this.mskWhatsapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskWhatsapp.Location = new System.Drawing.Point(744, 37);
            this.mskWhatsapp.Mask = "(99) 90000-0000";
            this.mskWhatsapp.Name = "mskWhatsapp";
            this.mskWhatsapp.Size = new System.Drawing.Size(145, 26);
            this.mskWhatsapp.TabIndex = 4;
            // 
            // mskFoneCelular3
            // 
            this.mskFoneCelular3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskFoneCelular3.Location = new System.Drawing.Point(558, 37);
            this.mskFoneCelular3.Mask = "(99) 90000-0000";
            this.mskFoneCelular3.Name = "mskFoneCelular3";
            this.mskFoneCelular3.Size = new System.Drawing.Size(130, 26);
            this.mskFoneCelular3.TabIndex = 3;
            // 
            // mskFoneCelular2
            // 
            this.mskFoneCelular2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskFoneCelular2.Location = new System.Drawing.Point(372, 37);
            this.mskFoneCelular2.Mask = "(99) 90000-0000";
            this.mskFoneCelular2.Name = "mskFoneCelular2";
            this.mskFoneCelular2.Size = new System.Drawing.Size(130, 26);
            this.mskFoneCelular2.TabIndex = 2;
            // 
            // mskFoneCelular1
            // 
            this.mskFoneCelular1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskFoneCelular1.Location = new System.Drawing.Point(186, 37);
            this.mskFoneCelular1.Mask = "(99) 90000-0000";
            this.mskFoneCelular1.Name = "mskFoneCelular1";
            this.mskFoneCelular1.Size = new System.Drawing.Size(130, 26);
            this.mskFoneCelular1.TabIndex = 1;
            // 
            // mskFoneFixo
            // 
            this.mskFoneFixo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskFoneFixo.Location = new System.Drawing.Point(10, 37);
            this.mskFoneFixo.Mask = "(99) 0000-0000";
            this.mskFoneFixo.Name = "mskFoneFixo";
            this.mskFoneFixo.Size = new System.Drawing.Size(120, 26);
            this.mskFoneFixo.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(555, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 17);
            this.label15.TabIndex = 12;
            this.label15.Text = "Celular 3:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(369, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 17);
            this.label14.TabIndex = 11;
            this.label14.Text = "Celular 2:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(183, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 17);
            this.label13.TabIndex = 10;
            this.label13.Text = "Celular 1:";
            // 
            // txtTwitter
            // 
            this.txtTwitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTwitter.Location = new System.Drawing.Point(626, 84);
            this.txtTwitter.MaxLength = 50;
            this.txtTwitter.Name = "txtTwitter";
            this.txtTwitter.Size = new System.Drawing.Size(263, 26);
            this.txtTwitter.TabIndex = 7;
            // 
            // txtFacebook
            // 
            this.txtFacebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFacebook.Location = new System.Drawing.Point(327, 84);
            this.txtFacebook.MaxLength = 50;
            this.txtFacebook.Name = "txtFacebook";
            this.txtFacebook.Size = new System.Drawing.Size(290, 26);
            this.txtFacebook.TabIndex = 6;
            // 
            // txtObservacao
            // 
            this.txtObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacao.Location = new System.Drawing.Point(111, 119);
            this.txtObservacao.MaxLength = 8000;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(778, 63);
            this.txtObservacao.TabIndex = 17;
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(9, 84);
            this.txtEmail.MaxLength = 35;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(306, 26);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(610, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Data Nasc.:";
            // 
            // mskNascimento
            // 
            this.mskNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskNascimento.Location = new System.Drawing.Point(614, 74);
            this.mskNascimento.Mask = "00/00/0000";
            this.mskNascimento.Name = "mskNascimento";
            this.mskNascimento.Size = new System.Drawing.Size(100, 26);
            this.mskNascimento.TabIndex = 5;
            this.mskNascimento.ValidatingType = typeof(System.DateTime);
            this.mskNascimento.Leave += new System.EventHandler(this.mskNascimento_Leave);
            this.mskNascimento.Validating += new System.ComponentModel.CancelEventHandler(this.mskNascimento_Validating);
            // 
            // mskCEP
            // 
            this.mskCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCEP.Location = new System.Drawing.Point(809, 178);
            this.mskCEP.Mask = "00000-000";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(92, 26);
            this.mskCEP.TabIndex = 6;
            this.mskCEP.Leave += new System.EventHandler(this.mskCEP_Leave);
            // 
            // btnConsultarNome
            // 
            this.btnConsultarNome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarNome.Image = global::Cupons.Properties.Resources.btnPesquisar;
            this.btnConsultarNome.Location = new System.Drawing.Point(562, 73);
            this.btnConsultarNome.Name = "btnConsultarNome";
            this.btnConsultarNome.Size = new System.Drawing.Size(33, 28);
            this.btnConsultarNome.TabIndex = 22;
            this.btnConsultarNome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsultarNome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultarNome.UseVisualStyleBackColor = true;
            this.btnConsultarNome.Visible = false;
            // 
            // btnConsultaDatasNascimento
            // 
            this.btnConsultaDatasNascimento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaDatasNascimento.Image = global::Cupons.Properties.Resources.btnPesquisar;
            this.btnConsultaDatasNascimento.Location = new System.Drawing.Point(716, 73);
            this.btnConsultaDatasNascimento.Name = "btnConsultaDatasNascimento";
            this.btnConsultaDatasNascimento.Size = new System.Drawing.Size(33, 28);
            this.btnConsultaDatasNascimento.TabIndex = 24;
            this.btnConsultaDatasNascimento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsultaDatasNascimento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultaDatasNascimento.UseVisualStyleBackColor = true;
            this.btnConsultaDatasNascimento.Visible = false;
            // 
            // grbInfo
            // 
            this.grbInfo.Controls.Add(this.lblDataCadastro);
            this.grbInfo.Controls.Add(this.lblID);
            this.grbInfo.Controls.Add(this.lblCadastradopor);
            this.grbInfo.Controls.Add(this.label25);
            this.grbInfo.Controls.Add(this.label22);
            this.grbInfo.Controls.Add(this.label21);
            this.grbInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInfo.Location = new System.Drawing.Point(614, 400);
            this.grbInfo.Name = "grbInfo";
            this.grbInfo.Size = new System.Drawing.Size(290, 79);
            this.grbInfo.TabIndex = 18;
            this.grbInfo.TabStop = false;
            this.grbInfo.Text = "Informações";
            this.grbInfo.Visible = false;
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.AutoSize = true;
            this.lblDataCadastro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCadastro.ForeColor = System.Drawing.Color.White;
            this.lblDataCadastro.Location = new System.Drawing.Point(109, 46);
            this.lblDataCadastro.Name = "lblDataCadastro";
            this.lblDataCadastro.Size = new System.Drawing.Size(95, 15);
            this.lblDataCadastro.TabIndex = 5;
            this.lblDataCadastro.Text = "DatadeCadastro";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(109, 16);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(84, 15);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "CodigoCliente";
            // 
            // lblCadastradopor
            // 
            this.lblCadastradopor.AutoSize = true;
            this.lblCadastradopor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastradopor.ForeColor = System.Drawing.Color.White;
            this.lblCadastradopor.Location = new System.Drawing.Point(109, 31);
            this.lblCadastradopor.Name = "lblCadastradopor";
            this.lblCadastradopor.Size = new System.Drawing.Size(87, 15);
            this.lblCadastradopor.TabIndex = 3;
            this.lblCadastradopor.Text = "CadastradoPor";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(21, 16);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(89, 15);
            this.label25.TabIndex = 0;
            this.label25.Text = "Código Cliente:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(10, 46);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(100, 15);
            this.label22.TabIndex = 4;
            this.label22.Text = "Data de Cadastro:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(16, 31);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(94, 15);
            this.label21.TabIndex = 2;
            this.label21.Text = "Cadastrado  Por:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(412, 157);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(60, 20);
            this.label24.TabIndex = 28;
            this.label24.Text = "Cidade:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(803, 157);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(39, 20);
            this.label26.TabIndex = 31;
            this.label26.Text = "CEP:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(748, 157);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(32, 20);
            this.label27.TabIndex = 30;
            this.label27.Text = "UF:";
            // 
            // frmCadCliente
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(916, 493);
            this.Controls.Add(this.grbInfo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.grbContatos);
            this.Controls.Add(this.grbSexo);
            this.Controls.Add(this.picFoto);
            this.Controls.Add(this.mskNascimento);
            this.Controls.Add(this.mskCPF);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.mskCEP);
            this.Controls.Add(this.btnConsultaDatasNascimento);
            this.Controls.Add(this.btnConsultarNome);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.txtEnderecoNumero);
            this.Controls.Add(this.txtEnderecoComplemento);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.chkAtivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmCadCliente";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.frmCadCliente_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmCadCliente_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.grbSexo.ResumeLayout(false);
            this.grbSexo.PerformLayout();
            this.grbContatos.ResumeLayout(false);
            this.grbContatos.PerformLayout();
            this.grbInfo.ResumeLayout(false);
            this.grbInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbSexo;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFeminino;
        private System.Windows.Forms.TextBox txtEnderecoNumero;
        private System.Windows.Forms.TextBox txtEnderecoComplemento;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox grbContatos;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox mskWhatsapp;
        private System.Windows.Forms.MaskedTextBox mskFoneCelular3;
        private System.Windows.Forms.MaskedTextBox mskFoneCelular2;
        private System.Windows.Forms.MaskedTextBox mskFoneCelular1;
        private System.Windows.Forms.MaskedTextBox mskFoneFixo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTwitter;
        private System.Windows.Forms.TextBox txtFacebook;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox mskNascimento;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Button btnConsultarNome;
        private System.Windows.Forms.Button btnConsultaDatasNascimento;
        private System.Windows.Forms.GroupBox grbInfo;
        private System.Windows.Forms.Label lblDataCadastro;
        private System.Windows.Forms.Label lblCadastradopor;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label24;
    }
}