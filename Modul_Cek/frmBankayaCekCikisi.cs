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
    public partial class frmBankayaCekCikisi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.TBL_CEKLER Cek;
        int CekID = -1;
        int BankaID = -1;


        public frmBankayaCekCikisi()
        {
            InitializeComponent();
        }

        private void frmBankayaCekCikisi_Load(object sender, EventArgs e)
        {
            txtVadeTarihi.Text = DateTime.Now.ToShortDateString();
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }

        void Temizle()
        {
            txtBanka.Text = "";
            txtBankaAdi.Text = "";
            txtBelgeNo.Text = "";
            txtcekNo.Text = "";
            txtHesapNo.Text = "";
            txtSube.Text = "";
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtTutar.Text = "";
            txtVadeTarihi.Text = "";
            CekID = -1;
            BankaID = -1;
            AnaForm.Aktar = -1;
            Cek = null;
        }

        void CekGetir(int ID)
        {
            try
            {
                CekID = ID;
                Cek = DB.TBL_CEKLERs.First(s => s.ID == CekID);
                txtBanka.Text = Cek.BANKA;
                txtcekNo.Text = Cek.CEKNO;
                txtSube.Text = Cek.SUBE;
                txtVadeTarihi.Text = Cek.VADETARIHI.Value.ToShortDateString();
                txtTutar.Text = Cek.TUTAR.Value.ToString();
                


            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }
        void BankaGetir(int ID)
        {
            try
            {
                BankaID = ID;
                txtHesapNo.Text = DB.TBL_BANKALARs.First(s => s.ID == BankaID).HESAPNO;
                txtBankaAdi.Text = DB.TBL_BANKALARs.First(s => s.ID == BankaID).BANKAADI;

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
                Fonksiyonlar.TBL_BANKAHAREKETLERI Hareket = new Fonksiyonlar.TBL_BANKAHAREKETLERI();
                Hareket.ACIKLAMA = txtBelgeNo.Text + "belge numaralı ve " + txtcekNo.Text + "çek numaralı çeki bankaya çıkışı";
                Hareket.BANKAID = BankaID;
                Hareket.BELGENO = txtBelgeNo.Text;
                Hareket.EVRAKID = CekID;
                Hareket.EVRAKTURU = "Bankaya Çek";
                Hareket.GCKODU = "G";
                Hareket.TARIH = DateTime.Parse(txtTarih.Text);
                Hareket.TUTAR = decimal.Parse(txtTutar.Text);
                Hareket.SAVEDATE = DateTime.Now;
                Hareket.SAVEUSER = AnaForm.UserID;
                DB.TBL_BANKAHAREKETLERIs.InsertOnSubmit(Hareket);
                DB.SubmitChanges();
                Mesajlar.YeniKayit(txtcekNo.Text + "numaralı çeki banka hareket kaydı işlenmiştir.");
                Cek.VERILENBANKA_BELGENO = txtBelgeNo.Text;
                Cek.VERILENBANKA_TARIHI = DateTime.Parse(txtTarih.Text);
                Cek.VERILENBANKAID = BankaID;
                Cek.DURUMU = "Bankada";
                DB.SubmitChanges();
                Mesajlar.YeniKayit(txtcekNo.Text + "numaralı çeki durum güncellemesi yapılmıştır.");
                Temizle();
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (Cek !=null && CekID > 0 && BankaID >0 )
            {
                YeniKaydet();
            }
        }

        private void txtHesapNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.BankaListesi(true);
            if (ID >0)
            {
                BankaGetir(ID);
            }
            AnaForm.Aktar = -1;
        }

        private void txtcekNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.CekListesi(true);
            if (ID > 0)
            {
                CekGetir(ID);
            }
            AnaForm.Aktar = -1;
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}