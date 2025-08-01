using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static StokProgrami.appconfig;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StokProgrami
{
    public partial class StokListeleme : Form
    {
        public StokListeleme()
        {
            InitializeComponent();
        }
        //Combobox a veri girileceği zaman kullanıcıları otomatik çekme metodu
        private void KullaniciMevcutComboBoxDoldur()
        {
            using (SqlConnection baglanti = new SqlConnection(AppConfig.BaglantiSatiri))
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT kullanıcı_ad_soyad FROM Kullanıcı", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                comboMevcutKullanıcı.Items.Clear();
                while (read.Read())
                {
                    string kullaniciAdi = read["kullanıcı_ad_soyad"].ToString();
                    if (kullaniciAdi != "")  // Eğer veri boş değilse
                    {
                        comboMevcutKullanıcı.Items.Add(kullaniciAdi);
                    }
                }
                read.Close();
            }
        }
        //DataSet (Veri Kümesi) Oluşturuluyor
        private DataSet datastok = new DataSet();
        private void StokListelemeMetodu()
        {
            // Bağlantı
            using (SqlConnection baglanti = new SqlConnection(AppConfig.BaglantiSatiri))
            {
                baglanti.Open();

                // "SELECT * FROM Stok" sorgusunu ve sql bağlantısını kullanarak SqlDataAdapter oluşturuluyor.
                // SqlDataAdapter, SQL sorgusunu çalıştıyor ve sonuçları DataSetin içine dolduruyor.
                SqlDataAdapter adtr = new SqlDataAdapter("select *from Stok", baglanti);

                // Veriler, Data adlı DataSetin kullanıcı tablosuna dolduruluyor.    
                adtr.Fill(datastok, "Stok");

                // dataGridView1’in yani (Kullanıcı Listeleme Gridi) nin datasource u kullanıcı tablosu olarak ayarlanıyor.
                dataGridView1.DataSource = datastok.Tables["Stok"];
            }
        }
        //Getter ile DataSetteki verilere erişiliyor
        public DataSet Stokdata
        {
            get { return datastok; }
        }
        public void ListeleStok() //Private metoda erişmek için private metodu public bir metodun içinde çağırılıyor
        {
            StokListelemeMetodu();
        }
        private void StokListeleme_Load(object sender, EventArgs e)
        {
            KullaniciMevcutComboBoxDoldur();
            StokListelemeMetodu();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridView içinde olan verilerin çift tıklandığında düzenlemek veya silmek için textboxlara doldurulması
            txtMevcutStokKodu.Text = dataGridView1.CurrentRow.Cells["stok_kodu"].Value.ToString();
            txtMevcutStokAdı.Text = dataGridView1.CurrentRow.Cells["ürün_adı"].Value.ToString();
            txtMevcutStokMiktarı.Text = dataGridView1.CurrentRow.Cells["ürün_miktarı"].Value.ToString();
            txtMevcutAlışFiyatı.Text = dataGridView1.CurrentRow.Cells["stok_alis_fiyati"].Value.ToString();
            txtMevcutSatışFiyatı.Text = dataGridView1.CurrentRow.Cells["stok_satis_fiyati"].Value.ToString();
            comboMevcutKullanıcı.Text = dataGridView1.CurrentRow.Cells["ad_soyad"].Value.ToString();
        }
        private void btnGüncelle_Click_1(object sender, EventArgs e)
        {
            //TextBox'a girilen stok koduna göre'ye göre diğer verileri güncelleme işlemi yapıyor
            if (int.TryParse(txtMevcutStokKodu.Text.Trim(), out int stok_kodu))
            {
                using (SqlConnection baglanti = new SqlConnection(AppConfig.BaglantiSatiri))
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("UPDATE Stok SET stok_kodu = @stok_kodu, ürün_adı = @ürün_adı, ürün_miktarı = @ürün_miktarı, stok_alis_fiyati = @stok_alis_fiyati, stok_satis_fiyati = @stok_satis_fiyati, ad_soyad = @ad_soyad WHERE stok_kodu = @stok_kodu", baglanti);
                    komut.Parameters.AddWithValue("@stok_kodu", stok_kodu);
                    komut.Parameters.AddWithValue("@ürün_adı", txtMevcutStokAdı.Text.Trim());
                    komut.Parameters.AddWithValue("@ürün_miktarı", Convert.ToInt32(txtMevcutStokMiktarı.Text.Trim()));
                    komut.Parameters.AddWithValue("@stok_alis_fiyati", Convert.ToDouble(txtMevcutAlışFiyatı.Text.Trim()));
                    komut.Parameters.AddWithValue("@stok_satis_fiyati", Convert.ToDouble(txtMevcutSatışFiyatı.Text.Trim()));
                    komut.Parameters.AddWithValue("@ad_soyad", comboMevcutKullanıcı.Text.Trim());

                    komut.ExecuteNonQuery();
                    // Komutu çalıştır ve güncellenen satır kontrolü
                    int guncellenenSatirSayisi = komut.ExecuteNonQuery();

                    // Güncelleme işleminin kontrolü
                    if (guncellenenSatirSayisi > 0)
                    {
                        MessageBox.Show("Stok başarıyla güncellendi.");
                    }
                    else
                    {
                        MessageBox.Show("Belirtilen stok kodu bulunamadı.");
                    }

                    // DataGridView'i güncelle
                    datastok.Tables["Stok"].Clear();
                    StokListelemeMetodu();

                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir stok kodu giriniz.");
            }
            //Güncellendikten sonra textboxların silinmesi için
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //TextBox'a girilen stok koduna göre'ye göre diğer verileri güncelleme işlemi yapıyor
            if (int.TryParse(txtMevcutStokKodu.Text.Trim(), out int stok_kodu))
            {
                using (SqlConnection baglanti = new SqlConnection(AppConfig.BaglantiSatiri))
                {
                    baglanti.Open();

                    //Sql tablosundaki veriyi stok koduna göre silme işlemi
                    SqlCommand komut = new SqlCommand("DELETE FROM Stok WHERE stok_kodu = @stok_kodu", baglanti);
                    komut.Parameters.AddWithValue("@stok_kodu", stok_kodu);

                    // Komutu çalıştır
                    int silinenSatirSayisi = komut.ExecuteNonQuery();

                    // Silme işleminin kontrolü
                    if (silinenSatirSayisi > 0)
                    {
                        MessageBox.Show("Stok başarıyla silindi.");
                    }
                    else
                    {
                        MessageBox.Show("Belirtilen stok bulunamadı.");
                    }

                    datastok.Tables["Stok"].Clear();
                    StokListelemeMetodu();

                }

            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir stok kodu giriniz.");
            }
            //Güncellendikten sonra textboxların silinmesi için
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void txtStokKodaGöreAra_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection(AppConfig.BaglantiSatiri))
            {
                baglanti.Open();
                //Arama sonuçlarını tutacağımız bir tablo açıyor
                DataTable aramatablosu2 = new DataTable();

                // Parametreli SQL sorgusu
                string sorgu = "SELECT * FROM Stok WHERE stok_kodu LIKE @stok_kodu";
                SqlDataAdapter adtr = new SqlDataAdapter(sorgu, baglanti);

                // Stok Koduna Göre Sonuçları Listeleyen Sql Parametresi
                adtr.SelectCommand.Parameters.AddWithValue("@stok_kodu", "%" + txtStokKodaGöreAra.Text + "%");

                //Sql sorgusundan dönen verileri aramatablosuna dolduruyoruz
                adtr.Fill(aramatablosu2);

                //Verilerin ekranda görüntülenmesi için datagridviewin kaynağını arama tablosu yapıyoruz
                dataGridView1.DataSource = aramatablosu2;
            }
        }
        //Stok koduna göre diğer textboxların doldurulması
        private void txtMevcutStokKodu_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection(AppConfig.BaglantiSatiri))
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from Stok where stok_kodu like '" + txtMevcutStokKodu.Text + "' ", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    txtMevcutStokAdı.Text = read["ürün_adı"].ToString();
                    txtMevcutStokMiktarı.Text = read["ürün_miktarı"].ToString();
                    txtMevcutAlışFiyatı.Text = read["stok_alis_fiyati"].ToString();
                    txtMevcutSatışFiyatı.Text = read["stok_satis_fiyati"].ToString();
                    comboMevcutKullanıcı.Text = read["ad_soyad"].ToString();
                }
            }
        }
    }
}

