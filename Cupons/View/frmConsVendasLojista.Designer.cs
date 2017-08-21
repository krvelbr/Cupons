namespace Cupons.View
{
    partial class frmConsVendasLojista
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
            this.mskCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultarCNPJ = new System.Windows.Forms.Button();
            this.gbResultado = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblValorVendas = new System.Windows.Forms.Label();
            this.lblCupons = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblClientesUnicos = new System.Windows.Forms.Label();
            this.lblTicketMedio = new System.Windows.Forms.Label();
            this.lblFantasia = new System.Windows.Forms.Label();
            this.gbResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // mskCNPJ
            // 
            this.mskCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.mskCNPJ.Location = new System.Drawing.Point(81, 16);
            this.mskCNPJ.Mask = "00,000,000/0000-00";
            this.mskCNPJ.Name = "mskCNPJ";
            this.mskCNPJ.Size = new System.Drawing.Size(177, 29);
            this.mskCNPJ.TabIndex = 0;
            this.mskCNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "CNPJ:";
            // 
            // btnConsultarCNPJ
            // 
            this.btnConsultarCNPJ.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarCNPJ.Image = global::Cupons.Properties.Resources.btnPesquisar;
            this.btnConsultarCNPJ.Location = new System.Drawing.Point(270, 16);
            this.btnConsultarCNPJ.Name = "btnConsultarCNPJ";
            this.btnConsultarCNPJ.Size = new System.Drawing.Size(33, 28);
            this.btnConsultarCNPJ.TabIndex = 1;
            this.btnConsultarCNPJ.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsultarCNPJ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultarCNPJ.UseVisualStyleBackColor = true;
            this.btnConsultarCNPJ.Click += new System.EventHandler(this.btnConsultarCNPJ_Click);
            // 
            // gbResultado
            // 
            this.gbResultado.Controls.Add(this.lblTicketMedio);
            this.gbResultado.Controls.Add(this.lblClientesUnicos);
            this.gbResultado.Controls.Add(this.lblCupons);
            this.gbResultado.Controls.Add(this.lblValorVendas);
            this.gbResultado.Controls.Add(this.label3);
            this.gbResultado.Controls.Add(this.label5);
            this.gbResultado.Controls.Add(this.label7);
            this.gbResultado.Controls.Add(this.label2);
            this.gbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResultado.Location = new System.Drawing.Point(17, 97);
            this.gbResultado.Name = "gbResultado";
            this.gbResultado.Size = new System.Drawing.Size(335, 169);
            this.gbResultado.TabIndex = 8;
            this.gbResultado.TabStop = false;
            this.gbResultado.Text = "Resultado de Vendas Cadastradas";
            // 
            // btnSair
            // 
            this.btnSair.CausesValidation = false;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = global::Cupons.Properties.Resources.Exit;
            this.btnSair.Location = new System.Drawing.Point(187, 285);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(86, 66);
            this.btnSair.TabIndex = 3;
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
            this.btnLimpar.Location = new System.Drawing.Point(61, 285);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(86, 66);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Valor em Vendas em R$:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Qtde Cupons Fiscais Cadastrados:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ticket Médio R$:";
            // 
            // lblValorVendas
            // 
            this.lblValorVendas.AutoSize = true;
            this.lblValorVendas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblValorVendas.Location = new System.Drawing.Point(182, 28);
            this.lblValorVendas.Name = "lblValorVendas";
            this.lblValorVendas.Size = new System.Drawing.Size(103, 15);
            this.lblValorVendas.TabIndex = 2;
            this.lblValorVendas.Text = "lblValorVendas";
            // 
            // lblCupons
            // 
            this.lblCupons.AutoSize = true;
            this.lblCupons.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCupons.ForeColor = System.Drawing.Color.Navy;
            this.lblCupons.Location = new System.Drawing.Point(241, 60);
            this.lblCupons.Name = "lblCupons";
            this.lblCupons.Size = new System.Drawing.Size(71, 15);
            this.lblCupons.TabIndex = 2;
            this.lblCupons.Text = "lblCupons";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Número de Clientes Únicos:";
            // 
            // lblClientesUnicos
            // 
            this.lblClientesUnicos.AutoSize = true;
            this.lblClientesUnicos.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblClientesUnicos.Location = new System.Drawing.Point(199, 94);
            this.lblClientesUnicos.Name = "lblClientesUnicos";
            this.lblClientesUnicos.Size = new System.Drawing.Size(119, 15);
            this.lblClientesUnicos.TabIndex = 2;
            this.lblClientesUnicos.Text = "lblClientesUnicos";
            // 
            // lblTicketMedio
            // 
            this.lblTicketMedio.AutoSize = true;
            this.lblTicketMedio.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTicketMedio.Location = new System.Drawing.Point(131, 131);
            this.lblTicketMedio.Name = "lblTicketMedio";
            this.lblTicketMedio.Size = new System.Drawing.Size(101, 15);
            this.lblTicketMedio.TabIndex = 2;
            this.lblTicketMedio.Text = "lblTicketMedio";
            // 
            // lblFantasia
            // 
            this.lblFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFantasia.ForeColor = System.Drawing.Color.Red;
            this.lblFantasia.Location = new System.Drawing.Point(11, 53);
            this.lblFantasia.Name = "lblFantasia";
            this.lblFantasia.Size = new System.Drawing.Size(341, 30);
            this.lblFantasia.TabIndex = 2;
            this.lblFantasia.Text = "lblFantasia";
            this.lblFantasia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmConsVendasLojista
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(364, 363);
            this.Controls.Add(this.lblFantasia);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.gbResultado);
            this.Controls.Add(this.btnConsultarCNPJ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mskCNPJ);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmConsVendasLojista";
            this.Text = "Consultar Total de Vendas por Lojista";
            this.Load += new System.EventHandler(this.frmConsVendasLojista_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmConsVendasLojista_KeyPress);
            this.gbResultado.ResumeLayout(false);
            this.gbResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskCNPJ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultarCNPJ;
        private System.Windows.Forms.GroupBox gbResultado;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblTicketMedio;
        private System.Windows.Forms.Label lblClientesUnicos;
        private System.Windows.Forms.Label lblCupons;
        private System.Windows.Forms.Label lblValorVendas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFantasia;
    }
}