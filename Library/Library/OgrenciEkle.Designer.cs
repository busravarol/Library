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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_no
            // 
            this.txt_no.Location = new System.Drawing.Point(130, 26);
            this.txt_no.Name = "txt_no";
            this.txt_no.Size = new System.Drawing.Size(151, 23);
            this.txt_no.TabIndex = 0;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(130, 99);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(151, 23);
            this.txt_soyad.TabIndex = 1;
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(130, 64);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(151, 23);
            this.txt_ad.TabIndex = 2;
            this.txt_ad.TextChanged += new System.EventHandler(this.txt_ad_TextChanged);
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(130, 165);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(151, 23);
            this.txt_mail.TabIndex = 4;
            // 
            // txt_tlf
            // 
            this.txt_tlf.Location = new System.Drawing.Point(130, 199);
            this.txt_tlf.Name = "txt_tlf";
            this.txt_tlf.Size = new System.Drawing.Size(151, 23);
            this.txt_tlf.TabIndex = 5;
            // 
            // Ad
            // 
            this.Ad.AutoSize = true;
            this.Ad.Location = new System.Drawing.Point(28, 69);
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(22, 15);
            this.Ad.TabIndex = 6;
            this.Ad.Text = "Ad";
            // 
            // Soyad
            // 
            this.Soyad.AutoSize = true;
            this.Soyad.Location = new System.Drawing.Point(28, 104);
            this.Soyad.Name = "Soyad";
            this.Soyad.Size = new System.Drawing.Size(39, 15);
            this.Soyad.TabIndex = 7;
            this.Soyad.Text = "Soyad";
            // 
            // OgrenciNo
            // 
            this.OgrenciNo.AutoSize = true;
            this.OgrenciNo.Location = new System.Drawing.Point(28, 29);
            this.OgrenciNo.Name = "OgrenciNo";
            this.OgrenciNo.Size = new System.Drawing.Size(68, 15);
            this.OgrenciNo.TabIndex = 8;
            this.OgrenciNo.Text = "Öğrenci No";
            // 
            // BolumAdi
            // 
            this.BolumAdi.AutoSize = true;
            this.BolumAdi.Location = new System.Drawing.Point(28, 137);
            this.BolumAdi.Name = "BolumAdi";
            this.BolumAdi.Size = new System.Drawing.Size(63, 15);
            this.BolumAdi.TabIndex = 9;
            this.BolumAdi.Text = "Bölüm Adı";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(28, 167);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(36, 15);
            this.Email.TabIndex = 10;
            this.Email.Text = "Email";
            // 
            // Telefon
            // 
            this.Telefon.AutoSize = true;
            this.Telefon.Location = new System.Drawing.Point(28, 202);
            this.Telefon.Name = "Telefon";
            this.Telefon.Size = new System.Drawing.Size(45, 15);
            this.Telefon.TabIndex = 11;
            this.Telefon.Text = "Telefon";
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(99)))));
            this.btnOgrenciEkle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOgrenciEkle.Location = new System.Drawing.Point(54, 356);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(149, 49);
            this.btnOgrenciEkle.TabIndex = 12;
            this.btnOgrenciEkle.Text = "Ekle";
            this.btnOgrenciEkle.UseVisualStyleBackColor = false;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // btnİptal
            // 
            this.btnİptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(99)))));
            this.btnİptal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnİptal.Location = new System.Drawing.Point(229, 420);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(151, 46);
            this.btnİptal.TabIndex = 13;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = false;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // bolum_Box
            // 
            this.bolum_Box.FormattingEnabled = true;
            this.bolum_Box.Location = new System.Drawing.Point(130, 131);
            this.bolum_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bolum_Box.Name = "bolum_Box";
            this.bolum_Box.Size = new System.Drawing.Size(151, 23);
            this.bolum_Box.TabIndex = 15;
            this.bolum_Box.SelectedIndexChanged += new System.EventHandler(this.bolum_Box_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(99)))));
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
            this.panel1.Location = new System.Drawing.Point(54, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 265);
            this.panel1.TabIndex = 16;
            // 
            // OgrenciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(444, 547);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnOgrenciEkle);
            this.Name = "OgrenciEkle";
            this.Text = "OgrenciEkle";
            this.Load += new System.EventHandler(this.OgrenciEkle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}