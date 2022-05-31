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
    public partial class TeslimAl : Form
    {
        public TeslimAl()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3; Uid=Banipal; pwd=Banipal12345.; database=Banipal;");
        MySqlDataAdapter da = new MySqlDataAdapter();
        MySqlCommand cmd = new MySqlCommand();
        DataSet ds = new DataSet();
       /* void griddoldur3()
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
            dataGridView1.Columns[9].HeaderCell.Value = "Teslim Verilen Tarih";
            baglanti.Close();



        }*/
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Ara_Click(object sender, EventArgs e)
        {
          /*  MySqlCommand cmd =new MySqlCommand();
            cmd.Connection = baglanti;
            baglanti.Open();
            cmd.CommandText = "select * from tbl_odunc where ogrno='" + txt_no.Text + "' and teslimver IS NULL ";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds=new DataSet();
            da.Fill(ds);
            
            if(ds.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[0].Rows;
            }
            else
            {
                MessageBox.Show("Teslim Verilen Kitap Yok.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            baglanti.Close();*/
        }

        private void btn_al_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = baglanti;
            baglanti.Open();
            cmd.CommandText = "update tbl_odunc set teslimver='" + dateTimePicker1.Text + "' where ogrno='" + txt_no + "'and oduncID='"+rowid+"'";
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Teslim Alma Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            /*TeslimAl_Load(this, null);*/
           


        }
        string kad;
        string vtarih;
        Int64 rowid;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
           /* dataGridView1.AllowUserToAddRows = true;
            dataGridView1.AllowUserToDeleteRows = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            /* if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
             {
                 rowid=Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                 kad=dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                 vtarih=dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
             }
             txt_kiad.Text=kad;
             txt_vetarih.Text=vtarih;*/

        }

        private void TeslimAl_Load(object sender, EventArgs e)
        {
            
            txt_no.Clear();
           /* griddoldur3();*/
        }
        int ID = 0;

        private void txt_no_TextChanged(object sender, EventArgs e)
        {
            /*if(txt_no.Text == "")
            {
                
                dataGridView1.DataSource=null;
            }*/
        }

        private void btn_yenile_Click(object sender, EventArgs e)
        {
            txt_no.Clear();
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
