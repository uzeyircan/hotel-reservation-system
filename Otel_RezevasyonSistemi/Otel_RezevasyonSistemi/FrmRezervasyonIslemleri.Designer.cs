namespace Otel_RezevasyonSistemi
{
    partial class FrmRezervasyonIslemleri
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateCikis = new System.Windows.Forms.DateTimePicker();
            this.dateGiris = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbKisiSayisi = new System.Windows.Forms.ComboBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.CmbOdaDurumu = new System.Windows.Forms.ComboBox();
            this.CmbOdaTuru = new System.Windows.Forms.ComboBox();
            this.BtnIptal = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.MusteriDGV = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtOdaAdi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MusteriDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // dateCikis
            // 
            this.dateCikis.Location = new System.Drawing.Point(144, 530);
            this.dateCikis.Margin = new System.Windows.Forms.Padding(4);
            this.dateCikis.Name = "dateCikis";
            this.dateCikis.Size = new System.Drawing.Size(262, 22);
            this.dateCikis.TabIndex = 86;
            // 
            // dateGiris
            // 
            this.dateGiris.Location = new System.Drawing.Point(144, 421);
            this.dateGiris.Margin = new System.Windows.Forms.Padding(4);
            this.dateGiris.Name = "dateGiris";
            this.dateGiris.Size = new System.Drawing.Size(262, 22);
            this.dateGiris.TabIndex = 87;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(11, 525);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 81;
            this.label5.Text = "Çıkış Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(15, 415);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 82;
            this.label3.Text = "Giriş Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 305);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 83;
            this.label2.Text = "Kişi Sayısı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 195);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 84;
            this.label1.Text = "Oda Türü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(83, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 25);
            this.label4.TabIndex = 85;
            this.label4.Text = "Ad";
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
            this.CmbKisiSayisi.Location = new System.Drawing.Point(144, 305);
            this.CmbKisiSayisi.Margin = new System.Windows.Forms.Padding(4);
            this.CmbKisiSayisi.Name = "CmbKisiSayisi";
            this.CmbKisiSayisi.Size = new System.Drawing.Size(249, 24);
            this.CmbKisiSayisi.TabIndex = 77;
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(144, 51);
            this.TxtAd.Margin = new System.Windows.Forms.Padding(4);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(249, 22);
            this.TxtAd.TabIndex = 80;
            // 
            // CmbOdaDurumu
            // 
            this.CmbOdaDurumu.FormattingEnabled = true;
            this.CmbOdaDurumu.Items.AddRange(new object[] {
            "Tüm Odalar",
            "Dolu Odalar",
            "Boş Odalar"});
            this.CmbOdaDurumu.Location = new System.Drawing.Point(1109, 68);
            this.CmbOdaDurumu.Margin = new System.Windows.Forms.Padding(4);
            this.CmbOdaDurumu.Name = "CmbOdaDurumu";
            this.CmbOdaDurumu.Size = new System.Drawing.Size(249, 24);
            this.CmbOdaDurumu.TabIndex = 78;
            this.CmbOdaDurumu.SelectedIndexChanged += new System.EventHandler(this.CmbOdaDurumu_SelectedIndexChanged);
            // 
            // CmbOdaTuru
            // 
            this.CmbOdaTuru.FormattingEnabled = true;
            this.CmbOdaTuru.Items.AddRange(new object[] {
            "Aile odası",
            "Kral dairesi",
            "Engelli odası",
            "Balayı Odası "});
            this.CmbOdaTuru.Location = new System.Drawing.Point(144, 195);
            this.CmbOdaTuru.Margin = new System.Windows.Forms.Padding(4);
            this.CmbOdaTuru.Name = "CmbOdaTuru";
            this.CmbOdaTuru.Size = new System.Drawing.Size(249, 24);
            this.CmbOdaTuru.TabIndex = 79;
            // 
            // BtnIptal
            // 
            this.BtnIptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnIptal.FlatAppearance.BorderSize = 0;
            this.BtnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIptal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnIptal.ForeColor = System.Drawing.Color.White;
            this.BtnIptal.Location = new System.Drawing.Point(1208, 552);
            this.BtnIptal.Margin = new System.Windows.Forms.Padding(4);
            this.BtnIptal.Name = "BtnIptal";
            this.BtnIptal.Size = new System.Drawing.Size(150, 55);
            this.BtnIptal.TabIndex = 76;
            this.BtnIptal.Text = "İptal";
            this.BtnIptal.UseVisualStyleBackColor = false;
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnSil.FlatAppearance.BorderSize = 0;
            this.BtnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSil.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.ForeColor = System.Drawing.Color.White;
            this.BtnSil.Location = new System.Drawing.Point(1032, 552);
            this.BtnSil.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(150, 55);
            this.BtnSil.TabIndex = 75;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnGuncelle.FlatAppearance.BorderSize = 0;
            this.BtnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuncelle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.ForeColor = System.Drawing.Color.White;
            this.BtnGuncelle.Location = new System.Drawing.Point(838, 552);
            this.BtnGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(169, 55);
            this.BtnGuncelle.TabIndex = 74;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // MusteriDGV
            // 
            this.MusteriDGV.AllowUserToAddRows = false;
            this.MusteriDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.MusteriDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.MusteriDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MusteriDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.MusteriDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MusteriDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.MusteriDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MusteriDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.MusteriDGV.Location = new System.Drawing.Point(429, 112);
            this.MusteriDGV.Margin = new System.Windows.Forms.Padding(4);
            this.MusteriDGV.Name = "MusteriDGV";
            this.MusteriDGV.ReadOnly = true;
            this.MusteriDGV.RowHeadersWidth = 51;
            this.MusteriDGV.Size = new System.Drawing.Size(929, 432);
            this.MusteriDGV.TabIndex = 73;
            this.MusteriDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MusteriDGV_CellDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(25, 112);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 89;
            this.label6.Text = "Oda Adı :";
            // 
            // TxtOdaAdi
            // 
            this.TxtOdaAdi.Location = new System.Drawing.Point(144, 112);
            this.TxtOdaAdi.Margin = new System.Windows.Forms.Padding(4);
            this.TxtOdaAdi.Name = "TxtOdaAdi";
            this.TxtOdaAdi.Size = new System.Drawing.Size(249, 22);
            this.TxtOdaAdi.TabIndex = 88;
            // 
            // FrmRezervasyonIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 689);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtOdaAdi);
            this.Controls.Add(this.dateCikis);
            this.Controls.Add(this.dateGiris);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmbKisiSayisi);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.CmbOdaDurumu);
            this.Controls.Add(this.CmbOdaTuru);
            this.Controls.Add(this.BtnIptal);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.MusteriDGV);
            this.Name = "FrmRezervasyonIslemleri";
            this.Text = "FrmRezervasyonListeleme";
            this.Load += new System.EventHandler(this.FrmRezervasyonIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MusteriDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateCikis;
        private System.Windows.Forms.DateTimePicker dateGiris;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbKisiSayisi;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.ComboBox CmbOdaDurumu;
        private System.Windows.Forms.ComboBox CmbOdaTuru;
        private System.Windows.Forms.Button BtnIptal;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.DataGridView MusteriDGV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtOdaAdi;
    }
}