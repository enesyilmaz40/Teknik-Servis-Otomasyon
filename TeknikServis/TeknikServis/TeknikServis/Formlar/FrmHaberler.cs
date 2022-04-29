using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace TeknikServis.Formlar
{
    public partial class FrmHaberler : Form
    {
        public FrmHaberler()
        {
            InitializeComponent();
        }

        private void FrmHaberler_Load(object sender, EventArgs e)
        {
        
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            List<Haber> Kayitlar = XmlCevir();
            lstBaslik.DataSource = Kayitlar;

        }
        private List<Haber> XmlCevir()
        {
            List<Haber> haberKayitlari = new List<Haber>();
            XDocument XMLKaynak = XDocument.Load(txtRssUrl.Text);
            XMLKaynak.Descendants("item");
            List<XElement> Rows = XMLKaynak.Descendants("item").ToList();
            foreach (XElement item in Rows)
            {
                Haber Temp = new Haber();
                Temp.Baslik = item.Element("title").Value;
                Temp.Aciklama = item.Element("description").Value;
                Temp.Link = item.Element("link").Value;
                haberKayitlari.Add(Temp);

            }
            return haberKayitlari;

        }

        private void lstBaslik_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox SecilenDeger = (ListBox)sender;
            Haber SecilenHaber = (Haber)SecilenDeger.SelectedItem;
            webBrowser1.DocumentText = SecilenHaber.Aciklama;
        }
    }
}
