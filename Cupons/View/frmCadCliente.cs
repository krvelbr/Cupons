using Biblioteca;
using Cupons.Controller;
using Funcoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cupons.View
{

    public partial class frmCadCliente : Form
    {

        public frmCadCliente()
        {
            InitializeComponent();
            
        }
        public bool fezbusca = false;

        private class erro
        {
            public bool cpf { get; set; }
            public bool sexo { get; set; }
            public bool nome { get; set; }
            public bool Nascimento { get; set; }
        }

        erro existeErro = new erro();


        private void picFoto_Click(object sender, EventArgs e)
        {
            // chama o formulario que tira a foto...
            frmFotoWebcam frmFoto = new frmFotoWebcam();
            frmFoto.ShowDialog();
            string retornoArquivoFoto;
            retornoArquivoFoto = frmFoto._fotonome;

            if (retornoArquivoFoto != null)
            {
                picFoto.ImageLocation = retornoArquivoFoto;
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparClientes();
        }

        private void limparClientes()
        {
            HabilitarCampos(true);

            mskCPF.Clear();
            fezbusca = false;  // retorna o marcador para poder fazer novas buscas.
            txtRG.Clear();
            rbFeminino.Checked = false;
            rbMasculino.Checked = false;
            chkAtivo.Checked = true;
            txtNome.Clear();
            mskNascimento.Clear();
            //picFoto.InitialImage = Cupons.Properties.Resources.foto_modelo;
            //picFoto.Image = Cupons.Properties.Resources.foto_modelo;
            picFoto.InitialImage = null;
            picFoto.Image = null;
            txtEndereco.Clear();
            txtEnderecoNumero.Clear();
            txtEnderecoComplemento.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtUF.Clear();
            mskCEP.Clear();
            mskFoneFixo.Clear();
            mskFoneCelular1.Clear();
            mskFoneCelular2.Clear();
            mskFoneCelular3.Clear();
            mskWhatsapp.Clear();
            txtEmail.Clear();
            txtFacebook.Clear();
            txtTwitter.Clear();
            txtObservacao.Clear();
            grbInfo.Visible = false;
            lblID.Text = "";
            lblCadastradopor.Text = "";
            lblDataCadastro.Text = "";
            btnGravar.Enabled = true;
            error.SetError(mskCPF, "");
            error.SetError(grbSexo, "");
            error.SetError(txtNome, "");
            error.SetError(mskNascimento, "");
            existeErro.cpf = false;
            existeErro.nome = false;
            existeErro.sexo = false;
            existeErro.Nascimento = false;

            mskCPF.Focus();
            SendKeys.Send("{BACKSPACE}");
            // btnConsultaDatasNascimento.Visible = false; // deixa o botao de pesquisar por datas desligado, ligar so para consultas
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (VerificaCamposObrigatorios())
            {

                // byte[] newImg = (byte[])pictureEdit1.EditValue;
                DialogResult confirm = MessageBox.Show("Deseja Gravar as Informações ?", "Salvar Dados", MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                if (confirm.ToString().ToUpper() == "YES")
                {
                    string retornobanco = "";
                    int id = 0; // se conseguir gravar, retorna com o numero do cliente no banco
                    string sexo = "";

                    if (rbFeminino.Checked == true) { sexo = "F"; }
                    if (rbMasculino.Checked == true) { sexo = "M"; }

                    Cliente cli = new Cliente();

                    cli._CPF = mskCPF.Text;
                    cli._RG = txtRG.Text;
                    cli._Sexo = sexo;
                    cli._Ativo = chkAtivo.Checked;
                    cli._Nome = txtNome.Text;
                    cli._Nascimento = DateTime.ParseExact(mskNascimento.Text.ToString(), "d/M/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                    cli._Endereco = txtEndereco.Text;
                    cli._EndNumero = txtEnderecoNumero.Text;
                    cli._EndComplemento = txtEnderecoComplemento.Text;
                    cli._Bairro = txtBairro.Text;
                    cli._Cidade = txtCidade.Text;
                    cli._UF = txtUF.Text;
                    cli._CEP = mskCEP.Text;
                    cli._FoneFixo = mskFoneFixo.Text;
                    cli._Celular1 = mskFoneCelular1.Text;
                    cli._Celular2 = mskFoneCelular2.Text;
                    cli._Celular3 = mskFoneCelular3.Text;
                    cli._Whatsapp = mskWhatsapp.Text;
                    cli._Email = txtEmail.Text;
                    cli._Facebook = txtFacebook.Text;
                    cli._Twitter = txtTwitter.Text;
                    cli._Observacao = txtObservacao.Text;
                    cli._CadastradoPor = Biblioteca.Settings.Default.User;  // usuário logado no sistema;

                    //cli._Foto = imageToByteArray(picFoto.Image);
                    cli._Foto = null;
                    Banco banco = new Banco();
                    retornobanco = banco.InserirCliente(cli);

                    if (int.TryParse(retornobanco, out id) == true)
                    {
                        MessageBox.Show("Cliente Cadastrado com sucesso no Banco de Dados.\n" +
                                        "Cadastrado com ID n°: " + id.ToString().PadLeft(6, '0'), "Sucesso");
                        limparClientes();
                        mskCPF.Focus();
                    }
                    else
                    {
                        //nao conseguiu converter em numero, então recebeu uma mensagem de erro do banco
                        MessageBox.Show("Houve um erro ao tentar cadastrar o Cliente.\n\n" + retornobanco, "Erro");
                    }

                }
            }
        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void frmCadCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ao pressionar enter vai para proximo campo
            if ((e.KeyChar == 13))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void mskCPF_Leave(object sender, EventArgs e)
        {
            //////  // validaCPF();  ativar validacao de cpf quando estiver ok

            if (validarcampoCPF() == true)
            {
                if (fezbusca == true)
                { txtRG.Focus(); }
            }
        }
        private void PreencheCampos(DataTable dtCli)
        {
            btnGravar.Enabled = false;
            grbInfo.Visible = true;

            txtRG.Text = dtCli.Rows[0]["RG"].ToString().Trim();
            txtNome.Text = dtCli.Rows[0]["Nome"].ToString().Trim();
            mskNascimento.Text = dtCli.Rows[0]["DataNasc"].ToString().Trim();
            chkAtivo.Checked = Convert.ToBoolean(dtCli.Rows[0]["Ativo"].ToString());

            if (dtCli.Rows[0]["Sexo"].ToString().Trim() == "F") { rbFeminino.Checked = true; }
            if (dtCli.Rows[0]["Sexo"].ToString().Trim() == "M") { rbMasculino.Checked = true; }

            txtEndereco.Text = dtCli.Rows[0]["Endereco"].ToString().Trim();
            txtEnderecoNumero.Text = dtCli.Rows[0]["EnderecoNumero"].ToString().Trim();
            txtEnderecoComplemento.Text = dtCli.Rows[0]["EnderecoComplemento"].ToString().Trim();
            txtBairro.Text = dtCli.Rows[0]["Bairro"].ToString().Trim();
            txtCidade.Text = dtCli.Rows[0]["Cidade"].ToString().Trim();
            txtUF.Text = dtCli.Rows[0]["Estado"].ToString().Trim();
            mskCEP.Text = dtCli.Rows[0]["CEP"].ToString().Trim();
            mskFoneFixo.Text = dtCli.Rows[0]["FoneFixo"].ToString().Trim();
            mskFoneCelular1.Text = dtCli.Rows[0]["FoneCelular1"].ToString().Trim();
            mskFoneCelular2.Text = dtCli.Rows[0]["FoneCelular2"].ToString().Trim();
            mskFoneCelular3.Text = dtCli.Rows[0]["FoneCelular3"].ToString().Trim();
            mskWhatsapp.Text = dtCli.Rows[0]["Whatsapp"].ToString().Trim();
            txtEmail.Text = dtCli.Rows[0]["Email"].ToString().Trim();
            txtFacebook.Text = dtCli.Rows[0]["Facebook"].ToString().Trim();
            txtTwitter.Text = dtCli.Rows[0]["Twitter"].ToString().Trim();
            txtObservacao.Text = dtCli.Rows[0]["Observacao"].ToString().Trim();

            lblID.Text = dtCli.Rows[0]["id"].ToString().Trim().PadLeft(6, '0');
            lblCadastradopor.Text = dtCli.Rows[0]["CadastradoPor"].ToString().Trim();
            lblDataCadastro.Text = dtCli.Rows[0]["DataCadastro"].ToString().Trim();
            //picFoto.Image = byteArrayToImage((byte[])dtCli.Rows[0]["Foto"]);
            picFoto.Image = null;
            //Encoding.ASCII.GetString((byte[])row["Customer ID"]);

        }
        private bool validarcampoCPF()
        {
            if (ValidaCPF.IsCpf(mskCPF.Text))
            {
                error.SetError(mskCPF, ""); // "CPF VALIDO";

                if (fezbusca == false)
                {
                    DataTable dtretorno = new DataTable();
                    Banco banco = new Banco();
                    dtretorno = banco.ConsultaCliente(mskCPF.Text);

                    if (dtretorno != null && dtretorno.Rows.Count > 0) //verifica se datatable esta nulo ou vazio
                    {
                        MessageBox.Show("Já existe Cliente Cadastrado com esse CPF.", "Aviso");
                        PreencheCampos(dtretorno);
                        fezbusca = true;
                        //                        txtRG.Focus();
                        HabilitarCampos(false); ///desabilita ou habilita os campos
                    }
                }
                // passou na validacao, vai verificar se ja existe no banco de dados
                return true;
            }
            else
            {
                error.SetError(mskCPF, "CPF INVÁLIDO");
                error.SetIconPadding(mskCPF, -18);
                mskCPF.Focus();
                return false;
            }
        }

        private void txtRG_KeyPress(object sender, KeyPressEventArgs e)
        {
            //aceita apenas numeros
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back && e.KeyChar != '-')
            {
                e.Handled = true;
            }

        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string email = txtEmail.Text;

            Regex rg = new Regex(@"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");
            if (rg.IsMatch(email) || txtEmail.Text == "")
            {
                // nao precisa mostrar mensagem que esta valido...
            }
            else
            {
                MessageBox.Show("Email Inválido!", "Erro");
                txtEmail.Focus();
            }
        }

        private void txtUF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void frmCadCliente_Load(object sender, EventArgs e)
        {
            grbInfo.Visible = false;
            lblID.Text = "";
            lblCadastradopor.Text = "";
            lblDataCadastro.Text = "";
            mskCPF.Focus();
        }
        private void HabilitarCampos(bool status)
        {

            mskCPF.Enabled = status;
            txtNome.Enabled = status;
            txtRG.Enabled = status;
            grbSexo.Enabled = status;
            chkAtivo.Enabled = status;
            mskNascimento.Enabled = status;
            //picFoto.Enabled = status;
            txtEndereco.Enabled = status;
            txtEnderecoNumero.Enabled = status;
            txtEnderecoComplemento.Enabled = status;
            txtBairro.Enabled = status;
            txtCidade.Enabled = status;
            txtUF.Enabled = status;
            mskCEP.Enabled = status;
            mskFoneFixo.Enabled = status;
            mskFoneCelular1.Enabled = status;
            mskFoneCelular2.Enabled = status;
            mskFoneCelular3.Enabled = status;
            mskWhatsapp.Enabled = status;
            txtEmail.Enabled = status;
            txtFacebook.Enabled = status;
            txtTwitter.Enabled = status;
            txtObservacao.Enabled = status;

        }

        private void mskNascimento_Leave(object sender, EventArgs e)
        {
            DateTime testadata;
            if (!DateTime.TryParse(mskNascimento.Text, out testadata)) // || mskNascimento.Text != "  /  /    ")
            {
                MessageBox.Show("Data Inválida ou Vazia. Favor Corrigir.", "Aviso");
                //mskNascimento.Focus();   // a data está incorreta, volta pro campo.
            }

        }

        private void txtEnderecoNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private bool VerificaCamposObrigatorios()
        {

            if (!rbFeminino.Checked && !rbMasculino.Checked)
            {
                error.SetError(grbSexo, "Campo Sexo deve ser preenchido");
                error.SetIconPadding(grbSexo, -20);
                existeErro.sexo = true;
                grbSexo.Focus();
            }
            else
            {
                error.SetError(grbSexo, "");
                existeErro.sexo = false;
            }
            //verificar preenchimento dos campos:
            //mskCPF, sexo, nome, datanasc;

            if (txtNome.Text.Trim().Length == 0)   ///campo esta vazio
            {
                error.SetError(txtNome, "Campo Nome não pode estar vazio");
                error.SetIconPadding(txtNome, -18);
                existeErro.nome = true;
                txtNome.Focus();
            }
            else
            {
                error.SetError(txtNome, "");
                existeErro.nome = false;
            }

            if (!mskNascimento.MaskCompleted)
            {
                error.SetError(mskNascimento, "Campo Data não pode estar vazio ou nulo");
                error.SetIconPadding(mskNascimento, -18);
                existeErro.Nascimento = true;
                mskNascimento.Focus();
            }
            else
            {
                error.SetError(mskNascimento, "");
                existeErro.Nascimento = false;
            }

            if (existeErro.cpf == true || existeErro.nome == true || existeErro.sexo == true || existeErro.Nascimento == true)
            {
                MessageBox.Show("Favor Verificar o(s) Campo(s) com erro(s).\n", "Aviso");
                return false;
            }
            else
            {
                return true;
            }

        }

        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            if (txtNome.Text.Trim().Length == 0)   ///campo esta vazio
            {
                error.SetError(txtNome, "Campo Nome não pode estar vazio");
                error.SetIconPadding(txtNome, -18);
            }
            else
            {
                error.SetError(txtNome, "");
            }
        }

        private void mskNascimento_Validating(object sender, CancelEventArgs e)
        {
            if (!mskNascimento.MaskCompleted)
            {
                error.SetError(mskNascimento, "Campo Data não pode estar vazio ou nulo");
                error.SetIconPadding(mskNascimento, -18);
            }
            else
            {
                error.SetError(mskNascimento, "");
            }
        }

       
    }

}

