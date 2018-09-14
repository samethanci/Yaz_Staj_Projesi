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
    public partial class frmBankaAcilisKarti : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        bool Edit = false;
        int SecimID = -1;


        public frmBankaAcilisKarti()
        {
            InitializeComponent();
            if(AnaForm.Kullanici.KODU == "Normal")
            {
                BtnSil.Enabled = false;
            }
        }

        private void frmBankaAcilisKarti_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Temizle()
        {
            Listele();
            txtAdres.Text = "";
            txtBankaAdi.Text = "";
            txtHesapAdi.Text = "";
            txtHesapNo.Text = "";
            txtIBAN.Text = "";
            txtSube.Text = "";
            txtTelefon.Text = "";
            txtTemsilci.Text = "";
            txtTemsilciEmail.Text = "";
            Edit = false;
            SecimID = -1;
        }

        void Listele()
        {
            var lst = from s in DB.TBL_BANKALARs
                      select s;
            Liste.DataSource = lst;
        }
       
        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_BANKALAR Banka = new Fonksiyonlar.TBL_BANKALAR();
                Banka.ADRES = txtAdres.Text;
                Banka.BANKAADI = txtBankaAdi.Text;
                Banka.HESAPADI = txtHesapAdi.Text;
                Banka.IBAN= txtIBAN.Text;
                Banka.SUBE = txtSube.Text;
                Banka.TEL = txtTelefon.Text;
                Banka.TEMSILCI = txtTemsilci.Text;
                Banka.TEMSILCIEMAIL = txtTemsilciEmail.Text;
                Banka.SAVEDATE = DateTime.Now;
                Banka.SAVEUSER = AnaForm.UserID;
                DB.TBL_BANKALARs.InsertOnSubmit(Banka);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Yeni banka kaydı açılmıştır.");
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
                Fonksiyonlar.TBL_BANKALAR Banka = DB.TBL_BANKALARs.First(s => s.ID == SecimID);
                Banka.ADRES = txtAdres.Text;
                Banka.BANKAADI = txtBankaAdi.Text;
                Banka.HESAPADI = txtHesapAdi.Text;
                Banka.IBAN = txtIBAN.Text;
                Banka.SUBE = txtSube.Text;
                Banka.TEL = txtTelefon.Text;
                Banka.TEMSILCI = txtTemsilci.Text;
                Banka.TEMSILCIEMAIL = txtTemsilciEmail.Text;
                Banka.EDITDATE = DateTime.Now;
                Banka.EDITUSER = AnaForm.UserID;
        
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
                DB.TBL_BANKALARs.DeleteOnSubmit(DB.TBL_BANKALARs.First(s => s.ID == SecimID));
                DB.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        void Sec()
        {
            try
            {
                Edit = true;
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                if (SecimID > 0) Ac();
            }
            catch (Exception )
            {
                Edit = false;
                SecimID = -1;
            }
        }
        void Ac()
        {
            try
            {
                Fonksiyonlar.TBL_BANKALAR Banka = DB.TBL_BANKALARs.First(s => s.ID == SecimID);
                txtAdres.Text = Banka.ADRES;
                txtBankaAdi.Text = Banka.BANKAADI;
                txtHesapAdi.Text = Banka.HESAPADI;
                txtHesapNo.Text = Banka.HESAPNO;
                txtIBAN.Text = Banka.IBAN;
                txtSube.Text = Banka.SUBE;
                txtTelefon.Text = Banka.TEL;
                txtTemsilci.Text = Banka.TEMSILCI;
                txtTemsilciEmail.Text = Banka.TEMSILCIEMAIL;
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKaydet();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();

        }
    }
}