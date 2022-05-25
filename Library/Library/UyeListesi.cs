using MySql.Data.MySqlClient;


using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Library
{
    public partial class UyeListesi : Form
    {
        MySqlConnection con;
        public Form1 frm1;

        
       

        public UyeListesi()
        {

        InitializeComponent();
            con = new MySqlConnection("Server=172.21.54.3; Uid=Banipal; pwd=Banipal12345.; database=Banipal;");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection();
            baglanti.ConnectionString =
                "Server=172.21.54.3; Uid=Banipal; pwd=Banipal12345.; database=Banipal";
            string sorgu = "Select * From Uyebilgisi";
            DataSet ds = frm1.VeriGetir(sorgu);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            string sorgu = "Select * From UyeBilgisi where (ogrtc like '%" + textBox7.Text + "%')";
            DataSet ds = frm1.VeriGetir(sorgu);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
