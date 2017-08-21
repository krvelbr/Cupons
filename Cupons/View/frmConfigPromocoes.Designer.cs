namespace Cupons.View
{
    partial class frmConfigPromocoes
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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tabConfig = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mskValorCupom = new System.Windows.Forms.TextBox();
            this.txtLicenca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lsbPrinters = new System.Windows.Forms.ListBox();
            this.lblImpressoraSelecionada = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pnlConfig = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.txtInstancia = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.tabConfig.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.pnlConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = global::Cupons.Properties.Resources.Exit;
            this.btnSair.Location = new System.Drawing.Point(374, 323);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(99, 77);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = global::Cupons.Properties.Resources.propriedades;
            this.btnAlterar.Location = new System.Drawing.Point(251, 323);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(99, 77);
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = global::Cupons.Properties.Resources.Gravar;
            this.btnSalvar.Location = new System.Drawing.Point(128, 323);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(99, 77);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // tabConfig
            // 
            this.tabConfig.Controls.Add(this.tabPage1);
            this.tabConfig.Controls.Add(this.tabPage3);
            this.tabConfig.Controls.Add(this.tabPage4);
            this.tabConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabConfig.Location = new System.Drawing.Point(14, 22);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.SelectedIndex = 0;
            this.tabConfig.Size = new System.Drawing.Size(575, 284);
            this.tabConfig.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.mskValorCupom);
            this.tabPage1.Controls.Add(this.txtLicenca);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(567, 253);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Config. Gerais";
            // 
            // mskValorCupom
            // 
            this.mskValorCupom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.mskValorCupom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskValorCupom.Location = new System.Drawing.Point(158, 15);
            this.mskValorCupom.MaxLength = 5;
            this.mskValorCupom.Name = "mskValorCupom";
            this.mskValorCupom.Size = new System.Drawing.Size(79, 26);
            this.mskValorCupom.TabIndex = 0;
            // 
            // txtLicenca
            // 
            this.txtLicenca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLicenca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLicenca.Location = new System.Drawing.Point(10, 70);
            this.txtLicenca.MaxLength = 60;
            this.txtLicenca.Name = "txtLicenca";
            this.txtLicenca.Size = new System.Drawing.Size(350, 26);
            this.txtLicenca.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Licenciado para:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Valor do Cupom R$:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.lsbPrinters);
            this.tabPage3.Controls.Add(this.lblImpressoraSelecionada);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(567, 253);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Config. Impressora";
            // 
            // lsbPrinters
            // 
            this.lsbPrinters.FormattingEnabled = true;
            this.lsbPrinters.ItemHeight = 18;
            this.lsbPrinters.Location = new System.Drawing.Point(16, 32);
            this.lsbPrinters.Name = "lsbPrinters";
            this.lsbPrinters.Size = new System.Drawing.Size(249, 166);
            this.lsbPrinters.TabIndex = 32;
            this.lsbPrinters.SelectedIndexChanged += new System.EventHandler(this.lsbPrinters_SelectedIndexChanged);
            // 
            // lblImpressoraSelecionada
            // 
            this.lblImpressoraSelecionada.AutoSize = true;
            this.lblImpressoraSelecionada.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpressoraSelecionada.ForeColor = System.Drawing.Color.Red;
            this.lblImpressoraSelecionada.Location = new System.Drawing.Point(12, 225);
            this.lblImpressoraSelecionada.Name = "lblImpressoraSelecionada";
            this.lblImpressoraSelecionada.Size = new System.Drawing.Size(183, 20);
            this.lblImpressoraSelecionada.TabIndex = 31;
            this.lblImpressoraSelecionada.Text = "lblImpressoraSelecionada";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Impressora Selecionada:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Selecione a Impressora";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.pnlConfig);
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(567, 253);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Config. Banco Dados";
            // 
            // pnlConfig
            // 
            this.pnlConfig.Controls.Add(this.label6);
            this.pnlConfig.Controls.Add(this.label5);
            this.pnlConfig.Controls.Add(this.label2);
            this.pnlConfig.Controls.Add(this.label7);
            this.pnlConfig.Controls.Add(this.label3);
            this.pnlConfig.Controls.Add(this.txtSenha);
            this.pnlConfig.Controls.Add(this.txtUser);
            this.pnlConfig.Controls.Add(this.txtBanco);
            this.pnlConfig.Controls.Add(this.txtInstancia);
            this.pnlConfig.Controls.Add(this.txtIP);
            this.pnlConfig.Location = new System.Drawing.Point(14, 16);
            this.pnlConfig.Name = "pnlConfig";
            this.pnlConfig.Size = new System.Drawing.Size(367, 182);
            this.pnlConfig.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Senha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Usuário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do Banco:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nome Instância:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Endereço IP:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(137, 138);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(162, 24);
            this.txtSenha.TabIndex = 4;
            this.txtSenha.Text = "hiper";
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(137, 106);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(162, 24);
            this.txtUser.TabIndex = 3;
            this.txtUser.Text = "sa";
            // 
            // txtBanco
            // 
            this.txtBanco.Location = new System.Drawing.Point(137, 74);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(215, 24);
            this.txtBanco.TabIndex = 2;
            this.txtBanco.Text = "Cupons";
            // 
            // txtInstancia
            // 
            this.txtInstancia.Location = new System.Drawing.Point(137, 42);
            this.txtInstancia.Name = "txtInstancia";
            this.txtInstancia.Size = new System.Drawing.Size(215, 24);
            this.txtInstancia.TabIndex = 1;
            this.txtInstancia.Text = "HIPER";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(137, 10);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(215, 24);
            this.txtIP.TabIndex = 0;
            this.txtIP.Text = "localhost";
            // 
            // frmConfigPromocoes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(593, 409);
            this.Controls.Add(this.tabConfig);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmConfigPromocoes";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configurações do Sistema";
            this.Load += new System.EventHandler(this.frmConfigPromocoes_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmConfigPromocoes_KeyPress);
            this.tabConfig.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.pnlConfig.ResumeLayout(false);
            this.pnlConfig.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TabControl tabConfig;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox mskValorCupom;
        private System.Windows.Forms.TextBox txtLicenca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel pnlConfig;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtBanco;
        private System.Windows.Forms.TextBox txtInstancia;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.ListBox lsbPrinters;
        private System.Windows.Forms.Label lblImpressoraSelecionada;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}