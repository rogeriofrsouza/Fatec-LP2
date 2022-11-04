namespace PMatrizes
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
            this.btnLerNumeros = new System.Windows.Forms.Button();
            this.btnLerQtde = new System.Windows.Forms.Button();
            this.btnVariavelTotal = new System.Windows.Forms.Button();
            this.btnArrayList = new System.Windows.Forms.Button();
            this.btnMediaAlunos = new System.Windows.Forms.Button();
            this.btnNomesPessoas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLerNumeros
            // 
            this.btnLerNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLerNumeros.Location = new System.Drawing.Point(107, 102);
            this.btnLerNumeros.Name = "btnLerNumeros";
            this.btnLerNumeros.Size = new System.Drawing.Size(142, 75);
            this.btnLerNumeros.TabIndex = 0;
            this.btnLerNumeros.Text = "Ler 20 números e inverter";
            this.btnLerNumeros.UseVisualStyleBackColor = true;
            this.btnLerNumeros.Click += new System.EventHandler(this.btnLerNumeros_Click);
            // 
            // btnLerQtde
            // 
            this.btnLerQtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLerQtde.Location = new System.Drawing.Point(318, 102);
            this.btnLerQtde.Name = "btnLerQtde";
            this.btnLerQtde.Size = new System.Drawing.Size(142, 75);
            this.btnLerQtde.TabIndex = 1;
            this.btnLerQtde.Text = "Ler quantidade e preço mercadorias";
            this.btnLerQtde.UseVisualStyleBackColor = true;
            this.btnLerQtde.Click += new System.EventHandler(this.btnLerQtde_Click);
            // 
            // btnVariavelTotal
            // 
            this.btnVariavelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnVariavelTotal.Location = new System.Drawing.Point(546, 102);
            this.btnVariavelTotal.Name = "btnVariavelTotal";
            this.btnVariavelTotal.Size = new System.Drawing.Size(142, 75);
            this.btnVariavelTotal.TabIndex = 2;
            this.btnVariavelTotal.Text = "Variável total";
            this.btnVariavelTotal.UseVisualStyleBackColor = true;
            this.btnVariavelTotal.Click += new System.EventHandler(this.btnVariavelTotal_Click);
            // 
            // btnArrayList
            // 
            this.btnArrayList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnArrayList.Location = new System.Drawing.Point(107, 236);
            this.btnArrayList.Name = "btnArrayList";
            this.btnArrayList.Size = new System.Drawing.Size(142, 75);
            this.btnArrayList.TabIndex = 3;
            this.btnArrayList.Text = "Array List";
            this.btnArrayList.UseVisualStyleBackColor = true;
            this.btnArrayList.Click += new System.EventHandler(this.btnArrayList_Click);
            // 
            // btnMediaAlunos
            // 
            this.btnMediaAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnMediaAlunos.Location = new System.Drawing.Point(318, 236);
            this.btnMediaAlunos.Name = "btnMediaAlunos";
            this.btnMediaAlunos.Size = new System.Drawing.Size(142, 75);
            this.btnMediaAlunos.TabIndex = 4;
            this.btnMediaAlunos.Text = "Média alunos";
            this.btnMediaAlunos.UseVisualStyleBackColor = true;
            this.btnMediaAlunos.Click += new System.EventHandler(this.btnMediaAlunos_Click);
            // 
            // btnNomesPessoas
            // 
            this.btnNomesPessoas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNomesPessoas.Location = new System.Drawing.Point(546, 236);
            this.btnNomesPessoas.Name = "btnNomesPessoas";
            this.btnNomesPessoas.Size = new System.Drawing.Size(142, 75);
            this.btnNomesPessoas.TabIndex = 5;
            this.btnNomesPessoas.Text = "Nomes pessoas";
            this.btnNomesPessoas.UseVisualStyleBackColor = true;
            this.btnNomesPessoas.Click += new System.EventHandler(this.btnNomesPessoas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 441);
            this.Controls.Add(this.btnNomesPessoas);
            this.Controls.Add(this.btnMediaAlunos);
            this.Controls.Add(this.btnArrayList);
            this.Controls.Add(this.btnVariavelTotal);
            this.Controls.Add(this.btnLerQtde);
            this.Controls.Add(this.btnLerNumeros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLerNumeros;
        private System.Windows.Forms.Button btnLerQtde;
        private System.Windows.Forms.Button btnVariavelTotal;
        private System.Windows.Forms.Button btnArrayList;
        private System.Windows.Forms.Button btnMediaAlunos;
        private System.Windows.Forms.Button btnNomesPessoas;
    }
}

