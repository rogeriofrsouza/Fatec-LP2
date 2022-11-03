using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteMetodos
{
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnSortear_Click(object sender, EventArgs e)
        {
            int num1, num2, res;
            Random rnd = new Random();

            if (Int32.TryParse(txtNumero1.Text, out num1) && Int32.TryParse(txtNumero2.Text, out num2))
            {
                res = rnd.Next(num1, num2);
                txtSaida.Text = res.ToString();
            }
        }
    }
}
