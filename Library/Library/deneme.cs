﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Library
{
    public partial class kitap : Form

    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        public kitap()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=172.21.54.3; Uid=Banipal; pwd=Banipal12345.; database=Banipal;");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void deneme_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           /*
            string kitapAdi = txt_Ad.Text;
            string yazar = txt_Yazar.Text;
            string yayinevi=txt_Yayinevi.Text;
            string kategori=txt_Kategori.Text;
            string tarih = eklendigi_tarih.Text;
            int kitapID = int.Parse(txt_ID.Text);
            int sayfaSayisi = int.Parse(txt_Ss.Text);
            int ısbn = int.Parse(txt_ISBN.Text);

           */
        }
    }
}
