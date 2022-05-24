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
    public partial class Odunc : Form
    {
        public Odunc()
        {
           
            
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3; Uid=Banipal; pwd=Banipal12345.; database=Banipal;");

        private void btn_Arama_Click(object sender, EventArgs e)
        {
            /*if(txt_No.Text != "")
            {
                string sql = txt_No.Text;
                MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3; Uid=Banipal; pwd=Banipal12345.; database=Banipal;");
                MySqlCommand komut = new MySqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "select * from tbl_ogrenci enroll='" + sql + "'";
                MySqlDataAdapter adapter = new MySqlDataAdapter(komut);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                if(ds.Tables[0].Rows.Count != 0)
                {
                    txt_No2.Text = ds.Tables[0].Rows[0][1].ToString();
                    txt_Oad.Text= ds.Tables[0].Rows[0][2].ToString();
                    txt_Osoyad.Text= ds.Tables[0].Rows[0][3].ToString();
                    txt_tlf.Text= ds.Tables[0].Rows[0][4].ToString();
                    txt_Posta.Text= ds.Tables[0].Rows[0][5].ToString();
                    txt_Blm.Text= ds.Tables[0].Rows[0][6].ToString();
                }
                */
            }
            


           
          
        }

        private void txt_No_TextChanged(object sender, EventArgs e)
        {
           baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select * from tbl_ogrenci like'" + txt_No.Text + "'", baglanti);
            MySqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txt_No2.Text= read.GetString(0);
                txt_Oad.Text= read.GetString(0);
                txt_Osoyad.Text= read.GetString(0);
                txt_tlf.Text= read.GetString(0);
                txt_Posta.Text= read.GetString(0);
                txt_Blm.Text= read.GetString(0);
            }
            baglanti.Close();
        }

        private void Odunc_Load(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3; Uid=Banipal; pwd=Banipal12345.; database=Banipal;");
            MySqlCommand komut = new MySqlCommand();
            komut.Connection = baglanti; 
            baglanti.Open();
            komut = new MySqlCommand("select ogrno from tbl_ogrenci",baglanti);
            MySqlDataReader reader = komut.ExecuteReader();
            reader.Close();
            baglanti.Close();
        }
    }
}
