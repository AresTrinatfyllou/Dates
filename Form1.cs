using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dates;

namespace Test
{
    public partial class Form1 : Form
    {
        //ClsDates date_class = new ClsDates();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = ClsDates.Date2Julian(textBox1.Text).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = ClsDates.Julian2Date(Convert.ToInt32(textBox2.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = ClsDates.DayInWeek(textBox1.Text).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = ClsDates.GetOrthodoxEaster(Convert.ToInt32(textBox1.Text)).ToString();
        }
    }
}
