namespace Exercise2_6
{
    public partial class Form1 : Form
    {
        private TextBox textBox1;
        private ListBox listBox1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1 = new ListBox();
            listBox1.Location = new Point(50, 30);
            this.Controls.Add(listBox1);

            textBox1=new TextBox();
            textBox1.Location = new Point(50, 150);
            this.Controls.Add(textBox1);

            Button button1 = new Button();
            button1.Location = new Point(150, 150);
            button1.Text = "Ekle";
            button1.AutoSize = true;
            button1.Click += Button1_Click;
            this.Controls.Add(button1);

            Button button2 = new Button();
            button2.Location = new Point(50, 200);
            button2.Text = "Temizle";
            button2.AutoSize = true;
            button2.Click += Button2_Click;
            this.Controls.Add(button2);

            Button button3 = new Button();
            button3.Location = new Point(150, 220);
            button3.Text = "Topla";
            button3.AutoSize = true;
            button3.Click += Button3_Click;
            this.Controls.Add(button3);

            Button button4 = new Button();
            button4.Location = new Point(50, 200);
            button4.Text = "Temizle";
            button4.AutoSize = true;
            button4.Click += Button4_Click;
            
        }

        private void Button4_Click(object? sender, EventArgs e)
        {
            
        }

        private void Button3_Click(object? sender, EventArgs e)
        {
            int total = 0;

            foreach (var item in listBox1.Items)
            {
                if (int.TryParse(item.ToString(),out int number))
                {
                    total += number;
                }
            }

            MessageBox.Show(total.ToString(),"toplayýcý");
        }

        private void Button2_Click(object? sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = null;
        }
    }
}
