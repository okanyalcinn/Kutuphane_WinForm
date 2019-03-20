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

namespace Kutuphane
{
    public partial class FormKitapDuzelt : Form
    {
        public FormKitapDuzelt()
        {
            InitializeComponent();

        }

        public FormKitapDuzelt(DataGridView dbGrid)
        {
            InitializeComponent();
            FormKitapEkle kitapEkle = new FormKitapEkle();
            kitapEkle.TumKayitlar("select * from Yazarlar", _cmbYazarAdi);
            kitapEkle.TumKayitlar("select * from Kategoriler", _cmbKategoriler);
            kitapEkle.TumKayitlar("select * from Kutuphane", _cmbKutuphanesi);
            kitapEkle.TumKayitlar("select * from Yayinevleri", _cmbYayinEvi);

            kitapID = dbGrid.CurrentRow.Cells[0].Value.ToString();
            _txtISBNNo.Text = dbGrid.CurrentRow.Cells[1].Value.ToString();
            _txtKitapAdi.Text = dbGrid.CurrentRow.Cells[2].Value.ToString();
            kitapAdiDegisikligi = false;
            kitapAdi = _txtKitapAdi.Text;
            _nmSayfaSayisi.Value = Convert.ToDecimal(dbGrid.CurrentRow.Cells[3].Value);
            _dtTimePicture.Value = Convert.ToDateTime(dbGrid.CurrentRow.Cells[4].Value);
            _cmbYazarAdi.Text = dbGrid.CurrentRow.Cells[5].Value.ToString();
            _cmbYayinEvi.Text = dbGrid.CurrentRow.Cells[7].Value.ToString();
            _cmbKutuphanesi.Text = dbGrid.CurrentRow.Cells[8].Value.ToString();
            _cmbKategoriler.Text = dbGrid.CurrentRow.Cells[9].Value.ToString();
        }

        SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
        string kitapID;
        string kitapAdi;
        string kitapAdiG;
        private void _btnKitapGuncelle_Click(object sender, EventArgs e)
        {
            int var = 0;
            try
            {
                kitapAdiG = _txtKitapAdi.Text;
                baglanti.Open();
                string sorgu = "SP_KitapDuzelt";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@kitapID", kitapID);
                komut.Parameters.AddWithValue("@kitapAdi", _txtKitapAdi.Text);
                komut.Parameters.AddWithValue("@ISBN", _txtISBNNo.Text);
                komut.Parameters.AddWithValue("@yayinTarihi", _dtTimePicture.Value);
                komut.Parameters.AddWithValue("@sayfaSayisi", Convert.ToInt32(_nmSayfaSayisi.Value));
                komut.Parameters.AddWithValue("@yayineviID", _cmbYayinEvi.SelectedValue);
                komut.Parameters.AddWithValue("@KutuphaneID", _cmbKutuphanesi.SelectedValue);
                komut.Parameters.AddWithValue("@KategoriID", _cmbKategoriler.SelectedValue);
                komut.Parameters.AddWithValue("@yazarID", _cmbYazarAdi.SelectedValue);
                var = komut.ExecuteNonQuery();
                MessageBox.Show(var != 0 ? "GÜNCELLEME BAŞARILI" : "GÜNCELLEME BAŞARISIZ");
                baglanti.Close();
                komut.Dispose();
                Form1 f1 = (Form1)Application.OpenForms["Form1"];
                f1.KitapListele();
                this.Close();
                if (kitapAdiDegisikligi)                
                    Form1.durum = "Durum: "+ kitapAdi +" adlı kitap "+ kitapAdiG + " adıyla güncellendi";    
                else
                    Form1.durum = "Durum: " + kitapAdi+ " adlı kitap bilgileri güncellendi";
                kitapAdiDegisikligi = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata" + ex);
                baglanti.Close();
            }
        }

        private void _btnKitapTemizle_Click(object sender, EventArgs e)
        {
            _txtISBNNo.Clear();
            _txtKitapAdi.Text = "";
            _dtTimePicture.Value = DateTime.Now;
            _nmSayfaSayisi.Value = 0;
            _cmbYayinEvi.SelectedIndex = 0;
        }

        private void FormKitapDuzelt_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Form1.acikP == "Açık Pencere: Kitap Bilgileri Güncelleme")
            {
                Form1.acikP = "Açık Pencere:";
            }
        }

        bool kitapAdiDegisikligi = false;
        private void _txtKitapAdi_TextChanged(object sender, EventArgs e)
        {
            kitapAdiDegisikligi = true;
        }
    }
}
