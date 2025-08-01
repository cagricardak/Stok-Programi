using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static StokProgrami.appconfig;
namespace StokProgrami
{
    public partial class StokKullanıcıEkle : Form
    {
        public StokKullanıcıEkle()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            //Sql Bağlantısı
            using (SqlConnection baglanti = new SqlConnection(AppConfig.BaglantiSatiri))
            {
                baglanti.Open();

                // Kullanıcı bilgilerini veritabanına eklemek için SQL komutu ve insert into ile veritabanında yeni kullanıcı kaydı
                SqlCommand komut = new SqlCommand("insert into kullanıcı(kullanıcı_ad_soyad,kullanıcı_telefon,kullanıcı_eposta) values(@kullanıcı_ad_soyad,@kullanıcı_telefon,@kullanıcı_eposta)", baglanti);

                // Kullanıcıdan alınan parametrelerin Sql'e aktarılma işlemi
                komut.Parameters.AddWithValue("@kullanıcı_ad_soyad", txt_ad_soyad.Text);
                komut.Parameters.AddWithValue("@kullanıcı_telefon", txt_telefon.Text);
                komut.Parameters.AddWithValue("@kullanıcı_eposta", txt_eposta.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kullanıcı başarıyla eklendi");

                //TextBox temizleme
                TemizleTextBox();
            }
        }
            private void btnkapat_Click(object sender, EventArgs e)
            {
                //Kapat Butonu
                this.Close();
            }
            private void btnfrmtemizle_Click(object sender, EventArgs e)
            {
                TemizleTextBox();
                //Kullanıcı ekleme formundaki textboxları temizleme
            }
            private void TemizleTextBox()
            {
                //Kullanıcı ekleme formundaki textboxları temizleme
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = ""; 
                    }
                }
            }
        } 
}
