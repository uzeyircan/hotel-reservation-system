namespace Otel_RezevasyonSistemi
{
    partial class FrmAnaSayfa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaSayfa));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BtnMusteriEkle = new System.Windows.Forms.Button();
            this.BtnMusteriListeleme = new System.Windows.Forms.Button();
            this.BtnRezervasyonOlusturma = new System.Windows.Forms.Button();
            this.BtnRezervasyonIslemleri = new System.Windows.Forms.Button();
            this.BtnOdaIslemi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(471, 534);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "add-user.png");
            this.ımageList1.Images.SetKeyName(1, "customer.png");
            this.ımageList1.Images.SetKeyName(2, "discount.png");
            this.ımageList1.Images.SetKeyName(3, "reserve.png");
            this.ımageList1.Images.SetKeyName(4, "reservation.png");
            this.ımageList1.Images.SetKeyName(5, "bed.png");
            // 
            // BtnMusteriEkle
            // 
            this.BtnMusteriEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMusteriEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMusteriEkle.ImageIndex = 0;
            this.BtnMusteriEkle.ImageList = this.ımageList1;
            this.BtnMusteriEkle.Location = new System.Drawing.Point(476, 31);
            this.BtnMusteriEkle.Name = "BtnMusteriEkle";
            this.BtnMusteriEkle.Size = new System.Drawing.Size(265, 179);
            this.BtnMusteriEkle.TabIndex = 1;
            this.BtnMusteriEkle.Text = "Müşteri Ekleme";
            this.BtnMusteriEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnMusteriEkle.UseVisualStyleBackColor = true;
            this.BtnMusteriEkle.Click += new System.EventHandler(this.BtnMusteriEkle_Click);
            // 
            // BtnMusteriListeleme
            // 
            this.BtnMusteriListeleme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMusteriListeleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMusteriListeleme.ImageIndex = 1;
            this.BtnMusteriListeleme.ImageList = this.ımageList1;
            this.BtnMusteriListeleme.Location = new System.Drawing.Point(717, 31);
            this.BtnMusteriListeleme.Name = "BtnMusteriListeleme";
            this.BtnMusteriListeleme.Size = new System.Drawing.Size(265, 179);
            this.BtnMusteriListeleme.TabIndex = 2;
            this.BtnMusteriListeleme.Text = "Müşteri Listeleme";
            this.BtnMusteriListeleme.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnMusteriListeleme.UseVisualStyleBackColor = true;
            this.BtnMusteriListeleme.Click += new System.EventHandler(this.BtnMusteriListeleme_Click);
            // 
            // BtnRezervasyonOlusturma
            // 
            this.BtnRezervasyonOlusturma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRezervasyonOlusturma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnRezervasyonOlusturma.ImageIndex = 3;
            this.BtnRezervasyonOlusturma.ImageList = this.ımageList1;
            this.BtnRezervasyonOlusturma.Location = new System.Drawing.Point(949, 31);
            this.BtnRezervasyonOlusturma.Name = "BtnRezervasyonOlusturma";
            this.BtnRezervasyonOlusturma.Size = new System.Drawing.Size(265, 179);
            this.BtnRezervasyonOlusturma.TabIndex = 3;
            this.BtnRezervasyonOlusturma.Text = "Rezervasyon Oluşturma";
            this.BtnRezervasyonOlusturma.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnRezervasyonOlusturma.UseVisualStyleBackColor = true;
            this.BtnRezervasyonOlusturma.Click += new System.EventHandler(this.BtnRezervasyonOlusturma_Click);
            // 
            // BtnRezervasyonIslemleri
            // 
            this.BtnRezervasyonIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRezervasyonIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnRezervasyonIslemleri.ImageIndex = 4;
            this.BtnRezervasyonIslemleri.ImageList = this.ımageList1;
            this.BtnRezervasyonIslemleri.Location = new System.Drawing.Point(543, 237);
            this.BtnRezervasyonIslemleri.Name = "BtnRezervasyonIslemleri";
            this.BtnRezervasyonIslemleri.Size = new System.Drawing.Size(265, 179);
            this.BtnRezervasyonIslemleri.TabIndex = 4;
            this.BtnRezervasyonIslemleri.Text = "Rezervasyon İşlemleri";
            this.BtnRezervasyonIslemleri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnRezervasyonIslemleri.UseVisualStyleBackColor = true;
            this.BtnRezervasyonIslemleri.Click += new System.EventHandler(this.BtnRezervasyonListeleme_Click);
            // 
            // BtnOdaIslemi
            // 
            this.BtnOdaIslemi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnOdaIslemi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOdaIslemi.ImageIndex = 5;
            this.BtnOdaIslemi.ImageList = this.ımageList1;
            this.BtnOdaIslemi.Location = new System.Drawing.Point(898, 237);
            this.BtnOdaIslemi.Name = "BtnOdaIslemi";
            this.BtnOdaIslemi.Size = new System.Drawing.Size(265, 179);
            this.BtnOdaIslemi.TabIndex = 6;
            this.BtnOdaIslemi.Text = "Oda İşlemleri";
            this.BtnOdaIslemi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnOdaIslemi.UseVisualStyleBackColor = true;
            this.BtnOdaIslemi.Click += new System.EventHandler(this.BtnOdaIslemi_Click);
            // 
            // FrmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1218, 529);
            this.Controls.Add(this.BtnOdaIslemi);
            this.Controls.Add(this.BtnRezervasyonIslemleri);
            this.Controls.Add(this.BtnRezervasyonOlusturma);
            this.Controls.Add(this.BtnMusteriListeleme);
            this.Controls.Add(this.BtnMusteriEkle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmAnaSayfa";
            this.Text = "FrmAnaSayfa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button BtnMusteriEkle;
        private System.Windows.Forms.Button BtnMusteriListeleme;
        private System.Windows.Forms.Button BtnRezervasyonOlusturma;
        private System.Windows.Forms.Button BtnRezervasyonIslemleri;
        private System.Windows.Forms.Button BtnOdaIslemi;
    }
}