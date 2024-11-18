namespace wpexercise3
{
    public partial class Form1 : Form
    {
        TextBox textBox1;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1 = new TextBox();
            textBox1.Location=new Point(0,0);
            this.Controls.Add(textBox1);

            Button button1 = new Button();
            button1.Location = new Point(100, 0);
            button1.BackColor = Color.Blue;
            button1.Text = "Art�k Y�l hesapla";
            button1.AutoSize = true;
            this.Controls.Add(button1);

            button1.Click += Button1_Click;
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            
            if (false == DateTime.IsLeapYear(Convert.ToInt32(textBox1.Text)))
            {
                MessageBox.Show(Convert.ToInt32(textBox1.Text) + " Artik y�l de�il");

            }
            else
            {
                MessageBox.Show(Convert.ToInt32(textBox1.Text) + " Artik y�l ");
            }

        }
    }
}
