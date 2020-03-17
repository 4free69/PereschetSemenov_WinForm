using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PereschetSemenov_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kurs = Convert.ToDouble(textBox1.Text);
            double priceUs = Convert.ToDouble(textBox2.Text);
            if(kurs != 0 && priceUs != 0)
            {
                textBox3.Text = Convert.ToString((kurs * priceUs) / 100 * 87.5);
                textBox4.Text = Convert.ToString((((kurs * priceUs) / 100 * 87.5) * 1.2) / 42);
                textBox2.Text = "";
            }
        }
    }
}
