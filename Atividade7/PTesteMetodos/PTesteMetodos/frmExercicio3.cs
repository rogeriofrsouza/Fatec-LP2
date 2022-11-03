using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteMetodos
{
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnRemoverOcorrencias_Click(object sender, EventArgs e)
        {
            int posicao;

            while (true)
            {
                posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);

                if (posicao == -1)
                    break;

                txtPalavra2.Text = txtPalavra2.Text.Substring(0, posicao) +
                                   txtPalavra2.Text.Substring(posicao + txtPalavra1.Text.Length, txtPalavra2.Text.Length - posicao - txtPalavra1.Text.Length);
            }
        }

        private void btnRemoverReplace_Click(object sender, EventArgs e)
        {
            txtPalavra2.Text = txtPalavra2.Text.Replace(txtPalavra1.Text, "");
        }

        private void btnInverter_Click(object sender, EventArgs e)
        {
            char[] arr = txtPalavra1.Text.ToCharArray();
            Array.Reverse(arr);
            txtPalavra1.Text = "";

            foreach (char carac in arr)
                txtPalavra1.Text += carac.ToString();
        }
    }
}
