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
    public partial class frmMenüekle : Form
    {
        
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();//datasetteki kayıtları forma aktarmak için kullanılır
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\restaurant.mdb");
        
      

        public frmMenüekle()
        {
            InitializeComponent();
        }
        void kayitlari_cek()
        {
            ;
            string seckomutu = "select * from icecekler";
            OleDbDataAdapter da = new OleDbDataAdapter(seckomutu, baglan);
            ds.Clear();
          
            da.Fill(ds, "icecekler");

            
        }

        void kayitlari_cek1()
        {
            string seckomutu = "select * from tatlilar";
            OleDbDataAdapter da = new OleDbDataAdapter(seckomutu, baglan);
            ds.Clear();
            da.Fill(ds, "tatlilar");
        }
        void kayitlari_cek2()
        {
            string seckomutu = "select * from anayemek";
            OleDbDataAdapter da = new OleDbDataAdapter(seckomutu, baglan);
            ds.Clear();
            da.Fill(ds, "anayemek");
        }
       
        void kayitlari_cek3()
        {
            string seckomutu = "select * from salata";
            OleDbDataAdapter da = new OleDbDataAdapter(seckomutu, baglan);
            ds.Clear();
            da.Fill(ds, "salata");
        }
        void kayitlari_cek4()
        {
            string seckomutu = "select * from fastfood";
            OleDbDataAdapter da = new OleDbDataAdapter(seckomutu, baglan);
            ds.Clear();
            da.Fill(ds, "fastfood");
        }
        void kayitlari_cek5()
        {
            string seckomutu = "select * from corba";
            OleDbDataAdapter da = new OleDbDataAdapter(seckomutu, baglan);
            ds.Clear();
            da.Fill(ds, "corba");
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {

        

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = baglan;
            OleDbCommand cmd1 = new OleDbCommand();
            cmd1.Connection = baglan;
            OleDbCommand cmd2 = new OleDbCommand();
            cmd2.Connection = baglan;
            OleDbCommand cmd3 = new OleDbCommand();
            cmd3.Connection = baglan;
            OleDbCommand cmd4 = new OleDbCommand();
            cmd4.Connection = baglan;
            OleDbCommand cmd5 = new OleDbCommand();
            cmd5.Connection = baglan;

           

            if (rdicecek.Checked == true)
            {
                if (checkBox1.Checked==true)
                {
                    cmd.Connection = baglan;
                    cmd.CommandText = "DELETE FROM icecekler WHERE ID=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
                    cmd.ExecuteNonQuery();
                }

                cmd.CommandText = "insert into icecekler (ID,icecekler,icecekfiyat) values (@ID,@icecekler,@icecekfiyat)";
                cmd.Parameters.Add("@ID", tbid.Text);
                cmd.Parameters.Add("@icecekler", tbadi.Text);
                cmd.Parameters.Add("@icecekfiyat", tbfiyati.Text);
                cmd.ExecuteNonQuery();

                kayitlari_cek();

               
                
            }
            if (rdtatli.Checked == true)
            {
                if (checkBox1.Checked == true)
                {
                    cmd.Connection = baglan;
                    cmd.CommandText = "DELETE FROM tatlilar WHERE ID=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
                    cmd.ExecuteNonQuery();
                }

                cmd1.CommandText = "insert into tatlilar (ID,tatlilar,tatlifiyat) values (@ID,@tatlilar,@tatlifiyat)";
                cmd1.Parameters.Add("@ID", tbid.Text);
                cmd1.Parameters.Add("@tatlilar", tbadi.Text);
                cmd1.Parameters.Add("@tatlifiyat", tbfiyati.Text);
                cmd1.ExecuteNonQuery();
                kayitlari_cek1();
             
                
            }
            if (rdanayemek.Checked == true)
            {
                if (checkBox1.Checked == true)
                {
                    cmd.Connection = baglan;
                    cmd.CommandText = "DELETE FROM anayemek WHERE ID=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
                    cmd.ExecuteNonQuery();
                }

                cmd2.CommandText = "insert into anayemek (ID,anayemek,anayemekfiyat) values (@ID,@anayemek,@anayemekfiyat)";
                cmd2.Parameters.Add("@ID", tbid.Text);
                cmd2.Parameters.Add("@anayemek", tbadi.Text);
                cmd2.Parameters.Add("@anayemekfiyat", tbfiyati.Text);
                cmd2.ExecuteNonQuery();
                kayitlari_cek2();
            }
            if (rdcorba.Checked == true)
            {
                if (checkBox1.Checked == true)
                {
                    cmd.Connection = baglan;
                    cmd.CommandText = "DELETE FROM corba WHERE ID=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
                    cmd.ExecuteNonQuery();
                }

                cmd3.CommandText = "insert into corba (ID,corba,corbafiyat) values (@ID,@corba,@corbafiyat)";
                cmd3.Parameters.Add("@ID", tbid.Text);
                cmd3.Parameters.Add("@corba", tbadi.Text);
                cmd3.Parameters.Add("@corbafiyat", tbfiyati.Text);
                cmd3.ExecuteNonQuery();
                kayitlari_cek5();
            }
            if (rdsalata.Checked == true)
            {
                if (checkBox1.Checked == true)
                {
                    cmd.Connection = baglan;
                    cmd.CommandText = "DELETE FROM salata WHERE ID=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
                    cmd.ExecuteNonQuery();
                }

                cmd4.CommandText = "insert into salata (ID,salata,salatafiyat) values (@ID,@salata,@salatafiyat)";
                cmd4.Parameters.Add("@ID", tbid.Text);
                cmd4.Parameters.Add("@salata", tbadi.Text);
                cmd4.Parameters.Add("@salatafiyat", tbfiyati.Text);
                cmd4.ExecuteNonQuery();
                kayitlari_cek3();
            }
            if (rdfastfood.Checked == true)
            {
                if (checkBox1.Checked == true)
                {
                    cmd.Connection = baglan;
                    cmd.CommandText = "DELETE FROM fastfood WHERE ID=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
                   cmd.ExecuteNonQuery();
                }

                cmd5.CommandText = "insert into fastfood (ID,fastfood,fastfoodfiyat) values (@ID,@fastfood,@fastfoodfiyat)";
                cmd5.Parameters.Add("@ID", tbid.Text);
                cmd5.Parameters.Add("@fastfood", tbadi.Text);
                cmd5.Parameters.Add("@fastfoodfiyat", tbfiyati.Text);
                cmd5.ExecuteNonQuery();
                kayitlari_cek4();
            }

            MessageBox.Show("Kayıt Gerçekleştirildi");

            tbid.Clear();
            tbadi.Clear();
            tbfiyati.Clear();
            tbadi.Enabled = false;
            tbfiyati.Enabled = false;
            tbid.Enabled = false;
            checkBox1.Checked = false;
            btnkaydet.Enabled = false;
           
        }

        private void frmMenüekle_Load(object sender, EventArgs e)
        {
            

            if (baglan.State == ConnectionState.Closed)//baglantı açık mı değil değil mi kontrol ettiriyoruz
                baglan.Open();
            rdanayemek.Checked = true;

            tbid.Enabled = false;
            tbadi.Enabled = false;
            tbfiyati.Enabled = false;
            btnkaydet.Enabled = false;


        
        }

        private void rdicecek_CheckedChanged(object sender, EventArgs e)
        {
           
                label1.Text = "İçecek Kodu:";
                label2.Text = "İçecek Adı:";
                label3.Text = "İçecek fiyatı:";
                tbadi.Clear();
                tbfiyati.Clear();
                tbid.Clear();

                if (baglan.State == ConnectionState.Closed)
                    baglan.Open();
                kayitlari_cek();
                bs.DataSource = ds.Tables["icecekler"];
                dataGridView1.DataSource = bs;
               
            
        }

        private void rdtatli_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
            label1.Text = "Tatlı Kodu:";
            label2.Text = "Tatlı Adı:";
            label3.Text = "Tatlı fiyatı:";
            tbadi.Clear();
            tbfiyati.Clear();
            tbid.Clear();

            if (baglan.State == ConnectionState.Closed)
                baglan.Open();
            kayitlari_cek1();
            bs.DataSource = ds.Tables["tatlilar"];
            dataGridView1.DataSource = bs;
            bs.Clear();
            }
            catch
            { }

        }



        private void rdcorba_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                label1.Text = "Çorba Kodu:";
                label2.Text = "Çorba Adı:";
                label3.Text = "Çorba fiyatı:";
                tbadi.Clear();
                tbfiyati.Clear();
                tbid.Clear();

                if (baglan.State == ConnectionState.Closed)
                    baglan.Open();
                kayitlari_cek5();
                bs.DataSource = ds.Tables["corba"];
                dataGridView1.DataSource = bs;
            }
            catch
            { }
           
        }

        private void rdsalata_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                label1.Text = "Salata Kodu:";
                label2.Text = "Salata Adı:";
                label3.Text = "Salata fiyatı:";
                tbadi.Clear();
                tbfiyati.Clear();
                tbid.Clear();

                if (baglan.State == ConnectionState.Closed)
                    baglan.Open();
                kayitlari_cek3();
                bs.DataSource = ds.Tables["salata"];
                dataGridView1.DataSource = bs;
            }
            catch { }
            
        }

        private void rdfastfood_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                label1.Text = "Fastfood Kodu:";
                label2.Text = "Fastfood Adı:";
                label3.Text = "Fastfood fiyatı:";
                tbadi.Clear();
                tbfiyati.Clear();
                tbid.Clear();

                if (baglan.State == ConnectionState.Closed)
                    baglan.Open();
                kayitlari_cek4();
                bs.DataSource = ds.Tables["fastfood"];
                dataGridView1.DataSource = bs;

            }
            catch { }
        }

        private void rdanayemek_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                label1.Text = "An Yemek Kodu:";
                label2.Text = "Ana Yemek Adı:";
                label3.Text = "Ana Yemek fiyatı:";
                tbadi.Clear();
                tbfiyati.Clear();
                tbid.Clear();

                if (baglan.State == ConnectionState.Closed)
                    baglan.Open();
                kayitlari_cek2();
                bs.DataSource = ds.Tables["anayemek"];
                dataGridView1.DataSource = bs;
            }
            catch
            { }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            frmMasadurumu Anasayfa = new frmMasadurumu();
            Anasayfa.Show();
            this.Hide();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            tbid.Enabled = true;
            tbadi.Enabled = true;
            tbfiyati.Enabled = true;
            btnkaydet.Enabled = true;

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Silmek istediğinize Emin misiniz ? ", "Uyarı", MessageBoxButtons.YesNo);
            if (cevap == DialogResult.Yes)
            {

                if (rdicecek.Checked == true)
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = baglan;
                    cmd.CommandText = "DELETE FROM icecekler WHERE ID=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
                    cmd.ExecuteNonQuery();
                    kayitlari_cek();
                }

                if (rdanayemek.Checked == true)
                {
                    OleDbCommand cmd2 = new OleDbCommand();
                    cmd2.Connection = baglan;
                    cmd2.CommandText = "DELETE FROM anayemek WHERE ID=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
                    cmd2.ExecuteNonQuery();
                    kayitlari_cek2();
                }

                if (rdtatli.Checked == true)
                {
                    OleDbCommand cmd1 = new OleDbCommand();
                    cmd1.Connection = baglan;
                    cmd1.CommandText = "DELETE FROM tatlilar WHERE ID=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
                    cmd1.ExecuteNonQuery();
                    kayitlari_cek1();
                }
                if (rdsalata.Checked==true)
                {
                    OleDbCommand cmd4 = new OleDbCommand();
                    cmd4.Connection = baglan;
                    cmd4.CommandText = "DELETE FROM salata WHERE ID=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
                    cmd4.ExecuteNonQuery();
                    kayitlari_cek3();
                }
                if (rdfastfood.Checked == true)
                {
                    OleDbCommand cmd5 = new OleDbCommand();
                    cmd5.Connection = baglan;
                    cmd5.CommandText = "DELETE FROM fastfood WHERE ID=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
                    cmd5.ExecuteNonQuery();
                    kayitlari_cek4();
                }
                if (rdcorba.Checked == true)
                {
                    OleDbCommand cmd3 = new OleDbCommand();
                    cmd3.Connection = baglan;
                    cmd3.CommandText = "DELETE FROM corba WHERE ID=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
                    cmd3.ExecuteNonQuery();
                    kayitlari_cek5();
                }
                MessageBox.Show("Kaydınız Silindi.");
            }

        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            tbid.Clear();
            tbadi.Clear();
            tbfiyati.Clear();
            tbid.Enabled = false;
            tbadi.Enabled = false;
            tbfiyati.Enabled = false;

        }

        private void btndüzenle_Click(object sender, EventArgs e)
        {
           
            tbid.Enabled = true;
            tbadi.Enabled = true;
            tbfiyati.Enabled = true;
            btnkaydet.Enabled = true;
            checkBox1.Checked = true;
            if (rdicecek.Checked == true)
            {
                tbid.DataBindings.Add("Text", bs, "ID");
                tbadi.DataBindings.Add("Text", bs, "icecekler");
                tbfiyati.DataBindings.Add("Text", bs, "icecekfiyat");
            }

            if (rdtatli.Checked == true)
            {
                tbid.DataBindings.Add("Text", bs, "ID");
                tbadi.DataBindings.Add("Text", bs, "tatlilar");
                tbfiyati.DataBindings.Add("Text", bs, "tatlifiyat");
            }
            if (rdanayemek.Checked == true)
            {
                tbid.DataBindings.Add("Text", bs, "ID");
                tbadi.DataBindings.Add("Text", bs, "anayemek");
                tbfiyati.DataBindings.Add("Text", bs, "anayemekfiyat");
            }
            if (rdsalata.Checked == true)
            {
                tbid.DataBindings.Add("Text", bs, "ID");
                tbadi.DataBindings.Add("Text", bs, "salata");
                tbfiyati.DataBindings.Add("Text", bs, "salatafiyat");
            }
            if (rdfastfood.Checked == true)
            {
                tbid.DataBindings.Add("Text", bs, "ID");
                tbadi.DataBindings.Add("Text", bs, "fastfood");
                tbfiyati.DataBindings.Add("Text", bs, "fastfoodfiyat");
            }
            if (rdcorba.Checked == true)
            {
                tbid.DataBindings.Add("Text", bs, "ID");
                tbadi.DataBindings.Add("Text", bs, "corba");
                tbfiyati.DataBindings.Add("Text", bs, "corbafiyat");
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
