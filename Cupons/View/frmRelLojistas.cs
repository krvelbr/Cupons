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
    public partial class frmRelLojistas : Form
    {
        public frmRelLojistas()
        {
            InitializeComponent();
        }

        private void frmRelLojistas_Load(object sender, EventArgs e)
        {

            Carregar();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            Carregar();
        }

        private void Carregar()
        {

            try
            {
                using(Cupons.Model.CuponsEntities dbLoja = new Model.CuponsEntities())
                {
                    tblLojistaBindingSource.DataSource = dbLoja.tblLojista.ToList();
                    this.rvLojistas.RefreshReport();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro:\n\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
