using Entities.Concrete; // Klasör kütüphanesi
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interfaces
{
    public interface IEmanetDal : IBaseDal<Emanet> //  IEmanetDal' a  Temel Emanet sınıfına erişmek için kalıtım aldırıldı.
    {
        void BorcGuncelle(); // BorcGuncelle metodu çağrıldı.
    }
}