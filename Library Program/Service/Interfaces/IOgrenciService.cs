using Entities.Concrete; //Klasör kütüphanesi
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IOgrenciService : IBaseService<Ogrenci>//  IOgrenciDal' a  Temel Service Ogrenci sınıfına erişmek için kalıtım aldırıldı ve oluşturuldu.
    {
        Ogrenci OgrenciBul(string Adsoyad); // OgrenciDal sınıfındaki Adsoyad parametreli OgrenciBul metodu çağrıldı.
        Ogrenci TCandPassword(string tc, string sifre);  // OgrenciDal sınıfındaki tc ve sifre parametreli TCandPassword metodu çağrıldı.
        void BorcGuncelle(); // BorcGuncelle metodu çağrıldı.
    }
}