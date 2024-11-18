using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Geri Al";
            button2.Text = "Sil";
            button3.Text = "Tamamla";
            label1.Text = "Yazı:";

        }

        private void dialogueButton(object sender, EventArgs e)
        {
            Button button = (Button)sender; ;
            switch (button.Text)
            {
                case "Geri Al":
                    textBox1.Undo();
                    break;
                case "Sil":
                    textBox1.Clear();
                    break;
                case "Tamamla":
                    textBox1.Enabled = false;
                    MessageBox.Show(textBox1.Text);
                    button1.Enabled = false;
                    button2.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dialogueButton(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dialogueButton(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dialogueButton(sender, e);
        }
    }
}
