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
    public partial class frmSplash : Form
    {
        int progress = 0;

        public frmSplash()
        {
            InitializeComponent();
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 50;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            progress += 1;
            if (progress >= 100)
            {
                timer1.Enabled = false;
                timer1.Stop();
                this.Hide();
                

                //chama form principal

                //frmPrincipal f = new frmPrincipal();
                //f.Show();


            }
            progressBar1.Value = progress;
        }
    }
}
