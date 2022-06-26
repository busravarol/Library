namespace Library
{
    partial class UyeListesi
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
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_no3 = new System.Windows.Forms.TextBox();
            this.txt_tlf = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btniptal = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ograd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ogrbolumad = new System.Windows.Forms.Label();
            this.ogreposta = new System.Windows.Forms.Label();
            this.ogrtelefon = new System.Windows.Forms.Label();
            this.ogrno = new System.Windows.Forms.Label();
            this.uyeozellikarama = new System.Windows.Forms.ComboBox();
            this.aramakutucuk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(132, 258);
            this.txt_mail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(185, 27);
            this.txt_mail.TabIndex = 0;
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(132, 125);
            this.txt_ad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(185, 27);
            this.txt_ad.TabIndex = 2;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(132, 169);
            this.txt_soyad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(185, 27);
            this.txt_soyad.TabIndex = 3;
            // 
            // txt_no3
            // 
            this.txt_no3.Location = new System.Drawing.Point(132, 83);
            this.txt_no3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_no3.Name = "txt_no3";
            this.txt_no3.Size = new System.Drawing.Size(185, 27);
            this.txt_no3.TabIndex = 4;
            // 
            // txt_tlf
            // 
            this.txt_tlf.Location = new System.Drawing.Point(132, 304);
            this.txt_tlf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_tlf.Name = "txt_tlf";
            this.txt_tlf.Size = new System.Drawing.Size(185, 27);
            this.txt_tlf.TabIndex = 6;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuncelle.Location = new System.Drawing.Point(165, 360);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(131, 56);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btniptal
            // 
            this.btniptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(160)))));
            this.btniptal.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btniptal.Location = new System.Drawing.Point(648, 486);
            this.btniptal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(150, 59);
            this.btniptal.TabIndex = 8;
            this.btniptal.Text = "İptal";
            this.btniptal.UseVisualStyleBackColor = false;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(160)))));
            this.btnsil.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsil.Location = new System.Drawing.Point(865, 486);
            this.btnsil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(150, 59);
            this.btnsil.TabIndex = 9;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(160)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(562, 113);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(555, 347);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ograd
            // 
            this.ograd.AutoSize = true;
            this.ograd.Location = new System.Drawing.Point(35, 128);
            this.ograd.Name = "ograd";
            this.ograd.Size = new System.Drawing.Size(28, 20);
            this.ograd.TabIndex = 11;
            this.ograd.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 13;
            // 
            // ogrbolumad
            // 
            this.ogrbolumad.AutoSize = true;
            this.ogrbolumad.Location = new System.Drawing.Point(30, 222);
            this.ogrbolumad.Name = "ogrbolumad";
            this.ogrbolumad.Size = new System.Drawing.Size(79, 20);
            this.ogrbolumad.TabIndex = 14;
            this.ogrbolumad.Text = "Bölüm Adı";
            // 
            // ogreposta
            // 
            this.ogreposta.AutoSize = true;
            this.ogreposta.Location = new System.Drawing.Point(33, 262);
            this.ogreposta.Name = "ogreposta";
            this.ogreposta.Size = new System.Drawing.Size(60, 20);
            this.ogreposta.TabIndex = 15;
            this.ogreposta.Text = "E-posta";
            this.ogreposta.Click += new System.EventHandler(this.ogreposta_Click);
            // 
            // ogrtelefon
            // 
            this.ogrtelefon.AutoSize = true;
            this.ogrtelefon.Location = new System.Drawing.Point(30, 307);
            this.ogrtelefon.Name = "ogrtelefon";
            this.ogrtelefon.Size = new System.Drawing.Size(58, 20);
            this.ogrtelefon.TabIndex = 16;
            this.ogrtelefon.Text = "Telefon";
            // 
            // ogrno
            // 
            this.ogrno.AutoSize = true;
            this.ogrno.Location = new System.Drawing.Point(33, 90);
            this.ogrno.Name = "ogrno";
            this.ogrno.Size = new System.Drawing.Size(85, 20);
            this.ogrno.TabIndex = 18;
            this.ogrno.Text = "Öğrenci No";
            // 
            // uyeozellikarama
            // 
            this.uyeozellikarama.FormattingEnabled = true;
            this.uyeozellikarama.Items.AddRange(new object[] {
            "Öğrenci No",
            "Öğrenci Ad",
            "Öğrenci Soyad",
            "Öğrenci Bölüm"});
            this.uyeozellikarama.Location = new System.Drawing.Point(648, 42);
            this.uyeozellikarama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uyeozellikarama.Name = "uyeozellikarama";
            this.uyeozellikarama.Size = new System.Drawing.Size(234, 28);
            this.uyeozellikarama.TabIndex = 19;
            // 
            // aramakutucuk
            // 
            this.aramakutucuk.Location = new System.Drawing.Point(911, 39);
            this.aramakutucuk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aramakutucuk.Name = "aramakutucuk";
            this.aramakutucuk.Size = new System.Drawing.Size(189, 27);
            this.aramakutucuk.TabIndex = 20;
            this.aramakutucuk.TextChanged += new System.EventHandler(this.aramakutucuk_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(545, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Arama";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(132, 214);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 28);
            this.comboBox1.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.txt_mail);
            this.panel1.Controls.Add(this.txt_ad);
            this.panel1.Controls.Add(this.txt_soyad);
            this.panel1.Controls.Add(this.txt_no3);
            this.panel1.Controls.Add(this.ogrno);
            this.panel1.Controls.Add(this.txt_tlf);
            this.panel1.Controls.Add(this.ogrtelefon);
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Controls.Add(this.ogreposta);
            this.panel1.Controls.Add(this.ograd);
            this.panel1.Controls.Add(this.ogrbolumad);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(179, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 472);
            this.panel1.TabIndex = 23;
            // 
            // UyeListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(1375, 631);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aramakutucuk);
            this.Controls.Add(this.uyeozellikarama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btniptal);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UyeListesi";
            this.Text = "UyeListesi";
            this.Load += new System.EventHandler(this.UyeListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_mail;
        private TextBox txt_ad;
        private TextBox txt_soyad;
        private TextBox txt_no3;
        private TextBox txt_tlf;
        private Button btnGuncelle;
        private Button btniptal;
        private Button btnsil;
        private DataGridView dataGridView1;
        private Label ograd;
        private Label label2;
        private Label label3;
        private Label ogrbolumad;
        private Label ogreposta;
        private Label ogrtelefon;
        private Label ogrno;
        private ComboBox uyeozellikarama;
        private TextBox aramakutucuk;
        private Label label1;
        private ComboBox comboBox1;
        private Panel panel1;
    }
}