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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double m = double.Parse(textBox1.Text);
            double V = double.Parse(textBox2.Text);
            double u = double.Parse(textBox3.Text);
            double P = double.Parse(textBox4.Text);
            double R = 8.31;

            double T = P * V * u / m * R;
            textBox11.Text = T.ToString();
            textBox5.Text = T.ToString();
            textBox6.Text = P.ToString();
            textBox7.Text = V.ToString();
            textBox8.Text = u.ToString();
            textBox9.Text = m.ToString();
            textBox10.Text = R.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            
        }
    }
}
