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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLPERSONEL
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.SOYAD,
                               u.MAIL,
                               u.TELEFON
                           };
            gridControl1.DataSource = degerler.ToList();
            lookUpEdit1.Properties.DataSource = (from x in db.TBLDEPARTMAN
                                                select new
                                                {
                                                 x.ID,
                                                 x.AD
                                                }).ToList();
            lookUpEdit1.Properties.DisplayMember = "AD";
            lookUpEdit1.Properties.ValueMember = "ID";
          




            //------------ 1 Numaralı Personel -----------
            string ad1, soyad1;
            ad1 = db.TBLPERSONEL.First(x => x.ID == 1).AD;
            soyad1 = db.TBLPERSONEL.First(x => x.ID == 1).SOYAD;
            labelControl8.Text=db.TBLPERSONEL.First(x=>x.ID == 1).MAIL;
            labelControl5.Text = db.TBLPERSONEL.First(x => x.ID == 1).TBLDEPARTMAN.AD;
            labelControl3.Text = ad1 + " " + soyad1;
            //------------ 2 Numaralı Personel -----------
            string ad2, soyad2;

            ad2 = db.TBLPERSONEL.First(x => x.ID == 2).AD;
            soyad2 = db.TBLPERSONEL.First(x => x.ID == 2).SOYAD;
            labelControl9.Text = db.TBLPERSONEL.First(x => x.ID == 2).MAIL;
            labelControl10.Text = db.TBLPERSONEL.First(x => x.ID == 2).TBLDEPARTMAN.AD;
            labelControl11.Text = ad2 + " " + soyad2;

            //------------ 3 Numaralı Personel -----------
            string ad3, soyad3;

            ad3 = db.TBLPERSONEL.First(x => x.ID == 3).AD;
            soyad3 = db.TBLPERSONEL.First(x => x.ID == 3).SOYAD;
            labelControl16.Text = db.TBLPERSONEL.First(x => x.ID == 3).MAIL;
            labelControl17.Text = db.TBLPERSONEL.First(x => x.ID == 3).TBLDEPARTMAN.AD;
            labelControl20.Text = ad3 + " " + soyad3;

            //------------ 4 Numaralı Personel -----------
            string ad4, soyad4;

            ad4 = db.TBLPERSONEL.First(x => x.ID == 4).AD;
            soyad4 = db.TBLPERSONEL.First(x => x.ID == 4).SOYAD;
            labelControl18.Text = db.TBLPERSONEL.First(x => x.ID == 4).MAIL;
            labelControl19.Text = db.TBLPERSONEL.First(x => x.ID == 4).TBLDEPARTMAN.AD;
            labelControl24.Text = ad4 + " " + soyad4;


            //------------ 5 Numaralı Personel -----------
            string ad5, soyad5;

            ad5 = db.TBLPERSONEL.First(x => x.ID == 5).AD;
            soyad5 = db.TBLPERSONEL.First(x => x.ID == 5).SOYAD;
            labelControl28.Text = db.TBLPERSONEL.First(x => x.ID == 5).MAIL;
            labelControl29.Text = db.TBLPERSONEL.First(x => x.ID == 5).TBLDEPARTMAN.AD;
            labelControl30.Text = ad5 + " " + soyad5;

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLPERSONEL t = new TBLPERSONEL();
            t.AD = txtAd.Text;
            t.SOYAD = txtSoyad.Text;
            t.DEPARTMAN=byte.Parse(lookUpEdit1.EditValue.ToString());
            t.MAIL = txtMail.Text;
            t.TELEFON = txtTelefon.Text;
            db.TBLPERSONEL.Add(t);
            db.SaveChanges();
            MessageBox.Show("Personel Sisteme Eklendi.");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var deger = db.TBLPERSONEL.Find(id);
            db.TBLPERSONEL.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Personel Başarıyla Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtMail.Text = "";
            txtTelefon.Text = "";
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var t = db.TBLPERSONEL.Find(id);
            t.AD = txtAd.Text;
            t.SOYAD = txtSoyad.Text;
            t.DEPARTMAN = byte.Parse(lookUpEdit1.EditValue.ToString());
            t.MAIL = txtMail.Text;
            t.TELEFON = txtTelefon.Text;
            db.SaveChanges();
            MessageBox.Show("Personel Başarıyla Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLPERSONEL
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.SOYAD,
                               u.MAIL,
                               u.TELEFON
                           };
            gridControl1.DataSource = degerler.ToList();
        }
    }
}
