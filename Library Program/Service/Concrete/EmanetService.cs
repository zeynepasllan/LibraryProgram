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
    public class EmanetService : IEmanetService // EmanetService' a IEmanetService' daki metotları kullanabilmek için kalıtım aldırıldı.
    {
        IEmanetDal emanetDal; // EmanetDal' dan nesne oluşturabilmek için IEmanetDal'dan bir değişken tanımlandı.

        public EmanetService()
        {
            emanetDal = new EmanetDal(); // nesne oluşturuldu.
        }
        public void ekle(Emanet entity) // entity parametreli erişilebilir ekle metodu
        {

            emanetDal.ekle(entity); // ekle komutu çağrıldı.
        }

        public void guncelle(Emanet entity) // entity parametreli erişilebilir guncelle metodu
        {
            emanetDal.BorcGuncelle();  // BorcGuncelle komutu çağrıldı.
            emanetDal.guncelle(entity);  // guncelle komutu çağrıldı.

        }
     
        public List<Emanet> listele() // erişilebilir listele metodu
        {
            emanetDal.BorcGuncelle(); // BorcGuncelle komutu çağrıldı.
            return emanetDal.listele(); // listeleme komutu döndürüldü.
        }

        public void sil(int id) // id parametreli erişilebilir sil metodu
        {
            emanetDal.sil(id); // sil komutu çağrıldı.
        }

        void IEmanetService.BorcGuncelle() // IEmanetService'deki BorcGuncelle metodu
        {
            emanetDal.BorcGuncelle(); // BorcGuncelle komutu çağrıldı.
        }
    }
}