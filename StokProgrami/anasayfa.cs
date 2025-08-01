using System.Data;
using static StokProgrami.Services;
using static StokProgrami.Services.VeriTaban���lemleri;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StokProgrami
{
    public partial class anasayfa : Form
    {
        private readonly VeriTaban���lemleri _veritabaniIslemleri;
        public anasayfa()
        {
            InitializeComponent();
            //Yap�c� metodun i�inde manuel olarak nesne olu�tur - Bunu yapt���m i�in s�rekli services.cs nesnesi olu�turmama gerek kalm�yor
            _veritabaniIslemleri = new VeriTaban���lemleri(); 
            VerileriYukle();
        }

        private void VerileriYukle()
        {
            // Kullan�c� verilerini al
            DataSet kullaniciVerileri = _veritabaniIslemleri.Kullan�c�VerileriniGetir();
            dataGridView1.DataSource = kullaniciVerileri.Tables["kullan�c�"];

            // Stok verilerini al
            DataSet stokVerileri = _veritabaniIslemleri.StokVerileriniGetir();
            dataGridView2.DataSource = stokVerileri.Tables["Stok"];
        }
        private void button7_Click(object sender, EventArgs e)
        {
            //Kullan�c� Ekleme formunun a��lmas�
            StokKullan�c�Ekle ekle = new StokKullan�c�Ekle();
            ekle.ShowDialog();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            //Stok Ekleme formununun a��lmas�
            StokEkleme stokEklemeForm = new StokEkleme();
            stokEklemeForm.Show();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            //Kullan�c� Listeleme formunun a��lmas�
            StokKullan�c�Listeleme listele = new StokKullan�c�Listeleme();
            listele.ShowDialog();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            //Stok Listeleme formunun a��lmas�
            StokListeleme listele = new StokListeleme();
            listele.ShowDialog();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        { 
            // Verileri g�ncelle
            DataSet veriSet = _veritabaniIslemleri.VerileriGuncelle();

            // DataGridView'lere veri y�kle
            dataGridView1.DataSource = veriSet.Tables["kullan�c�"];
            dataGridView2.DataSource = veriSet.Tables["Stok"];
        }
    }
}