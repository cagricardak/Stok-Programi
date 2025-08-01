using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static StokProgrami.appconfig;

namespace StokProgrami
{
    public partial class StokKullanıcıListeleme : Form
    {
        //DataSet Oluşturdum
        private DataSet data = new DataSet();
        public StokKullanıcıListeleme()
        {
            InitializeComponent();
        }
        private void StokKullanıcıListeleme_Load(object sender, EventArgs e)
        {
            KullaniciListelemeMetodu();
        }
        private void KullaniciListelemeMetodu()
        {
            // Bağlantı
            using (SqlConnection baglanti = new SqlConnection(AppConfig.BaglantiSatiri))
            {
                baglanti.Open();

                // SqlDataAdapter nesnesi yazdığım Sql sorgusunun verilerini alıyor
                SqlDataAdapter adtr = new SqlDataAdapter("select *from kullanıcı", baglanti);

                // Verileri Data adlı DataSetin kullanıcı tablosuna dolduruyor.    
                adtr.Fill(data, "kullanıcı");

                // Veriler datagridviewe yükleniyor.
                dataGridView1.DataSource = data.Tables["kullanıcı"];
            }
        }
        //Getter ile DataSetteki verilere erişiliyor
        public DataSet Kullanicidata
        {
            get { return data; }
        }
        public void ListeleKullanici() //Private metoda erişmek için private metodu public bir metodun içinde çağırılıyor
        {
            KullaniciListelemeMetodu();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridView içinde olan verilerin çift tıklandığında düzenlemek veya silmek için textboxlara doldurulması
            txt_ad_soyad.Text = dataGridView1.CurrentRow.Cells["kullanıcı_ad_soyad"].Value.ToString();
            txt_telefon.Text = dataGridView1.CurrentRow.Cells["kullanıcı_telefon"].Value.ToString();
            txt_eposta.Text = dataGridView1.CurrentRow.Cells["kullanıcı_eposta"].Value.ToString();

        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //TextBox'a girilen kullanıcı id'ye göre diğer verileri güncelleme işlemi yapıyor
            if (int.TryParse(txt_id.Text.Trim(), out int kullaniciID))
            {
                using (SqlConnection baglanti = new SqlConnection(AppConfig.BaglantiSatiri))
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("UPDATE Kullanıcı SET kullanıcı_ad_soyad = @kullanıcı_ad_soyad, kullanıcı_telefon = @kullanıcı_telefon, kullanıcı_eposta = @kullanıcı_eposta WHERE kullanıcı_id = @kullanıcı_id", baglanti);
                    komut.Parameters.AddWithValue("@kullanıcı_ad_soyad", txt_ad_soyad.Text);
                    komut.Parameters.AddWithValue("@kullanıcı_telefon", txt_telefon.Text);
                    komut.Parameters.AddWithValue("@kullanıcı_eposta", txt_eposta.Text);
                    komut.Parameters.AddWithValue("@kullanıcı_id", kullaniciID);
                    komut.ExecuteNonQuery();

                    int guncellenenSatirSayisi = komut.ExecuteNonQuery();

                    // Güncelleme işleminin kontrolü
                    if (guncellenenSatirSayisi > 0)
                    {
                        MessageBox.Show("Kullanıcı başarıyla güncellendi.");
                    }
                    else
                    {
                        MessageBox.Show("Belirtilen kullanıcı ID'si bulunamadı.");
                    }

                    // DataGridView'i güncelle
                    data.Tables["Kullanıcı"].Clear();
                    KullaniciListelemeMetodu();
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir kullanıcı ID giriniz.");
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
            // TextBox'a girilen kullanıcı id'ye göre silme işlemi yapıyor
            if (int.TryParse(txt_id.Text.Trim(), out int kullanıcı_id))
            {
                using (SqlConnection baglanti = new SqlConnection(AppConfig.BaglantiSatiri))
                {
                    baglanti.Open();

                    // Sql tablosundaki veriyi kullanıcı_id ye göre silme işlemi
                    SqlCommand komut = new SqlCommand("DELETE FROM Kullanıcı WHERE kullanıcı_id = @kullanıcı_id", baglanti);
                    komut.Parameters.AddWithValue("@kullanıcı_id", kullanıcı_id);

                    int silinenSatirSayisi = komut.ExecuteNonQuery();

                    // Silme işleminin kontrolü
                    if (silinenSatirSayisi > 0)
                    {
                        MessageBox.Show("Kullanıcı kaydı başarıyla silindi.");
                    }
                    else
                    {
                        MessageBox.Show("Belirtilen kullanıcı bulunamadı.");
                    }

                    data.Tables["kullanıcı"].Clear();
                    KullaniciListelemeMetodu();

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
            else
            {
                MessageBox.Show("Lütfen geçerli bir kullanıcı id giriniz.");
            }
        }
        private void txtAdSoyadaGöreAra_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection(AppConfig.BaglantiSatiri))
            {
                baglanti.Open();
                // Arama sonuçlarını tutacağımız bir tablo açıyor
                DataTable aramatablosu = new DataTable();

                // Sql sorgusunu string sorgunun değişkeninin içine atayıp çalıştırıyoruz
                string sorgu = "SELECT * FROM Kullanıcı WHERE kullanıcı_ad_soyad LIKE @adSoyad";
                SqlDataAdapter adtr = new SqlDataAdapter(sorgu, baglanti);

                // Parametre ekleme
                adtr.SelectCommand.Parameters.AddWithValue("@adSoyad", "%" + txtAdSoyadaGöreAra.Text + "%");

                //Sql sorgusundan dönen verileri aramatablosuna dolduruyoruz
                adtr.Fill(aramatablosu);

                //Verilerin ekranda görüntülenmesi için datagridviewin kaynağını arama tablosu yapıyoruz
                dataGridView1.DataSource = aramatablosu;
            }
        }
        //Girilen İd ye göre diğer textboxların doldurulması
        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection(AppConfig.BaglantiSatiri))
            {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("select * from Kullanıcı where kullanıcı_id like '" + txt_id.Text + "' ", baglanti);
                    SqlDataReader read = komut.ExecuteReader();
                    while (read.Read())
                    {
                    txt_ad_soyad.Text = read["kullanıcı_ad_soyad"].ToString();
                    txt_telefon.Text = read["kullanıcı_telefon"].ToString();
                    txt_eposta.Text = read["kullanıcı_eposta"].ToString();
                    }
                }
            }
        }
    }
