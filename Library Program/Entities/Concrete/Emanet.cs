using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Emanet
    {
        public int Id { get; set; } // int türünde Id değişkeni tanımlandı. Hem okunup hem yazılabilmesi için get, set kullanıldı.
        public int ogr_ID { get; set; } // int türünde ogr_ID değişkeni tanımlandı. Hem okunup hem yazılabilmesi için get, set kullanıldı.
        public int ktp_ID { get; set; } // int türünde ktp_ID değişkeni tanımlandı. Hem okunup hem yazılabilmesi için get, set kullanıldı.
        public DateTime Kitap_Alimi { get; set; } // DateTime türünde Kitap_Alimi değişkeni tanımlandı. Hem okunup hem yazılabilmesi için get, set kullanıldı.

        public DateTime Iade_Islemleri { get; set; } // DateTime türünde Iade_Islemleri değişkeni tanımlandı. Hem okunup hem yazılabilmesi için get, set kullanıldı.

        public DateTime? TeslimEdilenTarih { get; set; } // DateTime türünde TeslimEdilenTarih değişkeni tanımlandı. Hem okunup hem yazılabilmesi için get, set kullanıldı. Boş olması durumu için '?' kullanıldı.
        public int Borc { get; set; } // int türünde Borc değişkeni tanımlandı. Hem okunup hem yazılabilmesi için get, set kullanıldı.
    }
}