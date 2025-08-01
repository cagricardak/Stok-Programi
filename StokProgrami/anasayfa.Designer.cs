namespace StokProgrami
{
    partial class anasayfa
    {

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label6 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            btnYenile = new Button();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LightGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(520, 177);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(425, 263);
            dataGridView1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(712, 123);
            label6.Name = "label6";
            label6.Size = new Size(233, 37);
            label6.TabIndex = 3;
            label6.Text = "Kullanıcı Tablosu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(27, 123);
            label7.Name = "label7";
            label7.Size = new Size(180, 37);
            label7.TabIndex = 5;
            label7.Text = "Stok Tablosu";
            // 
            // panel1
            // 
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(974, 102);
            panel1.TabIndex = 13;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button8.Location = new Point(729, 12);
            button8.Name = "button8";
            button8.Size = new Size(112, 72);
            button8.TabIndex = 11;
            button8.Text = "Kullanıcı Düzenleme";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button7.Location = new Point(525, 12);
            button7.Name = "button7";
            button7.Size = new Size(112, 72);
            button7.TabIndex = 10;
            button7.Text = "Kullanıcı Ekle";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button6.Location = new Point(317, 12);
            button6.Name = "button6";
            button6.Size = new Size(112, 72);
            button6.TabIndex = 9;
            button6.Text = "Stok Silme ve Güncelleme";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button5.Location = new Point(102, 12);
            button5.Name = "button5";
            button5.Size = new Size(112, 72);
            button5.TabIndex = 8;
            button5.Text = "Stok Ekleme";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // btnYenile
            // 
            btnYenile.Location = new Point(442, 123);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(87, 42);
            btnYenile.TabIndex = 15;
            btnYenile.Text = "Tabloları Yenile";
            btnYenile.UseVisualStyleBackColor = true;
            btnYenile.Click += btnYenile_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.LightGray;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(27, 177);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(425, 263);
            dataGridView2.TabIndex = 14;
            // 
            // anasayfa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(974, 500);
            Controls.Add(btnYenile);
            Controls.Add(dataGridView2);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(label7);
            Name = "anasayfa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stok Programı";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private DataGridView dataGridView2;
        private Button btnYenile;
    }
}
