using System;
using Biblioteca;
using Funcoes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.IO;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Drawing.Printing;

namespace Cupons.View
{
    public partial class frmValidaCupomSorteado : Form
    {
        private IList<Stream> m_streams;   // para impressao ticket direto printer
        private int m_currentPageIndex;   // para impressao ticket direto printer

        private String message = "";
        public frmValidaCupomSorteado()
        {
            InitializeComponent();
            lblcpf.Text = "";
            lblcupom.Text = "";
            lblnome.Text = "";
            lbldata.Text = "";
            painelDados.Visible = false;
        }
        //string modelo = "4850584948584948325449485047484947574850514937373737373737698478697376673279683269777978424242424242424242424242424242424242424242424242424242424242424242424242424242424242424242353535355656575154535256505048";


        private void btnDecode_Click(object sender, EventArgs e)
        {

            string decoded = txtqrCode.Text.Trim();


            if (decoded != null)
            {
                if (decoded.Length == 208)
                {
                    //painelDados.Visible = true;
                    message = ValidaQRCode(decoded);

                    //    MessageBox.Show(decoded);
                }
                else
                {
                    MessageBox.Show("O QRCode não pode ser autenticado no sistema.\nPossivelmente esse código não seja válido ou não é um Cupom da promoção.", "Erro", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                }
            }




        }

        private void frmValidaCupomSorteado_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ao pressionar enter vai para proximo campo
            if ((e.KeyChar == 13))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }

        }

        private string ValidaQRCode(string strCodigo)
        {
            string montatemp = "";
            int indice = 0;

            for (int pos = 0; pos < strCodigo.Length; pos += 2)
            {
                montatemp += ((char)Convert.ToInt16(strCodigo.Substring(pos, 2))).ToString();
                indice++;
            }

            string convertida = reverseString(montatemp);
            painelDados.Visible = true;
            lblcpf.Text = String.Format(@"{0:000\.000\.000\-00}", Convert.ToDouble(convertida.Substring(0, 15).Replace('#', ' ').Trim()));
            lblnome.Text = convertida.Substring(15, 60).Replace('*', ' ').Trim();
            lblcupom.Text = convertida.Substring(75, 10).Replace('%', ' ').Trim().PadLeft(8, '0');
            txtCupom.Text = convertida.Substring(75, 10).Replace('%', ' ').Trim();
            lbldata.Text = convertida.Substring(85, 19);
            return convertida;
        }

        private string reverseString(string Word)
        {
            char[] arrChar = Word.ToCharArray();
            Array.Reverse(arrChar);
            string invertida = new String(arrChar);

            return invertida;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpaPainelCliente();
            painelCliente.Visible = false;
            btnImprimir.Visible = false;
            btnLimpar2.Visible = false;

            painelDados.Visible = false;
            lblcpf.Text = "";
            lblcupom.Text = "";
            lbldata.Text = "";
            lblnome.Text = "";
            txtCupom.Clear();
            txtqrCode.Clear();
            txtqrCode.Focus();

        }

