using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uaspabd
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 call = new Form1();
            call.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form3 call = new Form3();
            call.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form4 call = new Form4();
            call.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form5 call = new Form5();
            call.Show();
            this.Hide();
        }
    }
}
