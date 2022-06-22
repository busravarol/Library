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

            dataGridView1.Columns[0].HeaderCell.Value = "Öğrenci No";
            dataGridView1.Columns[1].HeaderCell.Value = "Ad";
            dataGridView1.Columns[2].HeaderCell.Value = "Soyad";
            dataGridView1.Columns[3].HeaderCell.Value = "Telefon";
            dataGridView1.Columns[4].HeaderCell.Value = "E-Posta";
            dataGridView1.Columns[5].HeaderCell.Value = "Bölüm";
            baglanti.Close();
        }
        void KayıtSil(int ogrno)
        {
            string sql = "DELETE FROM tbl_ogrenci WHERE ogrno=@ogrno";
            cmd = new MySqlCommand(sql, baglanti);
            cmd.Parameters.AddWithValue("@ogrno", ogrno);
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
                string ograd = txt_ad.Text;
                string ogrsoyad = txt_soyad.Text;
                Int64 ogrno = Int64.Parse(txt_no3.Text);
                string ogrBolumAd = txt_blm.Text;
                Int64 ogrtelefon = Int64.Parse(txt_tlf.Text);
                string ogrPosta = txt_mail.Text;
                cmd.Connection = baglanti;
                cmd.CommandText = "update tbl_ogrenci set ograd='" + ograd + "',ogrno='" + ogrno + "',ogrtelefon ='" + ogrtelefon + "',ogrBolumAd='" + ogrBolumAd + "',ogrsoyad='" + ogrsoyad + "',ogrPosta='" + ogrPosta + "' WHERE ogrno='" + ogrno + "'";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);

                da.Fill(ds);
            }
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
            griddoldur();
            MessageBox.Show("Öğrenci Başarıyla Güncellendi");
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
            /* if (MessageBox.Show("Veri Silinecek. Onaylıyor musunuz?", "Başarılı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                 foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
                 {
                     int ogrno= Convert.ToInt32(drow.Cells[0].Value);
                     KayıtSil(ogrno);
                 }
             griddoldur();*/
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           /* string aranan = txt_No1.Text.Trim().ToUpper();
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
                txt_no3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_ad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_soyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txt_tlf.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txt_mail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txt_blm.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            }
            catch
            {

            }
        }

        private void UyeListesi_Load(object sender, EventArgs e)
        {
            griddoldur();
        }
        int ID = 0;

        private void ogreposta_Click(object sender, EventArgs e)
        {

        }

        private void btniptal_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnsil_Click_1(object sender, EventArgs e)
        {

            if (MessageBox.Show("Veri Silinecek. Onaylıyor musunuz?", "Başarılı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
                {
                    int ogrno = Convert.ToInt32(drow.Cells[0].Value);
                    KayıtSil(ogrno);
                }
            griddoldur();
        }

        private void txt_No1_TextChanged(object sender, EventArgs e)
        {
          /*  string aranan = txt_No1.Text.Trim().ToUpper();
            for (int i = 0; i <= dataGridView1.Rows.Count - 1;i++)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           /* string aranan = textBox1.Text.Trim().ToUpper();
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
    }
}

