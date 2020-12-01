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
    public partial class frmSiparis : Form
    {

        DataSet ds = new DataSet();
        DataSet ds1 = new DataSet();
        DataSet ds2 = new DataSet();
        DataSet ds3 = new DataSet();
        DataSet ds4 = new DataSet();
        DataSet ds5 = new DataSet();
        DataSet ds6 = new DataSet();
        DataSet ds7 = new DataSet();
        BindingSource bs = new BindingSource();//datasetteki kayıtları forma aktarmak için kullanılır
        BindingSource bs1 = new BindingSource();
        BindingSource bs2 = new BindingSource();
        BindingSource bs3 = new BindingSource();
        BindingSource bs4 = new BindingSource();
        BindingSource bs5 = new BindingSource();
        BindingSource bs6 = new BindingSource();
        BindingSource bs7 = new BindingSource();
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\restaurant.mdb");
        OleDbCommand sorgu = new OleDbCommand();
        string durum = "dolu";
        string durum1 = "boş";
        string rezervasyon = "hayır";
        int kapasite = 6;
        int siparisucret = 0;
        int mshesap = 0;
        int toplam = 0;

        public frmSiparis()
        {
            InitializeComponent();
        }

      
       

       void kayitlari_cek()
       {
           
           string seckomutu = "select * from anayemek";
           OleDbDataAdapter da = new OleDbDataAdapter(seckomutu, baglan);
           ds.Clear();
           da.Fill(ds, "anayemek");

       }

       void kayitlari_cek2()
       {

           string seckomutu = "select * from corba";
           OleDbDataAdapter da = new OleDbDataAdapter(seckomutu, baglan);
           ds2.Clear();
           da.Fill(ds2, "corba");
       }

       void kayitlari_cek3()
       {
           string seckomutu = "select * from fastfood";
           OleDbDataAdapter da = new OleDbDataAdapter(seckomutu, baglan);
           ds3.Clear();
           da.Fill(ds3, "fastfood");
       }

       void kayitlari_cek4()
       {
           string seckomutu = "select * from salata";
           OleDbDataAdapter da = new OleDbDataAdapter(seckomutu, baglan);
           ds4.Clear();
           da.Fill(ds4, "salata");
       }
       void kayitlari_cek5()
       {
           string seckomutu = "select * from icecekler";
           OleDbDataAdapter da = new OleDbDataAdapter(seckomutu, baglan);
           ds5.Clear();
           da.Fill(ds5, "icecekler");
       }

       void kayitlari_cek6()
       {
           string seckomutu = "select * from tatlilar";
           OleDbDataAdapter da = new OleDbDataAdapter(seckomutu, baglan);
           ds6.Clear();
           da.Fill(ds6, "tatlilar");
       }

       void kayitlari_cek1()
       {
           string seckomutu = "select * from satislar where masanum='" + textBox3.Text + "'";
           OleDbDataAdapter da = new OleDbDataAdapter(seckomutu, baglan);
           ds1.Clear();
           da.Fill(ds1, "satislar");
       }

       void kayitlari_cek7()
       {
           string seckomutu = "select * from hesap where masanum='" + textBox3.Text + "'";
           OleDbDataAdapter da = new OleDbDataAdapter(seckomutu, baglan);
           ds7.Clear();
           da.Fill(ds7, "hesap");
       }

       private void frmSiparis_Load(object sender, EventArgs e)
       {
           timer1.Start();
           label5.Text = DateTime.Now.ToShortDateString();//sistem tarih

           textBox3.Text = frmMasadurumu.gonderilecekveri;
           
           if (baglan.State == ConnectionState.Closed)
               baglan.Open();
         /*  string seckomutu = "Select * from anayemek";
           OleDbCommand com = new OleDbCommand(seckomutu, baglan);
           OleDbDataReader dr = com.ExecuteReader();

           while (dr.Read()) //while’i tüm öğeleri seçmek için kullandık.
           {
               kayitlari_cek();
               bs.DataSource = ds.Tables["anayemek"];
               dataGridView1.DataSource = bs;
           }
           dr.Close();
           baglan.Close();*/ //kayıtları çek ile aynı işlemi yapıyor

           kayitlari_cek();
           bs.DataSource = ds.Tables["anayemek"];
           dataGridView1.DataSource = bs;

           kayitlari_cek2();
           bs2.DataSource = ds2.Tables["corba"];
           dataGridView2.DataSource = bs2;

           kayitlari_cek3();
           bs3.DataSource = ds3.Tables["fastfood"];
           dataGridView4.DataSource = bs3;

           kayitlari_cek4();
           bs4.DataSource = ds4.Tables["salata"];
           dataGridView5.DataSource = bs4;

           kayitlari_cek5();
           bs5.DataSource = ds5.Tables["icecekler"];
           dataGridView6.DataSource = bs5;

           kayitlari_cek6();
           bs6.DataSource = ds6.Tables["tatlilar"];
           dataGridView7.DataSource = bs6;

           kayitlari_cek1();
           bs1.DataSource = ds1.Tables["satislar"];
           dataGridView3.DataSource = bs1;


           kayitlari_cek7();
           bs7.DataSource = ds7.Tables["hesap"];
           textBox4.DataBindings.Add("Text", bs7, "masahesap");

       }


       private void button1_Click(object sender, EventArgs e)
       {

           siparisucret = Convert.ToInt32(textBox2.Text);
           mshesap = Convert.ToInt32(textBox4.Text);
           toplam = mshesap + siparisucret;

           if (baglan.State == ConnectionState.Closed)//baglantı açık mı değil değil mi kontrol ettiriyoruz
               baglan.Open();

           OleDbCommand cmd = new OleDbCommand();
          
           cmd.Connection = baglan;
           cmd.CommandText = "insert into satislar (masanum,ürün,ürünfiyat) values (@masanum,@ürün,@ürünfiyat)";
           cmd.Parameters.Add("@masanum", textBox3.Text);
           cmd.Parameters.Add("@ürün", textBox1.Text);
           cmd.Parameters.Add("@ürünfiyat", textBox2.Text);
           cmd.ExecuteNonQuery();
           MessageBox.Show("Kayıt Gerçekleşti");
           kayitlari_cek1();

           OleDbCommand cmd1 = new OleDbCommand();// hesap ödendiğinde yeni durum oluşturup içeriiğini boş olarak güncelle
           cmd1.Connection = baglan;
           cmd1.CommandText = "update masalar set kapasite=@kapasite,durum=@durum,rezervasyon=@rezervasyon where masanum=@masanum";
           cmd1.Parameters.Add("@kapasite", kapasite);
           cmd1.Parameters.Add("@durum", durum);
           cmd1.Parameters.Add("@rezervasyon", rezervasyon);
           cmd1.Parameters.Add("@masanum", textBox3.Text);
           cmd1.ExecuteNonQuery();

           OleDbCommand cmd2 = new OleDbCommand();// hesap ödendiğinde yeni durum oluşturup içeriiğini boş olarak güncelle
           cmd2.Connection = baglan;
           cmd2.CommandText = "update hesap set masahesap=@masahesap where masanum=@masanum";
           cmd2.Parameters.Add("@masahesap", toplam);
           cmd2.Parameters.Add("@masanum", textBox3.Text);
           cmd2.ExecuteNonQuery();

           kayitlari_cek7();


       
       }

       private void button2_Click(object sender, EventArgs e)
       {



          DialogResult cevap = MessageBox.Show("Silmek istediğinize Emin misiniz ? ", "Uyarı", MessageBoxButtons.YesNo);
            if (cevap == DialogResult.Yes)
            {
                siparisucret = Convert.ToInt32(textBox2.Text);
                mshesap = Convert.ToInt32(textBox4.Text);
                toplam = mshesap - siparisucret;
                
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baglan;
                cmd.CommandText = "delete from satislar where masanum=@masanum and ürün=@ürün";
                cmd.Parameters.Add("@masanum", textBox3.Text);
                cmd.Parameters.Add("@ürün", textBox1.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sipariş Silindi...");
               kayitlari_cek1();


               OleDbCommand cmd2 = new OleDbCommand();
               cmd2.Connection = baglan;
               cmd2.CommandText = "update hesap set masahesap=@masahesap where masanum=@masanum";
               cmd2.Parameters.Add("@masahesap", toplam);
               cmd2.Parameters.Add("@masanum", textBox3.Text);
               cmd2.ExecuteNonQuery();

               kayitlari_cek7();
              
            }
       } 
        
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
       {
           textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
           textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
       }

       private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
       {
           textBox1.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
           textBox2.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
       }

       private void dataGridView4_CellEnter(object sender, DataGridViewCellEventArgs e)
       {
           textBox1.Text = dataGridView4.CurrentRow.Cells[1].Value.ToString();
           textBox2.Text = dataGridView4.CurrentRow.Cells[2].Value.ToString();
       }

       private void dataGridView5_CellEnter(object sender, DataGridViewCellEventArgs e)
       {
           textBox1.Text = dataGridView5.CurrentRow.Cells[1].Value.ToString();
           textBox2.Text = dataGridView5.CurrentRow.Cells[2].Value.ToString();
       }

       private void dataGridView6_CellEnter(object sender, DataGridViewCellEventArgs e)
       {
           textBox1.Text = dataGridView6.CurrentRow.Cells[1].Value.ToString();
           textBox2.Text = dataGridView6.CurrentRow.Cells[2].Value.ToString();
       }

       private void dataGridView7_CellEnter(object sender, DataGridViewCellEventArgs e)
       {

           textBox1.Text = dataGridView7.CurrentRow.Cells[1].Value.ToString();
           textBox2.Text = dataGridView7.CurrentRow.Cells[2].Value.ToString();
       }

       private void dataGridView3_CellEnter(object sender, DataGridViewCellEventArgs e)
       {
           textBox1.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
           textBox2.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
       }

       private void button3_Click(object sender, EventArgs e)
       {
           if (baglan.State == ConnectionState.Closed)//baglantı açık mı değil değil mi kontrol ettiriyoruz
               baglan.Open();

           OleDbCommand cmd3 = new OleDbCommand();

           cmd3.Connection = baglan;
           cmd3.CommandText = "insert into kasa (tarih,saat,kasa) values (@tarih,@saat,@kasa)";
           cmd3.Parameters.Add("@tarih", label5.Text);
           cmd3.Parameters.Add("@saat", label4.Text);
           cmd3.Parameters.Add("@kasa", textBox4.Text);
           cmd3.ExecuteNonQuery();



           if (baglan.State == ConnectionState.Closed)//baglantı açık mı değil değil mi kontrol ettiriyoruz
               baglan.Open();


            DialogResult cevap = MessageBox.Show("Tüm Hesap Ödensin Miii ?? ", "Uyarı", MessageBoxButtons.YesNo);
            if (cevap == DialogResult.Yes)
            {
                toplam = 0;

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baglan;
                cmd.CommandText = "delete from satislar where masanum=@masanum";
                cmd.Parameters.Add("@masanum", textBox3.Text);
                cmd.Parameters.Add("@ürün", textBox1.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kaydınız Silindi...");
                kayitlari_cek1();


                OleDbCommand cmd2 = new OleDbCommand();
                cmd2.Connection = baglan;
                cmd2.CommandText = "update hesap set masahesap=@masahesap where masanum=@masanum";
                cmd2.Parameters.Add("@masahesap", toplam);
                cmd2.Parameters.Add("@masanum", textBox3.Text);
                cmd2.ExecuteNonQuery();

                kayitlari_cek7();

                if (baglan.State == ConnectionState.Closed)
                    baglan.Open();


                OleDbCommand cmd1 = new OleDbCommand();
                cmd1.Connection = baglan;
                cmd1.CommandText = "update masalar set kapasite=@kapasite,durum=@durum,rezervasyon=@rezervasyon where masanum=@masanum";
                cmd1.Parameters.Add("@kapasite", kapasite);
                cmd1.Parameters.Add("@durum", durum1);
                cmd1.Parameters.Add("@rezervasyon", rezervasyon);
                cmd1.Parameters.Add("@masanum", textBox3.Text);
                cmd1.ExecuteNonQuery();


            }
       }

       private void button16_Click(object sender, EventArgs e)
       {
           frmMasadurumu geri = new frmMasadurumu();
           geri.Show();
           this.Hide();

       }

       private void timer1_Tick(object sender, EventArgs e)
       {
           label4.Text = DateTime.Now.ToLongTimeString();//sistem saat
       }

        
    }
}
