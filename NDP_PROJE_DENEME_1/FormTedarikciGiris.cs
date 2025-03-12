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
    public partial class FormTedarikciGiris : Form
    {
        public FormTedarikciGiris()
        {
            InitializeComponent();
        }
        SqlBaglanti baglanti = new SqlBaglanti();

        private void FormTedarikciGiris_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormTedarikciKayit formTedarikciKayit = new FormTedarikciKayit();
            formTedarikciKayit.Show();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Table_Tedarikci where tedarikciAd=@p1 and tedarikciSifre=@p2", baglanti.sqlBaglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dataReader = komut.ExecuteReader();
            if (dataReader.Read())
            {
                FormTedarikciSayfasi formTedarikciSayfasi = new FormTedarikciSayfasi();
                formTedarikciSayfasi.ad = txtAd.Text;
                formTedarikciSayfasi.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız!");
            }
            baglanti.sqlBaglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAnaSayfa formAnaSayfa = new FormAnaSayfa();
            formAnaSayfa.Show();
            this.Close();
        }
    }
}
