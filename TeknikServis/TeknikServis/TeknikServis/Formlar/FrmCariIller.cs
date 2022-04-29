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
    public partial class FrmCariIller : Form
    {
        public FrmCariIller()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LT3581K;Initial Catalog=DbTeknikServis;Integrated Security=True");
        private void FrmCariIller_Load(object sender, EventArgs e)
        {
            //chartControl1.Series["Series 1"].Points.AddPoint("Ankara", 22);
            //chartControl1.Series["Series 1"].Points.AddPoint("İstanbul", 12);
            //chartControl1.Series["Series 1"].Points.AddPoint("İzmir", 8);
            //chartControl1.Series["Series 1"].Points.AddPoint("Bursa", 14);

            chartControl1.Series[0].LegendTextPattern = "{A}: {V:F1}";
            gridControl1.DataSource = db.TBLCARI.OrderBy(x => x.IL).
                GroupBy(y => y.IL).Select(z => new {İL=z.Key,TOPLAM=z.Count()}).ToList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select IL,Count(*) From TBLCARI group by IL",con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));

            }
            con.Close();
        }
    }
}
