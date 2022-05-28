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
            MySqlCommand komut1= new MySqlCommand("Select count (toplam_Ogrenci) from tbl_ogrenci", baglanti);
            MySqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read());
            {
                toplam_Ogrenci.Text = dr1[0].ToString();

            }
            baglanti.Close();

            baglanti.Open();
            MySqlCommand komut2 = new MySqlCommand("Select count (toplam_Kitap) from tbl_kitap", baglanti);
            MySqlDataReader dr2 = komut1.ExecuteReader();
            while (dr1.Read());
            {
                toplam_Kitap.Text = dr1[0].ToString();

            }
            baglanti.Close();

            baglanti.Open();
            MySqlCommand komuti1 = new MySqlCommand("Select count(LblCokOkunan),tbl_kitap from LblCokOkunan group by tbl_kitap)", baglanti);
            MySqlDataReader dri1 = komuti1.ExecuteReader();
            while (dri1.Read());
            {
               LblCokOkunan.Text = dr1[0].ToString();
            }
            baglanti.Close();

        }
    }
}
