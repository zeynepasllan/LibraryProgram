using Entities.Concrete;
using Service.Concrete;
using Service.Interfaces;
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

    public partial class Ogrenci_Listesi : Form
    {
        IOgrenciService ogrenciService; // OgrenciService' den nesne oluşturabilmek için IOgrenciService'dan bir değişken tanımlandı.
        List<Ogrenci> ogrenciler; // Ogrenci classının listesine erişebilmek için bir değişken tanımlandı.
        public Ogrenci_Listesi()
        {
            InitializeComponent();
            ogrenciService = new OgrenciService(); // Nesne oluşturuldu.
            ogrenciler = ogrenciService.listele(); // ogrenciler değişkenine ogrenci listele atandı.
            DataGridViewFill(); // DataGridViewFill tanımlandı.

        }
 
        private void DataGridViewFill()
        {
            dgwogrlistele.DataSource = ogrenciService.listele(); // Veritabanından ogrenciler çekilip liste şeklinde dgwOgrenci' ye listelendi.
        }

        private void buttonKTPHNANASAYFA_Click(object sender, EventArgs e) // kütüphaneye dön butonu için oluşturuldu.
        {

            Kutuphane_Anasayfa kutuphane_Anasayfa = new Kutuphane_Anasayfa(); // Kutuphane_Anasayfa formundan nesne oluşturuldu.
            kutuphane_Anasayfa.Show(); // kutuphane_Anasayfa formuna gidildi.
            this.Close(); // Önceki form kapatıldı.
        }

        private void textograra_TextChanged(object sender, EventArgs e) // Adsoyad' a göre ogrenci araması için oluşturuldu.
        {
            List<Ogrenci> filterData = ogrenciler.Where(x => x.Adsoyad.ToLower().Contains(textograra.Text.ToLower())).ToList(); // Veritabanında Ogrenci tablosundan Adsoyad ile eşleşen bilgileri çağırması için Ogrenci listeden filterData değişkeni oluşturuldu.
            if (filterData != null) // Kitap boş değilse if' e girildi.
            {
                dgwogrlistele.DataSource = filterData; // Adsoyad ile eşleşen bilgileri dgwogrlistele' ye yazıldı.
            }
        }
    }
}