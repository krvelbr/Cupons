using Biblioteca;
using Cupons.Controller;
using Funcoes;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;



namespace Cupons.View
{
    public partial class frmCadLojista : Form
    {
        public frmCadLojista()
        {
            InitializeComponent();
        }
        public bool fezbusca = false;

        private void frmCadLojista_Load(object sender, EventArgs e)
        {
            preencheComboRamos();
            mskCNPJ.Focus();
            //  mskCNPJ.Text = "10.306.331/0001-08";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpa_Campos();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            //verificar se tem erro
            if (VerificaCamposObrigatorios())
            {
                DialogResult confirm = MessageBox.Show("Deseja Gravar as Informações ?", "Salvar Dados", MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                if (confirm.ToString().ToUpper() == "YES")
                {
                    string retornobanco = "";
                    int id = 0; // se conseguir gravar, retorna com o numero do cliente no banco

                    Lojista loja = new Lojista();

                    loja._Cnpj = mskCNPJ.Text;
                    loja._IE = txtIE.Text;
                    loja._Razao = txtRazao.Text;
                    loja._Fantasia = txtFantasia.Text;
                    loja._Ativo = chkAtivo.Checked;
                    loja._idRamoAtividade = Int32.Parse(cmbRamos.SelectedValue.ToString());

                    Banco banco = new Banco();
                    retornobanco = banco.InserirLojista(loja);

                    if (int.TryParse(retornobanco, out id) == true)
                    {
                        MessageBox.Show("Lojista Cadastrado com sucesso no Banco de Dados.\n" +
                                        "Cadastrado com ID n°: " + id.ToString().PadLeft(6, '0'), "Sucesso");
                        Limpa_Campos();
                        mskCNPJ.Focus();
                    }
                    else
                    {
                        //nao conseguiu converter em numero, então recebeu uma mensagem de erro do banco
                        MessageBox.Show("Houve um erro ao tentar cadastrar o Lojista.\n\n" + retornobanco, "Erro");
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

        private void Limpa_Campos()
        {
            HabilitarCampos(true);
            mskCNPJ.Clear();
            txtIE.Clear();
            txtFantasia.Clear();
            txtRazao.Clear();
            chkAtivo.Checked = true;
            error.SetError(mskCNPJ, "");
            error.SetError(txtIE, "");
            error.SetError(txtFantasia, "");
            error.SetError(txtRazao, "");

            //btnGravar.Enabled = true;
            //mskCNPJ.Enabled = true;
            //txtIE.Enabled = true;
            //txtFantasia.Enabled = true;
            //txtRazao.Enabled = true;
            //chkAtivo.Enabled = true;
            fezbusca = false;
            mskCNPJ.Focus();
            cmbRamos.DataSource = null;
            preencheComboRamos();
            SendKeys.Send("{BACKSPACE}");

        }

        private void preencheComboRamos()
        {
            DataTable Ramos = new DataTable();
            AcessoBancoSql acessoBanco = new AcessoBancoSql();

            Ramos = acessoBanco.ConsultaRamos(CommandType.Text, "Select id as Código, Atividade as Ramo from tblRamosAtividade");
            cmbRamos.DataSource = Ramos;
            cmbRamos.DisplayMember = "Ramo";
            cmbRamos.ValueMember = "Código";
            cmbRamos.Update();
            cmbRamos.SelectedIndex = -1;
        }

        private void HabilitarCampos(bool status)
        {
            mskCNPJ.Enabled = status;
            txtIE.Enabled = status;
            txtFantasia.Enabled = status;
            txtRazao.Enabled = status;
            chkAtivo.Enabled = status;
            btnGravar.Enabled = status;
            cmbRamos.Enabled = status;
        }


        private bool validacnpj()
        {
            if (ValidacaoCNPJ.IsCnpj(mskCNPJ.Text))
            {
                error.SetError(mskCNPJ, ""); // "CNPJ VALIDO";
                                             // return true;

                if (fezbusca == false)
                {
                    DataTable dtretorno = new DataTable();
                    Banco banco = new Banco();
                    dtretorno = banco.ConsultaLojista(mskCNPJ.Text);
                    if (dtretorno != null && dtretorno.Rows.Count > 0) //verifica se datatable esta nulo ou vazio
                    {
                        MessageBox.Show("Já existe Lojista Cadastrado com esse CNPJ", "Aviso");
                        fezbusca = true;
                        PreencheCampos(dtretorno);
                        HabilitarCampos(false); ///desabilita ou habilita os campos


                    }
                }
                return true;
            }
            else
            {
                error.SetError(mskCNPJ, "CNPJ INVÁLIDO");
                error.SetIconPadding(mskCNPJ, -18);
                mskCNPJ.Focus();
                return false;
            }
        }


        private void mskCNPJ_Leave(object sender, EventArgs e)
        {

            if (validacnpj() == true)
            {
                if (fezbusca == true)
                {
                    txtIE.Focus();
                }
            }
        }


        private void PreencheCampos(DataTable dtloja)
        {
            txtIE.Text = dtloja.Rows[0]["IELojista"].ToString().Trim();
            txtFantasia.Text = dtloja.Rows[0]["FantasiaLojista"].ToString().Trim();
            txtRazao.Text = dtloja.Rows[0]["RazaoLojista"].ToString().Trim();
            //this.cmbAssignedTo.SelectedValue = this.cmbAssignedTo.Items.Contains(userId) ? userId : "All";
            object id = dtloja.Rows[0]["idRamoAtividade"].ToString().Trim();
            if (id.ToString() != "")
            { cmbRamos.SelectedValue = Convert.ToInt32(id); }
            else
            { cmbRamos.SelectedValue = -1; }
            

            chkAtivo.Checked = Convert.ToBoolean(dtloja.Rows[0]["Ativo"]);
            //HabilitarCampos(false);
            mskCNPJ.Enabled = false;
            txtIE.Enabled = false;
            txtFantasia.Enabled = false;
            txtRazao.Enabled = false;
            chkAtivo.Enabled = false;
            cmbRamos.Enabled = false;
            cmbRamos.Update();
            //btnLimpar.Focus();

            //txtIE.Focus();
        }


        private bool validarCampos(TextBox textbox, ErrorProvider erro) // valida campos vazios
        {
            if (!String.IsNullOrWhiteSpace(textbox.Text))
            {
                erro.SetError(textbox, "");
                return (true);
            }
            else
            {
                erro.SetError(textbox, "Campo Inválido ou Vazio.");
                erro.SetIconPadding(textbox, -18);
                textbox.Focus();
                return (false);
            }
        }

        private void txtRazao_Leave(object sender, EventArgs e)
        {
            if (validarCampos(txtRazao, error) == true)
            {
                // passou na validacao
            }
        }

        private void txtFantasia_Leave(object sender, EventArgs e)
        {
            if (validarCampos(txtFantasia, error) == true)
            {
                // passou na validacao
            }
        }

        private void frmCadLojista_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ao pressionar enter vai para proximo campo
            if ((e.KeyChar == 13))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        // private void mskCNPJ_Validating(object sender, CancelEventArgs e)
        // {
        //     if (validacnpj() != true)
        //     {
        //         error.SetError(mskCNPJ, "Campo Inválido ou Vazio.");
        //         error.SetIconPadding(mskCNPJ, -18);
        //         mskCNPJ.Focus();
        //     }
        //     else
        //     {
        //         error.SetError(mskCNPJ, "");
        //     }
        // }

        private void txtIE_Leave(object sender, EventArgs e)
        {
            if (validarCampos(txtIE, error) == true)
            {
                // passou na validacao
            }

        }

        private void txtIE_KeyPress(object sender, KeyPressEventArgs e)
        {
            //aceita apenas numeros
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }
    }

}








//loja.Salvar();


/*
                int ativo;
                if (chkAtivo.Checked == true)
                {
                    ativo = 1;
                }
                else
                {
                    ativo = 0;
                }





                DataGridView inserelojista = new DataGridView();
                inserelojista.DataSource = null;  // limpa o datagrid


                DataTable _table = new DataTable();
                _table.Columns.Add("CNPJ", typeof(string));
                _table.Columns.Add("IE", typeof(string));
                _table.Columns.Add("RAZAO", typeof(string));
                _table.Columns.Add("FANTASIA", typeof(string));
                _table.Columns.Add("ATIVO", typeof(int));
                _table.Rows.Add(mskCNPJ.Text, txtIE.Text, txtRazao.Text, txtFantasia.Text, ativo);

                Funcoes.InsereLojistas(_table);


            }
            else
            {
                mskCNPJ.Focus();
            }

    */
