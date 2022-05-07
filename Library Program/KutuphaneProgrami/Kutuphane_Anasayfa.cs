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
    public partial class Kutuphane_Anasayfa : Form
    {
        public Kutuphane_Anasayfa()
        {
            InitializeComponent();
        }

        private void buttonOGRISLEMLERİ_Click(object sender, EventArgs e) // öğrenci işlemleri butonu için oluşturuldu.
        {
            Ogrenci_Islemleri ogrenci_Islemleri = new Ogrenci_Islemleri(); // Ogrenci_Islemleri formundan nesne oluşturuldu.
            ogrenci_Islemleri.Show(); // ogrenci_Islemleri formuna gidildi.
            this.Close(); // Önceki form kapatıldı.
        }


        private void buttonKTPISLEMLERI_Click(object sender, EventArgs e) // kitap işlemleri butonu için oluşturuldu.
        {
            Kitap_Islemleri kitap_Islemleri = new Kitap_Islemleri(); // Kitap_Islemleri formundan nesne oluşturuldu.
            kitap_Islemleri.Show();  // kitap_Islemleri formuna gidildi.
            this.Close(); // Önceki form kapatıldı.
        }

        private void buttonKTPLISTE_Click(object sender, EventArgs e) // kitap listele butonu için oluşturuldu.
        {
            Kitap_Listesi kitap_Listesi = new Kitap_Listesi(); // Kitap_Listesi formundan nesne oluşturuldu.
            kitap_Listesi.Show();  // kitap_Listesi formuna gidildi.
            this.Close(); // Önceki form kapatıldı.
        }

        private void buttonOGRLISTE_Click(object sender, EventArgs e) // öğrenci listele butonu için oluşturuldu.
        {
            Ogrenci_Listesi ogrenci_Listesi = new Ogrenci_Listesi(); // Ogrenci_Listesi formundan nesne oluşturuldu.
            ogrenci_Listesi.Show();  // ogrenci_Listesi formuna gidildi.
            this.Close(); // Önceki form kapatıldı.
        } 
        private void buttonKTPALIMI_Click(object sender, EventArgs e) // emanet kitap ver butonu için oluşturuldu.
        {

            Kitap_Alimi kitap_Alimi = new Kitap_Alimi(); // Kitap_Alimi formundan nesne oluşturuldu.
            kitap_Alimi.Show();  // kitap_Alimi formuna gidildi.
            this.Close(); // Önceki form kapatıldı.

        }
        private void buttonIADE_Click(object sender, EventArgs e) // emanet kitap iade al butonu için oluşturuldu. 
        {
            Iade_Islemleri ıade_Islemleri = new Iade_Islemleri(); // Iade_Islemleri formundan nesne oluşturuldu.
            ıade_Islemleri.Show();  // ıade_Islemleri formuna gidildi.
            this.Close(); // Önceki form kapatıldı.
        }

        private void buttonEMNTLISTELE_Click(object sender, EventArgs e) // emanet listele butonu için oluşturuldu.
        {
            Emanet_Listesi emanet_Listesi = new Emanet_Listesi(); // Emanet_Listesi formundan nesne oluşturuldu.
            emanet_Listesi.Show();  // emanet_Listesi formuna gidildi.
            this.Close(); // Önceki form kapatıldı.
        }

        private void button1_Click(object sender, EventArgs e) // girişe dön butonu için oluşturuldu.
        {
            Giris giris = new Giris(); // Giris formundan nesne oluşturuldu.
            giris.Show();  // giris formuna gidildi.
            this.Close(); // Önceki form kapatıldı.
        }

        private void buttonGRAFIK_Click(object sender, EventArgs e) // kütüphane grafiği butonu için oluşturuldu.
        {
            Kutuphane_Grafiği kutuphane_Grafiği = new Kutuphane_Grafiği(); // Kutuphane_Grafiği formundan nesne oluşturuldu.
            kutuphane_Grafiği.Show();  // kutuphane_Grafiği formuna gidildi.
            this.Close(); // Önceki form kapatıldı.
        }
    }
}