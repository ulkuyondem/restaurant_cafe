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
    public partial class frmRezervasyon : Form

    {
        public frmRezervasyon()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();//datasetteki kayıtları forma aktarmak için kullanılır

        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\restaurant.mdb");
         OleDbCommand komut = new OleDbCommand();

         int kapasite = 6;
         string durum1 = "boş";
         string rezervasyon = "evet";
         string rezervasyon1 = "hayır";

         private void verilerigöster()
         {
             listView1.Items.Clear();
             try
             {
                 baglan.Open();
                 OleDbCommand komut = new OleDbCommand();
                 komut.Connection = baglan;//komut ve bağlan ilişkilendir
                 komut.CommandText = "Select * From rezervasyon";
                 OleDbDataReader oku = komut.ExecuteReader();
                 while (oku.Read()) //oku komutu caliştiği sürece
                 {
                     ListViewItem ekle = new ListViewItem();
                     ekle.Text = oku["ad"].ToString();
                     ekle.SubItems.Add(oku["soyadi"].ToString());
                     ekle.SubItems.Add(oku["telefon"].ToString());
                     ekle.SubItems.Add(oku["tarih"].ToString());
                     ekle.SubItems.Add(oku["kisisayisi"].ToString());
                     ekle.SubItems.Add(oku["masanum"].ToString());
                     listView1.Items.Add(ekle);
                 }
                 baglan.Close(); 
             }
             catch
             {
             }
         }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                
                textBox2.Text = item.SubItems[0].Text;
                textBox3.Text = item.SubItems[1].Text;
                maskedTextBox2.Text = item.SubItems[2].Text;
                maskedTextBox1.Text = item.SubItems[3].Text;
                textBox6.Text = item.SubItems[4].Text;
                cbmasa.Text = item.SubItems[5].Text;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                OleDbCommand komut = new OleDbCommand("insert into rezervasyon (ad,soyadi,telefon,tarih,kisisayisi,masanum) values ('" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + maskedTextBox2.Text.ToString() + "','" + maskedTextBox1.Text.ToString() + "','" + textBox6.Text.ToString() + "','" + cbmasa.Text.ToString() + "')", baglan);
                komut.ExecuteNonQuery();
                baglan.Close();
                verilerigöster();

                if (baglan.State == ConnectionState.Closed)
                    baglan.Open();

                OleDbCommand cmd1 = new OleDbCommand();
                cmd1.Connection = baglan;
                cmd1.CommandText = "update masalar set kapasite=@kapasite,durum=@durum,rezervasyon=@rezervasyon where masanum=@masanum";
                cmd1.Parameters.Add("@kapasite", kapasite);
                cmd1.Parameters.Add("@durum", durum1);
                cmd1.Parameters.Add("@rezervasyon", rezervasyon);
                cmd1.Parameters.Add("@masanum", cbmasa.Text);
                cmd1.ExecuteNonQuery();

                textBox2.Clear();
                textBox3.Clear();
                maskedTextBox2.Clear();
                maskedTextBox1.Clear();
                textBox6.Clear();
                cbmasa.Text = "";
            }
            catch
            {
                MessageBox.Show("Eklenecek Rezervasyon Bilgilerini Girin!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {


            try
            {
                baglan.Open();
                komut.Connection = baglan;
                komut.CommandText = "delete from rezervasyon where masanum ='" + cbmasa.Text + "'";
                komut.ExecuteNonQuery();
                baglan.Close();
                verilerigöster();



                if (baglan.State == ConnectionState.Closed)
                    baglan.Open();

                OleDbCommand cmd1 = new OleDbCommand();
                cmd1.Connection = baglan;
                cmd1.CommandText = "update masalar set kapasite=@kapasite,durum=@durum,rezervasyon=@rezervasyon where masanum=@masanum";
                cmd1.Parameters.Add("@kapasite", kapasite);
                cmd1.Parameters.Add("@durum", durum1);
                cmd1.Parameters.Add("@rezervasyon", rezervasyon1);
                cmd1.Parameters.Add("@masanum", cbmasa.Text);
                cmd1.ExecuteNonQuery();


            }
            catch
            {
                MessageBox.Show("Silinecek Rezervasyonu Seçiniz!");
            }

            textBox2.Clear();
            textBox3.Clear();
            maskedTextBox2.Clear();
            maskedTextBox1.Clear(); 
            textBox6.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand komut = new OleDbCommand();
                baglan.Open();
                komut.Connection = baglan;
                komut.CommandText = ("update rezervasyon set soyadi='" + textBox3.Text + "',telefon='" + maskedTextBox2.Text + "',tarih='" + maskedTextBox1.Text + "',kisisayisi='" + textBox6.Text + "',masanum='" + cbmasa.Text + "'where  ad='" + textBox2.Text + "'");
                komut.ExecuteNonQuery();
                baglan.Close();
                verilerigöster();
            }
            catch
            {
                MessageBox.Show("Lütfen Müşteri Bilgilerini Giriniz");
            }
            textBox2.Clear();
            textBox3.Clear();
            maskedTextBox2.Clear();
            maskedTextBox1.Clear();
            textBox6.Clear(); 
        }

        private void frmRezervasyon_Load(object sender, EventArgs e)
        {

            try
            {
                if (baglan.State == ConnectionState.Closed)
                    baglan.Open();

                string sec = "select * from masalar where durum='" + "boş" + "' and rezervasyon='" + "hayır" + "'";
                bs.DataSource = ds.Tables["rezervasyon"];
                OleDbDataAdapter da = new OleDbDataAdapter(sec, baglan);
                da.Fill(ds, "masalar");//dataset içindeki sanal bolumler tablosuna doldur
                cbmasa.DataSource = ds.Tables["masalar"];
                cbmasa.ValueMember = "masanum";
                cbmasa.DisplayMember = "masanum";
                baglan.Close();
                verilerigöster();
            }
            catch { }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            frmMasadurumu Anasayfa = new frmMasadurumu();
            Anasayfa.Show();
            this.Hide();
        }

       

       
    }
}
