namespace PMenuStrings
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ex1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ex2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ex3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ex4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ex1ToolStripMenuItem,
            this.ex2ToolStripMenuItem,
            this.ex3ToolStripMenuItem,
            this.ex4ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ex1ToolStripMenuItem
            // 
            this.ex1ToolStripMenuItem.Name = "ex1ToolStripMenuItem";
            this.ex1ToolStripMenuItem.Size = new System.Drawing.Size(84, 23);
            this.ex1ToolStripMenuItem.Text = "Exercício &1";
            this.ex1ToolStripMenuItem.Click += new System.EventHandler(this.ex1ToolStripMenuItem_Click);
            // 
            // ex2ToolStripMenuItem
            // 
            this.ex2ToolStripMenuItem.Name = "ex2ToolStripMenuItem";
            this.ex2ToolStripMenuItem.Size = new System.Drawing.Size(84, 23);
            this.ex2ToolStripMenuItem.Text = "Exercício &2";
            this.ex2ToolStripMenuItem.Click += new System.EventHandler(this.ex2ToolStripMenuItem_Click);
            // 
            // ex3ToolStripMenuItem
            // 
            this.ex3ToolStripMenuItem.Name = "ex3ToolStripMenuItem";
            this.ex3ToolStripMenuItem.Size = new System.Drawing.Size(84, 23);
            this.ex3ToolStripMenuItem.Text = "Exercício &3";
            this.ex3ToolStripMenuItem.Click += new System.EventHandler(this.ex3ToolStripMenuItem_Click);
            // 
            // ex4ToolStripMenuItem
            // 
            this.ex4ToolStripMenuItem.Name = "ex4ToolStripMenuItem";
            this.ex4ToolStripMenuItem.Size = new System.Drawing.Size(84, 23);
            this.ex4ToolStripMenuItem.Text = "Exercício &4";
            this.ex4ToolStripMenuItem.Click += new System.EventHandler(this.ex4ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ex1ToolStripMenuItem;
        private ToolStripMenuItem ex2ToolStripMenuItem;
        private ToolStripMenuItem ex3ToolStripMenuItem;
        private ToolStripMenuItem ex4ToolStripMenuItem;
    }
}