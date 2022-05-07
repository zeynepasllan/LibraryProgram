using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Utilities
{
    public class Baglanti // Bağlantıya ulaşabilmek için class açıldı.
    {
        public static string getir() // Bağlantıyı çalıştıracak olan string türünde getir metodu oluşturuldu.
        {
            return "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Kutuphane2.mdb"; // Bağlantı adresi yazıldı ve döndürüldü.
        }
    }
}