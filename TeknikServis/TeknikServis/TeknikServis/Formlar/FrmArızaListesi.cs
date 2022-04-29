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

namespace TeknikServis.Formlar
{
    public partial class FrmArızaListesi : Form
    {
        public FrmArızaListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmArızaListesi_Load(object sender, EventArgs e)
        {
            var degerler = from x in db.TBLURUNKABUL
                           select new
                           {
                               x.ISLEMID,
                               CARİ= x.TBLCARI.AD +" "+ x.TBLCARI.SOYAD,
                               PERSONELAD =x.TBLPERSONEL.AD +" "+ x.TBLPERSONEL.SOYAD,
                               x.GELISTARIH,
                               x.CIKISTARIH,
                               x.URUNSERINO,
                               x.DURUMDETAY
                           };
            gridControl1.DataSource=degerler.ToList();
            labelControl5.Text=db.TBLURUNKABUL.Count(x=>x.URUNDURUM==true).ToString();
            labelControl3.Text=db.TBLURUNKABUL.Count(x=>x.URUNDURUM==false).ToString();
            labelControl13.Text=db.TBLURUN.Count().ToString();
            labelControl7.Text=db.TBLURUNKABUL.Count(x=>x.DURUMDETAY=="Parça Bekliyor").ToString();
            labelControl15.Text=db.TBLURUNKABUL.Count(x=>x.DURUMDETAY=="Mesaj Bekliyor").ToString();
            labelControl11.Text=db.TBLURUNKABUL.Count(x=>x.DURUMDETAY=="Mesaj Bekliyor").ToString();

            chartControl1.Series[0].LegendTextPattern = "{A}: {V:F1}";

            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-LT3581K;Initial Catalog=DbTeknikServis;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select DURUMDETAY,count(*) from TBLURUNKABUL GROUP BY DURUMDETAY ", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            baglanti.Close();



        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmArizaDetaylar fr = new FrmArizaDetaylar();
            fr.id=gridView1.GetFocusedRowCellValue("ISLEMID").ToString();
            fr.serino=gridView1.GetFocusedRowCellValue("URUNSERINO").ToString();
            fr.Show();
        }
    }
}
