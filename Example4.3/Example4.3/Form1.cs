using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example4._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.Text = "Is Leap Year";
            this.BackColor=Color.DeepSkyBlue;
            label1.Text = "Year";
            button1.BackColor = Color.GreenYellow;
            button1.Text = "Check";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year = Int32.Parse(textBox1.Text);
            bool isLeapYear = DateTime.IsLeapYear(year);

            if (isLeapYear)
            {

                MessageBox.Show(year + " is leap year. (366)", "Message");
            }
            else
                MessageBox.Show(year + " is normal year. (365)", "Message");

        }
    }
}
