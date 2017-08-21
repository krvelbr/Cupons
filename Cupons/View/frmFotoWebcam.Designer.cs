namespace Cupons.View
{
    partial class frmFotoWebcam
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
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnTirarFoto = new System.Windows.Forms.Button();
            this.lblVideoDeviceSelectedForPreview = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picWebPreview = new System.Windows.Forms.PictureBox();
            this.lstVideoDevices = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblfoto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picWebPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(50, 329);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(94, 32);
            this.btnVisualizar.TabIndex = 5;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnTirarFoto
            // 
            this.btnTirarFoto.Enabled = false;
            this.btnTirarFoto.Location = new System.Drawing.Point(180, 329);
            this.btnTirarFoto.Name = "btnTirarFoto";
            this.btnTirarFoto.Size = new System.Drawing.Size(94, 32);
            this.btnTirarFoto.TabIndex = 9;
            this.btnTirarFoto.Text = "Tirar Foto";
            this.btnTirarFoto.UseVisualStyleBackColor = true;
            this.btnTirarFoto.Click += new System.EventHandler(this.btnTirarFoto_Click);
            // 
            // lblVideoDeviceSelectedForPreview
            // 
            this.lblVideoDeviceSelectedForPreview.AutoSize = true;
            this.lblVideoDeviceSelectedForPreview.Location = new System.Drawing.Point(47, 376);
            this.lblVideoDeviceSelectedForPreview.Name = "lblVideoDeviceSelectedForPreview";
            this.lblVideoDeviceSelectedForPreview.Size = new System.Drawing.Size(173, 13);
            this.lblVideoDeviceSelectedForPreview.TabIndex = 10;
            this.lblVideoDeviceSelectedForPreview.Text = "lblVideoDeviceSelectedForPreview";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Selecione o Dispositivo de Captura de Imagem";
            // 
            // picWebPreview
            // 
            this.picWebPreview.Location = new System.Drawing.Point(12, 27);
            this.picWebPreview.Name = "picWebPreview";
            this.picWebPreview.Size = new System.Drawing.Size(300, 240);
            this.picWebPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWebPreview.TabIndex = 13;
            this.picWebPreview.TabStop = false;
            // 
            // lstVideoDevices
            // 
            this.lstVideoDevices.FormattingEnabled = true;
            this.lstVideoDevices.Location = new System.Drawing.Point(50, 302);
            this.lstVideoDevices.Name = "lstVideoDevices";
            this.lstVideoDevices.Size = new System.Drawing.Size(224, 21);
            this.lstVideoDevices.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(80, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Webcam Preview";
            // 
            // lblfoto
            // 
            this.lblfoto.AutoSize = true;
            this.lblfoto.Location = new System.Drawing.Point(47, 397);
            this.lblfoto.Name = "lblfoto";
            this.lblfoto.Size = new System.Drawing.Size(47, 13);
            this.lblfoto.TabIndex = 10;
            this.lblfoto.Text = "labelfoto";
            // 
            // frmFotoWebcam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(325, 438);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstVideoDevices);
            this.Controls.Add(this.picWebPreview);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblfoto);
            this.Controls.Add(this.lblVideoDeviceSelectedForPreview);
            this.Controls.Add(this.btnTirarFoto);
            this.Controls.Add(this.btnVisualizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmFotoWebcam";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Foto pela WebCam";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFotoWebcam_FormClosing);
            this.Load += new System.EventHandler(this.frmFotoWebcam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picWebPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnTirarFoto;
        private System.Windows.Forms.Label lblVideoDeviceSelectedForPreview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picWebPreview;
        private System.Windows.Forms.ComboBox lstVideoDevices;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblfoto;
    }
}