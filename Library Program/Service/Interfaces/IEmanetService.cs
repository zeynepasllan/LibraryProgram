using Entities.Concrete; // Klasör kütüphanesi
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IEmanetService : IBaseService<Emanet> //  IEmanetService' a  Temel Service Emanet sınıfına erişmek için kalıtım aldırıldı.
    {
      
        void BorcGuncelle();  // BorcGuncelle metodu çağrıldı.
    }
}