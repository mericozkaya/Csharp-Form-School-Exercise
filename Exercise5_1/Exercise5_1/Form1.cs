namespace Exercise5_1
{
    public partial class Form1 : Form
    {
        private TextBox textBox1;

        public Form1()
        {
            InitializeComponent();

            Label label1 = new Label();
            label1.Text = "Ehliyet Almaya Uygunluk Yaþ Kontrol Sistemi";
            label1.Font = new Font(label1.Font, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            label1.AutoSize = true;
            label1.Location = new Point(100, 50);
            this.Controls.Add(label1);

            Label label2 = new Label();
            label2.Text = "Lütfen Yaþýnýzý Girin:";
            label2.Font = new Font(label2.Font, FontStyle.Bold | FontStyle.Italic);
            label2.AutoSize = true;
            label2.Location = new Point(50, 100);
            this.Controls.Add(label2);

            textBox1 = new TextBox();
            textBox1.Location = new Point(200, 100);
            this.Controls.Add(textBox1);

            Button button1 = new Button();
            button1.Text = "Sorgula";
            button1.Location = new Point(200, 150);
            button1.Click += new EventHandler(button1_Click);
            this.Controls.Add(button1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {



            if (double.TryParse(textBox1.Text, out double yas))
            {
                if (yas >= 18)
                {
                    MessageBox.Show("Ehliyet almaya yaþýnýz uygundur !", "Ehliyet Almaya Uygunluk Yaþ Kontrol Sistemi", MessageBoxButtons.OKCancel);
                }
                else
                {
                    MessageBox.Show("Ehliyet almaya yaþýnýz uygun DEÐÝLDÝR!", "Ehliyet Almaya Uygunluk yaþ Kontrol Sistemi", MessageBoxButtons.OKCancel);
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir yaþ girin.", "Hata", MessageBoxButtons.OKCancel);
            }


        }
    }
}
