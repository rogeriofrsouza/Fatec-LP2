using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMenuStrings
{
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double h = 0, n, i;

            /* validando input */
            if (double.TryParse(txtNumero.Text, out n))
            {
                /* testando se n diferente de 0 */
                if (n > 0)
                {
                    for (i = 1; i <= n; i++)
                        h += Convert.ToDouble(1) / i;

                    txtResultado.Text = h.ToString("N2");
                }
                else
                    MessageBox.Show("Digite um número maior que zero");
            }
        }
    }
}
