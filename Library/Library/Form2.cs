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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void öğrenciToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkış yapmak istediğine emin misin?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void kitapEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kitap form = new kitap();
            form.Show();
        }

        private void kitapListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kitaplistesi vb = new kitaplistesi();
            vb.Show();
        }

        private void öğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciEkle ogrenciEkle = new OgrenciEkle();
            ogrenciEkle.Show();

        }

        private void iadeKitaplarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Odunc2 odunc = new Odunc2();
            odunc.Show();
        }

        private void kitapDetaylarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OduncListesi oduncListesi = new OduncListesi();
            oduncListesi.Show();
        }

        private void ıssueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kitaplistesi vb = new kitaplistesi();
            vb.Show();
        }

        private void istatistikVerilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            istatistik istatistik = new istatistik();
            istatistik.Show();
        }

        private void öğrenciDetayıGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UyeListesi uyeListesi = new UyeListesi();
            uyeListesi.Show();
        }
    }
}
