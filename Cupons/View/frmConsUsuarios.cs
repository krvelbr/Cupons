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
    public partial class frmConsUsuarios : Form
    {
        public frmConsUsuarios()
        {
            InitializeComponent();
        }
        public DataTable dtUsuarios = new DataTable();
        public string senhaatual;
        public string novasenha;
        public bool altera = false;
        public bool senhaAlterada = false;

        private void frmConsUsuarios_Load(object sender, EventArgs e)
        {
            limparCampos();

            txtUsuario.Focus();
            btnSalvar.Location = new Point(18, 361);
            btnSalvar.Visible = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
            txtUsuario.Focus();
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

            altera = false;
            senhaAlterada = false;
            novasenha = "";
            senhaatual = "";
            PainelUsuarios.Enabled = false;
            PainelTopo.Visible = false;
            PainelTopo.Enabled = false;
            PainelTopo2.Enabled = false;
            PainelTopo2.Visible = false;
            grbInfo.Visible = false;
            btnAlterar.Enabled = false;
            txtUsuario.Enabled = true;
            btnConsultarUsuario.Enabled = true;
            btnSalvar.Visible = false;
            btnAlterar.Visible = true;
            //txtUsuario.Focus();

            //txtSenha.Enabled = false;     // campo senha desabilitado

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultarUsuario_Click(object sender, EventArgs e)
        {
            //verificar se o final do campo possui '%' para fazer busca parcial e abrir nova tela
            if (txtUsuario.Text.Trim().EndsWith("%"))
            {
                // chama form que mostra varios registros num datatable para selecionar
            }
            else
            {
                ConsultaUser();
                if (dtUsuarios != null && dtUsuarios.Rows.Count > 0) //verifica se datatable esta nulo ou vazio
                {
                    PreencheForm();
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado.\nFavor Verificar.", "Erro", MessageBoxButtons.OK,
                       MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    txtUsuario.Focus();
                }
            }
        }

        private void ConsultaUser()
        {
            Banco banco = new Banco();
            dtUsuarios.Clear();
            dtUsuarios = banco.ConsultaUsuarioUnico(txtUsuario.Text);

        }

        public void PreencheForm()
        {
            senhaatual = dtUsuarios.Rows[0]["Senha"].ToString().Trim();
            txtNome.Text = dtUsuarios.Rows[0]["Nome"].ToString().Trim();
            txtEndereco.Text = dtUsuarios.Rows[0]["Endereco"].ToString().Trim();
            txtEnderecoNumero.Text = dtUsuarios.Rows[0]["EnderecoNumero"].ToString().Trim();
            txtEnderecoComplemento.Text = dtUsuarios.Rows[0]["EnderecoComplemento"].ToString().Trim();
            txtBairro.Text = dtUsuarios.Rows[0]["Bairro"].ToString().Trim();
            txtCidade.Text = dtUsuarios.Rows[0]["Cidade"].ToString().Trim();
            txtUF.Text = dtUsuarios.Rows[0]["Estado"].ToString().Trim();
            mskCEP.Text = dtUsuarios.Rows[0]["CEP"].ToString().Trim();
            mskCelular.Text = dtUsuarios.Rows[0]["Celular"].ToString().Trim();
            mskWhatsapp.Text = dtUsuarios.Rows[0]["Whatsapp"].ToString().Trim();

            lblDataCadastro.Text = dtUsuarios.Rows[0]["DataCadastro"].ToString().Trim();
            lblCadastradopor.Text = dtUsuarios.Rows[0]["CadastradoPor"].ToString().Trim();
            lblDataAlteracao.Text = dtUsuarios.Rows[0]["DataAlteracao"].ToString().Trim();
            lblAlteradoPor.Text = dtUsuarios.Rows[0]["AlteradoPor"].ToString().Trim();
            chkAtivo.Checked = Convert.ToBoolean(dtUsuarios.Rows[0]["Ativo"].ToString());
            //cli._Nascimento = DateTime.ParseExact(mskNascimento.Text.ToString(), "d/M/yyyy", System.Globalization.CultureInfo.InvariantCulture);

            PainelTopo2.Visible = true;   //mostra se ta ativo ou nao
            grbInfo.Visible = true;
            btnAlterar.Enabled = true;
        }

        private void frmConsUsuarios_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ao pressionar enter vai para proximo campo
            if ((e.KeyChar == 13))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //verifica a senha para poder alterar
            frmSenha fsenha = new frmSenha();
            fsenha.Usuario = txtUsuario.Text.Trim();
            fsenha.Password = senhaatual;
            fsenha.ShowDialog();

            if (fsenha.Ok == true)
            {
                habilitaCampos();
                btnAlterar.Visible = false;
                btnSalvar.Visible = true;
            }

            //lblAlteradoPor.Text = fsenha.Ok.ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja Gravar as Informações ?", "Salvar Dados", MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

            if (confirm.ToString().ToUpper() == "YES")
            {
                string retornobanco = "";
                Usuario user = new Usuario();

                if (senhaAlterada == true)
                {
                    //////////////////////////////////
                    string cryptosenha = Funcoes.Banco.GeraSenha(txtUsuario.Text, txtSenha.Text);
                    ////////////////////////////////// já faz o HASH da possivel senha
                    // novasenha = cryptosenha;
                    novasenha = txtSenha.Text.Trim();
                }
                else   // se a senha foi alterada, novasenha = senha criptografada nova, caso contrario, permanece a senha atual.
                {
                    novasenha = senhaatual;
                }

                user._Usuario = txtUsuario.Text;
                user._Senha = novasenha;   //grava o hash da senha gerado
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
                user._AlteradoPor = Biblioteca.Settings.Default.User;  // usuário logado no sistema;

                Banco banco = new Banco();
                retornobanco = banco.UpdateUsuario(user);

                if (retornobanco == "Alterado com sucesso")
                {
                    MessageBox.Show("Usuario Alterado com sucesso no Banco de Dados.", "Sucesso", MessageBoxButtons.OK,
                                   MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    limparCampos();
                    txtUsuario.Focus();

                }
                else
                {
                    //nao conseguiu converter em numero, então recebeu uma mensagem de erro do banco
                    MessageBox.Show("Houve um erro ao tentar cadastrar o Cliente.\n\n" + retornobanco, "Erro");
                    txtUsuario.Focus();
                }

            }
        }


        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            senhaAlterada = true;
        }


        private void habilitaCampos()
        {
            PainelTopo.Visible = true;
            PainelTopo.Enabled = true;
            PainelTopo2.Enabled = true;
            PainelUsuarios.Enabled = true;
            txtSenha.Enabled = true;
           // txtSenha.Text = senhaatual;
            txtUsuario.Enabled = false;
            btnConsultarUsuario.Enabled = false;
            txtNome.Focus();
        }
    }
}
