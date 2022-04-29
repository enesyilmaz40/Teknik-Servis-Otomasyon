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
    public partial class FrmUrunListe : Form
    {
        public FrmUrunListe()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();
        void Metot1()
        {
            var degerler = from u in db.TBLURUN
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.MARKA,
                               KATEGORI=u.TBLKATEGORI.AD,
                               u.STOK,
                               u.ALISFIYAT,
                               u.SATISFIYAT,
                              
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmUrunListe_Load(object sender, EventArgs e)
        {
            //Listeleme ToList Add Remove 
            //var degerler = db.TBLURUN.ToList();
            Metot1();
            lookUpEdit1.Properties.DataSource = (from u in db.TBLKATEGORI
                                                select new
                                                {
                                                    u.ID,
                                                    u.AD,
                                                }).ToList();


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLURUN t = new TBLURUN();
            t.AD = txtUrunAd.Text;
            t.MARKA = txtMarka.Text;
            t.ALISFIYAT = decimal.Parse(txtAlisFiyat.Text);
            t.SATISFIYAT = decimal.Parse(txtSatisFiyat.Text);
            t.STOK = short.Parse(txtStok.Text);
            t.DURUM = false;
            t.KATEGORI = byte.Parse(lookUpEdit1.EditValue.ToString());
            db.TBLURUN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Metot1();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                txtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                txtUrunAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
                txtMarka.Text = gridView1.GetFocusedRowCellValue("MARKA").ToString();
                txtAlisFiyat.Text = gridView1.GetFocusedRowCellValue("ALISFIYAT").ToString();
                txtSatisFiyat.Text = gridView1.GetFocusedRowCellValue("SATISFIYAT").ToString();
                txtStok.Text = gridView1.GetFocusedRowCellValue("STOK").ToString();
                lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("KATEGORI").ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Hata");
            }
         
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var deger = db.TBLURUN.Find(id);
            db.TBLURUN.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var deger = db.TBLURUN.Find(id);
            deger.AD = txtUrunAd.Text;
            deger.MARKA = txtMarka.Text;
            deger.STOK = short.Parse(txtStok.Text);
            deger.ALISFIYAT = decimal.Parse(txtAlisFiyat.Text);
            deger.SATISFIYAT = decimal.Parse(txtSatisFiyat.Text);
            deger.KATEGORI = byte.Parse(lookUpEdit1.EditValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAlisFiyat.Text = "";
            txtID.Text = "";
            txtMarka.Text = "";
            txtSatisFiyat.Text = "";
            txtStok.Text = "";
            txtUrunAd.Text = "";
        }
    }
}
