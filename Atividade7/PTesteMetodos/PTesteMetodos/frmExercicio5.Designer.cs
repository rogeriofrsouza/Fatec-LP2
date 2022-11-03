namespace PTesteMetodos
{
    partial class frmExercicio5
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
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.lblNumero2 = new System.Windows.Forms.Label();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.lblSaida = new System.Windows.Forms.Label();
            this.txtSaida = new System.Windows.Forms.TextBox();
            this.btnSortear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(94, 110);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(200, 26);
            this.txtNumero1.TabIndex = 0;
            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.Location = new System.Drawing.Point(94, 88);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(71, 19);
            this.lblNumero1.TabIndex = 1;
            this.lblNumero1.Text = "Número 1";
            // 
            // lblNumero2
            // 
            this.lblNumero2.AutoSize = true;
            this.lblNumero2.Location = new System.Drawing.Point(94, 192);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(71, 19);
            this.lblNumero2.TabIndex = 3;
            this.lblNumero2.Text = "Número 2";
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(94, 214);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(200, 26);
            this.txtNumero2.TabIndex = 2;
            // 
            // lblSaida
            // 
            this.lblSaida.AutoSize = true;
            this.lblSaida.Location = new System.Drawing.Point(387, 88);
            this.lblSaida.Name = "lblSaida";
            this.lblSaida.Size = new System.Drawing.Size(41, 19);
            this.lblSaida.TabIndex = 5;
            this.lblSaida.Text = "Saída";
            // 
            // txtSaida
            // 
            this.txtSaida.Location = new System.Drawing.Point(387, 110);
            this.txtSaida.Name = "txtSaida";
            this.txtSaida.ReadOnly = true;
            this.txtSaida.Size = new System.Drawing.Size(200, 26);
            this.txtSaida.TabIndex = 4;
            // 
            // btnSortear
            // 
            this.btnSortear.Location = new System.Drawing.Point(387, 201);
            this.btnSortear.Name = "btnSortear";
            this.btnSortear.Size = new System.Drawing.Size(139, 51);
            this.btnSortear.TabIndex = 6;
            this.btnSortear.Text = "Sortear";
            this.btnSortear.UseVisualStyleBackColor = true;
            this.btnSortear.Click += new System.EventHandler(this.btnSortear_Click);
            // 
            // frmExercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSortear);
            this.Controls.Add(this.lblSaida);
            this.Controls.Add(this.txtSaida);
            this.Controls.Add(this.lblNumero2);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.lblNumero1);
            this.Controls.Add(this.txtNumero1);
            this.Name = "frmExercicio5";
            this.Text = "frmExercicio5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNumero1;
        private Label lblNumero1;
        private Label lblNumero2;
        private TextBox txtNumero2;
        private Label lblSaida;
        private TextBox txtSaida;
        private Button btnSortear;
    }
}