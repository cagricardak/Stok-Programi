namespace StokProgrami
{
    partial class StokKullanıcıListeleme
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
            btnGuncelle = new Button();
            btnSil = new Button();
            txtAdSoyadaGöreAra = new TextBox();
            txt_id = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label1 = new Label();
            txt_ad_soyad = new TextBox();
            txt_telefon = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txt_eposta = new TextBox();
            label7 = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LightGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(328, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(518, 310);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnGuncelle.Location = new Point(139, 286);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(93, 46);
            btnGuncelle.TabIndex = 16;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnSil.Location = new Point(22, 286);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(93, 46);
            btnSil.TabIndex = 17;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // txtAdSoyadaGöreAra
            // 
            txtAdSoyadaGöreAra.Location = new Point(620, 23);
            txtAdSoyadaGöreAra.Name = "txtAdSoyadaGöreAra";
            txtAdSoyadaGöreAra.Size = new Size(109, 23);
            txtAdSoyadaGöreAra.TabIndex = 19;
            txtAdSoyadaGöreAra.TextChanged += txtAdSoyadaGöreAra_TextChanged;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(132, 185);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(100, 23);
            txt_id.TabIndex = 22;
            txt_id.TextChanged += txt_id_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 188);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 23;
            label5.Text = "Kullanıcı ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightGray;
            label6.ForeColor = Color.DarkRed;
            label6.Location = new Point(22, 232);
            label6.Name = "label6";
            label6.Size = new Size(199, 30);
            label6.TabIndex = 25;
            label6.Text = "Güncellemek veya silmek istediğiniz \r\nkullanıcıya ait ID'yi giriniz.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 38);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 10;
            label1.Text = "Kullanıcı Ad Soyad";
            // 
            // txt_ad_soyad
            // 
            txt_ad_soyad.Location = new Point(132, 35);
            txt_ad_soyad.Name = "txt_ad_soyad";
            txt_ad_soyad.Size = new Size(100, 23);
            txt_ad_soyad.TabIndex = 11;
            // 
            // txt_telefon
            // 
            txt_telefon.Location = new Point(132, 84);
            txt_telefon.Name = "txt_telefon";
            txt_telefon.Size = new Size(100, 23);
            txt_telefon.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 87);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 12;
            label2.Text = "Kullanıcı Telefon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 136);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 14;
            label3.Text = "Kullanıcı E-posta";
            // 
            // txt_eposta
            // 
            txt_eposta.Location = new Point(132, 133);
            txt_eposta.Name = "txt_eposta";
            txt_eposta.Size = new Size(100, 23);
            txt_eposta.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(328, 16);
            label7.Name = "label7";
            label7.Size = new Size(286, 30);
            label7.TabIndex = 26;
            label7.Text = "Kullanıcı Ara (Ad-Soyad İle)";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txt_ad_soyad);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txt_telefon);
            groupBox1.Controls.Add(txt_id);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_eposta);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Location = new Point(37, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(257, 341);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kullanıcı Düzenleme";
            // 
            // StokKullanıcıListeleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(868, 376);
            Controls.Add(groupBox1);
            Controls.Add(label7);
            Controls.Add(txtAdSoyadaGöreAra);
            Controls.Add(dataGridView1);
            Name = "StokKullanıcıListeleme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Listeleme";
            Load += StokKullanıcıListeleme_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnGuncelle;
        private Button btnSil;
        private TextBox txtAdSoyadaGöreAra;
        private TextBox txt_id;
        private Label label5;
        private Label label6;
        private Label label1;
        private TextBox txt_ad_soyad;
        private TextBox txt_telefon;
        private Label label2;
        private Label label3;
        private TextBox txt_eposta;
        private Label label7;
        private GroupBox groupBox1;
    }
}