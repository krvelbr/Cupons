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
    public partial class frmSenha : Form
    {
        public string Password { get; set; }
        public string Usuario { get; set; }
        public bool Cancel { get; set; }
        public bool Ok { get; set; }

        public frmSenha()
        {
            InitializeComponent();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancel = true;
            Ok = false;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string cryptosenha = txtSenha.Text.Trim();    // nao vai passar pela funcao de crypto
                                                          //string cryptosenha = Funcoes.Banco.GeraSenha(Usuario, txtSenha.Text);
                                                          ////////////////////////////////// já faz o HASH da possivel senha


            //se o formulario que abriu foi o de configuracoes, vai receber o usuario Promocõe$, ai a senha é o dia e mes + 1978
            if ((Usuario == "Promocoe$" && txtSenha.Text == Password) || cryptosenha == Password)
            {
                Cancel = false;
                Ok = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Senha Incorreta.\nFavor Verificar.", "Erro", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                txtSenha.Clear();
                txtSenha.Focus();
            }

            ////////////////////////////////////
            /*
             if (cryptosenha == Password)
             {
                 Cancel = false;
                 Ok = true;
                 this.Close();
             }
             else  // senha está errada
             {
                 MessageBox.Show("Senha Incorreta.\nFavor Verificar.", "Erro", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                 txtSenha.Clear();
                 txtSenha.Focus();
             }
             */
            ////////////////////////////////////////

        }

        private void frmSenha_Load(object sender, EventArgs e)
        {
            Cancel = true;
            Ok = false;
            txtSenha.Text = "";
        }



        private void picSenha_MouseDown(object sender, MouseEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = false;
        }

        private void picSenha_MouseUp(object sender, MouseEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
        }

        private void frmSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ao pressionar enter vai para proximo campo
            if ((e.KeyChar == 13))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
    }
}
