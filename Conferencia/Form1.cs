using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conferencia
{
    public partial class Form1 : Form
    {
        int val1, val2, res;

        private void button2_Click(object sender, EventArgs e)
        {
            val1 = Int16.Parse(textBox1.Text);
            val2 = Int16.Parse(textBox2.Text);
            res = val1 - val2;

            this.label1.Text = "Resultado: " + res;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            val1 = Int16.Parse(textBox1.Text);
            val2 = Int16.Parse(textBox2.Text);
            res = val1 + val2;

            this.label1.Text = "Resultado: " + res;

        }
    }
}
