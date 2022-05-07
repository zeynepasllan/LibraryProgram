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
    public partial class Ogrenci_Girisi_BorcSorgula : Form
    { 
        IEmanetService emanetService; // EmanetService' den nesne oluşturabilmek için IEmanetService'dan bir değişken tanımlandı.
        IOgrenciService ogrenciService; // OgrenciService' den nesne oluşturabilmek için IOgrenciService'dan bir değişken tanımlandı.
        List<Emanet> emanetler; // Emanet classının listesine erişebilmek için bir değişken tanımlandı.
        List<Ogrenci> ogrenciler; // Ogrenci classının listesine erişebilmek için bir değişken tanımlandı.
        public Ogrenci_Girisi_BorcSorgula()
        {
            InitializeComponent();
            emanetService = new EmanetService(); // Nesne oluşturuldu.
            ogrenciService = new OgrenciService();  // Nesne oluşturuldu.
            ogrenciler = ogrenciService.listele(); // ogrenciler değişkenine ogrenci listele atandı.
            emanetler = emanetService.listele(); // emanetler değişkenine emanet listele atandı.
            DataGridViewFill(); // DataGridViewFill tanımlandı.
        }
        private void DataGridViewFill()
        {
            dgwemntliste.DataSource = emanetService.listele(); // Veritabanından emanetler çekilip liste şeklinde dgwemntliste' ye listelendi.
        }
        void tablorenk() // Renkleri göstermek için geriye değer döndürmeyen tablorenk adlı metot tanımlandı.
        {

            for (int i = 0; i < dgwemntliste.Rows.Count; i++) // dgwemntliste' ye sıralandı.
            {
                var row = dgwemntliste.Rows[i]; // Veriler için satır sağlandı.
                if (row.Cells[5].Value == null) // Satır boşsa if' e girildi.
                {
                    var totalDays = (DateTime.Now - (DateTime)row.Cells[4].Value).TotalDays; // Borca göre renk vermek için gün ayarlama işlemi yapıldı.
                    if (totalDays > 0) // Eğer borçlanan gün sayısı 0 dan büyükse if'e girildi.
                    {
                        dgwemntliste.Rows[i].DefaultCellStyle.BackColor = Color.Red; // Satır kırmızı yapıldı.
                        dgwemntliste.Rows[i].DefaultCellStyle.ForeColor = Color.White; // Satır beyaz yaoıldı.
                        continue; // Devam edildi.
                    }
                    else if (totalDays > -2 && totalDays < 0) // Eğer teslim tarihine 2 gün kaldıysa else if'e girildi.
                    {
                        dgwemntliste.Rows[i].DefaultCellStyle.BackColor = Color.Yellow; // Satır sarı yapıldı.
                        dgwemntliste.Rows[i].DefaultCellStyle.ForeColor = Color.Black; // Satır siyah yapıldı.
                        continue; // Devam edildi.
                    }
                }
                else // Çnceki 2 koşul sağlanmadıysa yani kitap teslim edildiyse else' e girildi.
                {
                    dgwemntliste.Rows[i].DefaultCellStyle.BackColor = Color.Green; // Satır yeşil yapıldı.
                    dgwemntliste.Rows[i].DefaultCellStyle.ForeColor = Color.White; // Satır beyaz yapıldı.
                }

            }

        }

        private void textOGRID_TextChanged(object sender, EventArgs e)  // Id' ye göre kitap araması için oluşturuldu.
        {
            if (!String.IsNullOrEmpty(textOGRID.Text)) // textOGRID boş değilse if'e girildi.
            {
                Ogrenci suankiogrenci = ogrenciler.FirstOrDefault(x => x.Id == Convert.ToInt32(textOGRID.Text)); // Veritabanında Ogrenci tablosundan Id ile eşleşen bilgileri çağırması içi suankiogrenci değişkeni oluşturuldu.
                if (suankiogrenci != null) // Id boş değilse if' e girildi.
                {
                    textTC.Text = suankiogrenci.Tc.ToString(); // Ogrencideki Tc, textTC' ye yazıldı.
                    textADSOYAD.Text = suankiogrenci.Adsoyad.ToString(); // Ogrencideki Adsoyad, textADSOYAD' a yazıldı.
                    textYAS.Text = suankiogrenci.yas.ToString(); // Ogrencideki yas, textYAS' a yazıldı.
                    textTELEFON.Text = suankiogrenci.telefon.ToString(); // Ogrencideki telefon, textTELEFON' a yazıldı.
                    textADRES.Text = suankiogrenci.adres.ToString(); // Ogrencideki adres, textADRES' a yazıldı.
                    textEMAIL.Text = suankiogrenci.email.ToString(); // Ogrencideki email, textEMAIL' e yazıldı.
                    textBORC.Text = suankiogrenci.borc.ToString(); // Ogrencideki borc, textBORC' a yazıldı.
                    textSIFRE.Text = suankiogrenci.sifre.ToString(); // Ogrencideki sifre, textSIFRE' ye yazıldı.
                }
            }
            else // textBoxID boş ise else'e girildi.
            {
                textTC.Text = String.Empty; // textTC  boş gösterildi.
                textADSOYAD.Text = String.Empty; // textADSOYAD  boş gösterildi.
                textYAS.Text = String.Empty; // textYAS  boş gösterildi.
                textTELEFON.Text = String.Empty; // textTELEFON  boş gösterildi.
                textADRES.Text = String.Empty; // textADRES  boş gösterildi.
                textEMAIL.Text = String.Empty; // textEMAIL  boş gösterildi.
                textBORC.Text = String.Empty; // textBORC  boş gösterildi.
                textSIFRE.Text = String.Empty; // textSIFRE  boş gösterildi.
            }
        }

        private void button1_Click(object sender, EventArgs e) // borç sorgula butonu için oluşturuldu.
        {
            string ad = textADSOYAD.Text; // textADSOYAD KitapDal' da OgrenciBul metodu içerisindeki parametreye atandı.
            Ogrenci ogrenci = ogrenciService.OgrenciBul(ad); // ad Ogrenci' ye atandı.
            dgwemntliste.DataSource = emanetService.listele().Where(x => x.ogr_ID == ogrenci.Id).ToList(); // Kitabı hangi öğrencilerin aldığını görüntüleyebilmek için emanet listeleden veritabanındaki ogr_ID ve programdaki Id ile eşleşen bilgiler dgwemntliste' da gösterildi.
            tablorenk(); // tablorenk metodu çağrıldı.
        }

        private void buttonGERIDON_Click_1(object sender, EventArgs e) // geriye dön butonu için oluşturuldu.
        {
            Ogrenci_Anasayfa ogrenci_Anasayfa = new Ogrenci_Anasayfa(); // Ogrenci_Anasayfa formundan nesne oluşturuldu.
            ogrenci_Anasayfa.Show(); // ogrenci_Anasayfa formuna gidildi.
            this.Close(); // Önceki form kapatıldı.
        }
    }
}
