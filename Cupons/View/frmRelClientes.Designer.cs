namespace Cupons.View
{
    partial class frmRelClientes
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rvClientes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.tblClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tblClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvClientes
            // 
            this.rvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource2.Name = "dsClientes";
            reportDataSource2.Value = this.tblClienteBindingSource;
            this.rvClientes.LocalReport.DataSources.Add(reportDataSource2);
            this.rvClientes.LocalReport.ReportEmbeddedResource = "Cupons.View.repClientes.rdlc";
            this.rvClientes.Location = new System.Drawing.Point(15, 11);
            this.rvClientes.Name = "rvClientes";
            this.rvClientes.Size = new System.Drawing.Size(896, 316);
            this.rvClientes.TabIndex = 0;
            // 
            // btnCarregar
            // 
            this.btnCarregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCarregar.Location = new System.Drawing.Point(837, 329);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(75, 23);
            this.btnCarregar.TabIndex = 3;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Visible = false;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // tblClienteBindingSource
            // 
            this.tblClienteBindingSource.DataSource = typeof(Cupons.Model.tblCliente);
            // 
            // frmRelClientes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(930, 364);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.rvClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRelClientes";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Relatório de Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRelClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblClienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvClientes;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.BindingSource tblClienteBindingSource;
    }
}