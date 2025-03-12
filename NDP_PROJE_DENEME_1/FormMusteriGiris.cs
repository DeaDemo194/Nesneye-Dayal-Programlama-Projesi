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
    public partial class FormMusteriGiris : Form
    {
        public FormMusteriGiris()
        {
            InitializeComponent();
        }
        SqlBaglanti baglanti = new SqlBaglanti();

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormMusteriKayit formMusteriKayit = new FormMusteriKayit();
            formMusteriKayit.Show();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Table_Musteri where musteriAd=@p1 and musteriSifre=@p2", baglanti.sqlBaglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dataReader = komut.ExecuteReader();
            if (dataReader.Read())
            {
                FormMusteriSayfasi formMusteriSayfasi = new FormMusteriSayfasi();
                formMusteriSayfasi.ad = txtAd.Text;
                formMusteriSayfasi.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız!");
            }
            baglanti.sqlBaglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAnaSayfa formAnaSayfa = new FormAnaSayfa();
            formAnaSayfa.Show();
            this.Close();
        }

        private void FormMusteriGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