        private void btnBuscarCupom_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCupom.Text))
            {
                Banco BancoBuscaCupom = new Banco();
                DataTable dtCupom = new DataTable();
                dtCupom.Clear();
                dtCupom = BancoBuscaCupom.BuscaCupom(txtCupom.Text);
                if (dtCupom != null && dtCupom.Rows.Count > 0)
                {
                    Int32 idCliente = Convert.ToInt32(dtCupom.Rows[0]["idCliente"].ToString().Trim());

                    Banco bancoCliente = new Banco();
                    DataTable dtCliente = new DataTable();
                    dtCliente.Clear();
                    dtCliente = BancoBuscaCupom.ConsultaIDCliente(idCliente);

                    btnImprimir.Visible = true;
                    btnLimpar2.Visible = true;
                    painelCliente.Visible = true;

                    PreencheCampos(dtCliente);
                    btnImprimir.Focus();



                }
                else
                {
                    // colocar mensagem que nao encontrou o cupom
                }

            }

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            StringBuilder strDadosGanhador = new StringBuilder();
            strDadosGanhador.Clear();
            strDadosGanhador.Append("CPF: " + mskCPF.Text).AppendLine();
            strDadosGanhador.Append("Nome: " + txtNome.Text).AppendLine();
            strDadosGanhador.Append("Endereço: " + txtEndereco.Text);
            strDadosGanhador.Append("  " + txtEnderecoNumero.Text).AppendLine();
            strDadosGanhador.Append("Complemento: " + txtEnderecoComplemento.Text).AppendLine();
            strDadosGanhador.Append("Bairro: " + txtBairro.Text).AppendLine();
            strDadosGanhador.Append("Cidade: " + txtCidade.Text);
            strDadosGanhador.Append("  Estado: " + txtUF.Text).AppendLine();
            strDadosGanhador.Append("CEP: " + mskCEP.Text).AppendLine();
            strDadosGanhador.Append("Fone Fixo: " + mskFoneFixo.Text).AppendLine();
            strDadosGanhador.Append("Celular1: " + mskFoneCelular1.Text).AppendLine();
            strDadosGanhador.Append("Celular2: " + mskFoneCelular2.Text).AppendLine();
            strDadosGanhador.Append("Whatsapp: " + mskWhatsapp.Text).AppendLine();
            strDadosGanhador.Append("Email: " + txtEmail.Text).AppendLine();
            strDadosGanhador.Append("Observação: " + txtObservacao.Text).AppendLine();
            strDadosGanhador.AppendLine();

            ReportParameter[] reportParameter = new ReportParameter[2];
            reportParameter[0] = new ReportParameter("DadosGanhador", strDadosGanhador.ToString());
            reportParameter[1] = new ReportParameter("CupomNumero", txtCupom.Text.ToString());

            ReportViewer rv2 = new ReportViewer();
            rv2.Reset();
            rv2.ProcessingMode = ProcessingMode.Local;
            rv2.LocalReport.EnableExternalImages = true;
            rv2.LocalReport.ReportEmbeddedResource = "Cupons.View.repCupomGanhador.rdlc";
            rv2.LocalReport.SetParameters(reportParameter);
            rv2.LocalReport.Refresh();

            Export(rv2.LocalReport);
            m_currentPageIndex = 0;
            Print();
        }

        private void Export(LocalReport report)
        {
            Warning[] warnings;
            string deviceInfo =
          "<DeviceInfo>" +
          "  <OutputFormat>EMF</OutputFormat>" +
          "  <PageWidth>8cm</PageWidth>" +
          "  <PageHeight>17cm</PageHeight>" +
          "  <MarginTop>0cm</MarginTop>" +
          "  <MarginLeft>0cm</MarginLeft>" +
          "  <MarginRight>0cm</MarginRight>" +
          "  <MarginBottom>1cm</MarginBottom>" +
          "</DeviceInfo>";

            m_streams = new List<Stream>();
            report.Render("Image", deviceInfo, CreateStream, out warnings);
            foreach (Stream stream in m_streams)
            {
                stream.Position = 0;
            }
        }

        private Stream CreateStream(string name, string fileNameExtension, Encoding encoding,
                             string mimeType, bool willSeek)
        {
            Stream stream = new MemoryStream();
            m_streams.Add(stream);
            return stream;
        }

        private void Print()
        {
            //const string printerName = Biblioteca.Settings.Default.Impressora.ToString();
            //string printerName = Biblioteca.Settings.Default.Impressora.ToString();   //recebe o nome da impressora das propriedades
            // colocar rotina para pegar a impressora padrao do sistema e enviar para ela...
            string printerName = ImpressoraPadrao();
            if (String.IsNullOrEmpty(printerName))
            {
                MessageBox.Show("Verifique se a impressora está instalada corretamente.", "Erro", MessageBoxButtons.OK,
                            MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                if (m_streams == null || m_streams.Count == 0)
                    return;

                PrintDocument printDoc = new PrintDocument();
                printDoc.PrinterSettings.PrinterName = printerName;   // aqui ele vai usar o nome da impressora que foi definida

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

                    printDoc.Print();
                    //Dispose();
                }
            }
        }

        private string ImpressoraPadrao()
        {

            PrinterSettings settings = new PrinterSettings();
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                settings.PrinterName = printer;
                if (settings.IsDefaultPrinter)
                    return printer;
            }
            return string.Empty;
        }


        private void PrintPage(object sender, PrintPageEventArgs ev)
        {
            Metafile pageImage = new Metafile(m_streams[m_currentPageIndex]);

            Rectangle adjustedRect = new Rectangle(
                ev.PageBounds.Left - (int)ev.PageSettings.HardMarginX,
                ev.PageBounds.Top - (int)ev.PageSettings.HardMarginY,
                78, 130);    // tamanho do cupom    75x120    // tava 77,140

            // Draw a white background for the report
            ev.Graphics.FillRectangle(Brushes.White, adjustedRect);

            ev.Graphics.PageUnit = GraphicsUnit.Millimeter;

            //ev.Graphics.PageScale = 3f;

            // Draw the report content
            ev.Graphics.DrawImage(pageImage, adjustedRect);
            //ev.Graphics.DrawImage(pageImage, ev.PageBounds); // se ficar ruim por a linha de cima;...

            // Prepare for the next page. Make sure we haven't hit the end.
        }






        private void limpaPainelCliente()
        {
            mskCPF.Clear();
            txtNome.Clear();
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
            mskWhatsapp.Clear();
            txtEmail.Clear();
            txtObservacao.Clear();
        }

        private void PreencheCampos(DataTable dtCli)
        {
            mskCPF.Text = dtCli.Rows[0]["CPF"].ToString().Trim();
            txtNome.Text = dtCli.Rows[0]["Nome"].ToString().Trim();
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
            mskWhatsapp.Text = dtCli.Rows[0]["Whatsapp"].ToString().Trim();
            txtEmail.Text = dtCli.Rows[0]["Email"].ToString().Trim();
            txtObservacao.Text = dtCli.Rows[0]["Observacao"].ToString().Trim();
        }


    }
}



