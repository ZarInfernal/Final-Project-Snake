using Snake.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
            ShowAboutSection();
        }

        private void button_about_Click(object sender, EventArgs e)
        {
            ShowAboutSection();
        }

        private void button_items_Click(object sender, EventArgs e)
        {
            ShowItemsSection_1();
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            ShowItemsSection_2();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            ShowItemsSection_1();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowAboutSection()
        {
            richTextBox_about.Visible = true;
            label_about.Visible = true;
            // ... set visibility for other controls in the "About" section ...

            richTextBox_controls.Visible = true;
            label_controls.Visible = true;
            // ... set visibility for other controls in the "Controls" section ...

            pictureBox_food.Visible = false;
            pictureBox_obstacle.Visible = false;
            pictureBox_health.Visible = false;
            pictureBox_speed.Visible = false;

            label_food.Visible = false;
            label_obstacle.Visible = false;
            label_health.Visible = false;
            label_speed.Visible = false;
            // ... set visibility for other controls in the "Items" section ...

            button_next.Visible = false;
            button_back.Visible = false;
        }

        private void ShowItemsSection_1()
        {
            richTextBox_about.Visible = false;
            label_about.Visible = false;
            // ... set visibility for other controls in the "About" section ...

            richTextBox_controls.Visible = false;
            label_controls.Visible = false;
            // ... set visibility for other controls in the "Controls" section ...

            pictureBox_food.Visible = true;
            pictureBox_obstacle.Visible = true;
            pictureBox_health.Visible = false;
            pictureBox_speed.Visible = false;

            label_food.Visible = true;
            label_obstacle.Visible = true;
            label_health.Visible = false;
            label_speed.Visible = false;
            // ... set visibility for other controls in the "Items" section ...

            button_next.Visible = true;
            button_back.Visible = true;
        }

        private void ShowItemsSection_2()
        {
            richTextBox_about.Visible = false;
            label_about.Visible = false;
            // ... set visibility for other controls in the "About" section ...

            richTextBox_controls.Visible = false;
            label_controls.Visible = false;
            // ... set visibility for other controls in the "Controls" section ...

            pictureBox_food.Visible = false;
            pictureBox_obstacle.Visible = false;
            pictureBox_health.Visible = true;
            pictureBox_speed.Visible = true;

            label_food.Visible = false;
            label_obstacle.Visible = false;
            label_health.Visible = true;
            label_speed.Visible = true;
            // ... set visibility for other controls in the "Items" section ...

            button_next.Visible = true;
            button_back.Visible = true;
        }
    }
}