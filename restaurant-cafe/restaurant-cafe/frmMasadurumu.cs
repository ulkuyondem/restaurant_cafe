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
    public partial class frmMasadurumu : Form
    {
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();  //datasetteki kayıtları forma aktarmak için kullanılır
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\restaurant.mdb");
      
        public frmMasadurumu()
        {
            InitializeComponent();
        }

        public static string gonderilecekveri;

        private void frmMasadurumu_Load(object sender, EventArgs e)
        {
            if (baglan.State == ConnectionState.Closed)
                baglan.Open();
            string seckomutu = "Select * from masalar";
            OleDbCommand com = new OleDbCommand(seckomutu, baglan);
            OleDbDataReader dr1 = com.ExecuteReader();

            while (dr1.Read())
            {
                if (dr1[0].ToString() == button1.Text)
                {
                    label1.Text = dr1[1].ToString();
                    label2.Text = dr1[2].ToString();
                    label3.Text = dr1[3].ToString();


                }
                if (label2.Text == "boş" & label3.Text == "evet")
                {
                    button1.BackColor = Color.Yellow;
                }
                else if (label2.Text == "boş" & label3.Text == "hayır")
                {
                    button1.BackColor = Color.Green;
                }
                if (label2.Text == "dolu")
                {
                    button1.BackColor = Color.Red;
                }
            }

            OleDbCommand com1 = new OleDbCommand(seckomutu, baglan);
            OleDbDataReader dr2 = com1.ExecuteReader();

            while (dr2.Read())
            {
                if (dr2[0].ToString() == button2.Text)
                {
                    label1.Text = dr2[1].ToString();
                    label2.Text = dr2[2].ToString();
                    label3.Text = dr2[3].ToString();


                }
                if (label2.Text == "boş" && label3.Text == "evet")
                {
                    button2.BackColor = Color.Yellow;
                }
                else if (label2.Text == "boş" && label3.Text == "hayır")
                {
                    button2.BackColor = Color.Green;
                }
                if (label2.Text == "dolu")
                {
                    button2.BackColor = Color.Red;
                }
            }
            OleDbCommand com2 = new OleDbCommand(seckomutu, baglan);
            OleDbDataReader dr3 = com2.ExecuteReader();

            while (dr3.Read())
            {
                if (dr3[0].ToString() == button3.Text)
                {
                    label1.Text = dr3[1].ToString();
                    label2.Text = dr3[2].ToString();
                    label3.Text = dr3[3].ToString();


                }
                if (label2.Text == "boş" && label3.Text == "evet")
                {
                    button3.BackColor = Color.Yellow;
                }
                else if (label2.Text == "boş" && label3.Text == "hayır")
                {
                    button3.BackColor = Color.Green;
                }
                if (label2.Text == "dolu")
                {
                    button3.BackColor = Color.Red;
                }
            }
            OleDbCommand com3 = new OleDbCommand(seckomutu, baglan);
            OleDbDataReader dr4 = com3.ExecuteReader();

            while (dr4.Read())
            {
                if (dr4[0].ToString() == button4.Text)
                {
                    label1.Text = dr4[1].ToString();
                    label2.Text = dr4[2].ToString();
                    label3.Text = dr4[3].ToString();


                }
                if (label2.Text == "boş" && label3.Text == "evet")
                {
                    button4.BackColor = Color.Yellow;
                }
                else if (label2.Text == "boş" && label3.Text == "hayır")
                {
                    button4.BackColor = Color.Green;
                }
                if (label2.Text == "dolu")
                {
                    button4.BackColor = Color.Red;
                }
            }

            OleDbCommand com4 = new OleDbCommand(seckomutu, baglan);
            OleDbDataReader dr5 = com4.ExecuteReader();

            while (dr5.Read())
            {
                if (dr5[0].ToString() == button5.Text)
                {
                    label1.Text = dr5[1].ToString();
                    label2.Text = dr5[2].ToString();
                    label3.Text = dr5[3].ToString();


                }
                if (label2.Text == "boş" && label3.Text == "evet")
                {
                    button5.BackColor = Color.Yellow;
                }
                else if (label2.Text == "boş" && label3.Text == "hayır")
                {
                    button5.BackColor = Color.Green;
                }
                if (label2.Text == "dolu")
                {
                    button5.BackColor = Color.Red;
                }
            }
            OleDbCommand com5 = new OleDbCommand(seckomutu, baglan);
            OleDbDataReader dr6 = com5.ExecuteReader();

            while (dr6.Read())
            {
                if (dr6[0].ToString() == button6.Text)
                {
                    label1.Text = dr6[1].ToString();
                    label2.Text = dr6[2].ToString();
                    label3.Text = dr6[3].ToString();


                }
                if (label2.Text == "boş" && label3.Text == "evet")
                {
                    button6.BackColor = Color.Yellow;
                }
                else if (label2.Text == "boş" && label3.Text == "hayır")
                {
                    button6.BackColor = Color.Green;
                }
                if (label2.Text == "dolu")
                {
                    button6.BackColor = Color.Red;
                }
            }
            OleDbCommand com6 = new OleDbCommand(seckomutu, baglan);
            OleDbDataReader dr7 = com6.ExecuteReader();

            while (dr7.Read())
            {
                if (dr7[0].ToString() == button7.Text)
                {
                    label1.Text = dr7[1].ToString();
                    label2.Text = dr7[2].ToString();
                    label3.Text = dr7[3].ToString();


                }
                if (label2.Text == "boş" && label3.Text == "evet")
                {
                    button7.BackColor = Color.Yellow;
                }
                else if (label2.Text == "boş" && label3.Text == "hayır")
                {
                    button7.BackColor = Color.Green;
                }
                if (label2.Text == "dolu")
                {
                    button7.BackColor = Color.Red;
                }
            }
            OleDbCommand com7 = new OleDbCommand(seckomutu, baglan);
            OleDbDataReader dr8 = com7.ExecuteReader();

            while (dr8.Read())
            {
                if (dr8[0].ToString() == button8.Text)
                {
                    label1.Text = dr8[1].ToString();
                    label2.Text = dr8[2].ToString();
                    label3.Text = dr8[3].ToString();


                }
                if (label2.Text == "boş" && label3.Text == "evet")
                {
                    button8.BackColor = Color.Yellow;
                }
                else if (label2.Text == "boş" && label3.Text == "hayır")
                {
                    button8.BackColor = Color.Green;
                }
                if (label2.Text == "dolu")
                {
                    button8.BackColor = Color.Red;
                }
            }
            OleDbCommand com8 = new OleDbCommand(seckomutu, baglan);
            OleDbDataReader dr9 = com8.ExecuteReader();

            while (dr9.Read())
            {
                if (dr9[0].ToString() == button9.Text)
                {
                    label1.Text = dr9[1].ToString();
                    label2.Text = dr9[2].ToString();
                    label3.Text = dr9[3].ToString();


                }
                if (label2.Text == "boş" && label3.Text == "evet")
                {
                    button9.BackColor = Color.Yellow;
                }
                else if (label2.Text == "boş" && label3.Text == "hayır")
                {
                    button9.BackColor = Color.Green;
                }
                if (label2.Text == "dolu")
                {
                    button9.BackColor = Color.Red;
                }
            }

            OleDbCommand com9 = new OleDbCommand(seckomutu, baglan);
            OleDbDataReader dr10 = com9.ExecuteReader();

            while (dr10.Read())
            {
                if (dr10[0].ToString() == button10.Text)
                {
                    label1.Text = dr10[1].ToString();
                    label2.Text = dr10[2].ToString();
                    label3.Text = dr10[3].ToString();


                }
                if (label2.Text == "boş" && label3.Text == "evet")
                {
                    button10.BackColor = Color.Yellow;
                }
                else if (label2.Text == "boş" && label3.Text == "hayır")
                {
                    button10.BackColor = Color.Green;
                }
                if (label2.Text == "dolu")
                {
                    button10.BackColor = Color.Red;
                }
            }

            OleDbCommand com21 = new OleDbCommand(seckomutu, baglan);
            OleDbDataReader dr21 = com21.ExecuteReader();

            while (dr21.Read())
            {
                if (dr21[0].ToString() == button11.Text)
                {
                    label1.Text = dr21[1].ToString();
                    label2.Text = dr21[2].ToString();
                    label3.Text = dr21[3].ToString();


                }
                if (label2.Text == "boş" && label3.Text == "evet")
                {
                    button11.BackColor = Color.Yellow;
                }
                else if (label2.Text == "boş" && label3.Text == "hayır")
                {
                    button11.BackColor = Color.Green;
                }
                if (label2.Text == "dolu")
                {
                    button11.BackColor = Color.Red;
                }
            }


            OleDbCommand com22 = new OleDbCommand(seckomutu, baglan);
            OleDbDataReader dr22 = com22.ExecuteReader();

            while (dr22.Read())
            {
                if (dr22[0].ToString() == button12.Text)
                {
                    label1.Text = dr22[1].ToString();
                    label2.Text = dr22[2].ToString();
                    label3.Text = dr22[3].ToString();


                }
                if (label2.Text == "boş" && label3.Text == "evet")
                {
                    button12.BackColor = Color.Yellow;
                }
                else if (label2.Text == "boş" && label3.Text == "hayır")
                {
                    button12.BackColor = Color.Green;
                }
                if (label2.Text == "dolu")
                {
                    button12.BackColor = Color.Red;
                }
            }

            OleDbCommand com23 = new OleDbCommand(seckomutu, baglan);
            OleDbDataReader dr23 = com23.ExecuteReader();

            while (dr23.Read())
            {
                if (dr23[0].ToString() == button17.Text)
                {
                    label1.Text = dr23[1].ToString();
                    label2.Text = dr23[2].ToString();
                    label3.Text = dr23[3].ToString();


                }
                if (label2.Text == "boş" && label3.Text == "evet")
                {
                    button17.BackColor = Color.Yellow;
                }
                else if (label2.Text == "boş" && label3.Text == "hayır")
                {
                    button17.BackColor = Color.Green;
                }
                if (label2.Text == "dolu")
                {
                    button17.BackColor = Color.Red;
                }
            }

            OleDbCommand com24 = new OleDbCommand(seckomutu, baglan);
            OleDbDataReader dr24 = com24.ExecuteReader();

            while (dr24.Read())
            {
                if (dr24[0].ToString() == button18.Text)
                {
                    label1.Text = dr24[1].ToString();
                    label2.Text = dr24[2].ToString();
                    label3.Text = dr24[3].ToString();


                }
                if (label2.Text == "boş" && label3.Text == "evet")
                {
                    button18.BackColor = Color.Yellow;
                }
                else if (label2.Text == "boş" && label3.Text == "hayır")
                {
                    button18.BackColor = Color.Green;
                }
                if (label2.Text == "dolu")
                {
                    button18.BackColor = Color.Red;
                }
            }

            OleDbCommand com25 = new OleDbCommand(seckomutu, baglan);
            OleDbDataReader dr25 = com25.ExecuteReader();

            while (dr25.Read())
            {
                if (dr25[0].ToString() == button19.Text)
                {
                    label1.Text = dr25[1].ToString();
                    label2.Text = dr25[2].ToString();
                    label3.Text = dr25[3].ToString();


                }
                if (label2.Text == "boş" && label3.Text == "evet")
                {
                    button19.BackColor = Color.Yellow;
                }
                else if (label2.Text == "boş" && label3.Text == "hayır")
                {
                    button19.BackColor = Color.Green;
                }
                if (label2.Text == "dolu")
                {
                    button19.BackColor = Color.Red;
                }
            }
            OleDbCommand com26 = new OleDbCommand(seckomutu, baglan);
            OleDbDataReader dr26 = com26.ExecuteReader();

            while (dr26.Read())
            {
                if (dr26[0].ToString() == button20.Text)
                {
                    label1.Text = dr26[1].ToString();
                    label2.Text = dr26[2].ToString();
                    label3.Text = dr26[3].ToString();


                }
                if (label2.Text == "boş" && label3.Text == "evet")
                {
                    button20.BackColor = Color.Yellow;
                }
                else if (label2.Text == "boş" && label3.Text == "hayır")
                {
                    button20.BackColor = Color.Green;
                }
                if (label2.Text == "dolu")
                {
                    button20.BackColor = Color.Red;
                }
            }



             
        }

        private void button16_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gonderilecekveri = button4.Text;
            frmSiparis masa = new frmSiparis();
            masa.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            gonderilecekveri = button1.Text;
          frmSiparis masa =new frmSiparis();
            masa.Show();
            this.Hide();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            gonderilecekveri = button2.Text;
            frmSiparis masa = new frmSiparis();
            masa.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gonderilecekveri = button3.Text;
            frmSiparis masa = new frmSiparis();
            masa.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gonderilecekveri = button5.Text;
            frmSiparis masa = new frmSiparis();
            masa.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            gonderilecekveri = button6.Text;
            frmSiparis masa = new frmSiparis();
            masa.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            gonderilecekveri = button7.Text;
            frmSiparis masa = new frmSiparis();
            masa.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            gonderilecekveri = button8.Text;
            frmSiparis masa = new frmSiparis();
            masa.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            gonderilecekveri = button9.Text;
            frmSiparis masa = new frmSiparis();
            masa.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            gonderilecekveri = button10.Text;
            frmSiparis masa = new frmSiparis();
            masa.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            gonderilecekveri = button11.Text;
            frmSiparis masa = new frmSiparis();
            masa.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            gonderilecekveri = button12.Text;
            frmSiparis masa = new frmSiparis();
            masa.Show();
            this.Hide();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            gonderilecekveri = button17.Text;
            frmSiparis masa = new frmSiparis();
            masa.Show();
            this.Hide();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            gonderilecekveri = button18.Text;
            frmSiparis masa = new frmSiparis();
            masa.Show();
            this.Hide();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            gonderilecekveri = button19.Text;
            frmSiparis masa = new frmSiparis();
            masa.Show();
            this.Hide();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            gonderilecekveri = button20.Text;
            frmSiparis masa = new frmSiparis();
            masa.Show();
            this.Hide();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            frmMenüekle menüekle = new frmMenüekle();
            menüekle.Show();
            this.Hide();
        }

        private void button21_Click(object sender, EventArgs e)
        {

            frmRezervasyon rezervasyon = new frmRezervasyon();
            rezervasyon.Show();
            this.Hide();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            frmRapor rapor = new frmRapor();
            rapor.Show();
            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {

            frmGiris cikis = new frmGiris();
            cikis.Show();
            this.Hide();
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            frmKasa kasa = new frmKasa();
            kasa.Show();
            this.Hide();
        }

        
    }
}
