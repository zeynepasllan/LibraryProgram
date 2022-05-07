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
    public class KitapService : IKitapService // KitapService' a IKitapService' daki metotları kullanabilmek için kalıtım aldırıldı.
    {
        IKitapDal kitapDal; // KitapDal' dan nesne oluşturabilmek için IKitapDal'dan bir değişken tanımlandı.

        public KitapService()
        {
            kitapDal = new KitapDal(); // nesne oluşturuldu.
        }
        public void ekle(Kitap entity) // entity parametreli erişilebilir ekle metodu
        {

            kitapDal.ekle(entity);  // ekle komutu çağrıldı.
        }

        public void guncelle(Kitap entity) // entity parametreli erişilebilir guncelle metodu
        {
            kitapDal.guncelle(entity);  // guncelle komutu çağrıldı.
        }

        public Kitap KitapBul(string ad) // ad parametreli erişilebilir KitapBul metodu
        {
            return kitapDal.KitapBul(ad); // KitapBul komutu döndürüldü.
        }

        public List<Kitap> listele() // erişilebilir listele metodu
        {
            return kitapDal.listele(); // listeleme komutu döndürüldü.
        }

        public void sil(int id) // id parametreli erişilebilir sil metodu
        {
            kitapDal.sil(id); // sil komutu çağrıldı.
        }
    }
}