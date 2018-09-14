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
    public partial class frmBankaIslem : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();

        bool Edit = false;
        int IslemID = -1;
        int BankaID = -1;


        public frmBankaIslem()
        {
            InitializeComponent();
        }

        private void frmBankaIslem_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }
        public void Ac(int ID)
        {
            try
            {
                Edit = true;
                IslemID = ID;
                Fonksiyonlar.TBL_BANKAHAREKETLERI Hareket = DB.TBL_BANKAHAREKETLERIs.First(s => s.ID == IslemID);
                BankaAc(Hareket.BANKAID.Value);
                txtAciklama.Text = Hareket.ACIKLAMA;
                txtBelgeNo.Text = Hareket.BELGENO;
                txtTarih.Text = Hareket.TARIH.Value.ToShortDateString();
                txtTutar.Text = Hareket.TUTAR.ToString();
                if (Hareket.GCKODU == "G") rbtnGiris.Checked = true;
                if (Hareket.GCKODU == "C") rbtnCikis.Checked = true;

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

        void Temizle()
        {
            txtAciklama.Text = "";
            txtBelgeNo.Text = "";
            txtHesapAdi.Text = "";
            txtHesapNo.Text = "";
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtTutar.Text = "";
            Edit = false;
            IslemID = -1;
            BankaID = -1;
            AnaForm.Aktar = -1;
        }

        void YeniKayit()
        {
            try
            {
                Fonksiyonlar.TBL_BANKAHAREKETLERI Hareket = new Fonksiyonlar.TBL_BANKAHAREKETLERI();
                Hareket.ACIKLAMA = txtAciklama.Text;
                Hareket.BANKAID = BankaID;
                Hareket.BELGENO = txtBelgeNo.Text;
                Hareket.EVRAKTURU = "Banka İşlem";
                if (rbtnGiris.Checked) Hareket.GCKODU = "G";
                if (rbtnCikis.Checked) Hareket.GCKODU = "C";

                Hareket.TARIH = DateTime.Parse(txtTarih.Text);
                Hareket.TUTAR = Decimal.Parse(txtTutar.Text);
                Hareket.SAVEDATE = DateTime.Now;
                Hareket.SAVEUSER = AnaForm.UserID;
                DB.TBL_BANKAHAREKETLERIs.InsertOnSubmit(Hareket);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Banka İşlemi Kaydı Yapılmıştır.");
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
                Fonksiyonlar.TBL_BANKAHAREKETLERI Hareket = DB.TBL_BANKAHAREKETLERIs.First(s => s.ID == IslemID);
                Hareket.ACIKLAMA = txtAciklama.Text;
                Hareket.BANKAID = BankaID;
                Hareket.BELGENO = txtBelgeNo.Text;
                Hareket.EVRAKTURU = "Banka İşlem";
                if (rbtnGiris.Checked) Hareket.GCKODU = "G";
                if (rbtnCikis.Checked) Hareket.GCKODU = "C";

                Hareket.TARIH = DateTime.Parse(txtTarih.Text);
                Hareket.TUTAR = Decimal.Parse(txtTutar.Text);
                Hareket.EDITDATE = DateTime.Now;
                Hareket.EDITUSER = AnaForm.UserID;             
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

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && IslemID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKayit();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (Edit && IslemID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
          
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}