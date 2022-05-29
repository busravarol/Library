using MySql.Data.MySqlClient;


using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Library
{
    public partial class OgrenciEkle : Form
    {
        MySqlConnection con;
        public OgrenciEkle()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=172.21.54.3; Uid=Banipal; pwd=Banipal12345.; database=Banipal;");
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection();
            baglanti.ConnectionString =
                "Server=172.21.54.3; Uid=Banipal; pwd=Banipal12345.; database=Banipal";
            baglanti.Open();

            MySqlCommand komutum = new MySqlCommand();
            komutum.Connection = baglanti;
            komutum.CommandText = "insert into tbl_ogrenci(ogrno, ograd, ogrsoyad, ogrtelefon, ogreposta, ogrbolumad) values (@ogrno, @ograd, @ogrsoyad, @ogrtelefon @ogreposta, @ogrbolumad)";
            
            string sorgu = "INSERT INTO tbl_ogrenci (ogrno, ograd, ogrsoyad, ogrtelefon, ogreposta , ogrbolumad) VALUES('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text
+ "' ,'" + textBox5.Text + "', '" + textBox6.Text + "',0,0)";
            komutum.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Kaydı Yapıldı.");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
