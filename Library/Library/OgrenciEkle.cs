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
        MySqlConnection con2 = new MySqlConnection(@"Server = 172.21.54.3; Uid=Banipal; pwd=Banipal12345.; database=Banipal;");
        private void BtnOgrenciEkle_Click(object sender, EventArgs e, MySqlConnection baglanti)
        {
           
           /* baglanti.Open();

            MySqlCommand komutum = new MySqlCommand();
            komutum.Connection = baglanti;
            komutum.CommandText = "insert into tbl_ogrenci(ogrno, ograd, ogrsoyad, ogrtelefon, ogreposta, ogrbolumad) values (@ogrno, @ograd, @ogrsoyad, @ogrtelefon @ogreposta, @ogrbolumad)";

            string sorgu = "INSERT INTO tbl_ogrenci (ogrno, ograd, ogrsoyad, ogrtelefon, ogreposta , ogrbolumad) VALUES('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text
+ "' ,'" + textBox5.Text + "', '" + textBox6.Text + "',0,0)";
            komutum.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Kaydı Yapıldı.");*/

        }

        MySqlCommand cmd = new MySqlCommand();
        int ögrenci_sayisi;
        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {//nerede 
            ögrenci_sayisi = 0;
            con2.Open();
            cmd = new MySqlCommand("select count(*) from tbl_ogrenci where ogrno=@gelenno ", con2);
            cmd.Parameters.AddWithValue("@gelenno", txt_no.Text);
            ögrenci_sayisi = int.Parse(cmd.ExecuteScalar().ToString());
            con2.Close();
            MessageBox.Show(ögrenci_sayisi.ToString());
            if (ögrenci_sayisi>0)
            {
                MessageBox.Show("AYNI ÖĞRENCİ VAR");
            }
            else
            {
                con.Open();
                MySqlCommand komutum = new MySqlCommand();
                komutum.Connection = con;
                komutum.CommandText = "insert into tbl_ogrenci(ogrno, ograd, ogrsoyad, ogrtelefon, ogrPosta, ogrBolumAd) values (@ogrno, @ograd, @ogrsoyad, @ogrtelefon, @ogreposta, @ogrbolumad)";
                komutum.Parameters.AddWithValue("@ogrno", txt_no.Text);
                komutum.Parameters.AddWithValue("@ograd", txt_ad.Text);
                komutum.Parameters.AddWithValue("@ogrsoyad", txt_soyad.Text);
                komutum.Parameters.AddWithValue("@ogrtelefon", txt_tlf.Text);
                komutum.Parameters.AddWithValue("@ogreposta", txt_mail.Text);
                komutum.Parameters.AddWithValue("@ogrbolumad", bolum_Box.SelectedItem);
                komutum.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Öğrenci Başarıyla Eklendi.");
            }
            

           



                /* string sorgu = "INSERT INTO tbl_ogrenci (ogrno, ograd, ogrsoyad, ogrtelefon, ogrPosta , ogrBolumAd) VALUES('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text
     + "' ,'" + textBox5.Text + "', '" + textBox6.Text + "',0,0)";
                 komutum.ExecuteNonQuery();
                 con.Close();
                 MessageBox.Show("Öğrenci Kaydı Yapıldı.");*/
            }

        private void txt_ad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnİptal_Click(object sender, EventArgs e)
        {

        }

        private void bolum_Box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OgrenciEkle_Load(object sender, EventArgs e)
        {
            object[] bolum = new object[] { "Yönetim Bilişim Sistemleri", "İşletme", "Uluslararası Ticaret ve İşletmecilik","Çocuk Gelişimi","Elektrik ve Elektronik","Dış Ticaret", };
            bolum_Box.Items.AddRange(bolum);
            bolum_Box.Text = "Seçiniz...";
        }
    }
}
