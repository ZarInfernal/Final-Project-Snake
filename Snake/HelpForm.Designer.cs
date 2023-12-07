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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.customTitleBarControl1 = new CustomTitleBarControl();
            this.button_close = new System.Windows.Forms.Button();
            this.richTextBox_about = new System.Windows.Forms.RichTextBox();
            this.richTextBox_controls = new System.Windows.Forms.RichTextBox();
            this.label_speed = new System.Windows.Forms.Label();
            this.label_health = new System.Windows.Forms.Label();
            this.label_obstacle = new System.Windows.Forms.Label();
            this.label_food = new System.Windows.Forms.Label();
            this.pictureBox_speed = new System.Windows.Forms.PictureBox();
            this.pictureBox_health = new System.Windows.Forms.PictureBox();
            this.pictureBox_obstacle = new System.Windows.Forms.PictureBox();
            this.pictureBox_food = new System.Windows.Forms.PictureBox();
            this.button_about = new System.Windows.Forms.Button();
            this.button_items = new System.Windows.Forms.Button();
            this.label_about = new System.Windows.Forms.Label();
            this.label_controls = new System.Windows.Forms.Label();
            this.button_next = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_health)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_obstacle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_food)).BeginInit();
            this.SuspendLayout();
            // 
            // customTitleBarControl1
            // 
            this.customTitleBarControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.customTitleBarControl1.Location = new System.Drawing.Point(0, 0);
            this.customTitleBarControl1.Margin = new System.Windows.Forms.Padding(4);
            this.customTitleBarControl1.Name = "customTitleBarControl1";
            this.customTitleBarControl1.Size = new System.Drawing.Size(1175, 53);
            this.customTitleBarControl1.TabIndex = 0;
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_close.BackgroundImage = global::Snake.Properties.Resources.close;
            this.button_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Location = new System.Drawing.Point(1106, 2);
            this.button_close.Margin = new System.Windows.Forms.Padding(4);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(52, 46);
            this.button_close.TabIndex = 19;
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // richTextBox_about
            // 
            this.richTextBox_about.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.richTextBox_about.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_about.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.85F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_about.ForeColor = System.Drawing.Color.White;
            this.richTextBox_about.Location = new System.Drawing.Point(36, 53);
            this.richTextBox_about.Name = "richTextBox_about";
            this.richTextBox_about.Size = new System.Drawing.Size(535, 509);
            this.richTextBox_about.TabIndex = 20;
            this.richTextBox_about.Text = resources.GetString("richTextBox_about.Text");
            // 
            // richTextBox_controls
            // 
            this.richTextBox_controls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.richTextBox_controls.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_controls.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.85F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_controls.ForeColor = System.Drawing.Color.White;
            this.richTextBox_controls.Location = new System.Drawing.Point(574, 53);
            this.richTextBox_controls.Name = "richTextBox_controls";
            this.richTextBox_controls.Size = new System.Drawing.Size(596, 488);
            this.richTextBox_controls.TabIndex = 21;
            this.richTextBox_controls.Text = resources.GetString("richTextBox_controls.Text");
            // 
            // label_speed
            // 
            this.label_speed.AutoSize = true;
            this.label_speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_speed.ForeColor = System.Drawing.Color.White;
            this.label_speed.Location = new System.Drawing.Point(711, 117);
            this.label_speed.Name = "label_speed";
            this.label_speed.Size = new System.Drawing.Size(385, 330);
            this.label_speed.TabIndex = 29;
            this.label_speed.Text = resources.GetString("label_speed.Text");
            // 
            // label_health
            // 
            this.label_health.AutoSize = true;
            this.label_health.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_health.ForeColor = System.Drawing.Color.White;
            this.label_health.Location = new System.Drawing.Point(145, 117);
            this.label_health.Name = "label_health";
            this.label_health.Size = new System.Drawing.Size(374, 363);
            this.label_health.TabIndex = 28;
            this.label_health.Text = resources.GetString("label_health.Text");
            // 
            // label_obstacle
            // 
            this.label_obstacle.AutoSize = true;
            this.label_obstacle.BackColor = System.Drawing.Color.Transparent;
            this.label_obstacle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_obstacle.ForeColor = System.Drawing.Color.White;
            this.label_obstacle.Location = new System.Drawing.Point(711, 117);
            this.label_obstacle.Name = "label_obstacle";
            this.label_obstacle.Size = new System.Drawing.Size(410, 363);
            this.label_obstacle.TabIndex = 27;
            this.label_obstacle.Text = resources.GetString("label_obstacle.Text");
            // 
            // label_food
            // 
            this.label_food.AutoSize = true;
            this.label_food.BackColor = System.Drawing.Color.Transparent;
            this.label_food.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_food.ForeColor = System.Drawing.Color.White;
            this.label_food.Location = new System.Drawing.Point(147, 117);
            this.label_food.Name = "label_food";
            this.label_food.Size = new System.Drawing.Size(394, 330);
            this.label_food.TabIndex = 26;
            this.label_food.Text = resources.GetString("label_food.Text");
            // 
            // pictureBox_speed
            // 
            this.pictureBox_speed.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_speed.BackgroundImage = global::Snake.Properties.Resources.speed_powerup;
            this.pictureBox_speed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_speed.Location = new System.Drawing.Point(583, 201);
            this.pictureBox_speed.Name = "pictureBox_speed";
            this.pictureBox_speed.Size = new System.Drawing.Size(109, 118);
            this.pictureBox_speed.TabIndex = 25;
            this.pictureBox_speed.TabStop = false;
            // 
            // pictureBox_health
            // 
            this.pictureBox_health.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_health.BackgroundImage = global::Snake.Properties.Resources.health_powerup;
            this.pictureBox_health.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_health.Location = new System.Drawing.Point(30, 201);
            this.pictureBox_health.Name = "pictureBox_health";
            this.pictureBox_health.Size = new System.Drawing.Size(109, 118);
            this.pictureBox_health.TabIndex = 24;
            this.pictureBox_health.TabStop = false;
            // 
            // pictureBox_obstacle
            // 
            this.pictureBox_obstacle.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_obstacle.BackgroundImage = global::Snake.Properties.Resources.crate;
            this.pictureBox_obstacle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_obstacle.Location = new System.Drawing.Point(584, 189);
            this.pictureBox_obstacle.Name = "pictureBox_obstacle";
            this.pictureBox_obstacle.Size = new System.Drawing.Size(109, 118);
            this.pictureBox_obstacle.TabIndex = 23;
            this.pictureBox_obstacle.TabStop = false;
            // 
            // pictureBox_food
            // 
            this.pictureBox_food.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_food.BackgroundImage = global::Snake.Properties.Resources.snakefood;
            this.pictureBox_food.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_food.Location = new System.Drawing.Point(30, 189);
            this.pictureBox_food.Name = "pictureBox_food";
            this.pictureBox_food.Size = new System.Drawing.Size(109, 118);
            this.pictureBox_food.TabIndex = 22;
            this.pictureBox_food.TabStop = false;
            // 
            // button_about
            // 
            this.button_about.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_about.FlatAppearance.BorderSize = 0;
            this.button_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_about.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold);
            this.button_about.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button_about.Location = new System.Drawing.Point(-36, -9);
            this.button_about.Margin = new System.Windows.Forms.Padding(0);
            this.button_about.Name = "button_about";
            this.button_about.Size = new System.Drawing.Size(184, 62);
            this.button_about.TabIndex = 30;
            this.button_about.Text = "ABOUT";
            this.button_about.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button_about.UseVisualStyleBackColor = false;
            this.button_about.Click += new System.EventHandler(this.button_about_Click);
            // 
            // button_items
            // 
            this.button_items.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_items.FlatAppearance.BorderSize = 0;
            this.button_items.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_items.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold);
            this.button_items.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button_items.Location = new System.Drawing.Point(131, -9);
            this.button_items.Margin = new System.Windows.Forms.Padding(0);
            this.button_items.Name = "button_items";
            this.button_items.Size = new System.Drawing.Size(184, 62);
            this.button_items.TabIndex = 32;
            this.button_items.Text = "ITEMS";
            this.button_items.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_items.UseVisualStyleBackColor = false;
            this.button_items.Click += new System.EventHandler(this.button_items_Click);
            // 
            // label_about
            // 
            this.label_about.AutoSize = true;
            this.label_about.Font = new System.Drawing.Font("Segoe UI Variable Display", 16.125F, System.Drawing.FontStyle.Bold);
            this.label_about.ForeColor = System.Drawing.Color.White;
            this.label_about.Location = new System.Drawing.Point(28, 117);
            this.label_about.Name = "label_about";
            this.label_about.Size = new System.Drawing.Size(152, 57);
            this.label_about.TabIndex = 33;
            this.label_about.Text = "About";
            // 
            // label_controls
            // 
            this.label_controls.AutoSize = true;
            this.label_controls.Font = new System.Drawing.Font("Segoe UI Variable Display", 16.125F, System.Drawing.FontStyle.Bold);
            this.label_controls.ForeColor = System.Drawing.Color.White;
            this.label_controls.Location = new System.Drawing.Point(565, 117);
            this.label_controls.Name = "label_controls";
            this.label_controls.Size = new System.Drawing.Size(202, 57);
            this.label_controls.TabIndex = 34;
            this.label_controls.Text = "Controls";
            // 
            // button_next
            // 
            this.button_next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button_next.FlatAppearance.BorderSize = 0;
            this.button_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_next.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_next.Location = new System.Drawing.Point(598, 487);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(75, 54);
            this.button_next.TabIndex = 35;
            this.button_next.Text = ">";
            this.button_next.UseVisualStyleBackColor = false;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button_back.FlatAppearance.BorderSize = 0;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_back.Location = new System.Drawing.Point(517, 487);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 54);
            this.button_back.TabIndex = 36;
            this.button_back.Text = "<";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1182, 562);
            this.ControlBox = false;
            this.Controls.Add(this.button_about);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.button_items);
            this.Controls.Add(this.label_speed);
            this.Controls.Add(this.label_health);
            this.Controls.Add(this.label_obstacle);
            this.Controls.Add(this.label_food);
            this.Controls.Add(this.label_controls);
            this.Controls.Add(this.label_about);
            this.Controls.Add(this.pictureBox_speed);
            this.Controls.Add(this.pictureBox_health);
            this.Controls.Add(this.pictureBox_obstacle);
            this.Controls.Add(this.pictureBox_food);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.customTitleBarControl1);
            this.Controls.Add(this.richTextBox_controls);
            this.Controls.Add(this.richTextBox_about);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HelpForm";
            this.Text = "HelpForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_health)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_obstacle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_food)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomTitleBarControl customTitleBarControl1;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.RichTextBox richTextBox_about;
        private System.Windows.Forms.RichTextBox richTextBox_controls;
        private System.Windows.Forms.Label label_speed;
        private System.Windows.Forms.Label label_health;
        private System.Windows.Forms.Label label_obstacle;
        private System.Windows.Forms.Label label_food;
        private System.Windows.Forms.PictureBox pictureBox_speed;
        private System.Windows.Forms.PictureBox pictureBox_health;
        private System.Windows.Forms.PictureBox pictureBox_obstacle;
        private System.Windows.Forms.PictureBox pictureBox_food;
        private System.Windows.Forms.Button button_about;
        private System.Windows.Forms.Button button_items;
        private System.Windows.Forms.Label label_about;
        private System.Windows.Forms.Label label_controls;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_back;
    }
}