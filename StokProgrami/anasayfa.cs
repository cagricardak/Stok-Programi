using System.Data;
using static StokProgrami.Services;
using static StokProgrami.Services.VeriTabanýÝþlemleri;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StokProgrami
{
    public partial class anasayfa : Form
    {
        private readonly VeriTabanýÝþlemleri _veritabaniIslemleri;
        public anasayfa()
        {
            InitializeComponent();
            //Yapýcý metodun içinde manuel olarak nesne oluþtur - Bunu yaptýðým için sürekli services.cs nesnesi oluþturmama gerek kalmýyor
            _veritabaniIslemleri = new VeriTabanýÝþlemleri(); 
            VerileriYukle();
        }

        private void VerileriYukle()
        {
            // Kullanýcý verilerini al
            DataSet kullaniciVerileri = _veritabaniIslemleri.KullanýcýVerileriniGetir();
            dataGridView1.DataSource = kullaniciVerileri.Tables["kullanýcý"];

            // Stok verilerini al
            DataSet stokVerileri = _veritabaniIslemleri.StokVerileriniGetir();
            dataGridView2.DataSource = stokVerileri.Tables["Stok"];
        }
        private void button7_Click(object sender, EventArgs e)
        {
            //Kullanýcý Ekleme formunun açýlmasý
            StokKullanýcýEkle ekle = new StokKullanýcýEkle();
            ekle.ShowDialog();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            //Stok Ekleme formununun açýlmasý
            StokEkleme stokEklemeForm = new StokEkleme();
            stokEklemeForm.Show();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            //Kullanýcý Listeleme formunun açýlmasý
            StokKullanýcýListeleme listele = new StokKullanýcýListeleme();
            listele.ShowDialog();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            //Stok Listeleme formunun açýlmasý
            StokListeleme listele = new StokListeleme();
            listele.ShowDialog();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        { 
            // Verileri güncelle
            DataSet veriSet = _veritabaniIslemleri.VerileriGuncelle();

            // DataGridView'lere veri yükle
            dataGridView1.DataSource = veriSet.Tables["kullanýcý"];
            dataGridView2.DataSource = veriSet.Tables["Stok"];
        }
    }
}