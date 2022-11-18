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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnVerificarPalindromo_Click(object sender, EventArgs e)
        {
            string texto, textoInverso, res;
            char[] aux;

            if (rtbxTexto.Text.Length <= 50)
            {
                /* retirando espaços em branco e transformando em letras minúsculas */
                texto = rtbxTexto.Text.Replace(" ", "").ToLower();

                /* transformando em char, invertendo e atribuindo para outra string */
                aux = texto.ToCharArray();
                Array.Reverse(aux);
                textoInverso = new string(aux);

                /* verificando se texto é igual a textoInverso */
                res = texto.Equals(textoInverso) ? "É" : "NÃO É";                  
                MessageBox.Show(rtbxTexto.Text + "\n" + res + " um palíndromo");
            }
            else
            {
                MessageBox.Show("Digite um texto menor");
                rtbxTexto.Text = "";
                rtbxTexto.Focus();
            }
        }
    }
}
