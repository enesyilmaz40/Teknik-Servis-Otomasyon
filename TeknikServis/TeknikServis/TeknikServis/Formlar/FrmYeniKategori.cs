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
    public partial class FrmYeniKategori : Form
    {
        public FrmYeniKategori()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtKategoriAd.Text != "" && txtKategoriAd.Text.Length <= 30)
            {
                TBLKATEGORI t = new TBLKATEGORI();
                t.AD = txtKategoriAd.Text;
                db.TBLKATEGORI.Add(t);
                db.SaveChanges();
                MessageBox.Show("Kategori Başarıyla Kaydedildi");
            }
            else
            {
                MessageBox.Show("Kategori Adı Boş Geçilemez ve Kategori Adı 30 Karakterden Uzun Olamaz","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
           
        }

        private void pictureEdit2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
