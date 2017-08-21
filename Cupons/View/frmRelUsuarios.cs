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
    public partial class frmRelUsuarios : Form
    {
        public frmRelUsuarios()
        {
            InitializeComponent();
        }

        private void frmRelUsuarios_Load(object sender, EventArgs e)
        {
            Carregar();
            //this.rvUsuarios.RefreshReport();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            Carregar();
        }


        private void Carregar()
        {
            try
            {
                using (Cupons.Model.CuponsEntities dbUsuario = new Model.CuponsEntities())
                {
                    tblUsuariosBindingSource.DataSource = dbUsuario.tblUsuarios.ToList();
                    this.rvUsuarios.RefreshReport();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro:\n\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
