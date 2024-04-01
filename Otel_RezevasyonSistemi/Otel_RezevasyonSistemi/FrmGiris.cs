using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace Otel_RezevasyonSistemi
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        public void Diller(string Culture)
        { 
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture=new CultureInfo(Culture);
            label1.Text = Localization.label1;
            label2.Text = Localization.label2;
            label3.Text = Localization.label3;
            BtnGiris.Text = Localization.BtnGiris;
            BtnIng.Text = Localization.BtnIng;
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            if (TxtKullaniciAdi.Text == "" || TxtSifre.Text == "")
            {
                MessageBox.Show("Eksik bilgi");
            }
            else if (TxtKullaniciAdi.Text == "admin" && TxtSifre.Text == "1234")
            {
                FrmAnaSayfa anaSayfa = new FrmAnaSayfa();
                anaSayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı yada Şifre");
            }
        }

        private void BtnTurkce_Click(object sender, EventArgs e)
        {
            Diller("");
        }

        private void BtnIng_Click(object sender, EventArgs e)
        {
            Diller("en-US");
        }
    }
}
