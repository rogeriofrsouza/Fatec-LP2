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

namespace PSalario
{
    public partial class Form1 : Form
    {
        double salarioBruto, salarioLiquido, salarioFamilia;
        int numeroFilhos;
        char sexo;
        bool casado;
        double aliquotaINSS, aliquotaIRPF, descontoINSS, descontoIRPF;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificaDesconto_Click(object sender, EventArgs e)
        {
            /* checando nome */
            if (txtNomeFuncionario.Text == String.Empty)
                MessageBox.Show("Insira um nome");

            /* checando sexo */
            if (rbtnMasculino.Checked)
                sexo = 'M';
            else
                sexo = 'F';

            /* checando se casado(a) */
            if (rbtnCasado.Checked)
                casado = true;
            else
                casado = false;

            /* checando salário bruto */
            if (double.TryParse(txtSalarioBruto.Text, out salarioBruto))
            {
                /* calculando alíquota INSS */
                if (salarioBruto <= 800.47)
                    aliquotaINSS = 0.0765;
                else if (salarioBruto <= 1050)
                    aliquotaINSS = 0.0865;
                else if (salarioBruto <= 1400.77)
                    aliquotaINSS = 0.09;
                else if (salarioBruto <= 2801.56)
                    aliquotaINSS = 0.11;
                else
                    aliquotaINSS = 0.00;

                /* calculando desconto INSS */
                if (aliquotaINSS == 0.00)
                    descontoINSS = 308.17;
                else
                    descontoINSS = salarioBruto * aliquotaINSS;

                txtAliquotaINSS.Text = (aliquotaINSS * 100).ToString() + "%";
                txtDescontoINSS.Text = descontoINSS.ToString("N2");

                /* calculando alíquota IRPF */
                if (salarioBruto <= 1257.12)
                    aliquotaIRPF = 0.00;
                else if (salarioBruto <= 2512.08)
                    aliquotaIRPF = 0.15;
                else
                    aliquotaIRPF = 0.275;

                /* calculando desconto IRPF */
                descontoIRPF = salarioBruto * aliquotaIRPF;

                txtAliquotaIRPF.Text = (aliquotaIRPF * 100).ToString() + "%";
                txtDescontoIRPF.Text = descontoIRPF.ToString("N2");

                /* calculando salário família */
                if (Int32.TryParse(nupdNumeroFilhos.Text, out numeroFilhos))
                {
                    if (salarioBruto <= 435.52)
                        salarioFamilia = 22.33 * numeroFilhos;
                    else if (salarioBruto <= 654.61)
                        salarioFamilia = 15.74 * numeroFilhos;
                    else
                        salarioFamilia = 0.00;

                    txtSalarioFamilia.Text = salarioFamilia.ToString("N2");
                }
            }

            /* calculando salário líquido */
            salarioLiquido = salarioBruto - descontoINSS - descontoIRPF + salarioFamilia;
            txtSalarioLiquido.Text = salarioLiquido.ToString("N2");

            /* exibindo dados do funcionário */
            lblDados.Text = "Nome: " + txtNomeFuncionario.Text +
                            ", Salário bruto: R$" + salarioBruto.ToString() +
                            "\nNúmero filhos: " + nupdNumeroFilhos.Text +
                            ", Sexo: " + sexo.ToString() +
                            ", Casado(a): " + casado.ToString();

        }
    }
}
