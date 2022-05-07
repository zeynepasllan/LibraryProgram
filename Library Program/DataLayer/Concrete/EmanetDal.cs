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
    public class EmanetDal : IEmanetDal // EmanetDal' a IEmanetDal' daki metotları kullanabilmek için kalıtım aldırıldı.
    {
        private string baglantiSorgusu; // veritabanına ulaşabilmek için dışardan erişilemez değişken tanımlandı.
        public EmanetDal() // EmanetDal'ın metodu oluşturuldu.
        {
            baglantiSorgusu = Baglanti.getir(); // veritabanına ulaşabilmek için bağlantı sorgusu çağrılıp baglantiSorgusu değişkenine atandı.
        }

        public void ekle(Emanet entity) // Emanet kitap eklemek için geriye değer döndürmeyecek erişilebilir ekle metodu oluşturuldu. Veritabanında Emanet tablosundaki alanlara erişebilmek için Emanet'ten entity adında parametre tanımlandı.
        {
            string query = "insert into Emanet (ogr_ID,ktp_ID,Kitap_Alimi,Iade_Islemleri,Borc) VALUES (@ogr_ID,@ktp_ID,@Kitap_Alimi,@Iade_Islemleri,@Borc)"; // veritabanındaki alan isimleri ile programda karşılıkları olacak değişkenler sağlandı.
            using (OleDbConnection connection = new OleDbConnection(baglantiSorgusu)) // connection nesnesi ile access için bağlantı oluşturuldu ve baglantiSorgusu ile sorgu çağrıldı.
            {
                using (OleDbCommand selectCommand = new OleDbCommand(query, connection))  // selectCommand nesnesi ile komut sağlandı.
                {
                    connection.Open(); // bağlantı açıldı.
                    selectCommand.Parameters.AddWithValue("@ogr_ID", entity.ogr_ID); // ogr_ID eklendi.
                    selectCommand.Parameters.AddWithValue("@ktp_ID", entity.ktp_ID); // ktp_ID eklendi.
                    selectCommand.Parameters.AddWithValue("@Kitap_Alimi", entity.Kitap_Alimi); // Kitap_Alimi eklendi.
                    selectCommand.Parameters.AddWithValue("@Iade_Islemleri", entity.Iade_Islemleri); // Iade_Islemleri eklendi.
                    selectCommand.Parameters.AddWithValue("@Borc", entity.Borc); // Borc eklendi.
                    selectCommand.ExecuteNonQuery(); // ekleme işleminden etkilenen satır kümesi döndürüldü.
                    connection.Close(); // bağlantı kapandı.
                }

            }
        }

        public void guncelle(Emanet entity) // Emanet kitap güncellemek için geriye değer döndürmeyecek erişilebilir guncelle metodu oluşturuldu. Veritabanında Emanet tablosundaki alanlara erişebilmek için Emanet'ten entity adında parametre tanımlandı.
        {
            string query = "Update Emanet set ogr_ID= @ogr_ID, ktp_ID= @ktp_ID, Kitap_Alimi= @Kitap_Alimi,  Iade_Islemleri= @Iade_Islemleri, TeslimEdilenTarih=@TeslimEdilenTarih, Borc=@Borc where emnt_ID= @Id"; // veritabanındaki alan isimleri programda tanımlanan değişkenlere, emnt_ID' ye göre güncellenmek için atandı.
            using (OleDbConnection connection = new OleDbConnection(baglantiSorgusu)) // connection nesnesi ile access için bağlantı oluşturuldu ve baglantiSorgusu ile sorgu çağrıldı.
            {
                {
                    using (OleDbCommand selectCommand = new OleDbCommand(query, connection)) // selectCommand nesnesi ile komut sağlandı.
                    {
                        connection.Open(); // bağlantı açıldı.
                        selectCommand.Parameters.AddWithValue("@ogr_ID", entity.ogr_ID); // ogr_ID güncellendi.
                        selectCommand.Parameters.AddWithValue("@ktp_ID", entity.ktp_ID); // ktp_ID güncellendi.
                        selectCommand.Parameters.AddWithValue("@Kitap_Alimi", entity.Kitap_Alimi); // Kitap_Alimi güncellendi.
                        selectCommand.Parameters.AddWithValue("@Iade_Islemleri", entity.Iade_Islemleri); // Iade_Islemleri güncellendi.
                        selectCommand.Parameters.AddWithValue("@TeslimEdilenTarih", entity.TeslimEdilenTarih); // TeslimEdilenTarih güncellendi.
                        selectCommand.Parameters.AddWithValue("@Borc", entity.Borc); // Borc güncellendi.
                        selectCommand.Parameters.AddWithValue("@emnt_ID", entity.Id); // emnt_ID güncellendi.
                        selectCommand.ExecuteNonQuery(); // güncelleme işleminden etkilenen satır kümesi döndürüldü.
                        connection.Close(); // bağlantı kapandı.
                    }

                }
            }       
        }
            public List<Emanet> listele() // veritabanınıdaki Emanet tablosunu listelemek için geriye değer döndürmeyecek erişilebilir listele metodu oluşturuldu. 
        {
                string query = "Select * from Emanet"; // Emanet tablosu listelendi.
                using (OleDbConnection connection = new OleDbConnection(baglantiSorgusu)) // connection nesnesi ile access için bağlantı oluşturuldu ve baglantiSorgusu ile sorgu çağrıldı.
            {
                    using (OleDbCommand selectCommand = new OleDbCommand(query, connection)) // selectCommand nesnesi ile komut sağlandı.
                {
                        connection.Open(); // bağlantı açıldı.
                    DataTable table = new DataTable(); // table nesnesi oluşturuldu.
                        OleDbDataReader dr = selectCommand.ExecuteReader(); // veritabanındaki Emanet tablosu verilerini okuması için komut oluşturuldu.
                        List<Emanet> emanetler = new List<Emanet>(); // Emanet listesi için emanetler isimli nesne oluşturuldu.
                        while (dr.Read()) // Liste oluşana kadar komut okundu.
                        {

                            DateTime? teslimver = null; // veritabanındaki TeslimEdilenTarih alanı boş değilse try alanına girildi.
                        try
                            {
                                teslimver = Convert.ToDateTime(dr["TeslimEdilenTarih"].ToString()); // TeslimEdilenTarih tarihe çevrilip teslimver değişkenine atandı.

                        }
                        catch // veritabanındaki TeslimEdilenTarih alanı boş ise catch alanına girildi.
                        {
                                teslimver = null; // programın hata vermemesi için null atandı.
                            }
                            emanetler.Add(new Emanet // Listeye yazma komutu
                            {
                                Id = Convert.ToInt32(dr["emnt_ID"]), // emnt_ID listelendi.
                                ogr_ID = Convert.ToInt32(dr["ogr_ID"]), // ogr_ID listelendi.
                                ktp_ID = Convert.ToInt32(dr["ktp_ID"]), // ktp_ID listelendi.
                                Kitap_Alimi = Convert.ToDateTime(dr["Kitap_Alimi"].ToString()), // Kitap_Alimi listelendi.
                                Iade_Islemleri = Convert.ToDateTime(dr["Iade_Islemleri"].ToString()), // Iade_Islemleri listelendi.
                                TeslimEdilenTarih = teslimver, // TeslimEdilenTarih listelendi.
                                Borc = Convert.ToInt32(dr["Borc"]?.ToString()) // Borc listelendi.
                            });
                        }
                        connection.Close(); // bağlantı kapandı.
                    return emanetler; // emanetler döndürüldü.
                    }
                }

            }

        public void sil(int id) // Emanet kitap silmek için geriye değer döndürmeyecek erişilebilir sil metodu oluşturuldu. 
        {
            string query = "delete from Emanet where emnt_ID = @Id"; // Emanet tablosunda emnt_ID' ye göre silme işlemi yapıldı.
            using (OleDbConnection connection = new OleDbConnection(baglantiSorgusu)) // connection nesnesi ile access için bağlantı oluşturuldu ve baglantiSorgusu ile sorgu çağrıldı.
            {
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
            public void BorcGuncelle() // Emanet borcunu güncellemek için geriye değer döndürmeyecek erişilebilir BorcGuncelle metodu oluşturuldu.
        {
                string query = "Update Emanet set Borc = DATEDIFF('d',Iade_Islemleri,Date()) WHERE TeslimEdilenTarih is null and Date() > Iade_Islemleri "; // Veritabanındaki Emanet tablosunun Borc alanında TeslimEdilenTarih boş ve Iade_Islemleri tarihi bugünün tarihinden küçükse öğrenci üzerine aradaki fark kadar borç yazdıracak sorgu.
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

