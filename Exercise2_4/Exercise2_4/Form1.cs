using System.Windows.Forms;


namespace Exercise2_4
{
    public partial class Form1 : Form
    {
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox checkBox1;
        private Button button1;
        
        public Form1()
        {

            InitializeComponent();
            this.Text = "Ýlk Programým";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            checkBox1 = new CheckBox();
            button1 = new Button();

            textBox1.Location = new Point(100, 100);
            this.Controls.Add(textBox1 );

            checkBox1.Text = "Evet";
            checkBox1.Location= new Point(350,150);
            this.Controls.Add(checkBox1 );

            label1.Text = "Görsel Programlamaya Hoþgeldiniz";
            label1.Font = new Font(label1.Font, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            label1.AutoSize = true;
            label1.Location = new Point(50,50);
            this.Controls.Add(label1);

            label2.Text = "Ýsim: ";
            label2.Font = new Font(label2.Font, FontStyle.Bold | FontStyle.Italic );
            label2.AutoSize = true;
            label2.Location = new Point(50, 100);
            this.Controls.Add(label2);

            label3.Text = "Görsel Programlamayý Sevdiniz mi?";
            label3.Font = new Font(label3.Font, FontStyle.Bold | FontStyle.Italic);
            label3.AutoSize = true;
            label3.Location = new Point(50, 150);
            this.Controls.Add(label3);

            button1 = new Button();
            button1.Text = "YARRAÐIMI YE";
            button1.AutoSize = true;
            button1.Location = new Point(150, 200);
            this.Controls.Add(button1);


        }

         
    }
}
