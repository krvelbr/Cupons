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
    public partial class frmRelClientes : Form
    {
        public frmRelClientes()
        {
            InitializeComponent();
        }

        private void frmRelClientes_Load(object sender, EventArgs e)
        {
            Carregar();
            this.rvClientes.RefreshReport();
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
                    tblClienteBindingSource.DataSource = dbLoja.tblCliente.ToList();
                    this.rvClientes.RefreshReport();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro:\n\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
