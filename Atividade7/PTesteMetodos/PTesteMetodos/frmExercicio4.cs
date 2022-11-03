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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnNumericos_Click(object sender, EventArgs e)
        {
            int qtde = 0;
            char[] arr = rtbxTexto.Text.ToCharArray();

            foreach (char caracter in arr)
                if (Char.IsNumber(caracter)) qtde++;

            if (qtde == 0)
                MessageBox.Show("Não encontrei caracteres numéricos");
            else
                MessageBox.Show($"Encontrei {qtde} caractere(s) numérico(s)");
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            int i = 0;
            char[] arr = rtbxTexto.Text.ToCharArray();

            while (i < rtbxTexto.Text.Length)
            {
                if (Char.IsWhiteSpace(arr[i]))
                {
                    MessageBox.Show($"Primeiro caracter branco está na posição {i}");
                    return;
                }

                i++;
            }

            MessageBox.Show("Não encontrei espaço em branco");
        }

        private void btnAlfabeticos_Click(object sender, EventArgs e)
        {
            int qtde = 0;
            char[] arr = rtbxTexto.Text.ToCharArray();

            foreach (char caracter in arr)
                if (Char.IsLetter(caracter)) qtde++;

            if (qtde == 0)
                MessageBox.Show("Não encontrei caracteres alfabéticos");
            else
                MessageBox.Show($"Encontrei {qtde} caractere(s) alfabético(s)");
        }
    }
}
