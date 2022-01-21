/********************************************************************************************************************
 * *                                      SAKARYA ÜNİVERSİTESİ
 *                                     BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
 *                                     BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
 *                                     NESNEYE DAYALI PROGRAMLAMA DERSİ
 *                                     2019-2020 BAHAR DÖNEMİ
 *                                     
 *                                     
 *                                     
 *                                     ÖDEV NUMARASI....:BAHAR DÖNEMİ PROJE ÖDEVİ
 *                                     ÖĞRENCİ ADI ....:Furkan KARAMA
 *                                     ÖĞRENCİ NUMARASI....:G191210073
 *                                     DERSİN ALINDIĞI GRUP....:B GRUBU 2. ÖĞRETİM
 * 
 * ******************************************************************************************************************/




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDProje
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            int deger = int.Parse(labsayac.Text);//label'in icinde ki string degeri int degere cevirdik.
            deger--;//cevirdigimiz degeri saniyede 1 kere azalttik.
            labsayac.Text = deger.ToString();//bu degeri labela atadik ve geri sayim yapan bir sayacimiz oldu.
            if(deger==0)//sayac 0'a geldiginde asagıdakiler olsun diye
            {
                timer1.Enabled = false;//sayaci durdurduk
                butcam.Enabled = false;//bu tusu islevsiz biraktik
                butcambos.Enabled = false;//bu tusu islevsiz biraktik
                butmetal.Enabled = false;//bu tusu islevsiz biraktik
                butmetalbos.Enabled = false;//bu tusu islevsiz biraktik
                butorganik.Enabled = false;//bu tusu islevsiz biraktik
                butorganikbos.Enabled = false;//bu tusu islevsiz biraktik
                butkagit.Enabled = false;//bu tusu islevsiz biraktik
                butkagitbos.Enabled = false;//bu tusu islevsiz biraktik

            }
        }
        private void butyenioyun_Click(object sender, EventArgs e)
        {
            barcam.Value = 0;//Her yeni oyunda 0'dan baslasin diye.
            barkagit.Value = 0;//Her yeni oyunda 0'dan baslasin diye.
            barmetal.Value = 0;//Her yeni oyunda 0'dan baslasin diye.
            barorganik.Value = 0;//Her yeni oyunda 0'dan baslasin diye.
            listcam.Items.Clear();//Her yeni oyunda liste temizlensin diye.
            listmetal.Items.Clear();//Her yeni oyunda liste temizlensin diye.
            listorganik.Items.Clear();//Her yeni oyunda liste temizlensin diye.
            listkagit.Items.Clear();//Her yeni oyunda liste temizlensin diye.
            labpuan.Text = "0";//Yeni oyuna baslandiginda puan sifirlansin diye.
            labsayac.Text = 60.ToString();//sayac 60'dan baslasin diye.
            butcam.Enabled = true;//oyuna baslandiginda tuslar islev kazansin diye.
            butcambos.Enabled = true;//oyuna baslandiginda tuslar islev kazansin diye.
            butmetal.Enabled = true;//oyuna baslandiginda tuslar islev kazansin diye.
            butmetalbos.Enabled = true;//oyuna baslandiginda tuslar islev kazansin diye.
            butorganik.Enabled = true;//oyuna baslandiginda tuslar islev kazansin diye.
            butorganikbos.Enabled = true;//oyuna baslandiginda tuslar islev kazansin diye.
            butkagit.Enabled = true;//oyuna baslandiginda tuslar islev kazansin diye.
            butkagitbos.Enabled = true;//oyuna baslandiginda tuslar islev kazansin diye.
            timer1.Enabled = true;//Yeni oyuna baslayinca yeniden saniye geri aksin diye.
            int number;

            Random random = new Random();

            number = random.Next(1, 9);//1 ve 8 arasinda rastgele bir sayi sectirerek her sayiyla bir resmi eslestirip pictureboxa rastgele resim gelmesini sagladim.

            if (number==1)//Gelen random sayi 1'e eşit ise bu secenegin icine giriyor.
            {
                pictureBox1.Tag = "organikd";//Eger gelen domates ise picturebox'ın etiketini organikd yapiyoruz.
                domates domat = new domates();//Domates sinifindan yeni bir nesne tanimladik.
                pictureBox1.Image = domat.Image;//Domates fotografini koydurduk.
            }
            else if (number==2)//Gelen random sayi 2'ye esit ise bu secenege giriyor.
            {
                pictureBox1.Tag = "organiks";//Eger gelen salatalik ise picturebox'ın etiketini organiks yapiyoruz.
                salatalik salat = new salatalik();//Salatalik sinifindan yeni bir nesne tanimladik.
                pictureBox1.Image = salat.Image;//Salat fotografini koydurduk.
            }
            else if(number==3)//Gelen random sayi 3'ye esit ise bu secenege giriyor.
            {
                pictureBox1.Tag = "kagitg";//Eger gelen gazete ise picturebox'ın etiketini kagitg yapiyoruz.
                gazete gazet = new gazete();//Gazete sinifindan yeni bir nesne tanimladik.
                pictureBox1.Image = gazet.Image;//gazete fotografini koydurduk.
            }
            else if(number==4)//Gelen random sayi 4'ye esit ise bu secenege giriyor.
            {
                pictureBox1.Tag = "kagitd";//Eger gelen dergi ise picturebox'ın etiketini kagitd yapiyoruz.
                dergi derg = new dergi();//Dergi sinifindan yeni bir nesne tanimladik.
                pictureBox1.Image = derg.Image;//dergi fotografini koydurduk.
            }
            else if(number==5)//Gelen random sayi 5'ye esit ise bu secenege giriyor.
            {
                pictureBox1.Tag = "camb";//Eger gelen cam bardak ise picturebox'ın etiketini camb yapiyoruz.
                cambardak bardak = new cambardak();//Cambardak sinifindan yeni bir nesne tanimladik.
                pictureBox1.Image = bardak.Image;//bardak fotografini koydurduk.
            }
            else if(number==6)//Gelen random sayi 6'ye esit ise bu secenege giriyor.
            {
                pictureBox1.Tag = "cams";//Eger gelen cam sise ise picturebox'ın etiketini cams yapiyoruz.
                camsise sise = new camsise();//Camsise sinifindan yeni bir nesne tanimladik.
                pictureBox1.Image = sise.Image;//sise fotografini koydurduk.
            }
            else if(number==7)//Gelen random sayi 7'ye esit ise bu secenege giriyor.
            {
                pictureBox1.Tag = "metals";//Eger gelen salca kutusu ise picturebox'ın etiketini camb yapiyoruz.
                salcakutu salca = new salcakutu();//Salcakutu sinifindan yeni bir nesne tanimladik.
                pictureBox1.Image = salca.Image;//Salca kutusu fotografini koyduk.
            }
            else if(number==8)//Gelen random sayi 8'ye esit ise bu secenege giriyor.
            {
                pictureBox1.Tag = "metalk";//Eger gelen kola kutusu ise picturebox'ın etiketini metalk yapiyoruz.
                kola cola = new kola();//Kola sinifindan yeni bir nesne tanimladik.
                pictureBox1.Image = cola.Image;//Kola kutusu fotografini koyduk.
            }
            
        }

        public interface IAtik
        {
            int Hacim { get; }//Atiklarin hacimlerini belirleyebilmek icin.
            System.Drawing.Image Image { get; }//Atiklarin resimlerini belirleyebilmek icin.
        }
        public interface IAtikKutusu : IDolabilen
        {
            /// <summary>
            /// Atık kutusu boşaltıldığında oyun puanına kaç puan ekleneceğini döndürür.
            /// </summary>
            int BosaltmaPuani { get; }//Atik kutulari bosaltildiginda kac puan gelecegini belirlemek icin.
            /// <summary>
            /// Atık kutusunda gönderilen atığı alacak kadar boş yer varsa atığı kutuya ekler.
            /// </summary>
            /// <param name="atik">Eklenecek Atık</param>
            /// <returns>Atığın kutuya eklenip eklenmediğini döndürür.</returns>
            void Ekle(Form1 fr);

            /// <summary>
            /// Atık kutusunun doluluk oranı %75'in üstündeyse atık kutusunu boşaltır.
            /// </summary>
            /// <returns>Atık kutusunun boşaltılıp boşaltılmadığını döndürür.</returns>
            void Bosalt(Form1 fr);
        }
        public interface IDolabilen
        {
            int Kapasite { get; set; }//Atik kutusunun kapasitesi belirlenebilsin diye.
            int DoluHacim { get; }
            int DolulukOrani { get; }//Doluluk orani nereye ulastiginda bosaltılacagini belirlemek icin.
        }
        public class organik : IAtikKutusu
        {
            public int BosaltmaPuani => (0);//Organik kutusu bosaltildiginda 0 puan gelsin diye.

            public int Kapasite { get => (700); set => value=(700); }//Kapasitesini 700 olarak belirledik.

            public int DoluHacim => throw new NotImplementedException();

            public int DolulukOrani => (525);//Doluluk oranini 525 olarak belirledik.

            public void Bosalt(Form1 fr)
            {
                if(fr.barorganik.Value>DolulukOrani && Convert.ToInt32(fr.labsayac.Text) > 0)//süre bitti mi diye bakiyoruz sonra gerekli doluluk oranina ulasti mi diye bakiyoruz
                {
                    int puan = Convert.ToInt32(fr.labpuan.Text);
                    puan = puan + BosaltmaPuani;//kutu bosaltildiginda kutunun puanini puana ekliyoruz.

                    fr.labpuan.Text = Convert.ToString(puan);
                    fr.barorganik.Value = 0;//Bari sifirliyoruz.
                    int sure = Convert.ToInt32(fr.labsayac.Text);
                    sure = sure + 3;//Sureye 3 saniye ekliyoruz.
                    fr.labsayac.Text = Convert.ToString(sure);

                }
            }

            public void Ekle(Form1 fr)
            {
                if (fr.pictureBox1.Tag == fr.butorganik.Tag && fr.barorganik.Maximum - fr.barorganik.Value >= 120 && Convert.ToInt32(fr.labsayac.Text) > 0)//Gelen fotograf ile nesne eslesiyor mu diye bakiyoruz sonra yeterli alan kutuda var mi diye bakiyoruz ve son olarak saniyenin yeterli olup olmadigini kontrol ettik.
                {
                    int number;

                    Random random = new Random();

                    number = random.Next(1, 9);//1 ve 8 arasinda rastgele bir sayi sectirerek her sayiyla bir resmi eslestirip pictureboxa rastgele resim gelmesini sagladim.
                    salatalik salat = new salatalik();//salatalik sinifindan yeni bir nesne tanimladik
                    if (number == 1)//Gelen random sayi 1'e eşit ise bu secenegin icine giriyor.
                    {
                        fr.pictureBox1.Tag = "organikd";//Eger gelen domates ise picturebox'ın etiketini organikd yapiyoruz.
                        domates domat = new domates();//domates sinifindan yeni bir nesne tanimladik
                        fr.pictureBox1.Image = domat.Image;//domates fotografini koyduk
                    }
                    else if (number == 2)
                    {
                        fr.pictureBox1.Tag = "organiks";//Eger gelen salatalik ise picturebox'ın etiketini organiks yapiyoruz.

                        fr.pictureBox1.Image = salat.Image;//salatalik fotografini koyduk
                    }
                    else if (number == 3)
                    {
                        fr.pictureBox1.Tag = "kagitg";//Eger gelen gazete ise picturebox'ın etiketini kagitg yapiyoruz.
                        gazete gazet = new gazete();//gazete sinifindan yeni bir nesne tanimladik
                        fr.pictureBox1.Image = gazet.Image;//gazete fotografini koyduk
                    }
                    else if (number == 4)
                    {
                        fr.pictureBox1.Tag = "kagitd";//Eger gelen dergi ise picturebox'ın etiketini kagitd yapiyoruz.
                        dergi derg = new dergi();//dergi sinifindan yeni bir nesne tanimladik
                        fr.pictureBox1.Image = derg.Image;//dergi fotografini koyduk
                    }
                    else if (number == 5)
                    {
                        fr.pictureBox1.Tag = "camb";//Eger gelen cam bardak ise picturebox'ın etiketini camb yapiyoruz.
                        cambardak bardak = new cambardak();//cambardak sinifindan yeni bir nesne tanimladik
                        fr.pictureBox1.Image = bardak.Image;//bardak fotografini koyduk
                    }
                    else if (number == 6)
                    {
                        fr.pictureBox1.Tag = "cams";//Eger gelen cam sise ise picturebox'ın etiketini cams yapiyoruz.
                        camsise sise = new camsise();//camsise sinifindan yeni bir nesne tanimladik
                        fr.pictureBox1.Image = sise.Image;//sise fotografini koyduk
                    }
                    else if (number == 7)
                    {
                        fr.pictureBox1.Tag = "metals";//Eger gelen salca kutusu ise picturebox'ın etiketini metals yapiyoruz.
                        salcakutu salca = new salcakutu();//salcakutu sinifindan yeni bir nesne tanimladik
                        fr.pictureBox1.Image = salca.Image;//salca fotografini koyduk
                    }
                    else if (number == 8)
                    {
                        fr.pictureBox1.Tag = "metalk";//Eger gelen kola kutusu ise picturebox'ın etiketini metalk yapiyoruz.
                        kola cola = new kola();//kola sinifindan yeni bir nesne tanimladik
                        fr.pictureBox1.Image = cola.Image;//kola fotografini koyduk
                    }
                    fr.listorganik.Items.Add("Salatalik(120)");//listeye salatalik yazdirdik
                    fr.barorganik.Value = fr.barorganik.Value + salat.Hacim;//bari salataligin hacmi kadar arttirdik
                    int puan = Convert.ToInt32(fr.labpuan.Text);
                    puan = puan + salat.Hacim;//salatanin puanini puana ekledik
                    fr.labpuan.Text = Convert.ToString(puan);

                }
                else if (fr.pictureBox1.Tag == fr.listorganik.Tag && fr.barorganik.Maximum - fr.barorganik.Value >= 150 && Convert.ToInt32(fr.labsayac.Text) > 0)//Gelen fotograf ile nesne eslesiyor mu diye bakiyoruz sonra yeterli alan kutuda var mi diye bakiyoruz ve son olarak saniyenin yeterli olup olmadigini kontrol ettik.
                {
                    int number;//bir int sayi olusturduk

                    Random random = new Random();

                    number = random.Next(1, 9);//1 ve 8 arasinda rastgele bir sayi sectirerek her sayiyla bir resmi eslestirip pictureboxa rastgele resim gelmesini sagladim.
                    domates domat = new domates();//domates sinifindan yeni bir nesne tanimladik
                    if (number == 1)//Gelen random sayi 1'e eşit ise bu secenegin icine giriyor.
                    {
                        fr.pictureBox1.Tag = "organikd";//Eger gelen domates ise picturebox'ın etiketini organikd yapiyoruz.

                        fr. pictureBox1.Image = domat.Image;//domates fotografini koyduk
                    }
                    else if (number == 2)
                    {
                       fr. pictureBox1.Tag = "organiks";//Eger gelen salatalik ise picturebox'ın etiketini organiks yapiyoruz.
                        salatalik salat = new salatalik();//salatalik sinifindan yeni bir nesne tanimladik
                        fr. pictureBox1.Image = salat.Image;//salatalik fotografini koyduk
                    }
                    else if (number == 3)
                    {
                        fr.pictureBox1.Tag = "kagitg";//Eger gelen gazete ise picturebox'ın etiketini kagitg yapiyoruz.
                        gazete gazet = new gazete();//gazete sinifindan yeni bir nesne tanimladik
                        fr.pictureBox1.Image = gazet.Image;//gazete fotografini koyduk
                    }
                    else if (number == 4)
                    {
                       fr. pictureBox1.Tag = "kagitd";//Eger gelen dergi ise picturebox'ın etiketini kagitd yapiyoruz.
                        dergi derg = new dergi();//dergi sinifindan yeni bir nesne tanimladik
                        fr. pictureBox1.Image = derg.Image;//dergi fotografini koyduk
                    }
                    else if (number == 5)
                    {
                       fr. pictureBox1.Tag = "camb";//Eger gelen cam bardak ise picturebox'ın etiketini camb yapiyoruz.
                        cambardak bardak = new cambardak();//cambardaksinifindan yeni bir nesne tanimladik
                        fr.pictureBox1.Image = bardak.Image;//bardak fotografini koyduk
                    }
                    else if (number == 6)
                    {
                        fr.pictureBox1.Tag = "cams"; //Eger gelen cam sise ise picturebox'ın etiketini cams yapiyoruz
                        camsise sise = new camsise();//camsise sinifindan yeni bir nesne tanimladik
                        fr.pictureBox1.Image = sise.Image;//sise fotografini koyduk
                    }
                    else if (number == 7)
                    {
                        fr.pictureBox1.Tag = "metals";//Eger gelen salca kutu ise picturebox'ın etiketini metals yapiyoruz
                        salcakutu salca = new salcakutu();//salcakutu sinifindan yeni bir nesne tanimladik
                        fr.pictureBox1.Image = salca.Image;//salca fotografini koyduk
                    }
                    else if (number == 8)
                    {
                        fr.pictureBox1.Tag = "metalk";//Eger gelen kola kutusu ise picturebox'ın etiketini metalk yapiyoruz.
                        kola cola = new kola();//kola sinifindan yeni bir nesne tanimladik
                        fr.pictureBox1.Image = cola.Image;//kola fotografini koyduk
                    }
                    fr.listorganik.Items.Add("Domates(150)");//listeye domates yazdirdik
                    fr.barorganik.Value = fr.barorganik.Value + domat.Hacim;//bari domates hacmi kadar doldurduk
                    int puan = Convert.ToInt32(fr.labpuan.Text);
                    puan = puan + domat.Hacim;//domatesin puanini puana ekledik
                    fr.labpuan.Text = Convert.ToString(puan);
                }
            }
        }
        public class metal : IAtikKutusu
        {
            public int BosaltmaPuani => (800);//metal kutusu bosaltildiginda 800 puan gelsin diye.

            public int Kapasite { get => (2300); set => value= (2300); }//metal kutunun kapasitesini 2300 olarak belirledik.

            public int DoluHacim => throw new NotImplementedException();

            public int DolulukOrani => (1725);//doluluk oranini 1725 olarak belirledik.

            public void Bosalt(Form1 fr)//kutu bosaltilsin diye metot
            {
                if (fr.barmetal.Value > DolulukOrani&& Convert.ToInt32(fr.labsayac.Text) > 0)//süre bitti mi diye bakiyoruz sonra gerekli doluluk oranina ulasti mi diye bakiyoruz
                {
                    int puan = Convert.ToInt32(fr.labpuan.Text);
                    puan = puan + BosaltmaPuani;//kutu bosaltildiginda kutunun puanini puana ekliyoruz.

                    fr.labpuan.Text = Convert.ToString(puan);
                    fr.barmetal.Value = 0;//Bari sifirliyoruz.
                    int sure = Convert.ToInt32(fr.labsayac.Text);
                    sure = sure + 3;//Sureye 3 saniye ekliyoruz.
                    fr.labsayac.Text = Convert.ToString(sure);

                }
            }

            public void Ekle(Form1 fr)//kutuya nesne eklenebilsin diye metot
            {
                if (fr.pictureBox1.Tag == fr.butmetal.Tag && fr.barmetal.Maximum - fr.barmetal.Value >= 550 && Convert.ToInt32(fr.labsayac.Text) > 0)//Gelen fotograf ile nesne eslesiyor mu diye bakiyoruz sonra yeterli alan kutuda var mi diye bakiyoruz ve son olarak saniyenin yeterli olup olmadigini kontrol ettik.
                {
                    int number;

                    Random random = new Random();

                    number = random.Next(1, 9);//1 ve 8 arasinda rastgele bir sayi sectirerek her sayiyla bir resmi eslestirip pictureboxa rastgele resim gelmesini sagladim.
                    salcakutu salca = new salcakutu();//salcakutu sinifindan yeni bir nesne tanimladik
                    if (number == 1)//Gelen random sayi 1'e eşit ise bu secenegin icine giriyor.
                    {
                        fr.pictureBox1.Tag = "organikd";//Eger gelen domates ise picturebox'ın etiketini organikd yapiyoruz.
                        domates domat = new domates();//domates sinifindan yeni bir nesne tanimladik
                        fr.pictureBox1.Image = domat.Image;
                    }
                    else if (number == 2)//Gelen random sayi 2'e eşit ise bu secenegin icine giriyor.
                    {
                        fr.pictureBox1.Tag = "organiks";//Eger gelen salatalik ise picturebox'ın etiketini organiks yapiyoruz.
                        salatalik salat = new salatalik();//salatalik sinifindan yeni bir nesne tanimladik
                        fr.pictureBox1.Image = salat.Image;
                    }
                    else if (number == 3)//Gelen random sayi 3'e eşit ise bu secenegin icine giriyor.
                    {
                        fr.pictureBox1.Tag = "kagitg";//Eger gelen gazete ise picturebox'ın etiketini kagitg yapiyoruz.
                        gazete gazet = new gazete();//gazete sinifindan yeni bir nesne tanimladik
                        fr.pictureBox1.Image = gazet.Image;
                    }
                    else if (number == 4)//Gelen random sayi 4'e eşit ise bu secenegin icine giriyor.
                    {
                        fr.pictureBox1.Tag = "kagitd";//Eger gelen dergi ise picturebox'ın etiketini kagitd yapiyoruz.
                        dergi derg = new dergi();//dergi sinifindan yeni bir nesne tanimladik
                        fr.pictureBox1.Image = derg.Image;
                    }
                    else if (number == 5)//Gelen random sayi 5'e eşit ise bu secenegin icine giriyor.
                    {
                        fr.pictureBox1.Tag = "camb";//Eger gelen cam bardak ise picturebox'ın etiketini camb yapiyoruz.
                        cambardak bardak = new cambardak();//cambardak sinifindan yeni bir nesne tanimladik
                        fr.pictureBox1.Image = bardak.Image;
                    }
                    else if (number == 6)//Gelen random sayi 6'ya eşit ise bu secenegin icine giriyor.
                    {
                        fr.pictureBox1.Tag = "cams";//Eger gelen cam sise ise picturebox'ın etiketini cams yapiyoruz.
                        camsise sise = new camsise();//camsise sinifindan yeni bir nesne tanimladik
                        fr.pictureBox1.Image = sise.Image;
                    }
                    else if (number == 7)//Gelen random sayi 7'e eşit ise bu secenegin icine giriyor.
                    {
                        fr.pictureBox1.Tag = "metals";//Eger gelen salca kutu ise picturebox'ın etiketini metals yapiyoruz.

                        fr.pictureBox1.Image = salca.Image;
                    }
                    else if (number == 8)//Gelen random sayi 8'e eşit ise bu secenegin icine giriyor.
                    {
                        fr.pictureBox1.Tag = "metalk";//Eger gelen kola kutusu ise picturebox'ın etiketini metalk yapiyoruz.
                        kola cola = new kola();//kola sinifindan yeni bir nesne tanimladik
                        fr.pictureBox1.Image = cola.Image;
                    }
                    fr.listmetal.Items.Add("Salca Kutu(550)");//Gelen fotograf salca kutusu ise listeye salca kutusu yaziyor.
                    fr.barmetal.Value = fr.barmetal.Value + salca.Hacim;//progressbar salca hacmi kadar dolsun diye.
                    int puan = Convert.ToInt32(fr.labpuan.Text);//Labelda ki string degeri int degere atadik.
                    puan = puan + salca.Hacim;//bu int degere salcanin hacmini ekledik ve salcanin hacmi kadar puan arttirdik.
                    fr.labpuan.Text = Convert.ToString(puan);//bu int puan degerini yeniden stringe cevirip puan labelina atadik.
                }
                else if (fr.pictureBox1.Tag == fr.listmetal.Tag && fr.barmetal.Maximum - fr.barmetal.Value >= 350 && Convert.ToInt32(fr.labsayac.Text) > 0)//Gelen fotograf ile nesne eslesiyor mu diye bakiyoruz sonra yeterli alan kutuda var mi diye bakiyoruz ve son olarak saniyenin yeterli olup olmadigini kontrol ettik.
                {
                    int number;

                    Random random = new Random();

                    number = random.Next(1, 9);//1 ve 8 arasinda rastgele bir sayi sectirerek her sayiyla bir resmi eslestirip pictureboxa rastgele resim gelmesini sagladim.
                    kola cola = new kola();//kola sinifindan yeni bir nesne tanimladik
                    if (number == 1)//Gelen random sayi 1'e eşit ise bu secenegin icine giriyor.
                    {
                        fr.pictureBox1.Tag = "organikd";//Eger gelen domates ise picturebox'ın etiketini organikd yapiyoruz.
                        domates domat = new domates();//domates sinifindan yeni bir nesne tanimladik
                        fr.pictureBox1.Image = domat.Image;//domates fotografini koyduk
                    }
                    else if (number == 2)
                    {
                        fr.pictureBox1.Tag = "organiks";//Eger gelen salatalik ise picturebox'ın etiketini organiks yapiyoruz.
                        salatalik salat = new salatalik();//salatalik sinifindan yeni bir nesne tanimladik
                        fr.pictureBox1.Image = salat.Image;//salatalik fotografini koyduk
                    }
                    else if (number == 3)
                    {
                        fr.pictureBox1.Tag = "kagitg";//Eger gelen gazete ise picturebox'ın etiketini kagitg yapiyoruz.
                        gazete gazet = new gazete();//gazete sinifindan yeni bir nesne tanimladik
                        fr.pictureBox1.Image = gazet.Image;//gazete fotografini koyduk
                    }
                    else if (number == 4)
                    {
                        fr.pictureBox1.Tag = "kagitd";//Eger gelen dergi ise picturebox'ın etiketini kagitd yapiyoruz.
                        dergi derg = new dergi();//dergi sinifindan yeni bir nesne tanimladik
                        fr.pictureBox1.Image = derg.Image;//dergi fotografini koyduk
                    }
                    else if (number == 5)
                    {
                        fr.pictureBox1.Tag = "camb";//Eger gelen cam bardak ise picturebox'ın etiketini camb yapiyoruz.
                        cambardak bardak = new cambardak();//cambardak sinifindan yeni bir nesne tanimladik
                        fr.pictureBox1.Image = bardak.Image;//bardak fotografini koyduk
                    }
                    else if (number == 6)
                    {
                        fr.pictureBox1.Tag = "cams";//Eger gelen cam sise ise picturebox'ın etiketini cams yapiyoruz.
                        camsise sise = new camsise();//camsise sinifindan yeni bir nesne tanimladik
                        fr.pictureBox1.Image = sise.Image;//sise fotografini koyduk
                    }
                    else if (number == 7)
                    {
                        fr.pictureBox1.Tag = "metals";//Eger gelen salca kutusu ise picturebox'ın etiketini metals yapiyoruz.
                        salcakutu salca = new salcakutu();//salcakutu sinifindan yeni bir nesne tanimladik
                        fr.pictureBox1.Image = salca.Image;//salca fotografini koyduk
                    }
                    else if (number == 8)
                    {
                        fr.pictureBox1.Tag = "metalk";//Eger gelen kola kutusu ise picturebox'ın etiketini metalk yapiyoruz.

                        fr.pictureBox1.Image = cola.Image;//kola fotografini koyduk
                    }
                    fr.listmetal.Items.Add("Kola Kutusu(350)");//listeye kola kutusu yazdirdik
                    fr.barmetal.Value = fr.barmetal.Value + cola.Hacim;//kola kutusu kadar bari cogaltiyoruz
                    int puan = Convert.ToInt32(fr.labpuan.Text);
                    puan = puan + cola.Hacim;//puana kolanin puanini ekliyoruz
                    fr.labpuan.Text = Convert.ToString(puan);
                }
            }
        }
        public class cam : IAtikKutusu
        {
            public int BosaltmaPuani => (600);//cam kutusu bosaltildiginda 600 puan gellsin diye.

            public int Kapasite { get => (2200); set => value=(2200); }//cam kutusunun kapasitesini 2200 olarak belirledik.

            public int DoluHacim => throw new NotImplementedException();

            public int DolulukOrani => (1650);//cam kutusunun doluluk oranini 1650 olarak belirledik.

            public void Bosalt(Form1 fr)//kutuyu bosaltmak icin metot
            {
                if (fr.barcam.Value > DolulukOrani&& Convert.ToInt32(fr.labsayac.Text) > 0)//süre bitti mi diye bakiyoruz sonra gerekli doluluk oranina ulasti mi diye bakiyoruz
                {
                    int puan = Convert.ToInt32(fr.labpuan.Text);
                    puan = puan + BosaltmaPuani;//kutu bosaltildiginda kutunun puanini puana ekliyoruz.

                    fr.labpuan.Text = Convert.ToString(puan);
                    fr.barcam.Value = 0;//Bari sifirliyoruz.
                    int sure = Convert.ToInt32(fr.labsayac.Text);
                    sure = sure + 3;//Sureye 3 saniye ekliyoruz.
                    fr.labsayac.Text = Convert.ToString(sure);

                }
            }

            public void Ekle(Form1 fr)//kutuya nesneyi ekleyecek metot
            {
                if (fr.pictureBox1.Tag == fr.butcam.Tag && fr.barcam.Maximum - fr.barcam.Value >= 250&& Convert.ToInt32(fr.labsayac.Text) > 0)//Gelen fotograf ile nesne eslesiyor mu diye bakiyoruz sonra yeterli alan kutuda var mi diye bakiyoruz ve son olarak saniyenin yeterli olup olmadigini kontrol ettik.
                {
                    int number;

                    Random random = new Random();

                    number = random.Next(1, 9);//1 ve 8 arasinda rastgele bir sayi sectirerek her sayiyla bir resmi eslestirip pictureboxa rastgele resim gelmesini sagladim.
                    cambardak bardak = new cambardak();//cambardak sinifindan yeni bir nesne tanimladik
                    if (number == 1)//Gelen random sayi 1'e eşit ise bu secenegin icine giriyor.
                    {
                        fr.pictureBox1.Tag = "organikd";//Eger gelen domates ise picturebox'ın etiketini organikd yapiyoruz.
                        domates domat = new domates();//domates sinifindan yeni bir nesne tanimladik
                        fr.pictureBox1.Image = domat.Image;//domates fotografini koyduk
                    }
                    else if (number == 2)//Gelen random sayi 2'e eşit ise bu secenegin icine giriyor.
                    {
                        fr.pictureBox1.Tag = "organiks";//Eger gelen salatalik ise picturebox'ın etiketini organiks yapiyoruz.
                        salatalik salat = new salatalik();//salatalik sinifindan yeni bir nesne tanimladik
                        fr.pictureBox1.Image = salat.Image;//salatalik fotografini koyduk
                    }
                    else if (number == 3)//Gelen random sayi 3'e eşit ise bu secenegin icine giriyor.
                    {
                        fr.pictureBox1.Tag = "kagitg";//Eger gelen gazete ise picturebox'ın etiketini kagitg yapiyoruz.
                        gazete gazet = new gazete();//gazete sinifindan yeni bir nesne tanimladik
                        fr.pictureBox1.Image = gazet.Image;//gazete fotografini koyduk
                    }
                    else if (number == 4)//Gelen random sayi 4'e eşit ise bu secenegin icine giriyor.
                    {
                        fr.pictureBox1.Tag = "kagitd";//Eger gelen dergi ise picturebox'ın etiketini kagitd yapiyoruz.
                        dergi derg = new dergi();//dergi sinifindan yeni bir nesne tanimladik
                        fr.pictureBox1.Image = derg.Image;//dergifotografini koyduk
                    }
                    else if (number == 5)//Gelen random sayi 5'e eşit ise bu secenegin icine giriyor.
                    {
                        fr.pictureBox1.Tag = "camb";//Eger gelen cam bardak ise picturebox'ın etiketini camb yapiyoruz.

                        fr.pictureBox1.Image = bardak.Image;//bardak fotografini koyduk
                    }
                    else if (number == 6)//Gelen random sayi 6'ya eşit ise bu secenegin icine giriyor.
                    {
                        fr.pictureBox1.Tag = "cams";//Eger gelen cam sise ise picturebox'ın etiketini cams yapiyoruz.
                        camsise sise = new camsise();//camsise sinifindan yeni bir nesne tanimladik.
                        fr.pictureBox1.Image = sise.Image;//cam sise fotografini koyduk
                    }
                    else if (number == 7)//Gelen random sayi 7'e eşit ise bu secenegin icine giriyor.
                    {
                        fr.pictureBox1.Tag = "metals";//Eger gelen salca kutusu ise picturebox'ın etiketini metals yapiyoruz.
                        salcakutu salca = new salcakutu();//salcakutu su sinifindan yeni nesne tanimladik.
                        fr.pictureBox1.Image = salca.Image;//salca kutusu koyuyoruz
                    }
                    else if (number == 8)//Gelen random sayi 8'e eşit ise bu secenegin icine giriyor.
                    {
                        fr.pictureBox1.Tag = "metalk";//Eger gelen kola kutusu ise picturebox'ın etiketini metalk yapiyoruz.
                        kola cola = new kola();//kola sinifindan yeni nesne tanimladik.
                        fr.pictureBox1.Image = cola.Image;//kolanin fotografini koyuyoruz
                    }
                    fr.listcam.Items.Add("Cam Bardak(250)");//listeye cam bardak yazdiriyoruz
                    fr.barcam.Value = fr.barcam.Value + bardak.Hacim;////bari bardak hacmi kadar dolduruyoruz
                    int puan = Convert.ToInt32(fr.labpuan.Text);
                    puan = puan + bardak.Hacim;//bardagin puanini ekliyoruz.
                    fr.labpuan.Text = Convert.ToString(puan);
                }


                else if (fr.pictureBox1.Tag == fr.listcam.Tag && fr.barcam.Maximum - fr.barcam.Value >= 600&& Convert.ToInt32(fr.labsayac.Text) > 0)// Gelen fotograf ile nesne eslesiyor mu diye bakiyoruz sonra yeterli alan kutuda var mi diye bakiyoruz ve son olarak saniyenin yeterli olup olmadigini kontrol ettik.
                {
                    int number;//bir int sayi tanimladik

                    Random random = new Random();

                    number = random.Next(1, 9);//1 ve 8 arasinda rastgele bir sayi sectirerek her sayiyla bir resmi eslestirip pictureboxa rastgele resim gelmesini sagladim.
                    camsise sise = new camsise();//cam sise sinifindan yeni bir nesne tanimladik.
                    if (number == 1)//Gelen random sayi 1'e eşit ise bu secenegin icine giriyor.
                    {
                        fr.pictureBox1.Tag = "organikd";//Eger gelen domates ise picturebox'ın etiketini organikd yapiyoruz.
                        domates domat = new domates();//domates sinifindan yeni bir nesne tanimladik.
                        fr.pictureBox1.Image = domat.Image;//Domates fotografini koyduk
                    }
                    else if (number == 2)//Gelen random sayi 2'e eşit ise bu secenegin icine giriyor.
                    {
                        fr.pictureBox1.Tag = "organiks";//Eger gelen salatalik ise picturebox'ın etiketini organiks yapiyoruz.
                        salatalik salat = new salatalik();//salatalik sinifindan yeni bir nesne tanimladik.
                        fr.pictureBox1.Image = salat.Image;//salatalik fotografini koyduk.
                    }
                    else if (number == 3)//Gelen random sayi 3'e eşit ise bu secenegin icine giriyor.
                    {
                        fr.pictureBox1.Tag = "kagitg";//Eger gelen gazete ise picturebox'ın etiketini kagitg yapiyoruz.
                        gazete gazet = new gazete();//gazete sinifindan yeni bir nesne tanimladik
                        fr.pictureBox1.Image = gazet.Image;//gazete fotografini koyduk
                    }
                    else if (number == 4)//Gelen random sayi 4'e eşit ise bu secenegin icine giriyor.
                    {
                        fr.pictureBox1.Tag = "kagitd";//Eger gelen dergi ise picturebox'ın etiketini kagitd yapiyoruz.
                        dergi derg = new dergi();//Dergi sinifindan yeni bir nesne tanimladik.
                        fr.pictureBox1.Image = derg.Image;//dergi fotografini koyuyoruz
                    }
                    else if (number == 5)//Gelen random sayi 5'e eşit ise bu secenegin icine giriyor.
                    {
                        fr.pictureBox1.Tag = "camb";//Eger gelen cam bardak ise picturebox'ın etiketini camb yapiyoruz.
                        cambardak bardak = new cambardak();//cambardak sinifindan yeni bir nesne tanimladik.
                        fr.pictureBox1.Image = bardak.Image;//Bardak fotografini koyuyoruz.
                    }
                    else if (number == 6)//Gelen random sayi 6'e eşit ise bu secenegin icine giriyor.
                    {
                        fr.pictureBox1.Tag = "cams";//Eger gelen cam sise ise picturebox'ın etiketini cams yapiyoruz.

                        fr.pictureBox1.Image = sise.Image;//cam sise fotografini koyuyoruz
                    }
                    else if (number == 7)//Gelen random sayi 7'e eşit ise bu secenegin icine giriyor.
                    {
                        fr.pictureBox1.Tag = "metals";//Eger gelen salca kutusu ise picturebox'ın etiketini metals yapiyoruz.
                        salcakutu salca = new salcakutu();//Salca kutusu sinifindan yeni bir nesne tanimliyoruz
                        fr.pictureBox1.Image = salca.Image;//salca fotografini koyuyoruz.
                    }
                    else if (number == 8)//Gelen random sayi 8'e eşit ise bu secenegin icine giriyor.
                    {
                        fr.pictureBox1.Tag = "metalk";//Eger gelen kola kutusu ise picturebox'ın etiketini metalk yapiyoruz.
                        kola cola = new kola();//Kola sinifindan yeni bir nesne tanimladik.
                        fr.pictureBox1.Image = cola.Image;//Kola fotograflarini koyduk.
                    }
                    fr.listcam.Items.Add("Cam Sise(600)");//Listeye cam sise yazdirdik.
                    fr.barcam.Value = fr.barcam.Value + sise.Hacim;//sisenin puani kadar bari cogalttik.
                    int puan = Convert.ToInt32(fr.labpuan.Text);
                    puan = puan + sise.Hacim;//Sisenin puanini ekledik.
                    fr.labpuan.Text = Convert.ToString(puan);
                }
            }
        }
        public class kagit : IAtikKutusu
        {
            public int BosaltmaPuani => (1000);//Kagit kutusu bosaltildiginda 1000 puan alinsin diye.

            public int Kapasite { get => (1200); set => value= (1200); }//Kagit kutusunun hacmini 1200 olarak belirledik.

            public int DoluHacim => throw new NotImplementedException();

            public int DolulukOrani => (900);//Kagit kutusunun doluluk oranini 900 olarak belirledik.

            public void Bosalt(Form1 fr)//kutuyu bosaltmak icin metot
            {
               if(fr.barkagit.Value>DolulukOrani&& Convert.ToInt32(fr.labsayac.Text) > 0)//süre bitti mi diye bakiyoruz sonra gerekli doluluk oranina ulasti mi diye bakiyoruz
                {
                    int puan = Convert.ToInt32(fr.labpuan.Text);
                    puan = puan + BosaltmaPuani;//kutu bosaltildiginda kutunun puanini puana ekliyoruz.

                    fr.labpuan.Text = Convert.ToString(puan);
                    fr.barkagit.Value = 0;//Bari sifirliyoruz.
                    int sure = Convert.ToInt32(fr.labsayac.Text);
                    sure = sure + 3;//Süreye 3 saniye ekliyoruz.
                    fr.labsayac.Text = Convert.ToString(sure);

                }
            }

            public void Ekle(Form1 fr)//kutuya nesne eklemek icin metot
            {
                if (fr.pictureBox1.Tag == fr.butkagit.Tag && fr.barkagit.Maximum - fr.barkagit.Value >= 250&&Convert.ToInt32(fr.labsayac.Text)>0)//Gelen fotograf ile nesne eslesiyor mu diye bakiyoruz sonra yeterli alan kutuda var mi diye bakiyoruz ve son olarak saniyenin yeterli olup olmadigini kontrol ettik.
                {
                    int number;

                    Random random = new Random();

                    number = random.Next(1, 9);//1 ve 8 arasinda rastgele bir sayi sectirerek her sayiyla bir resmi eslestirip pictureboxa rastgele resim gelmesini sagladim.
                    gazete gazet = new gazete();//gazete sinifindan yeni bir nesne tanimladik
                    if (number == 1)//Gelen random sayi 1'ye esit ise bu secenege giriyor.//Gelen random sayi 1'e eşit ise bu secenegin icine giriyor.
                    {
                        fr.pictureBox1.Tag = "organikd";//Eger gelen domates ise picturebox'ın etiketini organikd yapiyoruz.
                        domates domat = new domates();//domates sinifindan yeni bir nesne tanimladik
                        fr.pictureBox1.Image = domat.Image;//domates fotografini koyduk
                    }
                    else if (number == 2)//Gelen random sayi 2'ye esit ise bu secenege giriyor.
                    {
                        fr.pictureBox1.Tag = "organiks";//Eger gelen salatalik ise picturebox'ın etiketini organiks yapiyoruz.
                        salatalik salat = new salatalik();//salatalik sinifindan yeni bir nesne tanimladik
                        fr.pictureBox1.Image = salat.Image;//salatalik fotografini koyduk
                    }
                    else if (number == 3)//Gelen random sayi 3'ye esit ise bu secenege giriyor.
                    {
                        fr.pictureBox1.Tag = "kagitg";//Eger gelen gazete ise picturebox'ın etiketini kagitg yapiyoruz.

                        fr.pictureBox1.Image = gazet.Image;//gazete fotografini koyduk
                    }
                    else if (number == 4)//Gelen random sayi 4'ye esit ise bu secenege giriyor.
                    {
                        fr.pictureBox1.Tag = "kagitd";//Eger gelen dergi ise picturebox'ın etiketini kagitd yapiyoruz.
                        dergi derg = new dergi();//dergi sinifindan yeni bir nesne tanimladik
                        fr.pictureBox1.Image = derg.Image;//dergi fotografini koyduk
                    }
                    else if (number == 5)//Gelen random sayi 5'ye esit ise bu secenege giriyor.
                    {
                        fr.pictureBox1.Tag = "camb";//Eger gelen cam bardak ise picturebox'ın etiketini camb yapiyoruz.
                        cambardak bardak = new cambardak();//cambardak sinifindan yeni bir nesne tanimladik
                        fr.pictureBox1.Image = bardak.Image;//bardak fotografini koyduk
                    }
                    else if (number == 6)//Gelen random sayi 6'ye esit ise bu secenege giriyor.
                    {
                        fr.pictureBox1.Tag = "cams";//Eger gelen cam sise ise picturebox'ın etiketini cams yapiyoruz.
                        camsise sise = new camsise();//camsise sinifindan yeni bir nesne tanimladik
                        fr.pictureBox1.Image = sise.Image;//sise fotografini koyduk
                    }
                    else if (number == 7)//Gelen random sayi 7'ye esit ise bu secenege giriyor.
                    {
                        fr.pictureBox1.Tag = "metals";//Eger gelen salca kutusu ise picturebox'ın etiketini metals yapiyoruz.
                        salcakutu salca = new salcakutu();//salcakutu sinifindan yeni bir nesne tanimladik
                        fr.pictureBox1.Image = salca.Image;//salca fotografini koyduk
                    }
                    else if (number == 8)//Gelen random sayi 8'ye esit ise bu secenege giriyor.
                    {
                        fr.pictureBox1.Tag = "metalk";//Eger gelen kola kutusu ise picturebox'ın etiketini metalk yapiyoruz.
                        kola cola = new kola();//Kola sinifindan yeni bir nesne tanimladik.
                        fr.pictureBox1.Image = cola.Image;//Kola fotografini koyduk.
                    }
                    fr.listkagit.Items.Add("Gazete(250)");//Listeye gazete yazdirdik.
                    fr.barkagit.Value = fr.barkagit.Value + gazet.Hacim;//Bari gazete hacmi kadar arttirdik.
                    int puan = Convert.ToInt32(fr.labpuan.Text);
                    puan = puan + gazet.Hacim;//Gazetenin puanini ekledik.
                    fr.labpuan.Text = Convert.ToString(puan);
                }
                else if (fr.pictureBox1.Tag == fr.listkagit.Tag && fr.barkagit.Maximum - fr.barkagit.Value >= 200&& Convert.ToInt32(fr.labsayac.Text) > 0)//Gelen fotograf ile nesne eslesiyor mu diye bakiyoruz sonra yeterli alan kutuda var mi diye bakiyoruz ve son olarak saniyenin yeterli olup olmadigini kontrol ettik.
                {
                    int number;

                    Random random = new Random();

                    number = random.Next(1, 9);//1 ve 8 arasinda rastgele bir sayi sectirerek her sayiyla bir resmi eslestirip pictureboxa rastgele resim gelmesini sagladim.
                    dergi derg = new dergi();//dergi sinifindan yeni bir nesne tanimladik
                    if (number == 1)//Gelen random sayi 1'e eşit ise bu secenegin icine giriyor.
                    {
                        fr.pictureBox1.Tag = "organikd";//Eger gelen domates ise picturebox'ın etiketini organikd yapiyoruz.
                        domates domat = new domates();//domates sinifindan yeni bir nesne tanimladik
                        fr.pictureBox1.Image = domat.Image;//domates fotografini koyduk
                    }
                    else if (number == 2)
                    {
                        fr.pictureBox1.Tag = "organiks";//Eger gelen salatalik ise picturebox'ın etiketini organiks yapiyoruz.
                        salatalik salat = new salatalik();//salatalik sinifindan yeni bir nesne tanimladik
                        fr.pictureBox1.Image = salat.Image;//salatalik fotografini koyduk
                    }
                    else if (number == 3)
                    {
                        fr.pictureBox1.Tag = "kagitg";//Eger gelen gazete ise picturebox'ın etiketini kagitg yapiyoruz.
                        gazete gazet = new gazete();//gazete sinifindan yeni bir nesne tanimladik
                        fr.pictureBox1.Image = gazet.Image;//gazete fotografini koyduk
                    }
                    else if (number == 4)
                    {
                        fr.pictureBox1.Tag = "kagitd";//Eger gelen dergi ise picturebox'ın etiketini kagitd yapiyoruz.

                        fr.pictureBox1.Image = derg.Image;//dergi fotografini koyduk
                    }
                    else if (number == 5)
                    {
                        fr.pictureBox1.Tag = "camb";//Eger gelen cam bardak ise picturebox'ın etiketini camb yapiyoruz.
                        cambardak bardak = new cambardak();//cambardak sinifindan yeni bir nesne tanimladik
                        fr.pictureBox1.Image = bardak.Image;//bardak fotografini koyduk
                    }
                    else if (number == 6)
                    {
                        fr.pictureBox1.Tag = "cams";//Eger gelen cam sise ise picturebox'ın etiketini cams yapiyoruz.
                        camsise sise = new camsise();//camsise sinifindan yeni bir nesne tanimladik
                        fr.pictureBox1.Image = sise.Image;//sise fotografini koyduk
                    }
                    else if (number == 7)
                    {
                        fr.pictureBox1.Tag = "metals";//Eger gelen salca kutusu ise picturebox'ın etiketini metals yapiyoruz.
                        salcakutu salca = new salcakutu();// salcakutu sinifindan yeni bir nesne tanimladik
                        fr.pictureBox1.Image = salca.Image;//salca fotografini koyduk
                    }
                    else if (number == 8)
                    {
                        fr.pictureBox1.Tag = "metalk";//Eger gelen kola kutusu ise picturebox'ın etiketini metalk yapiyoruz.
                        kola cola = new kola();//kola sinifindan yeni bir nesne tanimladik
                        fr.pictureBox1.Image = cola.Image;//kola fotografini koyduk
                    }
                    fr.listkagit.Items.Add("Dergi(200)");//Listeye dergi yazdirdik.
                    fr.barkagit.Value = fr.barkagit.Value + derg.Hacim;//Bari gazete hacmi kadar arttirdik.
                    int puan = Convert.ToInt32(fr.labpuan.Text);
                    puan = puan + derg.Hacim;//Derginin puanini ekliyoruz.
                    fr.labpuan.Text = Convert.ToString(puan);
                }
            }
        }
        public class domates : IAtik //Domates sinifi acip IAtik interfaceinden miras bilgiler aldik.
        {
            public int Hacim => (150);//Domatesin hacminin 150 oldugunu belirttik.

            public Image Image => Image.FromFile("tomato-icon.png");//Domatesin fotografini koyduk.
        }
        public class salatalik : IAtik//Salatalik sinifi acip IAtik interfaceinden miras bilgiler aldik.
        {
            public int Hacim => (120);//Salataligin hacminin 120 oldugunu belirttik.

            public Image Image => Image.FromFile("Cucumber-icon.png");//Salataligin fotografini koyduk.
        }
        public class kola : IAtik//Kola sinifi acip IAtik interfaceinden miras bilgiler aldik.
        {
            public int Hacim => (350);//Kola sisesinin hacminin 350 oldugunu belirttik.

            public Image Image => Image.FromFile("Coke-Zero-icon.png");//Kola sisesinin fotografini koyduk..
        }
        public class camsise : IAtik//Cam sise sinifi acip IAtik interfaceinden miras bilgiler aldik.
        {
            public int Hacim => (600);//Sisenin hacminin 600 oldugunu belirttik.

            public Image Image => Image.FromFile("mail-in-a-bottle-icon.png");//Sisenin fotografini koyduk.
        }
        public class salcakutu : IAtik//Salca kutusu sinifi acip IAtik interfaceinden miras bilgiler aldik.
        {
            public int Hacim => (550);//Salcanin hacminin 550 oldugunu belirttik.

            public Image Image => Image.FromFile("indir.jpg");//Salcanin fotografini koyduk.
        }
        public class gazete : IAtik//Gazete sinifi acip IAtik interfaceinden miras bilgiler aldik.
        {
            public int Hacim => (250);//Gazetenin hacminin 250 oldugunu belirttik.

            public Image Image =>Image.FromFile("Newspapers-2-icon.png");//Gazetenin fotografini koyduk.
        }
        public class cambardak : IAtik//Cam bardak sinifi acip IAtik interfaceinden miras bilgiler aldik.
        {
            public int Hacim => (250);//Bardagin hacminin250 oldugunu belirttim.

            public Image Image => Image.FromFile("X-glass-icon(1).png");//Bardagin fotografini koyduk.
        }
        public class dergi : IAtik//Dergi sinifi acip IAtik interfaceinden miras bilgiler aldik.
        {
            public int Hacim => (200);//Derginin hacminin 200 oldugunu belirttim.

            public Image Image =>Image.FromFile("indir.png");//Derginin fotografini koyduk.
        }

        private void butorganik_Click(object sender, EventArgs e)
        {
            organik organikk = new organik();//organik sinifindan yeni nesne tanımladik.
            organikk.Ekle(this);//this ile form elemanlarini tasvirledim.

        }

        private void butkagit_Click(object sender, EventArgs e)
        {
            kagit kagitt = new kagit();//kagit sinifindan yeni nesne tanımladik.
            kagitt.Ekle(this);//this ile form elemanlarini tasvirledim.


        }

        private void butcam_Click(object sender, EventArgs e)
        {
            cam camm = new cam();//cam sinifindan yeni nesne tanımladik.
            camm.Ekle(this);//this ile form elemanlarini tasvirledim.
        }
           
        private void butmetal_Click(object sender, EventArgs e)
        {
            metal metall = new metal();//metal sinifindan yeni nesne tanimladik.
            metall.Ekle(this);//this ile form elemanlarini tasvirledim.

        }

        private void butcikis_Click(object sender, EventArgs e)
        {
            Application.Exit();//Formdan cıkıs yapilmasini soyledik.
        }

        private void progressBar3_Click(object sender, EventArgs e)
        {

        }

        private void butorganikbos_Click(object sender, EventArgs e)
        {
            organik organikk = new organik();//organik sinifindan yeni nesne tanimladik.
            organikk.Bosalt(this);//this ile form elemanlarini tasvirledim.

        }

        private void butkagitbos_Click(object sender, EventArgs e)
        {
            kagit kagitt = new kagit();//Kagit sinifindan yeni nesne tanimladik.
            kagitt.Bosalt(this);//this ile form elemanlarini tasvirledim.


        }

        private void butcambos_Click(object sender, EventArgs e)
        {
            cam camm = new cam();//Cam sinifindan yeni nesne tanimladik.
            camm.Bosalt(this);//this ile form elemanlarini tasvirledim.
        }

        private void butmetalbos_Click(object sender, EventArgs e)
        {
            metal metall = new metal();//metal sinifindan yeni nesne tanimladik.
            metall.Bosalt(this);//this ile form elemanlarini tasvirledim.
        }
    }
}
