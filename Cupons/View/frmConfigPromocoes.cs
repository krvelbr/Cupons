using Biblioteca;
using Funcoes;
using System;
using System.Data;
using System.Drawing.Printing;
using System.Windows.Forms;


namespace Cupons.View
{
    public partial class frmConfigPromocoes : Form
    {
        public frmConfigPromocoes()
        {
            InitializeComponent();
        }
        public Configuracao config = new Configuracao();
        public DataTable dtConfig = new DataTable();
        public bool vazio = true;
        public bool PrinterChanged = false;
        public int indiceRamos = -1;
        public int posRamos = -1;

        private void frmConfigPromocoes_Load(object sender, EventArgs e)
        {
            //verifica se tem algo na tabela de configuracao
            carregaCampos();
            vazio = verificaConfig("SELECT * FROM tblConfig");  //executa esse comando para verificar se tem algo na tabela
            preencheConfigGeral();
            preencheConfigBancoDados();
            preencheConfigImpressora();

        }

        private void frmConfigPromocoes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 13))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //verifica a senha para poder alterar
            frmSenha fsenha = new frmSenha();
            fsenha.Usuario = "Promocoe$";
            fsenha.Password = senhahoje();
            fsenha.ShowDialog();

            if (fsenha.Ok == true)
            {

                ((Control)this.tabPage1).Enabled = true;
                ((Control)this.tabPage3).Enabled = true;
                ((Control)this.tabPage4).Enabled = true;

                btnAlterar.Enabled = false;
                btnSalvar.Enabled = true;
            }
        }


        private void carregaCampos()
        {
            ((Control)this.tabPage1).Enabled = false;
            ((Control)this.tabPage3).Enabled = false;
            ((Control)this.tabPage4).Enabled = false;
            //tabConfig.Enabled = false;
            //mskValorCupom.Enabled = false;
            //txtLicenca.Enabled = false;
            btnAlterar.Enabled = true;
            btnSalvar.Enabled = false;
            lblImpressoraSelecionada.Text = "";

        }

        private string senhahoje()
        {
            string dia = DateTime.Now.Day.ToString().PadLeft(2, '0');
            string mes = DateTime.Now.Month.ToString().PadLeft(2, '0');
            string semente = dia + mes;  // concatena o dia com o mes.. ex: "2509'
            int senhacalculada = 1978 + Convert.ToInt16(semente);
            return senhacalculada.ToString().PadLeft(4, '0');
        }

        private bool verificaConfig(string executacomando)
        {
            Banco banco = new Banco();
            dtConfig.Clear();
            dtConfig = banco.ConsultaConfig(CommandType.Text, executacomando);

            if (dtConfig != null && dtConfig.Rows.Count > 0) //verifica se datatable esta nulo ou vazio
            {
                vazio = false;
            }
            else
            {
                MessageBox.Show("Não Existe nenhuma configuração disponível.\nEntrar em Contato com Suporte !", "Erro", MessageBoxButtons.OK,
                   MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                vazio = true;
                btnSair.Focus();
            }
            return vazio;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            preparaConfig();
            ManageConfig(config);   //envia a classe config para a funcao ManageConfig
            if (PrinterChanged == true)
            { Biblioteca.Settings.Default.Impressora = lsbPrinters.Text; }

            Biblioteca.Settings.Default.stringConnection = String.Format(@"Data Source= {0}\{1}; Initial Catalog= {2}; User ID= {3}; Password= {4}", config._IP, config._Instancia, config._Banco, config._Usuario, config._Senha);
            Biblioteca.Settings.Default.Save();
            Biblioteca.Settings.Default.Upgrade();
            ((Control)this.tabPage1).Enabled = false;
            ((Control)this.tabPage3).Enabled = false;
            ((Control)this.tabPage4).Enabled = false;

            btnSalvar.Enabled = false;
            btnAlterar.Enabled = true;
            btnSair.Focus();


        }


        private void preparaConfig()
        {
            config._ValorCupom = Convert.ToInt16(mskValorCupom.Text);
            config._Licenca = txtLicenca.Text;

            config._IP = txtIP.Text;
            config._Instancia = txtInstancia.Text;
            config._Banco = txtBanco.Text;
            config._Usuario = txtUser.Text;
            config._Senha = txtSenha.Text;

        }

        private void preencheConfigGeral()
        {
            if (!vazio) //se nao estiver vazio
            {
                config._ValorCupom = Convert.ToInt16(dtConfig.Rows[0]["ValorCupom"]);
                config._Licenca = dtConfig.Rows[0]["Licenciado"].ToString().Trim();

                mskValorCupom.Text = config._ValorCupom.ToString();
                txtLicenca.Text = config._Licenca;
            }
            else
            {
                config._ValorCupom = 200;
                config._Licenca = "Marko Solution";
            }
            PreencheTxts("Config.Geral");   // preenche a aba de Config. Banco


        }

        private void preencheConfigImpressora()
        {
            lblImpressoraSelecionada.Text = Biblioteca.Settings.Default.Impressora;
            foreach (string impressora in PrinterSettings.InstalledPrinters)
            {
                lsbPrinters.Items.Add(impressora);
            }
        }

        private void PreencheTxts(string tab)
        {
            if (tab == "Config.Geral")
            {
                mskValorCupom.Text = config._ValorCupom.ToString();
                txtLicenca.Text = config._Licenca;
            }

            if (tab == "RamoAtividade")
            {

            }

            if (tab == "ConfigImpressora")
            {

            }

            if (tab == "ConfigBanco")
            {
                txtIP.Text = config._IP;
                txtInstancia.Text = config._Instancia;
                txtBanco.Text = config._Banco;
                txtUser.Text = config._Usuario;
                txtSenha.Text = config._Senha;
            }


        }

        private void preencheConfigBancoDados()
        {
            if (!vazio) //se nao estiver vazio
            {
                config._IP = dtConfig.Rows[0]["IP"].ToString().Trim();
                config._Instancia = dtConfig.Rows[0]["Instancia"].ToString().Trim();
                config._Banco = dtConfig.Rows[0]["NomeBanco"].ToString().Trim();
                config._Usuario = dtConfig.Rows[0]["Usuario"].ToString().Trim();
                config._Senha = dtConfig.Rows[0]["Senha"].ToString().Trim();
            }
            else   // se estiver vazio
            {
                txtIP.Text = "Localhost";
                txtInstancia.Text = "Cupons";
                txtBanco.Text = "Cupons";
                txtUser.Text = "sa";
                txtSenha.Text = "solution";
            }
            PreencheTxts("ConfigBanco");   // preenche a aba de Config. Banco
        }

        private String ManageConfig(Configuracao conf)
        {
            AcessoBancoSql acessoBanco = new AcessoBancoSql();
            try
            {
                acessoBanco.LimparParametros();
                acessoBanco.AdicionarParametros("@ValorCupom", conf._ValorCupom);
                acessoBanco.AdicionarParametros("@Licenca", conf._Licenca);

                acessoBanco.AdicionarParametros("@IP", conf._IP);
                acessoBanco.AdicionarParametros("@Instancia", conf._Instancia);
                acessoBanco.AdicionarParametros("@NomeBanco", conf._Banco);
                acessoBanco.AdicionarParametros("@Usuario", conf._Usuario);
                acessoBanco.AdicionarParametros("@Senha", conf._Senha);

                string retConfig = acessoBanco.ExecutarManipulacao(CommandType.StoredProcedure, "uspManageConfig").ToString();
                return retConfig;
            }
            catch (Exception ex)
            {
                return ex.Message;    // se der algum erro, vai aparecer a string de erro aqui, e vai ser devolvido ao inves do id do lojista.
            }
        }

        private void lsbPrinters_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = lsbPrinters.SelectedIndex;
            PrinterChanged = true;
            lblImpressoraSelecionada.Text = lsbPrinters.Items[i].ToString();

        }

      
    }
}


/*
 * string _conn =

                    "Data Source = localhost\\HIPER;" + // aqui deve ser colocado o campo com o local do servidor que deve vir da configuracao de parametros
                    "Initial Catalog = Cupons;" +
                    "User ID = sa;" +
                    "Password = hiper";
*/
