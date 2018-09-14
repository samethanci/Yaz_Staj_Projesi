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

namespace Otomasyon.Modul_Cek
{
    public partial class frmKendiCekimiz : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();

        int CekID = -1;
        int BankaID = -1;
        bool Edit = false;

        public frmKendiCekimiz()
        {
            InitializeComponent();
        }

        private void frmKendiCekimiz_Load(object sender, EventArgs e)
        {
            txtVadeTarihi.Text = DateTime.Now.ToShortDateString();
        }

        void Temizle()
        {
            txtAciklama.Text = "";
            txtBanka.Text = "";
            txtBelgeNo.Text = "";
            txtCekNo.Text = "";
            txtHesapNo.Text = "";
            txtSube.Text = "";
            txtTutar.Text = "";
            txtVadeTarihi.Text = DateTime.Now.ToShortDateString();
            CekID = -1;
            BankaID = -1;
            Edit = false;
            AnaForm.Aktar = -1;
        }
        public void Ac(int CekinIDsi)
        {
            try
            {
                CekID = CekinIDsi;
                Fonksiyonlar.TBL_CEKLER Cek = DB.TBL_CEKLERs.First(s => s.ID == CekID);
                BankaAc(DB.TBL_BANKALARs.First(s => s.BANKAADI == Cek.BANKA && s.HESAPNO == Cek.HESAPNO).ID);
                txtAciklama.Text = Cek.ACIKLAMA;
                txtBelgeNo.Text = Cek.BELGENO;
                txtCekNo.Text = Cek.CEKNO;
                txtTutar.Text = Cek.TUTAR.Value.ToString();
                txtVadeTarihi.Text = Cek.VADETARIHI.Value.ToShortDateString();
                Edit = true;
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
                Temizle();
            }
        }
        void BankaAc(int BankaninIDsi)
        {
            try
            {
                BankaID = BankaninIDsi;
                Fonksiyonlar.TBL_BANKALAR Banka = DB.TBL_BANKALARs.First(s => s.ID == BankaID);
                txtBanka.Text = Banka.BANKAADI;
                txtHesapNo.Text = Banka.HESAPNO;
                txtSube.Text = Banka.SUBE;
                txtHesapNo.Text = Banka.HESAPNO;

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
                Fonksiyonlar.TBL_CEKLER Cek = new Fonksiyonlar.TBL_CEKLER();
                Cek.ACIKLAMA = txtAciklama.Text;
                Cek.ACKODU = "A";
                Cek.BANKA = txtBanka.Text;
                Cek.BELGENO = txtBelgeNo.Text;
                Cek.CEKNO = txtCekNo.Text;
                Cek.DURUMU = "Portföy";
                Cek.HESAPNO = txtHesapNo.Text;
                Cek.SUBE = txtSube.Text;
                Cek.TAHSIL = "Hayır";
                Cek.TARIH = DateTime.Now;
                Cek.TIPI = "Kendi Çekimiz";
                Cek.TUTAR = decimal.Parse(txtTutar.Text);
                Cek.VADETARIHI = DateTime.Parse(txtVadeTarihi.Text);
                Cek.SAVEUSER = AnaForm.UserID;
                Cek.SAVEDATE = DateTime.Now;
                DB.TBL_CEKLERs.InsertOnSubmit(Cek);
                DB.SubmitChanges();
                Mesajlar.YeniKayit(txtCekNo.Text + " numaralı kendi çekimizin çek kaydı yapılmıştır.");
                Fonksiyonlar.TBL_BANKAHAREKETLERI BankaHareketi = new Fonksiyonlar.TBL_BANKAHAREKETLERI();
                BankaHareketi.ACIKLAMA = txtCekNo.Text + " numaralı ve " + txtVadeTarihi.Text + " vadeli kendi çekimiz.";
                BankaHareketi.BANKAID = BankaID;
                BankaHareketi.BELGENO = txtBelgeNo.Text;
                BankaHareketi.EVRAKID = Cek.ID;
                BankaHareketi.EVRAKTURU = "Kendi Çekimiz";
                BankaHareketi.GCKODU = "C";
                BankaHareketi.TARIH = DateTime.Now;
                BankaHareketi.TUTAR = 0;
                BankaHareketi.SAVEDATE = DateTime.Now;
                BankaHareketi.SAVEUSER = AnaForm.UserID;
                DB.TBL_BANKAHAREKETLERIs.InsertOnSubmit(BankaHareketi);
                DB.SubmitChanges();
                Mesajlar.YeniKayit(txtCekNo.Text + " numaralı kendi çekimizin banka kaydı yapılmıştır.");
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
                Fonksiyonlar.TBL_CEKLER Cek = DB.TBL_CEKLERs.First(s=> s.ID == CekID);
                Cek.ACIKLAMA = txtAciklama.Text;
                Cek.ACKODU = "A";
                Cek.BANKA = txtBanka.Text;
                Cek.BELGENO = txtBelgeNo.Text;
                Cek.CEKNO = txtCekNo.Text;
                Cek.DURUMU = "Portföy";
                Cek.HESAPNO = txtHesapNo.Text;
                Cek.SUBE = txtSube.Text;
                Cek.TAHSIL = "Hayır";
                Cek.TARIH = DateTime.Now;
                Cek.TIPI = "Kendi Çekimiz";
                Cek.TUTAR = decimal.Parse(txtTutar.Text);
                Cek.VADETARIHI = DateTime.Parse(txtVadeTarihi.Text);
                Cek.EDITUSER = AnaForm.UserID;
                Cek.EDITDATE = DateTime.Now;
              
                DB.SubmitChanges();
               
                Fonksiyonlar.TBL_BANKAHAREKETLERI BankaHareketi = DB.TBL_BANKAHAREKETLERIs.First(s => s.EVRAKID == CekID && s.EVRAKTURU == "Kendi Çekimiz ");
                BankaHareketi.ACIKLAMA = txtCekNo.Text + " numaralı ve " + txtVadeTarihi.Text + " vadeli kendi çekimiz.";
                BankaHareketi.BANKAID = BankaID;
                BankaHareketi.BELGENO = txtBelgeNo.Text;
                BankaHareketi.EVRAKID = Cek.ID;
                BankaHareketi.EVRAKTURU = "Kendi Çekimiz";
                BankaHareketi.GCKODU = "C";
                BankaHareketi.TARIH = DateTime.Now;
                BankaHareketi.TUTAR = 0;
                BankaHareketi.EDITDATE = DateTime.Now;
                BankaHareketi.EDITUSER = AnaForm.UserID;
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
                DB.TBL_BANKAHAREKETLERIs.DeleteOnSubmit(DB.TBL_BANKAHAREKETLERIs.First(s => s.EVRAKID == CekID && s.EVRAKTURU == "Kendi Çekimiz "));
                DB.TBL_CEKLERs.DeleteOnSubmit(DB.TBL_CEKLERs.First(s => s.ID == CekID));
                DB.SubmitChanges();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }
        private void txtHesapNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = Formlar.BankaListesi(true);
            if(id>0) BankaAc(id);
            AnaForm.Aktar = -1;
           
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && CekID>0 &&Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKaydet();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (Edit && CekID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}