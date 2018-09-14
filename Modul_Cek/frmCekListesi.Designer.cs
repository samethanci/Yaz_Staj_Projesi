namespace Otomasyon.Modul_Cek
{
    partial class frmCekListesi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCekListesi));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.btnPrintToXls = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrintToPdf = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAra = new DevExpress.XtraEditors.SimpleButton();
            this.txtBanka = new System.Windows.Forms.TextBox();
            this.txtCekNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCekTuru = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BANKA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CEKNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TIPI = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCekTuru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.Liste);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(748, 417);
            this.splitContainerControl1.SplitterPosition = 196;
            this.splitContainerControl1.TabIndex = 2;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(196, 417);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.btnPrintToXls);
            this.xtraTabPage1.Controls.Add(this.btnPrintToPdf);
            this.xtraTabPage1.Controls.Add(this.BtnSil);
            this.xtraTabPage1.Controls.Add(this.BtnAra);
            this.xtraTabPage1.Controls.Add(this.txtBanka);
            this.xtraTabPage1.Controls.Add(this.txtCekNo);
            this.xtraTabPage1.Controls.Add(this.label2);
            this.xtraTabPage1.Controls.Add(this.label4);
            this.xtraTabPage1.Controls.Add(this.label3);
            this.xtraTabPage1.Controls.Add(this.label1);
            this.xtraTabPage1.Controls.Add(this.txtCekTuru);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(190, 389);
            this.xtraTabPage1.Text = "Arama";
            // 
            // btnPrintToXls
            // 
            this.btnPrintToXls.Location = new System.Drawing.Point(16, 266);
            this.btnPrintToXls.Name = "btnPrintToXls";
            this.btnPrintToXls.Size = new System.Drawing.Size(171, 32);
            this.btnPrintToXls.TabIndex = 6;
            this.btnPrintToXls.Text = "Listeyi Yazdır(XLS) ";
            this.btnPrintToXls.Click += new System.EventHandler(this.btnPrintToXls_Click);
            // 
            // btnPrintToPdf
            // 
            this.btnPrintToPdf.Location = new System.Drawing.Point(16, 228);
            this.btnPrintToPdf.Name = "btnPrintToPdf";
            this.btnPrintToPdf.Size = new System.Drawing.Size(171, 32);
            this.btnPrintToPdf.TabIndex = 5;
            this.btnPrintToPdf.Text = "Listeyi Yazdır(PDF)";
            this.btnPrintToPdf.Click += new System.EventHandler(this.btnPrintToPdf_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.Image")));
            this.BtnSil.Location = new System.Drawing.Point(98, 184);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(89, 38);
            this.BtnSil.TabIndex = 4;
            this.BtnSil.Text = "Temizle";
            // 
            // BtnAra
            // 
            this.BtnAra.Image = ((System.Drawing.Image)(resources.GetObject("BtnAra.Image")));
            this.BtnAra.Location = new System.Drawing.Point(16, 184);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(76, 38);
            this.BtnAra.TabIndex = 3;
            this.BtnAra.Text = "Ara";
            this.BtnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // txtBanka
            // 
            this.txtBanka.Location = new System.Drawing.Point(16, 141);
            this.txtBanka.Name = "txtBanka";
            this.txtBanka.Size = new System.Drawing.Size(171, 21);
            this.txtBanka.TabIndex = 2;
            // 
            // txtCekNo
            // 
            this.txtCekNo.Location = new System.Drawing.Point(16, 92);
            this.txtCekNo.Name = "txtCekNo";
            this.txtCekNo.Size = new System.Drawing.Size(171, 21);
            this.txtCekNo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bankası :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Çek Numarası :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Çek Türü :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stok Kodu :";
            // 
            // txtCekTuru
            // 
            this.txtCekTuru.EditValue = "Kendi Çekimiz";
            this.txtCekTuru.Location = new System.Drawing.Point(16, 53);
            this.txtCekTuru.Name = "txtCekTuru";
            this.txtCekTuru.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCekTuru.Properties.Items.AddRange(new object[] {
            "Kendi Çekimiz",
            "Müşteri Çeki"});
            this.txtCekTuru.Size = new System.Drawing.Size(171, 20);
            this.txtCekTuru.TabIndex = 0;
            // 
            // Liste
            // 
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.MainView = this.gridView1;
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(547, 417);
            this.Liste.TabIndex = 0;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.BANKA,
            this.CEKNO,
            this.TIPI});
            this.gridView1.GridControl = this.Liste;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // BANKA
            // 
            this.BANKA.Caption = "BANKA";
            this.BANKA.FieldName = "BANKA";
            this.BANKA.Name = "BANKA";
            this.BANKA.OptionsColumn.AllowEdit = false;
            this.BANKA.OptionsColumn.AllowFocus = false;
            this.BANKA.OptionsColumn.FixedWidth = true;
            this.BANKA.Visible = true;
            this.BANKA.VisibleIndex = 0;
            this.BANKA.Width = 163;
            // 
            // CEKNO
            // 
            this.CEKNO.Caption = "ÇEK NUMARASI";
            this.CEKNO.FieldName = "CEKNO";
            this.CEKNO.Name = "CEKNO";
            this.CEKNO.OptionsColumn.AllowEdit = false;
            this.CEKNO.OptionsColumn.AllowFocus = false;
            this.CEKNO.OptionsColumn.FixedWidth = true;
            this.CEKNO.Visible = true;
            this.CEKNO.VisibleIndex = 1;
            this.CEKNO.Width = 191;
            // 
            // TIPI
            // 
            this.TIPI.Caption = "ÇEK TÜRÜ";
            this.TIPI.FieldName = "TIPI";
            this.TIPI.Name = "TIPI";
            this.TIPI.Visible = true;
            this.TIPI.VisibleIndex = 2;
            this.TIPI.Width = 156;
            // 
            // frmCekListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 417);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCekListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çek Listesi";
            this.Load += new System.EventHandler(this.frmCekListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCekTuru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnAra;
        private System.Windows.Forms.TextBox txtBanka;
        private System.Windows.Forms.TextBox txtCekNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl Liste;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn BANKA;
        private DevExpress.XtraGrid.Columns.GridColumn CEKNO;
        private DevExpress.XtraGrid.Columns.GridColumn TIPI;
        private DevExpress.XtraEditors.ComboBoxEdit txtCekTuru;
        private DevExpress.XtraEditors.SimpleButton btnPrintToPdf;
        private DevExpress.XtraEditors.SimpleButton btnPrintToXls;
    }
}