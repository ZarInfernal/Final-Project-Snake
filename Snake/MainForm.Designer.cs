﻿namespace Snake
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
            this.customTitleBar = new System.Windows.Forms.Panel();
            this.pnlButtonClose = new System.Windows.Forms.Button();
            this.pnlButtonMin = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblPlayerHighScore = new System.Windows.Forms.Label();
            this.heart3 = new System.Windows.Forms.PictureBox();
            this.heart2 = new System.Windows.Forms.PictureBox();
            this.heart1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backBtn = new System.Windows.Forms.PictureBox();
            this.customTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // customTitleBar
            // 
            this.customTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.customTitleBar.Controls.Add(this.pnlButtonClose);
            this.customTitleBar.Controls.Add(this.pnlButtonMin);
            this.customTitleBar.Location = new System.Drawing.Point(1, 0);
            this.customTitleBar.Name = "customTitleBar";
            this.customTitleBar.Size = new System.Drawing.Size(1311, 37);
            this.customTitleBar.TabIndex = 14;
            this.customTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.customTitleBar_Paint);
            // 
            // pnlButtonClose
            // 
            this.pnlButtonClose.BackColor = System.Drawing.Color.Transparent;
            this.pnlButtonClose.BackgroundImage = global::Snake.Properties.Resources.close;
            this.pnlButtonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlButtonClose.Location = new System.Drawing.Point(1257, 1);
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
            this.pnlButtonMin.Location = new System.Drawing.Point(1217, 1);
            this.pnlButtonMin.Name = "pnlButtonMin";
            this.pnlButtonMin.Size = new System.Drawing.Size(39, 37);
            this.pnlButtonMin.TabIndex = 14;
            this.pnlButtonMin.UseVisualStyleBackColor = false;
            this.pnlButtonMin.Click += new System.EventHandler(this.pnlButtonMin_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Variable Display", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblTitle.Location = new System.Drawing.Point(204, 101);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(360, 69);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "SNAKE GAME";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Font = new System.Drawing.Font("Segoe UI Variable Display", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblGroup.Location = new System.Drawing.Point(1009, 101);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(261, 69);
            this.lblGroup.TabIndex = 17;
            this.lblGroup.Text = "Group 8   ";
            this.lblGroup.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.Teal;
            this.btnStartGame.Font = new System.Drawing.Font("Segoe UI Variable Display", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnStartGame.Location = new System.Drawing.Point(989, 397);
            this.btnStartGame.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(247, 74);
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
            this.lblHighScore.Location = new System.Drawing.Point(1002, 492);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(245, 43);
            this.lblHighScore.TabIndex = 30;
            this.lblHighScore.Text = "HIGH SCORE: 0";
            this.lblHighScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Teal;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1033, 559);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 28);
            this.comboBox1.TabIndex = 31;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI Variable Display", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblScore.Location = new System.Drawing.Point(1034, 621);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(156, 43);
            this.lblScore.TabIndex = 32;
            this.lblScore.Text = "SCORE: 0";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPlayerHighScore
            // 
            this.lblPlayerHighScore.AutoSize = true;
            this.lblPlayerHighScore.Font = new System.Drawing.Font("Segoe UI Variable Display", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerHighScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblPlayerHighScore.Location = new System.Drawing.Point(930, 683);
            this.lblPlayerHighScore.Name = "lblPlayerHighScore";
            this.lblPlayerHighScore.Size = new System.Drawing.Size(367, 43);
            this.lblPlayerHighScore.TabIndex = 33;
            this.lblPlayerHighScore.Text = "PLAYER HIGH SCORE: 0";
            this.lblPlayerHighScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // heart3
            // 
            this.heart3.BackColor = System.Drawing.Color.Transparent;
            this.heart3.Image = global::Snake.Properties.Resources.heart;
            this.heart3.Location = new System.Drawing.Point(784, 236);
            this.heart3.Name = "heart3";
            this.heart3.Size = new System.Drawing.Size(58, 58);
            this.heart3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart3.TabIndex = 36;
            this.heart3.TabStop = false;
            // 
            // heart2
            // 
            this.heart2.BackColor = System.Drawing.Color.Transparent;
            this.heart2.Image = global::Snake.Properties.Resources.heart;
            this.heart2.Location = new System.Drawing.Point(720, 236);
            this.heart2.Name = "heart2";
            this.heart2.Size = new System.Drawing.Size(58, 58);
            this.heart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart2.TabIndex = 35;
            this.heart2.TabStop = false;
            // 
            // heart1
            // 
            this.heart1.BackColor = System.Drawing.Color.Transparent;
            this.heart1.Image = global::Snake.Properties.Resources.heart;
            this.heart1.Location = new System.Drawing.Point(656, 236);
            this.heart1.Name = "heart1";
            this.heart1.Size = new System.Drawing.Size(58, 58);
            this.heart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart1.TabIndex = 34;
            this.heart1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Teal;
            this.pictureBox1.Location = new System.Drawing.Point(16, 224);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(840, 840);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.Image = global::Snake.Properties.Resources.Sprite_0002;
            this.backBtn.Location = new System.Drawing.Point(30, 72);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(66, 66);
            this.backBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backBtn.TabIndex = 38;
            this.backBtn.TabStop = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1309, 1086);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.heart3);
            this.Controls.Add(this.heart2);
            this.Controls.Add(this.heart1);
            this.Controls.Add(this.lblPlayerHighScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.customTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Snake Game";
            this.customTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.heart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pnlButtonClose;
        private System.Windows.Forms.Button pnlButtonMin;
        private System.Windows.Forms.Panel customTitleBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblPlayerHighScore;
        private System.Windows.Forms.PictureBox heart1;
        private System.Windows.Forms.PictureBox heart2;
        private System.Windows.Forms.PictureBox heart3;
        private System.Windows.Forms.PictureBox backBtn;
    }
}
