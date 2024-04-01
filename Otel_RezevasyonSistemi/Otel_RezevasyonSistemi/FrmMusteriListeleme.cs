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
    public partial class FrmMusteriListeleme : Form
    {
        OtelRezervasyon MusteriListeleme=new OtelRezervasyon();
        public FrmMusteriListeleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=OtelRezervasyon;Integrated Security=True");
        private void musteriler()
        {
            string cumle = "select*from Musteri";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            MusteriDGV.DataSource = MusteriListeleme.Listeleme(adtr2,cumle);
            MusteriDGV.Columns[0].HeaderText = "Id";
            MusteriDGV.Columns[1].HeaderText = "Ad";
            MusteriDGV.Columns[2].HeaderText = "Soyad";
            MusteriDGV.Columns[3].HeaderText = "Tc No";
            MusteriDGV.Columns[4].HeaderText = "Yaş";
            MusteriDGV.Columns[5].HeaderText = "Adres";
            MusteriDGV.Columns[6].HeaderText = "Telefon No";
            MusteriDGV.Columns[7].HeaderText = "Email";
            
        }
        
       

        private void button3_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Silinecek müşteriyi seçiniz");

            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "delete from Musteri where id=" + key + ";";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Müşteri Başarıyla Silindi");
                    baglanti.Close();
                    musteriler();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void AdFiltrele()
        {
            baglanti.Open();
            string query = "select * from Musteri where Ad='" + AraUyeTb.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            MusteriDGV.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            AdFiltrele();
            AraUyeTb.Text = "";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            musteriler();
        }

        

        
        
        private void MusteriDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = MusteriDGV.CurrentRow;
            key = Convert.ToInt32(satir.Cells[0].Value.ToString());
            AdTb.Text = satir.Cells[1].Value.ToString();
            SoyadTb.Text = satir.Cells[2].Value.ToString();
            TcNoTb.Text = satir.Cells[3].Value.ToString();
            YasTb.Text = satir.Cells[4].Value.ToString();
            AdresTb.Text = satir.Cells[5].Value.ToString();
            TelnoTb.Text = satir.Cells[6].Value.ToString();
            EmailTb.Text = satir.Cells[7].Value.ToString();
            
        }

        private void FrmMusteriListeleme_Load(object sender, EventArgs e)
        {
            musteriler();
            
        }

        private void MusteriDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = MusteriDGV.CurrentRow;
            AdTb.Text = satir.Cells[1].Value.ToString();
            SoyadTb.Text = satir.Cells[2].Value.ToString();
            TcNoTb.Text = satir.Cells[3].Value.ToString();
            YasTb.Text = satir.Cells[4].Value.ToString();
            AdresTb.Text = satir.Cells[5].Value.ToString();
            TelnoTb.Text = satir.Cells[6].Value.ToString();
            EmailTb.Text = satir.Cells[7].Value.ToString();
            
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            string cumle = "update Musteri set ad=@ad, soyad=@soyad, telefon=@telefon, adres=@adres, email=@email," +
            " yas=@yas where tc=@tc";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@tc", TcNoTb.Text);
            komut2.Parameters.AddWithValue("@ad", AdTb.Text);
            komut2.Parameters.AddWithValue("@soyad", SoyadTb.Text);
            komut2.Parameters.AddWithValue("@telefon", TelnoTb.Text);
            komut2.Parameters.AddWithValue("@adres", AdresTb.Text);
            komut2.Parameters.AddWithValue("@email", EmailTb.Text);
            komut2.Parameters.AddWithValue("@yas", YasTb.Text);

            MusteriListeleme.Ekle_Sil_Güncelle(komut2, cumle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is MaskedTextBox) item.Text = "";
            musteriler();



        }
        int key = 0;
        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Silinecek müşteriyi seçiniz");

            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "delete from Musteri where id=" + key + ";";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Müşteri Başarıyla Silindi");
                    baglanti.Close();
                    musteriler();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            AdTb.Text = "";
            SoyadTb.Text = "";
            TcNoTb.Text = "";
            YasTb.Text = "";
            AdresTb.Text = "";
            TelnoTb.Text = "";
            EmailTb.Text = "";
        }
    }
}
