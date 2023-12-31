﻿using System;
using System.Drawing;
using System.Windows.Forms;

public partial class CustomTitleBarControl : UserControl
{
    private Panel customTitleBar;
    private Point offset; // Used to store the mouse cursor position relative to the form

    public CustomTitleBarControl()
    {
        InitializeComponent();

        // Attach event handlers
     
    }

  
    

    private void InitializeComponent()
    {
            this.customTitleBar = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // customTitleBar
            // 
            this.customTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.customTitleBar.Location = new System.Drawing.Point(3, 3);
            this.customTitleBar.Name = "customTitleBar";
            this.customTitleBar.Size = new System.Drawing.Size(1325, 37);
            this.customTitleBar.TabIndex = 15;
            this.customTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.customTitleBar_Paint);
            this.customTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.customTitleBar_MouseDown);
            this.customTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.customTitleBar_MouseMove);
            this.customTitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.customTitleBar_MouseUp);
            // 
            // CustomTitleBarControl
            // 
            this.Controls.Add(this.customTitleBar);
            this.Name = "CustomTitleBarControl";
            this.Size = new System.Drawing.Size(1308, 40);
            this.Load += new System.EventHandler(this.CustomTitleBarControl_Load);
            this.ResumeLayout(false);

    }

    private void CustomTitleBarControl_Load(object sender, EventArgs e)
    {

    }

    private void customTitleBar_Paint(object sender, PaintEventArgs e)
    {

    }

    private void customTitleBar_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            // Capture the mouse and store the position relative to the form
            offset = new Point(-e.X, -e.Y);
            ((Control)sender).Capture = true;
        }

    }

    private void customTitleBar_MouseMove(object sender, MouseEventArgs e)
    {
        if (((Control)sender).Capture)
        {
            // Move the form based on the mouse cursor position
            Point newLocation = this.PointToScreen(e.Location);
            newLocation.Offset(offset);
            ((Form)this.TopLevelControl).Location = newLocation;
        }
    }

    private void customTitleBar_MouseUp(object sender, MouseEventArgs e)
    {
        // Release the mouse capture
        ((Control)sender).Capture = false;
    }
}
