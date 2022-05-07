using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Ogrenci
    {
        public int Id { get; set; } // int türünde Id değişkeni tanımlandı. Hem okunup hem yazılabilmesi için get, set kullanıldı.
        public string Tc { get; set; } // string türünde Tc değişkeni tanımlandı. Hem okunup hem yazılabilmesi için get, set kullanıldı.
        public string Adsoyad { get; set; } // string türünde Adsoyad değişkeni tanımlandı. Hem okunup hem yazılabilmesi için get, set kullanıldı.
        public int yas { get; set; } // int türünde yas değişkeni tanımlandı. Hem okunup hem yazılabilmesi için get, set kullanıldı.

        public string telefon { get; set; } // string türünde telefon değişkeni tanımlandı. Hem okunup hem yazılabilmesi için get, set kullanıldı.
        public string adres { get; set; } // string türünde adres değişkeni tanımlandı. Hem okunup hem yazılabilmesi için get, set kullanıldı.
        public string email { get; set; } // string türünde email değişkeni tanımlandı. Hem okunup hem yazılabilmesi için get, set kullanıldı.
        public int borc { get; set; } // int türünde borc değişkeni tanımlandı. Hem okunup hem yazılabilmesi için get, set kullanıldı.
        public string sifre { get; set; } // string türünde sifre değişkeni tanımlandı. Hem okunup hem yazılabilmesi için get, set kullanıldı.

    }
}