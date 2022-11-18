namespace PMenuStrings
{
    partial class frmExercicio1
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
            this.btnCalcularEspacos = new System.Windows.Forms.Button();
            this.btnLetraR = new System.Windows.Forms.Button();
            this.btnParLetras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbxTexto
            // 
            this.rtbxTexto.Location = new System.Drawing.Point(147, 68);
            this.rtbxTexto.Name = "rtbxTexto";
            this.rtbxTexto.Size = new System.Drawing.Size(431, 181);
            this.rtbxTexto.TabIndex = 0;
            this.rtbxTexto.Text = "";
            // 
            // btnCalcularEspacos
            // 
            this.btnCalcularEspacos.Location = new System.Drawing.Point(147, 286);
            this.btnCalcularEspacos.Name = "btnCalcularEspacos";
            this.btnCalcularEspacos.Size = new System.Drawing.Size(125, 64);
            this.btnCalcularEspacos.TabIndex = 1;
            this.btnCalcularEspacos.Text = "Calcular espaços em branco";
            this.btnCalcularEspacos.UseVisualStyleBackColor = true;
            this.btnCalcularEspacos.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLetraR
            // 
            this.btnLetraR.Location = new System.Drawing.Point(324, 286);
            this.btnLetraR.Name = "btnLetraR";
            this.btnLetraR.Size = new System.Drawing.Size(134, 64);
            this.btnLetraR.TabIndex = 2;
            this.btnLetraR.Text = "Calcular letras R";
            this.btnLetraR.UseVisualStyleBackColor = true;
            this.btnLetraR.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnParLetras
            // 
            this.btnParLetras.Location = new System.Drawing.Point(503, 286);
            this.btnParLetras.Name = "btnParLetras";
            this.btnParLetras.Size = new System.Drawing.Size(122, 64);
            this.btnParLetras.TabIndex = 3;
            this.btnParLetras.Text = "Calcular par de letras";
            this.btnParLetras.UseVisualStyleBackColor = true;
            this.btnParLetras.Click += new System.EventHandler(this.btnParLetras_Click);
            // 
            // frmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnParLetras);
            this.Controls.Add(this.btnLetraR);
            this.Controls.Add(this.btnCalcularEspacos);
            this.Controls.Add(this.rtbxTexto);
            this.Name = "frmExercicio1";
            this.Text = "frmExercicio1";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox rtbxTexto;
        private Button btnCalcularEspacos;
        private Button btnLetraR;
        private Button btnParLetras;
    }
}