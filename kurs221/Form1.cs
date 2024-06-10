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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 b = new Form3();
            b.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 с = new Form4();
            с.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 d = new Form5();
            d.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 s = new Form6();
            s.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 t = new Form7();
            t.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form8 q = new Form8();
            q.ShowDialog();
        }
    }
}
