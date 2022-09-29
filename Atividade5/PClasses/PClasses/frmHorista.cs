using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PClasses
{
    public partial class frmHorista : Form
    {
        public frmHorista()
        {
            InitializeComponent();
        }

        private void btnInstanciar_Click(object sender, EventArgs e)
        {
            // criar ou instanciar o objeto da classe Horista
            Horista objHorista = new Horista();

            // set
            objHorista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objHorista.NomeEmpregado = txtNomeEmpregado.Text;
            objHorista.SalarioHora = Convert.ToDouble(txtSalarioHora.Text);
            objHorista.DiasFalta = Convert.ToInt32(txtDiasFaltas.Text);
            objHorista.NumeroHora = Convert.ToDouble(txtNumeroHora.Text);
            objHorista.DataEntradaEmpresa = Convert.ToDateTime(txtDataEntradaEmpresa.Text);

            if (rbtnSim.Checked)
                objHorista.HomeOffice = 'S';
            else
                objHorista.HomeOffice = 'N';

            // get
            MessageBox.Show("Matrícula: " + objHorista.Matricula + "\n" +
                            "Nome: " + objHorista.NomeEmpregado + "\n" +
                            "Tempo de Trabalho (dias): " + objHorista.TempoTrabalho().ToString() + "\n" +
                            "Salário: R$" + objHorista.SalarioBruto().ToString("N2") + "\n" +
                            "Dias Falta: " + objHorista.DiasFalta + "\n" +
                            objHorista.VerificaHome());
        }
    }
}