//ReportViewer rv1 = new ReportViewer();
//rv1.Reset();
//rv1.LocalReport.ReportPath = Application.StartupPath + @"\View\repCupomGanhador.rdlc";  // modo release
//rv1.LocalReport.ReportPath = Application.StartupPath + @"\..\..\..\View\repCupomGanhador.rdlc";  // modo debug


//rv1.LocalReport.SetParameters(reportParameter);
//rv1.LocalReport.Refresh();

//Impressao autoPrint = new Impressao(rv1.LocalReport);
//autoPrint.Print();




//Warning[] warnings;
//    string[] streamids;
//    string mimeType;
//    string encoding;
//    string extension;

/*
 *string deviceInfo =
 "<DeviceInfo>" +
 //"  <OutputFormat>PDF</OutputFormat>" +
 "  <OutputFormat>PDF</OutputFormat>" +
 "  <PageWidth>8cm</PageWidth>" +
 "  <PageHeight>17cm</PageHeight>" +  // tava 15 cm
 "  <MarginTop>0cm</MarginTop>" +    // TAVA 1 CM
 "  <MarginLeft>0cm</MarginLeft>" +
 "  <MarginRight>0cm</MarginRight>" +
 "  <MarginBottom>1cm</MarginBottom>" +
 "</DeviceInfo>";

   byte[] bytePDF = rv2.LocalReport.Render("PDF", deviceInfo, out mimeType, out encoding, out extension, out streamids, out warnings);

   FileStream fileStreamPDF = null;
   string nomeArquivoPDF = Path.GetTempPath() + "Ticket_" + DateTime.Now.ToString("dd_MM_yyyy-HH_mm_ss") + ".pdf";

   fileStreamPDF = new FileStream(nomeArquivoPDF, FileMode.Create);
   fileStreamPDF.Write(bytePDF, 0, bytePDF.Length);
   fileStreamPDF.Close();
   Process.Start(nomeArquivoPDF);
   //
   //
   */

