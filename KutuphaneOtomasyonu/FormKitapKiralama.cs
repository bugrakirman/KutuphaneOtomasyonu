using Kutuphane.Lib.Data;
using Kutuphane.Lib.Helpers;
using Kutuphane.Lib.ViewModals;
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
                KitapAdi = x.KitapAdi
            })
            .ToList();
            cmbKiralaUyeAdi.DataSource = db.Uyeler.Select(x => new UyeViewModel
            {
                UyeAdi = x.UyeAdi,
                UyeSoyadi = x.UyeSoyadi
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
                        KitapId = (cmbKiralaKitapAdi.SelectedItem as KayitViewModel).KitapId,
                        UyeId = (cmbKiralaUyeAdi.SelectedItem as KayitViewModel).UyeId,
                        KitapAdi = (cmbKiralaKitapAdi.SelectedItem as KayitViewModel).KitapAdi,
                        UyeAdi = (cmbKiralaUyeAdi.SelectedItem as KayitViewModel).UyeAdi,
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
    }
}
