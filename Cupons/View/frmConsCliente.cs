using Biblioteca;
using Funcoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cupons.View
{
    public partial class frmConsCliente : Form
    {
        public frmConsCliente()
        {
            InitializeComponent();
        }
        DataTable dtretorno = new DataTable();

        private void frmConsCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ao pressionar enter vai para proximo campo
            if ((e.KeyChar == 13))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void frmConsCliente_Load(object sender, EventArgs e)
        {
            limparClientes();
            btnSalvar.Location = new Point(156, 421);
            HabilitarCampos(false);  //passa o status de falso para os campos ficarem desabilitados
            mskCPF.Focus();

            //por enquanto deixa invisivel os outros botoes de busca, ex.. nome, e data
            btnConsultarNome.Visible = false;
            btnConsultaDatasNascimento.Visible = false;

        }

        private void limparClientes()
        {
            mskCPF.Clear();
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
            lblID.Text = "";
            lblCadastradopor.Text = "";
            lblDataCadastro.Text = "";
            lblAlteradoPor.Text = "";
            lblDataAlteracao.Text = "";
            btnSalvar.Visible = false;
            btnAlterar.Visible = true;
            btnAlterar.Enabled = true;
            btnConsultaCPF.Enabled = true;
            grbInfo.Visible = false;
            mskCPF.Focus();
            SendKeys.Send("{BACKSPACE}");  //para eliminar o bug do maskedbox que empurra a mascara pra frente.
        }

        private void HabilitarCampos(bool status)
        {

            //mskCPF.Enabled = status;
            //txtNome.Enabled = status;
            //mskNascimento.Enabled = status;

            txtRG.Enabled = status;
            grbSexo.Enabled = status;
            chkAtivo.Enabled = status;
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
            //picFoto.Enabled = status;



        }

        private void btnConsultaCPF_Click(object sender, EventArgs e)
        {
            if (mskCPF.Text != "")
            {
                dtretorno.Clear();
                Banco banco = new Banco();
                dtretorno = banco.ConsultaCliente(mskCPF.Text);

                if (dtretorno != null && dtretorno.Rows.Count > 0) //verifica se datatable esta nulo ou vazio
                {
                    btnConsultaCPF.Enabled = false;
                    PreencheCampos(dtretorno);
                    // HabilitarCampos(true); ///desabilita ou habilita os campos
                    txtNome.Enabled = false;
                    mskNascimento.Enabled = false;
                    mskCPF.Focus();
                }


            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparClientes();
            txtNome.Enabled = true;
            mskNascimento.Enabled = true;
            btnConsultaCPF.Enabled = true;

            mskCPF.Focus();
        }

        private void PreencheCampos(DataTable dtCli)
        {
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
            lblDataAlteracao.Text = dtCli.Rows[0]["DataAlteracao"].ToString().Trim();
            lblAlteradoPor.Text = dtCli.Rows[0]["AlteradoPor"].ToString().Trim();

            //picFoto.Image = byteArrayToImage((byte[])dtCli.Rows[0]["Foto"]);
            picFoto.Image = null;
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            HabilitarCampos(true);
            txtNome.Enabled = true;
            mskNascimento.Enabled = true;
            btnAlterar.Visible = false;
            btnSalvar.Visible = true;
            mskCPF.Enabled = false;
        }

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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja Gravar as Informações ?", "Salvar Dados", MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

            if (confirm.ToString().ToUpper() == "YES")
            {
                string retornobanco = "";
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
                cli._AlteradoPor = Biblioteca.Settings.Default.User;  // usuário logado no sistema;

                //cli._Foto = imageToByteArray(picFoto.Image);
                cli._Foto = null;

                Banco banco = new Banco();
                retornobanco = banco.UpdateCliente(cli);

                if (retornobanco == "Alterado com sucesso")
                {
                    MessageBox.Show("Dados do Cliente Alterados com sucesso.", "Sucesso");

                    HabilitarCampos(false);  //passa o status de falso para os campos ficarem desabilitados
                    mskCPF.Enabled = true;
                    limparClientes();

                }
                else
                {
                    //nao conseguiu converter em numero, então recebeu uma mensagem de erro do banco
                    MessageBox.Show("Houve um erro ao tentar Atualizar o Cadastro do Cliente.\n\n" + retornobanco, "Erro");
                }


            }
        }
    }
}