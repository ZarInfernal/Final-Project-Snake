namespace Snake
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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.comboBoxDiff = new System.Windows.Forms.ComboBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblPlayerHighScore = new System.Windows.Forms.Label();
            this.directionTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlButtonClose = new System.Windows.Forms.Button();
            this.pnlButtonMin = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.PictureBox();
            this.heart3 = new System.Windows.Forms.PictureBox();
            this.heart2 = new System.Windows.Forms.PictureBox();
            this.heart1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customTitleBarControl1 = new CustomTitleBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Variable Display", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblTitle.Location = new System.Drawing.Point(136, 66);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(241, 47);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "SNAKE GAME";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Font = new System.Drawing.Font("Segoe UI Variable Display", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblGroup.Location = new System.Drawing.Point(673, 66);
            this.lblGroup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(176, 47);
            this.lblGroup.TabIndex = 17;
            this.lblGroup.Text = "Group 8   ";
            this.lblGroup.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.Teal;
            this.btnStartGame.Font = new System.Drawing.Font("Segoe UI Variable Display", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnStartGame.Location = new System.Drawing.Point(659, 258);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(165, 48);
            this.btnStartGame.TabIndex = 18;
            this.btnStartGame.Text = "START";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.Font = new System.Drawing.Font("Segoe UI Variable Display", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblHighScore.Location = new System.Drawing.Point(668, 320);
            this.lblHighScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(0, 30);
            this.lblHighScore.TabIndex = 30;
            this.lblHighScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBoxDiff
            // 
            this.comboBoxDiff.BackColor = System.Drawing.Color.LavenderBlush;
            this.comboBoxDiff.Location = new System.Drawing.Point(689, 363);
            this.comboBoxDiff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxDiff.Name = "comboBoxDiff";
            this.comboBoxDiff.Size = new System.Drawing.Size(115, 21);
            this.comboBoxDiff.TabIndex = 31;
            this.comboBoxDiff.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI Variable Display", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblScore.Location = new System.Drawing.Point(689, 404);
            this.lblScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 30);
            this.lblScore.TabIndex = 32;
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPlayerHighScore
            // 
            this.lblPlayerHighScore.AutoSize = true;
            this.lblPlayerHighScore.Font = new System.Drawing.Font("Segoe UI Variable Display", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerHighScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblPlayerHighScore.Location = new System.Drawing.Point(620, 444);
            this.lblPlayerHighScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayerHighScore.Name = "lblPlayerHighScore";
            this.lblPlayerHighScore.Size = new System.Drawing.Size(0, 30);
            this.lblPlayerHighScore.TabIndex = 33;
            this.lblPlayerHighScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // directionTimer
            // 
            this.directionTimer.Tick += new System.EventHandler(this.directionTimer_Tick);
            // 
            // pnlButtonClose
            // 
            this.pnlButtonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pnlButtonClose.BackgroundImage = global::Snake.Properties.Resources.close;
            this.pnlButtonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlButtonClose.FlatAppearance.BorderSize = 0;
            this.pnlButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnlButtonClose.Location = new System.Drawing.Point(831, -1);
            this.pnlButtonClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlButtonClose.Name = "pnlButtonClose";
            this.pnlButtonClose.Size = new System.Drawing.Size(26, 24);
            this.pnlButtonClose.TabIndex = 15;
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
            this.pnlButtonMin.Location = new System.Drawing.Point(805, -1);
            this.pnlButtonMin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlButtonMin.Name = "pnlButtonMin";
            this.pnlButtonMin.Size = new System.Drawing.Size(26, 24);
            this.pnlButtonMin.TabIndex = 14;
            this.pnlButtonMin.UseVisualStyleBackColor = false;
            this.pnlButtonMin.Click += new System.EventHandler(this.pnlButtonMin_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.backBtn.Image = global::Snake.Properties.Resources.Sprite_0002;
            this.backBtn.Location = new System.Drawing.Point(20, 47);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(44, 43);
            this.backBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backBtn.TabIndex = 38;
            this.backBtn.TabStop = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // heart3
            // 
            this.heart3.BackColor = System.Drawing.Color.Transparent;
            this.heart3.Image = global::Snake.Properties.Resources.heart;
            this.heart3.Location = new System.Drawing.Point(521, 107);
            this.heart3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.heart3.Name = "heart3";
            this.heart3.Size = new System.Drawing.Size(39, 38);
            this.heart3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart3.TabIndex = 36;
            this.heart3.TabStop = false;
            // 
            // heart2
            // 
            this.heart2.BackColor = System.Drawing.Color.Transparent;
            this.heart2.Image = global::Snake.Properties.Resources.heart;
            this.heart2.Location = new System.Drawing.Point(479, 107);
            this.heart2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.heart2.Name = "heart2";
            this.heart2.Size = new System.Drawing.Size(39, 38);
            this.heart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart2.TabIndex = 35;
            this.heart2.TabStop = false;
            // 
            // heart1
            // 
            this.heart1.BackColor = System.Drawing.Color.Transparent;
            this.heart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.heart1.Image = global::Snake.Properties.Resources.heart;
            this.heart1.Location = new System.Drawing.Point(438, 107);
            this.heart1.Margin = new System.Windows.Forms.Padding(0);
            this.heart1.Name = "heart1";
            this.heart1.Size = new System.Drawing.Size(39, 38);
            this.heart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart1.TabIndex = 34;
            this.heart1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Teal;
            this.pictureBox1.Location = new System.Drawing.Point(11, 146);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(560, 540);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // customTitleBarControl1
            // 
            this.customTitleBarControl1.Location = new System.Drawing.Point(-1, -3);
            this.customTitleBarControl1.Margin = new System.Windows.Forms.Padding(2);
            this.customTitleBarControl1.Name = "customTitleBarControl1";
            this.customTitleBarControl1.Size = new System.Drawing.Size(873, 26);
            this.customTitleBarControl1.TabIndex = 39;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(873, 706);
            this.Controls.Add(this.pnlButtonClose);
            this.Controls.Add(this.pnlButtonMin);
            this.Controls.Add(this.customTitleBarControl1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.heart3);
            this.Controls.Add(this.heart2);
            this.Controls.Add(this.heart1);
            this.Controls.Add(this.lblPlayerHighScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.comboBoxDiff);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Snake Game";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pnlButtonClose;
        private System.Windows.Forms.Button pnlButtonMin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblPlayerHighScore;
        private System.Windows.Forms.PictureBox heart1;
        private System.Windows.Forms.PictureBox heart2;
        private System.Windows.Forms.PictureBox heart3;
        private System.Windows.Forms.PictureBox backBtn;
        private CustomTitleBarControl customTitleBarControl1;
        private System.Windows.Forms.Timer directionTimer;
        private System.Windows.Forms.ComboBox comboBoxDiff;
    }
}

