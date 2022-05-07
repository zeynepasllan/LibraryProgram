using Entities.Concrete; //Klasör kütüphanesi
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interfaces
{
    public interface IKitapDal : IBaseDal<Kitap> //  IKitapDal' a  Temel Kitap sınıfına erişmek için kalıtım aldırıldı.
    {
        Kitap KitapBul(string ad); // Kitap sınıfındaki ad parametreli KitapBul metodu çağrıldı.
    }
}