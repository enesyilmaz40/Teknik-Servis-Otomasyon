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
    public partial class FrmArizaliUrunKaydi : Form
    {
        public FrmArizaliUrunKaydi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
         
            TBLURUNKABUL t = new TBLURUNKABUL();
           t.CARI= int.Parse(lookUpEdit1.EditValue.ToString());
            t.GELISTARIH=DateTime.Parse(txtTarih.Text);
            t.PERSONEL= short.Parse(lookUpEdit2.EditValue.ToString());
            t.URUNSERINO=txtSeriNo.Text;
            t.DURUMDETAY = "Ürün Kaydoldu";
            db.TBLURUNKABUL.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Arıza Girişi Yapıldı.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void FrmArizaliUrunKaydi_Load(object sender, EventArgs e)
        {
            //Muşteri
            lookUpEdit1.Properties.DataSource = (from u in db.TBLCARI
                                                 select new
                                                 {
                                                     u.ID,
                                                     ADSOYAD=u.AD+" "+u.SOYAD
                                                 }).ToList();
            lookUpEdit2.Properties.DataSource = (from u in db.TBLPERSONEL
                                                 select new
                                                 {
                                                     u.ID,
                                                     ADSOYAD = u.AD + " " + u.SOYAD
                                                 }).ToList();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureEdit8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTarih_Click(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }
    }
}
