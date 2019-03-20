namespace Kutuphane
{
    partial class Form1
    {
        
        
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this._uyeler = new System.Windows.Forms.GroupBox();
            this._dbGridUyeler = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._txtUyeAra = new System.Windows.Forms.TextBox();
            this._btnAdresEkle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this._btnUyeAra = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this._btnUyesiSil = new System.Windows.Forms.Button();
            this._btnUyeEkle = new System.Windows.Forms.Button();
            this._btnUyeDuzelt = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._dbGridKitaplar = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this._txtKitapAdiAra = new System.Windows.Forms.TextBox();
            this._btnKitapAra = new System.Windows.Forms.Button();
            this._btnKitapDuzelt = new System.Windows.Forms.Button();
            this._btnKitapSil = new System.Windows.Forms.Button();
            this._btnKitapEkle = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this._txtYazarSoyad = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this._txtYazarAd = new System.Windows.Forms.TextBox();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this._btnYazarEkle = new System.Windows.Forms.Button();
            this._btnYazarDuzelt = new System.Windows.Forms.Button();
            this._btnYazarSil = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this._dbGridYazarlar = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this._txtYazarAdiAra = new System.Windows.Forms.TextBox();
            this._btnYazarAra = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this._txtKategoriAdi = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this._btnKategoriSil = new System.Windows.Forms.Button();
            this._btnKategoriEkle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this._dbGridKategoriler = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this._btnYayinEviSil = new System.Windows.Forms.Button();
            this._btnYayinEviKaydet = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._cmbAdresBilgisi = new System.Windows.Forms.ComboBox();
            this._txtYayinEviAdi = new System.Windows.Forms.TextBox();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this._dbGridYayinEvleri = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this._dbGridEmanet = new System.Windows.Forms.DataGridView();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this._btnEGeriAl = new System.Windows.Forms.Button();
            this._btnEmanetVer = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this._dtepicturTelsimTa = new System.Windows.Forms.DateTimePicker();
            this._dtepicturVerilisTa = new System.Windows.Forms.DateTimePicker();
            this._cmbVerilenKitap = new System.Windows.Forms.ComboBox();
            this._cmbKitapveruye = new System.Windows.Forms.ComboBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this._dbGridKutuphaneler = new System.Windows.Forms.DataGridView();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this._btnKutuphaneGuncelle = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._txtKutuphaneAdi = new System.Windows.Forms.TextBox();
            this._cmbKutuphaneAdres = new System.Windows.Forms.ComboBox();
            this._btnKutuphaneEkle = new System.Windows.Forms.Button();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farklıKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.yazdırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baskıÖnizlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geriAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yineleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.kesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapıştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tümünüSeçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.özelleştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçeneklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.içindekilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dizinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._statusBar = new System.Windows.Forms.StatusBar();
            this._brPnlTarih = new System.Windows.Forms.StatusBarPanel();
            this._brPnlPencere = new System.Windows.Forms.StatusBarPanel();
            this._brPnlDurum = new System.Windows.Forms.StatusBarPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this._uyeler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dbGridUyeler)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dbGridKitaplar)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dbGridYazarlar)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dbGridKategoriler)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dbGridYayinEvleri)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.groupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dbGridEmanet)).BeginInit();
            this.groupBox12.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.groupBox16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dbGridKutuphaneler)).BeginInit();
            this.groupBox15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._brPnlTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._brPnlPencere)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._brPnlDurum)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.ımageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this._uyeler);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.ImageIndex = 18;
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 409);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Üyeler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // _uyeler
            // 
            this._uyeler.Controls.Add(this._dbGridUyeler);
            this._uyeler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._uyeler.Location = new System.Drawing.Point(3, 79);
            this._uyeler.Name = "_uyeler";
            this._uyeler.Padding = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this._uyeler.Size = new System.Drawing.Size(786, 327);
            this._uyeler.TabIndex = 4;
            this._uyeler.TabStop = false;
            this._uyeler.Text = "Üyeler";
            // 
            // _dbGridUyeler
            // 
            this._dbGridUyeler.AllowUserToAddRows = false;
            this._dbGridUyeler.AllowUserToDeleteRows = false;
            this._dbGridUyeler.AllowUserToResizeRows = false;
            this._dbGridUyeler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this._dbGridUyeler.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this._dbGridUyeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dbGridUyeler.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dbGridUyeler.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this._dbGridUyeler.Location = new System.Drawing.Point(3, 16);
            this._dbGridUyeler.MultiSelect = false;
            this._dbGridUyeler.Name = "_dbGridUyeler";
            this._dbGridUyeler.ReadOnly = true;
            this._dbGridUyeler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dbGridUyeler.Size = new System.Drawing.Size(780, 291);
            this._dbGridUyeler.TabIndex = 1;
            this._dbGridUyeler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dbGridUyeler_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._txtUyeAra);
            this.groupBox1.Controls.Add(this._btnAdresEkle);
            this.groupBox1.Controls.Add(this._btnUyeAra);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this._btnUyesiSil);
            this.groupBox1.Controls.Add(this._btnUyeEkle);
            this.groupBox1.Controls.Add(this._btnUyeDuzelt);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 70);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemler";
            // 
            // _txtUyeAra
            // 
            this._txtUyeAra.Location = new System.Drawing.Point(562, 35);
            this._txtUyeAra.Name = "_txtUyeAra";
            this._txtUyeAra.Size = new System.Drawing.Size(128, 20);
            this._txtUyeAra.TabIndex = 5;
            // 
            // _btnAdresEkle
            // 
            this._btnAdresEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnAdresEkle.ImageIndex = 8;
            this._btnAdresEkle.ImageList = this.ımageList1;
            this._btnAdresEkle.Location = new System.Drawing.Point(362, 16);
            this._btnAdresEkle.Name = "_btnAdresEkle";
            this._btnAdresEkle.Size = new System.Drawing.Size(112, 39);
            this._btnAdresEkle.TabIndex = 8;
            this._btnAdresEkle.Text = "      Adres Ekle";
            this._btnAdresEkle.UseVisualStyleBackColor = true;
            this._btnAdresEkle.Click += new System.EventHandler(this._btnAdresEkle_Click);
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
            // _btnUyeAra
            // 
            this._btnUyeAra.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this._btnUyeAra.ImageIndex = 14;
            this._btnUyeAra.ImageList = this.ımageList1;
            this._btnUyeAra.Location = new System.Drawing.Point(696, 19);
            this._btnUyeAra.Name = "_btnUyeAra";
            this._btnUyeAra.Size = new System.Drawing.Size(84, 39);
            this._btnUyeAra.TabIndex = 4;
            this._btnUyeAra.Text = "   Ara";
            this._btnUyeAra.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(559, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Üye Adı";
            // 
            // _btnUyesiSil
            // 
            this._btnUyesiSil.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this._btnUyesiSil.ImageIndex = 12;
            this._btnUyesiSil.ImageList = this.ımageList1;
            this._btnUyesiSil.Location = new System.Drawing.Point(126, 16);
            this._btnUyesiSil.Name = "_btnUyesiSil";
            this._btnUyesiSil.Size = new System.Drawing.Size(112, 39);
            this._btnUyesiSil.TabIndex = 1;
            this._btnUyesiSil.Text = "Sil";
            this._btnUyesiSil.UseVisualStyleBackColor = true;
            this._btnUyesiSil.Click += new System.EventHandler(this._btnUyesiSil_Click);
            // 
            // _btnUyeEkle
            // 
            this._btnUyeEkle.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this._btnUyeEkle.ImageIndex = 15;
            this._btnUyeEkle.ImageList = this.ımageList1;
            this._btnUyeEkle.Location = new System.Drawing.Point(8, 16);
            this._btnUyeEkle.Name = "_btnUyeEkle";
            this._btnUyeEkle.Size = new System.Drawing.Size(112, 39);
            this._btnUyeEkle.TabIndex = 2;
            this._btnUyeEkle.Text = "Ekle";
            this._btnUyeEkle.UseVisualStyleBackColor = true;
            this._btnUyeEkle.Click += new System.EventHandler(this._btnUyeEkle_Click);
            // 
            // _btnUyeDuzelt
            // 
            this._btnUyeDuzelt.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this._btnUyeDuzelt.ImageIndex = 3;
            this._btnUyeDuzelt.ImageList = this.ımageList1;
            this._btnUyeDuzelt.Location = new System.Drawing.Point(244, 16);
            this._btnUyeDuzelt.Name = "_btnUyeDuzelt";
            this._btnUyeDuzelt.Size = new System.Drawing.Size(112, 39);
            this._btnUyeDuzelt.TabIndex = 3;
            this._btnUyeDuzelt.Text = "Düzelt";
            this._btnUyeDuzelt.UseVisualStyleBackColor = true;
            this._btnUyeDuzelt.Click += new System.EventHandler(this._btnUyeDuzelt_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.ImageIndex = 6;
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 409);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kitaplar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._dbGridKitaplar);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.groupBox2.Size = new System.Drawing.Size(786, 327);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitaplar";
            // 
            // _dbGridKitaplar
            // 
            this._dbGridKitaplar.AllowUserToAddRows = false;
            this._dbGridKitaplar.AllowUserToDeleteRows = false;
            this._dbGridKitaplar.AllowUserToResizeRows = false;
            this._dbGridKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this._dbGridKitaplar.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this._dbGridKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dbGridKitaplar.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dbGridKitaplar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this._dbGridKitaplar.Location = new System.Drawing.Point(3, 16);
            this._dbGridKitaplar.MultiSelect = false;
            this._dbGridKitaplar.Name = "_dbGridKitaplar";
            this._dbGridKitaplar.ReadOnly = true;
            this._dbGridKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dbGridKitaplar.Size = new System.Drawing.Size(780, 291);
            this._dbGridKitaplar.TabIndex = 1;
            this._dbGridKitaplar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dbGridKitaplar_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this._txtKitapAdiAra);
            this.groupBox3.Controls.Add(this._btnKitapAra);
            this.groupBox3.Controls.Add(this._btnKitapDuzelt);
            this.groupBox3.Controls.Add(this._btnKitapSil);
            this.groupBox3.Controls.Add(this._btnKitapEkle);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(786, 70);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İşlemler";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(559, 19);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 13);
            this.label17.TabIndex = 32;
            this.label17.Text = "Kitap Adı";
            // 
            // _txtKitapAdiAra
            // 
            this._txtKitapAdiAra.Location = new System.Drawing.Point(562, 35);
            this._txtKitapAdiAra.Name = "_txtKitapAdiAra";
            this._txtKitapAdiAra.Size = new System.Drawing.Size(128, 20);
            this._txtKitapAdiAra.TabIndex = 5;
            // 
            // _btnKitapAra
            // 
            this._btnKitapAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnKitapAra.ImageIndex = 14;
            this._btnKitapAra.ImageList = this.ımageList1;
            this._btnKitapAra.Location = new System.Drawing.Point(696, 19);
            this._btnKitapAra.Name = "_btnKitapAra";
            this._btnKitapAra.Size = new System.Drawing.Size(84, 39);
            this._btnKitapAra.TabIndex = 4;
            this._btnKitapAra.Text = "   Ara";
            this._btnKitapAra.UseVisualStyleBackColor = true;
            // 
            // _btnKitapDuzelt
            // 
            this._btnKitapDuzelt.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this._btnKitapDuzelt.ImageIndex = 5;
            this._btnKitapDuzelt.ImageList = this.ımageList1;
            this._btnKitapDuzelt.Location = new System.Drawing.Point(244, 16);
            this._btnKitapDuzelt.Name = "_btnKitapDuzelt";
            this._btnKitapDuzelt.Size = new System.Drawing.Size(112, 39);
            this._btnKitapDuzelt.TabIndex = 3;
            this._btnKitapDuzelt.Text = "Düzelt";
            this._btnKitapDuzelt.UseVisualStyleBackColor = true;
            this._btnKitapDuzelt.Click += new System.EventHandler(this._btnKitapDuzelt_Click);
            // 
            // _btnKitapSil
            // 
            this._btnKitapSil.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this._btnKitapSil.ImageIndex = 12;
            this._btnKitapSil.ImageList = this.ımageList1;
            this._btnKitapSil.Location = new System.Drawing.Point(126, 16);
            this._btnKitapSil.Name = "_btnKitapSil";
            this._btnKitapSil.Size = new System.Drawing.Size(112, 39);
            this._btnKitapSil.TabIndex = 1;
            this._btnKitapSil.Text = "Sil";
            this._btnKitapSil.UseVisualStyleBackColor = true;
            this._btnKitapSil.Click += new System.EventHandler(this._btnKitapSil_Click);
            // 
            // _btnKitapEkle
            // 
            this._btnKitapEkle.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this._btnKitapEkle.ImageIndex = 6;
            this._btnKitapEkle.ImageList = this.ımageList1;
            this._btnKitapEkle.Location = new System.Drawing.Point(8, 16);
            this._btnKitapEkle.Name = "_btnKitapEkle";
            this._btnKitapEkle.Size = new System.Drawing.Size(112, 39);
            this._btnKitapEkle.TabIndex = 2;
            this._btnKitapEkle.Text = "Ekle";
            this._btnKitapEkle.UseVisualStyleBackColor = true;
            this._btnKitapEkle.Click += new System.EventHandler(this._btnKitapEkle_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.groupBox18);
            this.tabPage3.Controls.Add(this.groupBox19);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.ImageIndex = 4;
            this.tabPage3.Location = new System.Drawing.Point(4, 37);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 409);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Yazarlar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(72, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(319, 26);
            this.label13.TabIndex = 26;
            this.label13.Text = "Yazar Ekle/ Güncelle/ Sil/ Ara";
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this._txtYazarSoyad);
            this.groupBox18.Controls.Add(this.label14);
            this.groupBox18.Controls.Add(this.label15);
            this.groupBox18.Controls.Add(this.label16);
            this.groupBox18.Controls.Add(this._txtYazarAd);
            this.groupBox18.Location = new System.Drawing.Point(8, 62);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(220, 118);
            this.groupBox18.TabIndex = 23;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Yazar Bilgileri";
            // 
            // _txtYazarSoyad
            // 
            this._txtYazarSoyad.Location = new System.Drawing.Point(81, 64);
            this._txtYazarSoyad.Name = "_txtYazarSoyad";
            this._txtYazarSoyad.Size = new System.Drawing.Size(133, 20);
            this._txtYazarSoyad.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 124);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(10, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = " ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(25, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Yazar Ad";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 67);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Yazar soyad";
            // 
            // _txtYazarAd
            // 
            this._txtYazarAd.Location = new System.Drawing.Point(81, 33);
            this._txtYazarAd.Name = "_txtYazarAd";
            this._txtYazarAd.Size = new System.Drawing.Size(133, 20);
            this._txtYazarAd.TabIndex = 0;
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this._btnYazarEkle);
            this.groupBox19.Controls.Add(this._btnYazarDuzelt);
            this.groupBox19.Controls.Add(this._btnYazarSil);
            this.groupBox19.Location = new System.Drawing.Point(8, 186);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(469, 82);
            this.groupBox19.TabIndex = 25;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "İşlemler";
            // 
            // _btnYazarEkle
            // 
            this._btnYazarEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this._btnYazarEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnYazarEkle.ImageKey = "ok.ico";
            this._btnYazarEkle.ImageList = this.ımageList1;
            this._btnYazarEkle.Location = new System.Drawing.Point(21, 19);
            this._btnYazarEkle.Name = "_btnYazarEkle";
            this._btnYazarEkle.Size = new System.Drawing.Size(118, 38);
            this._btnYazarEkle.TabIndex = 0;
            this._btnYazarEkle.Text = "Kaydet";
            this._btnYazarEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._btnYazarEkle.UseVisualStyleBackColor = true;
            this._btnYazarEkle.Click += new System.EventHandler(this._btnYazarEkle_Click);
            // 
            // _btnYazarDuzelt
            // 
            this._btnYazarDuzelt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this._btnYazarDuzelt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnYazarDuzelt.ImageIndex = 11;
            this._btnYazarDuzelt.ImageList = this.ımageList1;
            this._btnYazarDuzelt.Location = new System.Drawing.Point(167, 19);
            this._btnYazarDuzelt.Name = "_btnYazarDuzelt";
            this._btnYazarDuzelt.Size = new System.Drawing.Size(118, 37);
            this._btnYazarDuzelt.TabIndex = 3;
            this._btnYazarDuzelt.Text = "Güncelle";
            this._btnYazarDuzelt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._btnYazarDuzelt.UseVisualStyleBackColor = true;
            this._btnYazarDuzelt.Click += new System.EventHandler(this._btnYazarDuzelt_Click);
            // 
            // _btnYazarSil
            // 
            this._btnYazarSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this._btnYazarSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnYazarSil.ImageIndex = 12;
            this._btnYazarSil.ImageList = this.ımageList1;
            this._btnYazarSil.Location = new System.Drawing.Point(318, 20);
            this._btnYazarSil.Name = "_btnYazarSil";
            this._btnYazarSil.Size = new System.Drawing.Size(118, 37);
            this._btnYazarSil.TabIndex = 1;
            this._btnYazarSil.Text = "Sil";
            this._btnYazarSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._btnYazarSil.UseVisualStyleBackColor = true;
            this._btnYazarSil.Click += new System.EventHandler(this._btnYazarSil_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this._dbGridYazarlar);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox4.Location = new System.Drawing.Point(487, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.groupBox4.Size = new System.Drawing.Size(305, 409);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Yazarlar";
            // 
            // _dbGridYazarlar
            // 
            this._dbGridYazarlar.AllowUserToAddRows = false;
            this._dbGridYazarlar.AllowUserToDeleteRows = false;
            this._dbGridYazarlar.AllowUserToResizeRows = false;
            this._dbGridYazarlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._dbGridYazarlar.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this._dbGridYazarlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dbGridYazarlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dbGridYazarlar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this._dbGridYazarlar.Location = new System.Drawing.Point(3, 16);
            this._dbGridYazarlar.MultiSelect = false;
            this._dbGridYazarlar.Name = "_dbGridYazarlar";
            this._dbGridYazarlar.ReadOnly = true;
            this._dbGridYazarlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dbGridYazarlar.Size = new System.Drawing.Size(299, 373);
            this._dbGridYazarlar.TabIndex = 1;
            this._dbGridYazarlar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dbGridYazarlar_CellClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this._txtYazarAdiAra);
            this.groupBox5.Controls.Add(this._btnYazarAra);
            this.groupBox5.Location = new System.Drawing.Point(234, 62);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(243, 118);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Arama İşlemleri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Aranacak isim";
            // 
            // _txtYazarAdiAra
            // 
            this._txtYazarAdiAra.Location = new System.Drawing.Point(104, 33);
            this._txtYazarAdiAra.Name = "_txtYazarAdiAra";
            this._txtYazarAdiAra.Size = new System.Drawing.Size(133, 20);
            this._txtYazarAdiAra.TabIndex = 5;
            // 
            // _btnYazarAra
            // 
            this._btnYazarAra.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this._btnYazarAra.ImageIndex = 14;
            this._btnYazarAra.ImageList = this.ımageList1;
            this._btnYazarAra.Location = new System.Drawing.Point(153, 66);
            this._btnYazarAra.Name = "_btnYazarAra";
            this._btnYazarAra.Size = new System.Drawing.Size(84, 39);
            this._btnYazarAra.TabIndex = 4;
            this._btnYazarAra.Text = "   Ara";
            this._btnYazarAra.UseVisualStyleBackColor = true;
            this._btnYazarAra.Click += new System.EventHandler(this._btnYazarAra_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox8);
            this.tabPage4.Controls.Add(this.groupBox6);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.groupBox20);
            this.tabPage4.ImageIndex = 0;
            this.tabPage4.Location = new System.Drawing.Point(4, 37);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(792, 409);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Kategori";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this._txtKategoriAdi);
            this.groupBox8.Location = new System.Drawing.Point(24, 87);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(369, 58);
            this.groupBox8.TabIndex = 24;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Kategori Bilgisi/Adı";
            // 
            // _txtKategoriAdi
            // 
            this._txtKategoriAdi.Location = new System.Drawing.Point(15, 26);
            this._txtKategoriAdi.Name = "_txtKategoriAdi";
            this._txtKategoriAdi.Size = new System.Drawing.Size(318, 20);
            this._txtKategoriAdi.TabIndex = 9;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this._btnKategoriSil);
            this.groupBox6.Controls.Add(this._btnKategoriEkle);
            this.groupBox6.Location = new System.Drawing.Point(24, 151);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(369, 64);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "İşlemler";
            // 
            // _btnKategoriSil
            // 
            this._btnKategoriSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnKategoriSil.ImageIndex = 12;
            this._btnKategoriSil.ImageList = this.ımageList1;
            this._btnKategoriSil.Location = new System.Drawing.Point(198, 16);
            this._btnKategoriSil.Name = "_btnKategoriSil";
            this._btnKategoriSil.Size = new System.Drawing.Size(161, 40);
            this._btnKategoriSil.TabIndex = 1;
            this._btnKategoriSil.Text = "Kategori Sil";
            this._btnKategoriSil.UseVisualStyleBackColor = true;
            this._btnKategoriSil.Click += new System.EventHandler(this._btnKategoriSil_Click);
            // 
            // _btnKategoriEkle
            // 
            this._btnKategoriEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnKategoriEkle.ImageIndex = 1;
            this._btnKategoriEkle.ImageList = this.ımageList1;
            this._btnKategoriEkle.Location = new System.Drawing.Point(19, 15);
            this._btnKategoriEkle.Name = "_btnKategoriEkle";
            this._btnKategoriEkle.Size = new System.Drawing.Size(162, 40);
            this._btnKategoriEkle.TabIndex = 0;
            this._btnKategoriEkle.Text = "Kategori Ekle";
            this._btnKategoriEkle.UseVisualStyleBackColor = true;
            this._btnKategoriEkle.Click += new System.EventHandler(this._btnKategoriEkle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(108, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 26);
            this.label5.TabIndex = 27;
            this.label5.Text = "Kategori Ekle/ Sil";
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this._dbGridKategoriler);
            this.groupBox20.Location = new System.Drawing.Point(410, 3);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(374, 382);
            this.groupBox20.TabIndex = 24;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Kategoriler";
            // 
            // _dbGridKategoriler
            // 
            this._dbGridKategoriler.AllowUserToAddRows = false;
            this._dbGridKategoriler.AllowUserToDeleteRows = false;
            this._dbGridKategoriler.AllowUserToResizeRows = false;
            this._dbGridKategoriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._dbGridKategoriler.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this._dbGridKategoriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dbGridKategoriler.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dbGridKategoriler.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this._dbGridKategoriler.Location = new System.Drawing.Point(3, 16);
            this._dbGridKategoriler.MultiSelect = false;
            this._dbGridKategoriler.Name = "_dbGridKategoriler";
            this._dbGridKategoriler.ReadOnly = true;
            this._dbGridKategoriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dbGridKategoriler.Size = new System.Drawing.Size(368, 363);
            this._dbGridKategoriler.TabIndex = 23;
            this._dbGridKategoriler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dbGridKategoriler_CellClick);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox11);
            this.tabPage5.Controls.Add(this.groupBox10);
            this.tabPage5.Controls.Add(this.groupBox17);
            this.tabPage5.ImageIndex = 8;
            this.tabPage5.Location = new System.Drawing.Point(4, 37);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(792, 409);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "YayınEvi";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this._btnYayinEviSil);
            this.groupBox11.Controls.Add(this._btnYayinEviKaydet);
            this.groupBox11.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox11.Location = new System.Drawing.Point(437, 0);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(355, 82);
            this.groupBox11.TabIndex = 22;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "İşlemler";
            // 
            // _btnYayinEviSil
            // 
            this._btnYayinEviSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnYayinEviSil.ImageIndex = 12;
            this._btnYayinEviSil.ImageList = this.ımageList1;
            this._btnYayinEviSil.Location = new System.Drawing.Point(204, 22);
            this._btnYayinEviSil.Name = "_btnYayinEviSil";
            this._btnYayinEviSil.Size = new System.Drawing.Size(127, 40);
            this._btnYayinEviSil.TabIndex = 1;
            this._btnYayinEviSil.Text = "YayınEvi Sil";
            this._btnYayinEviSil.UseVisualStyleBackColor = true;
            this._btnYayinEviSil.Click += new System.EventHandler(this._btnYayinEviSil_Click);
            // 
            // _btnYayinEviKaydet
            // 
            this._btnYayinEviKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnYayinEviKaydet.ImageIndex = 0;
            this._btnYayinEviKaydet.ImageList = this.ımageList1;
            this._btnYayinEviKaydet.Location = new System.Drawing.Point(27, 22);
            this._btnYayinEviKaydet.Name = "_btnYayinEviKaydet";
            this._btnYayinEviKaydet.Size = new System.Drawing.Size(162, 40);
            this._btnYayinEviKaydet.TabIndex = 0;
            this._btnYayinEviKaydet.Text = "Yayınevi Ekle";
            this._btnYayinEviKaydet.UseVisualStyleBackColor = true;
            this._btnYayinEviKaydet.Click += new System.EventHandler(this._btnYayinEviKaydet_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label7);
            this.groupBox10.Controls.Add(this.label6);
            this.groupBox10.Controls.Add(this._cmbAdresBilgisi);
            this.groupBox10.Controls.Add(this._txtYayinEviAdi);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox10.Location = new System.Drawing.Point(0, 0);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(389, 82);
            this.groupBox10.TabIndex = 24;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Yayın Evi/Bilgiler";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(199, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Adres Bilgisi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = " Adı";
            // 
            // _cmbAdresBilgisi
            // 
            this._cmbAdresBilgisi.FormattingEnabled = true;
            this._cmbAdresBilgisi.Location = new System.Drawing.Point(202, 37);
            this._cmbAdresBilgisi.Name = "_cmbAdresBilgisi";
            this._cmbAdresBilgisi.Size = new System.Drawing.Size(145, 21);
            this._cmbAdresBilgisi.TabIndex = 29;
            // 
            // _txtYayinEviAdi
            // 
            this._txtYayinEviAdi.Location = new System.Drawing.Point(30, 38);
            this._txtYayinEviAdi.Name = "_txtYayinEviAdi";
            this._txtYayinEviAdi.Size = new System.Drawing.Size(145, 20);
            this._txtYayinEviAdi.TabIndex = 28;
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this._dbGridYayinEvleri);
            this.groupBox17.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox17.Location = new System.Drawing.Point(0, 82);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Padding = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.groupBox17.Size = new System.Drawing.Size(792, 327);
            this.groupBox17.TabIndex = 25;
            this.groupBox17.TabStop = false;
            // 
            // _dbGridYayinEvleri
            // 
            this._dbGridYayinEvleri.AllowUserToAddRows = false;
            this._dbGridYayinEvleri.AllowUserToDeleteRows = false;
            this._dbGridYayinEvleri.AllowUserToResizeRows = false;
            this._dbGridYayinEvleri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._dbGridYayinEvleri.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this._dbGridYayinEvleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dbGridYayinEvleri.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dbGridYayinEvleri.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this._dbGridYayinEvleri.Location = new System.Drawing.Point(3, 16);
            this._dbGridYayinEvleri.MultiSelect = false;
            this._dbGridYayinEvleri.Name = "_dbGridYayinEvleri";
            this._dbGridYayinEvleri.ReadOnly = true;
            this._dbGridYayinEvleri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dbGridYayinEvleri.Size = new System.Drawing.Size(786, 291);
            this._dbGridYayinEvleri.TabIndex = 23;
            this._dbGridYayinEvleri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dbGridYayinEvleri_CellClick);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.groupBox13);
            this.tabPage6.Controls.Add(this.groupBox12);
            this.tabPage6.ImageIndex = 11;
            this.tabPage6.Location = new System.Drawing.Point(4, 37);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(792, 409);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "EmananetKitaplar";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this._dbGridEmanet);
            this.groupBox13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox13.Location = new System.Drawing.Point(0, 100);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Padding = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.groupBox13.Size = new System.Drawing.Size(792, 309);
            this.groupBox13.TabIndex = 1;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Emanet Listesi";
            // 
            // _dbGridEmanet
            // 
            this._dbGridEmanet.AllowUserToAddRows = false;
            this._dbGridEmanet.AllowUserToDeleteRows = false;
            this._dbGridEmanet.AllowUserToResizeRows = false;
            this._dbGridEmanet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._dbGridEmanet.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this._dbGridEmanet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dbGridEmanet.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dbGridEmanet.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this._dbGridEmanet.Location = new System.Drawing.Point(3, 16);
            this._dbGridEmanet.MultiSelect = false;
            this._dbGridEmanet.Name = "_dbGridEmanet";
            this._dbGridEmanet.ReadOnly = true;
            this._dbGridEmanet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dbGridEmanet.Size = new System.Drawing.Size(786, 273);
            this._dbGridEmanet.TabIndex = 0;
            this._dbGridEmanet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dbGridEmanet_CellClick);
            this._dbGridEmanet.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this._dbGridEmanet_CellFormatting);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this._btnEGeriAl);
            this.groupBox12.Controls.Add(this._btnEmanetVer);
            this.groupBox12.Controls.Add(this.label11);
            this.groupBox12.Controls.Add(this.label10);
            this.groupBox12.Controls.Add(this.label9);
            this.groupBox12.Controls.Add(this.label8);
            this.groupBox12.Controls.Add(this._dtepicturTelsimTa);
            this.groupBox12.Controls.Add(this._dtepicturVerilisTa);
            this.groupBox12.Controls.Add(this._cmbVerilenKitap);
            this.groupBox12.Controls.Add(this._cmbKitapveruye);
            this.groupBox12.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox12.Location = new System.Drawing.Point(0, 0);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(792, 94);
            this.groupBox12.TabIndex = 0;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Emanet ver";
            // 
            // _btnEGeriAl
            // 
            this._btnEGeriAl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnEGeriAl.ImageIndex = 7;
            this._btnEGeriAl.ImageList = this.ımageList1;
            this._btnEGeriAl.Location = new System.Drawing.Point(654, 30);
            this._btnEGeriAl.Name = "_btnEGeriAl";
            this._btnEGeriAl.Size = new System.Drawing.Size(120, 39);
            this._btnEGeriAl.TabIndex = 1;
            this._btnEGeriAl.Text = "Geri Al";
            this._btnEGeriAl.UseVisualStyleBackColor = true;
            this._btnEGeriAl.Click += new System.EventHandler(this._btnEGeriAl_Click);
            // 
            // _btnEmanetVer
            // 
            this._btnEmanetVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnEmanetVer.ImageIndex = 6;
            this._btnEmanetVer.ImageList = this.ımageList1;
            this._btnEmanetVer.Location = new System.Drawing.Point(532, 30);
            this._btnEmanetVer.Name = "_btnEmanetVer";
            this._btnEmanetVer.Size = new System.Drawing.Size(116, 39);
            this._btnEmanetVer.TabIndex = 0;
            this._btnEmanetVer.Text = "     Emanet Ver";
            this._btnEmanetVer.UseVisualStyleBackColor = true;
            this._btnEmanetVer.Click += new System.EventHandler(this._btnEmanetVer_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(308, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Teslim Tarihi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(308, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Veriliş Tarihi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(155, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Verilen Kitap";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Kitap verilecek üye";
            // 
            // _dtepicturTelsimTa
            // 
            this._dtepicturTelsimTa.Location = new System.Drawing.Point(311, 24);
            this._dtepicturTelsimTa.Name = "_dtepicturTelsimTa";
            this._dtepicturTelsimTa.Size = new System.Drawing.Size(156, 20);
            this._dtepicturTelsimTa.TabIndex = 4;
            // 
            // _dtepicturVerilisTa
            // 
            this._dtepicturVerilisTa.Enabled = false;
            this._dtepicturVerilisTa.Location = new System.Drawing.Point(311, 67);
            this._dtepicturVerilisTa.Name = "_dtepicturVerilisTa";
            this._dtepicturVerilisTa.Size = new System.Drawing.Size(156, 20);
            this._dtepicturVerilisTa.TabIndex = 3;
            // 
            // _cmbVerilenKitap
            // 
            this._cmbVerilenKitap.FormattingEnabled = true;
            this._cmbVerilenKitap.Location = new System.Drawing.Point(158, 46);
            this._cmbVerilenKitap.Name = "_cmbVerilenKitap";
            this._cmbVerilenKitap.Size = new System.Drawing.Size(133, 21);
            this._cmbVerilenKitap.TabIndex = 1;
            // 
            // _cmbKitapveruye
            // 
            this._cmbKitapveruye.FormattingEnabled = true;
            this._cmbKitapveruye.Location = new System.Drawing.Point(21, 46);
            this._cmbKitapveruye.Name = "_cmbKitapveruye";
            this._cmbKitapveruye.Size = new System.Drawing.Size(121, 21);
            this._cmbKitapveruye.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.groupBox16);
            this.tabPage7.Controls.Add(this.groupBox15);
            this.tabPage7.ImageIndex = 1;
            this.tabPage7.Location = new System.Drawing.Point(4, 37);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(792, 409);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Kütüphaneler";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this._dbGridKutuphaneler);
            this.groupBox16.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox16.Location = new System.Drawing.Point(217, 3);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Padding = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.groupBox16.Size = new System.Drawing.Size(572, 403);
            this.groupBox16.TabIndex = 35;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Kütüphaneler";
            // 
            // _dbGridKutuphaneler
            // 
            this._dbGridKutuphaneler.AllowUserToAddRows = false;
            this._dbGridKutuphaneler.AllowUserToDeleteRows = false;
            this._dbGridKutuphaneler.AllowUserToResizeRows = false;
            this._dbGridKutuphaneler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._dbGridKutuphaneler.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this._dbGridKutuphaneler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dbGridKutuphaneler.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dbGridKutuphaneler.Location = new System.Drawing.Point(3, 16);
            this._dbGridKutuphaneler.MultiSelect = false;
            this._dbGridKutuphaneler.Name = "_dbGridKutuphaneler";
            this._dbGridKutuphaneler.ReadOnly = true;
            this._dbGridKutuphaneler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dbGridKutuphaneler.Size = new System.Drawing.Size(566, 367);
            this._dbGridKutuphaneler.TabIndex = 0;
            this._dbGridKutuphaneler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dbGridKutuphaneler_CellClick);
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this._btnKutuphaneGuncelle);
            this.groupBox15.Controls.Add(this.label12);
            this.groupBox15.Controls.Add(this.label1);
            this.groupBox15.Controls.Add(this._txtKutuphaneAdi);
            this.groupBox15.Controls.Add(this._cmbKutuphaneAdres);
            this.groupBox15.Controls.Add(this._btnKutuphaneEkle);
            this.groupBox15.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox15.Location = new System.Drawing.Point(3, 3);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(208, 403);
            this.groupBox15.TabIndex = 34;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = " Ekle / Güncelle";
            // 
            // _btnKutuphaneGuncelle
            // 
            this._btnKutuphaneGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this._btnKutuphaneGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnKutuphaneGuncelle.ImageIndex = 11;
            this._btnKutuphaneGuncelle.ImageList = this.ımageList1;
            this._btnKutuphaneGuncelle.Location = new System.Drawing.Point(30, 219);
            this._btnKutuphaneGuncelle.Name = "_btnKutuphaneGuncelle";
            this._btnKutuphaneGuncelle.Size = new System.Drawing.Size(142, 46);
            this._btnKutuphaneGuncelle.TabIndex = 36;
            this._btnKutuphaneGuncelle.Text = "Güncelle";
            this._btnKutuphaneGuncelle.UseVisualStyleBackColor = true;
            this._btnKutuphaneGuncelle.Click += new System.EventHandler(this._btnKutuphaneGuncelle_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Kütüphane Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Adres:";
            // 
            // _txtKutuphaneAdi
            // 
            this._txtKutuphaneAdi.Location = new System.Drawing.Point(30, 50);
            this._txtKutuphaneAdi.Name = "_txtKutuphaneAdi";
            this._txtKutuphaneAdi.Size = new System.Drawing.Size(142, 20);
            this._txtKutuphaneAdi.TabIndex = 32;
            // 
            // _cmbKutuphaneAdres
            // 
            this._cmbKutuphaneAdres.FormattingEnabled = true;
            this._cmbKutuphaneAdres.Location = new System.Drawing.Point(30, 101);
            this._cmbKutuphaneAdres.Name = "_cmbKutuphaneAdres";
            this._cmbKutuphaneAdres.Size = new System.Drawing.Size(142, 21);
            this._cmbKutuphaneAdres.TabIndex = 33;
            // 
            // _btnKutuphaneEkle
            // 
            this._btnKutuphaneEkle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this._btnKutuphaneEkle.ImageIndex = 8;
            this._btnKutuphaneEkle.ImageList = this.ımageList1;
            this._btnKutuphaneEkle.Location = new System.Drawing.Point(30, 153);
            this._btnKutuphaneEkle.Name = "_btnKutuphaneEkle";
            this._btnKutuphaneEkle.Size = new System.Drawing.Size(142, 46);
            this._btnKutuphaneEkle.TabIndex = 31;
            this._btnKutuphaneEkle.Text = "  Kütüphane Ekle";
            this._btnKutuphaneEkle.UseVisualStyleBackColor = true;
            this._btnKutuphaneEkle.Click += new System.EventHandler(this._btnKutuphaneEkle_Click);
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripMenuItem,
            this.açToolStripMenuItem,
            this.toolStripSeparator,
            this.kaydetToolStripMenuItem,
            this.farklıKaydetToolStripMenuItem,
            this.toolStripSeparator1,
            this.yazdırToolStripMenuItem,
            this.baskıÖnizlemeToolStripMenuItem,
            this.toolStripSeparator2,
            this.çıkışToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "&Dosya";
            // 
            // yeniToolStripMenuItem
            // 
            this.yeniToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yeniToolStripMenuItem.Image")));
            this.yeniToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            this.yeniToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.yeniToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.yeniToolStripMenuItem.Text = "Y&eni";
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("açToolStripMenuItem.Image")));
            this.açToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.açToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.açToolStripMenuItem.Text = "&Aç";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(151, 6);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kaydetToolStripMenuItem.Image")));
            this.kaydetToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.kaydetToolStripMenuItem.Text = "&Kaydet";
            // 
            // farklıKaydetToolStripMenuItem
            // 
            this.farklıKaydetToolStripMenuItem.Name = "farklıKaydetToolStripMenuItem";
            this.farklıKaydetToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.farklıKaydetToolStripMenuItem.Text = "&Farklı Kaydet";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
            // 
            // yazdırToolStripMenuItem
            // 
            this.yazdırToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yazdırToolStripMenuItem.Image")));
            this.yazdırToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.yazdırToolStripMenuItem.Name = "yazdırToolStripMenuItem";
            this.yazdırToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.yazdırToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.yazdırToolStripMenuItem.Text = "Y&azdır";
            // 
            // baskıÖnizlemeToolStripMenuItem
            // 
            this.baskıÖnizlemeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("baskıÖnizlemeToolStripMenuItem.Image")));
            this.baskıÖnizlemeToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.baskıÖnizlemeToolStripMenuItem.Name = "baskıÖnizlemeToolStripMenuItem";
            this.baskıÖnizlemeToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.baskıÖnizlemeToolStripMenuItem.Text = "&Baskı Önizleme";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(151, 6);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.çıkışToolStripMenuItem.Text = "Çı&kış";
            // 
            // düzenToolStripMenuItem
            // 
            this.düzenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geriAlToolStripMenuItem,
            this.yineleToolStripMenuItem,
            this.toolStripSeparator3,
            this.kesToolStripMenuItem,
            this.kopyalaToolStripMenuItem,
            this.yapıştırToolStripMenuItem,
            this.toolStripSeparator4,
            this.tümünüSeçToolStripMenuItem});
            this.düzenToolStripMenuItem.Name = "düzenToolStripMenuItem";
            this.düzenToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.düzenToolStripMenuItem.Text = "D&üzen";
            // 
            // geriAlToolStripMenuItem
            // 
            this.geriAlToolStripMenuItem.Name = "geriAlToolStripMenuItem";
            this.geriAlToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.geriAlToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.geriAlToolStripMenuItem.Text = "&Geri Al";
            // 
            // yineleToolStripMenuItem
            // 
            this.yineleToolStripMenuItem.Name = "yineleToolStripMenuItem";
            this.yineleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.yineleToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.yineleToolStripMenuItem.Text = "Yi&nele";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(155, 6);
            // 
            // kesToolStripMenuItem
            // 
            this.kesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kesToolStripMenuItem.Image")));
            this.kesToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            this.kesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.kesToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.kesToolStripMenuItem.Text = "&Kes";
            // 
            // kopyalaToolStripMenuItem
            // 
            this.kopyalaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kopyalaToolStripMenuItem.Image")));
            this.kopyalaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            this.kopyalaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.kopyalaToolStripMenuItem.Text = "K&opyala";
            // 
            // yapıştırToolStripMenuItem
            // 
            this.yapıştırToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yapıştırToolStripMenuItem.Image")));
            this.yapıştırToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
            this.yapıştırToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.yapıştırToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.yapıştırToolStripMenuItem.Text = "&Yapıştır";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(155, 6);
            // 
            // tümünüSeçToolStripMenuItem
            // 
            this.tümünüSeçToolStripMenuItem.Name = "tümünüSeçToolStripMenuItem";
            this.tümünüSeçToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.tümünüSeçToolStripMenuItem.Text = "&Tümünü Seç";
            // 
            // araçlarToolStripMenuItem
            // 
            this.araçlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.özelleştirToolStripMenuItem,
            this.seçeneklerToolStripMenuItem});
            this.araçlarToolStripMenuItem.Name = "araçlarToolStripMenuItem";
            this.araçlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.araçlarToolStripMenuItem.Text = "&Araçlar";
            // 
            // özelleştirToolStripMenuItem
            // 
            this.özelleştirToolStripMenuItem.Name = "özelleştirToolStripMenuItem";
            this.özelleştirToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.özelleştirToolStripMenuItem.Text = "&Özelleştir";
            // 
            // seçeneklerToolStripMenuItem
            // 
            this.seçeneklerToolStripMenuItem.Name = "seçeneklerToolStripMenuItem";
            this.seçeneklerToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.seçeneklerToolStripMenuItem.Text = "&Seçenekler";
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.içindekilerToolStripMenuItem,
            this.dizinToolStripMenuItem,
            this.araToolStripMenuItem,
            this.toolStripSeparator5,
            this.hakkındaToolStripMenuItem});
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.yardımToolStripMenuItem.Text = "&Yardım";
            // 
            // içindekilerToolStripMenuItem
            // 
            this.içindekilerToolStripMenuItem.Name = "içindekilerToolStripMenuItem";
            this.içindekilerToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.içindekilerToolStripMenuItem.Text = "İçi&ndekiler";
            // 
            // dizinToolStripMenuItem
            // 
            this.dizinToolStripMenuItem.Name = "dizinToolStripMenuItem";
            this.dizinToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.dizinToolStripMenuItem.Text = "Di&zin";
            // 
            // araToolStripMenuItem
            // 
            this.araToolStripMenuItem.Name = "araToolStripMenuItem";
            this.araToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.araToolStripMenuItem.Text = "A&ra";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(130, 6);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.hakkındaToolStripMenuItem.Text = "&Hakkında...";
            // 
            // _statusBar
            // 
            this._statusBar.Location = new System.Drawing.Point(0, 428);
            this._statusBar.Name = "_statusBar";
            this._statusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this._brPnlTarih,
            this._brPnlPencere,
            this._brPnlDurum});
            this._statusBar.ShowPanels = true;
            this._statusBar.Size = new System.Drawing.Size(800, 22);
            this._statusBar.TabIndex = 2;
            this._statusBar.Text = "statusBar2";
            // 
            // _brPnlTarih
            // 
            this._brPnlTarih.Name = "_brPnlTarih";
            this._brPnlTarih.Text = "Tarih:";
            this._brPnlTarih.Width = 150;
            // 
            // _brPnlPencere
            // 
            this._brPnlPencere.Name = "_brPnlPencere";
            this._brPnlPencere.Text = "Açık Pencere:";
            this._brPnlPencere.Width = 270;
            // 
            // _brPnlDurum
            // 
            this._brPnlDurum.Name = "_brPnlDurum";
            this._brPnlDurum.Text = "Durum:";
            this._brPnlDurum.Width = 370;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._statusBar);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kutuphane";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this._uyeler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dbGridUyeler)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dbGridKitaplar)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dbGridYazarlar)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox20.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dbGridKategoriler)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dbGridYayinEvleri)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dbGridEmanet)).EndInit();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.groupBox16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dbGridKutuphaneler)).EndInit();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._brPnlTarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._brPnlPencere)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._brPnlDurum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem farklıKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem yazdırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baskıÖnizlemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geriAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yineleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yapıştırToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tümünüSeçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem özelleştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seçeneklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem içindekilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dizinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox _txtKitapAdiAra;
        private System.Windows.Forms.Button _btnKitapAra;
        private System.Windows.Forms.Button _btnKitapDuzelt;
        private System.Windows.Forms.Button _btnKitapSil;
        private System.Windows.Forms.Button _btnKitapEkle;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView _dbGridYazarlar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _txtYazarAdiAra;
        private System.Windows.Forms.Button _btnYazarAra;
        private System.Windows.Forms.Button _btnYazarDuzelt;
        private System.Windows.Forms.Button _btnYazarSil;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox _txtKategoriAdi;
        private System.Windows.Forms.DataGridView _dbGridKategoriler;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button _btnKategoriSil;
        private System.Windows.Forms.Button _btnKategoriEkle;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _txtYayinEviAdi;
        private System.Windows.Forms.DataGridView _dbGridYayinEvleri;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Button _btnYayinEviSil;
        private System.Windows.Forms.Button _btnYayinEviKaydet;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.DataGridView _dbGridEmanet;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker _dtepicturTelsimTa;
        private System.Windows.Forms.DateTimePicker _dtepicturVerilisTa;
        private System.Windows.Forms.ComboBox _cmbKitapveruye;
        private System.Windows.Forms.Button _btnEGeriAl;
        private System.Windows.Forms.Button _btnEmanetVer;
        public System.Windows.Forms.ComboBox _cmbAdresBilgisi;
        public System.Windows.Forms.DataGridView _dbGridKitaplar;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox _uyeler;
        public System.Windows.Forms.DataGridView _dbGridUyeler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button _btnAdresEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtUyeAra;
        private System.Windows.Forms.Button _btnUyeAra;
        public System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button _btnUyeDuzelt;
        private System.Windows.Forms.Button _btnUyesiSil;
        private System.Windows.Forms.Button _btnUyeEkle;
        private System.Windows.Forms.TabPage tabPage7;
        public System.Windows.Forms.ComboBox _cmbKutuphaneAdres;
        private System.Windows.Forms.TextBox _txtKutuphaneAdi;
        private System.Windows.Forms.Button _btnKutuphaneEkle;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.DataGridView _dbGridKutuphaneler;
        private System.Windows.Forms.Button _btnYazarEkle;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.TextBox _txtYazarSoyad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox _txtYazarAd;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button _btnKutuphaneGuncelle;
        private System.Windows.Forms.StatusBarPanel _brPnlTarih;
        private System.Windows.Forms.StatusBarPanel _brPnlDurum;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.StatusBarPanel _brPnlPencere;
        public System.Windows.Forms.StatusBar _statusBar;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox _cmbVerilenKitap;
    }
}

