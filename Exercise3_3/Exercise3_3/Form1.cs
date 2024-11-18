namespace Exercise3_3
{
    public partial class Form1 : Form
    {
        TextBox textBox1 = new TextBox();
        TextBox textBox2 = new TextBox();
        TextBox textBox3 = new TextBox();   
        TextBox textBox4 = new TextBox();
        TextBox textBox5 = new TextBox();
        TextBox textBox6 = new TextBox();
        TextBox textBox7 = new TextBox();
        TextBox textBox8 = new TextBox();
        TextBox textBox9 = new TextBox();
        TextBox textBox10 = new TextBox();
        TextBox textBox11 = new TextBox();
        TextBox textBox12 = new TextBox();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Label label1 = new Label();
            label1.Text = "Mini Calculator";
            label1.AutoSize = true;
            label1.Location = new Point(50,100);
            label1.Font=new Font("ariel", 50, FontStyle.Bold | FontStyle.Italic);
            this.Controls.Add(label1);
            
            
            
            textBox1 = new TextBox();
            textBox1.Location = new Point(50, 200);
            this.Controls.Add(textBox1);

            textBox2 = new TextBox();
            textBox2.Location = new Point(50, 250);
            this.Controls.Add(textBox2);

            textBox3 = new TextBox();
            textBox3.Location = new Point(50, 300);
            this.Controls.Add(textBox3);

            textBox4 = new TextBox();
            textBox4.Location = new Point(50, 350);
            this.Controls.Add(textBox4);

            textBox5 = new TextBox();
            textBox5.Location = new Point(200, 200);
            this.Controls.Add(textBox5);

            textBox6 = new TextBox();
            textBox6.Location = new Point(200, 250);
            this.Controls.Add(textBox6);

            textBox7 = new TextBox();
            textBox7.Location = new Point(200, 300);
            this.Controls.Add(textBox7);

            textBox8 = new TextBox();
            textBox8.Location = new Point(200, 350);
            this.Controls.Add(textBox8);

            textBox9 = new TextBox();
            textBox9.Location = new Point(350, 200);
            this.Controls.Add(textBox9);

            textBox10 = new TextBox();
            textBox10.Location = new Point(350, 250);
            this.Controls.Add(textBox10);

            textBox11 = new TextBox();
            textBox11.Location = new Point(350, 300);
            this.Controls.Add(textBox11);

            textBox12 = new TextBox();
            textBox12.Location = new Point(350, 350);
            this.Controls.Add(textBox12);



        }
    }
}
