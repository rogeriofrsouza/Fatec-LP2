namespace PClasses
{
    partial class frmMensalista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNomeEmpregado = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtSalarioMensal = new System.Windows.Forms.TextBox();
            this.lblSalarioMensal = new System.Windows.Forms.Label();
            this.txtDataEntradaEmpresa = new System.Windows.Forms.TextBox();
            this.lblDataEntradaEmpresa = new System.Windows.Forms.Label();
            this.gbxHomeOffice = new System.Windows.Forms.GroupBox();
            this.rbtnNao = new System.Windows.Forms.RadioButton();
            this.rbtnSim = new System.Windows.Forms.RadioButton();
            this.btnInstanciar1 = new System.Windows.Forms.Button();
            this.btnInstanciar2 = new System.Windows.Forms.Button();
            this.gbxHomeOffice.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(51, 39);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(52, 13);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matrícula";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(54, 55);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(148, 20);
            this.txtMatricula.TabIndex = 1;
            // 
            // txtNomeEmpregado
            // 
            this.txtNomeEmpregado.Location = new System.Drawing.Point(54, 113);
            this.txtNomeEmpregado.Name = "txtNomeEmpregado";
            this.txtNomeEmpregado.Size = new System.Drawing.Size(231, 20);
            this.txtNomeEmpregado.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(51, 97);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // txtSalarioMensal
            // 
            this.txtSalarioMensal.Location = new System.Drawing.Point(54, 174);
            this.txtSalarioMensal.Name = "txtSalarioMensal";
            this.txtSalarioMensal.Size = new System.Drawing.Size(148, 20);
            this.txtSalarioMensal.TabIndex = 5;
            // 
            // lblSalarioMensal
            // 
            this.lblSalarioMensal.AutoSize = true;
            this.lblSalarioMensal.Location = new System.Drawing.Point(51, 158);
            this.lblSalarioMensal.Name = "lblSalarioMensal";
            this.lblSalarioMensal.Size = new System.Drawing.Size(76, 13);
            this.lblSalarioMensal.TabIndex = 4;
            this.lblSalarioMensal.Text = "Salário Mensal";
            // 
            // txtDataEntradaEmpresa
            // 
            this.txtDataEntradaEmpresa.Location = new System.Drawing.Point(54, 239);
            this.txtDataEntradaEmpresa.Name = "txtDataEntradaEmpresa";
            this.txtDataEntradaEmpresa.Size = new System.Drawing.Size(148, 20);
            this.txtDataEntradaEmpresa.TabIndex = 7;
            // 
            // lblDataEntradaEmpresa
            // 
            this.lblDataEntradaEmpresa.AutoSize = true;
            this.lblDataEntradaEmpresa.Location = new System.Drawing.Point(51, 223);
            this.lblDataEntradaEmpresa.Name = "lblDataEntradaEmpresa";
            this.lblDataEntradaEmpresa.Size = new System.Drawing.Size(129, 13);
            this.lblDataEntradaEmpresa.TabIndex = 6;
            this.lblDataEntradaEmpresa.Text = "Data Entrada na Empresa";
            // 
            // gbxHomeOffice
            // 
            this.gbxHomeOffice.Controls.Add(this.rbtnNao);
            this.gbxHomeOffice.Controls.Add(this.rbtnSim);
            this.gbxHomeOffice.Location = new System.Drawing.Point(317, 71);
            this.gbxHomeOffice.Name = "gbxHomeOffice";
            this.gbxHomeOffice.Size = new System.Drawing.Size(150, 123);
            this.gbxHomeOffice.TabIndex = 8;
            this.gbxHomeOffice.TabStop = false;
            this.gbxHomeOffice.Text = "Trabalha em Home Office";
            // 
            // rbtnNao
            // 
            this.rbtnNao.AutoSize = true;
            this.rbtnNao.Checked = true;
            this.rbtnNao.Location = new System.Drawing.Point(6, 65);
            this.rbtnNao.Name = "rbtnNao";
            this.rbtnNao.Size = new System.Drawing.Size(45, 17);
            this.rbtnNao.TabIndex = 1;
            this.rbtnNao.TabStop = true;
            this.rbtnNao.Text = "Não";
            this.rbtnNao.UseVisualStyleBackColor = true;
            // 
            // rbtnSim
            // 
            this.rbtnSim.AutoSize = true;
            this.rbtnSim.Location = new System.Drawing.Point(7, 42);
            this.rbtnSim.Name = "rbtnSim";
            this.rbtnSim.Size = new System.Drawing.Size(42, 17);
            this.rbtnSim.TabIndex = 0;
            this.rbtnSim.Text = "Sim";
            this.rbtnSim.UseVisualStyleBackColor = true;
            // 
            // btnInstanciar1
            // 
            this.btnInstanciar1.Location = new System.Drawing.Point(54, 315);
            this.btnInstanciar1.Name = "btnInstanciar1";
            this.btnInstanciar1.Size = new System.Drawing.Size(176, 83);
            this.btnInstanciar1.TabIndex = 9;
            this.btnInstanciar1.Text = "Instanciar Mensalista";
            this.btnInstanciar1.UseVisualStyleBackColor = true;
            this.btnInstanciar1.Click += new System.EventHandler(this.btnInstanciar1_Click);
            // 
            // btnInstanciar2
            // 
            this.btnInstanciar2.Location = new System.Drawing.Point(291, 315);
            this.btnInstanciar2.Name = "btnInstanciar2";
            this.btnInstanciar2.Size = new System.Drawing.Size(176, 83);
            this.btnInstanciar2.TabIndex = 10;
            this.btnInstanciar2.Text = "Instanciar Mensalista passando parâmetros";
            this.btnInstanciar2.UseVisualStyleBackColor = true;
            // 
            // frmMensalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 447);
            this.Controls.Add(this.btnInstanciar2);
            this.Controls.Add(this.btnInstanciar1);
            this.Controls.Add(this.gbxHomeOffice);
            this.Controls.Add(this.txtDataEntradaEmpresa);
            this.Controls.Add(this.lblDataEntradaEmpresa);
            this.Controls.Add(this.txtSalarioMensal);
            this.Controls.Add(this.lblSalarioMensal);
            this.Controls.Add(this.txtNomeEmpregado);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblMatricula);
            this.Name = "frmMensalista";
            this.Text = "frmMensalista";
            this.gbxHomeOffice.ResumeLayout(false);
            this.gbxHomeOffice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNomeEmpregado;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtSalarioMensal;
        private System.Windows.Forms.Label lblSalarioMensal;
        private System.Windows.Forms.TextBox txtDataEntradaEmpresa;
        private System.Windows.Forms.Label lblDataEntradaEmpresa;
        private System.Windows.Forms.GroupBox gbxHomeOffice;
        private System.Windows.Forms.RadioButton rbtnNao;
        private System.Windows.Forms.RadioButton rbtnSim;
        private System.Windows.Forms.Button btnInstanciar1;
        private System.Windows.Forms.Button btnInstanciar2;
    }
}