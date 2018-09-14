﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Otomasyon.Modul_Cari
{
    public partial class frmCariAcilisKarti : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Numara Numaralar = new Fonksiyonlar.Numara();
        bool Edit = false;
        int CariID = -1;
        int GrupID = -1;

        public frmCariAcilisKarti()
        {
            InitializeComponent();
        }

        private void frmCariAcilisKarti_Load(object sender, EventArgs e)
        {
            txtCariKodu.Text = Numaralar.CariKodNumarasi();
        }

        void Temizle()
        {
            foreach(Control CT in groupControl1.Controls)
                if (CT is DevExpress.XtraEditors.TextEdit ||  CT is DevExpress.XtraEditors.ButtonEdit) CT.Text = "";
            foreach (Control CE in groupControl2.Controls)
                if (CE is DevExpress.XtraEditors.TextEdit || CE is DevExpress.XtraEditors.ButtonEdit || CE is DevExpress.XtraEditors.MemoEdit) CE.Text = "";
            txtCariKodu.Text = Numaralar.CariKodNumarasi();
            Edit = false;
            CariID = -1;
            GrupID = -1;
            AnaForm.Aktar = -1;

        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_CARILER Cari = new Fonksiyonlar.TBL_CARILER();
                Cari.ADRES = txtAdres.Text;
                Cari.CARIADI = txtCariAdi.Text;
                Cari.CARIKOD = txtCariKodu.Text;
                Cari.FAX1 = txtFax1.Text;
                Cari.FAX2 = txtFax2.Text;
                Cari.GRUPID = GrupID;
                Cari.ILCE = txtIlce.Text;
                Cari.MAILINFO = txtMailInfo.Text;
                Cari.SAVEDATE = DateTime.Now;
                Cari.SAVEUSER = AnaForm.UserID;
                Cari.TELEFON1 = txtTelefon1.Text;
                Cari.TELEFON2 = txtTelefon2.Text;
                Cari.ULKE = txtUlke.Text;
                Cari.SEHİR = txtSehir.Text;
                Cari.VERDIDAIRESI = txtVergiDairesi.Text;
                Cari.VERGINO = txtVergiNo.Text;
                Cari.WEBADRES = txtWebAdresi.Text;
                Cari.YETKILI1 = txtYetkili1.Text;
                Cari.YETKILI2 = txtYetkili2.Text;
                Cari.YETKILIEMAIL1 = txtYetkili1Email.Text;
                Cari.YETKILIEMAIL2 = txtYetkili2Email.Text;
                DB.TBL_CARILERs.InsertOnSubmit(Cari);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Yeni Cari Kaydı Oluşturulmuştur.");
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
                DB.TBL_CARILERs.DeleteOnSubmit(DB.TBL_CARILERs.First(s=> s.ID == CariID));
                DB.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {
                DB.SubmitChanges();
                Temizle();
                Mesajlar.Hata(e);
            }
        }

        void Guncelle()
        {
            try
            {
                Fonksiyonlar.TBL_CARILER Cari = DB.TBL_CARILERs.First(s => s.ID == CariID);
                Cari.ADRES = txtAdres.Text;
                Cari.CARIADI = txtCariAdi.Text;
                Cari.CARIKOD = txtCariKodu.Text;
                Cari.FAX1 = txtFax1.Text;
                Cari.FAX2 = txtFax2.Text;
                Cari.GRUPID = GrupID;
                Cari.ILCE = txtIlce.Text;
                Cari.MAILINFO = txtMailInfo.Text;
                Cari.EDITDATE = DateTime.Now;
                Cari.EDITUSER = AnaForm.UserID;
                Cari.TELEFON1 = txtTelefon1.Text;
                Cari.TELEFON2 = txtTelefon2.Text;
                Cari.ULKE = txtUlke.Text;
                Cari.SEHİR = txtSehir.Text;
                Cari.VERDIDAIRESI = txtVergiDairesi.Text;
                Cari.VERGINO = txtVergiNo.Text;
                Cari.WEBADRES = txtWebAdresi.Text;
                Cari.YETKILI1 = txtYetkili1.Text;
                Cari.YETKILI2 = txtYetkili2.Text;
                Cari.YETKILIEMAIL1 = txtYetkili1Email.Text;
                Cari.YETKILIEMAIL2 = txtYetkili2Email.Text;
                 
                DB.SubmitChanges();
                Mesajlar.Guncelle(true);
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }

        }

        void GrupAc(int ID)
        {
            try
            {
                GrupID = ID;
                Fonksiyonlar.TBL_CARİGRUPLARI Grup = DB.TBL_CARİGRUPLARIs.First(s => s.ID == GrupID);
                txtCariGrupAdi.Text = Grup.GRUPADI;
                txtCariGrupKodu.Text = Grup.GRUPKODU;

            }
            catch (Exception e)
            {
                
                Mesajlar.Hata(e);
            }
        }

        public void Ac(int ID)
        {
            try
            {
                Edit = true;
                CariID = ID;
                Fonksiyonlar.TBL_CARILER Cari = DB.TBL_CARILERs.First(s => s.ID == CariID);
                txtAdres.Text = Cari.ADRES;
                txtCariAdi.Text = Cari.CARIADI;
                txtCariKodu.Text = Cari.CARIKOD;
                txtFax1.Text = Cari.FAX1;
                txtFax2.Text = Cari.FAX2;
                txtIlce.Text = Cari.ILCE;
                txtMailInfo.Text = Cari.MAILINFO;
                txtSehir.Text = Cari.SEHİR;
                txtTelefon1.Text = Cari.TELEFON1;
                txtTelefon2.Text = Cari.TELEFON2;
                txtUlke.Text = Cari.ULKE;
                txtVergiDairesi.Text = Cari.VERDIDAIRESI;
                txtVergiNo.Text = Cari.VERGINO;
                txtWebAdresi.Text = Cari.WEBADRES;
                txtYetkili1.Text = Cari.YETKILI1;
                txtYetkili2.Text = Cari.YETKILI2;
                txtYetkili1Email.Text = Cari.YETKILIEMAIL1;
                txtYetkili2Email.Text = Cari.YETKILIEMAIL2;
                GrupAc(Cari.GRUPID.Value);
                
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (Edit && CariID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && CariID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKaydet();
        }

        private void txtCariGrupKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.CariGruplari(true);
            if(ID >0)
            {
                GrupAc(ID);
            }
            AnaForm.Aktar = -1;
        }

        private void txtCariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.CariListesi(true);
            if(ID>0)
            {
                Ac(ID);
            }
            AnaForm.Aktar = -1;
        }
    }
}