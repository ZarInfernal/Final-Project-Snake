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
            this.BarControls = new System.Windows.Forms.Panel();
            this.pnlButtonClose = new System.Windows.Forms.Button();
            this.pnlButtonMin = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.customTitleBarControl1 = new CustomTitleBarControl();
            this.BarControls.SuspendLayout();
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
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
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
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
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
            // BarControls
            // 
            this.BarControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BarControls.Controls.Add(this.pnlButtonClose);
            this.BarControls.Controls.Add(this.pnlButtonMin);
            this.BarControls.Controls.Add(this.customTitleBarControl1);
            this.BarControls.Location = new System.Drawing.Point(3, 2);
            this.BarControls.Name = "BarControls";
            this.BarControls.Size = new System.Drawing.Size(1062, 37);
            this.BarControls.TabIndex = 13;
            // 
            // pnlButtonClose
            // 
            this.pnlButtonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pnlButtonClose.BackgroundImage = global::Snake.Properties.Resources.close;
            this.pnlButtonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlButtonClose.FlatAppearance.BorderSize = 0;
            this.pnlButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnlButtonClose.Location = new System.Drawing.Point(1012, 0);
            this.pnlButtonClose.Name = "pnlButtonClose";
            this.pnlButtonClose.Size = new System.Drawing.Size(39, 37);
            this.pnlButtonClose.TabIndex = 17;
            this.pnlButtonClose.UseVisualStyleBackColor = false;
            this.pnlButtonClose.Click += new System.EventHandler(this.pnlButtonClose_Click);
            // 
            // pnlButtonMin
            // 
            this.pnlButtonMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pnlButtonMin.BackgroundImage = global::Snake.Properties.Resources.minimize;
            this.pnlButtonMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlButtonMin.FlatAppearance.BorderSize = 0;
            this.pnlButtonMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnlButtonMin.Location = new System.Drawing.Point(972, 0);
            this.pnlButtonMin.Name = "pnlButtonMin";
            this.pnlButtonMin.Size = new System.Drawing.Size(39, 37);
            this.pnlButtonMin.TabIndex = 16;
            this.pnlButtonMin.UseVisualStyleBackColor = false;
            this.pnlButtonMin.Click += new System.EventHandler(this.pnlButtonMin_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAbout.BackgroundImage = global::Snake.Properties.Resources.question;
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.ForeColor = System.Drawing.Color.Transparent;
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
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Location = new System.Drawing.Point(969, 500);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(52, 50);
            this.btnSettings.TabIndex = 11;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // customTitleBarControl1
            // 
            this.customTitleBarControl1.Location = new System.Drawing.Point(0, -3);
            this.customTitleBarControl1.Name = "customTitleBarControl1";
            this.customTitleBarControl1.Size = new System.Drawing.Size(1116, 40);
            this.customTitleBarControl1.TabIndex = 14;
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1066, 593);
            this.ControlBox = false;
            this.Controls.Add(this.BarControls);
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
            this.BarControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Panel BarControls;
        private CustomTitleBarControl customTitleBarControl1;
        private System.Windows.Forms.Button pnlButtonClose;
        private System.Windows.Forms.Button pnlButtonMin;
    }
}