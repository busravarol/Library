using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Library
{
    public partial class giris : Form
    {
       
        MySqlDataReader dr;
        public giris()
        {
            InitializeComponent();
            
        }
        public static MySqlConnection GetConnection()
        {

            string sql = "Server=172.21.54.3; Uid=Banipal; pwd=Banipal12345.; database=Banipal;";
            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"{ex}");
            }
            return con;
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
            string sqlCommand = "Select * FROM tbl_giris where kullaniciadi='" + txtUsername.Text + "'AND sifre='" + txtSifre.Text + "'";
            string user =txtUsername.Text;
            string sifre =txtSifre.Text;
            
             GetConnection();
            MySqlCommand command = new MySqlCommand(sqlCommand,GetConnection());

            dr= command.ExecuteReader();
            if (dr.Read())
            {
                this.Hide();
                Form2 form = new Form2();
                form.Show();
            }
            else
            {
                MessageBox.Show("Kullanýcý Adý ya da Þifre yanlýþ","Eror",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           /* SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Server=172.21.54.3; uid=Banipal; pwd=Banipal12345.;database=Banipal";
            baglanti.Open();
            MessageBox.Show("31");
            SqlCommand komutum = new SqlCommand();
            komutum.Connection = baglanti;
            komutum.CommandText = "select * from tbl_giris where kullanýcýadi ='" + txtUsername.Text + "' and sifre ='" + txtSifre.Text + "'";
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
                MessageBox.Show("Yanlýþ Kullanýcý Adý ya da Þifre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
          */
        }
    }
}
   