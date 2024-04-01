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
    public partial class FrmRezervasyonIslemleri : Form
    {
        OtelRezervasyon OdaIslemleri=new OtelRezervasyon();
        public FrmRezervasyonIslemleri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=OtelRezervasyon;Integrated Security=True");
        private void MusteriDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = MusteriDGV.CurrentRow;
            TxtAd.Text = satir.Cells["ad"].Value.ToString();
            CmbOdaTuru.Text = satir.Cells["odaturu"].Value.ToString();
            CmbKisiSayisi.Text = satir.Cells["kisisayisi"].Value.ToString();
            dateGiris.Text = satir.Cells["giristarihi"].Value.ToString();
            dateCikis.Text = satir.Cells["cikistarihi"].Value.ToString();

        }

        private void YenilemeListele()
        {
                string cumle = "select * from Rezervasyon";
                SqlDataAdapter adtr2 = new SqlDataAdapter();
                MusteriDGV.DataSource = OdaIslemleri.Listeleme(adtr2, cumle);   
        }

        private void FrmRezervasyonIslemleri_Load(object sender, EventArgs e)
        {
            YenilemeListele();
            CmbOdaDurumu.SelectedIndex = 0;
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            string cumle = " update Rezervasyon set ad=@ad, odaturu=@odaturu, kisisayisi=@kisisayisi, giristarihi=@giristarihi, cikistarihi=@cikistarihi where OdaAdi=@OdaAdi";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@ad", TxtAd.Text);
            komut2.Parameters.AddWithValue("@OdaAdi", TxtOdaAdi.Text);
            komut2.Parameters.AddWithValue("@odaturu", CmbOdaTuru.Text);
            komut2.Parameters.AddWithValue("@kisisayisi", CmbKisiSayisi.Text);
            komut2.Parameters.AddWithValue("@giristarihi", DateTime.Now.ToString());
            komut2.Parameters.AddWithValue("@cikistarihi", DateTime.Now.ToString());
            komut2.Parameters.AddWithValue("@Durumu", "Bos");

            OdaIslemleri.Ekle_Sil_Güncelle(komut2, cumle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            MessageBox.Show("Rezervasyon Başarıyla Güncellendi...");
            YenilemeListele();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Rezervasyonu Silmek İstediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                DataGridViewRow satir = MusteriDGV.CurrentRow;
                string cumle = " delete from Rezervasyon where odaadi ='" + satir.Cells["odaadi"].Value.ToString() + "'";
                SqlCommand komut2 = new SqlCommand();
                OdaIslemleri.Ekle_Sil_Güncelle(komut2, cumle);
                YenilemeListele();
                foreach (Control item in Controls) if (item is TextBox) item.Text = "";
                foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
                MessageBox.Show("Rezervasyon Başarıyla Silindi...");
            }
            else
            {
                MessageBox.Show("Rezervasyon Silme İşlemi İptal Ediliyor...");
            }
        }

        private void CmbOdaDurumu_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CmbOdaDurumu.SelectedIndex == 0)
                {
                    YenilemeListele();
                }
                if (CmbOdaDurumu.SelectedIndex == 1)
                {
                    string cumle = "select * from Rezervasyon where Durumu='Dolu'";
                    SqlDataAdapter adtr2 = new SqlDataAdapter();
                    MusteriDGV.DataSource = OdaIslemleri.Listeleme(adtr2, cumle);
                }
                if (CmbOdaDurumu.SelectedIndex == 2)
                {
                    string cumle = "select * from Rezervasyon where Durumu='Bos'";
                    SqlDataAdapter adtr2 = new SqlDataAdapter();
                    MusteriDGV.DataSource = OdaIslemleri.Listeleme(adtr2, cumle);
                }
            }
            catch
            {

            }
        }
    }
}
