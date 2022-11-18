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
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        /* mostra o número de espaços em branco na frase */
        private void button1_Click(object sender, EventArgs e)
        {
            int qtde = 0, i;
            char[] aux;

            aux = rtbxTexto.Text.ToCharArray();

            i = 0;
            while (i < aux.Length)
            {
                if (aux[i] == ' ')
                    qtde++;

                i++;
            }

            MessageBox.Show("Número de espaços em branco: " + qtde);
        }

        /* mostra o número de vezes que aparece a letra "R" */
        private void button2_Click(object sender, EventArgs e)
        {
            int qtde = 0, i;
            char[] aux;

            aux = rtbxTexto.Text.ToCharArray();

            i = 0;
            do
            {
                if (aux.Length != 0 && aux[i] == 'R')
                    qtde++;

                i++;
            } while (i < aux.Length);

            MessageBox.Show("Número de vezes que aparece a letra \"R\": " + qtde);
        }

        /* mostra o número de vezes que ocorre um mesmo par de letras na frase */
        private void btnParLetras_Click(object sender, EventArgs e)
        {
            int qtde = 0, i;
            char[] aux;
            char c = '\0';

            aux = rtbxTexto.Text.ToCharArray();

            for (i = 0; i < aux.Length; i++)
            {
                if (c != '\0' && c == aux[i])
                    qtde++;

                c = aux[i];
            }

            MessageBox.Show("Número de vezes que ocorre um mesmo par de letras: " + qtde);
        }
    }
}
