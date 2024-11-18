namespace Exercise_5_2
{
    public partial class Form1 : Form
    {
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        public Form1()
        {
            InitializeComponent();

            this.Text = "BMI Hesaplama";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Label label1=new Label();
            label1.Text = "Kilo (kg)";
            label1.AutoSize = true;
            label1.Location = new Point(0,0);
            this.Controls.Add(label1);


            textBox1 = new TextBox();
            textBox1.Location = new Point(100, 0);
            this.Controls.Add(textBox1 );


            Label label2=new Label();
            label2.Text = "Boy (m)";
            label2.AutoSize = true; 
            label2.Location = new Point(0,25);
            this.Controls.Add(label2);

            textBox2 = new TextBox();
            textBox2.Location = new Point(100, 25);
            this.Controls.Add(textBox2);

            Button button1=new Button();
            button1.Text = "Calculate BMI";
            button1.Location = new Point(50, 50);
            button1.Click += new EventHandler(button1_Click);
            this.Controls.Add(button1);

            Label label3=new Label();
            label3.Text = "Kiþinin BMI";
            label3.AutoSize = true;
            label3.Location = new Point(0, 75);
            this.Controls.Add(label3);

            textBox3 = new TextBox();
            textBox3.Location = new Point(100, 75);
            this.Controls.Add(textBox3);

            Label label4=new Label();
            label4.Text = "BMI Uygunluk";
            label4.AutoSize = true;
            label4.Location = new Point(0, 100);
            this.Controls.Add(label4);

            textBox4 = new TextBox();
            textBox4.Location = new Point(100, 100);
            this.Controls.Add(textBox4);




            void button1_Click(object sender, EventArgs e)
            {
                double w=Convert.ToDouble(textBox1.Text);
                double h=Convert.ToDouble(textBox2.Text);

                double bmi =w/(h*h);

                textBox3.Text = bmi.ToString();

                if (bmi < 18.5) 
                    textBox4.Text = "UnderWeight";
                if (18.5 < bmi && bmi < 24.9)
                    textBox4.Text = "Normal Kilo";
                if (25 < bmi && bmi < 29.9)
                    textBox4.Text = "Balýk Etli";
                if (bmi > 30);
                    textBox4.Text = "Obez";
                    

            }

        }
    }
}
