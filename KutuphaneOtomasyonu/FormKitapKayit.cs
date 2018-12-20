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
            lstKitaplar.Items.Clear();
            Form1.Context.Kitaplar.Add(new Kutuphane.Lib.Models.Kitap() {
                KitapAd = txtKitapAd.Text,
                YazarAd = txtYazarAd.Text,
                YazarSoyad = txtYazarSoyad.Text
            });
            lstKitaplar.Items.Add(Form1.Context.Kitaplar);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbKitapKategori.DataSource = Enum.GetNames(typeof(KitapKategorileri));
        }
    }
}
