using Kutuphane.Lib.Entities;
using Kutuphane.Lib.Helpers;
using Kutuphane.Lib.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class frmKitapKayit : Form
    {
        public frmKitapKayit()
        {
            InitializeComponent();
        }
        
        private KitapKategorileri KitapKategorisi;
        private void btnKitapKaydet_Click(object sender, EventArgs e)
        {
            
            if (txtKitapAd.Text == null || txtYazarAd.Text == null || txtYazarSoyad.Text == null) return;
            lstKitaplar.Items.Clear();
            Form1.Context.Kitaplar.Add(new Kitap() {
                KitapAdi = txtKitapAd.Text,
                YazarAdi = txtYazarAd.Text,
                YazarSoyadi = txtYazarSoyad.Text,
                
            
        });
            lstKitaplar.Items.AddRange(Form1.Context.Kitaplar.ToArray());
            ClearHelper.Temizle(this);
        }
       

        private void lstKitaplar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKitaplar.SelectedItem == null) return;
            Kitap seciliKitap = lstKitaplar.SelectedItem as Kitap;
            txtKitapAd.Text = seciliKitap.KitapAdi;
            txtYazarAd.Text = seciliKitap.YazarAdi;
            txtYazarSoyad.Text = seciliKitap.YazarSoyadi;
        }

        private void frmKitapKayit_Load(object sender, EventArgs e)
        {
            cmbKitapKategori.DataSource = Enum.GetNames(typeof(KitapKategorileri));
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            lstKitaplar.DataSource = SearchHelper.Ara<Kitap>(Form1.Context.Kitaplar.ToList(), txtAra.Text);//added tolist()
        }
    }
}
