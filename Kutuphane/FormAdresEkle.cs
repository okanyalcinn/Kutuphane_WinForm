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


    public partial class FormAdresEkle : Form
    {
        public FormAdresEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
        public DataSet dataSet = new DataSet();

        private void AdresKaydet()
        {
            try
            {
                string sorgu = "INSERT INTO [dbo].[Adresler]([cadde],[sokak],[mahalle] ,[binaNo],[kat],[postakodu],[il],[ilce])  VALUES(@cadde,@sokak,@mahalle,@numbinano,@numkatno,@postakodu,@il,@ilce)";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@cadde", _txtCadde.Text);
                komut.Parameters.AddWithValue("@sokak", _txtSokak.Text);
                komut.Parameters.AddWithValue("@mahalle", _txtMahalle.Text);
                komut.Parameters.AddWithValue("@numbinano", Convert.ToInt32(_numBinaNO.Text));
                komut.Parameters.AddWithValue("@numkatno", Convert.ToInt32(_numKatNo.Text));
                komut.Parameters.AddWithValue("@postakodu", Convert.ToInt32(_txtPostaKodu.Text));
                komut.Parameters.AddWithValue("@il", _txtIl.Text);
                komut.Parameters.AddWithValue("@ilce", _txtIlce.Text);
                baglanti.Open();
                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt Yapıldı");
                baglanti.Close();
                Form1.durum = "Durum: Yeni bir adres eklendi";
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                baglanti.Close();
            }
        }

        private void _btAdresKaydet_Click(object sender, EventArgs e)
        {
            dataSet.Tables["Adresler"].Clear();
            AdresKaydet();
            Listele();
            _lblAdresNo.Text = "-1";
            _txtCadde.Text = "";
            _txtSokak.Text = "";
            _txtMahalle.Text = "";
            _numBinaNO.Text = "";
            _numKatNo.Text = "";
            _txtPostaKodu.Text = "";
            _txtIl.Text = "";
            _txtIlce.Text = "";
        }

        private void Listele()
        {
            baglanti.Open();
            string sorgu = "select * From Adresler";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sorgu, baglanti);
            dataAdapter.Fill(dataSet, "Adresler");
            _dbAdresListele.DataSource = dataSet.Tables["Adresler"];
            _dbAdresListele.Columns[0].Visible = false;
            dataAdapter.Dispose();
            baglanti.Close();
        }


        private void FormAdresEkle_Load(object sender, EventArgs e)
        {
            _lblAdresNo.Text = "-1";
            Listele();
            _dbAdresListele.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void _dbAdresListele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seciliSatır = Convert.ToInt32(_dbAdresListele.CurrentRow.Cells[0].Value);
            _txtCadde.Text = _dbAdresListele.CurrentRow.Cells[1].Value.ToString();
            _txtSokak.Text = _dbAdresListele.CurrentRow.Cells[2].Value.ToString();
            _txtMahalle.Text = _dbAdresListele.CurrentRow.Cells[3].Value.ToString();
            _numBinaNO.Text = _dbAdresListele.CurrentRow.Cells[4].Value.ToString();
            _numKatNo.Text = _dbAdresListele.CurrentRow.Cells[5].Value.ToString();
            _txtPostaKodu.Text = _dbAdresListele.CurrentRow.Cells[6].Value.ToString();
            _txtIl.Text = _dbAdresListele.CurrentRow.Cells[7].Value.ToString();
            _txtIlce.Text = _dbAdresListele.CurrentRow.Cells[8].Value.ToString();
        }

        private void _btnADresTemizle_Click(object sender, EventArgs e)
        {
            _lblAdresNo.Text = "-1";
            _txtCadde.Text = "";
            _txtSokak.Text = "";
            _txtMahalle.Text = "";
            _numBinaNO.Text = "";
            _numKatNo.Text = "";
            _txtPostaKodu.Text = "";
            _txtIl.Text = "";
            _txtIlce.Text = "";
        }

        private void _btnAdresSil_Click(object sender, EventArgs e)
        {
            _lblAdresNo.Text = _dbAdresListele.CurrentRow.Cells[0].Value.ToString();
            DialogResult cevap;
            cevap = MessageBox.Show("Kaydı silmek istediğinizden eminmisiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "DELETE from Adresler WHERE adresID=@silno ";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@silno", _lblAdresNo.Text);
                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    baglanti.Close();
                    dataSet.Tables["Adresler"].Clear();
                    Listele();
                    _btnADresTemizle_Click(sender, e);
                    Form1.durum = "Durum: Adres Silindi";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: "+ex);
                    baglanti.Close();
                }
            }
        }

        int seciliSatır;
        private void _btnAdresGuncelle_Click(object sender, EventArgs e)
        {
            int var = 0;
            try
            {
                baglanti.Open();
                string sorgu = "UPDATE[dbo].[Adresler]SET[cadde] = @cadde,[sokak] = @sokak,[mahalle] = @mahalle,[binaNo] = @binaNo,[kat] = @katNo,[postaKodu] = @postaKodu,[il] = @il,[ilce] = @ilce WHERE [adresID]=@adresID";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@adresID", seciliSatır);
                komut.Parameters.AddWithValue("@cadde", _txtCadde.Text);
                komut.Parameters.AddWithValue("@sokak", _txtSokak.Text);
                komut.Parameters.AddWithValue("@mahalle", _txtMahalle.Text);
                komut.Parameters.AddWithValue("@binaNo", Convert.ToInt32(_numBinaNO.Text));
                komut.Parameters.AddWithValue("@katNo", Convert.ToInt32(_numKatNo.Text));
                komut.Parameters.AddWithValue("@postaKodu", _txtPostaKodu.Text);
                komut.Parameters.AddWithValue("@il", _txtIl.Text);
                komut.Parameters.AddWithValue("@ilce", _txtIlce.Text);
                var = komut.ExecuteNonQuery();
                MessageBox.Show(var != 0 ? "GÜNCELLEME BAŞARILI" : "GÜNCELLEME BAŞARISIZ");
                baglanti.Close();
                komut.Dispose();
                dataSet.Tables["Adresler"].Clear();
                Listele();
                Form1.durum = "Durum: Adres Güncellendi";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata" + ex);
                baglanti.Close();
            }
        }

        private void FormAdresEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.acikP = "Açık Pencere:";
        }
    }
}
