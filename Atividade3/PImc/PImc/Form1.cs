namespace PImc
{
    public partial class Form1 : Form
    {
        double peso, altura, imc;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            /* Validar inputs */
            if (double.TryParse(txtPeso.Text, out peso) && double.TryParse(txtAltura.Text, out altura))
            {
                if (peso > 250 || altura > 2.3)
                    MessageBox.Show("Digite valores válidos");
                else
                {
                    /* Cálculo IMC */
                    imc = peso / Math.Pow(altura, 2);
                    imc = Math.Round(imc, 1);
                    txtResultado.Text = imc.ToString();

                    if (imc < 18.5)
                        MessageBox.Show("Classificação: Magreza\n\nObesidade (grau): 0");
                    else if (imc < 25)
                        MessageBox.Show("Classificação: Normal\n\nObesidade (grau): 0");
                    else if (imc < 30)
                        MessageBox.Show("Classificação: Sobrepeso\n\nObesidade (grau): I");
                    else if (imc < 40)
                        MessageBox.Show("Classificação: Obesidade\n\nObesidade (grau): II");
                    else
                        MessageBox.Show("Classificação: Obesidade grave\n\nObesidade (grau): III");
                }
            }
            else
                MessageBox.Show("Digite um peso e uma altura para calcular");

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Text = string.Empty;
            txtPeso.Text = string.Empty;
            txtResultado.Text = string.Empty;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}