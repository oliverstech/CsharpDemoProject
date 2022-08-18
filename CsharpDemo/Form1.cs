using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label5.Text = Convert.ToString(trackBar1.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = textBox1.Text;
            MessageBox.Show("You typed: " + message, "Message Box Demo");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("The box is checked!");
            }
            else
            {
                MessageBox.Show("The box isn't checked!");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var linkmsg = MessageBox.Show("You clicked a link!\nThese are usually used for opening weblinks. Want to open an example one?", "", MessageBoxButtons.YesNo);

            if (linkmsg == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://www.google.com");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (progressBar1.Style == ProgressBarStyle.Marquee)
            {
                progressBar1.Style = ProgressBarStyle.Blocks;
            }
            else
            {
                progressBar1.Style = ProgressBarStyle.Marquee;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label5.Text = Convert.ToString(trackBar1.Value);
        }
    }
}
