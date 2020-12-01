using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurant_cafe
{
    public partial class frmRapor : Form
    {
        public frmRapor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMasadurumu anasayfa = new frmMasadurumu();
            anasayfa.Show();
            this.Hide();
        }

        private void frmRapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantDataSet.rezervasyon' table. You can move, or remove it, as needed.
            this.rezervasyonTableAdapter.Fill(this.restaurantDataSet.rezervasyon);

            this.reportViewer1.RefreshReport();
        }
    }
}
