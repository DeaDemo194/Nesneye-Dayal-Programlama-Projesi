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
    public partial class FormYonetici : Form
    {
        public FormYonetici()
        {
            InitializeComponent();
        }

        private void FormAnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FormUrun formUrun = new FormUrun();
            //formUrun.Show();
            //this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormMusterileriGoruntule formMusterileriGoruntule = new FormMusterileriGoruntule();
            formMusterileriGoruntule.Show();
            this.Hide();
        }

        private void btnTedarikcileriGrntl_Click(object sender, EventArgs e)
        {
            FormTedarikciGoruntule formTedarikciGoruntule = new FormTedarikciGoruntule();
            formTedarikciGoruntule.Show();
            this.Hide();
        }

        private void btnStokGrntl_Click(object sender, EventArgs e)
        {
            FormStok formStok = new FormStok();
            formStok.Show();
            this.Hide();
        }
    }
}
