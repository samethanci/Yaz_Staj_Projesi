using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Otomasyon.Modul_Kullanici
{
    public partial class frmKullaniciPanel : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        bool Ac = false;
        int KullaniciID = -1;


        public frmKullaniciPanel(int ID , bool Acc)
        {
            InitializeComponent();
            Ac = Acc;
            KullaniciID = ID;
            if (Ac)
            {
                KullaniciGetir(ID);
                txtKullaniciAdi.Enabled = false; 
            } 
        }
        void Temizle()
        {
            txtIsim.Text = "";
            txtKullaniciKodu.SelectedIndex = 1;
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
            txtSifreTekrar.Text = "";
            txtSoyisim.Text = "";
            KullaniciID = -1;
            Ac = false;
            rbtnAktif.Checked = false;
            rbtnPasif.Checked = true;

        }

        void KullaniciGetir(int ID)
        {
            KullaniciID = ID;
            try
            {
                Fonksiyonlar.TBL_KULLANICILAR Kullanici = DB.TBL_KULLANICILARs.First(s => s.ID == KullaniciID);
                txtIsim.Text = Kullanici.ISIM;
                txtKullaniciAdi.Text = Kullanici.KULLANICI;
                txtSoyisim.Text = Kullanici.SOYISIM;
                txtSifre.Text = Kullanici.SIFRE;
                txtSifreTekrar.Text = Kullanici.SIFRE;
                if (Kullanici.KODU == "Normal") txtKullaniciKodu.SelectedIndex = 1;
                if (Kullanici.KODU == "Yonetici") txtKullaniciKodu.SelectedIndex = 0;
                if (Kullanici.AKTIF.Value) rbtnAktif.Checked = true;
                if (!Kullanici.AKTIF.Value) rbtnPasif.Checked = true;
            }
            catch (Exception ex)
            {
                Mesajlar.Hata(ex);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            if (txtSifre.Text.Trim() == txtSifreTekrar.Text.Trim())
            {
                if (txtIsim.Text == "")
                {
                    MessageBox.Show("İsim Girilmesi Zorunludur.");
                    return;
                }
                else if (txtSoyisim.Text == "")
                {
                    MessageBox.Show("Soyisim Girilmesi Zorunludur.");
                    return;
                }
                else if (txtKullaniciAdi.Text == "")
                {
                    MessageBox.Show("Kullanıcı Adı Girilmesi Zorunludur.");
                    return;
                }
                else if (txtSifre.Text == "")
                {
                    MessageBox.Show("Şifre Girilmesi Zorunludur.");
                    return;
                }
                DialogResult DR = MessageBox.Show(txtKullaniciKodu.Text + " türünde bir kullanıcı açmak üzeresiniz.", "Kullanıcı Kaydı Tamamlama", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DR == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        if (!Ac)
                        {
                            if (DB.TBL_KULLANICILARs.Where(s => s.KULLANICI == txtKullaniciAdi.Text).Count() > 0)
                            {
                                MessageBox.Show("Böyle bir kullanıcı zaten var.Lütfen farklı bir ad giriniz.");
                                return;
                            } 
                        }
                        Fonksiyonlar.TBL_KULLANICILAR Kullanici;
                        if (!Ac) Kullanici = new Fonksiyonlar.TBL_KULLANICILAR();
                        else Kullanici = DB.TBL_KULLANICILARs.First(s => s.ID == KullaniciID);
                        if (rbtnAktif.Checked) Kullanici.AKTIF = true;
                        if (rbtnPasif.Checked) Kullanici.AKTIF = true;
                        Kullanici.ISIM = txtIsim.Text;
                        Kullanici.SOYISIM = txtSoyisim.Text;
                        Kullanici.KULLANICI = txtKullaniciAdi.Text;
                        Kullanici.KODU = txtKullaniciKodu.Text;
                        if (Ac) Kullanici.EDITDATE = DateTime.Now;
                        else Kullanici.SAVEDATE = DateTime.Now;
                        Kullanici.SIFRE = txtSifre.Text;
                        if (!Ac) DB.TBL_KULLANICILARs.InsertOnSubmit(Kullanici);
                        DB.SubmitChanges();
                        if (Ac) Mesajlar.Guncelle(true);
                        else Mesajlar.YeniKayit(txtKullaniciAdi.Text + " kullanıcı kaydı açılmıştır.");
                        Temizle();
                    }
                    catch (Exception ex)
                    {
                        Mesajlar.Hata(ex);
                    }
                }

            }
            else MessageBox.Show("Şifreler Aynı değil!");

        }

        private void frmKullaniciPanel_Load(object sender, EventArgs e)
        {

        }
    }
}