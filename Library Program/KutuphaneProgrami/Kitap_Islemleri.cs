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
    public partial class Kitap_Islemleri : Form
    {
        IKitapService kitapService; // KitapService' den nesne oluşturabilmek için IKitapService'dan bir değişken tanımlandı.
        List<Kitap> kitaplar; // Kitap classının listesine erişebilmek için bir değişken tanımlandı.
        public Kitap_Islemleri()
        {
            InitializeComponent();
            kitapService = new KitapService(); // Nesne oluşturuldu.
            kitaplar = kitapService.listele(); // kitaplar değişkenine kitap listele atandı.
            DataGridViewFill();  // DataGridViewFill tanımlandı.

        }
        private void DataGridViewFill()
        {
            dgwKITAP.DataSource = kitapService.listele();  // Veritabanından kitaplar çekilip liste şeklinde dgwKITAP' a listelendi.
        }

        private void kitapislem_Load(object sender, EventArgs e) // Form çalıştırıldığı anda gelmesi gerekenler için oluşturuldu.
        {
            textKITAPADI.Text = dgwKITAP.CurrentRow.Cells[1].Value.ToString(); // 1. indexe textKITAPADI' nda yazılı bilgi gösterildi.
            textYAZARI.Text = dgwKITAP.CurrentRow.Cells[2].Value.ToString(); // 2. indexe textYAZARI' nda yazılı bilgi gösterildi.
            textYAYINEVI.Text = dgwKITAP.CurrentRow.Cells[3].Value.ToString(); // 3. indexe textYAYINEVI' nde yazılı bilgi gösterildi.
            textSAYFASAYISI.Text = dgwKITAP.CurrentRow.Cells[4].Value.ToString(); // 4. indexe textSAYFASAYISI' nda yazılı bilgi gösterildi.
            textTURU.Text = dgwKITAP.CurrentRow.Cells[5].Value.ToString(); // 5. indexe textTURU' nde yazılı bilgi gösterildi.
            dtpBASIMTARIHI.Text = dgwKITAP.CurrentRow.Cells[6].Value.ToString(); // 6. indexe dtpBASIMTARIHI' nde yazılı bilgi gösterildi.
        }

        private void buttonKTPEKLE_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap(); // Nesne oluşturuldu.
            kitap.ad = textKITAPADI.Text; // textKITAPADI kitaptaki ad' a atandı.
            kitap.yazar = textYAZARI.Text; // textYAZARI kitaptaki yazar' a atandı.
            kitap.yayinevi = textYAYINEVI.Text; // textYAYINEVI kitaptaki yayinevi' ne atandı.
            kitap.sayfasayisi = Convert.ToInt32(textSAYFASAYISI.Text); // textSAYFASAYISI sayıya dönüştürülüp kitaptaki sayfasayisi' na atandı.
            kitap.turu = textTURU.Text; // textTURU kitaptaki turu' ne atandı.
            kitap.basimtarihi = Convert.ToDateTime(dtpBASIMTARIHI.Text); // dtpBASIMTARIHI tarihe dönüştürülüp kitaptaki basimtarihi' ne atandı.
            kitapService.ekle(kitap);  // Kitap ekle metodu çağrıldı.
            DataGridViewFill(); // Yeni kitaplar listesi gösterildi.
            MessageBox.Show("Kitap Eklendi"); // Ekrana kitabın eklendiğine dair bilgi mesajı verildi.
        }

        private void buttonKTPSIL_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap(); // Nesne oluşturuldu.
            int ktp_id = Convert.ToInt32(textKTPIDD.Text); // textKTPIDD sayıya dönüştürülüp ktp_id' ye atandı.
            kitapService.sil(ktp_id); // Kitap sil metodu çağrıldı.
            DataGridViewFill(); // Yeni kitaplar listesi gösterildi.
            MessageBox.Show("Kitap Silindi :("); // Ekrana kitabın silindiğine dair bilgi mesajı verildi.
        }

        private void buttonKTPGUNC_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap(); // Nesne oluşturuldu.
            kitap.ad = textKITAPADI.Text; // textKITAPADI kitaptaki ad' a atandı.
            kitap.yazar = textYAZARI.Text; // textYAZARI kitaptaki yazar' a atandı.
            kitap.yayinevi = textYAYINEVI.Text; // textYAYINEVI kitaptaki yayinevi' ne atandı.
            kitap.sayfasayisi = Convert.ToInt32(textSAYFASAYISI.Text); // textSAYFASAYISI sayıya dönüştürülüp kitaptaki sayfasayisi' na atandı.
            kitap.turu = textTURU.Text; // textTURU kitaptaki turu' ne atandı.
            kitap.basimtarihi = Convert.ToDateTime(dtpBASIMTARIHI.Text); // dtpBASIMTARIHI tarihe dönüştürülüp kitaptaki basimtarihi' ne atandı.
            kitap.Id = Convert.ToInt32(textKTPIDD.Text); // textKTPIDD kitaptaki Id' ye atandı.
            kitapService.guncelle(kitap);  // Kitap guncelle metodu çağrıldı.
            DataGridViewFill(); // Yeni kitaplar listesi gösterildi.
            MessageBox.Show("Kitap Güncellendi"); // Ekrana kitabın güncellendiğine dair bilgi mesajı verildi.
        }

      

        private void dgwKITAP_SelectionChanged(object sender, EventArgs e) // dgwKITAP' ta seçim değiştikçe aşağıdaki işlemleri yapması için oluşturuldu.
        {
            textKTPIDD.Text = dgwKITAP.CurrentRow.Cells[0].Value.ToString(); // 0. indexe textKTPIDD' de yazılı bilgi gösterildi.
            textKITAPADI.Text = dgwKITAP.CurrentRow.Cells[1].Value.ToString(); // 1. indexe textKITAPADI' nda yazılı bilgi gösterildi.
            textYAZARI.Text = dgwKITAP.CurrentRow.Cells[2].Value.ToString(); // 2. indexe textYAZARI' nda yazılı bilgi gösterildi.
            textYAYINEVI.Text = dgwKITAP.CurrentRow.Cells[3].Value.ToString(); // 3. indexe textYAYINEVI' nde yazılı bilgi gösterildi.
            textSAYFASAYISI.Text = dgwKITAP.CurrentRow.Cells[4].Value.ToString(); // 4. indexe textSAYFASAYISI' nda yazılı bilgi gösterildi.
            textTURU.Text = dgwKITAP.CurrentRow.Cells[5].Value.ToString(); // 5. indexe textTURU' nde yazılı bilgi gösterildi.
            dtpBASIMTARIHI.Text = dgwKITAP.CurrentRow.Cells[6].Value.ToString(); // 6. indexe dtpBASIMTARIHI' nde yazılı bilgi gösterildi.


        }

        private void buttonKTPHNANASAYFA_Click(object sender, EventArgs e) // kütüphaneye dön butonu için oluşturuldu.
        {

            Kutuphane_Anasayfa kutuphane_Anasayfa = new Kutuphane_Anasayfa(); // Kutuphane_Anasayfa formundan nesne oluşturuldu.
            kutuphane_Anasayfa.Show(); // kutuphane_Anasayfa formuna gidildi.
            this.Close(); // Önceki form kapatıldı.
        }

        private void textKITAPARA_TextChanged(object sender, EventArgs e) // ad' a göre kitap araması için oluşturuldu.
        {          
            List<Kitap> filterData = kitaplar.Where(x => x.ad.ToLower().Contains(textKITAPARA.Text.ToLower())).ToList(); // Veritabanında Kitap tablosundan ad ile eşleşen bilgileri çağırması için Kitap listeden filterData değişkeni oluşturuldu.
            if (filterData != null) // Kitap boş değilse if' e girildi.
            {
                dgwKITAP.DataSource = filterData; // ad ile eşleşen bilgileri dgwKITAP' a yazıldı.
            }
        }
    }
}