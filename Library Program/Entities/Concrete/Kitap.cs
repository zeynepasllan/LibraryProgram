using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Kitap
    {
        public int Id { get; set; } // int türünde Id değişkeni tanımlandı. Hem okunup hem yazılabilmesi için get, set kullanıldı.
        public string ad { get; set; } // string türünde ad değişkeni tanımlandı. Hem okunup hem yazılabilmesi için get, set kullanıldı.
        public string yazar { get; set; } // string türünde yazar değişkeni tanımlandı. Hem okunup hem yazılabilmesi için get, set kullanıldı.
        public string yayinevi { get; set; } // string türünde yayinevi değişkeni tanımlandı. Hem okunup hem yazılabilmesi için get, set kullanıldı.

        public int sayfasayisi { get; set; } // int türünde sayfasayisi değişkeni tanımlandı. Hem okunup hem yazılabilmesi için get, set kullanıldı.
        public string turu { get; set; } // string türünde turu değişkeni tanımlandı. Hem okunup hem yazılabilmesi için get, set kullanıldı.
        public DateTime basimtarihi { get; set; } // DateTime türünde basimtarihi değişkeni tanımlandı. Hem okunup hem yazılabilmesi için get, set kullanıldı.
    }
}