﻿using Kutuphane.Lib.Data;
using Kutuphane.Lib.Entities;
using Kutuphane.Lib.Helpers;
using System;
using System.Linq;
using System.Windows.Forms;
using Kutuphane.Lib.ViewModals;
using System.Data.Entity.Validation;
using KutuphaneOtomasyonu.ViewModals;
using KutuphaneOtomasyonu.Business;
using KutuphaneOtomasyonu.Entities;

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
                if (txtKitapAd.Text == null ) return;
                //ep1.Clear();
                Context db = new Context();
                KitapBusiness kb = new KitapBusiness();

                db.Kitaplar.Add(new Kitap()
                {
                    YazarId = (cmbKitapYazarlar.SelectedItem as YazarViewModel).YazarId,
                    KitapAdi = string.IsNullOrEmpty(txtKitapAd.Text) ? null : txtKitapAd.Text, //boş kaydetmesin diye
                    YazarAdi = (cmbKitapYazarlar.SelectedItem as YazarViewModel).YazarAdi,
                    YazarSoyadi = (cmbKitapYazarlar.SelectedItem as YazarViewModel).YazarSoyadi,
                    Kategori = (KitapKategorileri)Enum.Parse(typeof(KitapKategorileri), cmbKitapKategori.SelectedItem.ToString())
                     
                });
                Yazar yzr = new Yazar() {
                    YazarAdi = (cmbKitapYazarlar.SelectedItem as YazarViewModel).YazarAdi,
                    YazarSoyadi = (cmbKitapYazarlar.SelectedItem as YazarViewModel).YazarSoyadi
                };
                Kitap ktp = new Kitap() {
                     KitapAdi = string.IsNullOrEmpty(txtKitapAd.Text) ? null : txtKitapAd.Text
                };
                int sonuc = db.SaveChanges();
                MessageBox.Show($"{sonuc} kayit eklendi");
                KategorileriGetir();
                kb.KitapEkle(yzr,ktp);
              
            }
            catch (DbEntityValidationException ex)
            {
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
            Context db = new Context();
            cmbKitapKategori.DataSource = Enum.GetNames(typeof(KitapKategorileri));
            cmbKitapYazarlar.DataSource = db.Yazarlar.Select(x=> new YazarViewModel {
                YazarAdi=x.YazarAdi,
                 YazarSoyadi=x.YazarSoyadi,
                  Kategori=x.Kategori,
                   YazarId=x.YazarId
                   
            })
            .ToList();
            KategorileriGetir();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            lstKitaplar.DataSource = SearchHelper.Ara<Kitap>(Form1.Context.Kitaplar.ToList(), txtAra.Text);//added tolist()
        }
    }
}
