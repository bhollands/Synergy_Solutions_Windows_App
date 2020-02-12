namespace Synergy_Solutions_App
{
    partial class UserMode
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintainceModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.youreOnYourOwnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noHelpHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getGudM8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(722, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maintainceModeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // maintainceModeToolStripMenuItem
            // 
            this.maintainceModeToolStripMenuItem.Name = "maintainceModeToolStripMenuItem";
            this.maintainceModeToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.maintainceModeToolStripMenuItem.Text = "Maintaince Mode";
            this.maintainceModeToolStripMenuItem.Click += new System.EventHandler(this.maintainceModeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.youreOnYourOwnToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // youreOnYourOwnToolStripMenuItem
            // 
            this.youreOnYourOwnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noHelpHereToolStripMenuItem});
            this.youreOnYourOwnToolStripMenuItem.Name = "youreOnYourOwnToolStripMenuItem";
            this.youreOnYourOwnToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.youreOnYourOwnToolStripMenuItem.Text = "You\'re on your own";
            // 
            // noHelpHereToolStripMenuItem
            // 
            this.noHelpHereToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getGudM8ToolStripMenuItem});
            this.noHelpHereToolStripMenuItem.Name = "noHelpHereToolStripMenuItem";
            this.noHelpHereToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.noHelpHereToolStripMenuItem.Text = "No help here";
            // 
            // getGudM8ToolStripMenuItem
            // 
            this.getGudM8ToolStripMenuItem.Name = "getGudM8ToolStripMenuItem";
            this.getGudM8ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.getGudM8ToolStripMenuItem.Text = "Get gud m8";
            // 
            // UserMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 478);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserMode";
            this.Text = "UserMode";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintainceModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem youreOnYourOwnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noHelpHereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getGudM8ToolStripMenuItem;
    }
}

