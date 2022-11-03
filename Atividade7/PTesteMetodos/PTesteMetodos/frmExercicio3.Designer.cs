namespace PTesteMetodos
{
    partial class frmExercicio3
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
            this.lblPalavra1 = new System.Windows.Forms.Label();
            this.lblPalavra2 = new System.Windows.Forms.Label();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.btnRemoverOcorrencias = new System.Windows.Forms.Button();
            this.btnRemoverReplace = new System.Windows.Forms.Button();
            this.btnInverter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(82, 117);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(227, 26);
            this.txtPalavra1.TabIndex = 0;
            // 
            // lblPalavra1
            // 
            this.lblPalavra1.AutoSize = true;
            this.lblPalavra1.Location = new System.Drawing.Point(82, 95);
            this.lblPalavra1.Name = "lblPalavra1";
            this.lblPalavra1.Size = new System.Drawing.Size(65, 19);
            this.lblPalavra1.TabIndex = 1;
            this.lblPalavra1.Text = "Palavra 1";
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Location = new System.Drawing.Point(417, 95);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(65, 19);
            this.lblPalavra2.TabIndex = 3;
            this.lblPalavra2.Text = "Palavra 2";
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(417, 117);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(227, 26);
            this.txtPalavra2.TabIndex = 2;
            // 
            // btnRemoverOcorrencias
            // 
            this.btnRemoverOcorrencias.Location = new System.Drawing.Point(82, 204);
            this.btnRemoverOcorrencias.Name = "btnRemoverOcorrencias";
            this.btnRemoverOcorrencias.Size = new System.Drawing.Size(147, 61);
            this.btnRemoverOcorrencias.TabIndex = 4;
            this.btnRemoverOcorrencias.Text = "Remover ocorrências";
            this.btnRemoverOcorrencias.UseVisualStyleBackColor = true;
            this.btnRemoverOcorrencias.Click += new System.EventHandler(this.btnRemoverOcorrencias_Click);
            // 
            // btnRemoverReplace
            // 
            this.btnRemoverReplace.Location = new System.Drawing.Point(292, 204);
            this.btnRemoverReplace.Name = "btnRemoverReplace";
            this.btnRemoverReplace.Size = new System.Drawing.Size(147, 61);
            this.btnRemoverReplace.TabIndex = 5;
            this.btnRemoverReplace.Text = "Remover ocorrências (Replace)";
            this.btnRemoverReplace.UseVisualStyleBackColor = true;
            this.btnRemoverReplace.Click += new System.EventHandler(this.btnRemoverReplace_Click);
            // 
            // btnInverter
            // 
            this.btnInverter.Location = new System.Drawing.Point(497, 204);
            this.btnInverter.Name = "btnInverter";
            this.btnInverter.Size = new System.Drawing.Size(147, 61);
            this.btnInverter.TabIndex = 6;
            this.btnInverter.Text = "Inverter Palavra 1";
            this.btnInverter.UseVisualStyleBackColor = true;
            this.btnInverter.Click += new System.EventHandler(this.btnInverter_Click);
            // 
            // frmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInverter);
            this.Controls.Add(this.btnRemoverReplace);
            this.Controls.Add(this.btnRemoverOcorrencias);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.lblPalavra1);
            this.Controls.Add(this.txtPalavra1);
            this.Name = "frmExercicio3";
            this.Text = "frmExercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtPalavra1;
        private Label lblPalavra1;
        private Label lblPalavra2;
        private TextBox txtPalavra2;
        private Button btnRemoverOcorrencias;
        private Button btnRemoverReplace;
        private Button btnInverter;
    }
}