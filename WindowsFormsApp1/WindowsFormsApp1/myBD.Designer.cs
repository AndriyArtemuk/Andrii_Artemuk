
namespace WindowsFormsApp1
{
    partial class myBD
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
            this.tableBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calk1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calk2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tableBDToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.calculatorToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tableBDToolStripMenuItem
            // 
            this.tableBDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.animalsToolStripMenuItem,
            this.plantsToolStripMenuItem});
            this.tableBDToolStripMenuItem.Name = "tableBDToolStripMenuItem";
            this.tableBDToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.tableBDToolStripMenuItem.Text = "Table BD";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calk1ToolStripMenuItem,
            this.calk2ToolStripMenuItem});
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            // 
            // calk1ToolStripMenuItem
            // 
            this.calk1ToolStripMenuItem.Name = "calk1ToolStripMenuItem";
            this.calk1ToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.calk1ToolStripMenuItem.Text = "Calk_1";
            this.calk1ToolStripMenuItem.Click += new System.EventHandler(this.calk1ToolStripMenuItem_Click);
            // 
            // calk2ToolStripMenuItem
            // 
            this.calk2ToolStripMenuItem.Name = "calk2ToolStripMenuItem";
            this.calk2ToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.calk2ToolStripMenuItem.Text = "Calk_2";
            this.calk2ToolStripMenuItem.Click += new System.EventHandler(this.calk2ToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exirToolStripMenuItem
            // 
            this.exirToolStripMenuItem.Name = "exirToolStripMenuItem";
            this.exirToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exirToolStripMenuItem.Text = "Exit";
            this.exirToolStripMenuItem.Click += new System.EventHandler(this.exirToolStripMenuItem_Click);
            // 
            // animalsToolStripMenuItem
            // 
            this.animalsToolStripMenuItem.Name = "animalsToolStripMenuItem";
            this.animalsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.animalsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.animalsToolStripMenuItem.Text = "Animals";
            this.animalsToolStripMenuItem.Click += new System.EventHandler(this.animalsToolStripMenuItem_Click);
            // 
            // plantsToolStripMenuItem
            // 
            this.plantsToolStripMenuItem.Name = "plantsToolStripMenuItem";
            this.plantsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.plantsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.plantsToolStripMenuItem.Text = "Plants";
            // 
            // myBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "myBD";
            this.Text = "myBD";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tableBDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calk1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calk2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plantsToolStripMenuItem;
    }
}