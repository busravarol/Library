using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Library
{
    public partial class UyeListesi : Form
    {
        public Form1 frm1;
        public UyeListesi()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3; Uid=Banipal; pwd=Banipal12345.; database=Banipal;");

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "Select * From tbl_ogrenci";
            DataSet ds = frm1.VeriGetir(sorgu);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string sorgu = "Select * From tbl_ogrenci where (ograd like '%" + textBox3.Text + "%')";
            DataSet ds = frm1.VeriGetir(sorgu);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string sorgu = "Select * From tbl_ogrenci where (ogrsoyad like '%" + textBox4.Text + "%')";
            DataSet ds = frm1.VeriGetir(sorgu);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string sorgu = "Select * From tbl_ogrenci where (ogrno like '%" + textBox5.Text + "%')";
            DataSet ds = frm1.VeriGetir(sorgu);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            string sorgu = "Select * From tbl_ogrenci where (ogrBolumAd like '%" + textBox6.Text + "%')";
            DataSet ds = frm1.VeriGetir(sorgu);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string sorgu = "Select * From tbl_ogrenci where (ogrPosta like '%" + textBox1.Text + "%')";
            DataSet ds = frm1.VeriGetir(sorgu);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            string sorgu = "Select * From tbl_ogrenci where (ogrtelefon like '%" + textBox7.Text + "%')";
            DataSet ds = frm1.VeriGetir(sorgu);
            dataGridView1.DataSource = ds.Tables[0];
        }

       /* private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string sorgu = "Select * From tbl_ogrenci where (ogrtcno like '%" + textBox2.Text + "%')";
            DataSet ds = frm1.VeriGetir(sorgu);
            dataGridView1.DataSource = ds.Tables[0];
        }*/
    }
}
