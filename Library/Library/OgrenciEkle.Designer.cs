namespace Library
{
    partial class OgrenciEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciEkle));
            this.txt_no = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_tlf = new System.Windows.Forms.TextBox();
            this.Ad = new System.Windows.Forms.Label();
            this.Soyad = new System.Windows.Forms.Label();
            this.OgrenciNo = new System.Windows.Forms.Label();
            this.BolumAdi = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Telefon = new System.Windows.Forms.Label();
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.btnİptal = new System.Windows.Forms.Button();
            this.bolum_Box = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_no
            // 
            this.txt_no.Location = new System.Drawing.Point(166, 196);
            this.txt_no.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_no.Name = "txt_no";
            this.txt_no.Size = new System.Drawing.Size(172, 27);
            this.txt_no.TabIndex = 0;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(166, 293);
            this.txt_soyad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(172, 27);
            this.txt_soyad.TabIndex = 1;
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(166, 246);
            this.txt_ad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(172, 27);
            this.txt_ad.TabIndex = 2;
            this.txt_ad.TextChanged += new System.EventHandler(this.txt_ad_TextChanged);
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(166, 381);
            this.txt_mail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(172, 27);
            this.txt_mail.TabIndex = 4;
            // 
            // txt_tlf
            // 
            this.txt_tlf.Location = new System.Drawing.Point(166, 426);
            this.txt_tlf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_tlf.Name = "txt_tlf";
            this.txt_tlf.Size = new System.Drawing.Size(172, 27);
            this.txt_tlf.TabIndex = 5;
            // 
            // Ad
            // 
            this.Ad.AutoSize = true;
            this.Ad.Location = new System.Drawing.Point(49, 253);
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(28, 20);
            this.Ad.TabIndex = 6;
            this.Ad.Text = "Ad";
            // 
            // Soyad
            // 
            this.Soyad.AutoSize = true;
            this.Soyad.Location = new System.Drawing.Point(49, 300);
            this.Soyad.Name = "Soyad";
            this.Soyad.Size = new System.Drawing.Size(50, 20);
            this.Soyad.TabIndex = 7;
            this.Soyad.Text = "Soyad";
            // 
            // OgrenciNo
            // 
            this.OgrenciNo.AutoSize = true;
            this.OgrenciNo.Location = new System.Drawing.Point(49, 200);
            this.OgrenciNo.Name = "OgrenciNo";
            this.OgrenciNo.Size = new System.Drawing.Size(85, 20);
            this.OgrenciNo.TabIndex = 8;
            this.OgrenciNo.Text = "Öğrenci No";
            // 
            // BolumAdi
            // 
            this.BolumAdi.AutoSize = true;
            this.BolumAdi.Location = new System.Drawing.Point(49, 344);
            this.BolumAdi.Name = "BolumAdi";
            this.BolumAdi.Size = new System.Drawing.Size(79, 20);
            this.BolumAdi.TabIndex = 9;
            this.BolumAdi.Text = "Bölüm Adı";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(49, 384);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(46, 20);
            this.Email.TabIndex = 10;
            this.Email.Text = "Email";
            // 
            // Telefon
            // 
            this.Telefon.AutoSize = true;
            this.Telefon.Location = new System.Drawing.Point(49, 430);
            this.Telefon.Name = "Telefon";
            this.Telefon.Size = new System.Drawing.Size(58, 20);
            this.Telefon.TabIndex = 11;
            this.Telefon.Text = "Telefon";
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(160)))));
            this.btnOgrenciEkle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOgrenciEkle.Location = new System.Drawing.Point(132, 514);
            this.btnOgrenciEkle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(170, 65);
            this.btnOgrenciEkle.TabIndex = 12;
            this.btnOgrenciEkle.Text = "Ekle";
            this.btnOgrenciEkle.UseVisualStyleBackColor = false;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // btnİptal
            // 
            this.btnİptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(160)))));
            this.btnİptal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnİptal.Location = new System.Drawing.Point(336, 514);
            this.btnİptal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(173, 65);
            this.btnİptal.TabIndex = 13;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = false;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // bolum_Box
            // 
            this.bolum_Box.FormattingEnabled = true;
            this.bolum_Box.Location = new System.Drawing.Point(166, 336);
            this.bolum_Box.Name = "bolum_Box";
            this.bolum_Box.Size = new System.Drawing.Size(172, 28);
            this.bolum_Box.TabIndex = 15;
            this.bolum_Box.SelectedIndexChanged += new System.EventHandler(this.bolum_Box_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.OgrenciNo);
            this.panel1.Controls.Add(this.bolum_Box);
            this.panel1.Controls.Add(this.txt_no);
            this.panel1.Controls.Add(this.txt_soyad);
            this.panel1.Controls.Add(this.txt_ad);
            this.panel1.Controls.Add(this.Telefon);
            this.panel1.Controls.Add(this.txt_mail);
            this.panel1.Controls.Add(this.Email);
            this.panel1.Controls.Add(this.txt_tlf);
            this.panel1.Controls.Add(this.BolumAdi);
            this.panel1.Controls.Add(this.Ad);
            this.panel1.Controls.Add(this.Soyad);
            this.panel1.Location = new System.Drawing.Point(132, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 493);
            this.panel1.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(129, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // OgrenciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(692, 617);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnOgrenciEkle);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OgrenciEkle";
            this.Text = "OgrenciEkle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OgrenciEkle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

       
        #endregion

        private TextBox txt_no;
        private TextBox txt_soyad;
        private TextBox txt_ad;
        private TextBox txt_mail;
        private TextBox txt_tlf;
        private Label Ad;
        private Label Soyad;
        private Label OgrenciNo;
        private Label BolumAdi;
        private Label Email;
        private Label Telefon;
        private Button btnOgrenciEkle;
        private Button btnİptal;
        private ComboBox bolum_Box;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}