using Kutuphane.Lib.Data;
using Kutuphane.Lib.Helpers;
using Kutuphane.Lib.ViewModals;
using KutuphaneOtomasyonu.Business;
using KutuphaneOtomasyonu.Entities;
using KutuphaneOtomasyonu.ViewModals;
using System;
using System.Data;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class frmKitapKiralama : Form
    {
        public frmKitapKiralama()
        {
            InitializeComponent();
        }

        private void frmKitapKiralama_Load(object sender, EventArgs e)
        {
            gbKirala.Visible = false;
            gbİade.Visible = false;
            Context db = new Context();
            cmbKiralaKitapAdi.DataSource = db.Kitaplar.Select(x => new KitapViewModel
            {
                KitapId = x.KitapId,
                KitapAdi = x.KitapAdi
            })
            .ToList();
            cmbKiralaUyeAdi.DataSource = db.Uyeler.Select(x => new UyeViewModel
            {
                UyeId = x.UyeId,
                UyeAdi = x.UyeAdi,
                UyeSoyadi = x.UyeSoyadi
            })
            .ToList();
            cmbİadeUyeAdi.DataSource = db.Kayitlar
                .Where(x => x.KitapKiradaMi == true)
                .Select(x => new UyeViewModel
                {
                    UyeId = x.UyeId,
                    UyeAdi = x.UyeAdi,
                    UyeSoyadi = x.UyeSoyadi
                })
                .ToList();
            cmbİadeKitapAdi.DataSource = db.Kayitlar
                .Where(x => x.KitapKiradaMi == true)
                .Select(x => new KitapViewModel
                {
                    KitapId = x.KitapId,
                    KitapAdi = x.KitapAdi
                })
            .ToList();

        }

        private void btnKirala_Click(object sender, EventArgs e)
        {
            gbKirala.Visible = true;
            gbİade.Visible = false;
        }

        private void btnİade_Click(object sender, EventArgs e)
        {
            gbKirala.Visible = false;
            gbİade.Visible = true;
        }

        private void btnKitapKirala_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbKiralaKitapAdi.Text == null || cmbKiralaUyeAdi == null) return;
                Kayit kyt = new Kayit();
                if (kyt.KitapKiradaMi == false)
                {
                    Context db = new Context();

                    db.Kayitlar.Add(new Kayit()
                    {
                        KitapId = (cmbKiralaKitapAdi.SelectedItem as KitapViewModel).KitapId,
                        UyeId = (cmbKiralaUyeAdi.SelectedItem as UyeViewModel).UyeId,
                        KitapAdi = (cmbKiralaKitapAdi.SelectedItem as KitapViewModel).KitapAdi,
                        UyeAdi = (cmbKiralaUyeAdi.SelectedItem as UyeViewModel).UyeAdi,
                        UyeSoyadi = (cmbKiralaUyeAdi.SelectedItem as UyeViewModel).UyeSoyadi,
                        KiralanmaZamani = dtpKirala.Value,
                        KitapKiradaMi = true
                    });

                    int sonuc = db.SaveChanges();
                    MessageBox.Show($"{sonuc} kayit eklendi");
                }
                else
                {
                    MessageBox.Show("Kitap şu an başka biri tarafından kiralanmış durumda");
                }

            }
            catch (DbEntityValidationException ex)
            {
                MessageBox.Show(EntityHelper.ValidationMessage(ex), "Bir hata olustu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void KategorileriGetir()
        {
            throw new NotImplementedException();
        }

        private void btnKitapİade_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbİadeKitapAdi.Text == null || cmbİadeUyeAdi == null) return;

                Context db = new Context();
                var kitapId = (cmbİadeKitapAdi.SelectedItem as KitapViewModel).KitapId;
                var uyeId = (cmbİadeUyeAdi.SelectedItem as UyeViewModel).UyeId;
                var guncelle = db.Kayitlar
                    .Where(x => x.KitapId == kitapId && x.UyeId == uyeId )
                    .FirstOrDefault();

                TimeSpan ts = (DateTime.Now - guncelle.KiralanmaZamani);
                    if (ts.TotalDays <= 7)
                        if (guncelle.KitapKiradaMi == true)
                        {
                            guncelle.KitapKiradaMi = false;
                            int sonuc = db.SaveChanges();
                            MessageBox.Show($"{sonuc} kayit eklendi");
                        }
                        else
                        {
                            MessageBox.Show("Kitap şu an kiralanmış durumda değil");
                        }
                    else
                    {
                    ////////////////// generic yapmak gerekebilir ya da ceza business methodu değiştirilecek değeri döndürmüyor !
                    KiralamaBusiness kb = new KiralamaBusiness();
                    kb.CezaHesapla(ts.TotalDays);
                    guncelle.KitapKiradaMi = false;
                    int sonuc = db.SaveChanges();
                    MessageBox.Show($"{sonuc} kayit eklendi");
                }
            }
            catch (DbEntityValidationException ex)
            {
                MessageBox.Show(EntityHelper.ValidationMessage(ex), "Bir hata olustu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
