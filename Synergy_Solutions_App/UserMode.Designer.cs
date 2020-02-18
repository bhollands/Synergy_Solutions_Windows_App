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
            this.highScores = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.letter1 = new System.Windows.Forms.DomainUpDown();
            this.letter3 = new System.Windows.Forms.DomainUpDown();
            this.letter2 = new System.Windows.Forms.DomainUpDown();
            this.letter4 = new System.Windows.Forms.DomainUpDown();
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
            // highScores
            // 
            this.highScores.FormattingEnabled = true;
            this.highScores.Location = new System.Drawing.Point(12, 63);
            this.highScores.Name = "highScores";
            this.highScores.Size = new System.Drawing.Size(160, 316);
            this.highScores.TabIndex = 1;
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
            // letter1
            // 
            this.letter1.Items.Add("_");
            this.letter1.Items.Add("A");
            this.letter1.Items.Add("B");
            this.letter1.Items.Add("C");
            this.letter1.Items.Add("D");
            this.letter1.Items.Add("E");
            this.letter1.Items.Add("F");
            this.letter1.Items.Add("G");
            this.letter1.Items.Add("H");
            this.letter1.Items.Add("I");
            this.letter1.Items.Add("J");
            this.letter1.Items.Add("K");
            this.letter1.Items.Add("L");
            this.letter1.Items.Add("M");
            this.letter1.Items.Add("N");
            this.letter1.Items.Add("O");
            this.letter1.Items.Add("P");
            this.letter1.Items.Add("Q");
            this.letter1.Items.Add("R");
            this.letter1.Items.Add("S");
            this.letter1.Items.Add("T");
            this.letter1.Items.Add("U");
            this.letter1.Items.Add("V");
            this.letter1.Items.Add("W");
            this.letter1.Items.Add("X");
            this.letter1.Items.Add("Y");
            this.letter1.Items.Add("Z");
            this.letter1.Location = new System.Drawing.Point(380, 200);
            this.letter1.Name = "letter1";
            this.letter1.Size = new System.Drawing.Size(29, 20);
            this.letter1.TabIndex = 4;
            this.letter1.Text = "_";
            // 
            // letter3
            // 
            this.letter3.Items.Add("_");
            this.letter3.Items.Add("A");
            this.letter3.Items.Add("B");
            this.letter3.Items.Add("C");
            this.letter3.Items.Add("D");
            this.letter3.Items.Add("E");
            this.letter3.Items.Add("F");
            this.letter3.Items.Add("G");
            this.letter3.Items.Add("H");
            this.letter3.Items.Add("I");
            this.letter3.Items.Add("J");
            this.letter3.Items.Add("K");
            this.letter3.Items.Add("L");
            this.letter3.Items.Add("M");
            this.letter3.Items.Add("N");
            this.letter3.Items.Add("O");
            this.letter3.Items.Add("P");
            this.letter3.Items.Add("Q");
            this.letter3.Items.Add("R");
            this.letter3.Items.Add("S");
            this.letter3.Items.Add("T");
            this.letter3.Items.Add("U");
            this.letter3.Items.Add("V");
            this.letter3.Items.Add("W");
            this.letter3.Items.Add("X");
            this.letter3.Items.Add("Y");
            this.letter3.Items.Add("Z");
            this.letter3.Location = new System.Drawing.Point(450, 200);
            this.letter3.Name = "letter3";
            this.letter3.Size = new System.Drawing.Size(34, 20);
            this.letter3.TabIndex = 5;
            this.letter3.Text = "_";
            // 
            // letter2
            // 
            this.letter2.Items.Add("_");
            this.letter2.Items.Add("A");
            this.letter2.Items.Add("B");
            this.letter2.Items.Add("C");
            this.letter2.Items.Add("D");
            this.letter2.Items.Add("E");
            this.letter2.Items.Add("F");
            this.letter2.Items.Add("G");
            this.letter2.Items.Add("H");
            this.letter2.Items.Add("I");
            this.letter2.Items.Add("J");
            this.letter2.Items.Add("K");
            this.letter2.Items.Add("L");
            this.letter2.Items.Add("M");
            this.letter2.Items.Add("N");
            this.letter2.Items.Add("O");
            this.letter2.Items.Add("P");
            this.letter2.Items.Add("Q");
            this.letter2.Items.Add("R");
            this.letter2.Items.Add("S");
            this.letter2.Items.Add("T");
            this.letter2.Items.Add("U");
            this.letter2.Items.Add("V");
            this.letter2.Items.Add("W");
            this.letter2.Items.Add("X");
            this.letter2.Items.Add("Y");
            this.letter2.Items.Add("Z");
            this.letter2.Location = new System.Drawing.Point(415, 200);
            this.letter2.Name = "letter2";
            this.letter2.Size = new System.Drawing.Size(29, 20);
            this.letter2.TabIndex = 6;
            this.letter2.Text = "_";
            // 
            // letter4
            // 
            this.letter4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.letter4.Items.Add("_");
            this.letter4.Items.Add("A");
            this.letter4.Items.Add("B");
            this.letter4.Items.Add("C");
            this.letter4.Items.Add("D");
            this.letter4.Items.Add("E");
            this.letter4.Items.Add("F");
            this.letter4.Items.Add("G");
            this.letter4.Items.Add("H");
            this.letter4.Items.Add("I");
            this.letter4.Items.Add("J");
            this.letter4.Items.Add("K");
            this.letter4.Items.Add("L");
            this.letter4.Items.Add("M");
            this.letter4.Items.Add("N");
            this.letter4.Items.Add("O");
            this.letter4.Items.Add("P");
            this.letter4.Items.Add("Q");
            this.letter4.Items.Add("R");
            this.letter4.Items.Add("S");
            this.letter4.Items.Add("T");
            this.letter4.Items.Add("U");
            this.letter4.Items.Add("V");
            this.letter4.Items.Add("W");
            this.letter4.Items.Add("X");
            this.letter4.Items.Add("Y");
            this.letter4.Items.Add("Z");
            this.letter4.Location = new System.Drawing.Point(490, 200);
            this.letter4.Name = "letter4";
            this.letter4.Size = new System.Drawing.Size(28, 20);
            this.letter4.TabIndex = 7;
            this.letter4.Text = "_";
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.Controls.Add(this.letter4);
            this.Controls.Add(this.letter2);
            this.Controls.Add(this.letter3);
            this.Controls.Add(this.letter1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.highScores);
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
        private System.Windows.Forms.ListBox highScores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DomainUpDown letter1;
        private System.Windows.Forms.DomainUpDown letter3;
        private System.Windows.Forms.DomainUpDown letter2;
        private System.Windows.Forms.DomainUpDown letter4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox scoreText;
    }
}

