namespace Burc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime girilentarih = dateTimePicker1.Value;
            int g�nn = girilentarih.Day;
            int ayy = girilentarih.Month;
            int y�ll = girilentarih.Year;



            label8.Text = "Ay�n�z" + ayy.ToString();
            label9.Text = "G�n�n�z" + g�nn.ToString();
            label10.Text = "Y�l�n�z" + y�ll.ToString();

            DateTime �imdi = DateTime.Now;

            label11.Text = �imdi.Year.ToString();

            int sonu�y�l = �imdi.Year - y�ll;
            textBox3.Text = sonu�y�l.ToString();

            TimeSpan span = �imdi.Subtract(dateTimePicker1.Value);
            textBox1.Text = span.Days.ToString();


            DateTime g�ntarih = dateTimePicker2.Value;
            TimeSpan fark = new TimeSpan();
            if (DateTime.Now > g�ntarih)
            {
                fark = DateTime.Now - g�ntarih;
                label12.Text = "Do�um tarihinden" + fark.Days + "G�n Ge�ti";


            }
            else
            {
                fark = g�ntarih - DateTime.Now;
                label12.Text = "Do�um tarihine" + fark.Days + "G�n Kald�";
            }



            int ay = 0;

            ay += span.Days / 30;

            textBox2.Text = ay.ToString();

            if (ayy == 3 && g�nn >= 21 || ayy == 4 && g�nn <= 20)
            {
                pictureBox1.ImageLocation = "ko�.jpg";

            }
            if (ayy == 4 && g�nn >= 21 || ayy == 5 && g�nn <= 21)
            {
                pictureBox1.ImageLocation = "bo�a.jpg";

            }

            if (ayy == 5 && g�nn >= 22 || ayy == 6 && g�nn <= 22)
            {
                pictureBox1.ImageLocation = "ikizler.jpg";

            }

            if (ayy == 6 && g�nn >= 23 || ayy == 7 && g�nn <= 22)
            {
                pictureBox1.ImageLocation = "yenge�.jpg";

            }
            if (ayy == 7 && g�nn >= 23 || ayy == 8 && g�nn <= 22)
            {
                pictureBox1.ImageLocation = "aslan.jpg";

            }
            if (ayy == 8 && g�nn >= 23 || ayy == 9 && g�nn <= 22)
            {
                pictureBox1.ImageLocation = "ba�ak.jpg";

            }
            if (ayy == 9 && g�nn >= 23 || ayy == 10 && g�nn <= 22)
            {
                pictureBox1.ImageLocation = "terazi.jpg";

            }
            if (ayy == 10 && g�nn >= 23 || ayy == 11 && g�nn <= 21)
            {
                pictureBox1.ImageLocation = "akrep.jpg";

            }
            if (ayy == 11 && g�nn >= 22 || ayy == 12 && g�nn <= 21)
            {
                pictureBox1.ImageLocation = "yay.jpg";

            }
            if (ayy == 12 && g�nn >= 22 || ayy == 1 && g�nn <= 21)
            {
                pictureBox1.ImageLocation = "o�lak.jpg";

            }
            if (ayy == 1 && g�nn >= 22 || ayy == 2 && g�nn <= 19)
            {
                pictureBox1.ImageLocation = "kova.jpg";

            }
            if (ayy == 2 && g�nn >= 20 || ayy == 3 && g�nn <= 20)
            {
                pictureBox1.ImageLocation = "bal�k.jpg";

            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}