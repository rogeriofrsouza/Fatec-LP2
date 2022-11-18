namespace PMenuStrings
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
            this.rtbxTexto = new System.Windows.Forms.RichTextBox();
            this.btnVerificarPalindromo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbxTexto
            // 
            this.rtbxTexto.Location = new System.Drawing.Point(192, 73);
            this.rtbxTexto.Name = "rtbxTexto";
            this.rtbxTexto.Size = new System.Drawing.Size(371, 186);
            this.rtbxTexto.TabIndex = 0;
            this.rtbxTexto.Text = "";
            // 
            // btnVerificarPalindromo
            // 
            this.btnVerificarPalindromo.Location = new System.Drawing.Point(192, 297);
            this.btnVerificarPalindromo.Name = "btnVerificarPalindromo";
            this.btnVerificarPalindromo.Size = new System.Drawing.Size(147, 62);
            this.btnVerificarPalindromo.TabIndex = 1;
            this.btnVerificarPalindromo.Text = "Verificar palíndromo";
            this.btnVerificarPalindromo.UseVisualStyleBackColor = true;
            this.btnVerificarPalindromo.Click += new System.EventHandler(this.btnVerificarPalindromo_Click);
            // 
            // frmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVerificarPalindromo);
            this.Controls.Add(this.rtbxTexto);
            this.Name = "frmExercicio3";
            this.Text = "frmExercicio3";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox rtbxTexto;
        private Button btnVerificarPalindromo;
    }
}