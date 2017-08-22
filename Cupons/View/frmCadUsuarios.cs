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
    public partial class frmCadUsuarios : Form
    {
        public frmCadUsuarios()
        {
            InitializeComponent();
        }
        public bool sairpressionado = false;
        public DataTable dtUsuarios = new DataTable();
        //public bool existeUser;

        private void frmCadUsuarios_Load(object sender, EventArgs e)
        {
            //  BuscaUsuarios();
        }

        private void frmCadUsuarios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 13))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            sairpressionado = true;
            this.Close();
        }

        private void limparCampos()
        {
            txtUsuario.Clear();
            txtSenha.Clear();
            chkAtivo.Checked = true;
            txtNome.Clear();
            txtEndereco.Clear();
            txtEnderecoNumero.Clear();
            txtEnderecoComplemento.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtUF.Clear();
            mskCEP.Clear();
            mskCelular.Clear();
            mskWhatsapp.Clear();
            //existeUser = false;
            sairpressionado = false;

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void BuscaUsuarios()
        {
            //txtRG.Text = dtCli.Rows[0]["RG"].ToString().Trim();
            //DataTable dtUsuarios = new DataTable();
            Banco banco = new Banco();
            dtUsuarios.Clear();
            dtUsuarios = banco.ConsultaTodosUsuarios();

        }

        private bool ExisteUsuario(string user)
        {
            foreach (DataRow row in dtUsuarios.Rows)
            {
                if (row["Usuario"].ToString() == user)
                    return true;
            }
            return false;
        }

        private void txtUsuario_Validating(object sender, CancelEventArgs e)
        {
            if (txtUsuario.Text.Trim() == "" && sairpressionado == false)
            {
                MessageBox.Show("O nome de Usuário deve ser preenchido.\nNome de Usuário não pode estar em branco ou inválido.", "Aviso");
                txtUsuario.Focus();
            }
            else
            {
                BuscaUsuarios();

                if (ExisteUsuario(txtUsuario.Text) == true)
                {
                    //verifica se o usuario
                    MessageBox.Show("Esse nome de Usuário já existe.\nFavor escolher outro nome de usuário.", "Aviso");
                    limparCampos();
                    txtUsuario.Focus();
                }
            }
        }

        private void picSenha_MouseDown(object sender, MouseEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = false;
        }

        private void picSenha_MouseUp(object sender, MouseEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
        }

        private void txtSenha_Validating(object sender, CancelEventArgs e)
        {
            if (txtSenha.Text.Trim() == "")
            {
                MessageBox.Show("O campo Senha deve ser preenchido.\nA Senha do Usuário não pode estar em branco.", "Aviso");
                txtSenha.Focus();
            }

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() != "" && txtSenha.Text.Trim() != "")
            {

                DialogResult confirm = MessageBox.Show("Deseja Gravar as Informações ?", "Salvar Dados", MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                if (confirm.ToString().ToUpper() == "YES")
                {
                    string retornobanco = "";
                    int id = 0; // se conseguir gravar, retorna com o numero do usuario no banco

                    //////////////////////////////////
                    string cryptosenha = Funcoes.Banco.GeraSenha(txtUsuario.Text, txtSenha.Text);
                    ////////////////////////////////// já faz o HASH da possivel senha

                    Usuario user = new Usuario();
                    user._Usuario = txtUsuario.Text;
                    //user._Senha = cryptosenha;   //grava o hash da senha gerado
                    user._Senha = txtSenha.Text.Trim();
                    user._Ativo = chkAtivo.Checked;
                    user._Nome = txtNome.Text;
                    user._Endereco = txtEndereco.Text;
                    user._EndNumero = txtEnderecoNumero.Text;
                    user._EndComplemento = txtEnderecoComplemento.Text;
                    user._Bairro = txtBairro.Text;
                    user._Cidade = txtCidade.Text;
                    user._UF = txtUF.Text;
                    user._CEP = mskCEP.Text;
                    user._Celular = mskCelular.Text;
                    user._Whatsapp = mskWhatsapp.Text;
                    user._CadastradoPor = Biblioteca.Settings.Default.User;  // usuário logado no sistema;

                    Banco banco = new Banco();
                    retornobanco = banco.InserirUsuario(user);

                    if (int.TryParse(retornobanco, out id) == true)
                    {
                        MessageBox.Show("Usuario Cadastrado com sucesso no Banco de Dados.\n" +
                                        "Cadastrado com ID n°: " + id.ToString().PadLeft(6, '0'), "Sucesso");
                        limparCampos();
                        txtUsuario.Focus();
                    }
                    else
                    {
                        //nao conseguiu converter em numero, então recebeu uma mensagem de erro do banco
                        MessageBox.Show("Houve um erro ao tentar cadastrar o Cliente.\n\n" + retornobanco, "Erro");
                    }

                }
            }
        }


    }
}
