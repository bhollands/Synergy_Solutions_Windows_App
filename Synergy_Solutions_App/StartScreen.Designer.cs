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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.instruction = new System.Windows.Forms.Label();
            this.img_star02_2 = new System.Windows.Forms.PictureBox();
            this.img_star01_2 = new System.Windows.Forms.PictureBox();
            this.img_planet02_2 = new System.Windows.Forms.PictureBox();
            this.img_planet02_3 = new System.Windows.Forms.PictureBox();
            this.img_star01_1 = new System.Windows.Forms.PictureBox();
            this.img_planet03_2 = new System.Windows.Forms.PictureBox();
            this.img_star02_1 = new System.Windows.Forms.PictureBox();
            this.img_planet04F_1 = new System.Windows.Forms.PictureBox();
            this.img_planet01_2 = new System.Windows.Forms.PictureBox();
            this.img_planet04_1 = new System.Windows.Forms.PictureBox();
            this.img_planet03_1 = new System.Windows.Forms.PictureBox();
            this.img_planet02_1 = new System.Windows.Forms.PictureBox();
            this.img_planet01_1 = new System.Windows.Forms.PictureBox();
            this.img_UFO = new System.Windows.Forms.PictureBox();
            this.lanuage = new System.Windows.Forms.PictureBox();
            this.img_action = new System.Windows.Forms.PictureBox();
            this.img_arrow = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gameSerial = new System.IO.Ports.SerialPort(this.components);
            this.Title = new System.Windows.Forms.Label();
            this.loadingScreen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_star02_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_star01_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_planet02_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_planet02_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_star01_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_planet03_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_star02_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_planet04F_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_planet01_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_planet04_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_planet03_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_planet02_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_planet01_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_UFO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lanuage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_action)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_arrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // startGame
            // 
            this.startGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGame.Location = new System.Drawing.Point(14, 398);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(318, 81);
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
            this.action.Location = new System.Drawing.Point(198, 24);
            this.action.Name = "action";
            this.action.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.action.Size = new System.Drawing.Size(203, 55);
            this.action.TabIndex = 3;
            this.action.Text = "Loading";
            this.action.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.action.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Debug";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(28, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Debug button to UI mode";
            this.label1.Visible = false;
            // 
            // instruction
            // 
            this.instruction.AutoSize = true;
            this.instruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.instruction.Location = new System.Drawing.Point(394, 247);
            this.instruction.Name = "instruction";
            this.instruction.Size = new System.Drawing.Size(39, 42);
            this.instruction.TabIndex = 8;
            this.instruction.Text = "1";
            this.instruction.Visible = false;
            // 
            // img_star02_2
            // 
            this.img_star02_2.Image = global::Synergy_Solutions_App.Properties.Resources.star02;
            this.img_star02_2.Location = new System.Drawing.Point(788, 176);
            this.img_star02_2.Margin = new System.Windows.Forms.Padding(2);
            this.img_star02_2.Name = "img_star02_2";
            this.img_star02_2.Size = new System.Drawing.Size(40, 39);
            this.img_star02_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_star02_2.TabIndex = 23;
            this.img_star02_2.TabStop = false;
            // 
            // img_star01_2
            // 
            this.img_star01_2.Image = global::Synergy_Solutions_App.Properties.Resources.star01;
            this.img_star01_2.Location = new System.Drawing.Point(668, 176);
            this.img_star01_2.Margin = new System.Windows.Forms.Padding(2);
            this.img_star01_2.Name = "img_star01_2";
            this.img_star01_2.Size = new System.Drawing.Size(39, 39);
            this.img_star01_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_star01_2.TabIndex = 22;
            this.img_star01_2.TabStop = false;
            // 
            // img_planet02_2
            // 
            this.img_planet02_2.Image = global::Synergy_Solutions_App.Properties.Resources.planet02;
            this.img_planet02_2.Location = new System.Drawing.Point(848, 159);
            this.img_planet02_2.Margin = new System.Windows.Forms.Padding(2);
            this.img_planet02_2.Name = "img_planet02_2";
            this.img_planet02_2.Size = new System.Drawing.Size(111, 107);
            this.img_planet02_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_planet02_2.TabIndex = 21;
            this.img_planet02_2.TabStop = false;
            // 
            // img_planet02_3
            // 
            this.img_planet02_3.Image = global::Synergy_Solutions_App.Properties.Resources.planet02;
            this.img_planet02_3.Location = new System.Drawing.Point(848, 285);
            this.img_planet02_3.Margin = new System.Windows.Forms.Padding(2);
            this.img_planet02_3.Name = "img_planet02_3";
            this.img_planet02_3.Size = new System.Drawing.Size(47, 47);
            this.img_planet02_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_planet02_3.TabIndex = 20;
            this.img_planet02_3.TabStop = false;
            // 
            // img_star01_1
            // 
            this.img_star01_1.Image = global::Synergy_Solutions_App.Properties.Resources.star01;
            this.img_star01_1.Location = new System.Drawing.Point(624, 176);
            this.img_star01_1.Margin = new System.Windows.Forms.Padding(2);
            this.img_star01_1.Name = "img_star01_1";
            this.img_star01_1.Size = new System.Drawing.Size(39, 39);
            this.img_star01_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_star01_1.TabIndex = 19;
            this.img_star01_1.TabStop = false;
            // 
            // img_planet03_2
            // 
            this.img_planet03_2.Image = global::Synergy_Solutions_App.Properties.Resources.planet03;
            this.img_planet03_2.Location = new System.Drawing.Point(557, 176);
            this.img_planet03_2.Margin = new System.Windows.Forms.Padding(2);
            this.img_planet03_2.Name = "img_planet03_2";
            this.img_planet03_2.Size = new System.Drawing.Size(54, 53);
            this.img_planet03_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_planet03_2.TabIndex = 18;
            this.img_planet03_2.TabStop = false;
            // 
            // img_star02_1
            // 
            this.img_star02_1.Image = global::Synergy_Solutions_App.Properties.Resources.star02;
            this.img_star02_1.Location = new System.Drawing.Point(743, 176);
            this.img_star02_1.Margin = new System.Windows.Forms.Padding(2);
            this.img_star02_1.Name = "img_star02_1";
            this.img_star02_1.Size = new System.Drawing.Size(40, 39);
            this.img_star02_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_star02_1.TabIndex = 17;
            this.img_star02_1.TabStop = false;
            this.img_star02_1.Click += new System.EventHandler(this.pictureBox2_Click_2);
            // 
            // img_planet04F_1
            // 
            this.img_planet04F_1.BackColor = System.Drawing.Color.Transparent;
            this.img_planet04F_1.Image = global::Synergy_Solutions_App.Properties.Resources.planet04F;
            this.img_planet04F_1.Location = new System.Drawing.Point(612, 234);
            this.img_planet04F_1.Margin = new System.Windows.Forms.Padding(2);
            this.img_planet04F_1.Name = "img_planet04F_1";
            this.img_planet04F_1.Size = new System.Drawing.Size(201, 180);
            this.img_planet04F_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_planet04F_1.TabIndex = 16;
            this.img_planet04F_1.TabStop = false;
            this.img_planet04F_1.Click += new System.EventHandler(this.img_planet04F_1_Click);
            // 
            // img_planet01_2
            // 
            this.img_planet01_2.Image = ((System.Drawing.Image)(resources.GetObject("img_planet01_2.Image")));
            this.img_planet01_2.Location = new System.Drawing.Point(557, 32);
            this.img_planet01_2.Margin = new System.Windows.Forms.Padding(2);
            this.img_planet01_2.Name = "img_planet01_2";
            this.img_planet01_2.Size = new System.Drawing.Size(46, 48);
            this.img_planet01_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_planet01_2.TabIndex = 15;
            this.img_planet01_2.TabStop = false;
            this.img_planet01_2.Click += new System.EventHandler(this.planet01_2_Click);
            // 
            // img_planet04_1
            // 
            this.img_planet04_1.BackColor = System.Drawing.Color.Transparent;
            this.img_planet04_1.Image = global::Synergy_Solutions_App.Properties.Resources.planet04;
            this.img_planet04_1.Location = new System.Drawing.Point(597, 41);
            this.img_planet04_1.Margin = new System.Windows.Forms.Padding(2);
            this.img_planet04_1.Name = "img_planet04_1";
            this.img_planet04_1.Size = new System.Drawing.Size(92, 78);
            this.img_planet04_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_planet04_1.TabIndex = 14;
            this.img_planet04_1.TabStop = false;
            this.img_planet04_1.Click += new System.EventHandler(this.planet04_1_Click);
            // 
            // img_planet03_1
            // 
            this.img_planet03_1.Image = global::Synergy_Solutions_App.Properties.Resources.planet03;
            this.img_planet03_1.Location = new System.Drawing.Point(456, 149);
            this.img_planet03_1.Margin = new System.Windows.Forms.Padding(2);
            this.img_planet03_1.Name = "img_planet03_1";
            this.img_planet03_1.Size = new System.Drawing.Size(84, 80);
            this.img_planet03_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_planet03_1.TabIndex = 13;
            this.img_planet03_1.TabStop = false;
            // 
            // img_planet02_1
            // 
            this.img_planet02_1.Image = global::Synergy_Solutions_App.Properties.Resources.planet02;
            this.img_planet02_1.Location = new System.Drawing.Point(848, 45);
            this.img_planet02_1.Margin = new System.Windows.Forms.Padding(2);
            this.img_planet02_1.Name = "img_planet02_1";
            this.img_planet02_1.Size = new System.Drawing.Size(79, 77);
            this.img_planet02_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_planet02_1.TabIndex = 12;
            this.img_planet02_1.TabStop = false;
            this.img_planet02_1.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // img_planet01_1
            // 
            this.img_planet01_1.Image = ((System.Drawing.Image)(resources.GetObject("img_planet01_1.Image")));
            this.img_planet01_1.Location = new System.Drawing.Point(433, 12);
            this.img_planet01_1.Margin = new System.Windows.Forms.Padding(2);
            this.img_planet01_1.Name = "img_planet01_1";
            this.img_planet01_1.Size = new System.Drawing.Size(107, 110);
            this.img_planet01_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_planet01_1.TabIndex = 11;
            this.img_planet01_1.TabStop = false;
            this.img_planet01_1.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // img_UFO
            // 
            this.img_UFO.Image = ((System.Drawing.Image)(resources.GetObject("img_UFO.Image")));
            this.img_UFO.Location = new System.Drawing.Point(78, 121);
            this.img_UFO.Margin = new System.Windows.Forms.Padding(2);
            this.img_UFO.Name = "img_UFO";
            this.img_UFO.Size = new System.Drawing.Size(364, 271);
            this.img_UFO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_UFO.TabIndex = 10;
            this.img_UFO.TabStop = false;
            this.img_UFO.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lanuage
            // 
            this.lanuage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lanuage.Image = global::Synergy_Solutions_App.Properties.Resources.button_finger;
            this.lanuage.Location = new System.Drawing.Point(403, -128);
            this.lanuage.Name = "lanuage";
            this.lanuage.Size = new System.Drawing.Size(124, 82);
            this.lanuage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lanuage.TabIndex = 9;
            this.lanuage.TabStop = false;
            this.lanuage.Click += new System.EventHandler(this.lanuage_Click);
            // 
            // img_action
            // 
            this.img_action.Location = new System.Drawing.Point(483, 149);
            this.img_action.Name = "img_action";
            this.img_action.Size = new System.Drawing.Size(455, 325);
            this.img_action.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_action.TabIndex = 4;
            this.img_action.TabStop = false;
            this.img_action.Visible = false;
            // 
            // img_arrow
            // 
            this.img_arrow.BackColor = System.Drawing.Color.Transparent;
            this.img_arrow.Image = ((System.Drawing.Image)(resources.GetObject("img_arrow.Image")));
            this.img_arrow.Location = new System.Drawing.Point(12, 84);
            this.img_arrow.Name = "img_arrow";
            this.img_arrow.Size = new System.Drawing.Size(47, 63);
            this.img_arrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_arrow.TabIndex = 2;
            this.img_arrow.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(12, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 67);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // gameSerial
            // 
            this.gameSerial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.gameSerial_DataReceived);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Dealer Strikes", 150F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Red;
            this.Title.Location = new System.Drawing.Point(433, 344);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(693, 209);
            this.Title.TabIndex = 24;
            this.Title.Text = "BLAST OFF";
            this.Title.Click += new System.EventHandler(this.label2_Click);
            this.Title.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Title_PreviewKeyDown);
            // 
            // loadingScreen
            // 
            this.loadingScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loadingScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadingScreen.Image = ((System.Drawing.Image)(resources.GetObject("loadingScreen.Image")));
            this.loadingScreen.Location = new System.Drawing.Point(0, 0);
            this.loadingScreen.Name = "loadingScreen";
            this.loadingScreen.Size = new System.Drawing.Size(1003, 492);
            this.loadingScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.loadingScreen.TabIndex = 25;
            this.loadingScreen.TabStop = false;
            this.loadingScreen.Visible = false;
            this.loadingScreen.Click += new System.EventHandler(this.pictureBox2_Click_3);
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1003, 492);
            this.Controls.Add(this.loadingScreen);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.instruction);
            this.Controls.Add(this.action);
            this.Controls.Add(this.img_star02_2);
            this.Controls.Add(this.img_star01_2);
            this.Controls.Add(this.img_planet02_2);
            this.Controls.Add(this.img_planet02_3);
            this.Controls.Add(this.img_star01_1);
            this.Controls.Add(this.img_planet03_2);
            this.Controls.Add(this.img_star02_1);
            this.Controls.Add(this.img_planet04F_1);
            this.Controls.Add(this.img_planet01_2);
            this.Controls.Add(this.img_planet04_1);
            this.Controls.Add(this.img_planet03_1);
            this.Controls.Add(this.img_planet02_1);
            this.Controls.Add(this.img_planet01_1);
            this.Controls.Add(this.startGame);
            this.Controls.Add(this.lanuage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.img_action);
            this.Controls.Add(this.img_arrow);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.img_UFO);
            this.ForeColor = System.Drawing.Color.Black;
            this.KeyPreview = true;
            this.Name = "StartScreen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.StartScreen_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StartScreen_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.img_star02_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_star01_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_planet02_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_planet02_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_star01_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_planet03_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_star02_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_planet04F_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_planet01_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_planet04_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_planet03_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_planet02_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_planet01_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_UFO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lanuage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_action)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_arrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startGame;
        private System.Windows.Forms.PictureBox img_arrow;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label action;
        private System.Windows.Forms.PictureBox img_action;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label instruction;
        private System.Windows.Forms.PictureBox lanuage;
        private System.Windows.Forms.PictureBox img_UFO;
        private System.Windows.Forms.PictureBox img_planet01_1;
        public System.Windows.Forms.PictureBox img_planet02_1;
        private System.Windows.Forms.PictureBox img_planet03_1;
        private System.Windows.Forms.PictureBox img_planet04_1;
        private System.Windows.Forms.PictureBox img_planet01_2;
        private System.Windows.Forms.PictureBox img_planet04F_1;
        private System.Windows.Forms.PictureBox img_star02_1;
        private System.Windows.Forms.PictureBox img_planet03_2;
        private System.Windows.Forms.PictureBox img_star01_1;
        public System.Windows.Forms.PictureBox img_planet02_3;
        public System.Windows.Forms.PictureBox img_planet02_2;
        private System.Windows.Forms.PictureBox img_star01_2;
        private System.Windows.Forms.PictureBox img_star02_2;
        private System.IO.Ports.SerialPort gameSerial;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox loadingScreen;
    }
}