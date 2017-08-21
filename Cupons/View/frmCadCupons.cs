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

//using Microsoft.Reporting.WebForms;
using Microsoft.Reporting.WinForms;
using System.IO;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Drawing.Printing;


namespace Cupons.View
{
    public partial class frmCadCupons : Form
    {
        public frmCadCupons()
        {
            InitializeComponent();
        }
        int ticket = 0;
        DataTable dtCliente = new DataTable();
        DataTable dtLoja = new DataTable();
        DataTable dtCupom = new DataTable();
        Banco bancoCupons = new Banco();
        Int32 idLoja;
        Int32 idCliente;
        bool impresso = false;
        int totalcuponsimpressos;
        int totalcuponsgerar;
        private IList<Stream> m_streams;   // para impressao ticket direto printer
        private int m_currentPageIndex;   // para impressao ticket direto printer

        private void frmCadCupons_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ao pressionar enter vai para proximo campo
            if ((e.KeyChar == 13))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
            
        }

        private void frmCadCupons_Load(object sender, EventArgs e)
        {

            dgvCuponsGerados.AutoGenerateColumns = false;
            dgvCuponsGerados.ColumnCount = 1;
            dgvCuponsGerados.Columns[0].HeaderText = "CUPOM No.";
            dgvCuponsGerados.Columns[0].DataPropertyName = "noCupom";
            dgvCuponsGerados.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dtCliente.Clear();
            dtCupom.Clear();
            dtLoja.Clear();
            ticket = Biblioteca.Settings.Default.ValorPromocao;   // pega valor do ticket nas propriedades

            limpaCampos();
            EnableCampos(true);
            mskCPF.Focus();
            SendKeys.Send("{BACKSPACE}");
        }

        private void EnableCampos(bool stats)
        {
            //btnConsultaCNPJ.Enabled = stats;
            //mskCNPJ.Enabled = stats;
            mskCPF.Enabled = stats;
            btnConsultaCPF.Enabled = stats;
            grbDadosCF.Enabled = !stats;
            grbCuponsFiscaisCadastrados.Enabled = !stats;
            GrbCuponsGerados.Enabled = !stats;
            mskDataCupom.Enabled = !stats;
            txtNumeroCOO.Enabled = !stats;
            txtValorCupom.Enabled = !stats;
        }

