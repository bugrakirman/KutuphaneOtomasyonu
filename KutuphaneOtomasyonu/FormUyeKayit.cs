using Kutuphane.Lib.Data;
using Kutuphane.Lib.Helpers;
using KutuphaneOtomasyonu.Entities;
using KutuphaneOtomasyonu.ViewModals;
using System;
using System.Data;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class frmUyeKayit : Form
    {
        public frmUyeKayit()
        {
            InitializeComponent();
        }

        private void FormUyeKayit_Load(object sender, EventArgs e)
        {
            KategorileriGetir();
        }

        private void KategorileriGetir()
        {
            Context db = new Context();
            lstUyeler.DataSource = db.Uyeler
                .OrderBy(x => x.UyeAdi)
                .Select(x => new UyeViewModel()
                {
                    UyeAdi = x.UyeAdi,
                    UyeSoyadi =x.UyeSoyadi
                    
                })
                .ToList();
        }

        private void btnUyeKaydet_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtUyeAd.Text == null || txtUyeSoyad.Text == null) return;
                Context db = new Context();
                db.Uyeler.Add(new Uye()
                {
                    UyeAdi = txtUyeAd.Text,
                    UyeSoyadi = txtUyeSoyad.Text

                });
                int sonuc = db.SaveChanges();
                MessageBox.Show($"{sonuc} kayit eklendi");
                KategorileriGetir();
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
