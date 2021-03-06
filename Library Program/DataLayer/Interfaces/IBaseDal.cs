using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interfaces
{
    public interface IBaseDal<T> // Temel sınıf kalıtımı oluşturuldu.
    {
        List<T> listele(); // listele metodu çağrıldı.
        void ekle(T entity); // entity parametreli ekle metodu çağrıldı.
        void guncelle(T entity); // entity parametreli guncelle metodu çağrıldı.
        void sil(int id); // id parametreli sil metodu çağrıldı.

    }
}