        private void btnConsultaCNPJ_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(mskCNPJ.Text))
            {
                dtLoja.Clear();
                Banco bancoCupons = new Banco();
                dtLoja = bancoCupons.ConsultaLojista(mskCNPJ.Text);

                if (dtLoja != null && dtLoja.Rows.Count > 0) //verifica se datatable esta nulo ou vazio
                {
                    mskCNPJ.Enabled = false;
                    btnConsultaCNPJ.Enabled = false;
                    //txtNomeLoja.Text = dtLoja.Rows[0]["FantasiaLojista"].ToString().Trim() + "  -  " + dtLoja.Rows[0]["RazaoLojista"].ToString().Trim();
                    lblFantasia.Text = dtLoja.Rows[0]["FantasiaLojista"].ToString().Trim();
                    lblFantasia.Visible = true;
                    idLoja = Convert.ToInt32(dtLoja.Rows[0]["id"].ToString().Trim());
                    mskDataCupom.Enabled = true;
                    txtNumeroCOO.Enabled = true;
                    txtValorCupom.Enabled = true;
                    mskDataCupom.Focus();
                    SendKeys.Send("{BACKSPACE}");
                }
                else
                {
                    MessageBox.Show("CNPJ não está cadastrado no Banco de Dados.\nFavor corrigir ou cadastrar.", "Erro", MessageBoxButtons.OK,
               MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    mskCNPJ.Focus();
                    //  SendKeys.Send("{BACKSPACE}");
                }
            }
        }

        private void btnConsultaCPF_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(mskCPF.Text))
            {
                dtCliente.Clear();
                Banco bancoCupons = new Banco();
                dtCliente = bancoCupons.ConsultaCliente(mskCPF.Text);

                if (dtCliente != null && dtCliente.Rows.Count > 0) //verifica se datatable esta nulo ou vazio
                {
                    //PreencheCampos(dtretorno);   // chama funcao para armazenar variaveis de uso do form
                    //  EnableCampos(false); ///desabilita os botoes e habilita os groupboxes
                    mskCPF.Enabled = false;
                    btnConsultaCPF.Enabled = false;
                    grbDadosCF.Enabled = true;
                    txtNomeCliente.Text = dtCliente.Rows[0]["Nome"].ToString().Trim();
                    idCliente = Convert.ToInt32(dtCliente.Rows[0]["id"].ToString().Trim());
                    mskCNPJ.Enabled = true;
                    btnConsultaCNPJ.Enabled = true;

                    ConsultaCuponsFiscais();
                    grbCuponsFiscaisCadastrados.Enabled = true;
                    mskCNPJ.Focus();
                    SendKeys.Send("{BACKSPACE}");
                    //////////////////////////
                    /////////////////////////
                    ////// fazer verificacao no banco se ja tem cupons pro groupbox de cupons
                    //////
                    /////////////////////////
                    /////////////////////////
                }
                else
                {
                    MessageBox.Show("CPF não está cadastrado no Banco de Dados.\nFavor corrigir ou cadastrar.", "Erro", MessageBoxButtons.OK,
               MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    mskCPF.Focus();
                    //SendKeys.Send("{BACKSPACE}");
                }


            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            btnGerarCupons.Visible = false;
            limpaCampos();
            EnableCampos(true);
            mskCPF.Focus();
            SendKeys.Send("{BACKSPACE}");
        }

        private void limpaCampos()
        {
            mskCNPJ.Clear();
            mskCPF.Clear();
            mskDataCupom.Clear();
            txtNomeCliente.Clear();
            txtNumeroCOO.Clear();
            txtValorCupom.Clear();
            dgvCuponsFiscais.DataSource = null;
            lblSaldoTotal.Text = "";
            lblTotalCupons.Text = "";
            lblSaldoCreditos.Text = "";
            lblCuponsImpressos.Text = "";
            lblCuponsGerar.Text = "";
            lblFantasia.Text = "";
            lblFantasia.Visible = false;
            GrbCuponsGerados.Enabled = false;

            //limpa as variaveis globais
            dtCliente.Clear();
            dtLoja.Clear();
            dtCupom.Clear();
            bancoCupons = null;
            idLoja = 0;
            idCliente = 0;
            impresso = false;
            totalcuponsimpressos = 0;
            totalcuponsgerar = 0;


        }

        private void btnGravarCupom_Click(object sender, EventArgs e)
        {
            int idCupom = 0;
            if (!String.IsNullOrEmpty(mskDataCupom.Text) && !String.IsNullOrEmpty(txtNumeroCOO.Text) && !String.IsNullOrEmpty(txtValorCupom.Text))
            {
                CuponsFiscais Cupom = new CuponsFiscais();
                Cupom._idLojista = Convert.ToInt32(dtLoja.Rows[0]["id"].ToString().Trim());
                Cupom._idCliente = Convert.ToInt32(dtCliente.Rows[0]["id"].ToString().Trim());
                Cupom._COO = Convert.ToInt32(txtNumeroCOO.Text);
                Cupom._DataCupomCOO = DateTime.ParseExact(mskDataCupom.Text.ToString(), "d/M/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                Cupom._ValorCompraCOO = Convert.ToDecimal(txtValorCupom.Text);
                Cupom._CadastradoPor = Biblioteca.Settings.Default.User;

                Banco bancoCupons = new Banco();
                string retorno = bancoCupons.InserirCupom(Cupom);

                if (int.TryParse(retorno, out idCupom) == true)
                {
                    Cupom._id = idCupom;
                    MessageBox.Show("Cupom Fiscal Cadastrado com Sucesso.", "Sucesso");
                    mskCNPJ.Clear();
                    mskDataCupom.Clear();
                    txtNumeroCOO.Clear();
                    txtValorCupom.Clear();
                    mskDataCupom.Enabled = false;
                    txtNumeroCOO.Enabled = false;
                    txtValorCupom.Enabled = false;
                    mskCNPJ.Enabled = true;
                    btnConsultaCNPJ.Enabled = true;
                    ConsultaCuponsFiscais();
                    //consulta cupons para preencher groupbox ao lado.
                    lblFantasia.Text = "";
                    mskCNPJ.Focus();
                    SendKeys.Send("{BACKSPACE}");
                }
                else
                {
                    MessageBox.Show("Houve um erro ao tentar cadastrar o Cupom.\n\n" + retorno, "Erro");
                    btnGravarCupom.Focus();
                    //SendKeys.Send("{BACKSPACE}");
                }
            }
            else
            {
                MessageBox.Show("Todos os campos do Cupom Fiscal devem ser preenchidos.\nVerificar se estão preenchidos corretamente.", "Erro", MessageBoxButtons.OK,
           MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                mskDataCupom.Focus();

            }
        }

        private void ConsultaCuponsFiscais()
        {
            decimal saldototal = 0;
            int totalcupons = 0;
            decimal saldocreditos = 0;
            int cuponsimpressos = 0;

            Banco bancoCupons = new Banco();
            dgvCuponsFiscais.DataSource = null;
            dtCupom.Clear();
            dtCupom = bancoCupons.ConsultaCuponsFiscaisCliente(idCliente);

            dgvCuponsFiscais.AutoGenerateColumns = false;
            dgvCuponsFiscais.ColumnCount = 4;
            dgvCuponsFiscais.Columns[0].HeaderText = "CNPJ";
            dgvCuponsFiscais.Columns[0].DataPropertyName = "CNPJLojista";
            dgvCuponsFiscais.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dgvCuponsFiscais.Columns[0].DefaultCellStyle.Format = @"00\.000\.000/0000-00";

            dgvCuponsFiscais.Columns[1].HeaderText = "Data do Cupom";
            dgvCuponsFiscais.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvCuponsFiscais.Columns[1].DataPropertyName = "DataCupomCOO";

            dgvCuponsFiscais.Columns[2].HeaderText = "COO do Cupom";
            dgvCuponsFiscais.Columns[2].DataPropertyName = "COO";
            dgvCuponsFiscais.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvCuponsFiscais.Columns[3].HeaderText = "Valor";
            dgvCuponsFiscais.Columns[3].DataPropertyName = "ValorCompraCOO";
            dgvCuponsFiscais.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvCuponsFiscais.DataSource = dtCupom;
            dgvCuponsFiscais.Refresh();
            dgvCuponsFiscais.Update();

            ////////// ja faz a soma do total dos valores
            if (dgvCuponsFiscais.Rows.Count > 0)
            {
                decimal total = 0;
                int i = 0;
                for (i = 0; i < dgvCuponsFiscais.Rows.Count; i++)
                {
                    total = total + Convert.ToDecimal(dgvCuponsFiscais.Rows[i].Cells[3].Value);  // pega a quarta coluna [3] com o Valor.
                }


                //buscar se tem cupons ja gerados para esse cliente
                DataTable dttickets = new DataTable();
                dttickets = bancoCupons.ConsultaTickets(Convert.ToInt32(dtCliente.Rows[0]["id"].ToString().Trim()));
                if (dttickets != null && dttickets.Rows.Count > 0) //verifica se datatable esta nulo ou vazio    
                {
                    GrbCuponsGerados.Enabled = true;
                    dgvCuponsGerados.DataSource = dttickets;
                    dgvCuponsGerados.Refresh();
                    dgvCuponsGerados.Update();

                    cuponsimpressos = dgvCuponsGerados.Rows.Count;
                }
                else
                { cuponsimpressos = 0; }

                totalcuponsimpressos = cuponsimpressos;   //define o valor pra variavel global
                saldototal = total;
                totalcupons = Convert.ToInt16(Math.Truncate(saldototal / ticket));
                totalcuponsgerar = Convert.ToInt16(Math.Truncate((saldototal / ticket) - totalcuponsimpressos));
                saldocreditos = (saldototal - (totalcupons * ticket));


                //lblSaldoCreditos.Text = (total - (ticket * Convert.ToInt32(lblCuponsImpressos.Text))).ToString();
                // Convert.ToInt32("0" + lblCuponsGerar.Text);
                //lblCuponsGerar.Text = ((Convert.ToInt16(lblSaldoTotal.Text) / ticket) - totalcuponsimpressos).ToString();


                lblTotalCupons.Text = totalcupons.ToString(); //ok
                lblSaldoTotal.Text = saldototal.ToString(); //ok
                lblSaldoCreditos.Text = saldocreditos.ToString(); //ok
                lblCuponsImpressos.Text = totalcuponsimpressos.ToString(); //ok
                lblCuponsGerar.Text = totalcuponsgerar.ToString(); //ok
            }
            if (totalcuponsgerar > 0)
            { btnGerarCupons.Visible = true; }
            else
            { btnGerarCupons.Visible = false; }

        }

        private void btnGerarCupons_Click(object sender, EventArgs e)
        {
            Banco bancoCupons = new Banco();

            var recibolist = new List<recibo>();

            Tickets t = new Tickets();
            List<Tickets> tlista = new List<Tickets>();
            tlista.Clear();
            recibolist.Clear();

            for (int i = 1; i < totalcuponsgerar + 1; i++)
            {
                t._idCliente = Convert.ToInt32(dtCliente.Rows[0]["id"].ToString().Trim());
                t._Impresso = impresso;
                t._GeradoPor = Biblioteca.Settings.Default.User;
                t._DataHoraImpressao = DateTime.Now;
                string retorno = bancoCupons.InserirTicketImpresso(t);
                t._noTicket = Convert.ToInt32("0" + retorno);    // depois teria que criar uma validacao pra ver se é numero ou mensagem de erro
                string validacao = Geravalidacao(t);  // envia o conteudo do ticket para gerar a validacao

                Image imagem = GerarQRCode(720, 720, validacao);
                string imagemSTR = ImageToBase64(imagem, ImageFormat.Bmp);
                var rec = new recibo
                {
                    header1 = "PROMOÇÃO VIAGEM DOS SONHOS",
                    header2 = "Que Shopping realiza a viagem de seus sonhos ?",
                    header3 = "Av. Frei Serafim, 890",
                    header4 = "Centro - Teresina - PI",
                    CupomN = t._noTicket.ToString().PadLeft(6, '0'),
                    NomeCliente = dtCliente.Rows[0]["Nome"].ToString().Trim(),
                    ClienteEnder = dtCliente.Rows[0]["Endereco"].ToString().Trim(),
                    ClienteEnderNum = dtCliente.Rows[0]["EnderecoNumero"].ToString().Trim(),
                    ClienteCidade = dtCliente.Rows[0]["Cidade"].ToString().Trim(),
                    ClienteUF = dtCliente.Rows[0]["Estado"].ToString().Trim(),
                    ClienteFone = dtCliente.Rows[0]["FoneFixo"].ToString().Trim(),
                    ClienteCelular = dtCliente.Rows[0]["FoneCelular1"].ToString().Trim(),
                    Data = Convert.ToString(DateTime.Now),
                    Hora = Convert.ToString(DateTime.Now.TimeOfDay),
                    qrCodeSTR = imagemSTR
                };

                recibolist.Add(rec);
                tlista.Add(t);
            }

            ConsultaCuponsFiscais();   // atualiza groupboxes e valores de cupons, como quantidades e saldos

            //GeraImpressaoTicketPDF(recibolist);
            foreach (recibo linha in recibolist)
            {
                GeraImpressaoTicketPrinter(linha);
            }
            //GeraImpressaoTicketPrinter(recibolist);
            btnLimpar.Focus();
        }

        private string Geravalidacao(Tickets t)
        {
            string retvalid = "";
            string temp1 = reverseString(t._DataHoraImpressao.ToString());
            temp1 += reverseString(t._noTicket.ToString().PadLeft(10, '%'));
            temp1 += reverseString(txtNomeCliente.Text.PadLeft(60, '*'));
            temp1 += reverseString(mskCPF.Text).PadLeft(15, '#');

            byte[] rawBytes = System.Text.Encoding.ASCII.GetBytes(temp1);
            StringBuilder builder = new StringBuilder();
            foreach (byte value in rawBytes)
            {
                builder.Append(value);
            }
            retvalid = builder.ToString();

            return retvalid;
        }

        private bool GeraImpressaoTicketPDF(List<recibo> lista)
        {

            ReportViewer Impressao = new ReportViewer();
            Impressao.Reset();
            Impressao.ProcessingMode = ProcessingMode.Local;
            Impressao.LocalReport.EnableExternalImages = true;

            //caminho para encontrar o relatorio no c#
            Impressao.LocalReport.ReportEmbeddedResource = "Cupons.View.ReportTicket.rdlc";

            // cria datatable com os cupons que vieram da outra funcao
            DataTable dtlista = new DataTable();
            dtlista = ConvertToDataTable(lista);
            dtlista.TableName = "recibo";

            Impressao.LocalReport.DataSources.Add(new ReportDataSource("meuDataSet", dtlista));

            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string extension;


            byte[] bytePDF = Impressao.LocalReport.Render("PDF", null, out mimeType, out encoding, out extension, out streamids, out warnings);

            FileStream fileStreamPDF = null;
            string nomeArquivoPDF = Path.GetTempPath() + "Ticket_" + DateTime.Now.ToString("dd_MM_yyyy-HH_mm_ss") + ".pdf";

            fileStreamPDF = new FileStream(nomeArquivoPDF, FileMode.Create);
            fileStreamPDF.Write(bytePDF, 0, bytePDF.Length);
            fileStreamPDF.Close();
            Process.Start(nomeArquivoPDF);

            dtlista.Dispose();

            return true;
        }

        private string reverseString(string Word)
        {
            char[] arrChar = Word.ToCharArray();
            Array.Reverse(arrChar);
            string invertida = new String(arrChar);

            return invertida;
        }

        private void dgvCuponsFiscais_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // para formatar o cnpj na gridview
            Double d;
            if (e.ColumnIndex == 0 && e.Value != null)
            {
                Double.TryParse(e.Value.ToString(), out d);

                e.Value = d.ToString(@"00\.000\.000\/0000-00");
            }
        }

        private void txtValorCupom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtNumeroCOO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        public DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }

        public Bitmap GerarQRCode(int width, int height, string text)
        {
            try
            {
                var bw = new ZXing.BarcodeWriter();
                var encOptions = new ZXing.Common.EncodingOptions() { Width = width, Height = height, Margin = 0 };
                bw.Options = encOptions;
                bw.Format = ZXing.BarcodeFormat.QR_CODE;
                var resultado = new Bitmap(bw.Write(text));
                return resultado;
            }
            catch
            {
                throw;
            }
        }

        public string ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();

                // Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }


        /// <summary>
        /// Rotina de impressao abaixo
        /// </summary>
        /// <param name="listaTicket"></param>
        /// 
        //public void GeraImpressaoTicketPrinter(List<recibo> listaTicket)
        public void GeraImpressaoTicketPrinter(recibo listaTicket)
        {
            List<recibo> ListasTickets = new List<recibo>();
            ListasTickets.Add(listaTicket);
            LocalReport report = new LocalReport();
            
            
            //report.ReportPath = Application.StartupPath + @"\..\..\..\View\TicketPromo.rdlc";  // modo debug
            report.ReportPath = Application.StartupPath + @"\View\TicketPromo.rdlc";  // modo release



            report.DataSources.Add(new ReportDataSource("meuDataSet", ListasTickets));
            //report.DataSources.Add(new ReportDataSource("meuDataSet", listaTicket));
            Export(report);
            m_currentPageIndex = 0;
            Print();
            //ListasTickets.Clear();
        }

        private void Export(LocalReport report)
        {
            string deviceInfo =
      "<DeviceInfo>" +
      //"  <OutputFormat>PDF</OutputFormat>" +
      "  <OutputFormat>EMF</OutputFormat>" +
      "  <PageWidth>8cm</PageWidth>" +
      "  <PageHeight>15cm</PageHeight>" +
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
            //const string printerName = Biblioteca.Settings.Default.Impressora.ToString();
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

            // Adjust rectangular area with printer margins.
            //Rectangle adjustedRect = new Rectangle(
            //    ev.PageBounds.Left - (int)ev.PageSettings.HardMarginX,
            //    ev.PageBounds.Top - (int)ev.PageSettings.HardMarginY,
            //    ev.PageBounds.Width,
            //    ev.PageBounds.Height);

            Rectangle adjustedRect = new Rectangle(
                ev.PageBounds.Left - (int)ev.PageSettings.HardMarginX,
                ev.PageBounds.Top - (int)ev.PageSettings.HardMarginY,
                77, 140);    // tamanho do cupom    75x120

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



        public class recibo
        {
            public string header1 { get; set; }
            public string header2 { get; set; }
            public string header3 { get; set; }
            public string header4 { get; set; }
            public string CupomN { get; set; }
            public string NomeCliente { get; set; }
            public string ClienteEnder { get; set; }
            public string ClienteEnderNum { get; set; }
            public string ClienteCidade { get; set; }
            public string ClienteUF { get; set; }
            public string ClienteFone { get; set; }
            public string ClienteCelular { get; set; }
            public string Data { get; set; }
            public string Hora { get; set; }
            public string qrCodeSTR { get; set; }
        }

        private void txtNumeroCOO_Leave(object sender, EventArgs e)
        {
            // verifica se já foi usado esse COO com o mesmo CNPJ cadastrado

            string searchValue = txtNumeroCOO.Text;
            dgvCuponsFiscais.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dgvCuponsFiscais.Rows)
                {
                    if (row.Cells[2].Value.ToString().Equals(searchValue) && row.Cells[0].Value.ToString().Equals(mskCNPJ.Text))
                    {
                        MessageBox.Show("O cupom referente a esse lojista já foi lançado.\n\nFavor verifique.", "Erro", MessageBoxButtons.OK,
                             MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        txtNumeroCOO.Focus();
                        break;
                    }
                }
            }
            catch (Exception)
            {
            }

            //var exists = dgvCuponsFiscais.Rows.Cast<DataGridViewRow>()
            //                 .Where(row => !row.IsNewRow)
            //                 .Select(row => row.Cells[2].Value.ToString())
            //                 .Any(x => this.txtNumeroCOO.Text == x);

            //if (!exists)
            //{
            //Add rows here
            //}

        }

        private void btnReimprir_Click(object sender, EventArgs e)
        {
            // foi pressionado o botão de reimprimir
            // verificar senha
            if (verificaSenha(txtSenha.Text.Trim()))
                {
                //chama funcao para reimprimir o cupom
                //porem antes verifica se o cupom que quer imprimir foi selecionado
                if (dgvCuponsFiscais.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Deve ser selecionado o Cupom que será Reimpresso.\nVerifique, selecione e tente novamente.", "Erro", MessageBoxButtons.OK,
               MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    btnReimprir.Focus();
                }
                else
                {

                    Regrava_Cupom();

                    lblSenha.Visible = false;
                    txtSenha.Visible = false;
                    btnReimprir.Visible = false;
                    txtSenha.Clear();

                }

            }
        }

        private void Regrava_Cupom()
        {
            Banco rePrint = new Banco();

            var recibolist = new List<recibo>();

            Tickets t = new Tickets();
            List<Tickets> tlista = new List<Tickets>();
            tlista.Clear();
            recibolist.Clear();

            t._noTicket = Convert.ToInt32(dgvCuponsGerados.CurrentRow.Cells[0].Value.ToString());
            t._idCliente = Convert.ToInt32(dtCliente.Rows[0]["id"].ToString().Trim());
                t._Impresso = true;  //fez uma reimpressao
                t._GeradoPor = Biblioteca.Settings.Default.User;
                t._DataHoraImpressao = DateTime.Now;

                string retorno = rePrint.ReimprimeTicket(t);

                string validacao = Geravalidacao(t);  // envia o conteudo do ticket para gerar a validacao

                Image imagem = GerarQRCode(720, 720, validacao);
                string imagemSTR = ImageToBase64(imagem, ImageFormat.Bmp);

//            List<recibo> ListasTickets = new List<recibo>();
//            ListasTickets.Add(listaTicket);


            var rec = new recibo
                {
                    header1 = "PROMOÇÃO VIAGEM DOS SONHOS",
                    header2 = "Que Shopping realiza a viagem de seus sonhos ?",
                    header3 = "",
                    header4 = "",
                    CupomN = "R"+t._noTicket.ToString().PadLeft(6, '0'),
                    NomeCliente = txtNomeCliente.Text.Trim(),
                    ClienteEnder = dtCliente.Rows[0]["Endereco"].ToString().Trim(),
                    ClienteEnderNum = dtCliente.Rows[0]["EnderecoNumero"].ToString().Trim(),
                    ClienteCidade = dtCliente.Rows[0]["Cidade"].ToString().Trim(),
                    ClienteUF = dtCliente.Rows[0]["Estado"].ToString().Trim(),
                    ClienteFone = dtCliente.Rows[0]["FoneFixo"].ToString().Trim(),
                    ClienteCelular = dtCliente.Rows[0]["FoneCelular1"].ToString().Trim(),
                    Data = Convert.ToString(DateTime.Now),
                    Hora = Convert.ToString(DateTime.Now.TimeOfDay),
                    qrCodeSTR = imagemSTR
                };

            recibolist.Add(rec);
            tlista.Add(t);

            foreach (recibo linha in recibolist)
            {
                GeraImpressaoTicketPrinter(linha);
            }

            //GeraImpressaoTicketPrinter(rec);

        }

        private void Reimprime_Cupom()
        {
            throw new NotImplementedException();
        }

        private bool verificaSenha(string v)
        {
            string compara;
            string dia = DateTime.Now.Day.ToString();
            string mes = DateTime.Now.Month.ToString();
            int anobase = 1978;

            int soma = Convert.ToInt16(dia + mes) + anobase;
            compara = soma.ToString().PadLeft(4, '0');
            
            if (v == compara)
            { return true; }
            else
            {
                MessageBox.Show("Senha informada não está correta.\nVerifique.", "Erro", MessageBoxButtons.OK,
               MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txtSenha.Clear();
                txtSenha.Focus();
                return false;
            }
        }

        private void frmCadCupons_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.R)
            {

                if (btnReimprir.Visible == false)
                {
                    lblSenha.Visible = true;
                    txtSenha.Visible = true;
                    btnReimprir.Visible = true;
                    txtSenha.Clear();
                    txtSenha.Focus();
                }
                else
                {
                    lblSenha.Visible = false;
                    txtSenha.Visible = false;
                    btnReimprir.Visible = false;
                    txtSenha.Clear();
                }
            }
        }

       
    }
}













