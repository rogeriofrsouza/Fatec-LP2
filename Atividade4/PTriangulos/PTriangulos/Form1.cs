namespace PTriangulos
{
    public partial class Form1 : Form
    {
        double a, b, c;
        string triangulo;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            /* Validar inputs */
            if (double.TryParse(txtA.Text, out a) && 
                double.TryParse(txtB.Text, out b) && double.TryParse(txtC.Text, out c))
            {
                if (a > 0 && b > 0 && c > 0)
                {
                    /* Verificar os lados do tri�ngulo */
                    if ((a < b + c && a > Math.Abs(b - c)) && 
                        (b < a + c && b > Math.Abs(a - c)) && (c < a + b && c > Math.Abs(a - b)))
                    {
                        if (a == b && b == c)
                            triangulo = "Equil�tero";
                        else if (a == b || b == c || c == a)
                            triangulo = "Is�sceles";
                        else
                            triangulo = "Escaleno";

                        MessageBox.Show($"� poss�vel formar um tri�ngulo: {triangulo}");
                    }
                }
                else
                    MessageBox.Show("Digite n�meros maiores que zero (0)");
            }
            else
                MessageBox.Show("Digite valores v�lidos");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtA.Text = string.Empty;
            txtB.Text = string.Empty;
            txtC.Text = string.Empty;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}