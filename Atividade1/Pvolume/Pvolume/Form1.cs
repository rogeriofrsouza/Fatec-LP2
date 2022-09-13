using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pvolume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double raio, altura;

            /* Checar se os valores inseridos são números */
            if (Double.TryParse(txtAltura.Text, out altura) && (Double.TryParse(txtRaio.Text, out raio)))
            {
                /* Checar se os valores são positivos */
                if ((altura <= 0) || (raio <= 0))
                {
                    MessageBox.Show("Erro, altura e raio devem ser maiores que zero!");
                    txtRaio.Focus();
                } 
                else
                {
                    double volume;

                    volume = Math.PI * Math.Pow(raio, 2) * altura;
                    txtVolume.Text = volume.ToString("N2");
                }
            }
            /* Valores inseridos não são números */
            else
            {
                MessageBox.Show("Valores inválidos!");
                txtRaio.Focus();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            /* Limpar os dados */
            txtAltura.Clear();
            txtRaio.Text = "";
            txtVolume.Text = String.Empty;

            txtRaio.Focus();
        }
    }
}
