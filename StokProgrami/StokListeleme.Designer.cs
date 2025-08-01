namespace StokProgrami
{
    partial class StokListeleme
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
            dataGridView1 = new DataGridView();
            comboMevcutKullanıcı = new ComboBox();
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
            label7 = new Label();
            txtStokKodaGöreAra = new TextBox();
            btnGüncelle = new Button();
            btnSil = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LightGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(327, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(461, 351);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // comboMevcutKullanıcı
            // 
            comboMevcutKullanıcı.FormattingEnabled = true;
            comboMevcutKullanıcı.Location = new Point(131, 250);
            comboMevcutKullanıcı.Name = "comboMevcutKullanıcı";
            comboMevcutKullanıcı.Size = new Size(100, 23);
            comboMevcutKullanıcı.TabIndex = 32;
            // 
            // txtMevcutSatışFiyatı
            // 
            txtMevcutSatışFiyatı.Location = new Point(131, 210);
            txtMevcutSatışFiyatı.Name = "txtMevcutSatışFiyatı";
            txtMevcutSatışFiyatı.Size = new Size(100, 23);
            txtMevcutSatışFiyatı.TabIndex = 40;
            // 
            // txtMevcutAlışFiyatı
            // 
            txtMevcutAlışFiyatı.Location = new Point(131, 170);
            txtMevcutAlışFiyatı.Name = "txtMevcutAlışFiyatı";
            txtMevcutAlışFiyatı.Size = new Size(100, 23);
            txtMevcutAlışFiyatı.TabIndex = 39;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 213);
            label8.Name = "label8";
            label8.Size = new Size(88, 15);
            label8.TabIndex = 38;
            label8.Text = "Stok Satış Fiyatı";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(31, 173);
            label9.Name = "label9";
            label9.Size = new Size(83, 15);
            label9.TabIndex = 37;
            label9.Text = "Stok Alış Fiyatı";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(31, 253);
            label10.Name = "label10";
            label10.Size = new Size(94, 15);
            label10.TabIndex = 36;
            label10.Text = "Stok Kayıt Yapan";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(31, 136);
            label12.Name = "label12";
            label12.Size = new Size(70, 15);
            label12.TabIndex = 35;
            label12.Text = "Stok Miktarı";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(31, 96);
            label13.Name = "label13";
            label13.Size = new Size(51, 15);
            label13.TabIndex = 34;
            label13.Text = "Stok Adı";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(31, 56);
            label14.Name = "label14";
            label14.Size = new Size(61, 15);
            label14.TabIndex = 33;
            label14.Text = "Stok Kodu";
            // 
            // txtMevcutStokKodu
            // 
            txtMevcutStokKodu.Location = new Point(131, 53);
            txtMevcutStokKodu.Name = "txtMevcutStokKodu";
            txtMevcutStokKodu.Size = new Size(100, 23);
            txtMevcutStokKodu.TabIndex = 29;
            txtMevcutStokKodu.TextChanged += txtMevcutStokKodu_TextChanged;
            // 
            // txtMevcutStokAdı
            // 
            txtMevcutStokAdı.Location = new Point(131, 93);
            txtMevcutStokAdı.Name = "txtMevcutStokAdı";
            txtMevcutStokAdı.Size = new Size(100, 23);
            txtMevcutStokAdı.TabIndex = 30;
            // 
            // txtMevcutStokMiktarı
            // 
            txtMevcutStokMiktarı.Location = new Point(131, 133);
            txtMevcutStokMiktarı.Name = "txtMevcutStokMiktarı";
            txtMevcutStokMiktarı.Size = new Size(100, 23);
            txtMevcutStokMiktarı.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(327, 40);
            label7.Name = "label7";
            label7.Size = new Size(252, 30);
            label7.TabIndex = 44;
            label7.Text = "Stok Ara (Stok Kodu İle)";
            // 
            // txtStokKodaGöreAra
            // 
            txtStokKodaGöreAra.Location = new Point(585, 47);
            txtStokKodaGöreAra.Name = "txtStokKodaGöreAra";
            txtStokKodaGöreAra.Size = new Size(109, 23);
            txtStokKodaGöreAra.TabIndex = 43;
            txtStokKodaGöreAra.TextChanged += txtStokKodaGöreAra_TextChanged;
            // 
            // btnGüncelle
            // 
            btnGüncelle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnGüncelle.Location = new Point(139, 309);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(92, 47);
            btnGüncelle.TabIndex = 46;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.UseVisualStyleBackColor = true;
            btnGüncelle.Click += btnGüncelle_Click_1;
            // 
            // btnSil
            // 
            btnSil.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnSil.Location = new Point(31, 309);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(92, 47);
            btnSil.TabIndex = 48;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(txtMevcutStokMiktarı);
            groupBox1.Controls.Add(btnGüncelle);
            groupBox1.Controls.Add(txtMevcutStokAdı);
            groupBox1.Controls.Add(txtMevcutStokKodu);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(comboMevcutKullanıcı);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txtMevcutSatışFiyatı);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtMevcutAlışFiyatı);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Location = new Point(24, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(271, 393);
            groupBox1.TabIndex = 49;
            groupBox1.TabStop = false;
            groupBox1.Text = "Stok Düzenleme";
            // 
            // StokListeleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(label7);
            Controls.Add(txtStokKodaGöreAra);
            Controls.Add(dataGridView1);
            Name = "StokListeleme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stok Listeleme";
            Load += StokListeleme_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
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
        private Label label7;
        private TextBox txtStokKodaGöreAra;
        private Button btnGüncelle;
        private Button btnSil;
        private GroupBox groupBox1;
    }
    }