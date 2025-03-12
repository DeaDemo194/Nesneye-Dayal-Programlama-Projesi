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

namespace NDP_PROJE_DENEME_1
{
    public partial class FormTedarikciSayfasi : Form
    {
        public FormTedarikciSayfasi()
        {
            InitializeComponent();
        }
        public string ad;
        SqlBaglanti baglanti = new SqlBaglanti();
        void listele()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Tbl_Siparis where tedarikciNo=" + lblTedarikciNo.Text, baglanti.sqlBaglanti());
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
        private void FormTedarikciSayfasi_Load(object sender, EventArgs e)
        {
            lblAd.Text = ad;
            SqlCommand komut = new SqlCommand("select tedarikciNo from Table_Tedarikci where tedarikciAd=@p1", baglanti.sqlBaglanti());
            komut.Parameters.AddWithValue("@p1", lblAd.Text);
            SqlDataReader dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                lblTedarikciNo.Text = dataReader[0].ToString();
            }
            baglanti.sqlBaglanti().Close();
            listele();
        }
        
        private void btnUrunKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutKontrol = new SqlCommand("select * from Table_Urun where urunAdi=@p1 and urunSize=@p2 and urunFiyat=@p3", baglanti.sqlBaglanti());
            komutKontrol.Parameters.AddWithValue("@p1",txtUrunAdi.Text);
            komutKontrol.Parameters.AddWithValue("@p2", cmbUrunSize.Text);
            komutKontrol.Parameters.AddWithValue("@p3", txtUrunFiyat.Text);
            SqlDataReader dataReader = komutKontrol.ExecuteReader();
            if (dataReader.Read())
            {
                SqlCommand komutGuncelle = new SqlCommand("update Table_Urun set urunStok=urunStok +@p1 where urunAdi=@p2 and urunSize=@p3 and urunFiyat=@p4", baglanti.sqlBaglanti());
                komutGuncelle.Parameters.AddWithValue("@p1", txtAdet.Text);
                komutGuncelle.Parameters.AddWithValue("@p2", txtUrunAdi.Text);
                komutGuncelle.Parameters.AddWithValue("@p3", cmbUrunSize.Text);
                komutGuncelle.Parameters.AddWithValue("@p4", txtUrunFiyat.Text);
                komutGuncelle.ExecuteNonQuery();
            }
            else
            {
                SqlCommand komut = new SqlCommand("insert into Table_Urun (urunAdi,urunSize,urunFiyat,urunStok) values (@p1,@p2,@p3,@p4)", baglanti.sqlBaglanti());
                komut.Parameters.AddWithValue("@p1", txtUrunAdi.Text);
                komut.Parameters.AddWithValue("@p2", cmbUrunSize.Text);
                komut.Parameters.AddWithValue("@p3", txtUrunFiyat.Text);
                komut.Parameters.AddWithValue("@p4", txtAdet.Text);
                komut.ExecuteNonQuery();
            }
            lblTutar.Text = (Convert.ToInt32(txtAdet.Text) * Convert.ToInt32(txtUrunFiyat.Text)).ToString();
            SqlCommand komutSatisKaydet = new SqlCommand("insert into Tbl_Siparis (urunAdi,urunSize,urunAdet,urunTutar,tedarikciNo,tedarikciAd) values (@k1,@k2,@k3,@k4,@k5,@k6)", baglanti.sqlBaglanti());
            komutSatisKaydet.Parameters.AddWithValue("@k1", txtUrunAdi.Text);
            komutSatisKaydet.Parameters.AddWithValue("@k2", cmbUrunSize.Text);
            komutSatisKaydet.Parameters.AddWithValue("@k3", txtAdet.Text);
            komutSatisKaydet.Parameters.AddWithValue("@k4", lblTutar.Text);
            komutSatisKaydet.Parameters.AddWithValue("@k5", lblTedarikciNo.Text);
            komutSatisKaydet.Parameters.AddWithValue("@k6", lblAd.Text);
            komutSatisKaydet.ExecuteNonQuery();
            baglanti.sqlBaglanti().Close();
            listele();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtUrunAdi.Text = "";
            txtAdet.Text = "";
            txtUrunFiyat.Text = "";
            cmbUrunSize.Text = "";
            txtUrunAdi.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTedarikciGiris formTedarikciGiris = new FormTedarikciGiris();
            formTedarikciGiris.Show();
            this.Close();
        }
    }
}
