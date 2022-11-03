﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteMetodos
{
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnTestarIguais_Click(object sender, EventArgs e)
        {
            if (String.Compare(txtPalavra1.Text, txtPalavra2.Text) == 0)
                MessageBox.Show("São iguais!");
            else
                MessageBox.Show("São diferentes!");
        }

        private void btnInserirPalavra_Click(object sender, EventArgs e)
        {
            int metade = txtPalavra2.Text.Length / 2;

            txtPalavra2.Text = txtPalavra2.Text.Substring(0, metade) + 
                               txtPalavra1.Text + 
                               txtPalavra2.Text.Substring(metade);
        }

        private void btnInserirAsteriscos_Click(object sender, EventArgs e)
        {
            int metade = txtPalavra1.Text.Length / 2;

            txtPalavra2.Text = txtPalavra1.Text.Insert(metade, "**");
        }
    }
}
