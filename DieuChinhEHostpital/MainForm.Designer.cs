namespace DieuChinhEHostpital
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveBenhAnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSoLePDTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveBenhAnToolStripMenuItem,
            this.saveSoLePDTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1250, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveBenhAnToolStripMenuItem
            // 
            this.saveBenhAnToolStripMenuItem.Name = "saveBenhAnToolStripMenuItem";
            this.saveBenhAnToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.saveBenhAnToolStripMenuItem.Text = "SaveBenhAn";
            this.saveBenhAnToolStripMenuItem.Click += new System.EventHandler(this.saveBenhAnToolStripMenuItem_Click);
            // 
            // saveSoLePDTToolStripMenuItem
            // 
            this.saveSoLePDTToolStripMenuItem.Name = "saveSoLePDTToolStripMenuItem";
            this.saveSoLePDTToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.saveSoLePDTToolStripMenuItem.Text = "SaveSoLePDT";
            this.saveSoLePDTToolStripMenuItem.Click += new System.EventHandler(this.saveSoLePDTToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 653);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveBenhAnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSoLePDTToolStripMenuItem;
    }
}