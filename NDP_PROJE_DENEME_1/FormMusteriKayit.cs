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
    public partial class FormMusteriKayit : Form
    {
        public FormMusteriKayit()
        {
            InitializeComponent();
        }
        SqlBaglanti baglanti = new SqlBaglanti();

        private void FormMusteriKayit_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Table_Musteri (musteriAd,musteriSoyad,musteriCinsiyet,musteriYas,musteriSifre) values (@p1,@p2,@p3,@p4,@p5)", baglanti.sqlBaglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbCinsiyet.Text);
            komut.Parameters.AddWithValue("@p4", txtYas.Text);
            komut.Parameters.AddWithValue("@p5", txtSifre.Text);
            komut.ExecuteNonQuery();
            baglanti.sqlBaglanti().Close();
            MessageBox.Show("Kaydınız Başarıyla Yapıldı.");
            this.Close();
        }
    }
}
