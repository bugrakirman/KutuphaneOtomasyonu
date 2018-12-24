using Kutuphane.Lib.Helpers;
using Kutuphane.Lib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                KitapAd = txtKitapAd.Text,
                YazarAd = txtYazarAd.Text,
                YazarSoyad = txtYazarSoyad.Text,
                
            
        });
            lstKitaplar.Items.AddRange(Form1.Context.Kitaplar.ToArray());
            ClearHelper.Temizle(this);
        }
       

        private void lstKitaplar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKitaplar.SelectedItem == null) return;
            Kitap seciliKitap = lstKitaplar.SelectedItem as Kitap;
            txtKitapAd.Text = seciliKitap.KitapAd;
            txtYazarAd.Text = seciliKitap.YazarAd;
            txtYazarSoyad.Text = seciliKitap.YazarSoyad;
        }

        private void frmKitapKayit_Load(object sender, EventArgs e)
        {
            cmbKitapKategori.DataSource = Enum.GetNames(typeof(KitapKategorileri));
        }
    }
}
