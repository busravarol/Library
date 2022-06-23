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
    public partial class OduncListesi : Form
    {
        public OduncListesi()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3; Uid=Banipal; pwd=Banipal12345.; database=Banipal;");
        MySqlDataAdapter da = new MySqlDataAdapter();
        MySqlCommand cmd = new MySqlCommand();
        DataSet ds = new DataSet();
        void griddoldur2()
        {
            da = new MySqlDataAdapter("select*from tbl_odunc", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "odunc");
            dataGridView1.DataSource = ds.Tables["odunc"];

            dataGridView1.Columns[0].HeaderCell.Value = "ÖdünçID";
            dataGridView1.Columns[1].HeaderCell.Value = "Kitap Adı";
            dataGridView1.Columns[2].HeaderCell.Value = "Öğrenci No";
            dataGridView1.Columns[3].HeaderCell.Value = "Öğrenci Ad";
            dataGridView1.Columns[4].HeaderCell.Value = "Öğrenci Soyad";
            dataGridView1.Columns[5].HeaderCell.Value = "Öğrenci Telefon";
            dataGridView1.Columns[6].HeaderCell.Value = "Öğrenci E-posta";
            dataGridView1.Columns[7].HeaderCell.Value = "Öğrenci Bölüm";
            dataGridView1.Columns[8].HeaderCell.Value = "Teslim Alınan Tarih";
            dataGridView1.Columns[9].HeaderCell.Value = "Teslim Verilecek Tarih";
            baglanti.Close();



        }

        private void OduncListesi_Load(object sender, EventArgs e)
        {
            /*  object[] kitapadi = new object[] { "Yaban", "Açık Ufuk", "İçimizdeki Şeytan", "İrade Terbiyesi", "1984", "Çocukluk", "Kinyas ve Kayra", "Elveda Güzel Vatanım", "Saatleri Ayarlama Enstitüsü", "İtiraflarım" };
              comboBox1.Items.AddRange(kitapadi);
              comboBox1.Text = "Seçiniz...";*/
            griddoldur2();
        }
        int ID = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_AutoSizeRowsModeChanged(object sender, DataGridViewAutoSizeModeEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lbl_Kitap_Click(object sender, EventArgs e)
        {

        }

        private void txt_Kitap1_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_Ogr1_TextChanged(object sender, EventArgs e)
        {
            /* string aranan = txt_Ogr1.Text.Trim().ToUpper();
             for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
             {
                 foreach (DataGridViewRow row in dataGridView1.Rows)
                 {
                     foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                     {
                         if (cell.Value != null)
                         {
                             if (cell.Value.ToString().ToUpper() == aranan)
                             {
                                 cell.Style.BackColor = Color.DarkTurquoise;

                                 break;
                             }
                         }
                     }
                 }
             }*/
        }

        private void txt_Yazar1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            /* string aranan = comboBox1.Text.Trim().ToUpper();
             for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
             {
                 foreach (DataGridViewRow row in dataGridView1.Rows)
                 {
                     foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                     {
                         if (cell.Value != null)
                         {
                             if (cell.Value.ToString().ToUpper() == aranan)
                             {
                                 cell.Style.BackColor = Color.DarkTurquoise;

                                 break;
                             }
                         }
                     }
                 }

             }*/
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {
            baglanti.Open();
            if (comboBox2.Text == "Öğrenci No")
            {
                MySqlDataAdapter da = new MySqlDataAdapter("select* from tbl_odunc where ogrno like'%" + textBox1.Text + "%'", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
                if (textBox1.Text == "")
                {
                    griddoldur2();
                }
            }
            else if (comboBox2.Text == "Öğrenci Ad")
            {
                MySqlDataAdapter da = new MySqlDataAdapter("select* from tbl_odunc where ograd like'%" + textBox1.Text + "%'", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
                if (textBox1.Text == "")
                {
                    griddoldur2();
                }
            }
            else if (comboBox2.Text == "Öğrenci Soyad")
            {
                MySqlDataAdapter da = new MySqlDataAdapter("select* from tbl_odunc where ogrsoyad like'%" + textBox1.Text + "%'", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
                if (textBox1.Text == "")
                {
                    griddoldur2();
                }
            }
            else if (comboBox2.Text == "Öğrenci Bölüm")
            {
                MySqlDataAdapter da = new MySqlDataAdapter("select* from tbl_odunc where ogrBolumAd like'%" + textBox1.Text + "%'", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
                if (textBox1.Text == "")
                {
                    griddoldur2();
                }
            }
            else if (comboBox2.Text == "Kitap Ad")
            {
                MySqlDataAdapter da = new MySqlDataAdapter("select* from tbl_odunc where kitapAdi like'%" + textBox1.Text + "%'", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
                if (textBox1.Text == "")
                {
                    griddoldur2();
                }
            }
           /* else if (comboBox2.Text == "Yazar Ad")
            {
                MySqlDataAdapter da = new MySqlDataAdapter("select* from tbl_odunc where ogrBolumAd like'%" + textBox1.Text + "%'", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
                if (textBox1.Text == "")
                {
                    griddoldur2();
                }
            }
            else if (comboBox2.Text == "Yayınevi Ad")
            {
                MySqlDataAdapter da = new MySqlDataAdapter("select* from tbl_odunc where ogrBolumAd like'%" + textBox1.Text + "%'", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
                if (textBox1.Text == "")
                {
                    griddoldur2();
                }
            }*/
        }
    }
}
