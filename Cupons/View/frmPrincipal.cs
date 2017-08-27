using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cupons.View;
using Cupons.Controller;
using Funcoes;
using System.Threading;

namespace Cupons
{
    public partial class frmPrincipal : Form
    {

        public frmPrincipal()
        {
            InitializeComponent();
            this.Hide();
        }
        public string globalUser;
        public string globalEmpresa;
        public bool alterarUsuario = false;


        public void ShowSplash()
        {
            Application.Run(new frmSplash());
        }


        private void tsbCadLojista_Click(object sender, EventArgs e)
        {
            frmCadLojista CadLojista = new frmCadLojista();
            CheckMdiChildren(CadLojista);

        }

        private void tsbCadClientes_Click(object sender, EventArgs e)
        {
            frmCadCliente CadCliente = new frmCadCliente();
            CheckMdiChildren(CadCliente);

        }

        public void CheckMdiChildren(Form form)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() == form.GetType())
                {
                    frm.Focus();
                    return;
                }
            }
            form.MdiParent = this;
            form.Show();


        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // this.Close();
            Application.Exit();
        }

        private void lojistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadLojista CadLojista = new frmCadLojista();
            CheckMdiChildren(CadLojista);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            DateTime dataTeste = DateTime.Now.Date;
            DateTime dataBlock = new DateTime(2017, 12, 28);
            int result = DateTime.Compare(dataTeste, dataBlock);

            if (result > 0)
            {
                MessageBox.Show("A data para uso da licença do sistema expirou.\nEntre em contato com nosso suporte.\nMarko Solution - (86) 2106-5010.", "Erro", MessageBoxButtons.OK,
          MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                Application.Exit();
            }
            else
            {
                bool _continua = true;
                Thread t = new Thread(new ThreadStart(ShowSplash));
                t.Start();
                Thread.Sleep(4000);
                t.Abort();
                _continua = CarregaParametrosGerais();
                if (_continua == true)
                {
                    this.Show();
                    this.WindowState = FormWindowState.Maximized;

                    tssData.Text = DateTime.Now.ToLongDateString();
                    Chamalogin();
                }
                else
                { Application.Exit(); }
            }
            
        }

        private bool CarregaParametrosGerais()
        {
            bool _sem_erro = true;
            bool vazio = true;
            Banco banco = new Banco();
            DataTable dtConfig = new DataTable();
            dtConfig.Clear();
            try
            {
                dtConfig = banco.ConsultaConfig(CommandType.Text, "SELECT * FROM tblConfig");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace + "\n\nFaça a configuração correta do Acesso ao Banco.", "Erro", MessageBoxButtons.OK,
              MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);   // mostra mensagem de erro
                                                                          // ex.StackTrace mostra quais as linhas onde foram ocorrendo os erros ou exceptions.

                //ShowConfig();
                _sem_erro = false;
            }


            if (dtConfig != null && dtConfig.Rows.Count > 0) //verifica se datatable esta nulo ou vazio
            {
                vazio = false;
                Biblioteca.Settings.Default.ValorPromocao = Convert.ToInt16(dtConfig.Rows[0]["ValorCupom"]);
                Biblioteca.Settings.Default.Liberacao = dtConfig.Rows[0]["Licenciado"].ToString().Trim();
                tssLiberacao.Text = Biblioteca.Settings.Default.Liberacao;
            }
            else
            {
                vazio = true;
                //    MessageBox.Show("Configurações de Parametros não encontradas.\nEntre em contato com o Suporte Técnico.\nO Sistema será encerrado.", "Erro", MessageBoxButtons.OK,
                //  MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                //  MessageBox.Show("Configurações de Parametros não encontradas.\nSerá aberto uma tela de configuração, após cadastrar ou corrigir os Parâmetros do Sistema, o mesmo deve ser fechado e deve ser aberto novamente.", "Erro", MessageBoxButtons.OK,
                //MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                //frmConfigPromocoes frmPromocoes = new frmConfigPromocoes();
                //CheckMdiChildren(frmPromocoes);
                //if (tssUser.Text != ("ADMIN").ToUpper())
                //{
                //    frmPromocoes.Focus();

            }
            if (vazio == true)
            {
              ShowConfig();
            }

            return _sem_erro;
        }

        static public void ShowConfig()
        {
            //Form.ActiveForm.Hide();
            frmAcessoBanco ConfigBanco = new frmAcessoBanco();
            if (ConfigBanco.ShowDialog() != DialogResult.OK)
            { Application.Exit(); }

        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tssUser_Click(object sender, EventArgs e)
        {
            alterarUsuario = true;
            Chamalogin();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)  // clicou na palavra Usuario:
        {
            alterarUsuario = true;
            Chamalogin();
        }

        private void Chamalogin()
        {
            frmLogin flogin = new frmLogin();
            flogin.alteraUser = alterarUsuario;
            flogin.ShowDialog();    //---vou deixar desativado por enquanto
            tssUser.Text = flogin.User;
            Biblioteca.Settings.Default.User = tssUser.Text;
            alterarUsuario = false;
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadUsuarios Cadusuarios = new frmCadUsuarios();
            CheckMdiChildren(Cadusuarios);

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadCliente CadCliente = new frmCadCliente();
            CheckMdiChildren(CadCliente);
        }

        private void tsbCadUsuarios_Click(object sender, EventArgs e)
        {
            frmCadUsuarios Cadusuarios = new frmCadUsuarios();
            CheckMdiChildren(Cadusuarios);
        }

        private void tsbConsUsuarios_Click(object sender, EventArgs e)
        {

            frmConsUsuarios ConsUsuarios = new frmConsUsuarios();
            CheckMdiChildren(ConsUsuarios);
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmConsUsuarios ConsUsuarios = new frmConsUsuarios();
            CheckMdiChildren(ConsUsuarios);
        }

        private void tsbConsLojistas_Click(object sender, EventArgs e)
        {

            frmConsLojista ConsLojista = new frmConsLojista();
            CheckMdiChildren(ConsLojista);
        }

        private void lojistasToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            frmConsLojista ConsLojista = new frmConsLojista();
            CheckMdiChildren(ConsLojista);
        }

        private void tsbConsClientes_Click(object sender, EventArgs e)
        {

            frmConsCliente ConsCliente = new frmConsCliente();
            CheckMdiChildren(ConsCliente);
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            frmConsCliente ConsCliente = new frmConsCliente();
            CheckMdiChildren(ConsCliente);
        }

        private void promocaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfigPromocoes frmPromocoes = new frmConfigPromocoes();
            CheckMdiChildren(frmPromocoes);
        }

        private void tsbCadCupons_Click(object sender, EventArgs e)
        {
            frmCadCupons frmCadCupom = new frmCadCupons();
            CheckMdiChildren(frmCadCupom);
        }

        private void cuponsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadCupons frmCadCupom = new frmCadCupons();
            CheckMdiChildren(frmCadCupom);
        }

        private void SobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre frmsobre = new frmSobre();
            CheckMdiChildren(frmsobre);
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRelUsuarios relUsuarios = new frmRelUsuarios();
            CheckMdiChildren(relUsuarios);
        }

        private void lojistasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmRelLojistas relLojistas = new frmRelLojistas();
            CheckMdiChildren(relLojistas);
        }

        private void clientesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmRelClientes relClientes = new frmRelClientes();
            CheckMdiChildren(relClientes);
        }

        private void gerencialDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsVendasLojista ConsVendasLojista = new frmConsVendasLojista();
            CheckMdiChildren(ConsVendasLojista);
        }

        private void consultaCuponsTouchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsCuponsTouch ConsCuponsTouch = new frmConsCuponsTouch();
            CheckMdiChildren(ConsCuponsTouch);
        }

        private void tsbConsTouch_Click(object sender, EventArgs e)
        {
            frmConsCuponsTouch ConsCuponsTouch = new frmConsCuponsTouch();
            //CheckMdiChildren(ConsCuponsTouch);
            ConsCuponsTouch.ShowDialog();
        }

        private void tsbConfig_Click(object sender, EventArgs e)
        {
            frmConfigPromocoes frmPromocoes = new frmConfigPromocoes();
            CheckMdiChildren(frmPromocoes);
        }

        private void validadorDeCupomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmValidadorQrCode frmQRCode = new frmValidadorQrCode();
            CheckMdiChildren(frmQRCode);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //frmValidadorQrCode frmQRCode = new frmValidadorQrCode();
            frmValidaCupomSorteado frmQRCode = new frmValidaCupomSorteado();
            CheckMdiChildren(frmQRCode);
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            string mensagem = banco.Backup();
            if (mensagem.Contains("BACKUP DATABASE successfully processed"))
            { MessageBox.Show("Backup realizado com sucesso !"); }//MessageBox.Show(mensagem); }
            else
            { MessageBox.Show("Houve um erro ao efetuar o Backup"); }

        }

        private void ramosDeAtividadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRamosAtividade frmRamos = new frmRamosAtividade();
            CheckMdiChildren(frmRamos);
        }
    }

}




// Funcionalidades Principais do sistema:
/*
 * Manutencao de usuario (cadastro, alteracao, desativacao)
Manutencao de lojista(cadastro, alteracao, desativacao)
Manutencao de Clientes (cadastro, alteracao, desativacao)
Manutencao de Cupons (cadastrar e consultar cupons para os clientes)
Relatorios
Consultas
Configurações de Parametros internos (como valor do cupom)
impressao de cupons
*/

