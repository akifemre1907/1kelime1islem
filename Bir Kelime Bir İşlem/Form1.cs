namespace Bir_Kelime_Bir_İşlem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rst = new Random();
        int harfsayac = 0;
        int sayisayac = 0;

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnHarfGet_Click(object sender, EventArgs e)
        {
            harfsayac++;

            string krkt1, krkt2, krkt3, krkt4, krkt5, krkt6, krkt7, krkt8;
            int harfler;
            string[] dizi = { "A", "B", "C", "D", "E", "F", "G", "Ğ", "H", "I", "İ", "J", "K", "L", "M", "N", "O", "Ö", "P","R","S","Ş","T","U","Ü","V","Y","Z" };
            if (harfsayac== 1 )
            {
                harfler = rst.Next(0,dizi.Length);
                krkt1 = (dizi[harfler]);
                button1.Text = krkt1.ToString();
                button1.Visible = true;
            }

            if(harfsayac == 2 )
            {
                harfler = rst.Next(0, dizi.Length);
                krkt2 = (dizi[harfler]);
                button2.Text = krkt2.ToString();
                button2.Visible = true;
            }
            if (harfsayac == 3)
            {
                harfler = rst.Next(0, dizi.Length);
                krkt3 = (dizi[harfler]);
                button3.Text = krkt3.ToString();
                button3.Visible = true;
            }
            if (harfsayac == 4)
            {
                harfler = rst.Next(0, dizi.Length);
                krkt4 = (dizi[harfler]);
                button4.Text = krkt4.ToString();
                button4.Visible = true;
            }
            if (harfsayac == 5)
            {
                harfler = rst.Next(0, dizi.Length);
                krkt5 = (dizi[harfler]);
                button5.Text = krkt5.ToString();
                button5.Visible = true;
            }
            if (harfsayac == 6)
            {
                harfler = rst.Next(0, dizi.Length);
                krkt6 = (dizi[harfler]);
                button6.Text = krkt6.ToString();
                button6.Visible = true;
            }
            if (harfsayac == 7)
            {
                harfler = rst.Next(0, dizi.Length);
                krkt7 = (dizi[harfler]);
                button7.Text = krkt7.ToString();
                button7.Visible = true;
            }
            if (harfsayac == 8)
            {
                harfler = rst.Next(0, dizi.Length);
                krkt8 = (dizi[harfler]);
                button8.Text = krkt8.ToString();
                button8.Visible = true;
                btnJoker.Text = "?";
                btnJoker.Visible = true;
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void btnSayıGet_Click(object sender, EventArgs e)
        {
            sayisayac++;
            string dgr1, dgr2, dgr3, dgr4, dgr5, dgr6;
            int dgr7;
            string[] dizi2 = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string[] dizi3 = { "50", "77", "34", "76", "45", "86", "97", "28", "19" };
            int sayilar;

            if (sayisayac == 1)
            {
                sayilar = rst.Next(0,dizi2.Length);
                dgr1 = (dizi2[sayilar]);
                btnSayı1.Text = dgr1.ToString();
                btnSayı1.Visible    = true;
            }
            if (sayisayac == 2)
            {
                sayilar = rst.Next(0, dizi2.Length);
                dgr2 = (dizi2[sayilar]);
                btnSayı2.Text = dgr2.ToString();
                btnSayı2.Visible = true;
            }
            if (sayisayac == 3)
            {
                sayilar = rst.Next(0, dizi2.Length);
                dgr3 = (dizi2[sayilar]);
                btnSayı3.Text = dgr3.ToString();
                btnSayı3.Visible = true;
            }
            if (sayisayac == 4)
            {
                sayilar = rst.Next(0, dizi2.Length);
                dgr4 = (dizi2[sayilar]);
                btnSayı4.Text = dgr4.ToString();
                btnSayı4.Visible = true;
            }
            if (sayisayac == 5)
            {
                sayilar = rst.Next(0, dizi2.Length);
                dgr5 = (dizi2[sayilar]);
                btnSayı5.Text = dgr5.ToString();
                btnSayı5.Visible = true;
            }
            if (sayisayac == 6)
            {
                sayilar = rst.Next(0, dizi3.Length);
                dgr6 = (dizi3[sayilar]);
                btnSayı6.Text = dgr6.ToString();
                btnSayı6.Visible = true;

                dgr7 = rst.Next(100, 500);
                btnSoru.Text = dgr7.ToString();
                btnSoru.Visible = true;
                btnEsit.Visible = true;
            }

        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            harfsayac= 0;
            sayisayac= 0;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            btnJoker.Visible = false;

            btnSayı1.Visible = false;
            btnSayı2.Visible = false;
            btnSayı3.Visible = false;
            btnSayı4.Visible = false;
            btnSayı5.Visible = false;
            btnSayı6.Visible = false;
            btnEsit.Visible = false;
            btnSoru.Visible = false;
        }
    }
}