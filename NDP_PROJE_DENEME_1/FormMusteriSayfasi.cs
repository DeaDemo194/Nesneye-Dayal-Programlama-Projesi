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
    public partial class FormMusteriSayfasi : Form
    {
        public FormMusteriSayfasi()
        {
            InitializeComponent();
        }
        public string ad;
        SqlBaglanti baglanti = new SqlBaglanti();
        void listele()
        {
            this.table_UrunTableAdapter.Fill(this.magazaVeriTabaniDataSet1.Table_Urun);
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Table_Satis where musteriNo=" + lblMusteriNo.Text, baglanti.sqlBaglanti());
            dataAdapter.Fill(dataTable);
            dataGridView2.DataSource = dataTable;
        }
        private void FormMusteriSayfasi_Load(object sender, EventArgs e)
        {
            //Müşteri Bilgisi
            lblAd.Text = ad;
            SqlCommand komut = new SqlCommand("select musteriNo from Table_Musteri where musteriAd=@p1", baglanti.sqlBaglanti());
            komut.Parameters.AddWithValue("@p1", lblAd.Text);
            SqlDataReader dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                lblMusteriNo.Text = dataReader[0].ToString();
            }
            baglanti.sqlBaglanti().Close();
            listele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
         
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtUrunKod.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            lblUrunAdi.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            lblUrunSize.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtTutar.Text = (Convert.ToInt32(dataGridView1.Rows[secilen].Cells[3].Value.ToString()) * Convert.ToInt32(txtAdet.Text)).ToString();
            txtStok.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void btnSatınAl_Click(object sender, EventArgs e)
        {
            //Eğer
            if (Convert.ToInt32(txtStok.Text) - Convert.ToInt32(txtAdet.Text) >= 0)
            {
                SqlCommand komutSatinAl = new SqlCommand("update Table_Urun set urunStok=@p1 where urunKod=@p2", baglanti.sqlBaglanti());
                komutSatinAl.Parameters.AddWithValue("@p1", Convert.ToInt32(txtStok.Text) - Convert.ToInt32(txtAdet.Text));
                komutSatinAl.Parameters.AddWithValue("@p2", txtUrunKod.Text);
                komutSatinAl.ExecuteNonQuery();
                SqlCommand komutSatisKaydet = new SqlCommand("insert into Table_Satis (urunAdi,urunSize,urunAdet,urunTutar,musteriNo,musteriAd) values (@k1,@k2,@k3,@k4,@k5,@k6)", baglanti.sqlBaglanti());
                komutSatisKaydet.Parameters.AddWithValue("@k1", lblUrunAdi.Text);
                komutSatisKaydet.Parameters.AddWithValue("@k2", lblUrunSize.Text);
                komutSatisKaydet.Parameters.AddWithValue("@k3", txtAdet.Text);
                komutSatisKaydet.Parameters.AddWithValue("@k4", txtTutar.Text);
                komutSatisKaydet.Parameters.AddWithValue("@k5", lblMusteriNo.Text);
                komutSatisKaydet.Parameters.AddWithValue("@k6", lblAd.Text);
                komutSatisKaydet.ExecuteNonQuery();
                baglanti.sqlBaglanti().Close();
                listele();
            }
            else
            {
                MessageBox.Show("Ürün, istediğiniz sayıda stokta bulunmamaktadır. Lütfen stoktaki kadar adet giriniz!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMusteriGiris musteriGiris = new FormMusteriGiris();
            musteriGiris.Show();
            this.Close();
        }
    }
}
