﻿using System;
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
    public partial class Istatistik : Form
    {
        public Istatistik()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db =new DbTeknikServisEntities();

        private void Istatistik_Load(object sender, EventArgs e)
        {
            labelControl2.Text = db.TBLURUN.Count().ToString();
            labelControl3.Text = db.TBLKATEGORI.Count().ToString();
            labelControl5.Text= db.TBLURUN.Sum(x=>x.STOK).ToString();
            labelControl7.Text = "10";
            labelControl17.Text = (from x in db.TBLURUN
                                   orderby x.SATISFIYAT descending
                                   select x.AD).FirstOrDefault();
            labelControl19.Text = (from x in db.TBLURUN
                                   orderby x.SATISFIYAT ascending
                                   select x.AD).FirstOrDefault();
            labelControl11.Text=(from x in db.TBLURUN 
                                 orderby x.STOK descending 
                                 select x.AD).FirstOrDefault();
            labelControl13.Text = (from x in db.TBLURUN
                                   orderby x.STOK ascending
                                   select x.AD).FirstOrDefault();
            labelControl31.Text=db.TBLURUN.Count(x=>x.KATEGORI==4).ToString();
            labelControl35.Text=db.TBLURUN.Count(x=>x.KATEGORI==1).ToString();
            labelControl39.Text=db.TBLURUN.Count(x=>x.KATEGORI==3).ToString();
            labelControl21.Text = (from x in db.TBLURUN 
                                   select x.MARKA).Distinct().Count().ToString();
            labelControl27.Text=db.TBLURUNKABUL.Count().ToString();
            labelControl15.Text = db.makskategoriurun().FirstOrDefault();

            /*
             * 5.Panel
             * 12. Panel
             * 13. Panel
             * 14. Panel
             * 15. Panel
             * 16. Panel
             * 17. Panel
             */
        }

    }
}
