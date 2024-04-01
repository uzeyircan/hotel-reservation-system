using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Otel_RezevasyonSistemi
{
    internal class OtelRezervasyon
    {


        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=Deneme;Integrated Security=True");
        DataTable tablo;

        public void Ekle_Sil_Güncelle(SqlCommand komut, string sorgu)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public void Ucret_Hesapla(ComboBox CmbOdaTuru, TextBox ucret, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (CmbOdaTuru.SelectedIndex == 0) ucret.Text = (int.Parse(read["OdaUcreti"].ToString()) * 2).ToString();
                if (CmbOdaTuru.SelectedIndex == 1) ucret.Text = (int.Parse(read["OdaUcreti"].ToString()) * 5).ToString();
                if (CmbOdaTuru.SelectedIndex == 2) ucret.Text = (int.Parse(read["OdaUcreti"].ToString()) * 0.50).ToString();
                if (CmbOdaTuru.SelectedIndex == 1) ucret.Text = (int.Parse(read["OdaUcreti"].ToString()) * 3).ToString();
            }
            baglanti.Close();
        }

        public DataTable Listeleme(SqlDataAdapter adtr, string sorgu)
        {
            tablo = new DataTable();
            adtr = new SqlDataAdapter(sorgu, baglanti);
            adtr.Fill(tablo);
            baglanti.Close();
            return tablo;
        }

        public void Bos_Odalar(ComboBox combo, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combo.Items.Add(read["OdaAdi"].ToString());
            }
            baglanti.Close();
        }

        public void Tc_Ara(TextBox tcara, MaskedTextBox tc, TextBox ad, TextBox soyad, MaskedTextBox telefon, TextBox adres,TextBox email,MaskedTextBox Dogumtarihi ,string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                tc.Text = read["tc"].ToString();
                ad.Text = read["ad"].ToString();
                soyad.Text = read["soyad"].ToString();
                telefon.Text = read["telefon"].ToString();
                adres.Text = read["adres"].ToString();
                email.Text = read["email"].ToString();
                Dogumtarihi.Text = read["yas"].ToString();
            }
            baglanti.Close();
        }

        
    }
}
