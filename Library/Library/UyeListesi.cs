using MySql.Data.MySqlClient;


using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Library
{
    public partial class UyeListesi : Form
    {
        MySqlConnection con;
        /*public Form1 frm1;*/




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
            /* MySqlConnection baglanti = new MySqlConnection();
             baglanti.ConnectionString =
                 "Server=172.21.54.3; Uid=Banipal; pwd=Banipal12345.; database=Banipal";
             string sorgu = "Select * From Uyebilgisi";
             DataSet ds = frm1.VeriGetir(sorgu);
             dataGridView1.DataSource = ds.Tables[0];*/

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            /* string sorgu = "Select * From UyeBilgisi where (ogrtc like '%" + textBox7.Text + "%')";
             DataSet ds = frm1.VeriGetir(sorgu);
             dataGridView1.DataSource = ds.Tables[0];*/

        }
    }
}

/* baglanti.open();
 SqlCommand komut= new SqlCommand("select'from uye where tc like'"+txtTc.Text+"'",baglanti)
SqlDAataReader read = komut.ExecuteReader();
while(read.Read())
}

 txtAd.Text= read("ad").Tostring();
 txtSoyad.Text= read("soyad").Tostring();
 txtOgrenciNo.Text= read("ogrenciNo").Tostring();
 txtBolumAdi.Text= read("bolumAd").Tostring();
 txtEposta.Text= read("eposta").Tostring();
 txtTelefon.Text= read("telefon").Tostring();


private void textBox2_TextChanged(object sender, EventArgs e)
{
 string sorgu = "Select * From UyeBilgisi where (ograd like '%" + textBox2.Text + "%')";
 DataSet ds = frm1.VeriGetir(sorgu);
 dataGridView1.DataSource = ds.Tables[0];

}

private void textBox3_TextChanged(object sender, EventArgs e)
{
 string sorgu = "Select * From UyeBilgisi where (ogrsoyad like '%" + textBox3.Text + "%')";
 DataSet ds = frm1.VeriGetir(sorgu);
 dataGridView1.DataSource = ds.Tables[0];
}

private void textBox4_TextChanged(object sender, EventArgs e)
{
 string sorgu = "Select * From UyeBilgisi where (ogrno like '%" + textBox4.Text + "%')";
 DataSet ds = frm1.VeriGetir(sorgu);
 dataGridView1.DataSource = ds.Tables[0];
}

private void textBox5_TextChanged(object sender, EventArgs e)
{
 string sorgu = "Select * From UyeBilgisi where (ogrbolumad like '%" + textBox5.Text + "%')";
 DataSet ds = frm1.VeriGetir(sorgu);
 dataGridView1.DataSource = ds.Tables[0];
}

private void textBox6_TextChanged(object sender, EventArgs e)
{
 string sorgu = "Select * From UyeBilgisi where (ogreposta like '%" + textBox6.Text + "%')";
 DataSet ds = frm1.VeriGetir(sorgu);
 dataGridView1.DataSource = ds.Tables[0];
}

private void textBox1_TextChanged(object sender, EventArgs e)
{
 string sorgu = "Select * From UyeBilgisi where (ogrtelefon like '%" + textBox1.Text + "%')";
 DataSet ds = frm1.VeriGetir(sorgu);
 dataGridView1.DataSource = ds.Tables[0];
}
}
}*/
