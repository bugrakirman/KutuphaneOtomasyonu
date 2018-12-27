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
    public partial class frmYazarKayit : Form
    {
        public frmYazarKayit()
        {
            InitializeComponent();
        }

        private KitapKategorileri KitapKategorisi;
        private void frmYazarKayit_Load(object sender, EventArgs e)
        {
            cmbYazarKategori.DataSource = Enum.GetNames(typeof(KitapKategorileri));
        }

        private void btnYazarKaydet_Click(object sender, EventArgs e)
        {
            if (txtYazarAd.Text == null || txtYazarSoyad.Text == null) return;
            lstYazarlar.Items.Clear();
            Form1.Context.Kitaplar.Add(new Kitap()
            {
                YazarAd = txtYazarAd.Text,
                YazarSoyad = txtYazarSoyad.Text,


            });
            lstYazarlar.Items.AddRange(Form1.Context.Kitaplar.ToArray());
            ClearHelper.Temizle(this);
        }

        private void lstYazarlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstYazarlar.SelectedItem == null) return;
            Yazar seciliYazar = lstYazarlar.SelectedItem as Yazar;
            txtYazarAd.Text = seciliYazar.Ad;
            txtYazarSoyad.Text = seciliYazar.Soyad;
        }
    }
}
