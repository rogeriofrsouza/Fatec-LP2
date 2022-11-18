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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double salarioBruto, A, B, C, D, gratificacoes;
            int producao;

            /* validando inputs: salario (A), producao e gratificacoes */
            if (double.TryParse(txtSalario.Text, out A) && 
                int.TryParse(txtProducao.Text, out producao) && 
                double.TryParse(txtGratificacoes.Text, out gratificacoes))
            {
                /* calculando salarioBruto */
                B = producao >= 150 ? 1 : 0;
                C = producao >= 120 ? 1 : 0;
                D = producao >= 100 ? 1 : 0;

                salarioBruto = A + A * (0.05 * B + 0.1 * C + 0.1 * D) + gratificacoes;

                /* aplicando restrição */
                if (salarioBruto > 7000 && producao < 150 || gratificacoes == 0)
                    salarioBruto = 7000;

                txtSalarioBruto.Text = "R$" + salarioBruto.ToString("N2");
            }
            else
                MessageBox.Show("Preencha todos os campos");
        }
    }
}
