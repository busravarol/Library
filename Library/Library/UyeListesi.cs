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
        MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3; Uid=Banipal; pwd=Banipal12345.; database=Banipal;");
        MySqlDataAdapter da = new MySqlDataAdapter();
        MySqlCommand cmd = new MySqlCommand();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        void griddoldur()
        {
            
            da = new MySqlDataAdapter("select*from tbl_ogrenci", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "ogrenci");
            dataGridView1.DataSource = ds.Tables["ogrenci"];

            dataGridView1.Columns[0].HeaderCell.Value = "Ad";
            dataGridView1.Columns[1].HeaderCell.Value = "Soyad";
            dataGridView1.Columns[2].HeaderCell.Value = "Öğrenci No";
            dataGridView1.Columns[3].HeaderCell.Value = "Bölüm Adı";
            dataGridView1.Columns[4].HeaderCell.Value = "E-posta";
            dataGridView1.Columns[5].HeaderCell.Value = "Telefon";
            baglanti.Close();
        }
        void KayıtSil(int ograd)
        {
            string sql = "DELETE FROM tbl_ogrenci WHERE ograd=@ograd";
            cmd = new MySqlCommand(sql, baglanti);
            cmd.Parameters.AddWithValue("@ograd", ograd);
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.AllowUserToDeleteRows = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Öğrenci Güncellenecek Onaylıyor Musunuz?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string ograd = ograd.Text;
                string ogrsoyad = ogrsoyad.Text;
                Int32 ogrno = Int32.Parse(ogrno.Text);
                string ogrBolumAd = ogrBolumAd.Text;
                Int32 ogrtelefon = Int32.Parse(ogrtelefon.Text);
                string ogrPosta = ogrPosta.Text;
                cmd.Connection = baglanti;
                cmd.CommandText = "update tbl_ogrenci set ograd='" + textBox3.Text + "',ogrno='" + textBox5 + "',ogrtelefon ='" + textBox7 + "',ogrBolumAd='" + textBox6 + "',ogrsoyad='" + textBox4 + "',ogrPosta='" + textBox1;
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);

                da.Fill(ds);
            }
            /* if (MessageBox.Show("Öğrenci Güncellenecek Onaylıyor Musunuz?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
             {
                 string sorgu = "UPDATE tbl_ogrenci SET ograd='" + textBox3.Text + "',ogrno='" + textBox5 + "',ogrtelefon ='" + textBox7 + "',ogrBolumAd='" + textBox6 + "',ogrsoyad='" + textBox4 + "',ogrPposta='" + textBox1;
                 DataSet ds = frm1.VeriGetir(sorgu);
                 dataGridView1.DataSource = ds.Tables[0];
                 da.Fill(ds);
             }
             baglanti.Open();
             cmd.ExecuteNonQuery();
             baglanti.Close();
             griddoldur();
             MessageBox.Show("Öğrenci Başarıyla Güncellendi!");
            */
        }

        /* private void TextBox3_TextChanged(object sender, EventArgs e)
         {
             string sorgu = "Select * From tbl_ogrenci where (ograd like '%" + textBox3.Text + "%')";
             using DataSet ds = frm1.VeriGetir(sorgu);
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
        */
        private void btnsil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Veri Silinecek. Onaylıyor musunuz?", "Başarılı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
                {
                    int ograd= Convert.ToInt32(drow.Cells[0].Value);
                    KayıtSil(ograd);
                }
            griddoldur();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string aranan = ogrnoara.Text.Trim().ToUpper();
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                    {
                        if (cell.Value != null)
                        {
                            if (cell.Value.ToString().ToUpper() != aranan)
                            {
                                continue;
                            }
                            cell.Style.BackColor = Color.DarkTurquoise;

                            break;
                        }
                    }
                }
            }

        /* private void textBox2_TextChanged(object sender, EventArgs e)
         {
             string sorgu = "Select * From tbl_ogrenci where (ogrtcno like '%" + textBox2.Text + "%')";
             DataSet ds = frm1.VeriGetir(sorgu);
             dataGridView1.DataSource = ds.Tables[0];
         }*/
    }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ograd.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                ogrsoyad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                ogrno.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                ogrBolumAd.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                ogrtelefon.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                ogrPosta.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                
            }
            catch
            {

            }
        }
    }
}
