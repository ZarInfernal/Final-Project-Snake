namespace Snake
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlButtonClose = new System.Windows.Forms.Button();
            this.pnlButtonMin = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Variable Display", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblTitle.Location = new System.Drawing.Point(368, 83);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(360, 69);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "SNAKE GAME";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Teal;
            this.btnPlay.Font = new System.Drawing.Font("Segoe UI Variable Display", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPlay.Location = new System.Drawing.Point(204, 183);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(341, 298);
            this.btnPlay.TabIndex = 9;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Teal;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Variable Display", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnExit.Location = new System.Drawing.Point(553, 183);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(341, 298);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.pnlButtonClose);
            this.panel1.Controls.Add(this.pnlButtonMin);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 37);
            this.panel1.TabIndex = 13;
            // 
            // pnlButtonClose
            // 
            this.pnlButtonClose.BackColor = System.Drawing.Color.Transparent;
            this.pnlButtonClose.BackgroundImage = global::Snake.Properties.Resources.close;
            this.pnlButtonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlButtonClose.Location = new System.Drawing.Point(1006, 0);
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
            this.pnlButtonMin.Location = new System.Drawing.Point(966, 0);
            this.pnlButtonMin.Name = "pnlButtonMin";
            this.pnlButtonMin.Size = new System.Drawing.Size(39, 37);
            this.pnlButtonMin.TabIndex = 14;
            this.pnlButtonMin.UseVisualStyleBackColor = false;
            this.pnlButtonMin.Click += new System.EventHandler(this.pnlButtonMin_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAbout.BackgroundImage = global::Snake.Properties.Resources.question;
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAbout.Location = new System.Drawing.Point(969, 431);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(52, 50);
            this.btnAbout.TabIndex = 12;
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSettings.BackgroundImage = global::Snake.Properties.Resources.setting;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSettings.Location = new System.Drawing.Point(969, 500);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(52, 50);
            this.btnSettings.TabIndex = 11;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1066, 593);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblTitle);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartScreen";
            this.Text = "StartScreen";
            this.Load += new System.EventHandler(this.StartScreen_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button pnlButtonMin;
        private System.Windows.Forms.Button pnlButtonClose;
    }
}