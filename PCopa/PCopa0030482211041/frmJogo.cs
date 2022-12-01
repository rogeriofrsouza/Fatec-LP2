using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCopa0030482211041
{
    public partial class frmJogo : Form
    {
        private BindingSource bnJogo = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsJogo = new DataSet();
        private DataSet dsPais1 = new DataSet();
        private DataSet dsPais2 = new DataSet();
        private DataSet dsEstadio = new DataSet();

        public frmJogo()
        {
            InitializeComponent();
        }

        private void frmJogo_Load(object sender, EventArgs e)
        {
            try
            {
                Jogo RegJogo = new Jogo();
                dsJogo.Tables.Add(RegJogo.Listar());
                bnJogo.DataSource = dsJogo.Tables["Jogo"];
                dgvJogo.DataSource = bnJogo;
                bnvJogo.BindingSource = bnJogo;

                txtId.DataBindings.Add("TEXT", bnJogo, "id");
                dtpDataHora.DataBindings.Add("TEXT", bnJogo, "datahora");
                txtObservacao.DataBindings.Add("TEXT", bnJogo, "observacao");

                // carrega dados do estadio
                Estadio Estadio1 = new Estadio();
                dsEstadio.Tables.Add(Estadio1.Listar());
                cbxEstadio.DataSource = dsEstadio.Tables["estadio"];
                //CAMPO QUE SERÁ MOSTRADO PARA O USUÁRIO
                cbxEstadio.DisplayMember = "nome";
                //CAMPO QUE É A CHAVE DA TABELA CIDADE E QUE LIGA COM A TABELA DE ALUNO
                cbxEstadio.ValueMember = "id";
                //No momento de linkar os componentes com o Binding Source linkar também o combox da cidade
                cbxEstadio.DataBindings.Add("SelectedValue", bnJogo, "estadio_id");
                // AJUSTAR DROPDOWNSTYLE PARA DropDownList PARA NAO DEIXAR digitar

                // carrega dados do pais 1
                Pais Pais1 = new Pais();
                dsPais1.Tables.Add(Pais1.Listar());
                cbxPais1.DataSource = dsPais1.Tables["Pais"];
                cbxPais1.DisplayMember = "nome";
                cbxPais1.ValueMember = "id";
                cbxPais1.DataBindings.Add("SelectedValue", bnJogo, "pais_id");

                // carrega dados do pais 2
                Pais Pais2 = new Pais();
                dsPais2.Tables.Add(Pais2.Listar());
                cbxPais2.DataSource = dsPais2.Tables["Pais"];
                cbxPais2.DisplayMember = "nome";
                cbxPais2.ValueMember = "id";
                cbxPais2.DataBindings.Add("SelectedValue", bnJogo, "pais_id2"); // AJUSTAR DROPDOWNSTYLE PARA DropDownList PARA NAO DEIXAR 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (tbJogo.SelectedIndex == 0)
            {
                tbJogo.SelectTab(1);
            }

            bnJogo.AddNew();

            txtObservacao.Enabled = true;
            cbxEstadio.Enabled = true;
            cbxPais1.Enabled = true;
            cbxPais2.Enabled = true;
            cbxEstadio.SelectedIndex = 0;
            cbxPais1.SelectedIndex = 0;
            cbxPais2.SelectedIndex = 0;
            dtpDataHora.Enabled = true;

            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;

            bInclusao = true; 

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (cbxPais1.SelectedIndex == cbxPais2.SelectedIndex)
            {
                MessageBox.Show("Países iguais ou não são do mesmo grupo!");
            }
            else
            {
                Jogo RegJogo = new Jogo();
                RegJogo.EstadioId = Convert.ToInt32(cbxEstadio.SelectedValue.ToString());
                RegJogo.PaisId1 = Convert.ToInt32(cbxPais1.SelectedValue.ToString());
                RegJogo.PaisId2 = Convert.ToInt32(cbxPais2.SelectedValue.ToString());
                RegJogo.Datahora = dtpDataHora.Value;
                RegJogo.Observacao = txtObservacao.Text;

                if (bInclusao)
                {
                    if (RegJogo.Salvar() > 0)
                    {
                        MessageBox.Show("Jogo adicionado com sucesso!");

                        cbxEstadio.Enabled = false;
                        cbxPais1.Enabled = false;
                        cbxPais2.Enabled = false;

                        dtpDataHora.Enabled = false;
                        txtObservacao.Enabled = false;

                        btnNovo.Enabled = true;
                        btnAlterar.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnSalvar.Enabled = false;
                        btnCancelar.Enabled = false;

                        bInclusao = false;

                        // recarrega o grid
                        dsJogo.Tables.Clear();
                        dsJogo.Tables.Add(RegJogo.Listar());
                        bnJogo.DataSource = dsJogo.Tables["Jogo"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar jogo!");
                    }
                }
                else
                {
                    RegJogo.Id = Convert.ToInt32(txtId.Text);

                    if (RegJogo.Alterar() > 0)
                    {
                        MessageBox.Show("Jogo alterado com sucesso!");

                        cbxEstadio.Enabled = false;
                        cbxPais1.Enabled = false;
                        cbxPais2.Enabled = false;
                        dtpDataHora.Enabled = false;
                        txtObservacao.Enabled = false;

                        btnNovo.Enabled = true;
                        btnAlterar.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnSalvar.Enabled = false;
                        btnCancelar.Enabled = false;

                        // recarrega o grid
                        dsJogo.Tables.Clear();
                        dsJogo.Tables.Add(RegJogo.Listar());
                        bnJogo.DataSource = dsJogo.Tables["Jogo"];

                    }
                    else
                    {
                        MessageBox.Show("Erro ao alterar jogo!");
                    }

                }
            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tbJogo.SelectedIndex == 0)
            {
                tbJogo.SelectTab(1);
            }

            cbxEstadio.Enabled = true;
            cbxPais1.Enabled = true;
            cbxPais2.Enabled = true;
            dtpDataHora.Enabled = true;
            txtObservacao.Enabled = true;

            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;

            bInclusao = false;

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tbJogo.SelectedIndex == 0)
            {
                tbJogo.SelectTab(1);
            }


            if (MessageBox.Show("Confirma exclusão?", "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Jogo RegJogo = new Jogo();
                RegJogo.Id = Convert.ToInt32(txtId.Text);

                if (RegJogo.Excluir() > 0)
                {
                    MessageBox.Show("Jogo excluído com sucesso!");


                    // recarrega o grid
                    dsJogo.Tables.Clear();
                    dsJogo.Tables.Add(RegJogo.Listar());
                    bnJogo.DataSource = dsJogo.Tables["Jogo"];

                }
                else
                {
                    MessageBox.Show("Erro ao excluir contato!");
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bnJogo.CancelEdit();

            cbxEstadio.Enabled = false;
            cbxPais1.Enabled = false;
            cbxPais2.Enabled = false;
            dtpDataHora.Enabled = false;
            txtObservacao.Enabled = false;

            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;

            bInclusao = false;

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
