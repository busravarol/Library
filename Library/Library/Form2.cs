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
            this.IsMdiContainer = true;
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

       /* private void kitapEkleToolStripMenuItem_Click(object sender, EventArgs e)
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
        }*/
        private kitap kitapform;
        private bool kitapDurum;
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (kitapDurum == false)
            {
                kitapform = new kitap();
                kitapform.MdiParent = this;
                kitapform.Show();
                kitapDurum = true;
            }else
            {
                kitapform.Close();
                kitapDurum = false;
            }  
                
            
        }
        private kitaplistesi kitaplistesiform;
        private bool listedurum;
        private void button4_Click(object sender, EventArgs e)
        {
            if (listedurum == false)
            {
                kitaplistesiform = new kitaplistesi();
                kitaplistesiform.MdiParent = this;
                kitaplistesiform.Show();
                listedurum = true;
            }
            else
            {
                kitaplistesiform.Close();
               listedurum=false;

            }
        }
        private Odunc2 oduncform;
        private bool oduncDurum;    
        private void button5_Click(object sender, EventArgs e)
        { if (oduncDurum == false)
            {
                oduncform = new Odunc2();
                oduncform.MdiParent = this;
                oduncform.Show();
                oduncDurum = true;
            }
            else
            {
                oduncform.Close();
                oduncDurum = false;
            }
        }
        private OduncListesi odunclistesiform;
        private bool odunclisteDurum;
        private void button6_Click(object sender, EventArgs e)
        { if (odunclisteDurum == false)
            {
                odunclistesiform = new OduncListesi();
                odunclistesiform.MdiParent = this;
                odunclistesiform.Show();
                odunclisteDurum=true;
            }
            else
            {
                odunclistesiform.Close();
                odunclisteDurum = false;
            }
        }
        private OgrenciEkle OgrenciEkleform;
        private bool OgrenciEkleDurum;
        private void button3_Click(object sender, EventArgs e)
        { if (OgrenciEkleDurum == false)
            {
                OgrenciEkleform = new OgrenciEkle();
                OgrenciEkleform.MdiParent = this;
                OgrenciEkleform.Show();
                OgrenciEkleDurum=true;
            }
            else
            {
                OgrenciEkleform.Close();
                OgrenciEkleDurum = false;
            }
        }
        private UyeListesi UyeListesiform;
        private bool UyeListesiformDurum;
        private void button2_Click_1(object sender, EventArgs e)
        { if (UyeListesiformDurum == false)
            {
                UyeListesiform = new UyeListesi();
                UyeListesiform.MdiParent = this;
                UyeListesiform.Show();
                UyeListesiformDurum=true;
            }
            else
            {
                UyeListesiform.Close();
                UyeListesiformDurum = false;
            }
        }
        private istatistik istatistikform;
        private bool istatistikformDurum;
        private void button7_Click(object sender, EventArgs e)
        { if (istatistikformDurum == false)
            {
                istatistikform = new istatistik();
                istatistikform.MdiParent = this;
                istatistikform.Show();
                istatistikformDurum=true;
            }
            else
            {
                istatistikform.Close();
                istatistikformDurum = false;
            }
        }
    }
}
