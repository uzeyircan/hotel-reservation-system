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
    public partial class FrmMusteriEkle : Form
    {
        public FrmMusteriEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=Deneme;Integrated Security=True");

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            if (AdTb.Text == "" || SoyadTb.Text == "" || TcNoTb.Text == "" || AdresTb.Text == "" || YasTb.Text == "" || TelnoTb.Text == ""  || EmailTb.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");

            }
            else
            {
               
                    baglanti.Open();
                    string query = "insert into Musteri values('" + AdTb.Text + "','" + SoyadTb.Text + "','" + TcNoTb.Text + "','" + YasTb.Text + "','" + AdresTb.Text + "','" + TelnoTb.Text + "','" + EmailTb.Text + "')";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Müşteri Başarıyla eklendi");
                    baglanti.Close();
                    AdTb.Text = "";
                    SoyadTb.Text = "";
                    TcNoTb.Text = "";
                    YasTb.Text = "";
                    AdresTb.Text = "";
                    TelnoTb.Text = "";
                    EmailTb.Text = "";
                
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

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa anasayfaformu = new FrmAnaSayfa();
            anasayfaformu.ShowDialog();
            this.Close();
        }
    }
}
