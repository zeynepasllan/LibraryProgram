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
    public partial class Ogrenci_Islemleri : Form
    {
        IOgrenciService ogrenciService; // OgrenciService' den nesne oluşturabilmek için IOgrenciService'dan bir değişken tanımlandı.
        List<Ogrenci> ogrenciler; // Ogrenci classının listesine erişebilmek için bir değişken tanımlandı.

        public Ogrenci_Islemleri()
        {
            InitializeComponent();
            ogrenciService = new OgrenciService(); // Nesne oluşturuldu.
            ogrenciler = ogrenciService.listele(); // ogrenciler değişkenine ogrenci listele atandı.
            DataGridViewFill(); // DataGridViewFill tanımlandı.

        }
        private void DataGridViewFill()
        {
            dgwOgrenci.DataSource = ogrenciService.listele(); // Veritabanından ogrenciler çekilip liste şeklinde dgwOgrenci' ye listelendi.
        }

        private void buttonEKLE_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci(); // Nesne oluşturuldu.
            ogrenci.Tc = textTC.Text; // textTC ogrencideki Tc' ye atandı.
            ogrenci.Adsoyad = textADSOYAD.Text; // textADSOYAD ogrencideki Adsoyad' a atandı.
            ogrenci.yas = Convert.ToInt32(textYAS.Text); // textYAS sayıya dönüştürülüp ogrencideki yas' a atandı.
            ogrenci.telefon = textTELEFON.Text; // textTELEFON ogrencideki telefon' a atandı.
            ogrenci.adres = textADRES.Text; // textADRES ogrencideki adres' e atandı.
            ogrenci.email = textEMAIL.Text; // textEMAIL ogrencideki email' e atandı.
            ogrenci.borc = Convert.ToInt32(textBORC.Text); // textBORC sayıya dönüştürülüp ogrencideki borc' a atandı.
            ogrenci.sifre = textSIFRE.Text; // textSIFRE ogrencideki sifre' ye atandı.
            ogrenciService.ekle(ogrenci);  // Ogrenci ekle metodu çağrıldı.
            DataGridViewFill(); // Yeni öğrenciler listesi gösterildi.
            MessageBox.Show("Öğrenci Eklendi"); // Ekrana öğrencinin eklendiğine dair bilgi mesajı verildi.
        }

        private void buttonGUNCELLE_Click(object sender, EventArgs e)
        {

            Ogrenci ogrenci = new Ogrenci(); // Nesne oluşturuldu.
            ogrenci.Tc = textTC.Text; // textTC ogrencideki Tc' ye atandı.
            ogrenci.Adsoyad = textADSOYAD.Text; // textADSOYAD ogrencideki Adsoyad' a atandı.
            ogrenci.yas = Convert.ToInt32(textYAS.Text); // textYAS sayıya dönüştürülüp ogrencideki yas' a atandı.
            ogrenci.telefon = textTELEFON.Text; // textTELEFON ogrencideki telefon' a atandı.
            ogrenci.adres = textADRES.Text; // textADRES ogrencideki adres' e atandı.
            ogrenci.email = textEMAIL.Text; // textEMAIL ogrencideki email' e atandı.
            ogrenci.borc = Convert.ToInt32(textBORC.Text); // textBORC sayıya dönüştürülüp ogrencideki borc' a atandı.
            ogrenci.sifre = textSIFRE.Text; // textSIFRE ogrencideki sifre' ye atandı.
            ogrenci.Id = Convert.ToInt32(textID.Text); // textID ogrencideki Id' ye atandı.
            ogrenciService.guncelle(ogrenci);  // Ogrenci guncelle metodu çağrıldı.
            DataGridViewFill(); // Yeni öğrenciler listesi gösterildi.
            MessageBox.Show("Öğrenci Güncellendi"); // Ekrana öğrencinin eklendiğine dair bilgi mesajı verildi.

        }
        private void buttonSIL_Click(object sender, EventArgs e)
        {

            Ogrenci ogrenci = new Ogrenci(); // Nesne oluşturuldu.
            int id = Convert.ToInt32(textID.Text); // textID sayıya dönüştürülüp id' ye atandı.
            ogrenciService.sil(id); // Ogrenci sil metodu çağrıldı.
            DataGridViewFill(); // Yeni kitaplar listesi gösterildi.
            MessageBox.Show("Öğrenci Silindi :("); // Ekrana öğrencinin silindiğine dair bilgi mesajı verildi.

        }

        private void dgwOgrenci_SelectionChanged(object sender, EventArgs e) // dgwOgrenci' de seçim değiştikçe aşağıdaki işlemleri yapması için oluşturuldu.
        {

            textID.Text = dgwOgrenci.CurrentRow.Cells[0].Value.ToString(); // 0. indexe textID' de yazılı bilgi gösterildi.
            textTC.Text = dgwOgrenci.CurrentRow.Cells[1].Value.ToString(); // 1. indexe textTC' de yazılı bilgi gösterildi.
            textADSOYAD.Text = dgwOgrenci.CurrentRow.Cells[2].Value.ToString(); // 2. indexe textADSOYAD' da yazılı bilgi gösterildi.
            textYAS.Text = dgwOgrenci.CurrentRow.Cells[3].Value.ToString(); // 3. indexe textYAS' da yazılı bilgi gösterildi.
            textTELEFON.Text = dgwOgrenci.CurrentRow.Cells[4].Value.ToString(); // 4. indexe textTELEFON' da yazılı bilgi gösterildi.
            textADRES.Text = dgwOgrenci.CurrentRow.Cells[5].Value.ToString(); // 5. indexe textADRES' de yazılı bilgi gösterildi.
            textEMAIL.Text = dgwOgrenci.CurrentRow.Cells[6].Value.ToString(); // 6. indexe textEMAIL' de yazılı bilgi gösterildi.
            textBORC.Text = dgwOgrenci.CurrentRow.Cells[7].Value.ToString(); // 7. indexe textBORC' da yazılı bilgi gösterildi.
            textSIFRE.Text = dgwOgrenci.CurrentRow.Cells[8].Value.ToString(); // 8. indexe textSIFRE' de yazılı bilgi gösterildi.

        }
        private void buttonKTPHNANASAYFA_Click(object sender, EventArgs e) // kütüphaneye dön butonu için oluşturuldu.
        {
            Kutuphane_Anasayfa kutuphane_Anasayfa = new Kutuphane_Anasayfa(); // Kutuphane_Anasayfa formundan nesne oluşturuldu.
            kutuphane_Anasayfa.Show(); // kutuphane_Anasayfa formuna gidildi.
            this.Close(); // Önceki form kapatıldı.
        }

        private void textADSOYADARA_TextChanged(object sender, EventArgs e) // Adsoyad' a göre ogrenci araması için oluşturuldu.
        {
            List<Ogrenci> filterData = ogrenciler.Where(x => x.Adsoyad.ToLower().Contains(textADSOYADARA.Text.ToLower())).ToList(); // Veritabanında Ogrenci tablosundan Adsoyad ile eşleşen bilgileri çağırması için Ogrenci listeden filterData değişkeni oluşturuldu.
            if (filterData != null) // Kitap boş değilse if' e girildi.
            {
                dgwOgrenci.DataSource = filterData; // Adsoyad ile eşleşen bilgileri dgwOgrenci' ye yazıldı.
            }

        }
    }
}