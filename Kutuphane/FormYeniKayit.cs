using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Kutuphane
{
    public partial class FormYeniKayit : Form
    {
        public FormYeniKayit()
        {
            InitializeComponent();
            Form1 form=new Form1();
        }
        Form1 form1 = new Form1();
        SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);  

        private void _btnYeniUyeKaydet_Click(object sender, EventArgs e)
        {
            int var = 0;
            try
            {
                baglanti.Open();
                string sorgu = "SP_UyeEkle";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@uyeadi", _txtUyeAdi.Text);
                komut.Parameters.AddWithValue("@uyesoyadi", _txtUyeSoyad.Text);
                komut.Parameters.AddWithValue("@tcNo", _txtUyeTCNo.Text);
                string c = null;
                if (_rdbutonE.Checked == true)
                    c = "Erkek";
                else if (_rdbutonK.Checked == true)
                    c = "Kadın";
                komut.Parameters.AddWithValue("@cinsiyet", c.ToString());
                komut.Parameters.AddWithValue("@telefon", _txtTelefon.Text);
                komut.Parameters.AddWithValue("@eposta", _txtEposta.Text);
                komut.Parameters.AddWithValue("@adresID", _cmbAdresSec.SelectedValue);
                var = komut.ExecuteNonQuery();
                MessageBox.Show(var != 0 ? "KAYIT BAŞARILI" : "KAYIT BAŞARISIZ");
                baglanti.Close();
                Form1 f1 = (Form1)Application.OpenForms["Form1"];
                f1.UyeListele();
                Form1.durum = "Durum: " + _txtUyeAdi.Text + " adlı üye kaydı eklendi";
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                baglanti.Close();
            }
        }
        
        private void FormYeniKayit_Load(object sender, EventArgs e)
        {
            form1.ListeleCombobox(_cmbAdresSec, "VM_AdreslerListele",1);
        }

        private void _btnUyeGirisTemizle_Click(object sender, EventArgs e)
        {
            _txtEposta.Clear();
            _txtTelefon.Clear();
            _txtUyeAdi.Clear();
            _txtUyeSoyad.Clear();
            _txtUyeTCNo.Clear();
            _cmbAdresSec.SelectedIndex = 0;
            _rdbutonE.Checked = false;
            _rdbutonK.Checked = false;
        }
        
        private void _cmbAdresSec_KeyPress(object sender, KeyPressEventArgs e)
        {
            _cmbAdresSec.DroppedDown = false;
        }

        private void FormYeniKayit_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Form1.acikP == "Açık Pencere: Üye ekle")
            {
                Form1.acikP = "Açık Pencere:";
            }
        }
    }
}
