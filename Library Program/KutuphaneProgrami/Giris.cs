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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void buttonKTPHANEGİRİS_Click(object sender, EventArgs e) // Kütüphane giriş butonu için oluşturuldu.
        {
            Kutuphane_Giris kutuphane_Giris = new Kutuphane_Giris(this); // Kutuphane_Giris formundan nesne oluşturuldu.
            kutuphane_Giris.Show(); // kutuphane_Giris formuna gidildi.
            this.Hide(); // Önceki form kapatıldı.
        }

        private void buttonOGRGİRİS_Click(object sender, EventArgs e)
        {
            Ogrenci_Giris ogrenci_Giris= new Ogrenci_Giris(this); // Ogrenci_Giris formundan nesne oluşturuldu.
            ogrenci_Giris.Show(); // ogrenci_Giris formuna gidildi.
            this.Hide(); // Önceki form kapatıldı.
        }

      
    }
}