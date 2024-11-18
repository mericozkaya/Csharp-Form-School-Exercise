using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Example4._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Text = "DAİRE HESAPLAYICI";

            Button cevrebul = new Button();
            cevrebul.Text = "Çevre Bul";
            cevrebul.Name = "cevrebul";
            cevrebul.Size = new Size(100, 25);
            cevrebul.Location = new Point(100, 100);
            cevrebul.Click +=new EventHandler(cevrebul_Click);
            this.Controls.Add(cevrebul);

            Button alanbul = new Button();
            alanbul.Text = "Alan Bul";
            alanbul.Name = "alanbul";
            alanbul.Size = new Size(100, 25);
            alanbul.Location = new Point(225, 100);
            alanbul.Click += new EventHandler(alanbul_Click);
            this.Controls.Add(alanbul);

            Button hacimbul = new Button();
            hacimbul.Text = "Hacim Bul";
            hacimbul.Name = "hacimbul";
            hacimbul.Size = new Size(100, 25);
            hacimbul.Location = new Point(350, 100);
            hacimbul.Click += new EventHandler(hacimbul_Click);
            this.Controls.Add(hacimbul);

            Label label1 = new Label();
            label1.Text = "Yarıçap Uzunluğu";
            label1.Name = "label1";
            label1.AutoSize = true;
            label1.Location = new Point(100, 50);
            this.Controls.Add(label1);

            Label label2 = new Label();
            label2.Text = "Çevresi";
            label2.Name = "label2";
            label2.AutoSize = true;
            label2.Location = new Point(100, 150);
            this.Controls.Add(label2);

            Label label3 = new Label();
            label3.Text = "Alanı";
            label3.Name = "label3";
            label3.AutoSize = true;
            label3.Location = new Point(100,200);
            this.Controls.Add(label3);

            Label label4 = new Label();
            label4.Text = "Kürenin Hacmi";
            label4.Name = "label4";
            label4.AutoSize = true;
            label4.Location = new Point(100, 250);
            this.Controls.Add(label4);


            TextBox textBox1 = new TextBox();
            textBox1.Name = "textbox1";
            textBox1.AutoSize=true;
            textBox1.Location = new Point(225, 50);
            this.Controls.Add(textBox1);

            TextBox textBox2 = new TextBox();
            textBox2.Name = "textbox2";
            textBox2.AutoSize = true;
            textBox2.Location = new Point(225, 150);
            this.Controls.Add(textBox2);

            TextBox textBox3 = new TextBox();
            textBox3.Name = "textbox3";
            textBox3.AutoSize = true;
            textBox3.Location = new Point(225, 200);
            this.Controls.Add(textBox3);

            TextBox textBox4 = new TextBox();
            textBox4.Name = "textbox4";
            textBox4.AutoSize = true;
            textBox4.Location = new Point(225, 250);
            this.Controls.Add(textBox4);
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                double r;

                
                if (!double.TryParse(this.Controls["textbox1"].Text, out r))
                {
                    MessageBox.Show("Lütfen geçerli bir sayı girin.");
                    return;
                }

                double result;

                switch (button.Name)
                {
                    case "cevrebul":
                        result = 2 * r * Math.PI;
                        this.Controls["textbox2"].Text = result.ToString();
                        break;
                    case "alanbul":
                        result = Math.PI * Math.Pow(r, 2);
                        this.Controls["textbox3"].Text = result.ToString();
                        break;
                    case "hacimbul":
                        result = (4.0 / 3.0) * Math.PI * Math.Pow(r, 3);
                        this.Controls["textbox4"].Text = result.ToString();
                        break;
                    default:
                        break;
                }
            }
            
        }

        private void cevrebul_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void hacimbul_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void alanbul_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
                button_Click(sender, e);
        }
    }
}
