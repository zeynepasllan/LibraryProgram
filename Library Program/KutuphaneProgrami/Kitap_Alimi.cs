using Entities.Concrete; //Klasör kütüphanesi
using Service.Concrete; //Klasör kütüphanesi
using Service.Interfaces; //Klasör kütüphanesi
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneProgrami
{
    public partial class Kitap_Alimi : Form
    {
        IEmanetService emanetService; // EmanetService' den nesne oluşturabilmek için IEmanetService'dan bir değişken tanımlandı.
        IKitapService kitapService; // KitapService' den nesne oluşturabilmek için IKitapService'dan bir değişken tanımlandı.
        IOgrenciService ogrenciService; // OgrenciService' den nesne oluşturabilmek için IOgrenciService'dan bir değişken tanımlandı.
        List<Emanet> emanetler; // Emanet classının listesine erişebilmek için bir değişken tanımlandı.
        List<Kitap> kitaplar; // Kitap classının listesine erişebilmek için bir değişken tanımlandı.
        List<Ogrenci> ogrenciler; // Ogrenci classının listesine erişebilmek için bir değişken tanımlandı.
        public Kitap_Alimi()
        {
            InitializeComponent();
            emanetService = new EmanetService(); // Nesne oluşturuldu.
            kitapService = new KitapService(); // Nesne oluşturuldu.
            ogrenciService = new OgrenciService(); // Nesne oluşturuldu.
            DataGridViewFill(); // DataGridViewFill tanımlandı.
            DataGridViewFill2(); // DataGridViewFill2 tanımlandı.
            DataGridViewFill3(); // DataGridViewFill3 tanımlandı.

        }
        private void DataGridViewFill()
        {        
            emanetler = emanetService.listele(); // Veritabanından emanetler çekilip liste şeklinde emanetler değişkenine atandı. 
            dgwemntliste.DataSource = emanetler; // emanetler değişkeni dgwemntliste' ye listelendi.
        }
        private void DataGridViewFill2()
        {
            kitaplar = kitapService.listele(); // Veritabanından emanetler çekilip liste şeklinde emanetler değişkenine atandı. 
            dgwkitapliste.DataSource = kitaplar; // emanetler değişkeni dgwemntliste' ye listelendi.
        }
        private void DataGridViewFill3()
        {        
            ogrenciler = ogrenciService.listele(); // Veritabanından emanetler çekilip liste şeklinde emanetler değişkenine atandı. 
            dgwogrliste.DataSource = ogrenciler; // emanetler değişkeni dgwemntliste' ye listelendi.
        }
        private void buttonEMNTVER_Click(object sender, EventArgs e)
        {
            Emanet emanet = new Emanet(); // Nesne oluşturuldu.
            emanet.ogr_ID = Convert.ToInt32(textogrid.Text); // textogrid sayıya dönüştürülüp ogr_ID' ye atandı.
            emanet.ktp_ID = Convert.ToInt32(textktpid.Text); // textktpid sayıya dönüştürülüp ktp_ID' ye atandı.
            emanet.Kitap_Alimi = DateTime.Now.Date; // Bugünün tarihi TeslimEdilenTarih' e atandı.
            emanet.Iade_Islemleri = Convert.ToDateTime(dtpiadetarih.Text); // dtpiadetarih tarihe dönüştürülüp Iade_Islemleri' ne atandı.
            emanetService.ekle(emanet); // Emanet ekle metodu çağrıldı.
            DataGridViewFill(); // Yeni emanetler listesi gösterildi.
            MessageBox.Show("Kitap Emanet Edildi"); // Ekrana kitabın emanet edildiğine dair bilgi mesajı verildi.
        }

        private void buttonKTPHNANASAYFA_Click(object sender, EventArgs e) // kütüphaneye dön butonu için oluşturuldu.
        {
            Kutuphane_Anasayfa kutuphane_Anasayfa = new Kutuphane_Anasayfa(); // Kutuphane_Anasayfa formundan nesne oluşturuldu.
            kutuphane_Anasayfa.Show(); // kutuphane_Anasayfa formuna gidildi.
            this.Close(); // Önceki form kapatıldı.
        }

        private void textogrid_TextChanged(object sender, EventArgs e) // Id' ye göre öğrenci araması için oluşturuldu.
        {
            if (!String.IsNullOrEmpty(textogrid.Text)) // textogrid boş değilse if'e girildi.
            { 
                Ogrenci suankiogrenciler = ogrenciler.FirstOrDefault(x => x.Id == Convert.ToInt32(textogrid.Text)); // Veritabanında Ogrenci tablosundan Id ile eşleşen bilgileri çağırması içi suankiogrenciler değişkeni oluşturuldu.
                if (suankiogrenciler != null) // Id boş değilse if' e girildi.
                {
                    texttc.Text = suankiogrenciler.Tc.ToString(); // Ogrencideki Tc, texttc' ye yazıldı.
                    textadsoyad.Text = suankiogrenciler.Adsoyad.ToString(); // Ogrencideki Adsoyad, textadsoyad' a yazıldı.
                    textyas.Text = suankiogrenciler.yas.ToString(); // Ogrencideki yas, textyas' a yazıldı.
                    texttel.Text = suankiogrenciler.telefon.ToString(); // Ogrencideki telefon, texttel' e yazıldı.
                    textadres.Text = suankiogrenciler.adres.ToString(); // Ogrencideki adres, textadres' e yazıldı.
                    textemail.Text = suankiogrenciler.email.ToString(); // Ogrencideki email, textemail' e yazıldı.
                    textborc.Text = suankiogrenciler.borc.ToString(); // Ogrencideki borc, textborc' a yazıldı.
                    textsifre.Text = suankiogrenciler.sifre.ToString(); // Ogrencideki sifre, textsifre' ye yazıldı.

                }
            }
        }

        private void textktpid_TextChanged(object sender, EventArgs e) // Id' ye göre öğrenci araması için oluşturuldu.
        {
            if (!String.IsNullOrEmpty(textktpid.Text)) // textogrid boş değilse if'e girildi.
            {
                Kitap suankikitaplar = kitaplar.FirstOrDefault(x => x.Id == Convert.ToInt32(textktpid.Text)); // Veritabanında Ogrenci tablosundan Id ile eşleşen bilgileri çağırması içi suankiogrenciler değişkeni oluşturuldu.
                if (suankikitaplar != null) // Id boş değilse if' e girildi.
                {
                    textad.Text = suankikitaplar.ad.ToString(); // Kitaptaki ad, textad' a yazıldı.
                    textyazar.Text = suankikitaplar.yazar.ToString(); // Kitaptaki yazar, textyazar' a yazıldı.
                    textyayinevi.Text = suankikitaplar.yayinevi.ToString(); // Kitaptaki yayinevi, textyayinevi' ne yazıldı.
                    textsayfasayisi.Text = suankikitaplar.sayfasayisi.ToString(); // Kitaptaki sayfasayisi, textsayfasayisi' na yazıldı.
                    texttur.Text = suankikitaplar.turu.ToString(); // Kitaptaki turu, texttur' e yazıldı.
                    textbasimtarihi.Text = suankikitaplar.basimtarihi.ToString(); // Kitaptaki basimtarihi, textbasimtarihi' ne yazıldı.

                }
            }
        }
    }
}
