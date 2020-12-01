using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace restaurant_cafe
{
    public partial class frmGiris : Form
    {
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\restaurant.mdb");
        

        public frmGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string sifre, kulad;
            if (baglan.State == ConnectionState.Closed) baglan.Open();
            string seckomutu = "SELECT kullanici_adi, sifre  FROM kullanici WHERE kullanici_adi='" + tbkullanici.Text + "'";
            OleDbCommand cmd = new OleDbCommand(seckomutu, baglan);
            OleDbDataReader dr = cmd.ExecuteReader();
             try
            {
                dr.Read();
                sifre = dr["sifre"].ToString();
                kulad = dr["kullanici_adi"].ToString();
                if (kulad == tbkullanici.Text & sifre == tbsifre.Text)
                {
                    baglan.Close();
                    frmMasadurumu Anasayfa = new frmMasadurumu();
                    Anasayfa.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış");
                    tbsifre.Text = "";
                    tbsifre.Focus();
                    AcceptButton = btnGiris;
                }
                baglan.Close();
            }
            catch
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış");
                tbkullanici.Clear();
                tbsifre.Clear();
                tbkullanici.Focus();
                AcceptButton = btnGiris;

            }
        

        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {
            tbkullanici.Focus();
        }



       

       
    }
}
