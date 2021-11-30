using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double a, b, p;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Result_Click(object sender, EventArgs e)
        { 
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Не все данные введены");
            }
            else if (Double.TryParse(textBox1.Text, out a) && Double.TryParse(textBox2.Text, out b))
            {
                p = Math.Sqrt(a * a + b * b) + a + b;
                Perimetr.Text = Math.Round(p, 3).ToString();
            }
            else
            {
                MessageBox.Show("Неверные значения");
            }
        }
    }
}
