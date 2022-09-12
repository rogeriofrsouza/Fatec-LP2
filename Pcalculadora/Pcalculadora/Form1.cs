using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pcalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* Validação dos números inseridos nos TextBoxs */
        private bool ValidarNumeros()
        {
            if (double.TryParse(txtNumero1.Text, out double num1) && double.TryParse(txtNumero2.Text, out double num2))
                return true;
            
            MessageBox.Show("Erro: insira um número válido");

            return false;
        }

        /* Operação dos cálculos possíveis */
        private void Calcular(char op)
        {
            double res;
            double num1 = double.Parse(txtNumero1.Text), num2 = double.Parse(txtNumero2.Text);

            switch (op)
            {
                case '+': res = num1 + num2; break;
                case '-': res = num1 - num2; break;
                case '*': res = num1 * num2; break;
                default: res = num1 / num2; break;
            }
            this.txtResultado.Text = res.ToString();
        }

        private void BtnAdicao_Click(object sender, EventArgs e)
        {
            if (this.ValidarNumeros())
                this.Calcular('+');
        }

        private void BtnSubtrair_Click(object sender, EventArgs e)
        {
            if (this.ValidarNumeros())
                this.Calcular('-');
        }

        private void BtnMultiplicar_Click(object sender, EventArgs e)
        {
            if (this.ValidarNumeros())
                this.Calcular('*');
        }

        private void BtnDividir_Click(object sender, EventArgs e)
        {
            if (double.Parse(txtNumero2.Text) == 0)
                MessageBox.Show("Erro: insira um número divisor maior que zero (0)");
            else
                if (this.ValidarNumeros())
                    this.Calcular('/');
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";

            this.txtNumero1.Focus();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
