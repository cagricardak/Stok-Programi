using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokProgrami
{
    internal class Services
    {
        public class VeriTabanıİşlemleri
        {
            public DataSet KullanıcıVerileriniGetir()
            {
                // StokKullanıcıListeleme nesnesi oluştur
                StokKullanıcıListeleme stokKullanıcıListelemeForm = new StokKullanıcıListeleme();

                // Kullanıcı listeleme metodunu çağır
                stokKullanıcıListelemeForm.ListeleKullanici();

                // Verileri döndür
                return stokKullanıcıListelemeForm.Kullanicidata;
            }

            public DataSet StokVerileriniGetir()
            {
                // StokListeleme nesnesi oluştur
                StokListeleme stokListelemeForm = new StokListeleme();

                // Stok listeleme metodunu çağır
                stokListelemeForm.ListeleStok();

                // Verileri döndür
                return stokListelemeForm.Stokdata;
            }

            public DataSet VerileriGuncelle()
            {
                DataSet veriSet = new DataSet();

                // Kullanıcı verilerini getir 
                //Bir datatable yalnızca bir datasete ait olabileceğinden dolayı orijinal DataTable'ı kopyalayarak yeni bir nesne oluşturuyoruz.
                DataTable kullanıcıDataTable = KullanıcıVerileriniGetir().Tables["kullanıcı"].Copy();
                veriSet.Tables.Add(kullanıcıDataTable);

                // Stok verilerini getir
                DataTable stokDataTable = StokVerileriniGetir().Tables["Stok"].Copy();
                veriSet.Tables.Add(stokDataTable);

                //Verisetini döndür
                return veriSet;
            }
        }
    }
}