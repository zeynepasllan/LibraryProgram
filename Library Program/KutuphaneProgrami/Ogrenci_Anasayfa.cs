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
    public partial class Ogrenci_Anasayfa : Form
    {
        public Ogrenci_Anasayfa()
        {
            InitializeComponent();
        }

        private void buttonEMANETLISTE_Click(object sender, EventArgs e) // borç sorgula butonu için oluşturuldu.
        {
            Ogrenci_Girisi_BorcSorgula ogrenci_Girisi_EmanetListesi = new Ogrenci_Girisi_BorcSorgula(); // Ogrenci_Girisi_BorcSorgula formundan nesne oluşturuldu.
            ogrenci_Girisi_EmanetListesi.Show(); // ogrenci_Girisi_EmanetListesi formuna gidildi.
            this.Close(); // Önceki form kapatıldı.
        }
        private void buttonKITAPLISTE_Click(object sender, EventArgs e) // kitap ara butonu için oluşturuldu.
        {
            Ogrenci_Girisi_KitapAra ogrenci_Girisi_KitapListesi = new Ogrenci_Girisi_KitapAra(); // Ogrenci_Girisi_KitapAra formundan nesne oluşturuldu.
            ogrenci_Girisi_KitapListesi.Show(); // ogrenci_Girisi_KitapListesi formuna gidildi.
            this.Close(); // Önceki form kapatıldı.
        }

        private void button1_Click(object sender, EventArgs e) // girişe dön butonu için oluşturuldu.
        {
            Giris giris = new Giris(); // Giris formundan nesne oluşturuldu.
            giris.Show(); // giris formuna gidildi.
            this.Close(); // Önceki form kapatıldı.
        }
    }
}
