using System.Security.Cryptography.Xml;

namespace wpexercise1
{
    public partial class Form1 : Form
    {
        TextBox textBox1;
        TextBox textBox2;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1 = new TextBox();
            textBox1.Location = new Point(50, 50);
            this.Controls.Add(textBox1);

            Button button1 = new Button();
            button1.Location = new Point(200, 50);
            button1.Text = "Hesapla";
            button1.BackColor=Color.Yellow;
            button1.AutoSize = true;
            this.Controls.Add(button1);

            button1.Click += Button1_Click;

            textBox2 = new TextBox();
            textBox2.Location = new Point(300, 50);
            this.Controls.Add(textBox2);

            



        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            int xx = Convert.ToInt32(textBox1.Text);
            if (xx % 5 == 0)
            {
                textBox2.Text = (xx / 5).ToString();
            }
            else 
            {
                textBox2.Text = "5'e bölünemez";
            }
        }
    }
}
