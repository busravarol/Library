using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Odunc2 : Form
    {
        public Odunc2()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3; Uid=Banipal; pwd=Banipal12345.; database=Banipal;");

        private void Odunc2_Load(object sender, EventArgs e)
        {

        }

        private void txt_No_TextChanged(object sender, EventArgs e)
        {
            if (txt_No.Text == "") foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select* from tbl_ogrenci where ogrno like'" + txt_No.Text + "'");
            MySqlDataReader mySqlDataReader = komut.ExecuteReader();
            MySqlDataReader reader = mySqlDataReader;
            {
                while (reader.Read())
                {
                    txt_Ad.Text = reader["ograd"].ToString();
                    txt_Soyad.Text = reader[2].ToString();
                    txt_tlf.Text = reader[3].ToString();
                    txt_posta.Text = reader[4].ToString();
                    txt_blm.Text = reader[5].ToString();
                }
            }
            baglanti.Close();
        }
    }
}
