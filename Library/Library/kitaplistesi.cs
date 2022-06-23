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
        DataTable dt = new DataTable();
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
            dataGridView1.Columns[6].HeaderCell.Value = "Dil";
            dataGridView1.Columns[7].HeaderCell.Value = "Stok Sayısı";
            dataGridView1.Columns[8].HeaderCell.Value = "Dolap No";
            dataGridView1.Columns[9].HeaderCell.Value = "Raf No";


            /* dataGridView1.Columns[0].Name = "ID";
             dataGridView1.Columns[1].Name = "Kitap Adı";
             dataGridView1.Columns[2].Name = "Kategori";
             dataGridView1.Columns[3].Name = "Basım Yılı";
             dataGridView1.Columns[4].Name = "Yayınevi";
             dataGridView1.Columns[5].Name = "Sayfa Sayısı";
             dataGridView1.Columns[6].Name = "Yazar Adı";*/
            baglanti.Close();
        }
        void KayıtSil (int kitapID)
        {
            string sql = "DELETE FROM tbl_kitap WHERE kitapID=@kitapID";
            cmd = new MySqlCommand(sql,baglanti);
            cmd.Parameters.AddWithValue("@kitapID",kitapID);
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }
      /*  void  KayıtGunceller(int kitapID)
        {
            string sql = "update tbl_kitap"+"Set kitapAdi=@ad, kategori=@kategori, basimyili=@yil, ";
        }*/
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
            if (MessageBox.Show("Veri Silinecek. Onaylıyor musunuz?", "Başarılı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
               /* MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3; Uid=Banipal; pwd=Banipal12345.; database=Banipal;");
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                DataSet ds = new DataSet();

                /*cmd.CommandText= "delete from NewBook where ID="  rowkitap+"";
               
                da.Fill(ds);*/
               foreach(DataGridViewRow drow in dataGridView1.SelectedRows)
                {
                    int kitapId=Convert.ToInt32(drow.Cells[0].Value);
                    KayıtSil(kitapId);
                }
                griddoldur();

            } 
           /* string sql = "Delete From tbl_kitap Where kitapID=@ıd";
            cmd= new MySqlCommand(sql, baglanti); 
            cmd.Parameters.AddWithValue("@ıd", txt_id);
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
            griddoldur();
            MessageBox.Show("Kitap Silindi!");*/
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("Kitap Güncellenecek Onaylıyor Musunuz?","Success",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                string kitapAdi = txt_ad.Text;
                string kategori = comboBox1.Text;
                Int32 basimyili = Int32.Parse(txt_yil.Text);
                string yayinevi= txt_yayinevi.Text;
                Int32 sayfasayisi = Int32.Parse(txt_ss.Text);
                string yazaradi = txt_yad.Text;
                cmd.Connection = baglanti;
                cmd.CommandText = "update tbl_kitap set kitapAdi='" + kitapAdi + "',kategori='" + kategori + "',basimyili='" + basimyili + "',yayinevi='" + yayinevi + "',sayfasayisi='" + sayfasayisi + "',yazaradi='" + yazaradi + "' WHERE kitapID='" + txt_id.Text  + "'";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);

          
                da.Fill(ds);
            }
           /* string sql = "update tbl_kitap set kitapAdi  ";
            cmd=new MySqlCommand(sql, baglanti);
           /* cmd.Parameters.AddWithValue("@p1",txt_id);
            cmd.Parameters.AddWithValue("@p2",txt_ad);
            cmd.Parameters.AddWithValue("@p3",txt_kat);
            cmd.Parameters.AddWithValue("@p4",txt_yil);
            cmd.Parameters.AddWithValue("@p5",txt_yayinevi);
            cmd.Parameters.AddWithValue("@p6",txt_ss);
            cmd.Parameters.AddWithValue("@p7",txt_yad);*/
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
            griddoldur();
            MessageBox.Show("Kitap Başarıyla Güncellendi!");

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_ara_TextChanged(object sender, EventArgs e)
        {
            /*DataView dv = dt.DefaultView;
            dv.RowFilter = "select kitapAdi from tbl_kitap where kitapAdi LIKE %";
            dataGridView1.DataSource= dv;*/
          /*  string aranan = txt_ara.Text.Trim().ToUpper();
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                    {
                        if (cell.Value != null)
                        {
                            if (cell.Value.ToString().ToUpper() == aranan)
                            {
                                cell.Style.BackColor = Color.DarkTurquoise;
                               
                                break;
                            }
                        }
                    }
                }
               
                

            }
            


            */
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
            }
            catch
            {

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_ad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_yil.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_yayinevi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_ss.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_yad.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtdolap.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtdil.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtstok.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtraf.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*string aranan = txt_ara1.Text.Trim().ToUpper();
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                    {
                        if (cell.Value != null)
                        {
                            if (cell.Value.ToString().ToUpper() == aranan)
                            {
                                cell.Style.BackColor = Color.DarkTurquoise;

                                break;
                            }
                        }
                    }
                }

            }*/
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_kat_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            baglanti.Open();
            if (comboBox2.Text == "Kitap Adı")
            {
                MySqlDataAdapter da = new MySqlDataAdapter("select* from tbl_kitap where kitapAdi like'%" + textBox1.Text + "%'", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
                if (textBox1.Text == "")
                {
                    griddoldur();
                }
            }
            else if (comboBox2.Text == "Yazar Adı")
            {
                MySqlDataAdapter da = new MySqlDataAdapter("select* from tbl_kitap where yazaradi like'%" + textBox1.Text + "%'", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
                if (textBox1.Text == "")
                {
                    griddoldur();
                }
            }
            else if (comboBox2.Text == "Dil")
            {
                MySqlDataAdapter da = new MySqlDataAdapter("select* from tbl_kitap where dil like'%" + textBox1.Text + "%'", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
                if (textBox1.Text == "")
                {
                    griddoldur();
                }
            }
            else if (comboBox2.Text == "Yayınevi")
            {
                MySqlDataAdapter da = new MySqlDataAdapter("select* from tbl_kitap where yayinevi like'%" + textBox1.Text + "%'", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
                if (textBox1.Text == "")
                {
                    griddoldur();
                }
            }
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
