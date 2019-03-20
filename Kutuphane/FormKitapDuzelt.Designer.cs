namespace Kutuphane
{
    partial class FormKitapDuzelt
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKitapDuzelt));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._btnKitapTemizle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this._btnKitapGuncelle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._cmbYazarAdi = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this._cmbKutuphanesi = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this._cmbKategoriler = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this._dtTimePicture = new System.Windows.Forms.DateTimePicker();
            this._cmbYayinEvi = new System.Windows.Forms.ComboBox();
            this._nmSayfaSayisi = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this._txtKitapAdi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._txtISBNNo = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nmSayfaSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 13, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "     Kitap Güncelle";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this._btnKitapTemizle);
            this.groupBox3.Controls.Add(this._btnKitapGuncelle);
            this.groupBox3.Location = new System.Drawing.Point(14, 347);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(258, 69);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İşlemler";
            // 
            // _btnKitapTemizle
            // 
            this._btnKitapTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnKitapTemizle.ImageIndex = 21;
            this._btnKitapTemizle.ImageList = this.ımageList1;
            this._btnKitapTemizle.Location = new System.Drawing.Point(6, 19);
            this._btnKitapTemizle.Name = "_btnKitapTemizle";
            this._btnKitapTemizle.Size = new System.Drawing.Size(113, 40);
            this._btnKitapTemizle.TabIndex = 1;
            this._btnKitapTemizle.Text = "Temizle";
            this._btnKitapTemizle.UseVisualStyleBackColor = true;
            this._btnKitapTemizle.Click += new System.EventHandler(this._btnKitapTemizle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "add.ico");
            this.ımageList1.Images.SetKeyName(1, "db-add.ico");
            this.ımageList1.Images.SetKeyName(2, "door.ico");
            this.ımageList1.Images.SetKeyName(3, "edit user.ico");
            this.ımageList1.Images.SetKeyName(4, "edit.ico");
            this.ımageList1.Images.SetKeyName(5, "folder-blue rename.ico");
            this.ımageList1.Images.SetKeyName(6, "folder-blue up.ico");
            this.ımageList1.Images.SetKeyName(7, "folder-blue-down.ico");
            this.ımageList1.Images.SetKeyName(8, "home.ico");
            this.ımageList1.Images.SetKeyName(9, "mail-edit.ico");
            this.ımageList1.Images.SetKeyName(10, "ok.ico");
            this.ımageList1.Images.SetKeyName(11, "reload.ico");
            this.ımageList1.Images.SetKeyName(12, "remove.ico");
            this.ımageList1.Images.SetKeyName(13, "search-file.ico");
            this.ımageList1.Images.SetKeyName(14, "search-web.ico");
            this.ımageList1.Images.SetKeyName(15, "user.ico");
            this.ımageList1.Images.SetKeyName(16, "user-add.ico");
            this.ımageList1.Images.SetKeyName(17, "user-remove.ico");
            this.ımageList1.Images.SetKeyName(18, "users.ico");
            this.ımageList1.Images.SetKeyName(19, "vcard.ico");
            this.ımageList1.Images.SetKeyName(20, "undo.ico");
            this.ımageList1.Images.SetKeyName(21, "clean.ico");
            // 
            // _btnKitapGuncelle
            // 
            this._btnKitapGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnKitapGuncelle.ImageIndex = 11;
            this._btnKitapGuncelle.ImageList = this.ımageList1;
            this._btnKitapGuncelle.Location = new System.Drawing.Point(125, 19);
            this._btnKitapGuncelle.Name = "_btnKitapGuncelle";
            this._btnKitapGuncelle.Size = new System.Drawing.Size(127, 40);
            this._btnKitapGuncelle.TabIndex = 0;
            this._btnKitapGuncelle.Text = "Güncelle";
            this._btnKitapGuncelle.UseVisualStyleBackColor = true;
            this._btnKitapGuncelle.Click += new System.EventHandler(this._btnKitapGuncelle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._cmbYazarAdi);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this._cmbKutuphanesi);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this._cmbKategoriler);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this._dtTimePicture);
            this.groupBox1.Controls.Add(this._cmbYayinEvi);
            this.groupBox1.Controls.Add(this._nmSayfaSayisi);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this._txtKitapAdi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this._txtISBNNo);
            this.groupBox1.Location = new System.Drawing.Point(14, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 300);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Bilgileri";
            // 
            // _cmbYazarAdi
            // 
            this._cmbYazarAdi.FormattingEnabled = true;
            this._cmbYazarAdi.Location = new System.Drawing.Point(97, 153);
            this._cmbYazarAdi.Name = "_cmbYazarAdi";
            this._cmbYazarAdi.Size = new System.Drawing.Size(121, 21);
            this._cmbYazarAdi.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Yazar Adı";
            // 
            // _cmbKutuphanesi
            // 
            this._cmbKutuphanesi.FormattingEnabled = true;
            this._cmbKutuphanesi.Location = new System.Drawing.Point(95, 263);
            this._cmbKutuphanesi.Name = "_cmbKutuphanesi";
            this._cmbKutuphanesi.Size = new System.Drawing.Size(121, 21);
            this._cmbKutuphanesi.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Kütüphanesi";
            // 
            // _cmbKategoriler
            // 
            this._cmbKategoriler.FormattingEnabled = true;
            this._cmbKategoriler.Location = new System.Drawing.Point(95, 223);
            this._cmbKategoriler.Name = "_cmbKategoriler";
            this._cmbKategoriler.Size = new System.Drawing.Size(121, 21);
            this._cmbKategoriler.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Kategorisi";
            // 
            // _dtTimePicture
            // 
            this._dtTimePicture.Location = new System.Drawing.Point(96, 88);
            this._dtTimePicture.Name = "_dtTimePicture";
            this._dtTimePicture.Size = new System.Drawing.Size(121, 20);
            this._dtTimePicture.TabIndex = 15;
            // 
            // _cmbYayinEvi
            // 
            this._cmbYayinEvi.FormattingEnabled = true;
            this._cmbYayinEvi.Location = new System.Drawing.Point(96, 188);
            this._cmbYayinEvi.Name = "_cmbYayinEvi";
            this._cmbYayinEvi.Size = new System.Drawing.Size(121, 21);
            this._cmbYayinEvi.TabIndex = 14;
            // 
            // _nmSayfaSayisi
            // 
            this._nmSayfaSayisi.Location = new System.Drawing.Point(96, 122);
            this._nmSayfaSayisi.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this._nmSayfaSayisi.Name = "_nmSayfaSayisi";
            this._nmSayfaSayisi.Size = new System.Drawing.Size(120, 20);
            this._nmSayfaSayisi.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Sayfa Sayısı";
            // 
            // _txtKitapAdi
            // 
            this._txtKitapAdi.Location = new System.Drawing.Point(97, 53);
            this._txtKitapAdi.Name = "_txtKitapAdi";
            this._txtKitapAdi.Size = new System.Drawing.Size(119, 20);
            this._txtKitapAdi.TabIndex = 7;
            this._txtKitapAdi.TextChanged += new System.EventHandler(this._txtKitapAdi_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Yayın Evi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ISBN NO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yayin Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Adı";
            // 
            // _txtISBNNo
            // 
            this._txtISBNNo.Location = new System.Drawing.Point(97, 23);
            this._txtISBNNo.Name = "_txtISBNNo";
            this._txtISBNNo.Size = new System.Drawing.Size(119, 20);
            this._txtISBNNo.TabIndex = 0;
            // 
            // FormKitapDuzelt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 427);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormKitapDuzelt";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kitap Güncelleme";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormKitapDuzelt_FormClosed);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nmSayfaSayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button _btnKitapTemizle;
        private System.Windows.Forms.Button _btnKitapGuncelle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox _cmbYazarAdi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox _cmbKutuphanesi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox _cmbKategoriler;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker _dtTimePicture;
        private System.Windows.Forms.ComboBox _cmbYayinEvi;
        private System.Windows.Forms.NumericUpDown _nmSayfaSayisi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox _txtKitapAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtISBNNo;
        public System.Windows.Forms.ImageList ımageList1;
    }
}