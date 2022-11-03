namespace PTesteMetodos
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
            this.rtbxTexto = new System.Windows.Forms.RichTextBox();
            this.btnNumericos = new System.Windows.Forms.Button();
            this.btnBranco = new System.Windows.Forms.Button();
            this.btnAlfabeticos = new System.Windows.Forms.Button();
            this.lblTexto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbxTexto
            // 
            this.rtbxTexto.Location = new System.Drawing.Point(94, 70);
            this.rtbxTexto.Name = "rtbxTexto";
            this.rtbxTexto.Size = new System.Drawing.Size(563, 176);
            this.rtbxTexto.TabIndex = 0;
            this.rtbxTexto.Text = "";
            // 
            // btnNumericos
            // 
            this.btnNumericos.Location = new System.Drawing.Point(92, 299);
            this.btnNumericos.Name = "btnNumericos";
            this.btnNumericos.Size = new System.Drawing.Size(146, 51);
            this.btnNumericos.TabIndex = 1;
            this.btnNumericos.Text = "Caracteres numéricos";
            this.btnNumericos.UseVisualStyleBackColor = true;
            this.btnNumericos.Click += new System.EventHandler(this.btnNumericos_Click);
            // 
            // btnBranco
            // 
            this.btnBranco.Location = new System.Drawing.Point(303, 299);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(146, 51);
            this.btnBranco.TabIndex = 2;
            this.btnBranco.Text = "Primeiro caracter branco";
            this.btnBranco.UseVisualStyleBackColor = true;
            this.btnBranco.Click += new System.EventHandler(this.btnBranco_Click);
            // 
            // btnAlfabeticos
            // 
            this.btnAlfabeticos.Location = new System.Drawing.Point(512, 299);
            this.btnAlfabeticos.Name = "btnAlfabeticos";
            this.btnAlfabeticos.Size = new System.Drawing.Size(146, 51);
            this.btnAlfabeticos.TabIndex = 3;
            this.btnAlfabeticos.Text = "Caracteres alfabéticos";
            this.btnAlfabeticos.UseVisualStyleBackColor = true;
            this.btnAlfabeticos.Click += new System.EventHandler(this.btnAlfabeticos_Click);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(94, 48);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(101, 19);
            this.lblTexto.TabIndex = 4;
            this.lblTexto.Text = "Insira um texto";
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 466);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.btnAlfabeticos);
            this.Controls.Add(this.btnBranco);
            this.Controls.Add(this.btnNumericos);
            this.Controls.Add(this.rtbxTexto);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox rtbxTexto;
        private Button btnNumericos;
        private Button btnBranco;
        private Button btnAlfabeticos;
        private Label lblTexto;
    }
}