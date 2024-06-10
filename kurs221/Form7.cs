using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kurs221
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            
            textBox8.Clear();
            textBox9.Clear();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double m = double.Parse(textBox1.Text);
            double V = double.Parse(textBox2.Text);
            double v = double.Parse(textBox3.Text);

            double p = m * Math.Pow(v, 2) / 3 * V;
            
            textBox5.Text = m.ToString();
            textBox6.Text = v.ToString();
            textBox8.Text = V.ToString();

            textBox9.Text = p.ToString();
            textBox4.Text = p.ToString();

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }
}
