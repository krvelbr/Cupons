using Funcoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cupons.View
{
    public partial class frmAcessoBanco : Form
    {
        public frmAcessoBanco()
        {
            InitializeComponent();
        }

        public bool Config { get; set; }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        bool vazio = true;
        public DataTable dtConfig = new DataTable();

        private void frmAcessoBanco_Load(object sender, EventArgs e)
        {
            //btnOk.Enabled = false;
            inicializa();

            if (vazio == true) //se estiver vazio
            {
                //    MessageBox.Show("Não foi possível conectar ao Banco de Dados.\nVerifique as configurações de Acesso !", "Erro", MessageBoxButtons.OK,
                //       MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                btnSair.Focus();
            }
            else   // se nao estiver vazio
            {
                txtIP.Focus();
                btnOk.Enabled = true;
            }

        }


        private void inicializa()
        {
            try
            {
                vazio = verificaConfig("SELECT * FROM tblConfig");  //executa esse comando para verificar se tem algo na tabela
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível conectar ao Banco de Dados.\nVerifique as configurações de Acesso !\n" + ex.Message, "Erro", MessageBoxButtons.OK,
                   MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                this.Focus();
                btnSair.Focus();
            }

        }

        private bool verificaConfig(string executacomando)
        {
            Banco BD = new Banco();
            dtConfig.Clear();
            dtConfig = BD.ConsultaConfig(CommandType.Text, executacomando);

            if (dtConfig != null && dtConfig.Rows.Count > 0) //verifica se datatable esta nulo ou vazio
            {
                txtIP.Text = dtConfig.Rows[0]["IP"].ToString().Trim();
                txtInstancia.Text = dtConfig.Rows[0]["Instancia"].ToString().Trim();
                txtBanco.Text = dtConfig.Rows[0]["NomeBanco"].ToString().Trim();
                txtUser.Text = dtConfig.Rows[0]["Usuario"].ToString().Trim();
                txtSenha.Text = dtConfig.Rows[0]["Senha"].ToString().Trim();
                return false;
            }
            else
            {
                txtIP.Text = "LocalHost,5010";
                txtInstancia.Text = "SQLEXPRESS";
                txtBanco.Text = "Cupons";
                txtUser.Text = "sa";
                txtSenha.Text = "solution";

                MessageBox.Show("Não existe configuração de Conexão ao Banco de Dados.\nFavor configurar uma conexão de acesso.", "Erro", MessageBoxButtons.OK,
                   MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                txtIP.Focus();
                return true;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(txtIP.Text) || !String.IsNullOrEmpty(txtBanco.Text) || !String.IsNullOrEmpty(txtInstancia.Text) || !String.IsNullOrEmpty(txtUser.Text) || !String.IsNullOrEmpty(txtSenha.Text))
            {
                Biblioteca.AcessoBancoSql.Config info = new Biblioteca.AcessoBancoSql.Config();
                //int virg = txtIP.Text.IndexOf(',');
                string[] campos = txtIP.Text.Split(',');
                //foreach (string campo in campos)
                //{
                info.serverName = campos[0].ToString();
                info.serverPort = campos[1].ToString();
                //}
                info.dataBase = txtBanco.Text;
                info.serverInstance = txtInstancia.Text;
                info.userName = txtUser.Text;
                info.passWord = txtSenha.Text;
                Biblioteca.AcessoBancoSql.SaveXML.SaveData(info, "configCupons.xml");




                //string _conex = String.Format(@"Data Source={0}\{1}; Initial Catalog={2}; User ID={3}; Password={4}", txtIP.Text, txtInstancia.Text, txtBanco.Text, txtUser.Text, txtSenha.Text);
                //Biblioteca.Settings.Default.stringConnection = _conex;
                // string x = Biblioteca.Settings.Default.stringConnection;
                //Biblioteca.Settings.Default.Save();
                //Biblioteca.Settings.Default.Upgrade();
                

                Banco BD = new Banco();
                dtConfig.Clear();
                try
                {
                    dtConfig = BD.ConsultaConfig(CommandType.Text, "UPDATE tblConfig SET IP= '" + txtIP.Text +
                         "', Instancia='" + txtInstancia.Text + "', NomeBanco= '" + txtBanco.Text +
                         "', Usuario='" + txtUser.Text + "', Senha='" + txtSenha.Text + "' WHERE id = 1");

                    MessageBox.Show("Dados de acesso ao Banco gravados com sucesso.\n\nO Sistema deverá ser fechado para receber as informações.\nFavor Entrar novamente.", "Aviso", MessageBoxButtons.OK,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                    Config = true; //define o campo config que vai retornar para o formulario anterior que esta ok.
                    //Application.Exit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível alterar os parâmetros no Banco de Dados. O Erro foi: \n\n" + ex.Message + "\n\nAo pressionar OK o sistema tentará criar as configurações no Banco de Dados.", "Erro", MessageBoxButtons.OK,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    Config = false;
                }

                if (Config == false)
                {
                    try
                    {
                        String query = "INSERT INTO tblConfig (id,IP,Instancia,NomeBanco,Usuario,Senha) VALUES ";
                        query += "(1, '" + txtIP.Text + "', '" + txtInstancia.Text + "', '" + txtBanco.Text + "', '" + txtUser.Text + "', '" + txtSenha.Text + "')";

                        dtConfig = BD.ConsultaConfig(CommandType.Text, query);

                        MessageBox.Show("Dados de acesso ao Banco gravados com sucesso.\n\nO Sistema será fechado para receber as informações.\nFavor Entrar novamente.", "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        //Biblioteca.Settings.Default.stringConnection = String.Format(@"Data Source= {0}\{1}; Initial Catalog= {2}; User ID= {3}; Password= {4}", txtIP.Text, txtInstancia.Text, txtBanco.Text, txtUser.Text, txtSenha.Text);
                        //Biblioteca.Settings.Default.Save();
                        Config = true; //define o campo config que vai retornar para o formulario anterior que esta ok.
                     
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possível Incluir os parâmetros no Banco de Dados. O Erro foi: \n\n" + ex.Message + "\n\n" + ex.StackTrace + "\n\nEntre em contato com o Suporte.", "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        Config = false;
                    }
                }

                //  else
                //  {
                //      MessageBox.Show("Favor Preencher os campos corretamente.\nTodos os campos devem ser preenchidos.", "Erro", MessageBoxButtons.OK,
                //         MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                //  }
            }

        }
        private void txtBanco_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ao pressionar enter vai para proximo campo
            if ((e.KeyChar == 13))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void frmAcessoBanco_Activated(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Focus();
            txtIP.Focus();
        }
    }
}
