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
            griddoldur2();
        }
        int ID=0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_AutoSizeRowsModeChanged(object sender, DataGridViewAutoSizeModeEventArgs e)
        {

        }
    }
}
