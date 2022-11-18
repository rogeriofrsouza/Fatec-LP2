using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            char[,] matriz = new char[7, 10];  // matriz 7 alunos x 10 questões
            char[] gabarito = new char[10] {'A', 'B', 'C', 'D', 'E', 'A', 'B', 'C', 'D', 'E'};  // gabarito de respostas
            
            string aux = "", resultado = "";
            char resposta = '\0';

            // input de dados
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    // recebendo respostas do aluno
                    aux = Interaction.InputBox("Digite a resposta", "Aluno " + (i + 1));

                    // validando se 1 caracter
                    if (Char.TryParse(aux, out resposta))
                    {
                        // validando se é letra e está em gabarito
                        if (Char.IsLetter(resposta) && gabarito.Contains(resposta))
                        {
                            aux = aux.ToUpper();
                            matriz[i, j] = Convert.ToChar(aux);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Insira uma resposta válida (A, B, C, D, E)");
                        j--;
                    }
                }
            }

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    // comparando respostas com gabarito
                    if (matriz[i, j] == gabarito[j])
                        resultado = " acertou";
                    else
                        resultado = " errou";

                    lbxResultado.Items.Add("O aluno: " + (i + 1) + resultado + 
                                           " questão: " + (j + 1) +
                                           " era " + gabarito[j] + " escolheu " + matriz[i, j]);
                }
            }
        }
    }
}