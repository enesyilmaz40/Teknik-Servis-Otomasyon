using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Formlar.FrmUrunListe frmUrunListe;
        private void btnUrunListesiFormu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (frmUrunListe == null || frmUrunListe.IsDisposed)
            {
                frmUrunListe=new Formlar.FrmUrunListe();
                frmUrunListe.MdiParent = this;
                frmUrunListe.Show();
            }
        }
        Formlar.FrmYeniUrun frmYeniUrun;
        private void btnYeniÜrün_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmYeniUrun == null || frmYeniUrun.IsDisposed)
            {
                frmYeniUrun = new Formlar.FrmYeniUrun();
                frmYeniUrun.Show();
            }
          
        }

        Formlar.FrmKategori frmKategori;
        private void btnKategoriListe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
            if (frmKategori == null || frmKategori.IsDisposed)
            {
                frmKategori = new Formlar.FrmKategori();
                frmKategori.MdiParent = this;
                frmKategori.Show();
            }
        }
        Formlar.FrmYeniKategori frmYeniKategori;
        private void btnYeniKategori_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmYeniKategori == null || frmYeniKategori.IsDisposed)
            {
                frmYeniKategori = new Formlar.FrmYeniKategori();
                frmYeniKategori.Show();
            }
          

        }
        Formlar.Istatistik frmUrunIstatistik;
        private void btnUrunIstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmUrunIstatistik == null || frmUrunIstatistik.IsDisposed)
            {
                frmUrunIstatistik = new Formlar.Istatistik();
                frmUrunIstatistik.MdiParent = this;
                frmUrunIstatistik.Show();
            }
       
        }
        Formlar.FrmMarkalar frmMarkalar;
        private void btnMarkaIstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmMarkalar == null || frmMarkalar.IsDisposed)
            {
                frmMarkalar = new Formlar.FrmMarkalar();
                frmMarkalar.MdiParent = this;
                frmMarkalar.Show();
            }
         
        }
        Formlar.FrmCariListesi frmCariListesi;
        private void btnCari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmCariListesi == null || frmCariListesi.IsDisposed)
            {
                frmCariListesi = new Formlar.FrmCariListesi();
                frmCariListesi.MdiParent = this;
                frmCariListesi.Show();
            }

        }
        Formlar.FrmCariIller frmCariIller;
        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmCariIller == null || frmCariIller.IsDisposed)
            {
                frmCariIller = new Formlar.FrmCariIller();
                frmCariIller.MdiParent = this;
                frmCariIller.Show();
            }
         
        }
        Formlar.FrmCariEkle frmCariEkle;
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmCariEkle == null || frmCariEkle.IsDisposed)
            {
                frmCariEkle = new Formlar.FrmCariEkle();
                frmCariEkle.Show();
            }
          
        }
        Formlar.FrmDepartman frmDepartman;
        private void btnDepartmanListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        
            if (frmDepartman == null || frmDepartman.IsDisposed)
            {
                frmDepartman = new Formlar.FrmDepartman();
                frmDepartman.MdiParent = this;
                frmDepartman.Show();
            }
        }
        Formlar.FrmYeniDepartman frmYeniDepartman;
        private void btnYeniDepartman_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            if (frmYeniDepartman == null || frmYeniDepartman.IsDisposed)
            {
                frmYeniDepartman = new Formlar.FrmYeniDepartman();
                frmYeniDepartman.Show();
            }
        }
        Formlar.FrmPersonel frmPersonel;
        private void btnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmPersonel == null || frmPersonel.IsDisposed)
            {
                frmPersonel = new Formlar.FrmPersonel();
                frmPersonel.MdiParent = this;
                frmPersonel.Show();
            }
            
        }

        private void btnHesapMakinesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }
        Formlar.FrmKurlar frmKurlar;
        private void btnKurlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmKurlar == null || frmKurlar.IsDisposed)
            {
                frmKurlar = new Formlar.FrmKurlar();
                frmKurlar.MdiParent = this;
                frmKurlar.Show();
            }
       
        }
        Formlar.FrmHaberler frmHaberler;
        private void btnHaberler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
            if (frmHaberler == null || frmHaberler.IsDisposed)
            {
                frmHaberler = new Formlar.FrmHaberler();
                frmHaberler.MdiParent = this;
                frmHaberler.Show();
            }
        }

        private void btnWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }
        Formlar.FrmNotlar frmNotlar;
        private void btnNotListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmNotlar == null || frmNotlar.IsDisposed)
            {
                frmNotlar = new Formlar.FrmNotlar();
                frmNotlar.MdiParent = this;
                frmNotlar.Show();
            }
        }
        Formlar.FrmYeniNot frmYeniNot;
        private void btnYeniNot_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmYeniNot == null || frmYeniNot.IsDisposed)
            {
                frmYeniNot = new Formlar.FrmYeniNot();
                frmYeniNot.Show();
            }
         
        }
        Formlar.FrmArızaListesi frmArizaListesi;
        private void btnArizaliUrunListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmArizaListesi == null || frmArizaListesi.IsDisposed)
            {
                frmArizaListesi = new Formlar.FrmArızaListesi();
                frmArizaListesi.MdiParent = this;
                frmArizaListesi.Show();
            }
        }
        Formlar.FrmUrunSatis frmUrunSatis;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmUrunSatis == null || frmUrunSatis.IsDisposed)
            {
                frmUrunSatis = new Formlar.FrmUrunSatis();
                frmUrunSatis.Show();
            }
         
        }

        Formlar.FrmSatislar frmSatisListesi;
        private void btnSatisListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmSatisListesi == null || frmSatisListesi.IsDisposed)
            {
                frmSatisListesi = new Formlar.FrmSatislar();
                frmSatisListesi.MdiParent = this;
                frmSatisListesi.Show();
            }
      
        }
        Formlar.FrmArizaliUrunKaydi frmYeniArizaliUrunKaydi;
        private void btnYeniArizaliUrunKaydi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmYeniArizaliUrunKaydi == null || frmYeniArizaliUrunKaydi.IsDisposed)
            {
                frmYeniArizaliUrunKaydi = new Formlar.FrmArizaliUrunKaydi();
                frmYeniArizaliUrunKaydi.Show();
            }
        }
        Formlar.FrmArizaDetaylar frmArizaDetaylar;
        private void btnArizaUrunAciklama_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
       
            if (frmArizaDetaylar == null || frmArizaDetaylar.IsDisposed)
            {
                frmArizaDetaylar = new Formlar.FrmArizaDetaylar();
                frmArizaDetaylar.Show();
            }
        }
        Formlar.FrmArizaliUrunDetayListesi frmArizaliUrunDetayListesi;
        private void btnArizaUrunDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
         
            if (frmArizaliUrunDetayListesi == null || frmArizaliUrunDetayListesi.IsDisposed)
            {
                frmArizaliUrunDetayListesi = new Formlar.FrmArizaliUrunDetayListesi();
                frmArizaliUrunDetayListesi.MdiParent = this;
                frmArizaliUrunDetayListesi.Show();
            }
        }
        Formlar.FrmQRCode frmQRCode;
        private void btnQrCode_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmQRCode == null || frmQRCode.IsDisposed)
            {
                frmQRCode = new Formlar.FrmQRCode();
                frmQRCode.Show();
            }
        
        }
        Formlar.FrmFaturaListesi frmFaturaListesi;
        private void btnFaturaListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmFaturaListesi == null || frmFaturaListesi.IsDisposed)
            {
                frmFaturaListesi = new Formlar.FrmFaturaListesi();
                frmFaturaListesi.MdiParent = this;
                frmFaturaListesi.Show();
            }
           
        }
        Formlar.FrmFaturaKalem frmFaturaKalem;
        private void btnFaturaKalem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
       
            if (frmFaturaKalem == null || frmFaturaKalem.IsDisposed)
            {
                frmFaturaKalem = new Formlar.FrmFaturaKalem();
                frmFaturaKalem.MdiParent = this;
                frmFaturaKalem.Show();
            }
        }
        Formlar.FrmFaturaKalemleri frmFaturaKalemleri;
        private void btnFaturaKalemListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmFaturaKalemleri == null || frmFaturaKalemleri.IsDisposed)
            {
                frmFaturaKalemleri = new Formlar.FrmFaturaKalemleri();
                frmFaturaKalemleri.MdiParent = this;
                frmFaturaKalemleri.Show();
            }
          
        }
        Formlar.FrmGauge frmGauge;
        private void btnHakkimizda_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
         
            if (frmGauge == null || frmGauge.IsDisposed)
            {
                frmGauge = new Formlar.FrmGauge();
                frmGauge.MdiParent = this;
                frmGauge.Show();
            }
        }
        Formlar.FrmHarita frmHarita;
        private void btnHaritalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmHarita == null || frmHarita.IsDisposed)
            {
                frmHarita = new Formlar.FrmHarita();
                frmHarita.MdiParent = this;
                frmHarita.Show();
            }
        }
        Formlar.FrmRaporlar frmRaporlar;
        private void btnRaporSihirbazi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmRaporlar == null || frmRaporlar.IsDisposed)
            {
                frmRaporlar = new Formlar.FrmRaporlar();
                frmRaporlar.Show();
            }
        }

        Formlar.FrmAnaSayfa frmAnaSayfa;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (frmAnaSayfa == null || frmAnaSayfa.IsDisposed)
            {
                frmAnaSayfa = new Formlar.FrmAnaSayfa();
                frmAnaSayfa.MdiParent = this;
                frmAnaSayfa.Show();
            }

        }

        private void btnAnaForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmAnaSayfa == null || frmAnaSayfa.IsDisposed)
            {
                frmAnaSayfa = new Formlar.FrmAnaSayfa();
                frmAnaSayfa.MdiParent = this;
                frmAnaSayfa.Show();
            }

        }

        İletişim.FrmRehber frmRehber;
        private void barButtonItem35_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmRehber == null || frmRehber.IsDisposed)
            {
                frmRehber = new İletişim.FrmRehber();
                frmRehber.MdiParent = this;
                frmRehber.Show();
            }
        }
        İletişim.FrmGelenMesajlar frmGelenMesajlar;
        private void barButtonItem36_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmGelenMesajlar == null || frmGelenMesajlar.IsDisposed)
            {
                frmGelenMesajlar = new İletişim.FrmGelenMesajlar();
                frmGelenMesajlar.MdiParent = this;
                frmGelenMesajlar.Show();
            }
        }
        İletişim.FrmMail frmMail;
        private void barButtonItem37_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmMail == null || frmMail.IsDisposed)
            {
                frmMail = new İletişim.FrmMail();
                frmMail.Show();
            }
        }
    }
}
