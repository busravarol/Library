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
    public partial class Kaydol : Form
    {
        public Kaydol()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3; Uid=Banipal; pwd=Banipal12345.; database=Banipal;");

        private void GirisYap_btn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("insert into Memur(Adi,Soyadi,Kullanici_Adi,Kullanici_Sifre,Bolum_Adi) values (@k1,@k2,@k3,@k4,@k5) ", baglanti);
            komut.Parameters.AddWithValue("@k1", textBox1.Text);
            komut.Parameters.AddWithValue("@k2", textBox2.Text);
            komut.Parameters.AddWithValue("@k3", textBox3.Text);
            komut.Parameters.AddWithValue("@k4", textBox4.Text);
            komut.Parameters.AddWithValue("@k5", comboBox1.Text);
           
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kullanıcı Başarıyla Eklendi");
        }

        private void textBox4_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox4.Text == "Password")
            {
                textBox4.Clear();
                textBox4.UseSystemPasswordChar = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Kaydol_Load(object sender, EventArgs e)
        {

        }
    }
}
