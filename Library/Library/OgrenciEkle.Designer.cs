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
            this.txt_blm = new System.Windows.Forms.TextBox();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_no
            // 
            this.txt_no.Location = new System.Drawing.Point(121, 143);
            this.txt_no.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_no.Name = "txt_no";
            this.txt_no.Size = new System.Drawing.Size(196, 27);
            this.txt_no.TabIndex = 0;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(121, 247);
            this.txt_soyad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(196, 27);
            this.txt_soyad.TabIndex = 1;
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(121, 193);
            this.txt_ad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(196, 27);
            this.txt_ad.TabIndex = 2;
            this.txt_ad.TextChanged += new System.EventHandler(this.txt_ad_TextChanged);
            // 
            // txt_blm
            // 
            this.txt_blm.Location = new System.Drawing.Point(121, 303);
            this.txt_blm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_blm.Name = "txt_blm";
            this.txt_blm.Size = new System.Drawing.Size(196, 27);
            this.txt_blm.TabIndex = 3;
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(121, 361);
            this.txt_mail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(196, 27);
            this.txt_mail.TabIndex = 4;
            // 
            // txt_tlf
            // 
            this.txt_tlf.Location = new System.Drawing.Point(121, 415);
            this.txt_tlf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_tlf.Name = "txt_tlf";
            this.txt_tlf.Size = new System.Drawing.Size(196, 27);
            this.txt_tlf.TabIndex = 5;
            // 
            // Ad
            // 
            this.Ad.AutoSize = true;
            this.Ad.Location = new System.Drawing.Point(5, 197);
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(28, 20);
            this.Ad.TabIndex = 6;
            this.Ad.Text = "Ad";
            // 
            // Soyad
            // 
            this.Soyad.AutoSize = true;
            this.Soyad.Location = new System.Drawing.Point(5, 251);
            this.Soyad.Name = "Soyad";
            this.Soyad.Size = new System.Drawing.Size(50, 20);
            this.Soyad.TabIndex = 7;
            this.Soyad.Text = "Soyad";
            // 
            // OgrenciNo
            // 
            this.OgrenciNo.AutoSize = true;
            this.OgrenciNo.Location = new System.Drawing.Point(5, 147);
            this.OgrenciNo.Name = "OgrenciNo";
            this.OgrenciNo.Size = new System.Drawing.Size(85, 20);
            this.OgrenciNo.TabIndex = 8;
            this.OgrenciNo.Text = "Öğrenci No";
            // 
            // BolumAdi
            // 
            this.BolumAdi.AutoSize = true;
            this.BolumAdi.Location = new System.Drawing.Point(5, 307);
            this.BolumAdi.Name = "BolumAdi";
            this.BolumAdi.Size = new System.Drawing.Size(79, 20);
            this.BolumAdi.TabIndex = 9;
            this.BolumAdi.Text = "Bölüm Adı";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(8, 365);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(46, 20);
            this.Email.TabIndex = 10;
            this.Email.Text = "Email";
            // 
            // Telefon
            // 
            this.Telefon.AutoSize = true;
            this.Telefon.Location = new System.Drawing.Point(8, 419);
            this.Telefon.Name = "Telefon";
            this.Telefon.Size = new System.Drawing.Size(58, 20);
            this.Telefon.TabIndex = 11;
            this.Telefon.Text = "Telefon";
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(138)))), ((int)(((byte)(185)))));
            this.btnOgrenciEkle.Location = new System.Drawing.Point(373, 193);
            this.btnOgrenciEkle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(107, 85);
            this.btnOgrenciEkle.TabIndex = 12;
            this.btnOgrenciEkle.Text = "Ekle";
            this.btnOgrenciEkle.UseVisualStyleBackColor = false;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // btnİptal
            // 
            this.btnİptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(138)))), ((int)(((byte)(185)))));
            this.btnİptal.Location = new System.Drawing.Point(373, 308);
            this.btnİptal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(107, 84);
            this.btnİptal.TabIndex = 13;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = false;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(214, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // OgrenciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(198)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(525, 600);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnOgrenciEkle);
            this.Controls.Add(this.Telefon);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.BolumAdi);
            this.Controls.Add(this.OgrenciNo);
            this.Controls.Add(this.Soyad);
            this.Controls.Add(this.Ad);
            this.Controls.Add(this.txt_tlf);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.txt_blm);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_no);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OgrenciEkle";
            this.Text = "OgrenciEkle";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       
        #endregion

        private TextBox txt_no;
        private TextBox txt_soyad;
        private TextBox txt_ad;
        private TextBox txt_blm;
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
        private PictureBox pictureBox1;
    }
}