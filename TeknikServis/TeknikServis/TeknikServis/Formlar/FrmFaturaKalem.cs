using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Formlar
{
    public partial class FrmFaturaKalem : Form
    {
        public FrmFaturaKalem()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
      

        private void FrmFaturaKalem_Load(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLFATURADETAY
                           select new
                           {
                               u.FATURADETAYID,
                               u.URUN,
                               u.ADET,
                               u.FIYAT,
                               u.TUTAR,
                               u.FATURAID
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLFATURADETAY t = new TBLFATURADETAY();
            t.URUN=txtUrün.Text;
            t.ADET = short.Parse(txtAdet.Text);
            t.FIYAT = decimal.Parse(txtFiyat.Text);
            t.TUTAR = decimal.Parse(txtTutar.Text);
            t.FATURAID=int.Parse(txtFaturaID.Text);
            db.TBLFATURADETAY.Add(t);
            db.SaveChanges();
            MessageBox.Show("Faturaya Ait Kalem Girişi Başarıyla Yapıldı.");


        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLFATURADETAY
                           select new
                           {
                               u.FATURADETAYID,
                               u.URUN,
                               u.ADET,
                               u.FIYAT,
                               u.TUTAR,
                               u.FATURAID
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var deger = db.TBLFATURADETAY.Find(id);
            db.TBLFATURADETAY.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Faturaya Ait Kalem Başarıyla Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var deger = db.TBLFATURADETAY.Find(id);
            deger.URUN = txtUrün.Text;
            deger.ADET = short.Parse(txtAdet.Text);
            deger.FIYAT = decimal.Parse(txtFiyat.Text);
            deger.TUTAR = decimal.Parse(txtTutar.Text);
            deger.FATURAID = int.Parse(txtFaturaID.Text);
            db.TBLFATURADETAY.Add(deger);
            db.SaveChanges();
            MessageBox.Show("Faturaya Ait Kalem Girişi Başarıyla Güncellendi.");
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtUrün.Text = "";
            txtAdet.Text = "";
            txtFiyat.Text = "";
            txtTutar.Text = "";
            txtFaturaID.Text = "";


        }
    }
}
