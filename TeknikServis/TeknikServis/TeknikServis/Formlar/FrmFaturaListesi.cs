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
    public partial class FrmFaturaListesi : Form
    {
        public FrmFaturaListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmFaturaListesi_Load(object sender, EventArgs e)
        {

            var degerler = from u in db.TBLFATURABILGI
                           select new
                           {
                               u.ID,
                               u.SERI,
                               u.SIRANO,
                               u.TARIH,
                               u.SAAT,
                               u.VERGIDAIRE,
                               CARI=u.TBLCARI.AD+" "+u.TBLCARI.SOYAD,
                               PERSONEL=u.TBLPERSONEL.AD+" "+u.TBLPERSONEL.SOYAD
                           };
            gridControl1.DataSource = degerler.ToList();
            lookUpEdit1.Properties.DataSource = (from x in db.TBLCARI
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD=x.AD+" "+x.SOYAD
                                                 }).ToList();
            lookUpEdit2.Properties.DataSource = (from x in db.TBLPERSONEL
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD = x.AD +" "+ x.SOYAD
                                                 }).ToList();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLFATURABILGI
                           select new
                           {
                               u.ID,
                               u.SERI,
                               u.SIRANO,
                               u.TARIH,
                               u.SAAT,
                               u.VERGIDAIRE,
                               CARI = u.TBLCARI.AD + " " + u.TBLCARI.SOYAD,
                               PERSONEL = u.TBLPERSONEL.AD + " " + u.TBLPERSONEL.SOYAD
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLFATURABILGI t = new TBLFATURABILGI();
            t.SERI=txtSeri.Text;
            t.SIRANO=txtSiraNo.Text;
            t.TARIH = Convert.ToDateTime(txtTarih.Text);
            t.SAAT = txtSaat.Text;
            t.VERGIDAIRE = txtVergiDairesi.Text;
            t.CARI = int.Parse(lookUpEdit1.EditValue.ToString());
            t.PERSONEL=short.Parse(lookUpEdit2.EditValue.ToString());
            db.TBLFATURABILGI.Add(t);
            db.SaveChanges();
            MessageBox.Show("Fatura Sisteme Kaydedilmiştir,Kalem Girişi Yapabilirsiniz");
        }
        public string id;
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaKalemPopUp fr = new FrmFaturaKalemPopUp();
           fr.id=int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            fr.Show();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var deger = db.TBLFATURABILGI.Find(id);
            db.TBLFATURABILGI.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Fatura Başarıyla Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var t = db.TBLFATURABILGI.Find(id);
            t.SERI = txtSeri.Text;
            t.SIRANO = txtSiraNo.Text;
            t.TARIH = Convert.ToDateTime(txtTarih.Text);
            t.SAAT = txtSaat.Text;
            t.VERGIDAIRE = txtVergiDairesi.Text;
            t.CARI = int.Parse(lookUpEdit1.EditValue.ToString());
            t.PERSONEL = short.Parse(lookUpEdit2.EditValue.ToString());
            db.TBLFATURABILGI.Add(t);
            db.SaveChanges();
            MessageBox.Show("Fatura Başarıyla Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtSeri.Text = "";
            txtSiraNo.Text = "";
            txtTarih.Text = "";
            txtSaat.Text = "";
            txtVergiDairesi.Text = "";
            lookUpEdit1.Text = "";
            lookUpEdit2.Text = "";

        }
    }
}
