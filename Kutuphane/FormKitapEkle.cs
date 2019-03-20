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
    public partial class FormKitapEkle : Form
    {
        public FormKitapEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
        public DataSet dataSet = new DataSet();

        private void _btnYeniKitapEkle_Click(object sender, EventArgs e)
        {
            if (_txtISBNNo.Text != "" && _txtKitapAdi.Text != "" && _nmSayfaSayisi.Value != 0)
            {
                int var = 0;
                try
                {
                    string sorgu = "SP_KitapEkle";
                    SqlCommand kitapSorgu = new SqlCommand(sorgu, baglanti);
                    kitapSorgu.CommandType = CommandType.StoredProcedure;
                    kitapSorgu.Parameters.AddWithValue("@isbnno", _txtISBNNo.Text);
                    kitapSorgu.Parameters.AddWithValue("@kitapadi", _txtKitapAdi.Text);
                    kitapSorgu.Parameters.AddWithValue("@yayinTarihi", _dtTimePicture.Value);
                    kitapSorgu.Parameters.AddWithValue("@sayfaSayisi", Convert.ToInt32(_nmSayfaSayisi.Value));
                    kitapSorgu.Parameters.AddWithValue("@yayineviID", _cmbYayinEvi.SelectedValue);
                    kitapSorgu.Parameters.AddWithValue("@KutuphaneID", _cmbKutuphanesi.SelectedValue);
                    kitapSorgu.Parameters.AddWithValue("@KategoriID", _cmbKategoriler.SelectedValue);
                    kitapSorgu.Parameters.AddWithValue("@yazarID", _cmbYazarAdi.SelectedValue);
                    baglanti.Open();
                    var = kitapSorgu.ExecuteNonQuery();
                    MessageBox.Show(var != 0 ? "Kayıt Yapıldı" : "Kayıt Yapılmadı", "", MessageBoxButtons.OK);
                    baglanti.Close();
                    kitapSorgu.Dispose();
                    Form1 f1 = (Form1)Application.OpenForms["Form1"];
                    f1.KitapListele();
                    Form1.durum = "Durum: " + _txtKitapAdi.Text + " adlı kitap eklendi";
                    f1.ListeleCombobox(f1._cmbVerilenKitap, "VM_KitaplarListele", 2);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                    baglanti.Close();
                }
            }
            else
            {
                MessageBox.Show("Boş alanları doldurunuz.");
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

        public void TumKayitlar(string sorgu, ComboBox combo)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sorgu, baglanti);
            baglanti.Open();
            SqlCommand sql = new SqlCommand();
            sql.Connection = baglanti;
            sql.CommandText = sorgu;
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            SqlDataReader oku = sql.ExecuteReader();
            while (oku.Read())
            {
                //cambobaxa deger tablodan degerelri cektik
                combo.DataSource = dataTable;
                //yayın evi id
                combo.ValueMember = dataTable.Columns[0].ColumnName;
                //yayın evi adı
                combo.DisplayMember = dataTable.Columns[1].ColumnName;
            }
            baglanti.Close();
        }

        private void FormKitapEkle_Load_1(object sender, EventArgs e)
        {
            TumKayitlar("select * from Yazarlar", _cmbYazarAdi);
            TumKayitlar("select * from Kategoriler", _cmbKategoriler);
            TumKayitlar("select * from Kutuphane", _cmbKutuphanesi);
            TumKayitlar("select * from Yayinevleri", _cmbYayinEvi);
        }

        private void FormKitapEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form = new Form1();
            form.KitapListele();
            form._dbGridKitaplar.Refresh();
            form._dbGridKitaplar.Update();
            if (Form1.acikP == "Açık Pencere: Kitap ekle")
            {
                Form1.acikP = "Açık Pencere:";
            }
        }

        private void FormKitapEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form = new Form1();
            form.KitapListele();
            form._dbGridKitaplar.Refresh();
            form._dbGridKitaplar.Update();
        }
    }
}
