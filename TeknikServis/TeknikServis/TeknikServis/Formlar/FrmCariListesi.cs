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
    public partial class FrmCariListesi : Form
    {
        public FrmCariListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        int secilen;
        private void FrmCariListesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TBLCARI
                                       select new
                                       {
                                           x.ID,
                                           x.AD,
                                           x.SOYAD,
                                           x.MAIL,
                                           x.IL,
                                           x.ILCE
                                       }).ToList();
            labelControl12.Text = db.TBLCARI.Count().ToString();
            labelControl16.Text = db.TBLCARI.Select(x => x.IL).Distinct().Count().ToString();
            labelControl18.Text = db.TBLCARI.Select(x => x.ILCE).Distinct().Count().ToString();
            labelControl14.Text = (from x in db.TBLCARI
                                   orderby x.AD
                                   select x.IL).FirstOrDefault();

            lookUpEdit2.Properties.DataSource = (from u in db.TBLILLER
                                                 select new
                                                 {
                                                     u.id,
                                                     u.sehir
                                                 }).ToList();


        }

        private void lookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            secilen = int.Parse(lookUpEdit2.EditValue.ToString());
            lookUpEdit3.Properties.DataSource = (from u in db.TBLILCELER
                                                 select new
                                                 {
                                                     u.id,
                                                     u.ilce,
                                                     u.sehir

                                                 }).Where(z => z.sehir == secilen).ToList();


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLCARI t = new TBLCARI();
            t.AD = txtAd.Text;
            t.SOYAD = txtSoyad.Text;
            t.TELEFON = txtTelefon.Text;
            t.MAIL = txtMail.Text;
            t.IL = lookUpEdit2.Text;
            t.ILCE = lookUpEdit3.Text;
            t.BANKA = txtBanka.Text;
            t.VERGIDAIRESI = txtVergiDairesi.Text;
            t.VERGINO = txtVergiNo.Text;
            t.STATU = txtStatü.Text;
            t.ADRES = txtAdres.Text;
            db.TBLCARI.Add(t);
            db.SaveChanges();
            MessageBox.Show("Cari Eklendi");
            gridControl1.DataSource = (from x in db.TBLCARI
                                       select new
                                       {
                                           x.ID,
                                           x.AD,
                                           x.SOYAD,
                                           x.MAIL,
                                           x.IL,
                                           x.ILCE
                                       }).ToList();


        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TBLCARI
                                       select new
                                       {
                                           x.ID,
                                           x.AD,
                                           x.SOYAD,
                                           x.MAIL,
                                           x.IL,
                                           x.ILCE
                                       }).ToList();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var deger = db.TBLCARI.Find(id);
            db.TBLCARI.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Cari Başarıyla Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var t = db.TBLCARI.Find(id);
            t.AD = txtAd.Text;
            t.SOYAD = txtSoyad.Text;
            t.TELEFON = txtTelefon.Text;
            t.MAIL = txtMail.Text;
            t.IL = lookUpEdit2.Text;
            t.ILCE = lookUpEdit3.Text;
            t.BANKA = txtBanka.Text;
            t.VERGIDAIRESI = txtVergiDairesi.Text;
            t.VERGINO = txtVergiNo.Text;
            t.STATU = txtStatü.Text;
            t.ADRES = txtAdres.Text;
            db.TBLCARI.Add(t);
            db.SaveChanges();
            MessageBox.Show("Cari Başarıyla Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTelefon.Text = "";
            txtMail.Text = "";
            lookUpEdit2.Text = "";
            lookUpEdit3.Text = "";
            txtBanka.Text = "";
            txtVergiDairesi.Text = "";
            txtVergiNo.Text = "";
            txtStatü.Text = "";
            txtAdres.Text = "";
        }
    }
}
