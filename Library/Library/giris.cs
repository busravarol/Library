using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Library
{
    public partial class giris : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        public giris()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=172.21.54.3; Uid=Banipal; pwd=Banipal12345.; database=Banipal;");
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
            if (txtUsername.Text == "Username")
            {
                txtUsername.Clear();
            }
        }

        private void txtSifre_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (txtSifre.Text == "Password")
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
            string user =txtUsername.Text;
            string sifre =txtSifre.Text;
            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select * FROM tbl_giris where kullaniciadi='" + txtUsername.Text + "'AND sifre='" + txtSifre.Text + "'";
            dr= cmd.ExecuteReader();
            if (dr.Read())
            {
                this.Hide();
                anasayfa form = new anasayfa();
                form.Show();
            }
            else
            {
                MessageBox.Show("Kullan�c� Ad� ya da �ifre yanl��","Eror",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           /* SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Server=172.21.54.3; uid=Banipal; pwd=Banipal12345.;database=Banipal";
            baglanti.Open();
            MessageBox.Show("31");
            SqlCommand komutum = new SqlCommand();
            komutum.Connection = baglanti;
            komutum.CommandText = "select * from tbl_giris where kullan�c�adi ='" + txtUsername.Text + "' and sifre ='" + txtSifre.Text + "'";
            komutum.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(komutum);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                this.Hide();
                Form2 Form2 = new Form2();
                Form2.Show();
            }
            else
            {
                MessageBox.Show("Yanl�� Kullan�c� Ad� ya da �ifre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
          */
        }
    }
}
   