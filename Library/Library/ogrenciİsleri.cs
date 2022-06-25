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
    public partial class ogrenciİsleri : Form
    {
        public ogrenciİsleri()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3; Uid=Banipal; pwd=Banipal12345.; database=Banipal;");
        MySqlDataAdapter da = new MySqlDataAdapter();
        MySqlCommand cmd = new MySqlCommand();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        bool emptyBox;

        public void listelemanet()
        {
            baglanti.Open();

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM tbl_odunc", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Öğrenci No")
            {

                MySqlDataAdapter da = new MySqlDataAdapter("select * from tbl_odunc where ogrno like'" + textBox1.Text + "%'", baglanti);



                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;


                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[9].Value.ToString() == "Teslim Alindi")
                    {
                        button1.Visible = true;
                        emptyBox = true;
                    }
                }



            }
            else if (comboBox1.Text == "Öğrenci Ad")
            {
                MySqlDataAdapter da = new MySqlDataAdapter("select * from tbl_odunc where ograd like'" + textBox1.Text + "%'", baglanti);



                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[9].Value.ToString() == "Teslim Alindi")
                    {
                        button1.Visible = true;
                        emptyBox = true;

                    }
                }

            }

            else if (comboBox1.Text == "Öğrenci Soyad")
            {

                MySqlDataAdapter da = new MySqlDataAdapter("select * from tbl_odunc where ogrsoyad like'" + textBox1.Text + "%'", baglanti);



                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[9].Value.ToString() == "Teslim Alindi")
                    {
                        button1.Visible = true;
                        emptyBox = true;

                    }
                }
            }
            if (textBox1.Text == "")
            {
                button1.Visible = false;
            }
            if (dataGridView1.Rows.Count == 1)
            {
                button1.Visible = false;
            }
        }

        private void ogrenciİsleri_Load(object sender, EventArgs e)
        {
            listelemanet();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Belge Verildi! Almak İçin OK'a Basın.");
            System.Diagnostics.Process.Start("https://docs.google.com/document/d/1CQuo5pUr1WReHRSAWFSIAWAGITs-HbbS/edit?usp=sharing&ouid=103281766253877385045&rtpof=true&sd=true");

            Form form = new ogrenciİsleri();
            form.Show();
            this.Close();
        }
    }
    
}
