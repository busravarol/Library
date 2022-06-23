using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Library
{
    public partial class kitap : Form
    {
       
        MySqlDataReader dr;
       
        public kitap()

        {
            InitializeComponent();
        }
        MySqlConnection baglanti=new MySqlConnection("Server=172.21.54.3; Uid=Banipal; pwd=Banipal12345.; database=Banipal;");
        /*  public static MySqlConnection GetConnection()
          {
              string sql = "Server=172.21.54.3; Uid=Banipal; pwd=Banipal12345.; database=Banipal;";
              MySqlConnection con = new MySqlConnection(sql);
              try
              {
                  con.Open();
              }
              catch (Exception ex)
              {

                  MessageBox.Show($"{ex}");
              }
              return con;
          }
          public static void addBook(kitap kitap)
          {
              string sql = "INSERT INTO kitap VALUES (@ID,@kitap-ad, @ISBN,@kategori,@yayintarihi,@yayinevi,@sayfasayisi,@yazaradi)";
              MySqlConnection con =GetConnection();
              MySqlCommand cmd = new MySqlCommand(sql, con);
              cmd.CommandType = CommandType.Text;
              cmd.Parameters.Add("@kitap-ad", MySqlDbType.VarChar).Value = kitap.txt_Ad;
              cmd.Parameters.Add("@ISBN", MySqlDbType.VarChar).Value = kitap.txt_ISBN;
              cmd.Parameters.Add("@kategori", MySqlDbType.VarChar).Value = kitap.txt_Kategori;
              cmd.Parameters.Add("@yayintarihi", MySqlDbType.Int64).Value = kitap.txt_Tarih;
              cmd.Parameters.Add("@yayinevi", MySqlDbType.VarChar).Value = kitap.txt_Yayinevi;
              cmd.Parameters.Add("@sayfasayisi", MySqlDbType.Int64).Value = kitap.txt_Ss;
              cmd.Parameters.Add("@yazaradi", MySqlDbType.VarChar).Value = kitap.txt_Yazar;
              try
              {
                  cmd.ExecuteNonQuery();
                  MessageBox.Show("Kitap Başarıyla Eklendi");
              }
              catch(Exception ex)
              {
                  MessageBox.Show("Kitap Ekleme Başarısız"+ex.Message,"Error",MessageBoxButtons.OK);
              }
              con.Close();

          }
         /* public class kitap
          {
              string Ad;
              string ISBN;
              string Kategori;
              string Tarih;
              string Ss;
              string Yazar;
              public string 
          }*/


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void deneme_Load(object sender, EventArgs e)
        {
            object[] kategori = new object[] { "Edebiyat", "Tarih", "Kişisel Gelişim", "Felsefe", "İşletme" };
            kategori_Box.Items.AddRange(kategori);
            kategori_Box.Text = "Seçiniz...";

           /* object[] kitapadi = new object[] { "Yaban", "Açık Ufuk", "İçimizdeki Şeytan", "İrade Terbiyesi", "1984","Çocukluk","Kinyas ve Kayra","Elveda Güzel Vatanım","Saatleri Ayarlama Enstitüsü","İtiraflarım" };
            kitap_Box.Items.AddRange(kitapadi);
            kitap_Box.Text = "Seçiniz...";*/

            object[] yayinevi = new object[] { "İş Bankası", "İndigo", "Yapı Kredi", "Epsilon", "Timaş","Dergah" };
            yayın_Box.Items.AddRange(yayinevi);
            yayın_Box.Text = "Seçiniz...";

            object[] dil = new object[] { "Türkçe", "İngilizce", "Almanca"};
            dil_Box.Items.AddRange(dil);
            dil_Box.Text = "Seçiniz...";

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open   ();
            MySqlCommand komut = new MySqlCommand("insert into tbl_kitap(kitapAdi,kategori,basimyili,yayinevi,sayfasayisi,yazaradi,dolap,stoksayisi,dil,rafno) values (@k1,@k2,@k3,@k4,@k5,@k6,@k7,@k8,@k9,@k10) ", baglanti);
            komut.Parameters.AddWithValue("@k1", txt_kitap.Text);
            komut.Parameters.AddWithValue("@k2", kategori_Box.Text);
            komut.Parameters.AddWithValue("@k3", txt_Tarih.Text);
            komut.Parameters.AddWithValue("@k4", yayın_Box.Text);
            komut.Parameters.AddWithValue("@k5", txt_Ss.Text);
            komut.Parameters.AddWithValue("@k6", txt_Yazar.Text);
            komut.Parameters.AddWithValue("@k7", txtdolap.Text);
            komut.Parameters.AddWithValue("@k8", txtstok.Text);
            komut.Parameters.AddWithValue("@k9", dil_Box.Text);
            komut.Parameters.AddWithValue("@k10",txtraf.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Başarıyla Eklendi");


            
           /* for (int i = 0; i < kategori_Box.Items.Count; i++)
            {
                collection.Add(kategori_Box.Items[i].ToString());
            }*/


            /*kitap ID =    
            kitap.kitap-Ad = txt_Ad.Text;

            /* string sqlCommand = "insert into tbl_kitap(kitap-ad,ISBN,kategori,yayintarihi,yayinevi,sayfasayisi,yazaradi)" +
                 " values (" + txt_Ad.Text + ",'" + txt_ISBN.Text + "','" + txt_Kategori.Text + "','" + txt_Tarih.Text
                 + "','" + txt_Yayinevi.Text + "','" + int.Parse(txt_Ss.Text) + "','" + txt_Yazar.Text + "')";
             Console.WriteLine(sqlCommand);

             string kitapadi = txt_Ad.Text;
             string yazar = txt_Yazar.Text;
             string yayinevi = txt_Yayinevi.Text;
             string kategori= txt_Kategori.Text;
             int sayfasayisi = int.Parse(txt_Ss.Text);
             string isbn = txt_ISBN.Text;
             string yayintarihi = txt_Tarih.Text;
             MySqlConnection con = GetConnection();
             MySqlCommand command = new MySqlCommand(sqlCommand,con);

            try
            {
                MySqlCommand command = new MySqlCommand();
                command.ExecuteNonQuery();
                MessageBox.Show("Yeni Kitap Eklendi");
            }
            catch (Exception hata )
            {
                MessageBox.Show("Hata var kitap eklenmedi " + hata.Message);
               
            }*/

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        /*    baglanti.Open();
            MySqlCommand komut = new MySqlCommand("update tbl_kitap (kitapAdi,kategori,yayintarihi,yayinevi,sayfasayisi,yazaradi) values (@k1,@k2,@k3,@k4,@k5,@k6) ", baglanti);
            komut.Parameters.AddWithValue("@k1", txt_Ad.Text);
            komut.Parameters.AddWithValue("@k2", txt_Kategori.Text);
            komut.Parameters.AddWithValue("@k3", txt_Tarih.Text);
            komut.Parameters.AddWithValue("@k4", txt_Yayinevi.Text);
            komut.Parameters.AddWithValue("@k5", txt_Ss.Text);
            komut.Parameters.AddWithValue("@k6", txt_Yazar.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Başarıyla Güncellendi.");

           
            string kitapadi = txt_Ad.Text;
            string yazar = txt_Yazar.Text;
            string yayinevi = txt_Yayinevi.Text;
            string kategori = txt_Kategori.Text;
            int sayfasayisi = int.Parse(txt_Ss.Text);
            int isbn = int.Parse(txt_ISBN.Text);
            int yayintarihi = int.Parse(txt_Tarih.Text);

            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "update set kitap-adi='" + txt_Ad.Text + "',ISBN='" + int.Parse(txt_ISBN.Text) +
                "',kategori='" + txt_Kategori.Text + "'  yayintarihi=" + int.Parse(txt_Tarih.Text) +"',yayinevi='" + txt_Yayinevi.Text + 
                "',sayfasayisi='"+ int.Parse(txt_Ss.Text)+"',yazaradi='" + txt_Yazar.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            Form2 Form2 = new Form2();
            Form2.Show();*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Ad_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // object[] kategori = new object[] { "Edebiyat", "Tarih", "Kişisel Gelişim", "Felsefe", "İşletme" };
           // kategori_Box.Items.AddRange(kategori);
           // kategori_Box.Text = "Seçiniz...";
           // AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
        }

        private void kitap_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void yayın_Box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_kitap_TextChanged(object sender, EventArgs e)
        {

        }

        private void dil_Box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
