﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.İletişim
{
    public partial class FrmGelenMesajlar : Form
    {
        public FrmGelenMesajlar()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmGelenMesajlar_Load(object sender, EventArgs e)
        {
            labelControl12.Text=db.TBLILETISIM.Count().ToString();
            labelControl14.Text=db.TBLILETISIM.Where(x=>x.KONU=="Teşekkür").Count().ToString();
            labelControl16.Text=db.TBLILETISIM.Where(x=>x.KONU=="Rica").Count().ToString();
            labelControl18.Text=db.TBLILETISIM.Where(x=>x.KONU=="Şikayet").Count().ToString();

            gridControl1.DataSource=(from x in db.TBLILETISIM
                                    select new
                                    {
                                        x.ID,
                                        x.ADSOYAD,
                                        x.KONU,
                                        x.MAIL,x.MESAJ
                                    }).ToList();
            labelControl1.Text=db.TBLPERSONEL.Count().ToString();
            labelControl3.Text=db.TBLCARI.Count().ToString();
            labelControl5.Text=db.TBLKATEGORI.Count().ToString();
            labelControl7.Text=db.TBLURUN.Count().ToString();
        }
    }
}
