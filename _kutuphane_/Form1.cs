using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _kutuphane_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-A9IP5ML\\SQLEXPRESS;Initial Catalog=Tbl_Kutuphane_;Integrated Security=True");

        void temizle()
        {
            txtKitapİd.Text = "";
            txtAdi.Text = "";
            txtYazar.Text = "";
            mskBaskiYil.Text = "";
            mskSayfa.Text = "";
            cmbDil.Text = "";
            txtYayinEvi.Text = "";
            txtAdi.Focus();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

            this.tbl_Kutuphane_TableAdapter.Fill(this.tbl_Kutuphane_DataSet1.Tbl_Kutuphane_);

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            this.tbl_Kutuphane_TableAdapter.Fill(this.tbl_Kutuphane_DataSet1.Tbl_Kutuphane_);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Kutuphane_ (KitapAd,KitapYazar,KitapYil,KitapSayfa,KitapDil,KitapYayin) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtYazar.Text);
            komut.Parameters.AddWithValue("@p3", mskBaskiYil.Text);
            komut.Parameters.AddWithValue("p4", mskSayfa.Text);
            komut.Parameters.AddWithValue("@p5", cmbDil.Text);
            komut.Parameters.AddWithValue("@p6", txtYayinEvi.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Eklendi");
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtKitapİd.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAdi.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtYazar.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            mskBaskiYil.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskSayfa.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            cmbDil.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtYayinEvi.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_Kutuphane_ Where Kitapid=@k1", baglanti);
            komutsil.Parameters.AddWithValue("@k1", txtKitapİd.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Silindi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("Update Tbl_Kutuphane_ Set KitapAd=@a1,KitapYazar=@a2,KitapYil=@a3,KitapSayfa=@a4,KitapDil=@a5,KitapYayin=@a6 where Kitapid=@a7", baglanti);
            komutguncelle.Parameters.AddWithValue("@a1", txtAdi.Text);
            komutguncelle.Parameters.AddWithValue("@a2", txtYazar.Text);
            komutguncelle.Parameters.AddWithValue("@a3", mskBaskiYil.Text);
            komutguncelle.Parameters.AddWithValue("@a4", mskSayfa.Text);
            komutguncelle.Parameters.AddWithValue("@a5", cmbDil.Text);
            komutguncelle.Parameters.AddWithValue("@a6", txtYayinEvi.Text);
            komutguncelle.Parameters.AddWithValue("@a7", txtKitapİd.Text);
            komutguncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Bilgileri Güncellendi");
        }
    }
}
