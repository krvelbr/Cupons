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
    public partial class frmLogin : Form
    {
        string retUser = "";
        //bool alteraUser;


        public String User
        {
            get { return retUser; }
            set { retUser = value; }
        }

        public Boolean alteraUser { get; set; }

        /*public Boolean alteraUser
        {
            get { return alteraUser; }
            set { alteraUser = value; }
        }
        */

        public frmLogin()
        {
            InitializeComponent();

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPass.Text = "";
            txtUser.Focus();
        }

        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //////////////////////////////////
            //string cryptosenha = Funcoes.Banco.GeraSenha(txtUser.Text, txtPass.Text);
            ////////////////////////////////// já faz o HASH da possivel senha
            string senha_txt = txtPass.Text;

            if (!txtUser.ToString().Trim().Equals(""))  // se nao estiver vazio
            {
                Banco login = new Banco();
                DataTable dtlogin = new DataTable();
                dtlogin = login.LoginUser(txtUser.Text);
                if (dtlogin == null || dtlogin.Rows.Count == 0) //verifica se datatable esta nulo ou vazio
                {
                    MessageBox.Show("Usuário Inexistente.\nVerifique e informe os dados corretos.", "Aviso");
                    txtPass.Text = "";
                    txtUser.Focus();
                }
                else
                {
                    string retId = "";
                    string retUser = "";
                    string retPass = "";
                    retId = dtlogin.Rows[0]["id"].ToString().Trim();
                    retUser = dtlogin.Rows[0]["Usuario"].ToString().Trim();
                    retPass = dtlogin.Rows[0]["Senha"].ToString().Trim();
                    // Convert.ToBoolean(dtlogin.Rows[0]["Ativo"]);    // ---- verifica se esta ativo ou nao
                    if (Convert.ToBoolean(dtlogin.Rows[0]["Ativo"]) == false)   //se for falso esta inativo
                    {
                        MessageBox.Show("Usuário Desativado do Sistema.\nEste usuário não possui permissão para Utilizar o Sistema.", "Aviso");
                        txtPass.Text = "";
                        txtUser.Focus();
                    }
                    else
                    {
                        //if (retPass != cryptosenha)  //se a senha de retorno for diferente da senha digitada
                        if (retPass != senha_txt)
                        {
                            MessageBox.Show("Usuário ou Senha Incorreta.\nFavor verificar informações.", "Aviso");
                            txtPass.Text = "";
                            txtUser.Focus();
                        }
                        else //se chegou aqui é porque o usuario e a senha conferem
                        {
                            // Properties.Settings.Default.User = txtUser;
                            User = retUser;
                            this.Close();   //fecha o form
                        }
                    }

                }

            }
        }

        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 13))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (alteraUser == false)
            {
                Application.Exit();
            }
            else
            {
                User = Biblioteca.Settings.Default.User;
                this.Close();
            }
        }

        
    }
}
