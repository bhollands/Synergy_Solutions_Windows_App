namespace Synergy_Solutions_App
{
    partial class StartScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartScreen));
            this.startGame = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.action = new System.Windows.Forms.Label();
            this.img_action = new System.Windows.Forms.PictureBox();
            this.img_arrow = new System.Windows.Forms.PictureBox();
            this.img_button = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.instruction = new System.Windows.Forms.Label();
            this.lanuage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_action)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_arrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lanuage)).BeginInit();
            this.SuspendLayout();
            // 
            // startGame
            // 
            this.startGame.Location = new System.Drawing.Point(16, 591);
            this.startGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(424, 100);
            this.startGame.TabIndex = 0;
            this.startGame.Text = "Start";
            this.startGame.UseVisualStyleBackColor = true;
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // action
            // 
            this.action.AutoSize = true;
            this.action.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.action.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.action.Location = new System.Drawing.Point(713, 33);
            this.action.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.action.Name = "action";
            this.action.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.action.Size = new System.Drawing.Size(248, 69);
            this.action.TabIndex = 3;
            this.action.Text = "Loading";
            this.action.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.action.Visible = false;
            // 
            // img_action
            // 
            this.img_action.Location = new System.Drawing.Point(644, 183);
            this.img_action.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.img_action.Name = "img_action";
            this.img_action.Size = new System.Drawing.Size(607, 400);
            this.img_action.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_action.TabIndex = 4;
            this.img_action.TabStop = false;
            this.img_action.Visible = false;
            // 
            // img_arrow
            // 
            this.img_arrow.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.img_arrow.Image = ((System.Drawing.Image)(resources.GetObject("img_arrow.Image")));
            this.img_arrow.Location = new System.Drawing.Point(16, 103);
            this.img_arrow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.img_arrow.Name = "img_arrow";
            this.img_arrow.Size = new System.Drawing.Size(343, 207);
            this.img_arrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_arrow.TabIndex = 2;
            this.img_arrow.TabStop = false;
            this.img_arrow.Click += new System.EventHandler(this.img_arrow_Click);
            // 
            // img_button
            // 
            this.img_button.Image = ((System.Drawing.Image)(resources.GetObject("img_button.Image")));
            this.img_button.InitialImage = null;
            this.img_button.Location = new System.Drawing.Point(16, 304);
            this.img_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.img_button.Name = "img_button";
            this.img_button.Size = new System.Drawing.Size(424, 279);
            this.img_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_button.TabIndex = 1;
            this.img_button.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 49);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Debug button to UI mode";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(8, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 82);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // instruction
            // 
            this.instruction.AutoSize = true;
            this.instruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.instruction.Location = new System.Drawing.Point(525, 304);
            this.instruction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.instruction.Name = "instruction";
            this.instruction.Size = new System.Drawing.Size(49, 54);
            this.instruction.TabIndex = 8;
            this.instruction.Text = "1";
            this.instruction.Visible = false;
            // 
            // lanuage
            // 
            this.lanuage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lanuage.Image = ((System.Drawing.Image)(resources.GetObject("lanuage.Image")));
            this.lanuage.Location = new System.Drawing.Point(33, 0);
            this.lanuage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lanuage.Name = "lanuage";
            this.lanuage.Size = new System.Drawing.Size(165, 101);
            this.lanuage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lanuage.TabIndex = 9;
            this.lanuage.TabStop = false;
            this.lanuage.Click += new System.EventHandler(this.lanuage_Click);
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1109, 777);
            this.Controls.Add(this.lanuage);
            this.Controls.Add(this.instruction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.img_action);
            this.Controls.Add(this.action);
            this.Controls.Add(this.img_arrow);
            this.Controls.Add(this.img_button);
            this.Controls.Add(this.startGame);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StartScreen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.StartScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_action)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_arrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lanuage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startGame;
        private System.Windows.Forms.PictureBox img_button;
        private System.Windows.Forms.PictureBox img_arrow;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label action;
        private System.Windows.Forms.PictureBox img_action;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label instruction;
        private System.Windows.Forms.PictureBox lanuage;
    }
}