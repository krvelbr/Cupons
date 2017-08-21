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
    public partial class frmValidaCupomSorteado : Form
    {
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            painelDados.Visible = false;
            lblcpf.Text = "";
            lblcupom.Text = "";
            lbldata.Text = "";
            lblnome.Text = "";
            txtqrCode.Clear();
            txtqrCode.Focus();

        }
    }
}
