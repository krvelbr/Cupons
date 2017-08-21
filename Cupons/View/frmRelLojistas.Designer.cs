namespace Cupons.View
{
    partial class frmRelLojistas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rvLojistas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.tblLojistaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tblLojistaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvLojistas
            // 
            this.rvLojistas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "dsLojistas";
            reportDataSource1.Value = this.tblLojistaBindingSource;
            this.rvLojistas.LocalReport.DataSources.Add(reportDataSource1);
            this.rvLojistas.LocalReport.ReportEmbeddedResource = "Cupons.View.repLojistas.rdlc";
            this.rvLojistas.Location = new System.Drawing.Point(15, 11);
            this.rvLojistas.Name = "rvLojistas";
            this.rvLojistas.Size = new System.Drawing.Size(896, 316);
            this.rvLojistas.TabIndex = 0;
            // 
            // btnCarregar
            // 
            this.btnCarregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCarregar.Location = new System.Drawing.Point(836, 333);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(75, 23);
            this.btnCarregar.TabIndex = 3;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Visible = false;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // tblLojistaBindingSource
            // 
            this.tblLojistaBindingSource.DataSource = typeof(Cupons.Model.tblLojista);
            // 
            // frmRelLojistas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(930, 360);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.rvLojistas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRelLojistas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Lojistas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRelLojistas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblLojistaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvLojistas;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.BindingSource tblLojistaBindingSource;
    }
}