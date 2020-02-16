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
            this.Score = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.domainUpDown2 = new System.Windows.Forms.DomainUpDown();
            this.domainUpDown3 = new System.Windows.Forms.DomainUpDown();
            this.domainUpDown4 = new System.Windows.Forms.DomainUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.scoreText = new System.Windows.Forms.TextBox();
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
            // Score
            // 
            this.Score.FormattingEnabled = true;
            this.Score.Location = new System.Drawing.Point(12, 63);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(160, 316);
            this.Score.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "High Scores!!";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Items.Add("_");
            this.domainUpDown1.Items.Add("A");
            this.domainUpDown1.Items.Add("B");
            this.domainUpDown1.Items.Add("C");
            this.domainUpDown1.Items.Add("D");
            this.domainUpDown1.Items.Add("E");
            this.domainUpDown1.Items.Add("F");
            this.domainUpDown1.Items.Add("G");
            this.domainUpDown1.Items.Add("H");
            this.domainUpDown1.Items.Add("I");
            this.domainUpDown1.Items.Add("J");
            this.domainUpDown1.Items.Add("K");
            this.domainUpDown1.Items.Add("L");
            this.domainUpDown1.Items.Add("M");
            this.domainUpDown1.Items.Add("N");
            this.domainUpDown1.Items.Add("O");
            this.domainUpDown1.Items.Add("P");
            this.domainUpDown1.Items.Add("Q");
            this.domainUpDown1.Items.Add("R");
            this.domainUpDown1.Items.Add("S");
            this.domainUpDown1.Items.Add("T");
            this.domainUpDown1.Items.Add("U");
            this.domainUpDown1.Items.Add("V");
            this.domainUpDown1.Items.Add("W");
            this.domainUpDown1.Items.Add("X");
            this.domainUpDown1.Items.Add("Y");
            this.domainUpDown1.Items.Add("Z");
            this.domainUpDown1.Location = new System.Drawing.Point(380, 200);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(29, 20);
            this.domainUpDown1.TabIndex = 4;
            this.domainUpDown1.Text = "_";
            // 
            // domainUpDown2
            // 
            this.domainUpDown2.Items.Add("_");
            this.domainUpDown2.Items.Add("A");
            this.domainUpDown2.Items.Add("B");
            this.domainUpDown2.Items.Add("C");
            this.domainUpDown2.Items.Add("D");
            this.domainUpDown2.Items.Add("E");
            this.domainUpDown2.Items.Add("F");
            this.domainUpDown2.Items.Add("G");
            this.domainUpDown2.Items.Add("H");
            this.domainUpDown2.Items.Add("I");
            this.domainUpDown2.Items.Add("J");
            this.domainUpDown2.Items.Add("K");
            this.domainUpDown2.Items.Add("L");
            this.domainUpDown2.Items.Add("M");
            this.domainUpDown2.Items.Add("N");
            this.domainUpDown2.Items.Add("O");
            this.domainUpDown2.Items.Add("P");
            this.domainUpDown2.Items.Add("Q");
            this.domainUpDown2.Items.Add("R");
            this.domainUpDown2.Items.Add("S");
            this.domainUpDown2.Items.Add("T");
            this.domainUpDown2.Items.Add("U");
            this.domainUpDown2.Items.Add("V");
            this.domainUpDown2.Items.Add("W");
            this.domainUpDown2.Items.Add("X");
            this.domainUpDown2.Items.Add("Y");
            this.domainUpDown2.Items.Add("Z");
            this.domainUpDown2.Location = new System.Drawing.Point(450, 200);
            this.domainUpDown2.Name = "domainUpDown2";
            this.domainUpDown2.Size = new System.Drawing.Size(34, 20);
            this.domainUpDown2.TabIndex = 5;
            this.domainUpDown2.Text = "_";
            // 
            // domainUpDown3
            // 
            this.domainUpDown3.Items.Add("_");
            this.domainUpDown3.Items.Add("A");
            this.domainUpDown3.Items.Add("B");
            this.domainUpDown3.Items.Add("C");
            this.domainUpDown3.Items.Add("D");
            this.domainUpDown3.Items.Add("E");
            this.domainUpDown3.Items.Add("F");
            this.domainUpDown3.Items.Add("G");
            this.domainUpDown3.Items.Add("H");
            this.domainUpDown3.Items.Add("I");
            this.domainUpDown3.Items.Add("J");
            this.domainUpDown3.Items.Add("K");
            this.domainUpDown3.Items.Add("L");
            this.domainUpDown3.Items.Add("M");
            this.domainUpDown3.Items.Add("N");
            this.domainUpDown3.Items.Add("O");
            this.domainUpDown3.Items.Add("P");
            this.domainUpDown3.Items.Add("Q");
            this.domainUpDown3.Items.Add("R");
            this.domainUpDown3.Items.Add("S");
            this.domainUpDown3.Items.Add("T");
            this.domainUpDown3.Items.Add("U");
            this.domainUpDown3.Items.Add("V");
            this.domainUpDown3.Items.Add("W");
            this.domainUpDown3.Items.Add("X");
            this.domainUpDown3.Items.Add("Y");
            this.domainUpDown3.Items.Add("Z");
            this.domainUpDown3.Location = new System.Drawing.Point(415, 200);
            this.domainUpDown3.Name = "domainUpDown3";
            this.domainUpDown3.Size = new System.Drawing.Size(29, 20);
            this.domainUpDown3.TabIndex = 6;
            this.domainUpDown3.Text = "_";
            // 
            // domainUpDown4
            // 
            this.domainUpDown4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.domainUpDown4.Items.Add("_");
            this.domainUpDown4.Items.Add("A");
            this.domainUpDown4.Items.Add("B");
            this.domainUpDown4.Items.Add("C");
            this.domainUpDown4.Items.Add("D");
            this.domainUpDown4.Items.Add("E");
            this.domainUpDown4.Items.Add("F");
            this.domainUpDown4.Items.Add("G");
            this.domainUpDown4.Items.Add("H");
            this.domainUpDown4.Items.Add("I");
            this.domainUpDown4.Items.Add("J");
            this.domainUpDown4.Items.Add("K");
            this.domainUpDown4.Items.Add("L");
            this.domainUpDown4.Items.Add("M");
            this.domainUpDown4.Items.Add("N");
            this.domainUpDown4.Items.Add("O");
            this.domainUpDown4.Items.Add("P");
            this.domainUpDown4.Items.Add("Q");
            this.domainUpDown4.Items.Add("R");
            this.domainUpDown4.Items.Add("S");
            this.domainUpDown4.Items.Add("T");
            this.domainUpDown4.Items.Add("U");
            this.domainUpDown4.Items.Add("V");
            this.domainUpDown4.Items.Add("W");
            this.domainUpDown4.Items.Add("X");
            this.domainUpDown4.Items.Add("Y");
            this.domainUpDown4.Items.Add("Z");
            this.domainUpDown4.Location = new System.Drawing.Point(490, 200);
            this.domainUpDown4.Name = "domainUpDown4";
            this.domainUpDown4.Size = new System.Drawing.Size(28, 20);
            this.domainUpDown4.TabIndex = 7;
            this.domainUpDown4.Text = "_";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Your Score:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(363, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 13;
            // 
            // scoreText
            // 
            this.scoreText.Location = new System.Drawing.Point(380, 101);
            this.scoreText.Name = "scoreText";
            this.scoreText.ReadOnly = true;
            this.scoreText.Size = new System.Drawing.Size(138, 20);
            this.scoreText.TabIndex = 14;
            this.scoreText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UserMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 478);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.domainUpDown4);
            this.Controls.Add(this.domainUpDown3);
            this.Controls.Add(this.domainUpDown2);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Score);
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
        private System.Windows.Forms.ListBox Score;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.DomainUpDown domainUpDown2;
        private System.Windows.Forms.DomainUpDown domainUpDown3;
        private System.Windows.Forms.DomainUpDown domainUpDown4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox scoreText;
    }
}

