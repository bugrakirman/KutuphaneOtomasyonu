using Kutuphane.Lib.Entities;
using Kutuphane.Lib.Helpers;
using Kutuphane.Lib.Data;
using System;
using System.Linq;
using System.Windows.Forms;
using Kutuphane.Lib.ViewModals;
using System.Data.Entity.Validation;
using KutuphaneOtomasyonu.Entities;

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
            KategorileriGetir();
        }

        private void KategorileriGetir()
        {
            Context db = new Context();
            var yazarlar = db.Yazarlar
                .OrderBy(x => x.YazarAdi)
                .Select(x => new YazarViewModel()
                {
                    YazarAdi = x.YazarAdi,
                    YazarSoyadi = x.YazarSoyadi,
                    Kategori = x.Kategori
                })
                .ToList();
            
            lstYazarlar.DataSource = yazarlar;


            //cmbKategori.DisplayMember = "CategoryName";
            //cmbKategori.ValueMember = "CategoryID";    tostringi ezince gerek kalmadı
        }
        private void btnYazarKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtYazarAd.Text == null || txtYazarSoyad.Text == null) return;
                //ep1.Clear();
                Context db = new Context();
                db.Yazarlar.Add(new Yazar()
                { 
                    
                    YazarAdi = txtYazarAd.Text,
                    YazarSoyadi = txtYazarSoyad.Text,
                    Kategori = (KitapKategorileri)Enum.Parse(typeof(KitapKategorileri), cmbYazarKategori.SelectedItem.ToString()),
                       
                     
                });
                int sonuc = db.SaveChanges();
                MessageBox.Show($"{sonuc} kayit eklendi");
                KategorileriGetir();
            }
            catch (DbEntityValidationException ex)
            {
                //foreach (var validationError in ex.EntityValidationErrors)
                //{
                //    foreach (var error in validationError.ValidationErrors)
                //    {
                //        if (error.PropertyName == "KitapAdi")
                //            //ep1.SetError(txtKitapAd, error.ErrorMessage);
                //    }
                //}
                MessageBox.Show(EntityHelper.ValidationMessage(ex), "Bir hata olustu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //if (txtYazarAd.Text == null || txtYazarSoyad.Text == null) return;
            //lstYazarlar.Items.Clear();
            //Form1.Context.Kitaplar.Add(new Kitap()
            //{
            //    YazarAdi = txtYazarAd.Text,
            //    YazarSoyadi = txtYazarSoyad.Text,


            //});
            //lstYazarlar.Items.AddRange(Form1.Context.Kitaplar.ToArray());
            //ClearHelper.Temizle(this);
        }

        //private void lstYazarlar_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (lstYazarlar.SelectedItem == null) return;
        //    Yazar seciliYazar = lstYazarlar.SelectedItem as Yazar;
        //    txtYazarAd.Text = seciliYazar.YazarAdi;
        //    txtYazarSoyad.Text = seciliYazar.YazarSoyadi;
        //}
    }
}
