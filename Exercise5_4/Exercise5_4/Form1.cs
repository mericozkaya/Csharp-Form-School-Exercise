namespace Exercise5_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);

            double y = Convert.ToDouble(textBox2.Text);

            if (radioButton1.Checked)
                textBox3.Text=(x+y).ToString();
            if (radioButton2.Checked)
                textBox3.Text=(x-y).ToString();
            if(radioButton3.Checked)
                textBox3.Text=(x*y).ToString();
            
            if (radioButton4.Checked)
                if (y == 0)
                    textBox3.Text = "undefined";
                else
                    textBox3.Text=(x/y).ToString();
                


        }
    }
}
