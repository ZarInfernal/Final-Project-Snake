namespace Snake
{
    partial class HelpForm
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
            this.customTitleBarControl1 = new CustomTitleBarControl();
            this.pnlButtonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customTitleBarControl1
            // 
            this.customTitleBarControl1.Location = new System.Drawing.Point(0, 2);
            this.customTitleBarControl1.Name = "customTitleBarControl1";
            this.customTitleBarControl1.Size = new System.Drawing.Size(1308, 40);
            this.customTitleBarControl1.TabIndex = 0;
            // 
            // pnlButtonClose
            // 
            this.pnlButtonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pnlButtonClose.BackgroundImage = global::Snake.Properties.Resources.close;
            this.pnlButtonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlButtonClose.FlatAppearance.BorderSize = 0;
            this.pnlButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnlButtonClose.Location = new System.Drawing.Point(749, 5);
            this.pnlButtonClose.Name = "pnlButtonClose";
            this.pnlButtonClose.Size = new System.Drawing.Size(39, 37);
            this.pnlButtonClose.TabIndex = 19;
            this.pnlButtonClose.UseVisualStyleBackColor = false;
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pnlButtonClose);
            this.Controls.Add(this.customTitleBarControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HelpForm";
            this.Text = "HelpForm";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomTitleBarControl customTitleBarControl1;
        private System.Windows.Forms.Button pnlButtonClose;
    }
}