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
using ZedGraph;

namespace KutuphaneProgrami
{
    
    public partial class Kutuphane_Grafiği : Form
    {
        IKitapService kitapService; // KitapService' den nesne oluşturabilmek için IKitapService'dan bir değişken tanımlandı.
        IEmanetService emanetService; // EmanetService' den nesne oluşturabilmek için IEmanetService'dan bir değişken tanımlandı.
        public Kutuphane_Grafiği()
        {
            InitializeComponent();
            kitapService = new KitapService(); // Nesne oluşturuldu.
            emanetService = new EmanetService(); // Nesne oluşturuldu.
            drawGraph();  // drawGraph tanımlandı.
        }
        private void drawGraph() // geriye değer döndürmeyen drawGraph metodu oluşturuldu.
        {

            GraphPane myPane = new GraphPane(); // Grafik bölmeleri için nesne oluşturuldu.
            zedGraphControl1.GraphPane = myPane; // oluşturulan nesne zedGraphControl1' a atandı.

            myPane.Title.Text = "Kütüphane Grafiği"; // Grafiğin ismi tanımlandı.
            myPane.XAxis.Title.Text = "Yer"; // Yerleri belirtmek için yer tanımlandı.
            myPane.YAxis.Title.Text = "Sayı"; // Sayıları belirtmek için sayı tanımlandı.
            string[] x0 = new string[3]; // Yazılar sırayla 3 bölmeye ayrıldı.
            double[] y0 = new double[3]; // Sütunlar sırayla 3 bölmeye ayrıldı.

            int Kutuphanedeki_kitap_sayisi = kitapService.listele().Count; // kitap listele metodu Kutuphanedeki_kitap_sayisi' na kitapları listelemek için atandı ve sayıya çevrildi.
            int ogrenciye_verilen_kitap_sayisi= emanetService.listele().Count; // emanet listele metodu ogrenciye_verilen_kitap_sayisi' na emanetleri listelemek için atandı ve sayıya çevrildi.
            int verilmeye_hazir_olan_kitap_sayisi = kitapService.listele().Count - emanetService.listele().Count; // verilmeye hazır olan kitap sayısını belirtebilmek için kitap sayısından emanet verilen kitap sayısı çıkarıldı ve verilmeye_hazir_olan_kitap_sayisi' na atandı.

            x0[0] = "Tüm Kitap\nSayısı"; // 1. sütun için Tüm Kitap Sayısı yazdırıldı.
            x0[1] = "Verilen\nKitap Sayısı"; // 2. sütun için Verilen Kitap Sayısı yazdırıldı.
            x0[2] = "Verilmeye Hazır\nKitap Sayısı"; // 3. sütun için Verilmeye Hazır Kitap Sayısı yazdırıldı.
            y0[0] = Kutuphanedeki_kitap_sayisi; // 1. sütun için yukarda tanımlanan Kutuphanedeki_kitap_sayisi değişkeni çağrıldı.
            y0[1] = ogrenciye_verilen_kitap_sayisi; // 2. sütun için yukarda tanımlanan ogrenciye_verilen_kitap_sayisi değişkeni çağrıldı.
            y0[2] = verilmeye_hazir_olan_kitap_sayisi; // 3. sütun için yukarda tanımlanan verilmeye_hazir_olan_kitap_sayisi değişkeni çağrıldı.


            BarItem myCurve;
            myCurve = myPane.AddBar("Book Item Count", null, y0, Color.Black);

            myCurve.Bar.Fill = new Fill(Color.Black, Color.Black, Color.Black, 0f); // Grafiğin genel rengi siyah olarak ayarlandı.

            myPane.XAxis.Scale.TextLabels = x0; // Xasis labelindaki yazı yazıldı.

            myPane.XAxis.Type = AxisType.Text; // Type' ı verildi.

            myPane.BarSettings.Base = BarBase.X; // Base' e atandı.

            myPane.AxisChange(); // AxisChange çağrıldı.

        }

        private void buttonKTPHNANASAYFA_Click(object sender, EventArgs e) // kütüphaneye dön butonu için oluşturuldu.
        {
            Kutuphane_Anasayfa kutuphane_Anasayfa = new Kutuphane_Anasayfa(); // Kutuphane_Anasayfa formundan nesne oluşturuldu.
            kutuphane_Anasayfa.Show(); // kutuphane_Anasayfa formuna gidildi.
            this.Close(); // Önceki form kapatıldı.
        }
    }
}
