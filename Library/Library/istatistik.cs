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
            MySqlCommand komut1= new MySqlCommand("Select count (*) from toplam_Ogrenci", baglanti);
            MySqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read());
            {
                toplam_Ogrenci.Text = dr1[0].ToString();

            }
            baglanti.Close();

            MySqlCommand komut2 = new MySqlCommand("Select count (*) from toplam_Kitap", baglanti);
            MySqlDataReader dr2 = komut1.ExecuteReader();
            while (dr1.Read());
            {
                toplam_Kitap.Text = dr1[0].ToString();

            }
            baglanti.Close();

           /* MySqlCommand komutg1 = new MySqlCommand("Select toplam_Kitap,Count(*) as'En çok okunan kitap' from Kitap group by toplam_Kitap  ");*/

        }
    }
}
