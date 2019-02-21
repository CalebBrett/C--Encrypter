using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Encrypter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int code = 0;

            code = Int32.Parse(textBox3.Text);
            String FirstMessage = textBox1.Text.ToString();
            string f = FirstMessage;
            string result = new string(f.Select(r => (char)(r + code)).ToArray());
            textBox2.Text = result;
            textBox1.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int code = Int32.Parse(textBox3.Text);
            String FirstMessage = textBox2.Text.ToString();
            string f = FirstMessage;
            string result = new string(f.Select(r => (char)(r - code)).ToArray());
            textBox1.Text = result;
            textBox2.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                textBox3.Visible = true;
            }
            else
            {
                textBox3.Visible = false;
            }
        }
    }
}
