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
    public partial class Ogrenci_Girisi_KitapAra : Form
    {
        IKitapService kitapService;  // KitapService' den nesne oluşturabilmek için IKitapService'dan bir değişken tanımlandı.
        IEmanetService emanetService; // EmanetService' den nesne oluşturabilmek için IEmanetService'dan bir değişken tanımlandı.
        List<Kitap> kitaplar; // Kitap classının listesine erişebilmek için bir değişken tanımlandı.
        public Ogrenci_Girisi_KitapAra()
        {
            InitializeComponent();
            kitapService = new KitapService(); // Nesne oluşturuldu.
            emanetService = new EmanetService(); // Nesne oluşturuldu.
            kitaplar = kitapService.listele();  // kitaplar değişkenine kitap listele atandı.
            DataGridViewFill();  // DataGridViewFill tanımlandı.
            DataGridViewFill2();  // DataGridViewFill2 tanımlandı.
        }
        private void DataGridViewFill()
        {
            dgwKITAPARA.DataSource = kitapService.listele(); // Veritabanından kitaplar çekilip liste şeklinde dgwKITAPARA' ya listelendi.


        }
        private void DataGridViewFill2()
        {

            dgwKITAPBILGI.DataSource = kitapService.listele(); // Veritabanından kitaplar çekilip liste şeklinde dgwKITAPBILGI' ye listelendi.
        }
        private void buttonGERIDON_Click(object sender, EventArgs e)  // geri dön butonu için oluşturuldu.
        {
            Ogrenci_Anasayfa ogrenci_Anasayfa = new Ogrenci_Anasayfa(); // Ogrenci_Anasayfa formundan nesne oluşturuldu.
            ogrenci_Anasayfa.Show(); // ogrenci_Anasayfa formuna gidildi.
            this.Close(); // Önceki form kapatıldı.
        }

      
        private void buttonKITAPARA_Click(object sender, EventArgs e) // Hem kitap aranıp hem kitabı alan öğrencileri listelemek için oluşturuldu.
        {
            string ad = textKITAPARA.Text; // textKITAPARA KitapDal' da KitapBul metodu içerisindeki ad' a atandı.
            Kitap kitap = kitapService.KitapBul(ad); // ad Kitap' a atandı.
            dgwKITAPARA.DataSource = emanetService.listele().Where(x => x.ktp_ID == kitap.Id).ToList(); // Kitabı hangi öğrencilerin aldığını görüntüleyebilmek için emanet listeleden veritabanındaki ktp_ID ve programdaki Id ile eşleşen bilgiler dgwKITAPARA' da gösterildi.

        }

        private void textKITAPARA_TextChanged(object sender, EventArgs e) // ad' a göre kitap araması için oluşturuldu.
        {
            List<Kitap> filterData = kitaplar.Where(x => x.ad.ToLower().Contains(textKITAPARA.Text.ToLower())).ToList(); // Veritabanında Kitap tablosundan ad ile eşleşen bilgileri çağırması için Kitap listeden filterData değişkeni oluşturuldu.
            if (filterData != null) // Kitap boş değilse if' e girildi.
            {
                dgwKITAPARA.DataSource = filterData; // ad ile eşleşen bilgileri dgwKITAPARA' ya yazıldı.
            }
        }

        private void textBoxID_TextChanged(object sender, EventArgs e) // Id' ye göre kitap araması için oluşturuldu.
        {
          


                if (!String.IsNullOrEmpty(textBoxID.Text)) // textBoxID boş değilse if'e girildi.
            {
                    Kitap suankikitaplar = kitaplar.FirstOrDefault(x => x.Id == Convert.ToInt32(textBoxID.Text)); // Veritabanında Kitap tablosundan Id ile eşleşen bilgileri çağırması içi suankikitaplar değişkeni oluşturuldu.
                if (suankikitaplar != null) // Id boş değilse if' e girildi.
                {
                        textBoxAD.Text = suankikitaplar.ad.ToString();  // Kitaptaki ad, textBoxAD' a yazıldı.
                    textBoxYAZAR.Text = suankikitaplar.yazar.ToString(); // Kitaptaki yazar, textBoxYAZAR' a yazıldı.
                    textBoxYAYINEVI.Text = suankikitaplar.yayinevi.ToString(); // Kitaptaki yayinevi, textBoxYAYINEVI' ne yazıldı.
                    textBoxSYFSAYISI.Text = suankikitaplar.sayfasayisi.ToString(); // Kitaptaki sayfasayisi, textBoxSYFSAYISI' na yazıldı.
                    textBoxTURU.Text = suankikitaplar.turu.ToString(); // Kitaptaki turu, textBoxTURU' ne yazıldı.
                    textBoxBASIMTARIHI.Text = suankikitaplar.basimtarihi.ToString(); // Kitaptaki basimtarihi, textBoxBASIMTARIHI' ne yazıldı.
                }
                }
            else // textBoxID boş ise else'e girildi.
            {
                    textBoxAD.Text = String.Empty; // textBoxAD  boş gösterildi.
                textBoxYAZAR.Text = String.Empty; // textBoxYAZAR  boş gösterildi.
                textBoxYAYINEVI.Text = String.Empty; // textBoxYAYINEVI  boş gösterildi.
                textBoxSYFSAYISI.Text = String.Empty; // textBoxSYFSAYISI  boş gösterildi.
                textBoxTURU.Text = String.Empty; // textBoxTURU  boş gösterildi.
                textBoxBASIMTARIHI.Text = String.Empty; // textBoxBASIMTARIHI  boş gösterildi.
            }
            
        }
    }
}
