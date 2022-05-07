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
    public partial class Kutuphane_Giris : Form
    {
        Form form;
        public Kutuphane_Giris(Form form)
        {
            InitializeComponent();
            this.form = form;
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e); 
            form.Close();
        }

        private void buttonGIRIS_Click(object sender, EventArgs e)
        {
            string kullaniciadi = textKULLANICIADI.Text; // textKULLANICIADI, kullaniciadi' na atandı.
            string sifre = textSIFRE.Text; // textSIFRE, sifre' ye atandı.
            if (textKULLANICIADI.Text == "Zeynep" && textSIFRE.Text == "123") // eğer textKULLANICIADI Zeynep ve textSIFRE 123 ise if' e girildi.
            {
                Kutuphane_Anasayfa kutuphane_Anasayfa = new Kutuphane_Anasayfa(); // Kutuphane_Anasayfa formundan nesne oluşturuldu.
                kutuphane_Anasayfa.Show(); // kutuphane_Anasayfa formuna gidildi.
                this.Hide(); // Önceki form kapatıldı.
            }
            else // if koşulu sağlanmadıysa else' e girildi.
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı"); // Ekrana girilen bilgilerin hatalı olduğuna dair mesaj verildi.
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();  // Giris formundan nesne oluşturuldu.
            giris.Show();  // giris formuna gidildi.
            this.Hide(); // Önceki form kapatıldı.
        }
    }
}