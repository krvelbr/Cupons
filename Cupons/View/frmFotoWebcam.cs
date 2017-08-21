// Reference path for the following assemblies --> C:\Program Files\Microsoft Expression\Encoder 4\SDK\
using System;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;



namespace Cupons.View
{
    public partial class frmFotoWebcam : Form
    {
        
        //private LiveDeviceSource _deviceSource;
        //private LiveJob _job;

        public frmFotoWebcam()
        {
            InitializeComponent();
        }
        private FilterInfoCollection webcam;
        private VideoCaptureDevice cam;
        private bool fototirada = false;
        public string _fotonome;


        private void frmFotoWebcam_Load(object sender, EventArgs e)
        {
            //StopJob();
            webcam = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                     
                        
            foreach (FilterInfo VideoCaptureDevice in webcam)
            {
                lstVideoDevices.Items.Add(VideoCaptureDevice.Name);
            }

            lstVideoDevices.SelectedIndex = 0;

            lblVideoDeviceSelectedForPreview.Text = "";
            lblfoto.Text = "";

            btnTirarFoto.Enabled = false;
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            cam = new VideoCaptureDevice(webcam[lstVideoDevices.SelectedIndex].MonikerString);
            cam.NewFrame += new NewFrameEventHandler(cam_NewFrame);
            cam.Start();
            btnTirarFoto.Enabled = true;
        }

        void cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bit = (Bitmap)eventArgs.Frame.Clone();
            picWebPreview.Image = bit;
        }

        private void btnTirarFoto_Click(object sender, EventArgs e)
        {
            // Create a Bitmap of the same dimension of panelVideoPreview (Width x Height)
            using (Bitmap bitmap = new Bitmap(picWebPreview.Width, picWebPreview.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    // Get the paramters to call g.CopyFromScreen and get the image
                    Rectangle rectanglePanelVideoPreview = picWebPreview.Bounds;
                    Point sourcePoints = picWebPreview.PointToScreen(new Point(picWebPreview.ClientRectangle.X, picWebPreview.ClientRectangle.Y));
                    g.CopyFromScreen(sourcePoints, Point.Empty, rectanglePanelVideoPreview.Size);
                }

                string strGrabFileName = String.Format("C:\\Captured\\Snapshot_{0:yyyyMMdd_hhmmss}.jpg", DateTime.Now);
                bitmap.Save(strGrabFileName, System.Drawing.Imaging.ImageFormat.Jpeg);

                lblfoto.Text = "Foto Armazenada em: \n" + strGrabFileName;
                StopJob();
                btnTirarFoto.Enabled = false;

                fototirada = true;
                _fotonome = strGrabFileName;

            }
        }

        
        void StopJob()
        {
            if (cam != null)
            {
                if (cam.IsRunning)
                {
                    cam.Stop();
                }
            }
            
        }

        private void frmFotoWebcam_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopJob();
            if (fototirada == false)
            {
                _fotonome = null;
            }
        }

    }
}
