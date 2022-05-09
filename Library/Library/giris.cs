namespace Library
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUsername.Text == "Username") {
                txtUsername.Clear();    
            }
        }

        private void txtSifre_MouseClick_1(object sender, MouseEventArgs e)
        {
            if(txtSifre.Text == "Password")
            {
                txtSifre.Clear();   
                txtSifre.UseSystemPasswordChar = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}