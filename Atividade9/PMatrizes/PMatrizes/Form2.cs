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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            string[] nomes = new string[7];
            int[] qtde = new int[7];
            int i;
            string aux;

            for (i = 0; i < nomes.Length; i++)
            {
                nomes[i] = Interaction.InputBox($"Digite o nome completo da pessoa {i+1}", "Nomes", "");
                
                aux = nomes[i].Replace(" ", "");
                qtde[i] = aux.Length;

                lbxNomes.Items.Add($"O nome: {nomes[i]} tem {qtde[i]} caracteres");
            }
        }
    }
}
