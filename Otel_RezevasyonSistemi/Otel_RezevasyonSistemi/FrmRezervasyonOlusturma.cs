using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel_RezevasyonSistemi
{
    public partial class FrmRezervasyonOlusturma : Form
    {
        OtelRezervasyon rezervasyon=new OtelRezervasyon();
        public FrmRezervasyonOlusturma()
        {
            InitializeComponent();
        }

        private void CmbOdaTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "select *from Oda where OdaAdi like '" + CmbOdaTuru.SelectedItem + "'";
            rezervasyon.Ucret_Hesapla(CmbOdaTuru, TxtOdaUcreti, sorgu2);
        }

        private void Bos_Odalar()
        {
            string sorgu2 = "select * from Oda where Durumu='Bos'";
            rezervasyon.Bos_Odalar(CmbOdaAdi, sorgu2);
        }

        private void Yenileme()
        {
            string sorgu3 = "select * from Rezervasyon";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = rezervasyon.Listeleme(adtr2, sorgu3);
        }

        private void FrmRezervasyonOlusturma_Load(object sender, EventArgs e)
        {
            Yenileme();
            Bos_Odalar();
        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            TimeSpan gun = DateTime.Parse(dateCikis.Text) - DateTime.Parse(dateGiris.Text);
            int gun2 = gun.Days;
            TxtGun.Text = gun2.ToString();
            TxtTutar.Text = (gun2 * int.Parse(TxtOdaUcreti.Text)).ToString();
        }

        private void Temizle()
        {
            dateCikis.Text = DateTime.Now.ToShortDateString();
            dateGiris.Text = DateTime.Now.ToShortDateString();
            CmbOdaTuru.Text = "";
            TxtOdaUcreti.Text = "";
            TxtGun.Text = "";
            TxtTutar.Text = "";
            CmbOdaAdi.Text = "";
            CmbKisiSayisi.Text = "";
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            maskedTxtTc.Text = "";
            maskedTxtTelefon.Text = "";
            TxtAdres.Text = "";
            TxtEmail.Text = "";
            maskedTxtDogumTarih.Text = "";
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "insert into Rezervasyon(tc,ad,soyad,telefon,adres,email,yas,odaadi,odaturu,kisisayisi," +
                "giristarihi,cikistarihi,odaucreti,gun,tutar) values(@tc,@ad,@soyad,@telefon,@adres,@email,@yas,@odaadi,@odaturu," +
                "@kisisayisi,@giristarihi,@cikistarihi,@odaucreti,@gun,@tutar)";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.AddWithValue("@tc", maskedTxtTc.Text);
            komut.Parameters.AddWithValue("@ad", TxtAd.Text);
            komut.Parameters.AddWithValue("@soyad", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@telefon", maskedTxtTelefon.Text);
            komut.Parameters.AddWithValue("@adres", TxtAdres.Text);
            komut.Parameters.AddWithValue("@email", TxtEmail.Text);
            komut.Parameters.AddWithValue("@yas", maskedTxtDogumTarih.Text);
            komut.Parameters.AddWithValue("@odaadi", CmbOdaAdi.Text);
            komut.Parameters.AddWithValue("@odaturu", CmbOdaTuru.Text);
            komut.Parameters.AddWithValue("@kisisayisi", CmbKisiSayisi.Text);
            komut.Parameters.AddWithValue("@odaucreti", TxtOdaUcreti.Text);
            komut.Parameters.AddWithValue("@gun", int.Parse((TxtGun.Text)));
            komut.Parameters.AddWithValue("@tutar", int.Parse((TxtTutar.Text)));
            komut.Parameters.AddWithValue("@cikistarihi", dateCikis.Text);
            komut.Parameters.AddWithValue("@giristarihi", dateGiris.Text);
            rezervasyon.Ekle_Sil_Güncelle(komut, sorgu2);

            string sorgu3 = "update Oda set Durumu='Dolu' where OdaAdi='" + CmbOdaAdi.Text + "'";
            SqlCommand komut2 = new SqlCommand();
            rezervasyon.Ekle_Sil_Güncelle(komut2, sorgu3);
            CmbOdaAdi.Items.Clear();
            Bos_Odalar();
            Yenileme();
            foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
            CmbOdaAdi.Text = "";
            Temizle();
            MessageBox.Show("Rezervasyon Başarıyla Oluşturuldu...");
        }

        private void TxtTcAra_TextChanged(object sender, EventArgs e)
        {
            if (TxtTcAra.Text == "") foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            string sorgu2 = "select * from Musteri where tc like '" + TxtTcAra.Text + "'";
            rezervasyon.Tc_Ara(TxtTcAra, maskedTxtTc, TxtAd, TxtSoyad, maskedTxtTelefon,TxtAdres,TxtEmail,maskedTxtDogumTarih, sorgu2);
        }

        
    }
}
