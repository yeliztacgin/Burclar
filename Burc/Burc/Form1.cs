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
            int günn = girilentarih.Day;
            int ayy = girilentarih.Month;
            int yıll = girilentarih.Year;



            label8.Text = "Ayınız" + ayy.ToString();
            label9.Text = "Gününüz" + günn.ToString();
            label10.Text = "Yılınız" + yıll.ToString();

            DateTime şimdi = DateTime.Now;

            label11.Text = şimdi.Year.ToString();

            int sonuçyıl = şimdi.Year - yıll;
            textBox3.Text = sonuçyıl.ToString();

            TimeSpan span = şimdi.Subtract(dateTimePicker1.Value);
            textBox1.Text = span.Days.ToString();


            DateTime güntarih = dateTimePicker2.Value;
            TimeSpan fark = new TimeSpan();
            if (DateTime.Now > güntarih)
            {
                fark = DateTime.Now - güntarih;
                label12.Text = "Doğum tarihinden" + fark.Days + "Gün Geçti";


            }
            else
            {
                fark = güntarih - DateTime.Now;
                label12.Text = "Doğum tarihine" + fark.Days + "Gün Kaldı";
            }



            int ay = 0;

            ay += span.Days / 30;

            textBox2.Text = ay.ToString();

            if (ayy == 3 && günn >= 21 || ayy == 4 && günn <= 20)
            {
                pictureBox1.ImageLocation = "koç.jpg";

            }
            if (ayy == 4 && günn >= 21 || ayy == 5 && günn <= 21)
            {
                pictureBox1.ImageLocation = "boğa.jpg";

            }

            if (ayy == 5 && günn >= 22 || ayy == 6 && günn <= 22)
            {
                pictureBox1.ImageLocation = "ikizler.jpg";

            }

            if (ayy == 6 && günn >= 23 || ayy == 7 && günn <= 22)
            {
                pictureBox1.ImageLocation = "yengeç.jpg";

            }
            if (ayy == 7 && günn >= 23 || ayy == 8 && günn <= 22)
            {
                pictureBox1.ImageLocation = "aslan.jpg";

            }
            if (ayy == 8 && günn >= 23 || ayy == 9 && günn <= 22)
            {
                pictureBox1.ImageLocation = "başak.jpg";

            }
            if (ayy == 9 && günn >= 23 || ayy == 10 && günn <= 22)
            {
                pictureBox1.ImageLocation = "terazi.jpg";

            }
            if (ayy == 10 && günn >= 23 || ayy == 11 && günn <= 21)
            {
                pictureBox1.ImageLocation = "akrep.jpg";

            }
            if (ayy == 11 && günn >= 22 || ayy == 12 && günn <= 21)
            {
                pictureBox1.ImageLocation = "yay.jpg";

            }
            if (ayy == 12 && günn >= 22 || ayy == 1 && günn <= 21)
            {
                pictureBox1.ImageLocation = "oğlak.jpg";

            }
            if (ayy == 1 && günn >= 22 || ayy == 2 && günn <= 19)
            {
                pictureBox1.ImageLocation = "kova.jpg";

            }
            if (ayy == 2 && günn >= 20 || ayy == 3 && günn <= 20)
            {
                pictureBox1.ImageLocation = "balık.jpg";

            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}