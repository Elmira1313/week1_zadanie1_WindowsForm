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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int c, o, v;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void Result_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Данные не введены");
            }
            else if (Int32.TryParse(textBox1.Text, out c) && textBox1.Text.Length == 2)
            {
                o = Convert.ToInt32( c / 10);
                v = c % 10;
                if (o == v)
                {
                    Otvet.Text = "одинаковы";
                }
                else
                {
                    Otvet.Text = "разные";
                }
            }
            else
            {
                MessageBox.Show("Неверное значение");
            }
        }
    }
}
