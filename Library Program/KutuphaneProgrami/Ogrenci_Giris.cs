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
    public partial class Ogrenci_Giris : Form
    {
        IOgrenciService ogrenciService; // OgrenciService' den nesne oluşturabilmek için IOgrenciService'dan bir değişken tanımlandı.
        Form form;
        public Ogrenci_Giris(Form form)
        {
            InitializeComponent();
            ogrenciService = new OgrenciService(); // Nesne oluşturuldu.
            this.form = form;

        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            form.Close();
        }  

        private void button2_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();  // Giris formundan nesne oluşturuldu.
            giris.Show();  // giris formuna gidildi.
            this.Hide(); // Önceki form kapatıldı.
        }

        private void buttonGIRIS_Click(object sender, EventArgs e)
        {
          
                string tc = textTC.Text; // textTC, tc' ye atandı.
            string sifre = textSIFRE.Text; // textSIFRE, sifre' ye atandı.
            Ogrenci ogrenci = ogrenciService.TCandPassword(tc, sifre); // ogrenciServicedeki tc ve sifre parametreli TCandPassword metodu Ogrenci' ye atandı.
            if (ogrenci != null) // eğer ogrenci boş değilse if' e girildi.
                {
                    Ogrenci_Anasayfa ogrenci_Anasayfa = new Ogrenci_Anasayfa();  // Ogrenci_Anasayfa formundan nesne oluşturuldu.
                ogrenci_Anasayfa.Show(); // ogrenci_Anasayfa formuna gidildi.
                this.Hide(); // Önceki form kapatıldı.
            }
            else // if koşulu sağlanmadıysa else' e girildi.
            {
                    MessageBox.Show("TC veya şifre hatalı"); // Ekrana girilen bilgilerin hatalı olduğuna dair mesaj verildi.
            }
            
        }
    }
}