namespace StokProgrami
{
    partial class StokKullanıcıEkle
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
            label1 = new Label();
            txt_ad_soyad = new TextBox();
            label2 = new Label();
            txt_telefon = new TextBox();
            label3 = new Label();
            txt_eposta = new TextBox();
            button1 = new Button();
            btnkapat = new Button();
            btnfrmtemizle = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 37);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Ad Soyad";
            // 
            // txt_ad_soyad
            // 
            txt_ad_soyad.Location = new Point(179, 34);
            txt_ad_soyad.Name = "txt_ad_soyad";
            txt_ad_soyad.Size = new Size(100, 23);
            txt_ad_soyad.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 94);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 2;
            label2.Text = "Kullanıcı Telefon";
            // 
            // txt_telefon
            // 
            txt_telefon.Location = new Point(179, 91);
            txt_telefon.Name = "txt_telefon";
            txt_telefon.Size = new Size(100, 23);
            txt_telefon.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 151);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 4;
            label3.Text = "Kullanıcı E-posta";
            // 
            // txt_eposta
            // 
            txt_eposta.Location = new Point(179, 148);
            txt_eposta.Name = "txt_eposta";
            txt_eposta.Size = new Size(100, 23);
            txt_eposta.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.Location = new Point(189, 266);
            button1.Name = "button1";
            button1.Size = new Size(90, 58);
            button1.TabIndex = 7;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnkapat
            // 
            btnkapat.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnkapat.Location = new Point(59, 266);
            btnkapat.Name = "btnkapat";
            btnkapat.Size = new Size(90, 58);
            btnkapat.TabIndex = 8;
            btnkapat.Text = "Kapat";
            btnkapat.UseVisualStyleBackColor = true;
            btnkapat.Click += btnkapat_Click;
            // 
            // btnfrmtemizle
            // 
            btnfrmtemizle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnfrmtemizle.Location = new Point(125, 191);
            btnfrmtemizle.Name = "btnfrmtemizle";
            btnfrmtemizle.Size = new Size(90, 58);
            btnfrmtemizle.TabIndex = 9;
            btnfrmtemizle.Text = "Formu Temizle";
            btnfrmtemizle.UseVisualStyleBackColor = true;
            btnfrmtemizle.Click += btnfrmtemizle_Click;
            // 
            // StokKullanıcıEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(355, 336);
            Controls.Add(btnfrmtemizle);
            Controls.Add(btnkapat);
            Controls.Add(button1);
            Controls.Add(txt_eposta);
            Controls.Add(label3);
            Controls.Add(txt_telefon);
            Controls.Add(label2);
            Controls.Add(txt_ad_soyad);
            Controls.Add(label1);
            Name = "StokKullanıcıEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Ekle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_ad_soyad;
        private Label label2;
        private TextBox txt_telefon;
        private Label label3;
        private TextBox txt_eposta;
        private Button button1;
        private Button btnkapat;
        private Button btnfrmtemizle;
    }
}