/*

List<ReportParameter> ListaPar = new List<ReportParameter>();
foreach (DataRow linha in dtlista.Rows)
{
    //Parametros do Relatorio
    List<ReportParameter> ListaParametros = new List<ReportParameter>();
    ListaParametros.Add(new ReportParameter("NomePromocao", "Promoção Natal de Prêmios"));  //usar variavel depois
    ListaParametros.Add(new ReportParameter("NomeShopping", "Shopping daqui da cidade"));  //usar variavel depois
    ListaParametros.Add(new ReportParameter("Endereco1", "Av. Frei Serafim, 890"));  //usar variavel depois
    ListaParametros.Add(new ReportParameter("Endereco2", "Centro - Teresina - PI"));  //usar variavel depois

    //ListaParametros.Add(new ReportParameter("CupomNo", dtlista.Rows[linha]["CupomNo"].ToString().PadLeft(6, '0')));  //pegar o numero do cupom

    ListaParametros.Add(new ReportParameter("NomeCliente", dtCliente.Rows[0]["Nome"].ToString().Trim()));
    ListaParametros.Add(new ReportParameter("EnderecoCli", dtCliente.Rows[0]["Endereco"].ToString().Trim()));
    ListaParametros.Add(new ReportParameter("Numero", dtCliente.Rows[0]["EnderecoNumero"].ToString().Trim()));
    ListaParametros.Add(new ReportParameter("Cidade", dtCliente.Rows[0]["Cidade"].ToString().Trim()));
    ListaParametros.Add(new ReportParameter("UF", dtCliente.Rows[0]["Estado"].ToString().Trim()));
    ListaParametros.Add(new ReportParameter("Telefone", dtCliente.Rows[0]["FoneFixo"].ToString().Trim()));
    ListaParametros.Add(new ReportParameter("Celular", dtCliente.Rows[0]["FoneCelular1"].ToString().Trim()));
    ListaParametros.Add(new ReportParameter("Data", DateTime.Now.ToString("ddMMyyyy")));  //usar variavel depois
    ListaParametros.Add(new ReportParameter("Hora", DateTime.Now.TimeOfDay.ToString()));  //usar variavel depois

    ListaPar.AddRange(ListaParametros);
    //Impressao.LocalReport.SetParameters(ListaParametros);
    Impressao.LocalReport.SetParameters(ListaPar);


}

Warning[] warnings;
string[] streamids;
string mimeType;
string encoding;
string extension;

byte[] bytePDF = Impressao.LocalReport.Render("Pdf", null, out mimeType, out encoding, out extension, out streamids, out warnings);

FileStream fileStreamPDF = null;
string nomeArquivoPDF = Path.GetTempPath() + "Ticket_" + DateTime.Now.ToString("dd_MM_yyyy-HH_mm_ss") + ".pdf";

fileStreamPDF = new FileStream(nomeArquivoPDF, FileMode.Create);
fileStreamPDF.Write(bytePDF, 0, bytePDF.Length);
fileStreamPDF.Close();
Process.Start(nomeArquivoPDF);
return true;
*/
