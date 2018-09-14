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
    public partial class frmCekListesi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        public bool Secim = false;
        int SecilenID = -1;

        public frmCekListesi()
        {
            InitializeComponent();
        }
        void Listele()
        {
            var lst = from s in DB.TBL_CEKLERs
                      where s.TIPI.Contains(txtCekTuru.Text) && s.BANKA.Contains(txtBanka.Text) && s.CEKNO.Contains(txtCekNo.Text)
                      select s;
            Liste.DataSource = lst;
        }
        void Sec()
        {
            SecilenID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
        }

        private void frmCekListesi_Load(object sender, EventArgs e)
        {
            Listele();

        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (Secim && SecilenID > 0)
            {
                AnaForm.Aktar = SecilenID;
                this.Close();
            }
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnPrintToPdf_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sf = new SaveFileDialog())
            {
                sf.Filter = "Acrobat Reader|*.pdf";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    Liste.ExportToPdf(sf.FileName);
                }
            }
        }

        private void btnPrintToXls_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sf = new SaveFileDialog())
            {
                sf.Filter = "Excel|*.xls";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    Liste.ExportToXls(sf.FileName);
                }
            }
        }
    }
}