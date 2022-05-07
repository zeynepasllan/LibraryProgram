using Entities.Concrete; // Klasör kütüphanesi
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IKitapService : IBaseService<Kitap> //  IKitapService' a  Temel Service Kitap sınıfına erişmek için kalıtım aldırıldı.
    {
        Kitap KitapBul(string ad); // Kitap sınıfındaki ad parametreli KitapBul metodu çağrıldı.
    }
}