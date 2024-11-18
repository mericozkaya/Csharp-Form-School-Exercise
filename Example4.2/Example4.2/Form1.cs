using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Assignment";
            button1.Name = "buttonRed";
            button1.BackColor = Color.Red;
            button2.Name = "buttonGreen";
            button2.BackColor = Color.Green;
            button3.Name = "buttonBlue";
            button3.BackColor = Color.Blue;
            button1.Text = "K";
            button2.Text = "Y";
            button3.Text = "M";

            button4.Text = "Geri Al";
            button5.Text = "Sil";
            button6.Text = "Tamamla";
            label1.Text = "Yazı:";

        }

        private void rgb_button_MouseHover(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            switch (button.Name)
            {
                case "buttonRed":
                    this.BackColor = Color.Red;
                    break;
                case "buttonGreen":
                    this.BackColor = Color.Green;
                    break;
                case "buttonBlue":
                    this.BackColor = Color.Blue;
                    break;
                default:
                     break;
            }
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
                    button4.Enabled = false;
                    button5.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            rgb_button_MouseHover(sender, e);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            rgb_button_MouseHover(sender, e);
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            rgb_button_MouseHover(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dialogueButton(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dialogueButton(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dialogueButton(sender, e);
        }
    }
}
