using Kutuphane.Lib.Data;
using Kutuphane.Lib.Entities;
using Kutuphane.Lib.Helpers;
using Kutuphane.Lib.Models;
using System;
using System.Linq;
using System.Windows.Forms;
using Kutuphane.Lib.ViewModals;
using System.Data.Entity.Validation;

namespace KutuphaneOtomasyonu
{
    public partial class frmKitapKayit : Form
    {
        public frmKitapKayit()
        {
            InitializeComponent();
        }
        
        private KitapKategorileri KitapKategorisi;
        private object ep1;


        private void KategorileriGetir()
        {
            Context db = new Context();
            var kitaplar = db.Kitaplar
                .OrderBy(x => x.KitapAdi)
                .Select(x => new KitapViewModel()
                {
                    KitapAdi = x.KitapAdi,
                    YazarAdi = x.YazarAdi,
                    YazarSoyadi = x.YazarSoyadi,
                    Kategori = x.Kategori
                })
                .ToList();
           
            lstKitaplar.DataSource = kitaplar;
            

            //cmbKategori.DisplayMember = "CategoryName";
            //cmbKategori.ValueMember = "CategoryID";    tostringi ezince gerek kalmadı
        }
        private void btnKitapKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtKitapAd.Text == null || txtYazarAd.Text == null || txtYazarSoyad.Text == null) return;
                //ep1.Clear();
                Context db = new Context();
                db.Kitaplar.Add(new Kitap()
                {
                    KitapAdi = string.IsNullOrEmpty(txtKitapAd.Text) ? null : txtKitapAd.Text, //boş kaydetmesin diye
                    YazarId = 1,
                    YazarAdi = txtYazarAd.Text,
                    YazarSoyadi = txtYazarSoyad.Text,
                    Kategori = (KitapKategorileri)Enum.Parse(typeof(KitapKategorileri),cmbKitapKategori.SelectedItem.ToString())
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
            //    if (txtKitapAd.Text == null || txtYazarAd.Text == null || txtYazarSoyad.Text == null) return;
            //    lstKitaplar.Items.Clear();
            //    Form1.Context.Kitaplar.Add(new Kitap() {
            //        KitapAdi = txtKitapAd.Text,
            //        YazarAdi = txtYazarAd.Text,
            //        YazarSoyadi = txtYazarSoyad.Text,


            //});
            //    lstKitaplar.Items.AddRange(Form1.Context.Kitaplar.ToArray());
            //    ClearHelper.Temizle(this);
        }
       

        //private void lstKitaplar_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (lstKitaplar.SelectedItem == null) return;
        //    Kitap seciliKitap = lstKitaplar.SelectedItem as Kitap;
        //    txtKitapAd.Text = seciliKitap.KitapAdi;
        //    txtYazarAd.Text = seciliKitap.YazarAdi;
        //    txtYazarSoyad.Text = seciliKitap.YazarSoyadi;
        //}

        private void frmKitapKayit_Load(object sender, EventArgs e)
        {
            cmbKitapKategori.DataSource = Enum.GetNames(typeof(KitapKategorileri));
            KategorileriGetir();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            lstKitaplar.DataSource = SearchHelper.Ara<Kitap>(Form1.Context.Kitaplar.ToList(), txtAra.Text);//added tolist()
        }
    }
}
