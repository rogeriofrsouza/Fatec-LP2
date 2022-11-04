using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PMatrizes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLerNumeros_Click(object sender, EventArgs e)
        {
            int i;
            int[] arr = new int[20];
            string aux;

            for (i = 0; i < 20; i++)
            {
                aux = Interaction.InputBox("Digite um número:", "", "0");

                if (!Int32.TryParse(aux, out arr[i]))
                {
                    MessageBox.Show("Número inválido");
                    i--;
                }
            }

            Array.Reverse(arr);
            aux = String.Join(" ", arr);  // ajustando string de saída

            /* for (i = 0; i < 20; i++) aux += arr[i].ToString() + " "; */

            MessageBox.Show("Vetor invertido: " + aux);
        }

        private void btnLerQtde_Click(object sender, EventArgs e)
        {
            double[] qtde = new double[10];
            double[] valor = new double[10];

            double faturamento = 0;
            string aux;
            int i;

            for (i = 0; i < 10; i++)
            {
                aux = Interaction.InputBox($"Digite a qtde da mercadoria {i+1}", "Entrada de quantidades", "0");

                if (Double.TryParse(aux, out qtde[i]))
                {
                    aux = Interaction.InputBox($"Digite o valor da mercadoria {i+1}", "Entrada de preços", "0");

                    if (Double.TryParse(aux, out valor[i]))
                    {
                        faturamento += qtde[i] * valor[i];
                        continue;
                    }
                }

                MessageBox.Show("Qtde ou valor inválido");
                i--;
            }

            MessageBox.Show("Faturamento: R$" + faturamento.ToString("N2"));
        }

        private void btnVariavelTotal_Click(object sender, EventArgs e)
        {
            string[] alunos = {"Viviane", "André", "Hélio", "Denise", "Junior", "Leonardo", "Jose", "Nelma", "Tobby"};
            Int32 i, total = 0;
            Int32 n = alunos.Length;

            for (i = 0; i < n-1; i++)
                total += alunos[i].Length;

            MessageBox.Show("A variável total vale: " + total.ToString());  // total = 46
        }

        private void btnArrayList_Click(object sender, EventArgs e)
        {
            string[] alunos = {"Ana", "André", "Débora", "Fátima", "João", "Janete", "Otávio", "Marcelo", "Pedro", "Thais" };
            ArrayList arr = new ArrayList();
            string aux;

            arr.AddRange(alunos);
            arr.Remove("Otávio");

            aux = String.Join(Environment.NewLine, arr.ToArray());  // ajustando string de saída

            MessageBox.Show("Lista de alunos: \n" + aux);
        }

        private void btnMediaAlunos_Click(object sender, EventArgs e)
        {
            double[,] notas = new double[20, 3];
            double media;
            int i, j;
            string aux;

            for (i = 0; i < 20; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    aux = Interaction.InputBox($"Insira a nota {j+1}", $"Aluno {i+1}", "0");
                    notas[i, j] = Convert.ToDouble(aux);
                }
            }

            aux = "";

            for (i = 0; i < 20; i++)
            {
                aux += $"Aluno {i+1} ";
                media = 0;

                for (j = 0; j < 3; j++)
                    media += notas[i, j];

                media /= 3;
                aux += $"média: {media.ToString("N1")}\n";
            }

            MessageBox.Show(aux);
        }

        private void btnNomesPessoas_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }
    }
}
