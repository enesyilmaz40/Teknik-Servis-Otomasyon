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
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TBLURUN
                                       select new
                                       {
                                           x.AD,
                                           x.STOK
                                       }).Where(x => x.STOK < 30).ToList();
            gridControl2.DataSource = (from u in db.TBLCARI
                                       select new
                                       {
                                           u.AD,
                                           u.SOYAD,
                                           u.IL
                                       }).ToList();
            gridControl3.DataSource = (from y in db.TBLURUN
                            join u in db.TBLKATEGORI on y.KATEGORI equals u.ID
                            select new
                            {
                               ÜRÜNAD= y.AD,
                               KATEGORIAD= u.AD
                            }).ToList();

            DateTime bugun = DateTime.Today;
            var deger = (from i in db.TBLNOTLARIM.OrderBy(y => y.ID)
                         where (i.TARIH == bugun)
                         select new
                         {

                             i.BASLIK,
                             i.ICERIK
                         });
            gridControl4.DataSource = deger.ToList();

        
           
        }

   
    }
}
