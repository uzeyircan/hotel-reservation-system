namespace Otel_RezevasyonSistemi
{
    partial class FrmRezervasyonOlusturma
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTxtTc = new System.Windows.Forms.MaskedTextBox();
            this.maskedTxtDogumTarih = new System.Windows.Forms.MaskedTextBox();
            this.maskedTxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtAdres = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.TxtTcAra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnHesapla = new System.Windows.Forms.Button();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.CmbOdaAdi = new System.Windows.Forms.ComboBox();
            this.CmbOdaTuru = new System.Windows.Forms.ComboBox();
            this.CmbKisiSayisi = new System.Windows.Forms.ComboBox();
            this.dateCikis = new System.Windows.Forms.DateTimePicker();
            this.dateGiris = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.TxtTutar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtOdaUcreti = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtGun = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTxtTc);
            this.groupBox1.Controls.Add(this.maskedTxtDogumTarih);
            this.groupBox1.Controls.Add(this.maskedTxtTelefon);
            this.groupBox1.Controls.Add(this.TxtEmail);
            this.groupBox1.Controls.Add(this.TxtAdres);
            this.groupBox1.Controls.Add(this.TxtSoyad);
            this.groupBox1.Controls.Add(this.TxtAd);
            this.groupBox1.Controls.Add(this.TxtTcAra);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(334, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(884, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // maskedTxtTc
            // 
            this.maskedTxtTc.Location = new System.Drawing.Point(57, 47);
            this.maskedTxtTc.Mask = "00000000000";
            this.maskedTxtTc.Name = "maskedTxtTc";
            this.maskedTxtTc.Size = new System.Drawing.Size(130, 22);
            this.maskedTxtTc.TabIndex = 16;
            // 
            // maskedTxtDogumTarih
            // 
            this.maskedTxtDogumTarih.Location = new System.Drawing.Point(639, 91);
            this.maskedTxtDogumTarih.Mask = "00/00/0000";
            this.maskedTxtDogumTarih.Name = "maskedTxtDogumTarih";
            this.maskedTxtDogumTarih.Size = new System.Drawing.Size(106, 22);
            this.maskedTxtDogumTarih.TabIndex = 15;
            this.maskedTxtDogumTarih.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTxtTelefon
            // 
            this.maskedTxtTelefon.Location = new System.Drawing.Point(679, 41);
            this.maskedTxtTelefon.Mask = "(999) 000-0000";
            this.maskedTxtTelefon.Name = "maskedTxtTelefon";
            this.maskedTxtTelefon.Size = new System.Drawing.Size(117, 22);
            this.maskedTxtTelefon.TabIndex = 14;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(369, 91);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(103, 22);
            this.TxtEmail.TabIndex = 13;
            // 
            // TxtAdres
            // 
            this.TxtAdres.Location = new System.Drawing.Point(132, 94);
            this.TxtAdres.Name = "TxtAdres";
            this.TxtAdres.Size = new System.Drawing.Size(100, 22);
            this.TxtAdres.TabIndex = 12;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(478, 44);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(94, 22);
            this.TxtSoyad.TabIndex = 11;
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(262, 44);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(103, 22);
            this.TxtAd.TabIndex = 10;
            // 
            // TxtTcAra
            // 
            this.TxtTcAra.Location = new System.Drawing.Point(705, 9);
            this.TxtTcAra.Multiline = true;
            this.TxtTcAra.Name = "TxtTcAra";
            this.TxtTcAra.Size = new System.Drawing.Size(170, 22);
            this.TxtTcAra.TabIndex = 8;
            this.TxtTcAra.TextChanged += new System.EventHandler(this.TxtTcAra_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(526, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Doğum Tarihi : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(303, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Email : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Adres : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(601, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefon : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Soyad : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ad : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tc : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(636, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tc Ara :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnHesapla);
            this.groupBox2.Controls.Add(this.BtnTemizle);
            this.groupBox2.Controls.Add(this.BtnEkle);
            this.groupBox2.Controls.Add(this.CmbOdaAdi);
            this.groupBox2.Controls.Add(this.CmbOdaTuru);
            this.groupBox2.Controls.Add(this.CmbKisiSayisi);
            this.groupBox2.Controls.Add(this.dateCikis);
            this.groupBox2.Controls.Add(this.dateGiris);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.TxtTutar);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.TxtOdaUcreti);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.TxtGun);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 527);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Oda Bilgileri";
            // 
            // BtnHesapla
            // 
            this.BtnHesapla.Location = new System.Drawing.Point(117, 461);
            this.BtnHesapla.Name = "BtnHesapla";
            this.BtnHesapla.Size = new System.Drawing.Size(83, 39);
            this.BtnHesapla.TabIndex = 33;
            this.BtnHesapla.Text = "Hesapla";
            this.BtnHesapla.UseVisualStyleBackColor = true;
            this.BtnHesapla.Click += new System.EventHandler(this.BtnHesapla_Click);
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Location = new System.Drawing.Point(215, 461);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(83, 39);
            this.BtnTemizle.TabIndex = 32;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.UseVisualStyleBackColor = true;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(12, 461);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(83, 39);
            this.BtnEkle.TabIndex = 31;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // CmbOdaAdi
            // 
            this.CmbOdaAdi.FormattingEnabled = true;
            this.CmbOdaAdi.Location = new System.Drawing.Point(108, 34);
            this.CmbOdaAdi.Name = "CmbOdaAdi";
            this.CmbOdaAdi.Size = new System.Drawing.Size(190, 24);
            this.CmbOdaAdi.TabIndex = 30;
            // 
            // CmbOdaTuru
            // 
            this.CmbOdaTuru.FormattingEnabled = true;
            this.CmbOdaTuru.Items.AddRange(new object[] {
            "Aile odası",
            "Kral dairesi",
            "Engelli odası",
            "Balayı Odası "});
            this.CmbOdaTuru.Location = new System.Drawing.Point(108, 88);
            this.CmbOdaTuru.Name = "CmbOdaTuru";
            this.CmbOdaTuru.Size = new System.Drawing.Size(190, 24);
            this.CmbOdaTuru.TabIndex = 29;
            this.CmbOdaTuru.SelectedIndexChanged += new System.EventHandler(this.CmbOdaTuru_SelectedIndexChanged);
            // 
            // CmbKisiSayisi
            // 
            this.CmbKisiSayisi.FormattingEnabled = true;
            this.CmbKisiSayisi.Items.AddRange(new object[] {
            "1 Kişi\t",
            "2 Kişi",
            "3 Kişi",
            "4 Kişi",
            "5 Kişi",
            "6 Kişi"});
            this.CmbKisiSayisi.Location = new System.Drawing.Point(108, 147);
            this.CmbKisiSayisi.Name = "CmbKisiSayisi";
            this.CmbKisiSayisi.Size = new System.Drawing.Size(190, 24);
            this.CmbKisiSayisi.TabIndex = 28;
            // 
            // dateCikis
            // 
            this.dateCikis.Location = new System.Drawing.Point(108, 258);
            this.dateCikis.Name = "dateCikis";
            this.dateCikis.Size = new System.Drawing.Size(190, 22);
            this.dateCikis.TabIndex = 27;
            // 
            // dateGiris
            // 
            this.dateGiris.Location = new System.Drawing.Point(108, 203);
            this.dateGiris.Name = "dateGiris";
            this.dateGiris.Size = new System.Drawing.Size(190, 22);
            this.dateGiris.TabIndex = 26;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 264);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 16);
            this.label16.TabIndex = 25;
            this.label16.Text = "Çıkış Tarihi : ";
            // 
            // TxtTutar
            // 
            this.TxtTutar.Location = new System.Drawing.Point(108, 418);
            this.TxtTutar.Name = "TxtTutar";
            this.TxtTutar.Size = new System.Drawing.Size(190, 22);
            this.TxtTutar.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 313);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "Oda Ücreti   ";
            // 
            // TxtOdaUcreti
            // 
            this.TxtOdaUcreti.Location = new System.Drawing.Point(108, 310);
            this.TxtOdaUcreti.Name = "TxtOdaUcreti";
            this.TxtOdaUcreti.Size = new System.Drawing.Size(190, 22);
            this.TxtOdaUcreti.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 210);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 16);
            this.label15.TabIndex = 23;
            this.label15.Text = "Giriş Tarihi : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 367);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 16);
            this.label12.TabIndex = 17;
            this.label12.Text = "Gün : ";
            // 
            // TxtGun
            // 
            this.TxtGun.Location = new System.Drawing.Point(108, 364);
            this.TxtGun.Name = "TxtGun";
            this.TxtGun.Size = new System.Drawing.Size(190, 22);
            this.TxtGun.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 156);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 16);
            this.label14.TabIndex = 21;
            this.label14.Text = "Kişi Sayısı :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 421);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 16);
            this.label13.TabIndex = 19;
            this.label13.Text = "Tutar : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Oda Türü :  ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Oda Ad : ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(334, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(884, 392);
            this.dataGridView1.TabIndex = 2;
            // 
            // FrmRezervasyonOlusturma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1221, 551);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRezervasyonOlusturma";
            this.Text = "FrmRezervasyonOlusturma";
            this.Load += new System.EventHandler(this.FrmRezervasyonOlusturma_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox maskedTxtDogumTarih;
        private System.Windows.Forms.MaskedTextBox maskedTxtTelefon;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtAdres;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.TextBox TxtTcAra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTxtTc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtTutar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtGun;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtOdaUcreti;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateCikis;
        private System.Windows.Forms.DateTimePicker dateGiris;
        private System.Windows.Forms.ComboBox CmbOdaTuru;
        private System.Windows.Forms.ComboBox CmbKisiSayisi;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.ComboBox CmbOdaAdi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnHesapla;
    }
}