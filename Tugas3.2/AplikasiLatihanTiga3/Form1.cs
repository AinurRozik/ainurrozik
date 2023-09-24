using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiLatihanTiga3
{
    public partial class Form1 : Form
    {
        private object cmbPendidikan;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var nama = txtNama.Text;
            var pendidikan = comboBox1.Text;
            var pekerjaan = lstPekerjaan.Text;

            txtPesan1.Text = string.Format("hallo {0}", nama);
            txtPesan2.Text = string.Format("pendidikan anda {0} ya?", pendidikan);
            txtPesan3.Text = string.Format("pendidikan anda {0} ya?", pekerjaan);
        }
    }
}
