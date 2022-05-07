using DataLayer.Interfaces; //Klasör kütüphanesi
using DataLayer.Utilities; //Klasör kütüphanesi
using Entities.Concrete; //Klasör kütüphanesi
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb; // Access kütüphanesi
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Concrete
{
    public class OgrenciDal : IOgrenciDal // OgrenciDal' a IOgrenciDal' daki metotları kullanabilmek için kalıtım aldırıldı.
    {
        private string baglantiSorgusu; // veritabanına ulaşabilmek için dışardan erişilemez değişken tanımlandı.
        public OgrenciDal() // OgrenciDal'ın metodu oluşturuldu.
        {
            baglantiSorgusu = Baglanti.getir(); // veritabanına ulaşabilmek için bağlantı sorgusu çağrılıp baglantiSorgusu değişkenine atandı.
        }

        public void ekle(Ogrenci entity) // Ogrenci eklemek için geriye değer döndürmeyecek erişilebilir ekle metodu oluşturuldu. Veritabanında 
            //Ogrenci tablosundaki alanlara erişebilmek için Ogrenci'den entity adında parametre tanımlandı.
        {
            string query = "insert into Ogrenci (TC,Ad_Soyad,Yas,Telefon,Adres,Email,Borc,Sifre) VALUES (@Tc,@Adsoyad,@yas,@telefon,@adres,@email," +
                "@borc,@sifre)"; // veritabanındaki alan isimleri ile programda karşılıkları olacak değişkenler sağlandı.
            using (OleDbConnection connection = new OleDbConnection(baglantiSorgusu)) // connection nesnesi ile access için bağlantı oluşturuldu ve 
                //baglantiSorgusu ile sorgu çağrıldı.
            {
                using (OleDbCommand selectCommand = new OleDbCommand(query, connection))  // selectCommand nesnesi ile komut sağlandı.
                {
                    connection.Open(); // bağlantı açıldı.
                    selectCommand.Parameters.AddWithValue("@Tc", entity.Tc); // Tc eklendi.
                    selectCommand.Parameters.AddWithValue("@Adsoyad", entity.Adsoyad); // Adsoyad eklendi.
                    selectCommand.Parameters.AddWithValue("@yas", entity.yas); // yas eklendi.
                    selectCommand.Parameters.AddWithValue("@telefon", entity.telefon); // telefon eklendi.
                    selectCommand.Parameters.AddWithValue("@adres", entity.adres); // adres eklendi.
                    selectCommand.Parameters.AddWithValue("@email", entity.email); // email eklendi.
                    selectCommand.Parameters.AddWithValue("@borc", entity.borc); // borc eklendi.
                    selectCommand.Parameters.AddWithValue("@sifre", entity.sifre); // sifre eklendi.
                    selectCommand.ExecuteNonQuery(); // ekleme işleminden etkilenen satır kümesi döndürüldü.
                    connection.Close(); // bağlantı kapandı.
                }

            }
        }

        public void guncelle(Ogrenci entity) // Ogrenci güncellemek için geriye değer döndürmeyecek erişilebilir guncelle metodu oluşturuldu. 
            //Veritabanında Ogrenci tablosundaki alanlara erişebilmek için Ogrenci'den entity adında parametre tanımlandı.
        {
            string query = "Update Ogrenci set TC= @Tc, Ad_Soyad= @Adsoyad, Yas= @yas,  Telefon= @telefon, Adres= @adres, Email=@email, Borc=@borc," +
                " Sifre=@sifre where ogr_ID= @Id"; // veritabanındaki alan isimleri programda tanımlanan değişkenlere, ogr_ID' ye göre güncellenmek
            //için atandı.
            using (OleDbConnection connection = new OleDbConnection(baglantiSorgusu)) // connection nesnesi ile access için bağlantı oluşturuldu ve
                //baglantiSorgusu ile sorgu çağrıldı.
            {
                using (OleDbCommand selectCommand = new OleDbCommand(query, connection)) // selectCommand nesnesi ile komut sağlandı.
                {
                    connection.Open(); // bağlantı açıldı.
                    selectCommand.Parameters.AddWithValue("@Tc", entity.Tc); // Tc güncellendi.
                    selectCommand.Parameters.AddWithValue("@Adsoyad", entity.Adsoyad); // Adsoyad güncellendi.
                    selectCommand.Parameters.AddWithValue("@yas", entity.yas); // yas güncellendi.
                    selectCommand.Parameters.AddWithValue("@telefon", entity.telefon); // telefon güncellendi.
                    selectCommand.Parameters.AddWithValue("@adres", entity.adres); // adres güncellendi.
                    selectCommand.Parameters.AddWithValue("@email", entity.email); // email güncellendi.
                    selectCommand.Parameters.AddWithValue("@borc", entity.borc); // borc güncellendi.
                    selectCommand.Parameters.AddWithValue("@sifre", entity.sifre); // sifre güncellendi.
                    selectCommand.Parameters.AddWithValue("@Id", entity.Id); // Id güncellendi.
                    selectCommand.ExecuteNonQuery(); // güncelleme işleminden etkilenen satır kümesi döndürüldü.
                    connection.Close(); // bağlantı kapandı.
                }
            }
        }

        public Ogrenci OgrenciBul(string Adsoyad)  // Ogrenci bulmak için geriye değer döndürmeyecek erişilebilir OgrenciBul metodu oluşturuldu.
        {   
            string query = "Select * from Ogrenci where Ad_Soyad Like @Adsoyad"; // Ad_Soyad' a göre Ogrenci tablosu listelendi.
            using (OleDbConnection connection = new OleDbConnection(baglantiSorgusu)) // connection nesnesi ile access için bağlantı oluşturuldu ve baglantiSorgusu ile sorgu çağrıldı.                                                                                    
            {
                using (OleDbCommand selectCommand = new OleDbCommand(query, connection)) // selectCommand nesnesi ile komut sağlandı.
                {
                    connection.Open(); // bağlantı açıldı.
                    DataTable table = new DataTable(); // table nesnesi oluşturuldu.
                    selectCommand.Parameters.AddWithValue("@Adsoyad", Adsoyad); // Adsoyad arandı.
                    OleDbDataReader dr = selectCommand.ExecuteReader(); // veritabanındaki Ogrenci tablosu verilerini okuması için komut oluşturuldu.
                    Ogrenci ogrenci = null; // Ogrenci listesine null atandı.
                    while (dr.Read()) // Ogrenci listesi oluşana kadar komut okundu.
                    {
                        ogrenci = new Ogrenci // Ogrenci listesine yazma komutu.
                        {
                            Id = Convert.ToInt32(dr["ogr_ID"].ToString()), // ogr_ID bulundu.
                            Tc = dr["TC"].ToString(), // TC bulundu.
                            Adsoyad = dr["Ad_Soyad"].ToString(), // Ad_Soyad bulundu.
                            yas = Convert.ToInt32(dr["Yas"].ToString()), // Yas bulundu.
                            telefon = dr["Telefon"].ToString(), // Telefon bulundu.
                            adres = dr["Adres"].ToString(), // Adres bulundu.
                            email = dr["Email"].ToString(), // Email bulundu.
                            borc = Convert.ToInt32(dr["Borc"].ToString()), // Borc bulundu.
                            sifre = dr["Sifre"].ToString(), // Sifre bulundu.
                        };
                    }
                    if (ogrenci != null) // Liste boş değilse
                    {
                        return ogrenci; // ogrenci döndürüldü.
                    }
                }
                connection.Close(); // bağlantı kapandı.
            }
            return null; // null döndürüldü.      
        }

        public List<Ogrenci> listele() // veritabanınıdaki Ogrenci tablosunu listelemek için geriye değer döndürmeyecek erişilebilir listele metodu oluşturuldu. 
        {
            string query = "Select * from Ogrenci"; // Ogrenci tablosu listelendi.
            using (OleDbConnection connection = new OleDbConnection(baglantiSorgusu)) // connection nesnesi ile access için bağlantı oluşturuldu ve baglantiSorgusu ile sorgu çağrıldı.
            {
                using (OleDbCommand selectCommand = new OleDbCommand(query, connection)) // selectCommand nesnesi ile komut sağlandı.
                {
                    connection.Open(); // bağlantı açıldı.
                    DataTable table = new DataTable(); // table nesnesi oluşturuldu.
                    OleDbDataReader dr = selectCommand.ExecuteReader(); // veritabanındaki Ogrenci tablosu verilerini okuması için komut oluşturuldu.
                    List<Ogrenci> ogrenciler = new List<Ogrenci>(); // Ogrenci listesi için ogrenciler isimli nesne oluşturuldu.
                    while (dr.Read()) // Ogrenci listesi oluşana kadar komut okundu.
                    {

                        ogrenciler.Add(new Ogrenci // Ogrenci listesine yazma komutu.
                        {
                            Id = Convert.ToInt32(dr["ogr_ID"].ToString()),  // ogr_ID listelendi.
                            Tc = dr["TC"].ToString(),  // TC listelendi.
                            Adsoyad = dr["Ad_Soyad"].ToString(),  // Ad_Soyad listelendi.
                            yas = Convert.ToInt32(dr["Yas"].ToString()), // Yas listelendi.
                            telefon = dr["Telefon"].ToString(), // Telefon listelendi.
                            adres = dr["Adres"].ToString(), // Adres listelendi.
                            email = dr["Email"].ToString(), // Email listelendi.
                            borc = Convert.ToInt32(dr["Borc"].ToString()), // Borc listelendi.
                            sifre = dr["Sifre"].ToString() // Sifre listelendi.
                        });
                    }
                    connection.Close(); // bağlantı kapandı.
                    return ogrenciler; // kitaplar döndürüldü.
                }
            }

        }

        public void sil(int id) // Ogrenci silmek için geriye değer döndürmeyecek erişilebilir sil metodu oluşturuldu. 
        {
            string query = "delete from Ogrenci where ogr_ID = @Id"; // Ogrenci tablosunda ogr_ID' ye göre silme işlemi yapıldı.
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

        public Ogrenci TCandPassword(string tc, string sifre)  // Öğrenci girişi için geriye değer döndürmeyecek erişilebilir TCandPassword metodu oluşturuldu. Tc ve sifre adında string parametreler tanımlandı.
        {
            string query = "SELECT * FROM Ogrenci where TC =@Tc AND Sifre=@sifre"; // Öğrencinin kendi tc ve sifresiyle girebilmesi için oluşturulan sorgu. Veritabanındaki TC programdaki Tc' ye, Sifre sifre' ye atandı.
            using (OleDbConnection connection = new OleDbConnection(baglantiSorgusu)) // connection nesnesi ile access için bağlantı oluşturuldu ve baglantiSorgusu ile sorgu çağrıldı.
            {
                using (OleDbCommand selectCommand = new OleDbCommand(query, connection)) // selectCommand nesnesi ile komut sağlandı.
                {
                    connection.Open(); // bağlantı açıldı.
                    DataTable table = new DataTable(); // table nesnesi oluşturuldu.
                    selectCommand.Parameters.AddWithValue("@Tc", tc); // Tc silindi.
                    selectCommand.Parameters.AddWithValue("@sifre", sifre); // sifre silindi.
                    OleDbDataReader dr = selectCommand.ExecuteReader(); // veritabanındaki Öğrenci tablosu verilerini okuması için komut oluşturuldu.
                    Ogrenci ogrenci = null; // Öğrenci listesine null atandı.
                    while (dr.Read()) // Öğrenci listesi oluşana kadar komut okundu.
                    {
                        ogrenci = new Ogrenci // Öğrenci listesine yazma komutu.
                        {
                            Id = Convert.ToInt32(dr["ogr_ID"].ToString()), // ogr_ID listelendi.
                            Tc = dr["TC"].ToString(), // TC listelendi.
                            Adsoyad = dr["Ad_Soyad"].ToString(), // Ad_Soyad listelendi.
                            yas = Convert.ToInt32(dr["Yas"].ToString()), // Yas listelendi.
                            telefon = dr["Telefon"].ToString(), // Telefon listelendi.
                            adres = dr["Adres"].ToString(), // Adres listelendi.
                            email = dr["Email"].ToString(), // Email listelendi.
                            borc = Convert.ToInt32(dr["Borc"].ToString()), // Borc listelendi.
                            sifre = dr["Sifre"].ToString() // Sifre listelendi.

                        };
                    }
                    if (ogrenci != null) // Liste boş değilse
                    {
                        return ogrenci; // ogrenci döndürüldü.
                    }

                }
                connection.Close(); // bağlantı kapandı.

            }
            return null; // null döndürüldü.
        }

   public void BorcGuncelle() // Ogrenci borcunu güncellemek için geriye değer döndürmeyecek erişilebilir BorcGuncelle metodu oluşturuldu.
        {
            string query = "Update Ogrenci set Borc = DATEDIFF('d',Iade_Islemleri,Date()) WHERE TeslimEdilenTarih is null"; // Veritabanındaki Ogrenci tablosunun Borc alanında TeslimEdilenTarih boş ve Iade_Islemleri tarihi bugünün tarihinden küçükse öğrenci üzerine aradaki fark kadar borç yazdıracak sorgu.
            using (OleDbConnection connection = new OleDbConnection(baglantiSorgusu)) // connection nesnesi ile access için bağlantı oluşturuldu ve baglantiSorgusu ile sorgu çağrıldı.
            {
                using (OleDbCommand selectCommand = new OleDbCommand(query, connection)) // selectCommand nesnesi ile komut sağlandı.
                {
                    connection.Open(); // bağlantı açıldı.
                    selectCommand.ExecuteNonQuery(); // BorcGuncelle işleminden etkilenen satır kümesi döndürüldü.
                    connection.Close(); // bağlantı kapandı.     
                }

            }
        } 
    }
}

