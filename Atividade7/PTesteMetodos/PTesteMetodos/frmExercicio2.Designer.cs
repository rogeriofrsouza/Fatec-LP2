namespace PTesteMetodos
{
    partial class frmExercicio2
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
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.lblPalavra1 = new System.Windows.Forms.Label();
            this.lblPalavra2 = new System.Windows.Forms.Label();
            this.btnTestarIguais = new System.Windows.Forms.Button();
            this.btnInserirPalavra = new System.Windows.Forms.Button();
            this.btnInserirAsteriscos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(72, 115);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(229, 26);
            this.txtPalavra1.TabIndex = 0;
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(391, 115);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(229, 26);
            this.txtPalavra2.TabIndex = 1;
            // 
            // lblPalavra1
            // 
            this.lblPalavra1.AutoSize = true;
            this.lblPalavra1.Location = new System.Drawing.Point(72, 91);
            this.lblPalavra1.Name = "lblPalavra1";
            this.lblPalavra1.Size = new System.Drawing.Size(65, 19);
            this.lblPalavra1.TabIndex = 2;
            this.lblPalavra1.Text = "Palavra 1";
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Location = new System.Drawing.Point(391, 91);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(65, 19);
            this.lblPalavra2.TabIndex = 3;
            this.lblPalavra2.Text = "Palavra 2";
            // 
            // btnTestarIguais
            // 
            this.btnTestarIguais.Location = new System.Drawing.Point(72, 199);
            this.btnTestarIguais.Name = "btnTestarIguais";
            this.btnTestarIguais.Size = new System.Drawing.Size(140, 63);
            this.btnTestarIguais.TabIndex = 4;
            this.btnTestarIguais.Text = "Testar iguais";
            this.btnTestarIguais.UseVisualStyleBackColor = true;
            this.btnTestarIguais.Click += new System.EventHandler(this.btnTestarIguais_Click);
            // 
            // btnInserirPalavra
            // 
            this.btnInserirPalavra.Location = new System.Drawing.Point(282, 199);
            this.btnInserirPalavra.Name = "btnInserirPalavra";
            this.btnInserirPalavra.Size = new System.Drawing.Size(141, 63);
            this.btnInserirPalavra.TabIndex = 5;
            this.btnInserirPalavra.Text = "Inserir Palavra 1 na Palavra 2";
            this.btnInserirPalavra.UseVisualStyleBackColor = true;
            this.btnInserirPalavra.Click += new System.EventHandler(this.btnInserirPalavra_Click);
            // 
            // btnInserirAsteriscos
            // 
            this.btnInserirAsteriscos.Location = new System.Drawing.Point(488, 199);
            this.btnInserirAsteriscos.Name = "btnInserirAsteriscos";
            this.btnInserirAsteriscos.Size = new System.Drawing.Size(132, 63);
            this.btnInserirAsteriscos.TabIndex = 6;
            this.btnInserirAsteriscos.Text = "Inserir asteríscos na Palavra 1";
            this.btnInserirAsteriscos.UseVisualStyleBackColor = true;
            this.btnInserirAsteriscos.Click += new System.EventHandler(this.btnInserirAsteriscos_Click);
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInserirAsteriscos);
            this.Controls.Add(this.btnInserirPalavra);
            this.Controls.Add(this.btnTestarIguais);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.lblPalavra1);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.txtPalavra1);
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtPalavra1;
        private TextBox txtPalavra2;
        private Label lblPalavra1;
        private Label lblPalavra2;
        private Button btnTestarIguais;
        private Button btnInserirPalavra;
        private Button btnInserirAsteriscos;
    }
}