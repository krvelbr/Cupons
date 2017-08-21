using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Drawing;
using System.Windows.Forms;
using ZXing;

namespace Cupons.View
{
    public partial class frmValidadorQrCode : Form
    {
        public frmValidadorQrCode()
        {
            InitializeComponent();
            lblcpf.Text = "";
            lblcupom.Text = "";
            lblnome.Text = "";
            lbldata.Text = "";
            ocultalabels(true);
        }

        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private String message = "";

        //string modelo = "4850584948584948325449485047484947574850514937373737373737698478697376673279683269777978424242424242424242424242424242424242424242424242424242424242424242424242424242424242424242353535355656575154535256505048";

        private void frmValidadorQrCode_Load(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in videoDevices)
            {
                comboBoxCameraSource.Items.Add(device.Name);
            }
            comboBoxCameraSource.SelectedIndex = 0;

            videoSource = new VideoCaptureDevice();

            btnVisualizar.Text = "Iniciar";
            btnDecode.Enabled = false;
            painelDados.Visible = false;
            lblcpf.Text = "";
            lblcupom.Text = "";
            lblnome.Text = "";
            lbldata.Text = "";
            ocultalabels(true);
        }

        private void ocultalabels(bool sinal)
        {

            lblcpf.Visible = !sinal;
            lblcupom.Visible = !sinal;
            lblnome.Visible = !sinal;
            lbldata.Visible = !sinal;
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
            ocultalabels(false);
            lblcpf.Text = String.Format(@"{0:000\.000\.000\-00}", Convert.ToDouble(convertida.Substring(0, 15).Replace('#', ' ').Trim()));
            lblnome.Text = convertida.Substring(15, 60).Replace('*', ' ').Trim();
            lblcupom.Text = convertida.Substring(75, 10).Replace('%', ' ').Trim().PadLeft(6, '0');
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

        void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                Bitmap image = (Bitmap)eventArgs.Frame.Clone();
                picWebPreview.Image = image;
            }
            catch (Exception)
            {

            }

        }

        private void frmValidadorQrCode_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            if (videoSource != null)
                if (videoSource.IsRunning)
                {
                    videoSource.Stop();
                }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            // criar uma variavel que indique que o botao iniciar foi apertado e ativou a camera
            
            if (videoSource.IsRunning)
            {
                videoSource.Stop();
                picWebPreview.Image = null;
                picWebPreview.Invalidate();

                btnVisualizar.Text = "Iniciar";
                btnDecode.Enabled = false;
                painelDados.Visible = false;
                lblcpf.Text = "";
                lblcupom.Text = "";
                lblnome.Text = "";
                lbldata.Text = "";
                //picWebPreview.Dispose();
                
            }
            else
            {
                videoSource = new VideoCaptureDevice(videoDevices[comboBoxCameraSource.SelectedIndex].MonikerString);
                videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);
                videoSource.Start();

                btnVisualizar.Text = "Parar";
                btnDecode.Enabled = true;
            }
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            btnDecode.Enabled = false;
            timer1.Enabled = true;
            timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            BarcodeReader Reader = new BarcodeReader();
            try
            {
                Result resultado = Reader.Decode((Bitmap)picWebPreview.Image);
                string decoded = resultado.ToString().Trim();

                if (decoded != null)
                {
                    if (decoded.Length == 208)
                    {
                        painelDados.Visible = true;
                        message = ValidaQRCode(decoded);
                        timer1.Stop();
                        //    MessageBox.Show(decoded);
                    }
                    else
                    {
                        MessageBox.Show("O QRCode não pode ser autenticado no sistema.\nPossivelmente esse código não seja válido ou não é um Cupom da promoção.", "Erro", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                    }
                }
            }
            catch (Exception)
            {
                //    se retornou nullo, continua lendo ate achar o valor
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



/* private void btnTirarFoto_Click(object sender, EventArgs e)
 {
     if (videoSource.IsRunning)
     {
         pictureBoxCaptured.Image = (Bitmap)picWebPreview.Image.Clone();
         capturedImage = (Bitmap)pictureBoxCaptured.Image;
     }
 }*/


/*private string ExtractQRCodeMessageFromImage(Bitmap bitmap)
{

    BarcodeReader reader = new BarcodeReader();

    try
    {
        //BarcodeReader reader = new BarcodeReader
        //    (null, newbitmap => new BitmapLuminanceSource(bitmap), luminance => new GlobalHistogramBinarizer(luminance));



        reader.AutoRotate = true;
        reader.TryInverted = true;
        reader.Options = new DecodingOptions { TryHarder = true };

        //    var result = reader.Decode(bitmap);
        Result result =  reader.Decode(bitmap);

        if (result != null)
        {
            message = result.Text;
            return message;
        }
        else
        {
            MessageBox.Show("QRCode não pode ser decodificado.", "Erro", MessageBoxButtons.OK,
       MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            return message = "";
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("QRCode não foi detectado corretamente.\n\n" + ex.Message, "Erro", MessageBoxButtons.OK,
   MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

        return message = "";
    }

}*/
