namespace Library
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.öğrencidetay = new System.Windows.Forms.Button();
            this.öğrenciekle = new System.Windows.Forms.Button();
            this.istatistikler = new System.Windows.Forms.Button();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.mySqlCommand2 = new MySql.Data.MySqlClient.MySqlCommand();
            this.mySqlCommand3 = new MySql.Data.MySqlClient.MySqlCommand();
            this.kitapdetay = new System.Windows.Forms.Button();
            this.iadekitaplar = new System.Windows.Forms.Button();
            this.kitaplistesi = new System.Windows.Forms.Button();
            this.kitapekle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ogrİsleri = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // öğrencidetay
            // 
            this.öğrencidetay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(160)))));
            this.öğrencidetay.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.öğrencidetay.Image = ((System.Drawing.Image)(resources.GetObject("öğrencidetay.Image")));
            this.öğrencidetay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.öğrencidetay.Location = new System.Drawing.Point(39, 262);
            this.öğrencidetay.Name = "öğrencidetay";
            this.öğrencidetay.Size = new System.Drawing.Size(207, 84);
            this.öğrencidetay.TabIndex = 3;
            this.öğrencidetay.Text = "    Öğrenci Listesi";
            this.öğrencidetay.UseVisualStyleBackColor = false;
            this.öğrencidetay.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // öğrenciekle
            // 
            this.öğrenciekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(160)))));
            this.öğrenciekle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.öğrenciekle.Image = ((System.Drawing.Image)(resources.GetObject("öğrenciekle.Image")));
            this.öğrenciekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.öğrenciekle.Location = new System.Drawing.Point(39, 190);
            this.öğrenciekle.Name = "öğrenciekle";
            this.öğrenciekle.Size = new System.Drawing.Size(207, 81);
            this.öğrenciekle.TabIndex = 4;
            this.öğrenciekle.Text = "   Öğrenci Ekle";
            this.öğrenciekle.UseVisualStyleBackColor = false;
            this.öğrenciekle.Click += new System.EventHandler(this.button3_Click);
            // 
            // istatistikler
            // 
            this.istatistikler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(160)))));
            this.istatistikler.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.istatistikler.Image = ((System.Drawing.Image)(resources.GetObject("istatistikler.Image")));
            this.istatistikler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.istatistikler.Location = new System.Drawing.Point(39, 486);
            this.istatistikler.Name = "istatistikler";
            this.istatistikler.Size = new System.Drawing.Size(207, 84);
            this.istatistikler.TabIndex = 8;
            this.istatistikler.Text = "     İstatistik Veriler";
            this.istatistikler.UseVisualStyleBackColor = false;
            this.istatistikler.Click += new System.EventHandler(this.button7_Click);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // mySqlCommand2
            // 
            this.mySqlCommand2.CacheAge = 0;
            this.mySqlCommand2.Connection = null;
            this.mySqlCommand2.EnableCaching = false;
            this.mySqlCommand2.Transaction = null;
            // 
            // mySqlCommand3
            // 
            this.mySqlCommand3.CacheAge = 0;
            this.mySqlCommand3.Connection = null;
            this.mySqlCommand3.EnableCaching = false;
            this.mySqlCommand3.Transaction = null;
            // 
            // kitapdetay
            // 
            this.kitapdetay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(160)))));
            this.kitapdetay.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kitapdetay.Location = new System.Drawing.Point(39, 412);
            this.kitapdetay.Name = "kitapdetay";
            this.kitapdetay.Size = new System.Drawing.Size(207, 83);
            this.kitapdetay.TabIndex = 7;
            this.kitapdetay.Text = "       Ödünç Kitaplar";
            this.kitapdetay.UseVisualStyleBackColor = false;
            this.kitapdetay.Click += new System.EventHandler(this.button6_Click);
            // 
            // iadekitaplar
            // 
            this.iadekitaplar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(160)))));
            this.iadekitaplar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iadekitaplar.Location = new System.Drawing.Point(39, 337);
            this.iadekitaplar.Name = "iadekitaplar";
            this.iadekitaplar.Size = new System.Drawing.Size(207, 84);
            this.iadekitaplar.TabIndex = 6;
            this.iadekitaplar.Text = "   Teslim Ver-Al";
            this.iadekitaplar.UseVisualStyleBackColor = false;
            this.iadekitaplar.Click += new System.EventHandler(this.button5_Click);
            // 
            // kitaplistesi
            // 
            this.kitaplistesi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(160)))));
            this.kitaplistesi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kitaplistesi.Image = ((System.Drawing.Image)(resources.GetObject("kitaplistesi.Image")));
            this.kitaplistesi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kitaplistesi.Location = new System.Drawing.Point(39, 119);
            this.kitaplistesi.Name = "kitaplistesi";
            this.kitaplistesi.Size = new System.Drawing.Size(207, 77);
            this.kitaplistesi.TabIndex = 5;
            this.kitaplistesi.Text = "Kitap Listesi";
            this.kitaplistesi.UseVisualStyleBackColor = false;
            this.kitaplistesi.Click += new System.EventHandler(this.button4_Click);
            // 
            // kitapekle
            // 
            this.kitapekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(160)))));
            this.kitapekle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kitapekle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kitapekle.Image = ((System.Drawing.Image)(resources.GetObject("kitapekle.Image")));
            this.kitapekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kitapekle.Location = new System.Drawing.Point(39, 50);
            this.kitapekle.Name = "kitapekle";
            this.kitapekle.Size = new System.Drawing.Size(207, 78);
            this.kitapekle.TabIndex = 2;
            this.kitapekle.Text = "Kitap Ekle";
            this.kitapekle.UseVisualStyleBackColor = false;
            this.kitapekle.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.ogrİsleri);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.kitaplistesi);
            this.panel1.Controls.Add(this.kitapekle);
            this.panel1.Controls.Add(this.istatistikler);
            this.panel1.Controls.Add(this.öğrencidetay);
            this.panel1.Controls.Add(this.kitapdetay);
            this.panel1.Controls.Add(this.öğrenciekle);
            this.panel1.Controls.Add(this.iadekitaplar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 664);
            this.panel1.TabIndex = 9;
            // 
            // ogrİsleri
            // 
            this.ogrİsleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(160)))));
            this.ogrİsleri.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ogrİsleri.Location = new System.Drawing.Point(39, 558);
            this.ogrİsleri.Name = "ogrİsleri";
            this.ogrİsleri.Size = new System.Drawing.Size(207, 65);
            this.ogrİsleri.TabIndex = 10;
            this.ogrİsleri.Text = "Öğrenci İşleri";
            this.ogrİsleri.UseVisualStyleBackColor = false;
            this.ogrİsleri.Click += new System.EventHandler(this.ogrİsleri_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(49, 415);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(49, 352);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1009, 664);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "anasayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private Button öğrencidetay;
        private Button öğrenciekle;
        private Button istatistikler;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand2;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand3;
        private Button kitapdetay;
        private Button iadekitaplar;
        private Button kitaplistesi;
        private Button kitapekle;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button ogrİsleri;
    }
}