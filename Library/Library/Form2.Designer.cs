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
            this.öğrencidetay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(99)))));
            this.öğrencidetay.Location = new System.Drawing.Point(6, 456);
            this.öğrencidetay.Name = "öğrencidetay";
            this.öğrencidetay.Size = new System.Drawing.Size(199, 69);
            this.öğrencidetay.TabIndex = 3;
            this.öğrencidetay.Text = "         Öğrenci Detayı Görüntüle";
            this.öğrencidetay.UseVisualStyleBackColor = false;
            this.öğrencidetay.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // öğrenciekle
            // 
            this.öğrenciekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(99)))));
            this.öğrenciekle.Location = new System.Drawing.Point(6, 373);
            this.öğrenciekle.Name = "öğrenciekle";
            this.öğrenciekle.Size = new System.Drawing.Size(199, 66);
            this.öğrenciekle.TabIndex = 4;
            this.öğrenciekle.Text = "Öğrenci Ekle";
            this.öğrenciekle.UseVisualStyleBackColor = false;
            this.öğrenciekle.Click += new System.EventHandler(this.button3_Click);
            // 
            // istatistikler
            // 
            this.istatistikler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(99)))));
            this.istatistikler.Location = new System.Drawing.Point(3, 298);
            this.istatistikler.Name = "istatistikler";
            this.istatistikler.Size = new System.Drawing.Size(202, 69);
            this.istatistikler.TabIndex = 8;
            this.istatistikler.Text = "İstatistik Veriler";
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
            this.kitapdetay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(99)))));
            this.kitapdetay.Location = new System.Drawing.Point(3, 224);
            this.kitapdetay.Name = "kitapdetay";
            this.kitapdetay.Size = new System.Drawing.Size(202, 68);
            this.kitapdetay.TabIndex = 7;
            this.kitapdetay.Text = "Kitap Detayları";
            this.kitapdetay.UseVisualStyleBackColor = false;
            this.kitapdetay.Click += new System.EventHandler(this.button6_Click);
            // 
            // iadekitaplar
            // 
            this.iadekitaplar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(99)))));
            this.iadekitaplar.Location = new System.Drawing.Point(3, 149);
            this.iadekitaplar.Name = "iadekitaplar";
            this.iadekitaplar.Size = new System.Drawing.Size(199, 69);
            this.iadekitaplar.TabIndex = 6;
            this.iadekitaplar.Text = "İade Kitaplar";
            this.iadekitaplar.UseVisualStyleBackColor = false;
            this.iadekitaplar.Click += new System.EventHandler(this.button5_Click);
            // 
            // kitaplistesi
            // 
            this.kitaplistesi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(99)))));
            this.kitaplistesi.Location = new System.Drawing.Point(3, 81);
            this.kitaplistesi.Name = "kitaplistesi";
            this.kitaplistesi.Size = new System.Drawing.Size(202, 62);
            this.kitaplistesi.TabIndex = 5;
            this.kitaplistesi.Text = "Kitap Listesi";
            this.kitaplistesi.UseVisualStyleBackColor = false;
            this.kitaplistesi.Click += new System.EventHandler(this.button4_Click);
            // 
            // kitapekle
            // 
            this.kitapekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(99)))));
            this.kitapekle.Location = new System.Drawing.Point(3, 12);
            this.kitapekle.Name = "kitapekle";
            this.kitapekle.Size = new System.Drawing.Size(199, 63);
            this.kitapekle.TabIndex = 2;
            this.kitapekle.Text = "Kitap Ekle";
            this.kitapekle.UseVisualStyleBackColor = false;
            this.kitapekle.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1415, 602);
            this.Controls.Add(this.öğrencidetay);
            this.Controls.Add(this.kitapdetay);
            this.Controls.Add(this.öğrenciekle);
            this.Controls.Add(this.iadekitaplar);
            this.Controls.Add(this.istatistikler);
            this.Controls.Add(this.kitaplistesi);
            this.Controls.Add(this.kitapekle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "anasayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
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
    }
}