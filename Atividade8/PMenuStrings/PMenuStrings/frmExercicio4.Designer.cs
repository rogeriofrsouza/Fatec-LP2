namespace PMenuStrings
{
    partial class frmExercicio4
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblProducao = new System.Windows.Forms.Label();
            this.txtProducao = new System.Windows.Forms.TextBox();
            this.lblGratificacoes = new System.Windows.Forms.Label();
            this.txtGratificacoes = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.txtSalarioBruto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(69, 70);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(250, 26);
            this.txtNome.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(69, 48);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(46, 19);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(69, 128);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(46, 19);
            this.lblCargo.TabIndex = 3;
            this.lblCargo.Text = "Cargo";
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(69, 150);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(250, 26);
            this.txtCargo.TabIndex = 2;
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(69, 225);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(66, 19);
            this.lblMatricula.TabIndex = 5;
            this.lblMatricula.Text = "Matrícula";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(69, 247);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(250, 26);
            this.txtMatricula.TabIndex = 4;
            // 
            // lblProducao
            // 
            this.lblProducao.AutoSize = true;
            this.lblProducao.Location = new System.Drawing.Point(69, 311);
            this.lblProducao.Name = "lblProducao";
            this.lblProducao.Size = new System.Drawing.Size(67, 19);
            this.lblProducao.TabIndex = 7;
            this.lblProducao.Text = "Produção";
            // 
            // txtProducao
            // 
            this.txtProducao.Location = new System.Drawing.Point(69, 333);
            this.txtProducao.Name = "txtProducao";
            this.txtProducao.Size = new System.Drawing.Size(250, 26);
            this.txtProducao.TabIndex = 6;
            // 
            // lblGratificacoes
            // 
            this.lblGratificacoes.AutoSize = true;
            this.lblGratificacoes.Location = new System.Drawing.Point(436, 128);
            this.lblGratificacoes.Name = "lblGratificacoes";
            this.lblGratificacoes.Size = new System.Drawing.Size(86, 19);
            this.lblGratificacoes.TabIndex = 11;
            this.lblGratificacoes.Text = "Gratificações";
            // 
            // txtGratificacoes
            // 
            this.txtGratificacoes.Location = new System.Drawing.Point(436, 150);
            this.txtGratificacoes.Name = "txtGratificacoes";
            this.txtGratificacoes.Size = new System.Drawing.Size(250, 26);
            this.txtGratificacoes.TabIndex = 10;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(436, 48);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(49, 19);
            this.lblSalario.TabIndex = 9;
            this.lblSalario.Text = "Salário";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(436, 70);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(250, 26);
            this.txtSalario.TabIndex = 8;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(436, 222);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(143, 51);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "Calcular salário";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.Location = new System.Drawing.Point(436, 311);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(87, 19);
            this.lblSalarioBruto.TabIndex = 14;
            this.lblSalarioBruto.Text = "Salário Bruto";
            // 
            // txtSalarioBruto
            // 
            this.txtSalarioBruto.Location = new System.Drawing.Point(436, 333);
            this.txtSalarioBruto.Name = "txtSalarioBruto";
            this.txtSalarioBruto.ReadOnly = true;
            this.txtSalarioBruto.Size = new System.Drawing.Size(250, 26);
            this.txtSalarioBruto.TabIndex = 13;
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSalarioBruto);
            this.Controls.Add(this.txtSalarioBruto);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblGratificacoes);
            this.Controls.Add(this.txtGratificacoes);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblProducao);
            this.Controls.Add(this.txtProducao);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNome;
        private Label lblNome;
        private Label lblCargo;
        private TextBox txtCargo;
        private Label lblMatricula;
        private TextBox txtMatricula;
        private Label lblProducao;
        private TextBox txtProducao;
        private Label lblGratificacoes;
        private TextBox txtGratificacoes;
        private Label lblSalario;
        private TextBox txtSalario;
        private Button btnCalcular;
        private Label lblSalarioBruto;
        private TextBox txtSalarioBruto;
    }
}