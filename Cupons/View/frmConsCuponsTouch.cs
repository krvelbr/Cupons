using Funcoes;
using Biblioteca;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cupons.View
{
    public partial class frmConsCuponsTouch : Form
    {
        public frmConsCuponsTouch()
        {
            InitializeComponent();
            inicia(); // chama funcao para iniciar controles
        }
        int ticket = Biblioteca.Settings.Default.ValorPromocao;
        DataTable dtConsCupons = new DataTable();
        DataTable dtTemp = new DataTable();
        int botao = 0;
        string acao = "";
        private IList<Stream> m_streams;   // para impressao ticket direto printer
        private int m_currentPageIndex;   // para impressao ticket direto printer



        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                                      Color.Green,
                                                                      Color.White,
                                                                      90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }

        }


        // funcao abaixo server para repintar a tela quando fizer um resize

        private void alinhapnl()  // ver se consigo receber o controle e alinhar na horizontal.
        {
            // obj = localobj;
            // obj.Anchor = AnchorStyles.None;
            // obj.Left = (this.ClientSize.Width - obj.Width) / 2;
            // obj.Top = (this.ClientSize.Height - obj.Height) / 2;

            pnlMenu1.Anchor = AnchorStyles.None;
            pnlMenu1.Left = (this.ClientSize.Width - pnlMenu1.Width) / 2;
            pnlMenu1.Top = (this.ClientSize.Height - pnlMenu1.Height) / 2;
        }


        private void inicia()
        {
            this.WindowState = FormWindowState.Maximized;  // maximiza o formulario principal

            this.MinimizeBox = false;  // desativa o botão de minimizar
            this.MaximizeBox = false;  // desativa o botão de maximizar

            pnlCPF.Visible = false;
            pnlBotoes1.Visible = false;
            pnlNotFound.Visible = false;
            pnlConsultaSaldo.Visible = false;
            pnlCreditos.Visible = false;
            pnlMenu1.Visible = true;
            btnOK.Visible = false;
            pnlTeclado.Visible = false;
            mskCPF.Clear();
            botao = 0;
            acao = "";
            //clienteId = 0;
            alinhapnl();   // chama a rotina de alinhamento dos botoes iniciais
        }

        private void frmConsCuponsTouch_Load(object sender, EventArgs e)
        {
            inicia();
            lblValorTroca.Text = ticket.ToString() + ",00";
        }

        private void frmConsCuponsTouch_Resize(object sender, EventArgs e)
        {
            this.Invalidate(); // invalida o form e força que seja repintado.
                               //      btnConfig.Left = this.ClientSize.Width - 100;
        }



        private void btnNome_Click(object sender, EventArgs e)
        {
            mskCPF.Clear();
            acao = "Saldo";
            Consultar_Saldo();

        }

        private void btnVolta1_Click(object sender, EventArgs e)
        {
            MenuInicio();
            alinhapnl();
        }

        private void Consultar_Saldo()
        {
            //System.Diagnostics.Process.Start("osk.exe");   // chama o teclado virtual do windows.
            pnlCPF.Anchor = AnchorStyles.None;
            pnlCPF.Left = (this.ClientSize.Width - pnlCPF.Width) / 2;
            pnlCPF.Top = (this.ClientSize.Height - (pnlCPF.Height + pnlBotoes1.Height + pnlTeclado.Height)) / 2; //coloquei +80 para subir um pouco
            pnlTeclado.Left = (this.ClientSize.Width - pnlTeclado.Width) / 2;
            pnlTeclado.Top = pnlCPF.Bottom + 20;
            pnlTeclado.Visible = true;
            pnlBotoes1.Top = pnlTeclado.Bottom + 20;
            pnlBotoes1.Left = (this.ClientSize.Width - pnlBotoes1.Width) / 2;
            pnlMenu1.Visible = false;
            pnlBotoes1.Visible = true;
            pnlCPF.Visible = true;

            mskCPF.Focus();
        }

        private void painelNotFound()
        {
            pnlTeclado.Visible = false;
            pnlBotoes1.Visible = false;
            pnlNotFound.Top = pnlTeclado.Top;
            pnlNotFound.Left = (this.ClientSize.Width - pnlNotFound.Width) / 2;
            pnlNotFound.Visible = true;
        }


        private void MenuInicio()
        {
            mskCPF.Clear();
            inicia();

        }

        private void btnProcuraNome_Click(object sender, EventArgs e)
        {
            if (acao == "Saldo")
            {
                if (!String.IsNullOrEmpty(mskCPF.Text))
                {
                    dtConsCupons.Clear();
                    dtConsCupons = SaldoCupons(mskCPF.Text);


                    if (dtConsCupons != null && dtConsCupons.Rows.Count > 0) //verifica se datatable esta nulo ou vazio
                    {
                        pnlCPF.Visible = false;
                        pnlMenu1.Visible = false;
                        pnlNotFound.Visible = false;
                        pnlBotoes1.Visible = false;
                        pnlTeclado.Visible = false;


                        pnlConsultaSaldo.Visible = true;
                        pnlCreditos.Visible = true;
                        pnlConsultaSaldo.Left = (this.ClientSize.Width - pnlConsultaSaldo.Width) / 2;
                        pnlConsultaSaldo.Top = (this.ClientSize.Height - pnlConsultaSaldo.Height) / 2;

                        lblCupons.Text = "";
                        lblNome.Text = "";
                        lblRestante.Text = "";
                        lblSaldo.Text = "";
                        lblTicket.Text = ticket.ToString() + ",00";

                        //lblNome.Text = dtConsCupons.Rows[0]["Nome"].ToString().Trim();
                        SaldoCupons(mskCPF.Text);
                        btnOK.Left = pnlConsultaSaldo.Left;
                        btnOK.Top = pnlConsultaSaldo.Bottom + 30;  // tira a altura do botao
                        botao = 1; // se for 1, quer dizer que o botao que vai mostrar e da mensagem final
                        btnOK.Visible = true;


                        decimal total = 0;
                        //soma a coluna de valores
                        string filter = "CPF = " + mskCPF.Text;
                        total = Convert.ToDecimal(dtConsCupons.Compute("Sum(ValorCompraCOO)", filter));
                        lblNome.Text = dtConsCupons.Rows[0]["Nome"].ToString().Trim();
                        lblCupons.Text = (Math.Truncate(total / ticket)).ToString().PadLeft(5, '0'); //dtCupons.Rows.Count.ToString().Trim().PadLeft(5, '0');    ///  aqui eu tenho que fazer um outro calculo... baseado no cadcupom pra pegar so a parte inteira
                        lblSaldo.Text = "R$ " + (total % ticket).ToString();
                        lblRestante.Text = "R$ " + (ticket - (total % ticket)).ToString();




                    }
                    else
                    {
                        lblNome.Text = "";
                        lblCupons.Text = "0";
                        lblSaldo.Text = "R$ 0,00";
                        lblRestante.Text = "R$ " + ticket + ",00";

                        painelNotFound();
                        botao = 2; // se for 2, quer dizer que o botao que vai mostrar e da mensagem de erro
                        btnOK.Left = (this.ClientSize.Width - btnOK.Width) / 2;
                        btnOK.Top = pnlNotFound.Bottom + 30;  // tira a altura do botao
                        btnOK.Visible = true;
                    }

                }
            }
            if (acao == "Extrato")
            {
                if (!String.IsNullOrEmpty(mskCPF.Text))
                {
                    dtConsCupons.Clear();
                    dtConsCupons = ExtratoCupons(mskCPF.Text);

                    if (dtConsCupons != null && dtConsCupons.Rows.Count > 0) //verifica se datatable esta nulo ou vazio
                    {
                        string cuponsemitidos = "";
                        foreach (DataRow linha in dtConsCupons.Rows)
                        {
                            cuponsemitidos = cuponsemitidos + linha["noCupom"].ToString().PadLeft(6, '0') + "    ";

                        }
                        var Extr = new Extrato
                        {
                            header1 = "", //"Promoção Natal de Prêmios",
                            header2 = "", //"Shopping daqui da cidade",
                            header3 = "", //"Av. Frei Serafim, 890",
                            header4 = lblNome.Text,
                            Cupons = cuponsemitidos
                        };


                        Imprimir(Extr);

                        MessageBox.Show("Extrato de Cupons Emitido. Obrigado !", "Erro", MessageBoxButtons.OK,
                                                      MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        //clienteId = Convert.ToInt32(dtConsCupons.Rows[0]["CodigoCliente"].ToString().Trim());
                        inicia();
                    }
                    else
                    {
                        string msg = String.Format("Não existem cupons cadastrados para esse CPF.");
                        MessageBox.Show(msg, "Erro", MessageBoxButtons.OK,
                                                          MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        mskCPF.Focus();
                        SendKeys.SendWait("\b");
                    }
                }
            }
        }

        private void Imprimir(Extrato lsTemp)
        {
            DataSet ds = new DataSet();
            List<Extrato> lsTemp2 = new List<Extrato>();
            lsTemp2.Add(lsTemp);
            LocalReport report = new LocalReport();
            //report.ReportPath = Application.StartupPath + @"\..\..\..\View\repExtratoTickets.rdlc";  // modo debug
            report.ReportPath = Application.StartupPath + @"\View\repExtratoTickets.rdlc";    // modo release
            report.DataSources.Add(new ReportDataSource("dsExtrato", lsTemp2));
            //List<ReportParameter> ListaParametros = new List<ReportParameter>();
            //ListaParametros.Add(new ReportParameter("header1" , "Promoção Natal de Prêmios"));  //usar variavel depois
            //ListaParametros.Add(new ReportParameter("header2" , "Shopping daqui da cidade"));  //usar variavel depois
            //ListaParametros.Add(new ReportParameter("header3" , "Av. Frei Serafim, 890"));  //usar variavel depois
            //ListaParametros.Add(new ReportParameter("header4" , "Centro - Teresina - PI"));  //usar variavel depois
            //report.LocalReport.SetParameters(ListaParametros)
            Export(report);
            m_currentPageIndex = 0;
            Print();
        }


        private void Export(LocalReport report)
        {
            string deviceInfo =
      "<DeviceInfo>" +
      //"  <OutputFormat>PDF</OutputFormat>" +
      "  <OutputFormat>EMF</OutputFormat>" +
      "  <PageWidth>8cm</PageWidth>" +
      "  <PageHeight>27cm</PageHeight>" +
      "  <MarginTop>1cm</MarginTop>" +
      "  <MarginLeft>0cm</MarginLeft>" +
      "  <MarginRight>0cm</MarginRight>" +
      "  <MarginBottom>1cm</MarginBottom>" +
      "</DeviceInfo>";
            Warning[] warnings;
            //string[] streamids;
            // string mimeType;
            //string encoding;
            //string extension;

            m_streams = new List<Stream>();
            //report.Render("PDF", deviceInfo, CreateStream, out warnings);
            report.Render("Image", deviceInfo, CreateStream, out warnings);
            foreach (Stream stream in m_streams)
            {
                stream.Position = 0;

            }
        }

        private Stream CreateStream(string name, string fileNameExtension, Encoding encoding,
                             string mimeType, bool willSeek)
        {
            //Stream stream = new FileStream(Path.GetTempPath() + "Ticket_" + DateTime.Now.ToString("dd_MM_yyyy-HH_mm_ss") + "."+fileNameExtension, FileMode.Create);
            Stream stream = new MemoryStream();
            m_streams.Add(stream);
            return stream;
        }

        private void Print()
        {
            //const string printerName = Properties.Settings.Default.Impressora.ToString();
            string printerName = Biblioteca.Settings.Default.Impressora.ToString();   //recebe o nome da impressora das propriedades

            if (m_streams == null || m_streams.Count == 0)
                return;

            PrintDocument printDoc = new PrintDocument();
            printDoc.PrinterSettings.PrinterName = printerName;

            //////
            //PaperSize paperSize = new PaperSize("My Ticket", 289, 566);
            //paperSize.RawKind = (int)PaperKind.Custom;
            //printDoc.DefaultPageSettings.PaperSize = paperSize;
            //////

            if (!printDoc.PrinterSettings.IsValid)
            {
                string msg = String.Format("Não foi possível encontrar a impressora \"{0}\".", printerName);
                MessageBox.Show(msg, "Erro", MessageBoxButtons.OK,
                              MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
            else
            {
                printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
                m_currentPageIndex = 0;
                //printDoc.PrinterSettings.PrinterResolutions=
                printDoc.Print();
                //Dispose();
            }
        }

        private void PrintPage(object sender, PrintPageEventArgs ev)
        {
            Metafile pageImage = new Metafile(m_streams[m_currentPageIndex]);



            Rectangle adjustedRect = new Rectangle(
                  ev.PageBounds.Left - (int)ev.PageSettings.HardMarginX,
                  ev.PageBounds.Top - (int)ev.PageSettings.HardMarginY,
                  77, 220);    // tamanho do cupom    75x140


            // Draw a white background for the report
            ev.Graphics.FillRectangle(Brushes.White, adjustedRect);

            ev.Graphics.PageUnit = GraphicsUnit.Millimeter;

            //ev.Graphics.PageScale = 3f;

            // Draw the report content
            ev.Graphics.DrawImage(pageImage, adjustedRect);

            // Prepare for the next page. Make sure we haven't hit the end.
            m_currentPageIndex++;
            ev.HasMorePages = (m_currentPageIndex < m_streams.Count);
        }


        


        /*
        private void RealizaImpressao()
        {
            PrintDialog printDialog1 = new PrintDialog();

            PrintDocument print = new PrintDocument();
            print.PrinterSettings.PrinterName = Properties.Settings.Default.Impressora.ToString();
            print.PrintPage += new PrintPageEventHandler(Print_PrintPage);
            print.Print();

            /*
            DialogResult resultado = printDialog1.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                using (PrintPreviewDialog dialog = new PrintPreviewDialog())
                {
                    dialog.Document = print;
                    dialog.ShowDialog();
                }

            }
            inicia();

        }

        private void Print_PrintPage(object sender, PrintPageEventArgs ev)
        {
            string header1 = "Promoção Natal\n de Prêmios";
            string header2 = "Shopping daqui da cidade";
            string header3 = "Av. Frei Serafim, 890";
            string header4 = "Centro - Teresina - PI";
            string texto = "Você está concorrendo com os seguintes cupons:";
            string rodape = "Boa Sorte !";

            //Rectangle adjustedRect = new Rectangle(
            //    ev.PageBounds.Left - (int)ev.PageSettings.HardMarginX,
            //    ev.PageBounds.Top - (int)ev.PageSettings.HardMarginY,
            //    77, 140);    // tamanho do cupom    75x120

            // Draw a white background for the report
            //ev.Graphics.FillRectangle(Brushes.White, adjustedRect);

            Graphics g = ev.Graphics;
            g.PageUnit = GraphicsUnit.Millimeter;
            ev.Graphics.Clip = new Region(new Rectangle(0, 0, 77, 140));

            // Fill the region.
            ev.Graphics.FillRegion(Brushes.White, ev.Graphics.Clip);

            

            Font Header = new Font("Arial", 16, FontStyle.Bold);
            Font subHeader = new Font("Arial", 10);
            Font subrodape = new Font("Arial", 14);
            Font font = new Font("Times New Roman", 12);

            g.DrawString(header1, Header, Brushes.Black, 15, 10);   // x,y
            g.DrawString(header2, subHeader, Brushes.Black, 12, 25);
            g.DrawString(header3, subHeader, Brushes.Black, 20, 30);
            g.DrawString(header4, subHeader, Brushes.Black, 20, 35);
            g.DrawLine(new Pen(Color.Black,1), 5, 45, 75, 45);
            g.DrawString(texto, font, Brushes.Black, 20, 50);


            // drawline 5,328 to 300,328
            //g.DrawString("Titulo", font, Brushes.Black, 5, 66);

        }
  */

        private DataTable ExtratoCupons(string txtCPF)
        {
            Banco bancoCupons = new Banco();
            DataTable dtCupons = new DataTable();
            dtCupons.Clear();
            dtCupons = bancoCupons.ExtratoCuponsCPF(txtCPF);
            return dtCupons;
        }

        private DataTable SaldoCupons(String txtCPF)
        {
            Banco bancoCupons = new Banco();
            DataTable dtCupons = new DataTable();
            dtCupons.Clear();
            dtCupons = bancoCupons.ConsultaCuponsCPF(txtCPF);
            return dtCupons;
        }

        /*
            ////////// ja faz a soma do total dos valores
            if (dtCupons.Rows.Count > 0)
            {
                if (acao == "Saldo")
                {
                    decimal total = 0;
                    //soma a coluna de valores
                    string filter = "CPF = " + txtCPF;
                    total = Convert.ToDecimal(dtCupons.Compute("Sum(ValorCompraCOO)", filter));
                    lblNome.Text = dtCupons.Rows[0]["Nome"].ToString().Trim();
                    lblCupons.Text = (Math.Truncate(total / ticket)).ToString().PadLeft(5, '0'); //dtCupons.Rows.Count.ToString().Trim().PadLeft(5, '0');    ///  aqui eu tenho que fazer um outro calculo... baseado no cadcupom pra pegar so a parte inteira
                    lblSaldo.Text = "R$ " + (total % ticket).ToString();
                    lblRestante.Text = "R$ " + (ticket - (total % ticket)).ToString();
                }
                else
                {
                    lblNome.Text = "";
                    lblCupons.Text = "0";
                    lblSaldo.Text = "R$ 0,00";
                    lblRestante.Text = "R$ " + ticket + ",00";
                }
            }
                return dtCupons;
            }
            */



        private void frmConsCuponsTouch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Q)
            {
                this.Close();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (botao == 1)
            { inicia(); }
            if (botao == 2)
            {
                pnlNotFound.Visible = false;
                pnlTeclado.Visible = true;
                pnlBotoes1.Visible = true;
                mskCPF.Focus();
                btnOK.Visible = false;
            }

        }

        private void numeros(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            mskCPF.Focus();
            System.Windows.Forms.SendKeys.SendWait(btn.Text);

        }

        private void btnApaga_Click(object sender, EventArgs e)
        {
            mskCPF.Focus();
            SendKeys.SendWait("\b");  // --->  \b é o codigo do Backspace
        }

        private void btnExtrato_Click(object sender, EventArgs e)
        {
            acao = "Extrato";
            Consultar_Saldo();

        }
    }

    public class Extrato
    {
        public string header1 { get; set; }
        public string header2 { get; set; }
        public string header3 { get; set; }
        public string header4 { get; set; }
        public string Cupons { get; set; }

    }
}
