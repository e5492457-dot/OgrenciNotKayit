namespace OgrenciNotKayit
{
    partial class ÖğrenciNotKayıt
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ÖğrenciNotKayıt));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textAdSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxDers = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textSınavBir = new System.Windows.Forms.TextBox();
            this.textSınavİki = new System.Windows.Forms.TextBox();
            this.textSınavÜç = new System.Windows.Forms.TextBox();
            this.textOrt = new System.Windows.Forms.TextBox();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.buttonHesapla = new System.Windows.Forms.Button();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textDurum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonDers = new System.Windows.Forms.Button();
            this.comboBoxSınıf = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonMesaj = new System.Windows.Forms.Button();
            this.buttonFor = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.buttonFor2 = new System.Windows.Forms.Button();
            this.buttonTemiz = new System.Windows.Forms.Button();
            this.buttonWhile = new System.Windows.Forms.Button();
            this.buttonDizi1 = new System.Windows.Forms.Button();
            this.buttonDizi2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PapayaWhip;
            this.label1.Font = new System.Drawing.Font("MV Boli", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(272, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Not Kayıt Sistemi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad:";
            // 
            // textAdSoyad
            // 
            this.textAdSoyad.Location = new System.Drawing.Point(105, 14);
            this.textAdSoyad.Name = "textAdSoyad";
            this.textAdSoyad.Size = new System.Drawing.Size(126, 29);
            this.textAdSoyad.TabIndex = 2;
            this.textAdSoyad.TextChanged += new System.EventHandler(this.textAdSoyad_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ders:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBoxDers
            // 
            this.comboBoxDers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDers.FormattingEnabled = true;
            this.comboBoxDers.Location = new System.Drawing.Point(105, 148);
            this.comboBoxDers.Name = "comboBoxDers";
            this.comboBoxDers.Size = new System.Drawing.Size(121, 29);
            this.comboBoxDers.TabIndex = 4;
            this.comboBoxDers.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-1, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sınav 1:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-1, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sınav 2:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-1, 150);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Sınav 3:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ort:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textSınavBir
            // 
            this.textSınavBir.Location = new System.Drawing.Point(70, 43);
            this.textSınavBir.Name = "textSınavBir";
            this.textSınavBir.Size = new System.Drawing.Size(53, 29);
            this.textSınavBir.TabIndex = 9;
            this.textSınavBir.TextChanged += new System.EventHandler(this.textSınavBir_TextChanged);
            // 
            // textSınavİki
            // 
            this.textSınavİki.Location = new System.Drawing.Point(70, 94);
            this.textSınavİki.Name = "textSınavİki";
            this.textSınavİki.Size = new System.Drawing.Size(53, 29);
            this.textSınavİki.TabIndex = 10;
            this.textSınavİki.TextChanged += new System.EventHandler(this.textSınavİki_TextChanged);
            // 
            // textSınavÜç
            // 
            this.textSınavÜç.Location = new System.Drawing.Point(70, 147);
            this.textSınavÜç.Name = "textSınavÜç";
            this.textSınavÜç.Size = new System.Drawing.Size(49, 29);
            this.textSınavÜç.TabIndex = 11;
            this.textSınavÜç.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textOrt
            // 
            this.textOrt.Enabled = false;
            this.textOrt.Location = new System.Drawing.Point(69, 23);
            this.textOrt.Name = "textOrt";
            this.textOrt.Size = new System.Drawing.Size(49, 29);
            this.textOrt.TabIndex = 12;
            this.textOrt.TextChanged += new System.EventHandler(this.textOrt_TextChanged);
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Location = new System.Drawing.Point(33, 259);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(123, 42);
            this.buttonKaydet.TabIndex = 13;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // buttonHesapla
            // 
            this.buttonHesapla.Location = new System.Drawing.Point(338, 259);
            this.buttonHesapla.Name = "buttonHesapla";
            this.buttonHesapla.Size = new System.Drawing.Size(123, 42);
            this.buttonHesapla.TabIndex = 14;
            this.buttonHesapla.Text = "Hesapla";
            this.buttonHesapla.UseVisualStyleBackColor = true;
            this.buttonHesapla.Click += new System.EventHandler(this.buttonHesapla_Click);
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.Location = new System.Drawing.Point(517, 259);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(123, 42);
            this.buttonTemizle.TabIndex = 15;
            this.buttonTemizle.Text = "Temizle";
            this.buttonTemizle.UseVisualStyleBackColor = true;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(20, 355);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(784, 151);
            this.listBox1.TabIndex = 16;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 104);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "No:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(105, 96);
            this.maskedTextBox1.Mask = "0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 29);
            this.maskedTextBox1.TabIndex = 18;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // textDurum
            // 
            this.textDurum.Enabled = false;
            this.textDurum.Location = new System.Drawing.Point(65, 65);
            this.textDurum.Name = "textDurum";
            this.textDurum.Size = new System.Drawing.Size(110, 29);
            this.textDurum.TabIndex = 20;
            this.textDurum.TextChanged += new System.EventHandler(this.textDurum_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 68);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 21);
            this.label9.TabIndex = 19;
            this.label9.Text = "Durum:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(878, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 61);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 21);
            this.label10.TabIndex = 22;
            this.label10.Text = "Sınıf:";
            // 
            // buttonDers
            // 
            this.buttonDers.Location = new System.Drawing.Point(715, 259);
            this.buttonDers.Name = "buttonDers";
            this.buttonDers.Size = new System.Drawing.Size(123, 42);
            this.buttonDers.TabIndex = 24;
            this.buttonDers.Text = "Dersleri listele";
            this.buttonDers.UseVisualStyleBackColor = true;
            this.buttonDers.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxSınıf
            // 
            this.comboBoxSınıf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSınıf.FormattingEnabled = true;
            this.comboBoxSınıf.Items.AddRange(new object[] {
            "9.Sınıf",
            "10.Sınıf",
            "11.Sınıf",
            "12.Sınıf"});
            this.comboBoxSınıf.Location = new System.Drawing.Point(105, 53);
            this.comboBoxSınıf.Name = "comboBoxSınıf";
            this.comboBoxSınıf.Size = new System.Drawing.Size(121, 29);
            this.comboBoxSınıf.TabIndex = 25;
            this.comboBoxSınıf.SelectedIndexChanged += new System.EventHandler(this.comboBoxSınıf_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(517, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 44);
            this.button2.TabIndex = 26;
            this.button2.Text = "Sayaç";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(621, 213);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 21);
            this.label11.TabIndex = 27;
            this.label11.Text = "0";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // buttonMesaj
            // 
            this.buttonMesaj.Location = new System.Drawing.Point(185, 259);
            this.buttonMesaj.Name = "buttonMesaj";
            this.buttonMesaj.Size = new System.Drawing.Size(123, 42);
            this.buttonMesaj.TabIndex = 28;
            this.buttonMesaj.Text = "Mesaj Kutusu";
            this.buttonMesaj.UseVisualStyleBackColor = true;
            this.buttonMesaj.Click += new System.EventHandler(this.buttonMesaj_Click);
            // 
            // buttonFor
            // 
            this.buttonFor.Location = new System.Drawing.Point(33, 307);
            this.buttonFor.Name = "buttonFor";
            this.buttonFor.Size = new System.Drawing.Size(123, 42);
            this.buttonFor.TabIndex = 29;
            this.buttonFor.Text = "For Döngüsü";
            this.buttonFor.UseVisualStyleBackColor = true;
            this.buttonFor.Click += new System.EventHandler(this.buttonFor_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 21;
            this.listBox2.Location = new System.Drawing.Point(813, 355);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(171, 151);
            this.listBox2.TabIndex = 30;
            // 
            // buttonFor2
            // 
            this.buttonFor2.Location = new System.Drawing.Point(185, 307);
            this.buttonFor2.Name = "buttonFor2";
            this.buttonFor2.Size = new System.Drawing.Size(123, 42);
            this.buttonFor2.TabIndex = 31;
            this.buttonFor2.Text = "For Döngüsü 2";
            this.buttonFor2.UseVisualStyleBackColor = true;
            this.buttonFor2.Click += new System.EventHandler(this.buttonFor2_Click);
            // 
            // buttonTemiz
            // 
            this.buttonTemiz.Location = new System.Drawing.Point(338, 307);
            this.buttonTemiz.Name = "buttonTemiz";
            this.buttonTemiz.Size = new System.Drawing.Size(147, 42);
            this.buttonTemiz.TabIndex = 32;
            this.buttonTemiz.Text = "Listbox Temizleyici";
            this.buttonTemiz.UseVisualStyleBackColor = true;
            this.buttonTemiz.Click += new System.EventHandler(this.buttonTemiz_Click);
            // 
            // buttonWhile
            // 
            this.buttonWhile.Location = new System.Drawing.Point(517, 307);
            this.buttonWhile.Name = "buttonWhile";
            this.buttonWhile.Size = new System.Drawing.Size(141, 42);
            this.buttonWhile.TabIndex = 33;
            this.buttonWhile.Text = "While Döngüsü";
            this.buttonWhile.UseVisualStyleBackColor = true;
            this.buttonWhile.Click += new System.EventHandler(this.buttonWhile_Click);
            // 
            // buttonDizi1
            // 
            this.buttonDizi1.Location = new System.Drawing.Point(715, 307);
            this.buttonDizi1.Name = "buttonDizi1";
            this.buttonDizi1.Size = new System.Drawing.Size(106, 42);
            this.buttonDizi1.TabIndex = 34;
            this.buttonDizi1.Text = "Diziler 1";
            this.buttonDizi1.UseVisualStyleBackColor = true;
            this.buttonDizi1.Click += new System.EventHandler(this.buttonDizi_Click);
            // 
            // buttonDizi2
            // 
            this.buttonDizi2.Location = new System.Drawing.Point(878, 307);
            this.buttonDizi2.Name = "buttonDizi2";
            this.buttonDizi2.Size = new System.Drawing.Size(106, 42);
            this.buttonDizi2.TabIndex = 35;
            this.buttonDizi2.Text = "Diziler 2";
            this.buttonDizi2.UseVisualStyleBackColor = true;
            this.buttonDizi2.Click += new System.EventHandler(this.buttonDizi2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxDers);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textAdSoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.comboBoxSınıf);
            this.groupBox1.Location = new System.Drawing.Point(33, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 188);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textSınavİki);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textSınavBir);
            this.groupBox2.Controls.Add(this.textSınavÜç);
            this.groupBox2.Location = new System.Drawing.Point(301, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(123, 183);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textDurum);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textOrt);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(440, 67);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            // 
            // ÖğrenciNotKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 506);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonDizi2);
            this.Controls.Add(this.buttonDizi1);
            this.Controls.Add(this.buttonWhile);
            this.Controls.Add(this.buttonTemiz);
            this.Controls.Add(this.buttonFor2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.buttonFor);
            this.Controls.Add(this.buttonMesaj);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonDers);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonTemizle);
            this.Controls.Add(this.buttonHesapla);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ÖğrenciNotKayıt";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textAdSoyad;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox comboBoxDers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textSınavBir;
        private System.Windows.Forms.TextBox textSınavİki;
        private System.Windows.Forms.TextBox textSınavÜç;
        private System.Windows.Forms.TextBox textOrt;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.Button buttonHesapla;
        private System.Windows.Forms.Button buttonTemizle;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textDurum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonDers;
        private System.Windows.Forms.ComboBox comboBoxSınıf;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonMesaj;
        private System.Windows.Forms.Button buttonFor;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button buttonFor2;
        private System.Windows.Forms.Button buttonTemiz;
        private System.Windows.Forms.Button buttonWhile;
        private System.Windows.Forms.Button buttonDizi1;
        private System.Windows.Forms.Button buttonDizi2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

