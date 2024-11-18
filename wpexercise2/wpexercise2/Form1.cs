namespace wpexercise2
{
    public partial class Form1 : Form
    {
        ListBox listBox1;
        TextBox textBox1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1 = new ListBox();
            listBox1.Location = new Point(0, 0);
            listBox1.Size = new Size(200, 200);
            this.Controls.Add(listBox1);

            textBox1 = new TextBox();
            textBox1.Location = new Point(200, 100);
            this.Controls.Add(textBox1);

            Button button1 = new Button();
            button1.Location = new Point(300, 100);
            button1.Text = "Para bölüþtür";
            button1.AutoSize = true;
            button1.BackColor = Color.Green;

            this.Controls.Add(button1);
            button1.Click += Button1_Click;


        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);

            if (x % 200 != 0)
            {
                listBox1.Items.Add($"{x / 200} adet 200 TL'lik");
                x = x - ((x / 200) * 200);
                
            }
            if (x % 100 != 0)
            {
                listBox1.Items.Add($"{x / 100} adet 100 TL'lik");
                x = x - ((x / 100) * 100);
            }
            if (x % 50 != 0)
            {
                listBox1.Items.Add($"{x / 50} adet 50 TL'lik");
                x = x - ((x / 50) * 50);
            }

            if (x % 20 != 0)
            {
                listBox1.Items.Add($"{x / 20} adet 20 TL'lik");
                x = x - ((x / 20) * 20);
            }
            if (x % 10 != 0)
            {
                listBox1.Items.Add($"{x / 10} adet 10 TL'lik");
                x = x - ((x / 10) * 10);
            }
            if (x % 5 != 0)
            {
                listBox1.Items.Add($"{x / 5} adet 5 TL'lik");
                x = x - ((x / 5) * 5);
            }

        }
    }
}
