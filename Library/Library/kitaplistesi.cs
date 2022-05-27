using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class kitaplistesi : Form
    {
        public kitaplistesi()
        {
            InitializeComponent();
        }

        MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3; Uid=Banipal; pwd=Banipal12345.; database=Banipal;");
        MySqlDataAdapter da = new MySqlDataAdapter();
        MySqlCommand cmd = new MySqlCommand();
        DataSet ds = new DataSet();
        void griddoldur()
        {
            da = new MySqlDataAdapter("select*from tbl_kitap", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "kitap");
            dataGridView1.DataSource = ds.Tables["kitap"];

            dataGridView1.Columns[0].HeaderCell.Value = "ID";
            dataGridView1.Columns[1].HeaderCell.Value = "Kitap Adı";
            dataGridView1.Columns[2].HeaderCell.Value = "Kategori";
            dataGridView1.Columns[3].HeaderCell.Value = "Basım Yılı";
            dataGridView1.Columns[4].HeaderCell.Value = "Yayınevi";
            dataGridView1.Columns[5].HeaderCell.Value = "Sayfa Sayısı";
            dataGridView1.Columns[6].HeaderCell.Value = "Yazar Adı";


            /* dataGridView1.Columns[0].Name = "ID";
             dataGridView1.Columns[1].Name = "Kitap Adı";
             dataGridView1.Columns[2].Name = "Kategori";
             dataGridView1.Columns[3].Name = "Basım Yılı";
             dataGridView1.Columns[4].Name = "Yayınevi";
             dataGridView1.Columns[5].Name = "Sayfa Sayısı";
             dataGridView1.Columns[6].Name = "Yazar Adı";*/
            baglanti.Close();
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void kitaplistesi_Load(object sender, EventArgs e)
        {
            /*string sql = "Server=172.21.54.3; Uid=Banipal; pwd=Banipal12345.; database=Banipal;";
            MySqlConnection con = new MySqlConnection(sql);*/
            griddoldur();
        }
        int ID = 0;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.AllowUserToDeleteRows = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            /* dataGridView1.ColumnCount = 7;
             dataGridView1.Columns[0].HeaderCell.Value = "ID";
             dataGridView1.Columns[1].HeaderCell.Value = "Kitap Adı";
             dataGridView1.Columns[2].HeaderCell.Value= "Kategori";
             dataGridView1.Columns[3].HeaderCell.Value = "Basım Yılı";
             dataGridView1.Columns[4].HeaderCell.Value = "Yayınevi";
             dataGridView1.Columns[5].HeaderCell.Value = "Sayfa Sayısı";
             dataGridView1.Columns[6].HeaderCell.Value = "Yazar Adı";
            dataGridView1.Rows.Add("");*/
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            /*DialogResult dialog;
            dialog = MessageBox.Show("Silmek istediğinize emin misiniz?"), "Sil", MessageBoxButtons.YesNo,;
            if (dialog == DialogResult.Yes)
            {
                baglanti.Open();
                MySqlCommand komut= new MySqlCommand("delete from kitap where kitapID-Ki")
            }
            */

        }
    }
}
