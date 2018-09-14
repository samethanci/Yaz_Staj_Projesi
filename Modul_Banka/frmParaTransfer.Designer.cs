namespace Otomasyon.Modul_Banka
{
    partial class frmParaTransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParaTransfer));
            this.BtnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.rbtnGiden = new System.Windows.Forms.RadioButton();
            this.rbtnGelen = new System.Windows.Forms.RadioButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtTutar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.txtTrasferTuru = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtTarih = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtHesapNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtBelgeNo = new DevExpress.XtraEditors.TextEdit();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtCariAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtCariKodu = new DevExpress.XtraEditors.ButtonEdit();
            this.txtHesapAdi = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrasferTuru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBelgeNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapAdi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnKapat
            // 
            this.BtnKapat.Image = global::Otomasyon.Properties.Resources.Kapat24x24;
            this.BtnKapat.Location = new System.Drawing.Point(314, 111);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(76, 30);
            this.BtnKapat.TabIndex = 7;
            this.BtnKapat.Text = "Kapat";
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Image = global::Otomasyon.Properties.Resources.Sil24x24;
            this.BtnSil.Location = new System.Drawing.Point(314, 76);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(74, 30);
            this.BtnSil.TabIndex = 6;
            this.BtnSil.Text = "Sil";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.groupControl3);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.txtTutar);
            this.groupControl2.Controls.Add(this.labelControl9);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.txtAciklama);
            this.groupControl2.Controls.Add(this.txtTrasferTuru);
            this.groupControl2.Controls.Add(this.txtTarih);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 203);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(402, 270);
            this.groupControl2.TabIndex = 8;
            this.groupControl2.Text = "İşlem Bilgileri";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.rbtnGiden);
            this.groupControl3.Controls.Add(this.rbtnGelen);
            this.groupControl3.Location = new System.Drawing.Point(265, 28);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(107, 80);
            this.groupControl3.TabIndex = 5;
            this.groupControl3.Text = "İşlem Türü ";
            // 
            // rbtnGiden
            // 
            this.rbtnGiden.AutoSize = true;
            this.rbtnGiden.Location = new System.Drawing.Point(12, 48);
            this.rbtnGiden.Name = "rbtnGiden";
            this.rbtnGiden.Size = new System.Drawing.Size(88, 17);
            this.rbtnGiden.TabIndex = 1;
            this.rbtnGiden.Text = "Giden Havale";
            this.rbtnGiden.UseVisualStyleBackColor = true;
            // 
            // rbtnGelen
            // 
            this.rbtnGelen.AutoSize = true;
            this.rbtnGelen.Checked = true;
            this.rbtnGelen.Location = new System.Drawing.Point(12, 25);
            this.rbtnGelen.Name = "rbtnGelen";
            this.rbtnGelen.Size = new System.Drawing.Size(88, 17);
            this.rbtnGelen.TabIndex = 0;
            this.rbtnGelen.TabStop = true;
            this.rbtnGelen.Text = "Gelen Havale";
            this.rbtnGelen.UseVisualStyleBackColor = true;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(24, 127);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 13);
            this.labelControl6.TabIndex = 4;
            this.labelControl6.Text = "Açıklama :";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(24, 81);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(33, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Tutar :";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(105, 78);
            this.txtTutar.Name = "txtTutar";
            // 
            // 
            // 
            this.txtTutar.Properties.Mask.EditMask = "c";
            this.txtTutar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTutar.Size = new System.Drawing.Size(154, 20);
            this.txtTutar.TabIndex = 2;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(24, 31);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(73, 13);
            this.labelControl9.TabIndex = 4;
            this.labelControl9.Text = "Transfer Türü :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(24, 57);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(31, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Tarih :";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(85, 126);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(265, 86);
            this.txtAciklama.TabIndex = 3;
            // 
            // txtTrasferTuru
            // 
            this.txtTrasferTuru.EditValue = "Banka Havale";
            this.txtTrasferTuru.Location = new System.Drawing.Point(105, 28);
            this.txtTrasferTuru.Name = "txtTrasferTuru";
            // 
            // 
            // 
            this.txtTrasferTuru.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTrasferTuru.Properties.Items.AddRange(new object[] {
            "Banka Havale",
            "Banka EFT"});
            this.txtTrasferTuru.Size = new System.Drawing.Size(154, 20);
            this.txtTrasferTuru.TabIndex = 0;
            this.txtTrasferTuru.SelectedIndexChanged += new System.EventHandler(this.txtTrasferTuru_SelectedIndexChanged);
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(105, 53);
            this.txtTarih.Name = "txtTarih";
            // 
            // 
            // 
            this.txtTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            // 
            // 
            // 
            this.txtTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Properties.DisplayFormat.FormatString = "";
            this.txtTarih.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTarih.Properties.EditFormat.FormatString = "";
            this.txtTarih.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTarih.Properties.Mask.EditMask = "";
            this.txtTarih.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtTarih.Size = new System.Drawing.Size(154, 20);
            this.txtTarih.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(24, 98);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(53, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Hesap No :";
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.Location = new System.Drawing.Point(120, 94);
            this.txtHesapNo.Name = "txtHesapNo";
            // 
            // 
            // 
            this.txtHesapNo.Properties.ReadOnly = true;
            this.txtHesapNo.Size = new System.Drawing.Size(188, 20);
            this.txtHesapNo.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(24, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(87, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Hesap Adı / Türü :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(24, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Belge No :";
            // 
            // txtBelgeNo
            // 
            this.txtBelgeNo.Location = new System.Drawing.Point(120, 40);
            this.txtBelgeNo.Name = "txtBelgeNo";
            this.txtBelgeNo.Size = new System.Drawing.Size(188, 20);
            this.txtBelgeNo.TabIndex = 0;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Image = global::Otomasyon.Properties.Resources.Kaydet24x24;
            this.BtnKaydet.Location = new System.Drawing.Point(313, 39);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(75, 30);
            this.BtnKaydet.TabIndex = 5;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.txtCariAdi);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtHesapNo);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtBelgeNo);
            this.groupControl1.Controls.Add(this.BtnKapat);
            this.groupControl1.Controls.Add(this.BtnKaydet);
            this.groupControl1.Controls.Add(this.BtnSil);
            this.groupControl1.Controls.Add(this.txtCariKodu);
            this.groupControl1.Controls.Add(this.txtHesapAdi);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(402, 203);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "Temel Bilgiler";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(24, 151);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(44, 13);
            this.labelControl8.TabIndex = 4;
            this.labelControl8.Text = "Cari Adı :";
            // 
            // txtCariAdi
            // 
            this.txtCariAdi.Location = new System.Drawing.Point(120, 147);
            this.txtCariAdi.Name = "txtCariAdi";
            // 
            // 
            // 
            this.txtCariAdi.Properties.ReadOnly = true;
            this.txtCariAdi.Size = new System.Drawing.Size(188, 20);
            this.txtCariAdi.TabIndex = 4;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(24, 124);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(53, 13);
            this.labelControl7.TabIndex = 4;
            this.labelControl7.Text = "Cari Kodu :";
            // 
            // txtCariKodu
            // 
            this.txtCariKodu.Location = new System.Drawing.Point(120, 122);
            this.txtCariKodu.Name = "txtCariKodu";
            // 
            // 
            // 
            this.txtCariKodu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtCariKodu.Properties.ReadOnly = true;
            this.txtCariKodu.Size = new System.Drawing.Size(188, 20);
            this.txtCariKodu.TabIndex = 3;
            this.txtCariKodu.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtCariKodu_ButtonClick);
            // 
            // txtHesapAdi
            // 
            this.txtHesapAdi.Location = new System.Drawing.Point(120, 67);
            this.txtHesapAdi.Name = "txtHesapAdi";
            // 
            // 
            // 
            this.txtHesapAdi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtHesapAdi.Properties.ReadOnly = true;
            this.txtHesapAdi.Size = new System.Drawing.Size(188, 20);
            this.txtHesapAdi.TabIndex = 1;
            this.txtHesapAdi.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtHesapAdi_ButtonClick);
            // 
            // frmParaTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 473);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmParaTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Para Transfer Formu";
            this.Load += new System.EventHandler(this.frmBankaListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrasferTuru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBelgeNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapAdi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnKapat;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.RadioButton rbtnGiden;
        private System.Windows.Forms.RadioButton rbtnGelen;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtTutar;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.MemoEdit txtAciklama;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtHesapNo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtBelgeNo;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtCariAdi;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.ComboBoxEdit txtTrasferTuru;
        private DevExpress.XtraEditors.ButtonEdit txtCariKodu;
        private DevExpress.XtraEditors.ButtonEdit txtHesapAdi;
        private DevExpress.XtraEditors.DateEdit txtTarih;
    }
}