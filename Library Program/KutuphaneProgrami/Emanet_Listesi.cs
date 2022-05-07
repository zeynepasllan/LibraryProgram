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
    public partial class Emanet_Listesi : Form
    {
       
        IEmanetService emanetService; // EmanetService' den nesne oluşturabilmek için IEmanetService'dan bir değişken tanımlandı.
        List<Emanet> emanetler; // Emanet classının listesine erişebilmek için bir değişken tanımlandı.
        public Emanet_Listesi()
        {
            InitializeComponent();
            emanetService = new EmanetService(); // Nesne oluşturuldu.
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

        private void buttonKTPHNANASAYFA_Click(object sender, EventArgs e) // kütüphaneye dön butonu için oluşturuldu.
        {
            Kutuphane_Anasayfa kutuphane_Anasayfa = new Kutuphane_Anasayfa(); // Kutuphane_Anasayfa formundan nesne oluşturuldu.
            kutuphane_Anasayfa.Show(); // kutuphane_Anasayfa formuna gidildi.
            this.Close(); // Önceki form kapatıldı.
        }

        private void Emanet_Listesi_Load(object sender, EventArgs e) // Form çalıştırıldığı anda gelmesi gerekenler için oluşturuldu.
        {
            tablorenk(); // Form çalıştığında tablorenk metodu çağrıldı.
        }

        private void textEMNTARA_TextChanged(object sender, EventArgs e) // Id' ye göre emanet araması için oluşturuldu.
        {
            List<Emanet> filterData = emanetler.Where(x => x.Id.ToString().Contains(textEMNTARA.Text.ToLower())).ToList(); // Veritabanında Emanet tablosundan Id ile eşleşen bilgileri çağırması için Emanet listeden filterData değişkeni oluşturuldu.
            if (filterData != null) // Emanet boş değilse if' e girildi.
            {
                dgwemntliste.DataSource = filterData; // Id ile eşleşen bilgileri dgwemntliste' ye yazıldı.
            }
            tablorenk(); // Borçların renge göre tekrar gösterilmesi için tablorenk metodu çağrıldı.
        }
    }
}
