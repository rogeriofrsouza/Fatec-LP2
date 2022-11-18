namespace PNotas
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
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lbxResultado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnVerificar
            // 
            this.btnVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnVerificar.Location = new System.Drawing.Point(102, 177);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(265, 95);
            this.btnVerificar.TabIndex = 0;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lbxResultado
            // 
            this.lbxResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbxResultado.FormattingEnabled = true;
            this.lbxResultado.ItemHeight = 20;
            this.lbxResultado.Location = new System.Drawing.Point(474, 64);
            this.lbxResultado.Name = "lbxResultado";
            this.lbxResultado.Size = new System.Drawing.Size(388, 344);
            this.lbxResultado.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 511);
            this.Controls.Add(this.lbxResultado);
            this.Controls.Add(this.btnVerificar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.ListBox lbxResultado;
    }
}

