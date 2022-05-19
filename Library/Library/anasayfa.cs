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
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void kitapEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            kitap form = new kitap();
            form.Show();
        }

        private void öDÜNÇKİTAPLARToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
