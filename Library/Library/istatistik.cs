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


namespace Library
{
    public partial class istatistik : Form
    {
        
        public istatistik()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3; Uid=Banipal; pwd=Banipal12345.; database=Banipal;");
        MySqlCommand komut = new MySqlCommand();

        private void istatistik_Load(object sender, EventArgs e)
            
        {
       
            baglanti.Open();
            MySqlCommand komut1= new MySqlCommand("Select count(ogrno) from tbl_ogrenci", baglanti);
            MySqlDataReader dr1 = komut1.ExecuteReader();
           
            while (dr1.Read());
            {
                toplam_Ogrenci.Text = dr1[0].ToString();

            }
            baglanti.Close();

           
           baglanti.Open();
            MySqlCommand komut2 = new MySqlCommand("Select count(kitapAdi) from tbl_kitap", baglanti);
            MySqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read());
            {
                toplam_Kitap.Text = dr2[0].ToString();

            }
            baglanti.Close(); 
           
            baglanti.Open();
            MySqlCommand komuti1 = new MySqlCommand("select count(kitapAdi) from tbl_odunc group by kitapAdi", baglanti);
            MySqlDataReader dri1 = komuti1.ExecuteReader();
            while (dri1.Read());
            {
               lblCokOkunan.Text = dri1[0].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            MySqlCommand komuti2 = new MySqlCommand("select count(ogrno) from tbl_odunc group by ogrno", baglanti);
            MySqlDataReader dri2 = komuti1.ExecuteReader();
            while (dri2.Read()) ;
            {
                lblCokOkuyan.Text = dri2[0].ToString();
            }
            baglanti.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCokOkuyan_Click(object sender, EventArgs e)
        {

        }

        private void lblCokOkunan_Click(object sender, EventArgs e)
        {

        }
    }
}
