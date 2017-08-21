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
    public partial class frmConsLojista : Form
    {
        public frmConsLojista()
        {
            InitializeComponent();
        }
        public DataTable dtLojista = new DataTable();

        private void frmConsLojista_Load(object sender, EventArgs e)
        {
            limparCampos();
            btnSalvar.Location = new Point(145, 277);
            HabilitaCampos(false);  //passa o status de falso para os campos ficarem desabilitados
        }

        private void limparCampos()
        {
            mskCNPJ.Enabled = true;
            mskCNPJ.ResetOnPrompt = true;
            mskCNPJ.Clear();
            txtIE.Clear();
            chkAtivo.Checked = true;
            txtFantasia.Clear();
            txtRazao.Clear();
            btnConsultarLojista.Enabled = true;
            btnLimpar.Enabled = true;
            btnSair.Enabled = true;
            btnAlterar.Visible = true;
            btnSalvar.Visible = false;
            //mskCNPJ.Mask = "00,000,000/0000-00";
            //mskCNPJ.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            cmbRamos.DataSource = null;
            mskCNPJ.Focus();
            SendKeys.Send("{BACKSPACE}");  //para eliminar o bug do maskedbox que empurra a mascara pra frente.
        }
        private void HabilitaCampos(bool status)
        {
            txtIE.Enabled = status;
            chkAtivo.Enabled = status;
            txtFantasia.Enabled = status;
            txtRazao.Enabled = status;
            cmbRamos.Enabled = status;
        }

        private void frmConsLojista_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ao pressionar enter vai para proximo campo
            if ((e.KeyChar == 13))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void btnConsultarLojista_Click(object sender, EventArgs e)
        {

            if (mskCNPJ.Text.Trim() != "")
            {
                ConsultaLojista();

                if (dtLojista != null && dtLojista.Rows.Count > 0) //verifica se datatable esta nulo ou vazio
                {
                    PreencheForm();
                    HabilitaCampos(false);  //passa o status de falso para os campos ficarem desabilitados
                    btnAlterar.Visible = true;
                    btnAlterar.Enabled = true;

                }
                else
                {
                    MessageBox.Show("CNPJ não encontrado.\nFavor Verificar.", "Erro", MessageBoxButtons.OK,
                       MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    mskCNPJ.Focus();
                }
            }
        }

        private void ConsultaLojista()
        {
            Banco banco = new Banco();
            dtLojista.Clear();
            dtLojista = banco.ConsultaLojista(mskCNPJ.Text);


            DataTable Ramos = new DataTable();
            AcessoBancoSql acessoBanco = new AcessoBancoSql();

            Ramos = acessoBanco.ConsultaRamos(CommandType.Text, "Select id as Código, Atividade as Ramo from tblRamosAtividade");
            cmbRamos.DataSource = Ramos;
            cmbRamos.DisplayMember = "Ramo";
            cmbRamos.ValueMember = "Código";
        }

        private void PreencheForm()
        {
            txtIE.Text = dtLojista.Rows[0]["IELojista"].ToString().Trim();
            txtFantasia.Text = dtLojista.Rows[0]["FantasiaLojista"].ToString().Trim();
            txtRazao.Text = dtLojista.Rows[0]["RazaoLojista"].ToString().Trim();
            chkAtivo.Checked = Convert.ToBoolean(dtLojista.Rows[0]["Ativo"]);
            mskCNPJ.Enabled = false;
            object id = dtLojista.Rows[0]["idRamoAtividade"].ToString().Trim();
            if (id.ToString() != "")
            { cmbRamos.SelectedValue = Convert.ToInt32(id); }
            else
            { cmbRamos.SelectedValue = -1; }
            cmbRamos.Update();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
            //mskCNPJ.Clear();
            //mskCNPJ.Focus();
            //SendKeys.Send("{BACKSPACE}");  //para eliminar o bug do maskedbox que empurra a mascara pra frente.
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //verificar se tem erro
            if (VerificaCamposObrigatorios())
            {
                DialogResult confirm = MessageBox.Show("Deseja Gravar as Informações ?", "Salvar Dados", MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                if (confirm.ToString().ToUpper() == "YES")
                {
                    string retornobanco = "";

                    Lojista loja = new Lojista();

                    loja._Cnpj = mskCNPJ.Text;
                    loja._IE = txtIE.Text;
                    loja._Razao = txtRazao.Text;
                    loja._Fantasia = txtFantasia.Text;
                    loja._Ativo = chkAtivo.Checked;
                    loja._idRamoAtividade = Int32.Parse(cmbRamos.SelectedValue.ToString());

                    Banco banco = new Banco();
                    retornobanco = banco.UpdateLojista(loja);

                    if (retornobanco == "Alterado com sucesso")
                    {
                        MessageBox.Show("Dados do Lojista Alterados com sucesso.", "Sucesso");
                        
                        HabilitaCampos(false);  //passa o status de falso para os campos ficarem desabilitados
                        limparCampos();
                    }
                    else
                    {
                        //nao conseguiu converter em numero, então recebeu uma mensagem de erro do banco
                        MessageBox.Show("Houve um erro ao tentar Atualizar o Cadastro do Lojista.\n\n" + retornobanco, "Erro");
                    }
                }
            }
        }

        private bool VerificaCamposObrigatorios()
        {
            if (txtIE.Text == "" || txtFantasia.Text == "" || txtRazao.Text == "")

            {
                MessageBox.Show("Os campos do cadastro não podem estar vazios ou nulos.", "Aviso");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            mskCNPJ.Enabled = false;
            btnAlterar.Visible = false;
            btnSalvar.Visible = true;
            HabilitaCampos(true);  //passa o status de falso para os campos ficarem desabilitados
            

        }
    }
}
