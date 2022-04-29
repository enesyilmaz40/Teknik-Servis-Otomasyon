using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace TeknikServis.Formlar
{
    public partial class FrmMarkalar : Form
    {
        public FrmMarkalar()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmMarkalar_Load(object sender, EventArgs e)
        {
            var degerler = db.TBLURUN.OrderBy(x => x.MARKA).GroupBy(y => y.MARKA).Select(z => new
            {
                Marka = z.Key,
                Toplam = z.Count()
            });
            gridControl1.DataSource = degerler.ToList();
            labelControl2.Text = db.TBLURUN.Count().ToString();
            labelControl3.Text = (from u in db.TBLURUN
                                  select u.MARKA).Distinct().Count().ToString();
            labelControl5.Text = db.maksurunmarka().FirstOrDefault();
            labelControl7.Text = (from u in db.TBLURUN
                                  orderby u.SATISFIYAT descending
                                  select u.MARKA).FirstOrDefault();
            //chartControl1.Series["Series 1"].Points.AddPoint("Siemens", 4);
            //chartControl1.Series["Series 1"].Points.AddPoint("Arçelik", 6);
            //chartControl1.Series["Series 1"].Points.AddPoint("Beko", 2);
            //chartControl1.Series["Series 1"].Points.AddPoint("Toshiba", 1);
            //chartControl1.Series["Series 1"].Points.AddPoint("Lenovo", 1);

            chartControl1.Series[0].LegendTextPattern = "{A}: {V:F1}";

            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-LT3581K;Initial Catalog=DbTeknikServis;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select MARKA,count(*)from TBLURUN GROUP BY MARKA ", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            baglanti.Close();


            //2.chart
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select TBLKATEGORI.AD,COUNT(*) FROM TBLURUNINNER JOIN TBLKATEGORI ON TBLKATEGORI.ID = TBLURUN.KATEGORI GROUP BY TBLKATEGORI.AD", baglanti);
            SqlDataReader dr2 = komut.ExecuteReader();
            while (dr2.Read())
            {
                chartControl2.Series["Kategoriler"].Points.AddPoint(Convert.ToString(dr2[0]), int.Parse(dr2[1].ToString()));
            }
            baglanti.Close();




        }
    }
}
