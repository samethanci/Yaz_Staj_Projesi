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


namespace Otomasyon
{
    public partial class frmLoginform : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();

        public frmLoginform()
        {
            InitializeComponent();
            txtKullanici.Focus();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Fonksiyonlar.TBL_KULLANICILAR Kullanici = DB.TBL_KULLANICILARs.First(s => s.KULLANICI == txtKullanici.Text.Trim() && s.SIFRE == txtSifre.Text.Trim());
                Kullanici.LASTLOGIN = DateTime.Now;
                DB.SubmitChanges();
                this.Hide();
                AnaForm frm = new AnaForm(Kullanici);
                frm.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Girişi Yapılamadı.\nKullanıcı adı veya şifre hatalı.\n Lütfen kontrol edip tekrar deneyiniz.!\n","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
 
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmAyar frm = new frmAyar();
            frm.ShowDialog();

        }

        private void frmLoginform_Load(object sender, EventArgs e)
        {

        }
    }
}