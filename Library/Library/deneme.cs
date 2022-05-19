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
       
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        MySqlDataAdapter da;
        DataSet ds;
        public kitap()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=172.21.54.3; Uid=Banipal; pwd=Banipal12345.; database=Banipal;");
        }
        void griddoldur()
        {
            con = new MySqlConnection("server=.; Initial Catalog=okul;Integrated Security=SSPI");
            da = new MySqlDataAdapter("Select *From ogrenci", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "ogrenci");
            con.Close();
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

            
             string kitapAdi = txt_Ad.Text;
             string yazar = txt_Yazar.Text;
             string yayinevi=txt_Yayinevi.Text;
             string kategori=txt_Kategori.Text;
             string tarih = yayin_tarihi.Text;
             int kitapID = int.Parse(txt_ID.Text);
             int sayfaSayisi = int.Parse(txt_Ss.Text);
             string isbn = txt_ISBN.Text;

            
            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into tbl_kitap(ID,kitap-ad,ISBN,kategori,yayintarihi,yayinevi,sayfasayisi,yazaradi) values (" + int.Parse(txt_ID.Text)+ ",'" 
                + txt_Ad.Text + "','" + txt_ISBN.Text+ "','" + txt_Kategori.Text +"','"+yayin_tarihi.Text +"','" + txt_Yayinevi.Text+"','" + int.Parse(txt_Ss.Text)+"','" + txt_Yazar.Text + "')";
            cmd.ExecuteNonQuery(); 
            con.Close();
            MessageBox.Show("Kitap başarıyla eklendi.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string kitapAdi = txt_Ad.Text;
            string yazar = txt_Yazar.Text;
            string yayinevi = txt_Yayinevi.Text;
            string kategori = txt_Kategori.Text;
            string tarih = yayin_tarihi.Text;
            int kitapID = int.Parse(txt_ID.Text);
            int sayfaSayisi = int.Parse(txt_Ss.Text);
            int ısbn = int.Parse(txt_ISBN.Text);

            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "update tbl_kitap set ID ='" + int.Parse(txt_ID.Text) + "',kitap-ad='" + txt_Ad.Text + "',ISBN='" + int.Parse(txt_ISBN.Text) + 
                "',kategori='" + txt_Kategori.Text +"',yayintarihi=" + yayin_tarihi.Text + "',yayinevi='" + txt_Yayinevi.Text + "',sayfasayisi='" + int.Parse(txt_Ss.Text) + "',yazaradi='" + txt_Yazar + "";
            cmd.ExecuteNonQuery();
            con.Close();
        }
          
    }
}
