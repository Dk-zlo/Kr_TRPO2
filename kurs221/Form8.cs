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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
          
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double p1 = double.Parse(textBox1.Text);
            double t1 = double.Parse(textBox2.Text);
            double t2 = double.Parse(textBox3.Text);

            double P2 = p1 * t2 / t1;

            textBox11.Text = p1.ToString();
            textBox12.Text = t1.ToString();
            textBox13.Text = t2.ToString();

            textBox14.Text = P2.ToString();
            textBox4.Text = P2.ToString();

        }
    }
}
