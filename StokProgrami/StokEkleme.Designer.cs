namespace StokProgrami
{
    partial class StokEkleme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label4 = new Label();
            comboKullanıcı = new ComboBox();
            btnYeniEkle = new Button();
            txtSatışFiyatı = new TextBox();
            txtAlışFiyatı = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtStokKodu = new TextBox();
            txtStokAdı = new TextBox();
            txtStokMiktarı = new TextBox();
            groupBox2 = new GroupBox();
            btnVarOlanÜrünEkle = new Button();
            lblMiktar = new Label();
            comboMevcutKullanıcı = new ComboBox();
            label16 = new Label();
            txtMevcutSatışFiyatı = new TextBox();
            txtMevcutAlışFiyatı = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            txtMevcutStokKodu = new TextBox();
            txtMevcutStokAdı = new TextBox();
            txtMevcutStokMiktarı = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(comboKullanıcı);
            groupBox1.Controls.Add(btnYeniEkle);
            groupBox1.Controls.Add(txtSatışFiyatı);
            groupBox1.Controls.Add(txtAlışFiyatı);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtStokKodu);
            groupBox1.Controls.Add(txtStokAdı);
            groupBox1.Controls.Add(txtStokMiktarı);
            groupBox1.Location = new Point(68, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(280, 374);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yeni Ürün";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.DarkRed;
            label4.Location = new Point(22, 276);
            label4.Name = "label4";
            label4.Size = new Size(249, 15);
            label4.TabIndex = 20;
            label4.Text = "Eklemek istediğiniz ürünün özelliklerini giriniz.";
            // 
            // comboKullanıcı
            // 
            comboKullanıcı.FormattingEnabled = true;
            comboKullanıcı.Location = new Point(129, 233);
            comboKullanıcı.Name = "comboKullanıcı";
            comboKullanıcı.Size = new Size(100, 23);
            comboKullanıcı.TabIndex = 4;
            // 
            // btnYeniEkle
            // 
            btnYeniEkle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnYeniEkle.Location = new Point(91, 310);
            btnYeniEkle.Name = "btnYeniEkle";
            btnYeniEkle.Size = new Size(93, 46);
            btnYeniEkle.TabIndex = 18;
            btnYeniEkle.Text = "Ekle";
            btnYeniEkle.UseVisualStyleBackColor = true;
            btnYeniEkle.Click += btnYeniEkle_Click;
            // 
            // txtSatışFiyatı
            // 
            txtSatışFiyatı.Location = new Point(129, 193);
            txtSatışFiyatı.Name = "txtSatışFiyatı";
            txtSatışFiyatı.Size = new Size(100, 23);
            txtSatışFiyatı.TabIndex = 14;
            // 
            // txtAlışFiyatı
            // 
            txtAlışFiyatı.Location = new Point(129, 153);
            txtAlışFiyatı.Name = "txtAlışFiyatı";
            txtAlışFiyatı.Size = new Size(100, 23);
            txtAlışFiyatı.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 196);
            label7.Name = "label7";
            label7.Size = new Size(88, 15);
            label7.TabIndex = 12;
            label7.Text = "Stok Satış Fiyatı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 156);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 11;
            label6.Text = "Stok Alış Fiyatı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 236);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 10;
            label5.Text = "Stok Kayıt Yapan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 119);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 8;
            label3.Text = "Stok Miktarı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 79);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 7;
            label2.Text = "Stok Adı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 39);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 6;
            label1.Text = "Stok Kodu";
            // 
            // txtStokKodu
            // 
            txtStokKodu.Location = new Point(129, 36);
            txtStokKodu.Name = "txtStokKodu";
            txtStokKodu.Size = new Size(100, 23);
            txtStokKodu.TabIndex = 1;
            // 
            // txtStokAdı
            // 
            txtStokAdı.Location = new Point(129, 76);
            txtStokAdı.Name = "txtStokAdı";
            txtStokAdı.Size = new Size(100, 23);
            txtStokAdı.TabIndex = 2;
            // 
            // txtStokMiktarı
            // 
            txtStokMiktarı.Location = new Point(129, 116);
            txtStokMiktarı.Name = "txtStokMiktarı";
            txtStokMiktarı.Size = new Size(100, 23);
            txtStokMiktarı.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LightGray;
            groupBox2.Controls.Add(btnVarOlanÜrünEkle);
            groupBox2.Controls.Add(lblMiktar);
            groupBox2.Controls.Add(comboMevcutKullanıcı);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(txtMevcutSatışFiyatı);
            groupBox2.Controls.Add(txtMevcutAlışFiyatı);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(txtMevcutStokKodu);
            groupBox2.Controls.Add(txtMevcutStokAdı);
            groupBox2.Controls.Add(txtMevcutStokMiktarı);
            groupBox2.Location = new Point(451, 34);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(280, 374);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Var Olan Ürün Stok Miktarı Güncelleme";
            // 
            // btnVarOlanÜrünEkle
            // 
            btnVarOlanÜrünEkle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnVarOlanÜrünEkle.Location = new Point(95, 310);
            btnVarOlanÜrünEkle.Name = "btnVarOlanÜrünEkle";
            btnVarOlanÜrünEkle.Size = new Size(93, 46);
            btnVarOlanÜrünEkle.TabIndex = 17;
            btnVarOlanÜrünEkle.Text = "Güncelle";
            btnVarOlanÜrünEkle.UseVisualStyleBackColor = true;
            btnVarOlanÜrünEkle.Click += btnVarOlanÜrünEkle_Click;
            // 
            // lblMiktar
            // 
            lblMiktar.AutoSize = true;
            lblMiktar.Location = new Point(143, 276);
            lblMiktar.Name = "lblMiktar";
            lblMiktar.Size = new Size(0, 15);
            lblMiktar.TabIndex = 30;
            // 
            // comboMevcutKullanıcı
            // 
            comboMevcutKullanıcı.FormattingEnabled = true;
            comboMevcutKullanıcı.Location = new Point(143, 233);
            comboMevcutKullanıcı.Name = "comboMevcutKullanıcı";
            comboMevcutKullanıcı.Size = new Size(100, 23);
            comboMevcutKullanıcı.TabIndex = 18;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(32, 276);
            label16.Name = "label16";
            label16.Size = new Size(110, 15);
            label16.TabIndex = 20;
            label16.Text = "Mevcut Ürün Stoğu";
            // 
            // txtMevcutSatışFiyatı
            // 
            txtMevcutSatışFiyatı.Location = new Point(143, 193);
            txtMevcutSatışFiyatı.Name = "txtMevcutSatışFiyatı";
            txtMevcutSatışFiyatı.Size = new Size(100, 23);
            txtMevcutSatışFiyatı.TabIndex = 28;
            // 
            // txtMevcutAlışFiyatı
            // 
            txtMevcutAlışFiyatı.Location = new Point(143, 153);
            txtMevcutAlışFiyatı.Name = "txtMevcutAlışFiyatı";
            txtMevcutAlışFiyatı.Size = new Size(100, 23);
            txtMevcutAlışFiyatı.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 196);
            label8.Name = "label8";
            label8.Size = new Size(88, 15);
            label8.TabIndex = 26;
            label8.Text = "Stok Satış Fiyatı";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(32, 156);
            label9.Name = "label9";
            label9.Size = new Size(83, 15);
            label9.TabIndex = 25;
            label9.Text = "Stok Alış Fiyatı";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(32, 236);
            label10.Name = "label10";
            label10.Size = new Size(94, 15);
            label10.TabIndex = 24;
            label10.Text = "Stok Kayıt Yapan";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(32, 119);
            label12.Name = "label12";
            label12.Size = new Size(70, 15);
            label12.TabIndex = 22;
            label12.Text = "Stok Miktarı";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(32, 79);
            label13.Name = "label13";
            label13.Size = new Size(51, 15);
            label13.TabIndex = 21;
            label13.Text = "Stok Adı";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(32, 39);
            label14.Name = "label14";
            label14.Size = new Size(61, 15);
            label14.TabIndex = 20;
            label14.Text = "Stok Kodu";
            // 
            // txtMevcutStokKodu
            // 
            txtMevcutStokKodu.Location = new Point(143, 36);
            txtMevcutStokKodu.Name = "txtMevcutStokKodu";
            txtMevcutStokKodu.Size = new Size(100, 23);
            txtMevcutStokKodu.TabIndex = 15;
            txtMevcutStokKodu.TextChanged += txtMevcutStokKodu_TextChanged;
            // 
            // txtMevcutStokAdı
            // 
            txtMevcutStokAdı.Location = new Point(143, 76);
            txtMevcutStokAdı.Name = "txtMevcutStokAdı";
            txtMevcutStokAdı.Size = new Size(100, 23);
            txtMevcutStokAdı.TabIndex = 16;
            // 
            // txtMevcutStokMiktarı
            // 
            txtMevcutStokMiktarı.Location = new Point(143, 116);
            txtMevcutStokMiktarı.Name = "txtMevcutStokMiktarı";
            txtMevcutStokMiktarı.Size = new Size(100, 23);
            txtMevcutStokMiktarı.TabIndex = 17;
            // 
            // StokEkleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "StokEkleme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stok Ekleme";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private TextBox txtStokKodu;
        private TextBox txtStokAdı;
        private TextBox txtStokMiktarı;
        private ComboBox comboKullanıcı;
        private Label label3;
        private Label label2;
        private Label label5;
        private TextBox txtSatışFiyatı;
        private TextBox txtAlışFiyatı;
        private Label label7;
        private Label label6;
        private ComboBox comboMevcutKullanıcı;
        private TextBox txtMevcutSatışFiyatı;
        private TextBox txtMevcutAlışFiyatı;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox txtMevcutStokKodu;
        private TextBox txtMevcutStokAdı;
        private TextBox txtMevcutStokMiktarı;
        private Button btnVarOlanÜrünEkle;
        private Button btnYeniEkle;
        private Label lblMiktar;
        private Label label16;
        private Label label4;
    }
}