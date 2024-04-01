using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel_RezevasyonSistemi
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        private void BtnMusteriEkle_Click(object sender, EventArgs e)
        {
            FrmMusteriEkle MusteriEkelemeFormu= new FrmMusteriEkle();
            MusteriEkelemeFormu.ShowDialog();
            this.Hide();
        }

        private void BtnMusteriListeleme_Click(object sender, EventArgs e)
        {
            FrmMusteriListeleme MusteriListelemeFormu= new FrmMusteriListeleme();
            MusteriListelemeFormu.ShowDialog();
            this.Hide();
        }

        private void BtnRezervasyonOlusturma_Click(object sender, EventArgs e)
        {
            FrmRezervasyonOlusturma RezervasyonOlusturmaFormu=new FrmRezervasyonOlusturma();
            RezervasyonOlusturmaFormu.ShowDialog();
            this.Hide();
        }

        private void BtnRezervasyonListeleme_Click(object sender, EventArgs e)
        {
            FrmRezervasyonIslemleri RezervasyonListelemeFormu=new FrmRezervasyonIslemleri();
            RezervasyonListelemeFormu.ShowDialog();
            this.Hide();
        }

        

        private void BtnOdaIslemi_Click(object sender, EventArgs e)
        {
            FrmOdaİslemleri OdaIslemleriFormu = new FrmOdaİslemleri();
            OdaIslemleriFormu.ShowDialog();
            this.Hide();
        }
    }
}
