using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Library
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUsername.Text == "Username") {
                txtUsername.Clear();    
            }
        }

        private void txtSifre_MouseClick_1(object sender, MouseEventArgs e)
        {
            if(txtSifre.Text == "Password")
            {
                txtSifre.Clear();   
                txtSifre.UseSystemPasswordChar = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection();
            baglanti.ConnectionString = "Server=172.21.54.3; uid=Banipal; pwd=Banipal12345.; database=tbl_giris";
            baglanti.Open();
            MySqlCommand komutum = new MySqlCommand();
            komutum.Connection = baglanti;
            komutum.CommandText= "select * from tbl_giris where kullanýcýadi ='"+txtUsername.Text+"' and sifre ='"+txtSifre.Text+"'";
            komutum.ExecuteNonQuery();

            MySqlDataAdapter da = new SqlDataAdapter(komutum);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if(ds.Tables[0].Rows.Count != 0) 
            {
                this.Hide();
                Form2 anasayfa = new Form2();
                anasayfa.Show();
            }
            else
            {
                MessageBox.Show("Yanlýþ Kullanýcý Adý ya da Þifre", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

   