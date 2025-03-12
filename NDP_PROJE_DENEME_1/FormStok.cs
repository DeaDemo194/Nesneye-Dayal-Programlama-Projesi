using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDP_PROJE_DENEME_1
{
    public partial class FormStok : Form
    {
        public FormStok()
        {
            InitializeComponent();
        }

        private void FormStok_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'magazaVeriTabaniDataSet4.Table_Urun' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.table_UrunTableAdapter.Fill(this.magazaVeriTabaniDataSet4.Table_Urun);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormYonetici formYonetici = new FormYonetici();
            formYonetici.Show();
            this.Close();
        }
    }
}
