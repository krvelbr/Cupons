using Biblioteca;
using Funcoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cupons.View
{
    public partial class frmRamosAtividade : Form
    {
        public frmRamosAtividade()
        {
            InitializeComponent();
        }
        public int indiceRamos = -1;
        public int posRamos = -1;


        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnRamoCadastrar_Click(object sender, EventArgs e)
        {
            if (txtRamo.Text.Trim() != "")
            {
                string user = Biblioteca.Settings.Default.User;
                Banco banco = new Banco();

                try
                {
                    indiceRamos = Convert.ToInt32(banco.InserirRamo(txtRamo.Text, user));

                    //dgvRamos.Rows.Add((indiceRamos), txtRamo.Text.Trim().ToUpper());
                    preencheRamoAtividade();
                    dgvRamos.Update();
                    dgvRamos.Refresh();
                    txtRamo.Clear();
                    txtRamo.Focus();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao tentar gravar o Ramo de Atividade !\n" + ex.Message, "Erro", MessageBoxButtons.OK,
                                       MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    txtRamo.Focus();
                }



            }

        }

        private void btnRamoAlterar_Click(object sender, EventArgs e)
        {
            if (posRamos != -1)
            {
                string user = Biblioteca.Settings.Default.User;
                Banco banco = new Banco();
                string retornoRamo;

                try
                {
                    retornoRamo = banco.AlterarRamo(Convert.ToInt32(dgvRamos.CurrentRow.Cells["Código"].Value.ToString()), txtRamo.Text, user);

                    if (retornoRamo == "Alterado com sucesso")
                    {
                        preencheRamoAtividade();
                        dgvRamos.Update();
                        dgvRamos.Refresh();
                        txtRamo.Clear();
                        txtRamo.Focus();
                        btnRamoAlterar.Enabled = false;
                        btnRamoCadastrar.Enabled = true;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao tentar atualizar o Ramo de Atividade !\n" + ex.Message, "Erro", MessageBoxButtons.OK,
                                       MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    txtRamo.Focus();
                }

            }
        }

        private void frmRamosAtividade_Load(object sender, EventArgs e)
        {
            btnRamoAlterar.Enabled = false;
            preencheRamoAtividade();
            //comeca a preencher as tabs
            dgvRamos.AutoGenerateColumns = false;
            //dgvRamos.ColumnCount = 2;
            dgvRamos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            txtRamo.Focus();
        }

        private void frmRamosAtividade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 13))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
        private void preencheRamoAtividade()
        {
            txtRamo.Clear();

            DataTable Ramos = new DataTable();
            AcessoBancoSql acessoBanco = new AcessoBancoSql();

            Ramos = acessoBanco.ConsultaRamos(CommandType.Text, "Select id as Código, Atividade as Ramo from tblRamosAtividade");

            dgvRamos.DataSource = Ramos;

        }

        private void dgvRamos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            posRamos = dgvRamos.CurrentRow.Index;
            txtRamo.Text = dgvRamos.CurrentRow.Cells["Ramo"].Value.ToString();
            btnRamoAlterar.Enabled = true;
            btnRamoCadastrar.Enabled = false;
            txtRamo.Focus();
        }

        private void dgvRamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posRamos = dgvRamos.CurrentRow.Index;
        }

    }
}
