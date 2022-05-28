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
        MySqlCommand komut = new MySqlCommand();
        

        private void Odunc2_Load(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3; Uid=Banipal; pwd=Banipal12345.; database=Banipal;");
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = baglanti;
            baglanti.Open();
            cmd=new MySqlCommand("select kitapadi from tbl_kitap ",baglanti);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                for(int i = 0; i < dr.FieldCount; i++)
                {
                    txt_Kitap.Text = dr[i].ToString();
                }
            }
            dr.Close();
            baglanti.Close();
        }

        private void txt_No_TextChanged(object sender, EventArgs e)
        {
           /* MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3; Uid=Banipal; pwd=Banipal12345.; database=Banipal;");

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
            baglanti.Close();*/
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnarama_Click(object sender, EventArgs e)
        {
            if(txt_No.Text != "")
            {
                string edi = txt_No.Text;
                MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3; Uid=Banipal; pwd=Banipal12345.; database=Banipal;");
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = baglanti;

                cmd.CommandText = "select * from tbl_ogrenci where ogrno='" + edi + "'";
                MySqlDataAdapter Da = new MySqlDataAdapter(cmd);
                DataSet Ds = new DataSet();
                Da.Fill(Ds);
               /* cmd.CommandText ="select count(ogrno) from tbl_odunc where ogrno='"+edi + "' and teslimverilecektarih is null";
                MySqlDataAdapter DA1 =new MySqlDataAdapter(cmd);
                DataSet DS1 =new DataSet();
                Da.Fill(DS1);
                
                count = int.Parse(DS1.Tables[0].Rows[0][0].ToString)();*/

                if(Ds.Tables[0].Rows.Count != 0)
                {   
                    txt_Ad.Text = Ds.Tables[0].Rows[0][1].ToString();
                    txt_Soyad.Text=Ds.Tables[0].Rows[0][2].ToString();
                    txt_tlf.Text=Ds.Tables[0].Rows[0][3].ToString();
                    txt_posta.Text=Ds.Tables[0].Rows[0][4].ToString();
                    txt_blm.Text=Ds.Tables[0].Rows[0][5].ToString();

                }
                else
                {
                    txt_Ad.Clear();
                    txt_Soyad.Clear();
                    txt_tlf.Clear();
                    txt_posta.Clear();
                    txt_blm.Clear();
                    MessageBox.Show("Ögrenci Bulunamamaktadır.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void btn_Teslim_Click(object sender, EventArgs e)
        {


            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("insert into tbl_odunc(ograd,ogrsoyad,ogrtelefon,ogreposta,ogrbolumad,kitapadi,teslimalinantarih) values (@k1,@k2,@k3,@k4,@k5,@k6,@k7) ", baglanti);
            komut.Parameters.AddWithValue("@k1", txt_Ad.Text);
            komut.Parameters.AddWithValue("@k2", txt_Soyad.Text);
            komut.Parameters.AddWithValue("@k3", txt_tlf.Text);
            komut.Parameters.AddWithValue("@k4", txt_posta.Text);
            komut.Parameters.AddWithValue("@k5", txt_blm.Text);
            komut.Parameters.AddWithValue("@k6", txt_Kitap.Text);
            komut.Parameters.AddWithValue("@k7", dateTimePicker1.Value);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Teslim Edildi");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
