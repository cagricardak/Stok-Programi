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
using static StokProgrami.Services.VeriTabanıİşlemleri;

namespace StokProgrami
{
    
    public partial class StokEkleme : Form
    {
        
        public StokEkleme()
        {
            InitializeComponent();
            this.Load += StokEkleme_Load; //Form yüklendiğinde KullaniciComboBoxDoldur metodunu çağırıyor
        }
        //Durum değişkeninin sınıf düzeyinde tanımladım
        private bool durum = true;
        private void AynıStokNoEngelleme() 
        {
            using (SqlConnection baglanti = new SqlConnection(AppConfig.BaglantiSatiri))
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT stok_kodu FROM Stok", baglanti);
                using (SqlDataReader read = komut.ExecuteReader())
                {
                    //Aynı Stok Kodunu engellemek için aynı mı veya null,boş kontrolü
                    while (read.Read())
                    {
                        if (string.IsNullOrEmpty(txtStokKodu.Text) || txtMevcutStokKodu.Text == read["stok_kodu"].ToString())
                            durum = false;
                        break;
                    }
                }
            }
        }
        //Combobox a mevcut kullanıcıları doldurma
        private void KullaniciComboBoxDoldur()
        {
            using (SqlConnection baglanti = new SqlConnection(AppConfig.BaglantiSatiri))
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT kullanıcı_ad_soyad FROM Kullanıcı", baglanti);
                using (SqlDataReader read = komut.ExecuteReader())
                {
                    comboKullanıcı.Items.Clear();
                    comboMevcutKullanıcı.Items.Clear();

                    while (read.Read())
                    {
                        string kullaniciAdi = read["kullanıcı_ad_soyad"].ToString();
                        if (kullaniciAdi != "")  // Eğer veri boş değilse
                        {
                            comboKullanıcı.Items.Add(kullaniciAdi);
                            comboMevcutKullanıcı.Items.Add(kullaniciAdi);
                        }
                    }
                }
            }
        }
        //Temizleme Metodu
        private void Groupbox1Temizle() {
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
        //Temizleme Metodu 2 GroupBoxlar farklı olduğundan dolayı tek metod haline getiremedim
        private void Groupbox2Temizle()
        {
            foreach (Control item in groupBox2.Controls)
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
        //Ürün ekleme
        private void btnYeniEkle_Click(object sender, EventArgs e)
        {
            AynıStokNoEngelleme();

            if (durum == true)
            {
                using (SqlConnection baglanti = new SqlConnection(AppConfig.BaglantiSatiri))
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("insert into Stok(stok_kodu,ürün_adı,ürün_miktarı,stok_tarih,stok_alis_fiyati,stok_satis_fiyati,ad_soyad) values(@stok_kodu,@ürün_adı,@ürün_miktarı,GETDATE(),@stok_alis_fiyati,@stok_satis_fiyati,@ad_soyad)", baglanti);
                    komut.Parameters.AddWithValue("@stok_kodu", txtStokKodu.Text);
                    komut.Parameters.AddWithValue("@ürün_adı", txtStokAdı.Text);
                    komut.Parameters.AddWithValue("@ürün_miktarı", Convert.ToInt16(txtStokMiktarı.Text));
                    komut.Parameters.AddWithValue("@stok_alis_fiyati", Convert.ToDouble(txtAlışFiyatı.Text));
                    komut.Parameters.AddWithValue("@stok_satis_fiyati", Convert.ToDouble(txtSatışFiyatı.Text));
                    komut.Parameters.AddWithValue("@ad_soyad", comboKullanıcı.SelectedItem);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Stok başarıyla eklendi.");
                }
            }
            else
            {
                MessageBox.Show("Uyarı! Girdiğiniz stok kodu mevcut veya geçersiz");
            }
            Groupbox1Temizle();
        }
        private void StokEkleme_Load(object sender, EventArgs e)
        {
            KullaniciComboBoxDoldur();  // Kullanıcıları ComboBox'a yükle
        }
       //stok kodu değişince verilerin otomatik doldurulması ve ayrıca en alt kısımdaki label miktarın doldurulması
        private void txtMevcutStokKodu_TextChanged(object sender, EventArgs e)
        {
            if (txtMevcutStokKodu.Text == "")
            {
                lblMiktar.Text = "";
                Groupbox2Temizle();
            }
            using (SqlConnection baglanti = new SqlConnection(AppConfig.BaglantiSatiri))
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from Stok where stok_kodu like '" + txtMevcutStokKodu.Text + "' ", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    txtMevcutStokAdı.Text = read["ürün_adı"].ToString();
                    lblMiktar.Text = read["ürün_miktarı"].ToString();
                    txtMevcutAlışFiyatı.Text = read["stok_alis_fiyati"].ToString();
                    txtMevcutSatışFiyatı.Text = read["stok_satis_fiyati"].ToString();
                    comboMevcutKullanıcı.Text = read["ad_soyad"].ToString();

                }
            }
        }
        //Ürün miktarı değiştirme
        private void btnVarOlanÜrünEkle_Click(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection(AppConfig.BaglantiSatiri))
            {
                baglanti.Open();
                // Textboxdan girilen Mevcut stok miktarını inte çevirip değişkende saklama
                int mevcutStokMiktarı = Convert.ToInt16(txtMevcutStokMiktarı.Text);

                // SQL komutunu oluşturuyoruz
                SqlCommand komut = new SqlCommand("UPDATE Stok SET ürün_miktarı = ürün_miktarı + @mevcutStokMiktarı WHERE stok_kodu = @stokKodu", baglanti);
                // Parametreleri ekliyoruz
                komut.Parameters.AddWithValue("@mevcutStokMiktarı", mevcutStokMiktarı);
                komut.Parameters.AddWithValue("@stokKodu", txtMevcutStokKodu.Text);
                komut.ExecuteNonQuery();
                
                Groupbox2Temizle();
                MessageBox.Show("Var olan ürüne yeni ekleme yapıldı.");
                }
            }
        }
    }

