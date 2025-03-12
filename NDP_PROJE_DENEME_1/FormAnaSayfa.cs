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
    public partial class FormAnaSayfa : Form
    {
        public FormAnaSayfa()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormYonetici formYonetici = new FormYonetici();
            formYonetici.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMusteriGiris formMusteriGiris = new FormMusteriGiris();
            formMusteriGiris.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormTedarikciGiris formTedarikciGiris = new FormTedarikciGiris();
            formTedarikciGiris.Show();
            this.Hide();
        }
    }
}
