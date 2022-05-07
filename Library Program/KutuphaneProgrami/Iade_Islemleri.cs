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
    public partial class Iade_Islemleri : Form
    {
        IEmanetService emanetService; // EmanetService' den nesne oluşturabilmek için IEmanetService'dan bir değişken tanımlandı.
        List<Emanet> emanetler; // Emanet classının listesine erişebilmek için bir değişken tanımlandı.
        public Iade_Islemleri()
        {
            InitializeComponent();
            emanetService = new EmanetService(); // Nesne oluşturuldu.
            DataGridViewFill(); // DataGridViewFill tanımlandı.
        }
        private void DataGridViewFill()
        {
            emanetler = emanetService.listele();  // Veritabanından emanetler çekilip liste şeklinde emanetler değişkenine atandı. 
            dgwemanetliste.DataSource = emanetler; // emanetler değişkeni dgwemanetliste' ye listelendi.
        }

        private void buttonIADEET_Click(object sender, EventArgs e)
        {
            Emanet emanet = new Emanet(); // Nesne oluşturuldu.
            emanet.ktp_ID = Convert.ToInt32(textktpid.Text); // textktpid sayıya dönüştürülüp emanetteki ktp_ID' ye atandı.
            emanet.ogr_ID = Convert.ToInt32(textogrid.Text); // textogrid sayıya dönüştürülüp emanetteki ogr_ID' ye atandı.
            emanet.Kitap_Alimi = Convert.ToDateTime(textkitapalimi.Text); // textkitapalimi tarihe dönüştürülüp emanetteki Kitap_Alimi' na atandı.
            emanet.TeslimEdilenTarih = DateTime.Now.Date; // Bugünün tarihi emanetteki TeslimEdilenTarih' e atandı.
            emanet.Iade_Islemleri = Convert.ToDateTime(textiade.Text); // textiade tarihe dönüştürülüp emanetteki Iade_Islemleri' ne atandı.
            emanet.Borc = Convert.ToInt32(textborc.Text); // textborc integera dönüştürülüp emanetteki Borc' a atandı.
            emanet.Id = Convert.ToInt32(textEMANETID.Text); // textEMANETID integera dönüştürülüp emanetteki Id' ye atandı.
            emanetService.guncelle(emanet); // Emanet guncelle metodu çağrıldı.
            DataGridViewFill(); // Yeni emanetler listesi gösterildi.
            MessageBox.Show("Emanet Kitap İade Edildi"); // Ekrana kitabın iade edildiğine dair bilgi mesajı verildi.

        }

        private void buttonSIL_Click(object sender, EventArgs e)
        {

            Emanet emanet = new Emanet(); // Nesne oluşturuldu.
            int Id = Convert.ToInt32(textEMANETARA.Text); // textEMANETARA sayıya dönüştürülüp Id' ye atandı.
            emanetService.sil(Id); // Emanet sil metodu çağrıldı.
            DataGridViewFill(); // Yeni emanetler listesi gösterildi.
            MessageBox.Show("Emanet Kitap Silindi :("); // Ekrana emanet kitabın silindiğine dair bilgi mesajı verildi.

        }

        private void textEMANETID_TextChanged(object sender, EventArgs e) // Id' ye göre emanet araması için oluşturuldu.
        {
            if (!String.IsNullOrEmpty(textEMANETID.Text)) // textEMANETID boş değilse if'e girildi.
            {
                Emanet suankiEmanet = emanetler.FirstOrDefault(x => x.Id == Convert.ToInt32(textEMANETID.Text)); // Veritabanında Emanet tablosundan Id ile eşleşen bilgileri çağırması içi suankiEmanet değişkeni oluşturuldu.
                if (suankiEmanet != null) // Id boş değilse if' e girildi.
                {
                    textogrid.Text = suankiEmanet.ogr_ID.ToString(); // Emanetteki ogr_ID, textogrid' ye yazıldı.
                    textktpid.Text = suankiEmanet.ktp_ID.ToString(); // Emanetteki ktp_ID, textktpid' ye yazıldı.
                    textkitapalimi.Text = suankiEmanet.Kitap_Alimi.ToString(); // Emanetteki Kitap_Alimi, textkitapalimi' ye yazıldı.
                    textiade.Text = suankiEmanet.Iade_Islemleri.ToString(); // Emanetteki Iade_Islemleri, textiade' ye yazıldı.
                    textborc.Text = suankiEmanet.Borc.ToString(); // Emanetteki Borc, textborc' ye yazıldı.
                    dtpTESLIMEDILENTARIH.Text = suankiEmanet.TeslimEdilenTarih.ToString(); // Emanetteki TeslimEdilenTarih, dtpTESLIMEDILENTARIH' ye yazıldı.

                }
            }
        }
     
        private void buttonKTPHNANASAYFA_Click(object sender, EventArgs e) // kütüphaneye dön butonu için oluşturuldu.
        {
            Kutuphane_Anasayfa kutuphane_Anasayfa = new Kutuphane_Anasayfa(); // Kutuphane_Anasayfa formundan nesne oluşturuldu.
            kutuphane_Anasayfa.Show(); // kutuphane_Anasayfa formuna gidildi.
            this.Close(); // Önceki form kapatıldı.
        }

    }
}
