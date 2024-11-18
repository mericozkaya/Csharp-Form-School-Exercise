namespace Exercise3_1
{
    public partial class Form1 : Form
    {
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Label label1 = new Label();
            label1.Text = "Ad: ";
            label1.Location = new Point(50, 50);
            label1.AutoSize = true;
            this.Controls.Add(label1);

            textBox1 = new TextBox();
            textBox1.Location = new Point(200, 50);
            this.Controls.Add(textBox1);

            Label label2 = new Label();
            label2.Text = "Soyad: ";
            label2.Location = new Point(50, 100);
            label2.AutoSize = true;
            this.Controls.Add(label2);

            textBox2 = new TextBox();
            textBox2.Location = new Point(200, 100);
            this.Controls.Add(textBox2);

            Label label3 = new Label();
            label3.Text = "Öðrenci No: ";
            label3.Location = new Point(50, 150);
            label3.AutoSize = true;
            this.Controls.Add(label3);

            textBox3 = new TextBox();
            textBox3.Location = new Point(200, 150);
            this.Controls.Add(textBox3);

            Label label4 = new Label();
            label4.Text = "Okul: ";
            label4.Location = new Point(50, 200);
            label4.AutoSize = true;
            this.Controls.Add(label4);

            textBox4 = new TextBox();
            textBox4.Location = new Point(200, 200);
            this.Controls.Add(textBox4);

            Label label5 = new Label();
            label5.Text = "Bölüm: ";
            label5.Location = new Point(50, 250);
            label5.AutoSize = true;
            this.Controls.Add(label5);

            textBox5 = new TextBox();
            textBox5.Location = new Point(200, 250);
            this.Controls.Add(textBox5);


            Button button1 = new Button();
            button1.Location = new Point(200, 400);
            button1.Text = "Göster";
            button1.AutoSize = true;
            this.Controls.Add(button1);
            button1.Click += Button1_Click;

            GroupBox groupBox1 = new GroupBox();
            groupBox1.Location = new Point(100, 300);
            groupBox1.AutoSize = true;
            this.Controls.Add(groupBox1);
           

            radioButton1 = new RadioButton();
            radioButton1.Location = new Point(0, 0);
            radioButton1.Text = "Kýz";
            radioButton1.AutoSize = true;
            this.Controls.Add(radioButton1);

            radioButton2 = new RadioButton();
            radioButton2.Location = new Point(100, 0);
            radioButton2.Text = "Erkek";
            radioButton2.AutoSize = true;
            this.Controls.Add(radioButton2);

            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);

            
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            MessageBox.Show($" {textBox1.Text} \n {textBox2.Text} \n {textBox3.Text} \n {textBox4.Text} \n {textBox5.Text} \n ", "Mahmut", MessageBoxButtons.OKCancel);
        }
    }
}
