using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukusyu0517
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void up_button_Click(object sender, EventArgs e)
        {
            textBox2.Text = "-5";
            textBox1.Text = "0";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += int.Parse(textBox1.Text);
            label1.Top += int.Parse(textBox2.Text);
        }

        private void left_button_Click(object sender, EventArgs e)
        {
            textBox1.Text = "-5";
            textBox2.Text = "0";
        }

        private void down_button_Click(object sender, EventArgs e)
        {
            textBox2.Text = "5";
            textBox1.Text = "0";
        }

        private void right_button_Click(object sender, EventArgs e)
        {
            textBox1.Text = "5";
            textBox2.Text = "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            label1.Location = new Point(240, 160);
        }
    }
}
