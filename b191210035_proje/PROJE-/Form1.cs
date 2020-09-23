/*******************************************************************************
 **
 **
 **
 **
 **             ADI: Melek Selin UYSAL
 **             NUMARA: b191210035
 **             SINIFI: 1-C
 **             BOLUMU: Bilgisayar Mühendisligi
 **             ODEV: NDP PROJE ODEVİ
 **
 **
 **
 **
 **
 **
 **
 **
 *******************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJE_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = _bardak.Image;
          
        }
        //objeleri olusturdum.
        Domates _domates = new Domates();
        Salatalik _salatalik = new Salatalik();
        Sise _sise = new Sise();
        Bardak _bardak = new Bardak();
        Gazete _gazete = new Gazete();
        Cola _cola = new Cola();
        Salca _salca = new Salca();
        Dergi _dergi = new Dergi();
        OrganikAtik _organikAtik = new OrganikAtik();
        Kagit _kagit = new Kagit();
        Cam _cam = new Cam();
        Metal _metal = new Metal();

        //Kullacagim degiskenleri tanimladim.
        Bitmap[] pictures = new Bitmap[8];
        int sayi = 60;
        int sayac;
        public int kagitToplam;
        public int camToplam;
        public int metalToplam;
        public int organikAtikToplam;
        public int puan;
        //Random olarak resimleri çağırmak için fonksiyon olusturdum.
        public void resimGetir()
        {
            Random random = new Random();


            pictures[0] = new Bitmap("images//bardak.jpg");
            pictures[1] = new Bitmap("images//cola.jpg");
            pictures[2] = new Bitmap("images//sal.jpg");
            pictures[3] = new Bitmap("images//domates.jpg");
            pictures[4] = new Bitmap("images//gazete.jpg");
            pictures[5] = new Bitmap("images//dergi.jpg");
            pictures[6] = new Bitmap("images//salça.png");
            pictures[7] = new Bitmap("images//şişe.jpg");
            for (int i = 0; i <= 7; i++)
            {
                pictureBox1.Image =  pictures[random.Next(0, 7)];
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            resimGetir();   
            timer1.Enabled = true;

            //Süre sifirlandiğinde tekrar oyunun başa dönmesini kontrol ettim.
            if(sayac==0)
            {
                sayi = 60;
                puan = 0;
                label4.Text = puan.ToString();
            }
            
            orgAtikTemizle();
            metalTemizle();
            kagitTemizle();
            camTemizle(); 
            //Butonları kullanilabilir duruma getirdim.
            organikAtikbtn.Enabled = true;
            camBtn.Enabled = true;
            kagitBtn.Enabled = true;
            metalBtn.Enabled = true;

        }
    
        private void timer1_Tick(object sender, EventArgs e)
        { 
            //Sayaci olusturdum.
            if (sayi >= 0)
            {
                timer1.Interval = 1000;
                timer1.Enabled = true;
                sayac = sayi--;
                label2.Text = sayac.ToString();//label2'ye sayaci yazdirdim.
                if (sayac > 0)
                {
                    button1.Enabled = false;
                }
                else
                {
                    button1.Enabled = true;             
                }
            }
      
        }
        public void organikAtikEkle()
        {
            if (sayac > 0) 
            {
                //Picturebox'daki resime göre organik atiklarin listboxlara eklenmesini sagladim. 
                if (pictureBox1.Image == pictures[2])
                {
                    listBox1.Items.Add("Salatalik (120)");
                    organikAtikToplam = organikAtikToplam + _salatalik.Hacim; //Resim kontrolüne göre organik atik degerini artirdim.
                    label6.Text = Convert.ToString(organikAtikToplam);
                    puan = puan + _salatalik.Hacim; //Resim konrtrolüne göre puan kısmına hacmi ekledim.
                    label4.Text = Convert.ToString(puan);
                }
                if (pictureBox1.Image == pictures[3])
                {
                    listBox1.Items.Add("Domates (150)");
                    organikAtikToplam = organikAtikToplam + _domates.Hacim; //Resim kontrolüne göre organik atik degerini artirdim.
                    label6.Text = Convert.ToString(organikAtikToplam);
                    puan = puan + _domates.Hacim;//Resim konrtrolüne göre puan kismina hacmi ekledim.
                    label4.Text = Convert.ToString(puan);
                }

                //Eger gelen resim organik atiklardan biriyse tekrar resmin gelebilmesini kontrol ettim.
                if (pictureBox1.Image == pictures[2] || pictureBox1.Image == pictures[3])
                {
                    resimGetir();
                }
                //Kapasiteye göre butonu kontrol ettim.
                if (_organikAtik.kapasite <= organikAtikToplam)
                {
                    organikAtikbtn.Enabled = false;
                }
                if (organikAtikToplam < _organikAtik.kapasite)
                {
                    progressBar1.Value = organikAtikToplam; //Progressbar'ın değerini esitledim.
                }
            }
        }

        //organikAtikEkle fonksiyonuna yaptigim kontrolleri kagitEkle fonksiyonuna uyarladim.
        public void kagitEkle()
        {
           
            if (sayac > 0)
            { 
                if (pictureBox1.Image == pictures[4])
                {
                    listBox2.Items.Add("Gazete (250)");
                    kagitToplam = kagitToplam + _gazete.Hacim;
                    label7.Text = Convert.ToString(kagitToplam);
                    puan = puan + _gazete.Hacim;
                    label4.Text = Convert.ToString(puan);
                }
                if (pictureBox1.Image == pictures[5])
                {
                    listBox2.Items.Add("Dergi (200)");
                    kagitToplam = kagitToplam + _dergi.Hacim;
                    label7.Text = Convert.ToString(kagitToplam);
                    puan = puan + _dergi.Hacim;
                    label4.Text = Convert.ToString(puan);
                }
        
                if (pictureBox1.Image == pictures[4] || pictureBox1.Image == pictures[5])
                {
                    resimGetir();
                }
           
                if (_kagit.kapasite <= kagitToplam)
                {
                    kagitBtn.Enabled = false;
                }

                if (kagitToplam < _kagit.kapasite)
                {
                    progressBar2.Value = kagitToplam;
                }
            }
        }
      
        //organikAtikEkle fonksiyonuna yaptigim kontrolleri camEkle fonksiyonuna uyarladim.
        private void camEkle()
        {
            if (sayac > 0)
            {
                if (pictureBox1.Image == pictures[0])
                {
                    listBox3.Items.Add("Bardak (250)");
                    camToplam = camToplam + _bardak.Hacim;
                    label8.Text = Convert.ToString(camToplam);
                    puan = puan + _bardak.Hacim;
                    label4.Text = Convert.ToString(puan);
                }
                if (pictureBox1.Image == pictures[7])
                {
                    listBox3.Items.Add("Sise (600)");
                    camToplam = camToplam + _sise.Hacim;
                    label8.Text = Convert.ToString(camToplam);
                    puan = puan + _sise.Hacim;
                    label4.Text = Convert.ToString(puan);

                }

                if (pictureBox1.Image == pictures[0] || pictureBox1.Image == pictures[7])
                {
                    resimGetir();
                }
                if (_cam.kapasite <= camToplam)
                {
                    camBtn.Enabled = false;
                }
                if (camToplam < _cam.kapasite)
                {
                    progressBar3.Value = camToplam;
                }
            }
        }

        //organikAtikEkle fonksiyonuna yaptigim kontrolleri metalEkle fonksiyonuna uyarladim.
        public void metalEkle()
        {

            if (sayac > 0)
            {
                if (pictureBox1.Image == pictures[1])
                {
                    listBox4.Items.Add("Kola Kutusu (350)");
                    metalToplam = metalToplam + _cola.Hacim;
                    label9.Text = Convert.ToString(metalToplam);
                    puan = puan + _cola.Hacim;
                    label4.Text = Convert.ToString(puan);
                }
                if (pictureBox1.Image == pictures[6])
                {
                    listBox4.Items.Add("Salca Kutusu (550)");
                    metalToplam = metalToplam + _salca.Hacim;
                    label9.Text = Convert.ToString(metalToplam);
                    puan = puan + _salca.Hacim;
                    label4.Text = Convert.ToString(puan);
                }

                if (pictureBox1.Image == pictures[1] || pictureBox1.Image == pictures[6])
                {
                    resimGetir();
                }
                if (_metal.kapasite <= metalToplam)
                {
                    metalBtn.Enabled = false;
                }

                if (metalToplam < _metal.kapasite)
                {
                    progressBar4.Value = metalToplam;
                }
            }
        }
        //Butonlarda ekle fonksiyonlarini cagirdim.
        private void organikAtikbtn_Click(object sender, EventArgs e)
        {

            organikAtikEkle(); 
        }

        private void kagitBtn_Click(object sender, EventArgs e)
        {
            kagitEkle();
        }
        private void camBtn_Click(object sender, EventArgs e)
        {
            camEkle();
        }

        private void metalBtn_Click(object sender, EventArgs e)
        {
            metalEkle();
        }
       
        public void orgAtikTemizle()
        {
           
            bosaltBtn1.Enabled = true; //bosalt butonunu kullanilir hale getirdim.
            listBox1.Items.Clear();//organik atiklari ekleyen listbox'ı temizledim.
            label6.Text = string.Empty;// organik atik toplami yazdiran label temizledim.
            organikAtikToplam = 0; //organik atik toplami sifirladim.
            progressBar1.Value = 0;//progressbari sifirladim.
        }
        //orgAtikTemizle fonksiyonunu kagit icin uyarladim.
        public void kagitTemizle()
        {

            bosaltBtn2.Enabled = true;
            listBox2.Items.Clear();
            label7.Text = string.Empty;
            kagitToplam = 0;
            progressBar2.Value = 0;

        }
        //orgAtikTemizle fonksiyonunu cam icin uyarladim.
        public void camTemizle()
        {

            bosaltBtn3.Enabled = true;
            listBox3.Items.Clear();
            label8.Text = string.Empty;
            camToplam = 0;
            progressBar3.Value = 0;

        }
        //orgAtikTemizle fonksiyonunu metal icin uyarladim.
        public void metalTemizle()
        {
            bosaltBtn4.Enabled = true;
            listBox4.Items.Clear();
            label9.Text = string.Empty;
            metalToplam = 0;
            progressBar4.Value = 0;
        }
        // bosalt butonlari için eklenicek sürenin fonksiyonu
        public void süreEkle()
        {
            sayac = sayac + 3;
            sayi = sayi + 3;
            label2.Text = sayac.ToString();
        }
        private void bosaltBtn1_Click(object sender, EventArgs e)
        {
            if (sayac > 0)
            {
                if (organikAtikToplam > ((_organikAtik.kapasite) * 0.75)) // bosaltabilme durumunu kontrol etiim.
                {
                    orgAtikTemizle(); // butona basinca organik atiklari temizlettim.
                    organikAtikbtn.Enabled = true;
                    süreEkle(); // süre eklendi.
                }
            }
        }
        //organik atik bosalt butonunu kagit bosalt butonuna uyarladim.
        private void bosaltBtn2_Click(object sender, EventArgs e)
        {
            if (sayac > 0)
            {
                if (kagitToplam > ((_kagit.kapasite) * 0.75))
                {
                    kagitTemizle();

                    kagitBtn.Enabled = true;
                    puan = puan + 1000;
                    label4.Text = Convert.ToString(puan);
                    süreEkle();
                }
            }
        }
        //organik atik bosalt butonunu cam bosalt butonuna uyarladim.
        private void bosaltBtn3_Click(object sender, EventArgs e)
        {
            if (sayac > 0)
            {
                if (camToplam > ((_cam.kapasite) * 0.75))
                {
                    camTemizle();


                    camBtn.Enabled = true;
                    puan = puan + 600;
                    label4.Text = Convert.ToString(puan);
                    süreEkle();
                }
            }
        }
        //organik atik bosalt butonunu metal bosalt butonuna uyarladim.
        private void bosaltBtn4_Click(object sender, EventArgs e)
        {
            if (sayac > 0)
            {
                if (metalToplam > ((_metal.kapasite) * 0.75))
                {

                    metalTemizle();

                    metalBtn.Enabled = true;
                    puan = puan + 800;
                    label4.Text = Convert.ToString(puan);
                    süreEkle();
                }
            }
        }
        //cikis butonuyla ekrandan cikisi sagladim.
        private void cikisBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
