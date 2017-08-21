namespace Cupons.View
{
    partial class frmRamosAtividade
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
            this.dgvRamos = new System.Windows.Forms.DataGridView();
            this.btnRamoAlterar = new System.Windows.Forms.Button();
            this.btnRamoCadastrar = new System.Windows.Forms.Button();
            this.txtRamo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRamos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRamos
            // 
            this.dgvRamos.AllowUserToAddRows = false;
            this.dgvRamos.AllowUserToDeleteRows = false;
            this.dgvRamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRamos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvRamos.Location = new System.Drawing.Point(12, 32);
            this.dgvRamos.Name = "dgvRamos";
            this.dgvRamos.ReadOnly = true;
            this.dgvRamos.RowHeadersVisible = false;
            this.dgvRamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRamos.Size = new System.Drawing.Size(331, 243);
            this.dgvRamos.TabIndex = 0;
            this.dgvRamos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRamos_CellClick);
            this.dgvRamos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRamos_CellDoubleClick);
            // 
            // btnRamoAlterar
            // 
            this.btnRamoAlterar.Location = new System.Drawing.Point(400, 154);
            this.btnRamoAlterar.Name = "btnRamoAlterar";
            this.btnRamoAlterar.Size = new System.Drawing.Size(116, 38);
            this.btnRamoAlterar.TabIndex = 3;
            this.btnRamoAlterar.Text = "Alterar";
            this.btnRamoAlterar.UseVisualStyleBackColor = true;
            this.btnRamoAlterar.Click += new System.EventHandler(this.btnRamoAlterar_Click);
            // 
            // btnRamoCadastrar
            // 
            this.btnRamoCadastrar.Location = new System.Drawing.Point(400, 110);
            this.btnRamoCadastrar.Name = "btnRamoCadastrar";
            this.btnRamoCadastrar.Size = new System.Drawing.Size(116, 38);
            this.btnRamoCadastrar.TabIndex = 2;
            this.btnRamoCadastrar.Text = "Cadastrar";
            this.btnRamoCadastrar.UseVisualStyleBackColor = true;
            this.btnRamoCadastrar.Click += new System.EventHandler(this.btnRamoCadastrar_Click);
            // 
            // txtRamo
            // 
            this.txtRamo.Location = new System.Drawing.Point(353, 76);
            this.txtRamo.Name = "txtRamo";
            this.txtRamo.Size = new System.Drawing.Size(207, 20);
            this.txtRamo.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(349, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 20);
            this.label12.TabIndex = 40;
            this.label12.Text = "Cadastrar Novo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(349, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 20);
            this.label11.TabIndex = 41;
            this.label11.Text = "Ramo de Atividade:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(235, 20);
            this.label10.TabIndex = 39;
            this.label10.Text = "Ramos de Atividade Cadastrados:";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = global::Cupons.Properties.Resources.Exit;
            this.btnSair.Location = new System.Drawing.Point(400, 198);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(116, 77);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmRamosAtividade
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(572, 289);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dgvRamos);
            this.Controls.Add(this.btnRamoAlterar);
            this.Controls.Add(this.btnRamoCadastrar);
            this.Controls.Add(this.txtRamo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmRamosAtividade";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Ramos de Atividades";
            this.Load += new System.EventHandler(this.frmRamosAtividade_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmRamosAtividade_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRamos;
        private System.Windows.Forms.Button btnRamoAlterar;
        private System.Windows.Forms.Button btnRamoCadastrar;
        private System.Windows.Forms.TextBox txtRamo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSair;
    }
}