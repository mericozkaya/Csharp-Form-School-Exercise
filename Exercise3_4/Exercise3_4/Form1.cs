namespace Exercise3_4
{
    public partial class Form1 : Form
    {
        TextBox textBox1;
        TextBox textBox2;
        TextBox textBox3;
        TextBox textBox4;


        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Average";
            this.BackColor = Color.Green;

            Label label1 = new Label();
            label1.Text = "Average Calculator";
            label1.AutoSize = true;
            label1.Location = new Point(50, 0);
            this.Controls.Add(label1);

            textBox1 = new TextBox();
            textBox1.Location = new Point(50,50);
            this.Controls.Add(textBox1);

            textBox2= new TextBox();
            textBox2.Location = new Point(50, 100);
            this.Controls.Add(textBox2);

            textBox3 = new TextBox();
            textBox3.Location = new Point(50, 150);
            this.Controls.Add(textBox3);

            textBox4 = new TextBox();
            textBox4.Location = new Point(50, 250);
            this.Controls.Add(textBox4);


            Button button1 = new Button();
            button1.Text = "Calculate Avarage";
            button1.AutoSize = true;
            button1.Location = new Point(50, 200);
            this.Controls.Add(button1);

            button1.Click += Button1_Click;

        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            textBox4.Text = Convert.ToString((Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox3.Text))/3);
            MessageBox.Show(textBox4.Text,"yarrraaa",MessageBoxButtons.OK);
            
        }
    }
}
