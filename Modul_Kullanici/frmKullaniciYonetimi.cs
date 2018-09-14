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
    public partial class frmKullaniciYonetimi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        int Secim = -1;

        public frmKullaniciYonetimi()
        {
            InitializeComponent();
            this.Shown += frmKullaniciYonetimi_Shown;
                

        }
    
        void Listele()
        {
            var lst = from s in DB.TBL_KULLANICILARs
                      select s;
            gridControl1.DataSource = lst;
        }

        private void frmKullaniciYonetimi_Shown(object sender, EventArgs e)
        {
            Listele();
        }

        private void frmKullaniciYonetimi_Load(object sender, EventArgs e)
        {

        }
        private void btnYeniKullanici_Click(object sender, EventArgs e)
        {
            Formlar.KullaniciPanel();
        }
   

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(Mesajlar.Sil()==DialogResult.Yes)DB.TBL_KULLANICILARs.DeleteOnSubmit(DB.TBL_KULLANICILARs.First(s => s.ID == Secim));
             DB.SubmitChanges();
        }

        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
             Formlar.KullaniciPanel(true, Secim);
             Listele();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            Secim = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());

        }
    }
}