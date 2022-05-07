using DataLayer.Interfaces; // Klasör kütüphanesi
using DataLayer.Utilities; // Klasör kütüphanesi
using Entities.Concrete; // Klasör kütüphanesi
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb; // Access kütüphanesi
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Concrete
{
    public class KitapDal : IKitapDal // KitapDal' a IKitapDal' daki metotları kullanabilmek için kalıtım aldırıldı.
    {
        private string baglantiSorgusu; // veritabanına ulaşabilmek için dışardan erişilemez değişken tanımlandı.
        public KitapDal() // KitapDal'ın metodu oluşturuldu.
        {
            baglantiSorgusu = Baglanti.getir(); // veritabanına ulaşabilmek için bağlantı sorgusu çağrılıp baglantiSorgusu değişkenine atandı.
        }


        public void ekle(Kitap entity) // Kitap eklemek için geriye değer döndürmeyecek erişilebilir ekle metodu oluşturuldu. Veritabanında Kitap tablosundaki alanlara erişebilmek için Kitap'tan entity adında parametre tanımlandı.
        {
            string query = "insert into Kitap (Ad,Yazar,Yayinevi,Sayfa_Sayisi,Turu,Basim_Tarihi) VALUES (@ad,@yazar,@yayinevi,@sayfasayisi,@turu,@basimtarihi)"; // veritabanındaki alan isimleri ile programda karşılıkları olacak değişkenler sağlandı.
            using (OleDbConnection connection = new OleDbConnection(baglantiSorgusu)) // connection nesnesi ile access için bağlantı oluşturuldu ve baglantiSorgusu ile sorgu çağrıldı.
            {
                using (OleDbCommand selectCommand = new OleDbCommand(query, connection))  // selectCommand nesnesi ile komut sağlandı.
                {
                    connection.Open(); // bağlantı açıldı.
                    selectCommand.Parameters.AddWithValue("@ad", entity.ad); // ad eklendi.
                    selectCommand.Parameters.AddWithValue("@yazar", entity.yazar); // yazar eklendi.
                    selectCommand.Parameters.AddWithValue("@yayinevi", entity.yayinevi); // yayinevi eklendi.
                    selectCommand.Parameters.AddWithValue("@sayfasayisi", entity.sayfasayisi); // sayfasayisi eklendi.
                    selectCommand.Parameters.AddWithValue("@turu", entity.turu); // turu eklendi.
                    selectCommand.Parameters.AddWithValue("@basimtarihi", entity.basimtarihi); // basimtarihi eklendi.
                    selectCommand.ExecuteNonQuery(); // ekleme işleminden etkilenen satır kümesi döndürüldü.
                    connection.Close(); // bağlantı kapandı.
                }

            }
        }

        public void guncelle(Kitap entity)  // Kitap güncellemek için geriye değer döndürmeyecek erişilebilir guncelle metodu oluşturuldu. Veritabanında Kitap tablosundaki alanlara erişebilmek için Kitap'tan entity adında parametre tanımlandı.
        {
            string query = "Update Kitap set Ad= @ad, Yazar= @yazar, Yayinevi= @yayinevi,  Sayfa_Sayisi= @sayfasayisi, Turu= @turu, Basim_Tarihi=@basimtarihi where ktp_ID= @Id"; // veritabanındaki alan isimleri programda tanımlanan değişkenlere, ktp_ID' ye göre güncellenmek için atandı.
            using (OleDbConnection connection = new OleDbConnection(baglantiSorgusu)) // connection nesnesi ile access için bağlantı oluşturuldu ve baglantiSorgusu ile sorgu çağrıldı.
            {
                using (OleDbCommand selectCommand = new OleDbCommand(query, connection)) // selectCommand nesnesi ile komut sağlandı.
                {
                    connection.Open(); // bağlantı açıldı.
                    selectCommand.Parameters.AddWithValue("@ad", entity.ad); // ad güncellendi.
                    selectCommand.Parameters.AddWithValue("@yazar", entity.yazar); // yazar güncellendi.
                    selectCommand.Parameters.AddWithValue("@yayinevi", entity.yayinevi); // yayinevi güncellendi.
                    selectCommand.Parameters.AddWithValue("@sayfasayisi", entity.sayfasayisi); // sayfasayisi güncellendi.
                    selectCommand.Parameters.AddWithValue("@turu", entity.turu); // turu güncellendi.
                    selectCommand.Parameters.AddWithValue("@basimtarihi", entity.basimtarihi); // basimtarihi güncellendi.
                    selectCommand.Parameters.AddWithValue("@Id", entity.Id); // Id güncellendi.
                    selectCommand.ExecuteNonQuery(); // güncelleme işleminden etkilenen satır kümesi döndürüldü.
                    connection.Close(); // bağlantı kapandı.
                }

            }
        }

        public Kitap KitapBul(string ad)  // Kitap bulmak için geriye değer döndürmeyecek erişilebilir KitapBul metodu oluşturuldu.
        {
            string query = "Select * from Kitap where Ad Like @ad "; // Ad' a göre Kitap tablosu listelendi.
            using (OleDbConnection connection = new OleDbConnection(baglantiSorgusu)) // connection nesnesi ile access için bağlantı oluşturuldu ve baglantiSorgusu ile sorgu çağrıldı.
            {

                using (OleDbCommand selectCommand = new OleDbCommand(query, connection)) // selectCommand nesnesi ile komut sağlandı.
                { 
                    connection.Open(); // bağlantı açıldı.
                    DataTable table = new DataTable(); // table nesnesi oluşturuldu.
                    selectCommand.Parameters.AddWithValue("@ad", "%" + ad + "%"); // ad arandı.
                    OleDbDataReader dr = selectCommand.ExecuteReader(); // veritabanındaki Kitap tablosu verilerini okuması için komut oluşturuldu.
                    Kitap kitap = null; // Kitap listesinin boş olma durumu
                    while (dr.Read()) // Kitap listesi oluşana kadar komut okundu.
                    {
                        kitap = new Kitap // Kitap listesine yazma komutu
                        {
                            Id = Convert.ToInt32(dr["ktp_ID"].ToString()), // ktp_ID bulundu.
                            ad = dr["Ad"].ToString(), // Ad bulundu.
                            yazar = dr["Yazar"].ToString(), // Yazar bulundu.
                            yayinevi = dr["Yayinevi"].ToString(), // Yayinevi bulundu.
                            sayfasayisi = Convert.ToInt32(dr["Sayfa_Sayisi"].ToString()),  // Sayfa_Sayisi bulundu.
                            turu = dr["Turu"].ToString(), // Turu bulundu.
                            basimtarihi = Convert.ToDateTime(dr["Basim_Tarihi"].ToString()), // Basim_Tarihi bulundu.

                        };
                        break;
                    }
                    if (kitap != null) // Liste boş değilse
                    {
                        return kitap; // kitaplar döndürüldü.
                    }

                }
                connection.Close(); // bağlantı kapandı.

            }
            return null; // null döndürüldü.
        }

        public List<Kitap> listele() // veritabanınıdaki Kitap tablosunu listelemek için geriye değer döndürmeyecek erişilebilir listele metodu oluşturuldu. 
        {
            string query = "Select * from Kitap"; // Kitap tablosu listelendi.
            using (OleDbConnection connection = new OleDbConnection(baglantiSorgusu)) // connection nesnesi ile access için bağlantı oluşturuldu ve baglantiSorgusu ile sorgu çağrıldı.
            {
                using (OleDbCommand selectCommand = new OleDbCommand(query, connection)) // selectCommand nesnesi ile komut sağlandı.
                {
                    connection.Open(); // bağlantı açıldı.
                    DataTable table = new DataTable(); // table nesnesi oluşturuldu.
                    OleDbDataReader dr = selectCommand.ExecuteReader(); // veritabanındaki Kitap tablosu verilerini okuması için komut oluşturuldu.
                    List<Kitap> kitaplar = new List<Kitap>(); // Kitap listesi için kitaplar isimli nesne oluşturuldu.
                    while (dr.Read()) // Liste oluşana kadar komut okundu.
                    {

                        kitaplar.Add(new Kitap // Listeye yazma komutu
                        {
                            Id = Convert.ToInt32(dr["ktp_ID"].ToString()), // ktp_ID listelendi.
                            ad = dr["Ad"].ToString(), // Ad listelendi.
                            yazar = dr["Yazar"].ToString(), // Yazar listelendi.
                            yayinevi = dr["Yayinevi"].ToString(), // Yayinevi listelendi.
                            sayfasayisi = Convert.ToInt32(dr["Sayfa_Sayisi"].ToString()),  // Sayfa_Sayisi listelendi.
                            turu = dr["Turu"].ToString(), // Turu listelendi.
                            basimtarihi = Convert.ToDateTime(dr["Basim_Tarihi"].ToString()), // Basim_Tarihi listelendi.
                        });
                    }
                    connection.Close(); // bağlantı kapandı.
                    return kitaplar; // kitaplar döndürüldü.
                }
            }

        }

        public void sil(int id) // Kitap silmek için geriye değer döndürmeyecek erişilebilir sil metodu oluşturuldu. 
        {
            string query = "delete from Kitap where ktp_ID = @Id"; // Kitap tablosunda ktp_ID' ye göre silme işlemi yapıldı.
            using (OleDbConnection connection = new OleDbConnection(baglantiSorgusu)) // connection nesnesi ile access için bağlantı oluşturuldu ve baglantiSorgusu ile sorgu çağrıldı.
            {
                using (OleDbCommand selectCommand = new OleDbCommand(query, connection)) // selectCommand nesnesi ile komut sağlandı.
                {
                    connection.Open(); // bağlantı açıldı.
                    selectCommand.Parameters.AddWithValue("@Id", id); // Id silindi.
                    selectCommand.ExecuteNonQuery(); // silme işleminden etkilenen satır kümesi döndürüldü.
                    connection.Close(); // bağlantı kapandı.
                }
            }
        }


    }
}

