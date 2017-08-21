namespace Cupons.View
{
    partial class frmValidadorQrCode
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblcpf = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblcupom = new System.Windows.Forms.Label();
            this.lbldata = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxCameraSource = new System.Windows.Forms.ComboBox();
            this.picWebPreview = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnDecode = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnFechar = new System.Windows.Forms.Button();
            this.painelDados = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picWebPreview)).BeginInit();
            this.painelDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "CPF Cliente:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nome do Cliente:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Número do Cupom:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Data e Hora Geração:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblcpf.Location = new System.Drawing.Point(154, 8);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(30, 20);
            this.lblcpf.TabIndex = 15;
            this.lblcpf.Text = "cpf";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblnome.Location = new System.Drawing.Point(154, 40);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(48, 20);
            this.lblnome.TabIndex = 15;
            this.lblnome.Text = "nome";
            // 
            // lblcupom
            // 
            this.lblcupom.AutoSize = true;
            this.lblcupom.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcupom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblcupom.Location = new System.Drawing.Point(154, 70);
            this.lblcupom.Name = "lblcupom";
            this.lblcupom.Size = new System.Drawing.Size(56, 20);
            this.lblcupom.TabIndex = 15;
            this.lblcupom.Text = "cupom";
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbldata.Location = new System.Drawing.Point(154, 102);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(39, 20);
            this.lbldata.TabIndex = 15;
            this.lbldata.Text = "data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(80, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 18);
            this.label6.TabIndex = 26;
            this.label6.Text = "Webcam Preview";
            // 
            // comboBoxCameraSource
            // 
            this.comboBoxCameraSource.FormattingEnabled = true;
            this.comboBoxCameraSource.Location = new System.Drawing.Point(340, 48);
            this.comboBoxCameraSource.Name = "comboBoxCameraSource";
            this.comboBoxCameraSource.Size = new System.Drawing.Size(224, 21);
            this.comboBoxCameraSource.TabIndex = 25;
            // 
            // picWebPreview
            // 
            this.picWebPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picWebPreview.Location = new System.Drawing.Point(12, 28);
            this.picWebPreview.Name = "picWebPreview";
            this.picWebPreview.Size = new System.Drawing.Size(300, 240);
            this.picWebPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWebPreview.TabIndex = 24;
            this.picWebPreview.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(227, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Selecione o Dispositivo de Captura de Imagem";
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(340, 75);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(94, 32);
            this.btnVisualizar.TabIndex = 21;
            this.btnVisualizar.Text = "Iniciar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(470, 75);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(94, 32);
            this.btnDecode.TabIndex = 21;
            this.btnDecode.Text = "Decodificar";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnFechar
            // 
            this.btnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFechar.Location = new System.Drawing.Point(340, 113);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(224, 32);
            this.btnFechar.TabIndex = 21;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // painelDados
            // 
            this.painelDados.Controls.Add(this.label4);
            this.painelDados.Controls.Add(this.label2);
            this.painelDados.Controls.Add(this.lblcpf);
            this.painelDados.Controls.Add(this.lblnome);
            this.painelDados.Controls.Add(this.lblcupom);
            this.painelDados.Controls.Add(this.lbldata);
            this.painelDados.Controls.Add(this.label1);
            this.painelDados.Controls.Add(this.label3);
            this.painelDados.Location = new System.Drawing.Point(12, 274);
            this.painelDados.Name = "painelDados";
            this.painelDados.Size = new System.Drawing.Size(598, 134);
            this.painelDados.TabIndex = 27;
            // 
            // frmValidadorQrCode
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnFechar;
            this.ClientSize = new System.Drawing.Size(613, 414);
            this.Controls.Add(this.painelDados);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxCameraSource);
            this.Controls.Add(this.picWebPreview);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnVisualizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmValidadorQrCode";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Validador do QrCode";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmValidadorQrCode_FormClosing);
            this.Load += new System.EventHandler(this.frmValidadorQrCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picWebPreview)).EndInit();
            this.painelDados.ResumeLayout(false);
            this.painelDados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblcupom;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxCameraSource;
        private System.Windows.Forms.PictureBox picWebPreview;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel painelDados;
    }
}