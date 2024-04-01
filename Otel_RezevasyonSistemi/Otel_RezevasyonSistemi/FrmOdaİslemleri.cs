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
    public partial class FrmOdaİslemleri : Form
    {
        OtelRezervasyon OdaEkle=new OtelRezervasyon();
        public FrmOdaİslemleri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=Deneme;Integrated Security=True");
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            string ekle = "insert into Oda(OdaAdi,OdaTuru,OdaUcreti,Durumu) values(@OdaAdi," + "@OdaTuru,@OdaUcreti,@Durumu)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@OdaAdi", OdaAdTb.Text);
            komut2.Parameters.AddWithValue("@OdaTuru", OdaTurCb.Text);
            komut2.Parameters.AddWithValue("@OdaUcreti", int.Parse(OdaUcretTb.Text));
            komut2.Parameters.AddWithValue("@Durumu", "Bos");


            OdaEkle.Ekle_Sil_Güncelle(komut2, ekle);

            
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            MessageBox.Show("Oda Başarıyla Eklendi...");
        }

        private void BtnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
