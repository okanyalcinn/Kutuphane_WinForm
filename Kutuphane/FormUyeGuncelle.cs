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

    public partial class FormUyeGuncelle : Form
    {
        public FormUyeGuncelle()
        {
            InitializeComponent();
        }

        public FormUyeGuncelle(DataGridView _dbGridUyeler)
        {
            InitializeComponent();
            Form1 form1 = new Form1();
            form1.ListeleCombobox(_cmbGAdresSec," VM_AdreslerListele",1);
            satir_no = _dbGridUyeler.CurrentRow.Cells[0].Value.ToString();
            _txtGUyeAdi.Text = _dbGridUyeler.CurrentRow.Cells[1].Value.ToString();
            uyeAdiDegisiklik = false;
            uyeAdi = _txtGUyeAdi.Text;
            _txtGUyeSoyad.Text = _dbGridUyeler.CurrentRow.Cells[2].Value.ToString();
            _txtGUyeTCNo.Text = _dbGridUyeler.CurrentRow.Cells[3].Value.ToString();
            if (_dbGridUyeler.CurrentRow.Cells[4].Value.ToString() == "Erkek")
                _rdbtnGE.Checked = true;
            else
                _rdbtnGK.Checked = true;
            _txtGTelefon.Text = _dbGridUyeler.CurrentRow.Cells[5].Value.ToString();
            _txtGEposta.Text = _dbGridUyeler.CurrentRow.Cells[6].Value.ToString();
            _cmbGAdresSec.SelectedValue = _dbGridUyeler.CurrentRow.Cells[15].Value;
        }

        SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
        string satir_no;
        string uyeAdi;
        string uyeAdiG;
        private void _btnGUyeGirisTemizle_Click(object sender, EventArgs e)
        {
            _txtGEposta.Clear();
            _txtGUyeAdi.Clear();
            _txtGUyeSoyad.Clear();
            _txtGUyeTCNo.Clear();
            _txtGTelefon.Clear();
            _rdbtnGE.Checked = false;
            _rdbtnGK.Checked = false;
            _cmbGAdresSec.SelectedIndex = 0;
        }
        
        
        bool cmbDegisiklik = false;
        private void _cmbGAdresSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDegisiklik = true;
        }        

        private void _btnUyeGuncelle_Click(object sender, EventArgs e)
        {
            int var = 0;
            if (cmbDegisiklik)
            {
                try
                {
                    uyeAdiG = _txtGUyeAdi.Text;
                    baglanti.Open();
                    string sorgu = "SP_UyeDuzelt";                    
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.CommandType = CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@uyeID", satir_no);
                    komut.Parameters.AddWithValue("@uyeadi", _txtGUyeAdi.Text);
                    komut.Parameters.AddWithValue("@uyesoyadi", _txtGUyeSoyad.Text);
                    komut.Parameters.AddWithValue("@tcNo", _txtGUyeTCNo.Text);
                    string c = null;
                    if (_rdbtnGE.Checked == true)
                        c = "Erkek";
                    else
                    if (_rdbtnGK.Checked == true)
                        c = "Kadın";
                    komut.Parameters.AddWithValue("@cinsiyet", c.ToString());
                    komut.Parameters.AddWithValue("@telefon", _txtGTelefon.Text);
                    komut.Parameters.AddWithValue("@eposta", _txtGEposta.Text);
                    komut.Parameters.AddWithValue("@adresID", _cmbGAdresSec.SelectedValue);
                    var = komut.ExecuteNonQuery();
                    MessageBox.Show(var != 0 ? "GÜNCELLEME BAŞARILI" : "GÜNCELLEME BAŞARISIZ");
                    baglanti.Close();
                    komut.Dispose();
                    Form1 f1 = (Form1)Application.OpenForms["Form1"];
                    f1.UyeListele();
                    if (uyeAdiDegisiklik)
                        Form1.durum = "Durum: " + uyeAdi + " adlı üye " + uyeAdiG + " adıyla güncellendi";
                    else
                        Form1.durum = "Durum: " + uyeAdi + " adlı üyenin kaydı güncellendi";
                    uyeAdiDegisiklik = false;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata" + ex);
                    baglanti.Close();
                }
            }
            else
            {
                MessageBox.Show("Adres Seçimi Yap");
            }
        }

        private void FormUyeGuncelle_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Form1.acikP == "Açık Pencere: Üye Bilgileri Güncelleme")
            {
                Form1.acikP = "Açık Pencere:";
            }
        }
        bool uyeAdiDegisiklik = false;
        private void _txtGUyeAdi_TextChanged(object sender, EventArgs e)
        {
            uyeAdiDegisiklik = true;
        }
        
    }
}
