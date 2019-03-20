using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Kutuphane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// cellClick işlemi için kullanılır
        /// </summary>
        /// <param name="dtGrid">data grid view nesnesini gönder</param>
        /// <param name="satir"> satir numarasını almak için değişkeni gönder</param>
        public void DataGridBasmaOlayi(DataGridView dtGrid, ref int satir)
        {
            int dataCount = dtGrid.Rows.Count - 1;
            if (dtGrid.CurrentRow.Index <= dataCount)
            {
                satir = Convert.ToInt32(dtGrid.CurrentRow.Cells[0].Value);
                if (yayinEvi)
                {
                    _txtYayinEviAdi.Text = _dbGridYayinEvleri.CurrentRow.Cells[1].Value.ToString();
                }
            }
            else
                satir = -1;
        }

        SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
        public DataSet dataSet = new DataSet();
        int satir_no = -1;
        FormKitapEkle formkitapekle = new FormKitapEkle();
        static public string acikP = "Açık Pencere:";
        static public string durum = "Durum:";

        private void Form1_Load(object sender, EventArgs e)
        {
            ListeleCombobox(_cmbKitapveruye, "VM_ComboboxUyeListele", 1);
            ListeleCombobox(_cmbAdresBilgisi, "VM_AdreslerListele", 1);
            ListeleCombobox(_cmbKutuphaneAdres, "VM_AdreslerListele", 1);
            ListeleCombobox(_cmbVerilenKitap, "VM_KitaplarListele", 2);
            UyeListele();
            KitapListele();
            KutuphaneListele();
            YayineviListele();
            SadeceListele("Yazarlar", _dbGridYazarlar);
            SadeceListele("Kategoriler", _dbGridKategoriler);
            EmanetListele();
            tarihGuncelle();
        }

        #region methodlar
        /// <summary>
        /// stored procedure ile arama methodu
        /// </summary>
        /// <param name="sorgu">SP sorgusu gönder</param>
        /// <param name="aranacaSutun"></param>
        /// <param name="textBox"></param>
        /// <param name="dtGrid"></param>
        public void AramaStoredProcedure(string sorgu, string aranacakSutun, TextBox textBox, DataGridView dtGrid)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sorgu, baglanti);
            DataTable data = new DataTable();
            dataAdapter.SelectCommand.Parameters.AddWithValue(aranacakSutun, textBox.Text);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.Fill(data);
            dtGrid.Columns.Clear();
            dtGrid.DataSource = data;
            dataAdapter.Dispose();
            baglanti.Close();
            dtGrid.Refresh();
            dtGrid.Update();
            dtGrid.Columns[0].Visible = false;
        }
        /// <summary>
        /// genel listeleme methodu
        /// </summary>
        /// <param name="sorgu"></param>
        /// <param name="dataGrid"></param>
        public void Listeleme(string sorgu, DataGridView dataGrid)
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sorgu, baglanti);
                DataTable data = new DataTable();
                dataAdapter.Fill(data);
                dataGrid.DataSource = data;
                dataAdapter.Dispose();
                baglanti.Close();
                dataGrid.Refresh();
                dataGrid.Update();
                dataGrid.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir şey oldu" + ex);
                baglanti.Close();
            }
        }
        /// <summary>
        /// Sadece Sil Başka İhsan İstemem
        /// </summary>
        /// <param name="nesilmek">ne kaydı sileceksiniz.Sizin için bir örnek.Buyrun:Yazar</param>
        /// <param name="sorgu">SP parametresi gönderirseniz güzel olur.</param>
        /// <param name="silID">sql silinecek id parametresi.Sizin için bir örnek.Buyrun:"@silinecekID" </param>
        /// <param name="satir">Satir_no gönderirseniz güzel olur.</param>
        private void SadeceSil(string nesilmek, string sorgu, string silID, int satir)
        {
            DialogResult sonuc = MessageBox.Show(nesilmek + " silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.Yes)
            {
                try
                {
                    SqlCommand Sil = new SqlCommand(sorgu, baglanti);
                    Sil.CommandType = CommandType.StoredProcedure;
                    Sil.Parameters.AddWithValue(silID, satir);
                    baglanti.Open();
                    Sil.ExecuteNonQuery();
                    MessageBox.Show(nesilmek + " Silindi");
                    Sil.Dispose();
                    baglanti.Close();
                    durum = "Durum: " + nesilmek + " silindi";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir şey oldu" + ex);
                    baglanti.Close();
                }
            }
        }

        /// <summary>
        /// genel listeleme metodu
        /// </summary>
        /// <param name="tabloismi">listelenecek tablonun ismi</param>
        /// <param name="gridView">listelenecek dataGridView nesnesi</param>
        private void SadeceListele(string tabloismi, DataGridView gridView)
        {
            try
            {
                baglanti.Open();
                string sorgu = "select * from " + tabloismi;
                SqlDataAdapter sqlSorgu = new SqlDataAdapter(sorgu, baglanti);
                sqlSorgu.Fill(dataSet, tabloismi);
                gridView.DataSource = dataSet.Tables[tabloismi];
                gridView.Columns[0].Visible = false;
                sqlSorgu.Dispose();
                gridView.Refresh();
                gridView.Update();
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex);
                baglanti.Close();
            }
        }
        public void ListeleCombobox(ComboBox comboBox, string vm_sorgu, int sutundegeri)
        {
            try
            {
                baglanti.Open();
                SqlCommand sqlcmd = new SqlCommand("SELECT * FROM " + vm_sorgu, baglanti);
                SqlDataAdapter sda = new SqlDataAdapter(sqlcmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                comboBox.ValueMember = dt.Columns[0].ColumnName;
                comboBox.DisplayMember = dt.Columns[sutundegeri].ColumnName;
                comboBox.DataSource = dt;
                sda.Dispose();
                sqlcmd.Dispose();
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir şey oldu" + ex);
                baglanti.Close();
            }
        }
        #endregion

        #region üyeler
        public void UyeListele()
        {
            Listeleme("select* From  VM_UyelerListele", _dbGridUyeler);
            _dbGridUyeler.Columns[1].HeaderText = "Üye Adi";
        }
        private void _btnUyesiSil_Click(object sender, EventArgs e)
        {
            SadeceSil("Üye kaydını", "SP_UyeSil", "@silinecekID", satir_no);
            UyeListele();
        }

        bool uyeSecimi = false;
        private void _dbGridUyeler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridBasmaOlayi(_dbGridUyeler, ref satir_no);

            uyeSecimi = true;
        }
        private void _btnUyeDuzelt_Click(object sender, EventArgs e)
        {
            if (uyeSecimi)
            {
                FormUyeGuncelle uyeGuncelle = new FormUyeGuncelle(_dbGridUyeler);
                uyeGuncelle.Show();
                uyeSecimi = false;
                acikP = "Açık Pencere: Üye Bilgileri Güncelleme";
                _brPnlPencere.Text = acikP;
            }
            else
            {
                MessageBox.Show("Önce üye seçimi yapınız");
            }
        }
        private void _btnUyeAra_Click(object sender, EventArgs e)
        {
            AramaStoredProcedure("SP_UyeAra", "@uyeAdi", _txtUyeAra, _dbGridUyeler);
        }
        private void _btnUyeEkle_Click(object sender, EventArgs e)
        {
            FormYeniKayit formYeni = new FormYeniKayit();
            formYeni.Show();
            acikP = "Açık Pencere: Üye ekle";
            _brPnlPencere.Text = acikP;
        }
        #endregion

        #region kitaplar
        private void _btnKitapEkle_Click(object sender, EventArgs e)
        {
            FormKitapEkle kitapEkle = new FormKitapEkle();
            kitapEkle.Show();
            acikP = "Açık Pencere: Kitap ekle";
            _brPnlPencere.Text = acikP;
        }

        public void KitapListele()
        {
            baglanti.Open();
            string sorgu = "select * From  VM_KitaplarListele";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sorgu, baglanti);
            DataTable data = new DataTable();
            dataAdapter.Fill(data);
            _dbGridKitaplar.DataSource = data;
            _dbGridKitaplar.Refresh();
            _dbGridKitaplar.Update();
            _dbGridKitaplar.Columns[0].Visible = false;
            dataAdapter.Dispose();
            baglanti.Close();
        }
        bool uyeVarMi = false;
        private void _btnKitapSil_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < _dbGridEmanet.RowCount; i++)
            {
                if (Convert.ToInt32(_dbGridEmanet.Rows[i].Cells[2].Value) == satir_no)
                {
                    MessageBox.Show("Kitap hala bir üyede duruyor");
                    uyeVarMi = true;
                    break;
                }
            }

            if (!uyeVarMi && satir_no != -1)
            {
                SadeceSil("Kitap kaydı", "SP_KitapSil", "@silinecekID", satir_no);
                KitapListele();
            }
            uyeVarMi = false;
            if (satir_no == -1)
            {
                MessageBox.Show("Kitap seçmelisiniz");
            }
        }

        private void _dbGridKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridBasmaOlayi(_dbGridKitaplar, ref satir_no);
        }

        private void _btnKitapDuzelt_Click(object sender, EventArgs e)
        {
            FormKitapDuzelt kitapDuzelt = new FormKitapDuzelt(_dbGridKitaplar);
            kitapDuzelt.Show();
            acikP = "Açık Pencere: Kitap Bilgileri Güncelleme";
            _brPnlPencere.Text = acikP;
        }

        private void _btnKitapAra_Click(object sender, EventArgs e)
        {
            AramaStoredProcedure("SP_KitapAra", "@kitapAdi", _txtKitapAdiAra, _dbGridKitaplar);
        }
        #endregion

        #region yazarlar
        private void _btnYazarEkle_Click(object sender, EventArgs e)
        {
            int var = 0;
            try
            {
                baglanti.Open();
                string sorgu = "SP_YazarEkle";
                SqlCommand kategoriEkle = new SqlCommand(sorgu, baglanti);
                kategoriEkle.CommandType = CommandType.StoredProcedure;
                kategoriEkle.Parameters.AddWithValue("@yazarAd", _txtYazarAd.Text);
                kategoriEkle.Parameters.AddWithValue("@yazarSoyad", _txtYazarSoyad.Text);
                var = kategoriEkle.ExecuteNonQuery();
                MessageBox.Show(var != 0 ? "İŞLEM BAŞARILI" : "İŞLEM BAŞARISIZ");
                baglanti.Close();
                dataSet.Tables["Yazarlar"].Clear();
                SadeceListele("Yazarlar", _dbGridYazarlar);
                _dbGridYazarlar.Refresh();
                _dbGridYazarlar.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                baglanti.Close();
            }
        }

        private void _btnYazarSil_Click(object sender, EventArgs e)
        {
            SadeceSil("Yazar", "SP_YazarSil", "@silinecekID", satir_no);
            dataSet.Tables["Yazarlar"].Clear();
            SadeceListele("Yazarlar", _dbGridYazarlar);
            _txtYazarAd.Clear();
            _txtYazarSoyad.Clear();
        }

        private void _dbGridYazarlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridBasmaOlayi(_dbGridYazarlar, ref satir_no);
            _txtYazarAd.Text = _dbGridYazarlar.CurrentRow.Cells[1].Value.ToString();
            _txtYazarSoyad.Text = _dbGridYazarlar.CurrentRow.Cells[2].Value.ToString();

        }

        private void _btnYazarTemizle_Click(object sender, EventArgs e)
        {
            _txtYazarAd.Clear();
            _txtYazarSoyad.Clear();

        }

        private void _btnYazarDuzelt_Click(object sender, EventArgs e)
        {
            int var = 0;
            try
            {
                baglanti.Open();
                string sorgu = "SP_YazarDuzelt";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@ID", satir_no);
                komut.Parameters.AddWithValue("@yazarAd", _txtYazarAd.Text);
                komut.Parameters.AddWithValue("@yazarSoyad", _txtYazarSoyad.Text);
                var = komut.ExecuteNonQuery();
                MessageBox.Show(var != 0 ? "GÜNCELLEME BAŞARILI" : "GÜNCELLEME BAŞARISIZ");
                baglanti.Close();
                komut.Dispose();
                dataSet.Tables["Yazarlar"].Clear();
                SadeceListele("Yazarlar", _dbGridYazarlar);
                durum = "Durum: Yazar güncellendi";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata" + ex);
                baglanti.Close();
            }
        }

        private void _btnYazarAra_Click(object sender, EventArgs e)
        {
            AramaStoredProcedure("SP_YazarAra", "@yazarAdi", _txtYazarAdiAra, _dbGridYazarlar);
        }
        #endregion

        #region kategoriler
        private void _btnKategoriEkle_Click(object sender, EventArgs e)
        {
            int var = 0;
            try
            {
                baglanti.Open();
                string sorgu = "SP_KategoriEkle";
                SqlCommand kategoriEkle = new SqlCommand(sorgu, baglanti);
                kategoriEkle.CommandType = CommandType.StoredProcedure;
                kategoriEkle.Parameters.AddWithValue("@KategoriAd", _txtKategoriAdi.Text);
                var = kategoriEkle.ExecuteNonQuery();
                MessageBox.Show(var != 0 ? "İŞLEM BAŞARILI" : "İŞLEM BAŞARISIZ");
                baglanti.Close();
                dataSet.Tables["Kategoriler"].Clear();
                SadeceListele("Kategoriler", _dbGridKategoriler);
                _dbGridKategoriler.Refresh();
                _dbGridKategoriler.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                baglanti.Close();
            }
        }
        private void _btnKategoriSil_Click(object sender, EventArgs e)
        {
            SadeceSil("Kategori", "SP_KategoriSil", "@silinecekID", satir_no);
            _txtKategoriAdi.Clear();
            dataSet.Tables["Kategoriler"].Clear();
            SadeceListele("Kategoriler", _dbGridKategoriler);
            _dbGridKategoriler.Refresh();
        }
        private void _dbGridKategoriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridBasmaOlayi(_dbGridKategoriler, ref satir_no);
            _txtKategoriAdi.Text = _dbGridKategoriler.CurrentRow.Cells[1].Value.ToString();
        }
        #endregion

        #region yayın evleri
        public void YayineviListele()
        {
            Listeleme("select* From  VM_YayineviListele", _dbGridYayinEvleri);
            _dbGridYayinEvleri.Columns[0].Visible = false;
            _dbGridYayinEvleri.Columns[2].Visible = false;
        }

        private void _btnYayinEviKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string sorgu = "SP_YayinEviEkle";
                SqlCommand yayiEviEkle = new SqlCommand(sorgu, baglanti);
                yayiEviEkle.CommandType = CommandType.StoredProcedure;
                yayiEviEkle.Parameters.AddWithValue("@yayinEviAdi", _txtYayinEviAdi.Text);
                yayiEviEkle.Parameters.AddWithValue("@adresID", _cmbAdresBilgisi.SelectedValue);
                baglanti.Open();
                yayiEviEkle.ExecuteNonQuery();
                MessageBox.Show("Kayıt Yapıldı");
                baglanti.Close();
                YayineviListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                baglanti.Close();
            }
        }

        private void _btnYayinEviSil_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Yayın evini silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            try
            {
                if (sonuc == DialogResult.Yes)
                {
                    string yayinEviAdi = _txtYayinEviAdi.Text;
                    string sorgu = "DELETE FROM YayinEvleri WHERE yayinEviID='" + satir_no + "'";
                    SqlCommand ysil = new SqlCommand(sorgu, baglanti);
                    baglanti.Open();
                    ysil.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Silindi");
                    ysil.Dispose();
                    baglanti.Close();
                    YayineviListele();
                    _txtYayinEviAdi.Clear();
                    _cmbAdresBilgisi.SelectedIndex = 0;
                    durum = "Durum: " + yayinEviAdi + " adlı yayın evi silindi";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Yayınevi silinirken hata oluştu. Olası durum yayınevine ait kitap bilgisi bulunmakta");
                baglanti.Close();
            }
        }

        bool yayinEvi = false;
        private void _dbGridYayinEvleri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            yayinEvi = true;
            DataGridBasmaOlayi(_dbGridYayinEvleri, ref satir_no);
        }
        #endregion

        #region emanet kitaplar
        string GunFarki;
        public void EmanetListele()
        {
            baglanti.Open();
            string sorgu = "select * From  VM_EmanetListe";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sorgu, baglanti);
            DataTable data = new DataTable();
            dataAdapter.Fill(data);
            _dbGridEmanet.DataSource = data;
            _dbGridEmanet.Columns[0].Visible = false;
            _dbGridEmanet.Columns[2].Visible = false;
            _dbGridEmanet.Columns[6].ReadOnly = true;
            _dbGridEmanet.Columns[7].Visible = false;
            _dbGridEmanet.Refresh();
            _dbGridEmanet.Update();
            dataAdapter.Dispose();
            baglanti.Close();
        }
        private void tarihGuncelle()
        {
            for (int i = 0; i < _dbGridEmanet.RowCount - 1; i++)
            {
                if (Convert.ToBoolean(_dbGridEmanet.Rows[i].Cells[6].Value) == true)
                {
                    TimeSpan tsTarihFarki = Convert.ToDateTime(_dbGridEmanet.Rows[i].Cells[5].Value) - DateTime.Now;
                    GunFarki = (tsTarihFarki.Days).ToString();
                    if (GunFarki != "0")
                    {
                        int ilk = Convert.ToInt32(GunFarki);
                        GunFarki = (ilk + 1).ToString();
                    }
                }
                else
                {
                    GunFarki = "Teslim edildi";
                }
                try
                {
                    string sorgu = "SP_EmanettarihDuzelt";
                    SqlCommand emanetSorgu = new SqlCommand(sorgu, baglanti);
                    emanetSorgu.CommandType = CommandType.StoredProcedure;
                    emanetSorgu.Parameters.AddWithValue("@uyeID", _dbGridEmanet.Rows[i].Cells[0].Value);
                    emanetSorgu.Parameters.AddWithValue("@kitapID", _dbGridEmanet.Rows[i].Cells[2].Value);
                    emanetSorgu.Parameters.AddWithValue("@emanetID", _dbGridEmanet.Rows[i].Cells[7].Value);
                    emanetSorgu.Parameters.AddWithValue("@tarihfark", GunFarki);
                    baglanti.Open();
                    emanetSorgu.ExecuteNonQuery();
                    baglanti.Close();
                    emanetSorgu.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                    baglanti.Close();
                }
            }
            EmanetListele();
        }

        private void _btnEmanetVer_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < _dbGridEmanet.RowCount; i++)
            {
                if (Convert.ToInt32(_cmbVerilenKitap.SelectedValue) == Convert.ToInt32(_dbGridEmanet.Rows[i].Cells[2].Value))
                {
                    MessageBox.Show("Kitap başka bir üyede!");
                    break;
                }
                else
                {
                    TimeSpan tsTarihFarki = Convert.ToDateTime(_dtepicturTelsimTa.Value) - Convert.ToDateTime(DateTime.Now.ToLongDateString());
                    GunFarki = (tsTarihFarki.Days).ToString();
                    int var = 0;
                    try
                    {
                        string uyeAdi = _cmbKitapveruye.Text;
                        string kitap = _cmbVerilenKitap.Text;
                        string sorgu = "SP_EmanetEkle";
                        SqlCommand emanetSorgu = new SqlCommand(sorgu, baglanti);
                        emanetSorgu.CommandType = CommandType.StoredProcedure;
                        emanetSorgu.Parameters.AddWithValue("@uyeID", _cmbKitapveruye.SelectedValue);
                        emanetSorgu.Parameters.AddWithValue("@kitapID", _cmbVerilenKitap.SelectedValue);
                        emanetSorgu.Parameters.AddWithValue("@emanetTarihi", _dtepicturVerilisTa.Value);
                        emanetSorgu.Parameters.AddWithValue("@teslimTarihi", _dtepicturTelsimTa.Value);
                        emanetSorgu.Parameters.AddWithValue("@teslimDurum", 1);
                        emanetSorgu.Parameters.AddWithValue("@tarihfark", GunFarki);
                        baglanti.Open();
                        var = emanetSorgu.ExecuteNonQuery();
                        MessageBox.Show(var != 0 ? "Kayıt Yapıldı" : "Kayıt Yapılmadı", "", MessageBoxButtons.OK);
                        baglanti.Close();
                        emanetSorgu.Dispose();
                        EmanetListele();
                        durum = "Durum: " + uyeAdi + " adlı kişiye " + kitap + " isimli kitap verildi";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                        baglanti.Close();
                    }
                }
            }
        }

        private void _btnEGeriAl_Click(object sender, EventArgs e)
        {
            int var = 0;
            try
            {
                string sorgu = "SP_EmanetSil";
                SqlCommand emanetSorgu = new SqlCommand(sorgu, baglanti);
                emanetSorgu.CommandType = CommandType.StoredProcedure;
                emanetSorgu.Parameters.AddWithValue("@uyeID", emanetUyeID);
                emanetSorgu.Parameters.AddWithValue("@kitapID", emanetKitapID);
                emanetSorgu.Parameters.AddWithValue("@emanetID", emanetID);
                emanetSorgu.Parameters.AddWithValue("@teslimDurum", 0);
                baglanti.Open();
                var = emanetSorgu.ExecuteNonQuery();
                MessageBox.Show(var != 0 ? "Kitap teslim alındı" : "Uye seçimi yapınız", "", MessageBoxButtons.OK);
                baglanti.Close();
                emanetSorgu.Dispose();
                EmanetListele();
                tarihGuncelle();
                durum = emanetUyeAdi + " adlı üyeden " + emanetKitapAdi + " isimli kitap geri alındı";
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                baglanti.Close();
            }
        }

        int emanetUyeID;
        string emanetUyeAdi;
        int emanetKitapID;
        string emanetKitapAdi;
        int emanetID;

        private void _dbGridEmanet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dataCount = _dbGridEmanet.Rows.Count - 1;
            if (_dbGridEmanet.CurrentRow.Index <= dataCount)
            {
                emanetUyeID = Convert.ToInt32(_dbGridEmanet.CurrentRow.Cells[0].Value);
                emanetUyeAdi = _dbGridEmanet.CurrentRow.Cells[1].Value.ToString();
                emanetKitapID = Convert.ToInt32(_dbGridEmanet.CurrentRow.Cells[2].Value);
                emanetKitapAdi = _dbGridEmanet.CurrentRow.Cells[3].Value.ToString();
                emanetID = Convert.ToInt32(_dbGridEmanet.CurrentRow.Cells[7].Value);
            }
            else
            {
                emanetUyeID = -1;
                emanetKitapID = -1;
                emanetID = -1;
                emanetUyeAdi = null;
                emanetKitapAdi = null;
            }
        }
        private void _dbGridEmanet_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < _dbGridEmanet.RowCount - 1; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if (Convert.ToInt32(_dbGridEmanet.Rows[i].Cells[6].Value) == 1)
                {
                    if (Convert.ToInt32(_dbGridEmanet.Rows[i].Cells["tarihfark"].Value) <= 0)
                    {
                        renk.BackColor = Color.Black;
                        renk.ForeColor = Color.White;
                    }
                    else if (Convert.ToInt32(_dbGridEmanet.Rows[i].Cells["tarihfark"].Value) <= 5)
                    {
                        renk.BackColor = Color.Red;
                    }
                    else if (Convert.ToInt32(_dbGridEmanet.Rows[i].Cells["tarihfark"].Value) <= 15)
                    {
                        renk.BackColor = Color.Yellow;
                    }
                    else
                    {
                        renk.BackColor = Color.Green;
                    }
                }
                else
                {
                    renk.BackColor = Color.White;
                }
                _dbGridEmanet.Rows[i].DefaultCellStyle = renk;
            }
        }
        private void _btnYenileEmanet_Click(object sender, EventArgs e)
        {
            EmanetListele();
            tarihGuncelle();
        }
        #endregion

        #region kütüphaneler

        public void KutuphaneListele()
        {
            Listeleme("select* From  VM_KutuphaneListele", _dbGridKutuphaneler);
            _dbGridKutuphaneler.Columns[0].Visible = false;
            _dbGridKutuphaneler.Columns[2].Visible = false;
        }

        private void _btnKutuphaneEkle_Click(object sender, EventArgs e)
        {
            int var = 0;
            try
            {
                string sorgu = "SP_KutuphaneEkle";
                SqlCommand kutuphaneEkle = new SqlCommand(sorgu, baglanti);
                kutuphaneEkle.CommandType = CommandType.StoredProcedure;
                kutuphaneEkle.Parameters.AddWithValue("@kutuphaneAdi", _txtKutuphaneAdi.Text);
                kutuphaneEkle.Parameters.AddWithValue("@adresID", _cmbKutuphaneAdres.SelectedValue);
                baglanti.Open();
                var = kutuphaneEkle.ExecuteNonQuery();
                MessageBox.Show(var != 0 ? "Kayıt yapıldı" : "Kayıt başarısız oldu ", "Mesaj", MessageBoxButtons.OK);
                baglanti.Close();
                _dbGridKutuphaneler.Refresh();
                _dbGridKutuphaneler.Update();
                KutuphaneListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                baglanti.Close();
            }
        }

        private void _dbGridKutuphaneler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridBasmaOlayi(_dbGridKutuphaneler, ref satir_no);
            _txtKutuphaneAdi.Text = _dbGridKutuphaneler.CurrentRow.Cells[1].Value.ToString();
            _cmbKutuphaneAdres.SelectedValue = _dbGridKutuphaneler.CurrentRow.Cells[2].Value;
        }
        private void _btnKutuphaneGuncelle_Click(object sender, EventArgs e)
        {
            int var = 0;
            try
            {
                baglanti.Open();
                string sorgu = "SP_KutuphaneDuzelt";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@ID", satir_no);
                komut.Parameters.AddWithValue("@kutuphaneAd", _txtKutuphaneAdi.Text);
                komut.Parameters.AddWithValue("@adresID", _cmbKutuphaneAdres.SelectedValue);
                var = komut.ExecuteNonQuery();
                MessageBox.Show(var != 0 ? "GÜNCELLEME BAŞARILI" : "GÜNCELLEME BAŞARISIZ");
                baglanti.Close();
                komut.Dispose();
                SadeceListele("Kutuphane", _dbGridKutuphaneler);
                durum = "Durum: Kütüphane güncellendi";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata" + ex);
                baglanti.Close();
            }
        }

        #endregion

        #region adresler
        private void _btnAdresEkle_Click(object sender, EventArgs e)
        {
            FormAdresEkle formAdresEkle = new FormAdresEkle();
            formAdresEkle.Show();
            acikP = "Açık Pencere: Adresler";
        }


        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            _brPnlTarih.Text = " " + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();
            _brPnlPencere.Text = acikP;
            _brPnlDurum.Text = durum;
        }
    }
}

