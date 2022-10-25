namespace PSalario
{
    partial class Form1
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
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.lblNumeroFilhos = new System.Windows.Forms.Label();
            this.nupdNumeroFilhos = new System.Windows.Forms.NumericUpDown();
            this.btnVerificaDesconto = new System.Windows.Forms.Button();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.rbtnFeminino = new System.Windows.Forms.RadioButton();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.rbtnCasado = new System.Windows.Forms.RadioButton();
            this.lblAliquotaINSS = new System.Windows.Forms.Label();
            this.txtAliquotaINSS = new System.Windows.Forms.TextBox();
            this.txtAliquotaIRPF = new System.Windows.Forms.TextBox();
            this.lblAliquotaIRPF = new System.Windows.Forms.Label();
            this.lblDescontoINSS = new System.Windows.Forms.Label();
            this.lblDescontoIRPF = new System.Windows.Forms.Label();
            this.lblSalarioFamilia = new System.Windows.Forms.Label();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.lblDados = new System.Windows.Forms.Label();
            this.txtDescontoINSS = new System.Windows.Forms.TextBox();
            this.txtDescontoIRPF = new System.Windows.Forms.TextBox();
            this.txtSalarioFamilia = new System.Windows.Forms.TextBox();
            this.txtSalarioLiquido = new System.Windows.Forms.TextBox();
            this.txtSalarioBruto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupdNumeroFilhos)).BeginInit();
            this.gbxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.AutoSize = true;
            this.lblNomeFuncionario.Location = new System.Drawing.Point(29, 27);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(90, 13);
            this.lblNomeFuncionario.TabIndex = 0;
            this.lblNomeFuncionario.Text = "Nome funcionário";
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Location = new System.Drawing.Point(32, 43);
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(186, 20);
            this.txtNomeFuncionario.TabIndex = 1;
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.Location = new System.Drawing.Point(29, 85);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(66, 13);
            this.lblSalarioBruto.TabIndex = 2;
            this.lblSalarioBruto.Text = "Salário bruto";
            // 
            // lblNumeroFilhos
            // 
            this.lblNumeroFilhos.AutoSize = true;
            this.lblNumeroFilhos.Location = new System.Drawing.Point(29, 146);
            this.lblNumeroFilhos.Name = "lblNumeroFilhos";
            this.lblNumeroFilhos.Size = new System.Drawing.Size(86, 13);
            this.lblNumeroFilhos.TabIndex = 4;
            this.lblNumeroFilhos.Text = "Número de filhos";
            // 
            // nupdNumeroFilhos
            // 
            this.nupdNumeroFilhos.Location = new System.Drawing.Point(32, 162);
            this.nupdNumeroFilhos.Name = "nupdNumeroFilhos";
            this.nupdNumeroFilhos.Size = new System.Drawing.Size(109, 20);
            this.nupdNumeroFilhos.TabIndex = 5;
            // 
            // btnVerificaDesconto
            // 
            this.btnVerificaDesconto.Location = new System.Drawing.Point(174, 221);
            this.btnVerificaDesconto.Name = "btnVerificaDesconto";
            this.btnVerificaDesconto.Size = new System.Drawing.Size(164, 37);
            this.btnVerificaDesconto.TabIndex = 6;
            this.btnVerificaDesconto.Text = "Verifica Desconto";
            this.btnVerificaDesconto.UseVisualStyleBackColor = true;
            this.btnVerificaDesconto.Click += new System.EventHandler(this.btnVerificaDesconto_Click);
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.rbtnFeminino);
            this.gbxSexo.Controls.Add(this.rbtnMasculino);
            this.gbxSexo.Location = new System.Drawing.Point(358, 27);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Size = new System.Drawing.Size(110, 80);
            this.gbxSexo.TabIndex = 7;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // rbtnFeminino
            // 
            this.rbtnFeminino.AutoSize = true;
            this.rbtnFeminino.Location = new System.Drawing.Point(7, 44);
            this.rbtnFeminino.Name = "rbtnFeminino";
            this.rbtnFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbtnFeminino.TabIndex = 1;
            this.rbtnFeminino.TabStop = true;
            this.rbtnFeminino.Text = "Feminino";
            this.rbtnFeminino.UseVisualStyleBackColor = true;
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(7, 20);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbtnMasculino.TabIndex = 0;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtnCasado
            // 
            this.rbtnCasado.AutoSize = true;
            this.rbtnCasado.Location = new System.Drawing.Point(365, 130);
            this.rbtnCasado.Name = "rbtnCasado";
            this.rbtnCasado.Size = new System.Drawing.Size(76, 17);
            this.rbtnCasado.TabIndex = 8;
            this.rbtnCasado.TabStop = true;
            this.rbtnCasado.Text = "Casado (a)";
            this.rbtnCasado.UseVisualStyleBackColor = true;
            // 
            // lblAliquotaINSS
            // 
            this.lblAliquotaINSS.AutoSize = true;
            this.lblAliquotaINSS.Location = new System.Drawing.Point(32, 331);
            this.lblAliquotaINSS.Name = "lblAliquotaINSS";
            this.lblAliquotaINSS.Size = new System.Drawing.Size(75, 13);
            this.lblAliquotaINSS.TabIndex = 9;
            this.lblAliquotaINSS.Text = "Alíquota INSS";
            // 
            // txtAliquotaINSS
            // 
            this.txtAliquotaINSS.Enabled = false;
            this.txtAliquotaINSS.Location = new System.Drawing.Point(32, 347);
            this.txtAliquotaINSS.Name = "txtAliquotaINSS";
            this.txtAliquotaINSS.Size = new System.Drawing.Size(186, 20);
            this.txtAliquotaINSS.TabIndex = 10;
            // 
            // txtAliquotaIRPF
            // 
            this.txtAliquotaIRPF.Enabled = false;
            this.txtAliquotaIRPF.Location = new System.Drawing.Point(32, 413);
            this.txtAliquotaIRPF.Name = "txtAliquotaIRPF";
            this.txtAliquotaIRPF.Size = new System.Drawing.Size(186, 20);
            this.txtAliquotaIRPF.TabIndex = 12;
            // 
            // lblAliquotaIRPF
            // 
            this.lblAliquotaIRPF.AutoSize = true;
            this.lblAliquotaIRPF.Location = new System.Drawing.Point(32, 397);
            this.lblAliquotaIRPF.Name = "lblAliquotaIRPF";
            this.lblAliquotaIRPF.Size = new System.Drawing.Size(74, 13);
            this.lblAliquotaIRPF.TabIndex = 11;
            this.lblAliquotaIRPF.Text = "Alíquota IRPF";
            // 
            // lblDescontoINSS
            // 
            this.lblDescontoINSS.AutoSize = true;
            this.lblDescontoINSS.Location = new System.Drawing.Point(306, 331);
            this.lblDescontoINSS.Name = "lblDescontoINSS";
            this.lblDescontoINSS.Size = new System.Drawing.Size(81, 13);
            this.lblDescontoINSS.TabIndex = 13;
            this.lblDescontoINSS.Text = "Desconto INSS";
            // 
            // lblDescontoIRPF
            // 
            this.lblDescontoIRPF.AutoSize = true;
            this.lblDescontoIRPF.Location = new System.Drawing.Point(306, 396);
            this.lblDescontoIRPF.Name = "lblDescontoIRPF";
            this.lblDescontoIRPF.Size = new System.Drawing.Size(80, 13);
            this.lblDescontoIRPF.TabIndex = 15;
            this.lblDescontoIRPF.Text = "Desconto IRPF";
            // 
            // lblSalarioFamilia
            // 
            this.lblSalarioFamilia.AutoSize = true;
            this.lblSalarioFamilia.Location = new System.Drawing.Point(32, 464);
            this.lblSalarioFamilia.Name = "lblSalarioFamilia";
            this.lblSalarioFamilia.Size = new System.Drawing.Size(76, 13);
            this.lblSalarioFamilia.TabIndex = 17;
            this.lblSalarioFamilia.Text = "Salario Família";
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Location = new System.Drawing.Point(32, 530);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(78, 13);
            this.lblSalarioLiquido.TabIndex = 19;
            this.lblSalarioLiquido.Text = "Salario Líquido";
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.BackColor = System.Drawing.SystemColors.Window;
            this.lblDados.Location = new System.Drawing.Point(32, 279);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(0, 13);
            this.lblDados.TabIndex = 21;
            // 
            // txtDescontoINSS
            // 
            this.txtDescontoINSS.Location = new System.Drawing.Point(309, 347);
            this.txtDescontoINSS.Name = "txtDescontoINSS";
            this.txtDescontoINSS.Size = new System.Drawing.Size(159, 20);
            this.txtDescontoINSS.TabIndex = 22;
            // 
            // txtDescontoIRPF
            // 
            this.txtDescontoIRPF.Location = new System.Drawing.Point(309, 412);
            this.txtDescontoIRPF.Name = "txtDescontoIRPF";
            this.txtDescontoIRPF.Size = new System.Drawing.Size(159, 20);
            this.txtDescontoIRPF.TabIndex = 23;
            // 
            // txtSalarioFamilia
            // 
            this.txtSalarioFamilia.Location = new System.Drawing.Point(32, 480);
            this.txtSalarioFamilia.Name = "txtSalarioFamilia";
            this.txtSalarioFamilia.Size = new System.Drawing.Size(186, 20);
            this.txtSalarioFamilia.TabIndex = 24;
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.Location = new System.Drawing.Point(32, 546);
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.Size = new System.Drawing.Size(186, 20);
            this.txtSalarioLiquido.TabIndex = 25;
            // 
            // txtSalarioBruto
            // 
            this.txtSalarioBruto.Location = new System.Drawing.Point(32, 102);
            this.txtSalarioBruto.Name = "txtSalarioBruto";
            this.txtSalarioBruto.Size = new System.Drawing.Size(186, 20);
            this.txtSalarioBruto.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 593);
            this.Controls.Add(this.txtSalarioBruto);
            this.Controls.Add(this.txtSalarioLiquido);
            this.Controls.Add(this.txtSalarioFamilia);
            this.Controls.Add(this.txtDescontoIRPF);
            this.Controls.Add(this.txtDescontoINSS);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.lblSalarioFamilia);
            this.Controls.Add(this.lblDescontoIRPF);
            this.Controls.Add(this.lblDescontoINSS);
            this.Controls.Add(this.txtAliquotaIRPF);
            this.Controls.Add(this.lblAliquotaIRPF);
            this.Controls.Add(this.txtAliquotaINSS);
            this.Controls.Add(this.lblAliquotaINSS);
            this.Controls.Add(this.rbtnCasado);
            this.Controls.Add(this.gbxSexo);
            this.Controls.Add(this.btnVerificaDesconto);
            this.Controls.Add(this.nupdNumeroFilhos);
            this.Controls.Add(this.lblNumeroFilhos);
            this.Controls.Add(this.lblSalarioBruto);
            this.Controls.Add(this.txtNomeFuncionario);
            this.Controls.Add(this.lblNomeFuncionario);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nupdNumeroFilhos)).EndInit();
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeFuncionario;
        private System.Windows.Forms.TextBox txtNomeFuncionario;
        private System.Windows.Forms.Label lblSalarioBruto;
        private System.Windows.Forms.Label lblNumeroFilhos;
        private System.Windows.Forms.NumericUpDown nupdNumeroFilhos;
        private System.Windows.Forms.Button btnVerificaDesconto;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.RadioButton rbtnFeminino;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.RadioButton rbtnCasado;
        private System.Windows.Forms.Label lblAliquotaINSS;
        private System.Windows.Forms.TextBox txtAliquotaINSS;
        private System.Windows.Forms.TextBox txtAliquotaIRPF;
        private System.Windows.Forms.Label lblAliquotaIRPF;
        private System.Windows.Forms.Label lblDescontoINSS;
        private System.Windows.Forms.Label lblDescontoIRPF;
        private System.Windows.Forms.Label lblSalarioFamilia;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.Label lblDados;
        private System.Windows.Forms.TextBox txtDescontoINSS;
        private System.Windows.Forms.TextBox txtDescontoIRPF;
        private System.Windows.Forms.TextBox txtSalarioFamilia;
        private System.Windows.Forms.TextBox txtSalarioLiquido;
        private System.Windows.Forms.TextBox txtSalarioBruto;
    }
}

