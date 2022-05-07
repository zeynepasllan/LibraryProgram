using DataLayer.Concrete; // Klasör kütüphanesi
using DataLayer.Interfaces; // Klasör kütüphanesi
using Entities.Concrete; // Klasör kütüphanesi
using Service.Interfaces; // Klasör kütüphanesi
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Concrete
{
    public class OgrenciService : IOgrenciService // OgrenciService' a IOgrenciService' daki metotları kullanabilmek için kalıtım aldırıldı.
    {
        IOgrenciDal ogrenciDal; // OgrenciDal' dan nesne oluşturabilmek için IOgrenciDal'dan bir değişken tanımlandı.
        IEmanetDal emanetDal; // EmanetDal' dan nesne oluşturabilmek için IEmanetDal'dan bir değişken tanımlandı.


        public OgrenciService()
        {
            ogrenciDal = new OgrenciDal(); // nesne oluşturuldu.
            emanetDal = new EmanetDal(); // nesne oluşturuldu.
        }
        public void ekle(Ogrenci entity) // entity parametreli erişilebilir ekle metodu
        {

            ogrenciDal.ekle(entity); // ekle komutu çağrıldı.
        }
        public void sil(int id) // id parametreli erişilebilir sil metodu
        {
            ogrenciDal.sil(id); // sil komutu çağrıldı.
        }
        public void guncelle(Ogrenci entity)  // entity parametreli erişilebilir guncelle metodu
        {
            emanetDal.BorcGuncelle();  // emanetDal'dan BorcGuncelle komutu çağrıldı.
            ogrenciDal.guncelle(entity); // ogrenciDal'dan guncelle komutu çağrıldı.
        }
        public Ogrenci OgrenciBul(string Adsoyad)  // Ogrenci classındaki Adsoyad parametreli erişilebilir OgrenciBul metodu
        {
            return ogrenciDal.OgrenciBul(Adsoyad); // OgrenciBul komutu döndürüldü.
        }
        public List<Ogrenci> listele() // erişilebilir listele metodu
        {
            List<Ogrenci> ogrenciler = ogrenciDal.listele(); // ogrenciDal'dan oluşturulan liste, Ogrenci Listesine atandı.
            foreach (var ogrenci in ogrenciler) // öğrenciler döngüye girdi.
            {
                int toplamBorc = emanetDal.listele().Where(x => x.ogr_ID == ogrenci.Id).Sum(x => x.Borc); // emanetDal'dan ogr_ID' sine göre öğrencinin borçları toplanıp toplamBorc' a atandı.
                ogrenci.borc = toplamBorc; // tomplamBorc ogrenci borcuna atandı.
                ogrenciDal.guncelle(ogrenci); // ogrenciDal'dan ogrenci listesi için guncelle metodu çağrıldı.
            }
            return ogrenciDal.listele(); // listeleme komutu döndürüldü.
        }
        public Ogrenci TCandPassword(string tc, string sifre) // Ogrenci classındaki tc ve sifre parametreli erişilebilir TCandPassword metodu
        {
            return ogrenciDal.TCandPassword(tc, sifre); // TCandPassword komutu döndürüldü.
        }
        void IOgrenciService.BorcGuncelle() // IOgrenciService'deki BorcGuncelle metodu
        {
            emanetDal.BorcGuncelle(); // emanetDal'dan BorcGuncelle komutu çağrıldı.
        }
    }
}