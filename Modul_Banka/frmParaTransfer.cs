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

namespace Otomasyon.Modul_Banka
{
    public partial class frmParaTransfer : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();

        bool Edit = false;
        int CariID = -1;
        int BankaID = -1;
        int IslemID = -1;

        public frmParaTransfer()
        {
            InitializeComponent();
        }   

        private void frmBankaListesi_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }


        private void txtTrasferTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtTrasferTuru.SelectedIndex == 0)
            {
                rbtnGelen.Text = "Gelen Havale";
                rbtnGiden.Text = "Giden Havale";
            }
            else
            {
                rbtnGelen.Text = "Gelen EFT";
                rbtnGiden.Text = "Giden EFT";
            }

        }

        void Temizle()
        {
            txtAciklama.Text = "";
            txtBelgeNo.Text = "";
            txtCariAdi.Text = "";
            txtCariKodu.Text = "";
            txtHesapAdi.Text = "";
            txtHesapNo.Text = "";
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtTutar.Text = "0";
            Edit = false;
            CariID = -1;
            BankaID = -1;
            IslemID = -1;
            AnaForm.Aktar = -1;
        }

        public void Ac(int ID)
        {
            try
            {
                Edit = true;
                IslemID = ID;
                Fonksiyonlar.TBL_BANKAHAREKETLERI Banka = DB.TBL_BANKAHAREKETLERIs.First(s => s.ID == IslemID);
                BankaAc(Banka.BANKAID.Value);
                CariAc(Banka.CARIID.Value);
                txtAciklama.Text = Banka.ACIKLAMA;
                txtBelgeNo.Text = Banka.BELGENO;
                txtTarih.Text = Banka.TARIH.Value.ToShortDateString();
                txtTrasferTuru.Text = Banka.EVRAKTURU;
                txtTutar.Text = Banka.TUTAR.ToString();

                if (Banka.GCKODU == "G") rbtnGelen.Checked = true;
                if (Banka.GCKODU == "C") rbtnGiden.Checked = true;
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }

        void BankaAc(int ID)
        {
            try
            {
                BankaID = ID;
               txtHesapAdi.Text = DB.TBL_BANKALARs.First(s => s.ID == BankaID).HESAPADI;
               txtHesapNo.Text = DB.TBL_BANKALARs.First(s => s.ID == BankaID).HESAPNO;
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

         void CariAc(int ID)
        {
            try
            {
                CariID = ID;
                txtCariKodu.Text = DB.TBL_CARILERs.First(s => s.ID == CariID).CARIKOD;
                txtCariAdi.Text = DB.TBL_CARILERs.First(s => s.ID == CariID).CARIADI;

            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_BANKAHAREKETLERI Banka = new Fonksiyonlar.TBL_BANKAHAREKETLERI();
                Banka.ACIKLAMA = txtAciklama.Text;
                Banka.BANKAID = BankaID;
                Banka.BELGENO = txtBelgeNo.Text;
                Banka.CARIID = CariID;
                Banka.EVRAKTURU = txtTrasferTuru.SelectedItem.ToString();
                if (rbtnGelen.Checked) Banka.GCKODU = "G";
                if (rbtnGiden.Checked) Banka.GCKODU = "C";
                Banka.TARIH = DateTime.Parse(txtTarih.Text);
                Banka.TUTAR = decimal.Parse(txtTutar.Text);
                Banka.SAVEDATE = DateTime.Now;
                Banka.SAVEUSER = AnaForm.UserID;
                DB.TBL_BANKAHAREKETLERIs.InsertOnSubmit(Banka);
                DB.SubmitChanges();
                Fonksiyonlar.TBL_CARIHAREKETLERI Cari = new Fonksiyonlar.TBL_CARIHAREKETLERI();
                Cari.ACIKLAMA = txtAciklama.Text;
                if (rbtnGelen.Checked) Cari.ALACAK = decimal.Parse(txtTutar.Text);
                if (rbtnGiden.Checked) Cari.BORC = decimal.Parse(txtTutar.Text);
                Cari.CARIID = CariID;
                Cari.EVRAKID = Banka.ID;
                Cari.EVRAKTURU = txtTrasferTuru.SelectedItem.ToString();
                Cari.TARIH = DateTime.Parse(txtTarih.Text);
                if (txtTrasferTuru.SelectedIndex == 0) Cari.TIPI = "BH";
                if (txtTrasferTuru.SelectedIndex == 1) Cari.TIPI = "EFT";
                Cari.SAVEDATE = DateTime.Now;
                Cari.SAVEUSER = AnaForm.UserID;
                DB.TBL_CARIHAREKETLERIs.InsertOnSubmit(Cari);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Para Transfer Kaydı İşlenmiştir.");
                Temizle();

            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        void Guncelle()
        {
            try
            {

                Fonksiyonlar.TBL_BANKAHAREKETLERI Banka = DB.TBL_BANKAHAREKETLERIs.First(s => s.ID ==IslemID);
                Banka.ACIKLAMA = txtAciklama.Text;
                Banka.BANKAID = BankaID;
                Banka.BELGENO = txtBelgeNo.Text;
                Banka.CARIID = CariID;
                Banka.EVRAKTURU = txtTrasferTuru.SelectedItem.ToString();
                if (rbtnGelen.Checked) Banka.GCKODU = "G";
                if (rbtnGiden.Checked) Banka.GCKODU = "C";
                Banka.TARIH = DateTime.Parse(txtTarih.Text);
                Banka.TUTAR = decimal.Parse(txtTutar.Text);
                Banka.EDITDATE = DateTime.Now;
                Banka.EDITUSER = AnaForm.UserID;
            
                DB.SubmitChanges();
                Fonksiyonlar.TBL_CARIHAREKETLERI Cari = DB.TBL_CARIHAREKETLERIs.First(s => s.EVRAKTURU == txtTrasferTuru.SelectedItem.ToString() && s.EVRAKID == IslemID);
                Cari.ACIKLAMA = txtAciklama.Text;
                if (rbtnGelen.Checked) Cari.ALACAK = decimal.Parse(txtTutar.Text);
                if (rbtnGiden.Checked) Cari.BORC = decimal.Parse(txtTutar.Text);
                Cari.CARIID = CariID;
                Cari.EVRAKID = Banka.ID;
                Cari.EVRAKTURU = txtTrasferTuru.SelectedItem.ToString();
                Cari.TARIH = DateTime.Parse(txtTarih.Text);
                if (txtTrasferTuru.SelectedIndex == 0) Cari.TIPI = "BH";
                if (txtTrasferTuru.SelectedIndex == 1) Cari.TIPI = "EFT";
                Cari.EDITDATE = DateTime.Now;
                Cari.EDITUSER = AnaForm.UserID;
            
                DB.SubmitChanges();
                Mesajlar.Guncelle(true);
                Temizle();

            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        void Sil()

        {
            try
            {
                DB.TBL_CARIHAREKETLERIs.DeleteOnSubmit(DB.TBL_CARIHAREKETLERIs.First(s => s.EVRAKTURU == txtTrasferTuru.SelectedItem.ToString() && s.EVRAKID == IslemID));
                DB.TBL_BANKAHAREKETLERIs.DeleteOnSubmit(DB.TBL_BANKAHAREKETLERIs.First(s => s.ID == IslemID));
                DB.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        private void txtHesapAdi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = Formlar.BankaListesi(true);
            if (Id > 0) BankaAc(Id);
            AnaForm.Aktar = -1;
        }

        private void txtCariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = Formlar.CariListesi(true);
            if (Id > 0) CariAc(Id);
            AnaForm.Aktar = -1;

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && CariID > 0 && BankaID > 0 && IslemID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKaydet();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (Edit && CariID > 0 && BankaID > 0 && IslemID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}