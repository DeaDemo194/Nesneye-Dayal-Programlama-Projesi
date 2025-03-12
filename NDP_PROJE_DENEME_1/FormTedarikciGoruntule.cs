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
    public partial class FormTedarikciGoruntule : Form
    {
        public FormTedarikciGoruntule()
        {
            InitializeComponent();
        }
        SqlBaglanti baglanti = new SqlBaglanti();
        void listele()
        {
            this.table_TedarikciTableAdapter.Fill(this.magazaVeriTabaniDataSet3.Table_Tedarikci);
        }
        private void FormTedarikciGoruntule_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            lblTedarikciNo.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            listele();
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Tbl_Siparis where tedarikciNo=" + lblTedarikciNo.Text, baglanti.sqlBaglanti());
            dataAdapter.Fill(dataTable);
            dataGridView2.DataSource = dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormYonetici formYonetici = new FormYonetici();
            formYonetici.Show();
            this.Close();
        }
    }
}
