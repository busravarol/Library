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
        public static MySqlConnection GetConnection()
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void deneme_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
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
            MySqlCommand command = new MySqlCommand(sqlCommand,con);*/

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Yeni Kitap Eklendi");
            }
            catch (Exception hata )
            {
                MessageBox.Show("Hata var kitap eklenmedi " + hata.Message);
               
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*
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
    }
}
