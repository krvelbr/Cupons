using Funcoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cupons.View
{
    public partial class frmConsVendasLojista : Form
    {
        public frmConsVendasLojista()
        {
            InitializeComponent();
        }
        public DataTable dtConsVendas = new DataTable();

        private void frmConsVendasLojista_Load(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void frmConsVendasLojista_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 13))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void limparCampos()
        {
            gbResultado.Visible = false;
            lblClientesUnicos.Text = "";
            lblCupons.Text = "";
            lblTicketMedio.Text = "";
            lblValorVendas.Text = "";
            lblFantasia.Text = "";
            btnConsultarCNPJ.Enabled = true;
            mskCNPJ.Clear();
            mskCNPJ.Focus();
            SendKeys.Send("{BACKSPACE}");  //para eliminar o bug do maskedbox que empurra a mascara pra frente.
        }

        private void btnConsultarCNPJ_Click(object sender, EventArgs e)
        {

            if (mskCNPJ.Text.Trim() != "")
            {
                ConsultaLojista();

                if (dtConsVendas != null && dtConsVendas.Rows.Count > 0) //verifica se datatable esta nulo ou vazio
                {
                    PreencheForm();

                }
                else
                {
                    MessageBox.Show("CNPJ não encontrado.\nFavor Verificar.", "Erro", MessageBoxButtons.OK,
                       MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    mskCNPJ.Focus();
                }
            }
        }

        private void PreencheForm()
        {
            btnConsultarCNPJ.Enabled = false;
            gbResultado.Visible = true;
            string filter = "CNPJLojista = " + mskCNPJ.Text;
            DataView view = new DataView(dtConsVendas);
            DataTable distinctValues = new DataTable();
            distinctValues = view.ToTable(true, "idCliente");   // descobre quantos clientes unicos (ou distintos) existem na tabela

            // preenche os labels com os valores.
            lblFantasia.Text = dtConsVendas.Rows[0]["FantasiaLojista"].ToString().Trim();
            lblValorVendas.Text = dtConsVendas.Compute("Sum(ValorCompraCOO)", filter).ToString();
            lblCupons.Text = (dtConsVendas.Rows.Count).ToString();
            lblTicketMedio.Text = ((Convert.ToDouble(lblValorVendas.Text) / Convert.ToInt32(lblCupons.Text))).ToString("C2");// "R$ {0:#,###.##}");            
            lblClientesUnicos.Text = (distinctValues.Rows.Count).ToString();



            //txtIE.Text = dtLojista.Rows[0]["IELojista"].ToString().Trim();
            //object sumObject;
            //sumObject = table.Compute("Sum(Total)", "EmpID = 5");
            //lblValorVendas.Text = Convert.ToString(dtConsVendas.Compute("Sum(ValorCompraCOO)", "ValorCompraCOO = "+mskCNPJ.Text));
            //object obj = (dtConsVendas.Compute("Sum(ValorCompraCOO)", filter));
            //lblClientesUnicos.Text = dtConsVendas.AsEnumerable().Select(c => (DataRow)c["idCliente"]).Distinct().ToString(); //



        }

        private void ConsultaLojista()
        {
            Banco banco = new Banco();
            dtConsVendas.Clear();
            dtConsVendas = banco.VendasLojista(mskCNPJ.Text);
        }



    }
}
