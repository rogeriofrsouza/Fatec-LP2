using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PCopa0030482211041
{
    public partial class frmPrincipal : Form
    {
        public static SqlConnection conexao;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                // aqui a conexão vai depende da sua máquina da escola ou particular 
                conexao = new SqlConnection("Data Source=Apolo;Initial Catalog=LP2;Integrated Security=False;User ID=BD2211041;Password=MichaelBD99");
                conexao.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro de banco de dados =/" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Outros Erros =/" + ex.Message);
            }
        }

        private void cadastroJogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmJogo"];
            if (fc != null)
                fc.Close();

            frmJogo objJ = new frmJogo();

            objJ.MdiParent = this;
            objJ.WindowState = FormWindowState.Maximized;
            objJ.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            Form fc = Application.OpenForms["frmSobre"];
            if (fc != null)
                fc.Close();

            frmSobre sobre = new frmSobre();

            sobre.MdiParent = this;
            sobre.WindowState = FormWindowState.Maximized;
            sobre.Show();
            */
            frmSobre frm = new frmSobre();
            frm.ShowDialog(this);
            frm.Dispose();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
