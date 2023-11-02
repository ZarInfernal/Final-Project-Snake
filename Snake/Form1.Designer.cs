namespace Snake
{
    partial class SettingsForm
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
            this.pnlButtonClose = new System.Windows.Forms.Button();
            this.pnlButtonMin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblSettings = new System.Windows.Forms.Label();
            this.lblMusic = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.gameSoundSwtich = new Snake.Custom_Controlers.ToggleButtons();
            this.clickSoundSwitch = new Snake.Custom_Controlers.ToggleButtons();
            this.musicSwitch = new Snake.Custom_Controlers.ToggleButtons();
            this.toggleButtons1 = new Snake.Custom_Controlers.ToggleButtons();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButtonClose
            // 
            this.pnlButtonClose.BackColor = System.Drawing.Color.Transparent;
            this.pnlButtonClose.BackgroundImage = global::Snake.Properties.Resources.close;
            this.pnlButtonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlButtonClose.Location = new System.Drawing.Point(432, 1);
            this.pnlButtonClose.Name = "pnlButtonClose";
            this.pnlButtonClose.Size = new System.Drawing.Size(39, 37);
            this.pnlButtonClose.TabIndex = 15;
            this.pnlButtonClose.UseVisualStyleBackColor = false;
            this.pnlButtonClose.Click += new System.EventHandler(this.pnlButtonClose_Click);
            // 
            // pnlButtonMin
            // 
            this.pnlButtonMin.BackColor = System.Drawing.Color.Transparent;
            this.pnlButtonMin.BackgroundImage = global::Snake.Properties.Resources.minimize;
            this.pnlButtonMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlButtonMin.Location = new System.Drawing.Point(387, 1);
            this.pnlButtonMin.Name = "pnlButtonMin";
            this.pnlButtonMin.Size = new System.Drawing.Size(39, 37);
            this.pnlButtonMin.TabIndex = 14;
            this.pnlButtonMin.UseVisualStyleBackColor = false;
            this.pnlButtonMin.Click += new System.EventHandler(this.pnlButtonMin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pnlButtonClose);
            this.panel1.Controls.Add(this.pnlButtonMin);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 41);
            this.panel1.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Snake.Properties.Resources.close;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(1006, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 37);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::Snake.Properties.Resources.minimize;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(966, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 37);
            this.button2.TabIndex = 14;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.Font = new System.Drawing.Font("Segoe UI Variable Display", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblSettings.Location = new System.Drawing.Point(96, 52);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(274, 69);
            this.lblSettings.TabIndex = 17;
            this.lblSettings.Text = "SETTINGS";
            this.lblSettings.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMusic
            // 
            this.lblMusic.AutoSize = true;
            this.lblMusic.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblMusic.Location = new System.Drawing.Point(190, 138);
            this.lblMusic.Name = "lblMusic";
            this.lblMusic.Size = new System.Drawing.Size(65, 27);
            this.lblMusic.TabIndex = 22;
            this.lblMusic.Text = "Music";
            this.lblMusic.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(190, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 27);
            this.label1.TabIndex = 23;
            this.label1.Text = "Click Sound";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(190, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 27);
            this.label2.TabIndex = 24;
            this.label2.Text = "Game Sound";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Location = new System.Drawing.Point(45, 245);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(406, 3);
            this.panel3.TabIndex = 27;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Location = new System.Drawing.Point(79, 273);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(347, 3);
            this.panel4.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(100, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 43);
            this.label3.TabIndex = 29;
            this.label3.Text = "GROUP MEMBERS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(176, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 27);
            this.label4.TabIndex = 30;
            this.label4.Text = "DICK FABABI";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(154, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 27);
            this.label5.TabIndex = 31;
            this.label5.Text = "JESS WILKINSON";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(160, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 27);
            this.label6.TabIndex = 32;
            this.label6.Text = "JOSE MURRIETA";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label7.Location = new System.Drawing.Point(151, 427);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 27);
            this.label7.TabIndex = 33;
            this.label7.Text = "MICHAEL HIEBERT";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label8.Location = new System.Drawing.Point(130, 454);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 27);
            this.label8.TabIndex = 34;
            this.label8.Text = "LEONARDO MONCADA";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnPlay.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPlay.Location = new System.Drawing.Point(135, 511);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(201, 54);
            this.btnPlay.TabIndex = 35;
            this.btnPlay.Text = "GO BACK";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // gameSoundSwtich
            // 
            this.gameSoundSwtich.AutoSize = true;
            this.gameSoundSwtich.Location = new System.Drawing.Point(126, 203);
            this.gameSoundSwtich.MinimumSize = new System.Drawing.Size(45, 22);
            this.gameSoundSwtich.Name = "gameSoundSwtich";
            this.gameSoundSwtich.OffBackColor = System.Drawing.Color.Gray;
            this.gameSoundSwtich.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.gameSoundSwtich.OnBackColor = System.Drawing.Color.Teal;
            this.gameSoundSwtich.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.gameSoundSwtich.Size = new System.Drawing.Size(45, 22);
            this.gameSoundSwtich.SolidStyle = true;
            this.gameSoundSwtich.TabIndex = 26;
            this.gameSoundSwtich.UseVisualStyleBackColor = true;
            this.gameSoundSwtich.CheckedChanged += new System.EventHandler(this.gameSoundSwitch_Click);
            // 
            // clickSoundSwitch
            // 
            this.clickSoundSwitch.AutoSize = true;
            this.clickSoundSwitch.Location = new System.Drawing.Point(126, 172);
            this.clickSoundSwitch.MinimumSize = new System.Drawing.Size(45, 22);
            this.clickSoundSwitch.Name = "clickSoundSwitch";
            this.clickSoundSwitch.OffBackColor = System.Drawing.Color.Gray;
            this.clickSoundSwitch.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.clickSoundSwitch.OnBackColor = System.Drawing.Color.Teal;
            this.clickSoundSwitch.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.clickSoundSwitch.Size = new System.Drawing.Size(45, 22);
            this.clickSoundSwitch.SolidStyle = true;
            this.clickSoundSwitch.TabIndex = 25;
            this.clickSoundSwitch.UseVisualStyleBackColor = true;
            this.clickSoundSwitch.CheckedChanged += new System.EventHandler(this.clickSoundSwtich_CheckedChanged);
            // 
            // musicSwitch
            // 
            this.musicSwitch.AutoSize = true;
            this.musicSwitch.Location = new System.Drawing.Point(126, 143);
            this.musicSwitch.MinimumSize = new System.Drawing.Size(45, 22);
            this.musicSwitch.Name = "musicSwitch";
            this.musicSwitch.OffBackColor = System.Drawing.Color.Gray;
            this.musicSwitch.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.musicSwitch.OnBackColor = System.Drawing.Color.Teal;
            this.musicSwitch.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.musicSwitch.Size = new System.Drawing.Size(45, 22);
            this.musicSwitch.SolidStyle = true;
            this.musicSwitch.TabIndex = 19;
            this.musicSwitch.UseVisualStyleBackColor = true;
            this.musicSwitch.CheckedChanged += new System.EventHandler(this.musicSwitch_CheckedChanged);
            // 
            // toggleButtons1
            // 
            this.toggleButtons1.AutoSize = true;
            this.toggleButtons1.Location = new System.Drawing.Point(-22, -22);
            this.toggleButtons1.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleButtons1.Name = "toggleButtons1";
            this.toggleButtons1.OffBackColor = System.Drawing.Color.Gray;
            this.toggleButtons1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleButtons1.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.toggleButtons1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleButtons1.Size = new System.Drawing.Size(45, 22);
            this.toggleButtons1.SolidStyle = true;
            this.toggleButtons1.TabIndex = 18;
            this.toggleButtons1.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(476, 608);
            this.ControlBox = false;
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.gameSoundSwtich);
            this.Controls.Add(this.clickSoundSwitch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMusic);
            this.Controls.Add(this.musicSwitch);
            this.Controls.Add(this.toggleButtons1);
            this.Controls.Add(this.lblSettings);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pnlButtonClose;
        private System.Windows.Forms.Button pnlButtonMin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblSettings;
        private Custom_Controlers.ToggleButtons toggleButtons1;
        private Custom_Controlers.ToggleButtons musicSwitch;
        private System.Windows.Forms.Label lblMusic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Custom_Controlers.ToggleButtons clickSoundSwitch;
        private Custom_Controlers.ToggleButtons gameSoundSwtich;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPlay;
    }
}