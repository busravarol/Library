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
            this.txt_blm = new System.Windows.Forms.TextBox();
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
            this.uyeözellikarama = new System.Windows.Forms.ComboBox();
            this.aramakutucuk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(99, 226);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(162, 23);
            this.txt_mail.TabIndex = 0;
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(99, 95);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(162, 23);
            this.txt_ad.TabIndex = 2;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(99, 128);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(162, 23);
            this.txt_soyad.TabIndex = 3;
            // 
            // txt_no3
            // 
            this.txt_no3.Location = new System.Drawing.Point(99, 160);
            this.txt_no3.Name = "txt_no3";
            this.txt_no3.Size = new System.Drawing.Size(162, 23);
            this.txt_no3.TabIndex = 4;
            // 
            // txt_blm
            // 
            this.txt_blm.Location = new System.Drawing.Point(99, 194);
            this.txt_blm.Name = "txt_blm";
            this.txt_blm.Size = new System.Drawing.Size(162, 23);
            this.txt_blm.TabIndex = 5;
            // 
            // txt_tlf
            // 
            this.txt_tlf.Location = new System.Drawing.Point(99, 260);
            this.txt_tlf.Name = "txt_tlf";
            this.txt_tlf.Size = new System.Drawing.Size(162, 23);
            this.txt_tlf.TabIndex = 6;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(99)))));
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuncelle.Location = new System.Drawing.Point(99, 313);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(162, 44);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btniptal
            // 
            this.btniptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(99)))));
            this.btniptal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btniptal.Location = new System.Drawing.Point(398, 359);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(131, 44);
            this.btniptal.TabIndex = 8;
            this.btniptal.Text = "İptal";
            this.btniptal.UseVisualStyleBackColor = false;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(99)))));
            this.btnsil.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsil.Location = new System.Drawing.Point(588, 359);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(131, 44);
            this.btnsil.TabIndex = 9;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(99)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(308, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(486, 260);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ograd
            // 
            this.ograd.AutoSize = true;
            this.ograd.Location = new System.Drawing.Point(10, 98);
            this.ograd.Name = "ograd";
            this.ograd.Size = new System.Drawing.Size(22, 15);
            this.ograd.TabIndex = 11;
            this.ograd.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 13;
            // 
            // ogrbolumad
            // 
            this.ogrbolumad.AutoSize = true;
            this.ogrbolumad.Location = new System.Drawing.Point(10, 199);
            this.ogrbolumad.Name = "ogrbolumad";
            this.ogrbolumad.Size = new System.Drawing.Size(63, 15);
            this.ogrbolumad.TabIndex = 14;
            this.ogrbolumad.Text = "Bölüm Adı";
            // 
            // ogreposta
            // 
            this.ogreposta.AutoSize = true;
            this.ogreposta.Location = new System.Drawing.Point(12, 229);
            this.ogreposta.Name = "ogreposta";
            this.ogreposta.Size = new System.Drawing.Size(47, 15);
            this.ogreposta.TabIndex = 15;
            this.ogreposta.Text = "E-posta";
            this.ogreposta.Click += new System.EventHandler(this.ogreposta_Click);
            // 
            // ogrtelefon
            // 
            this.ogrtelefon.AutoSize = true;
            this.ogrtelefon.Location = new System.Drawing.Point(14, 265);
            this.ogrtelefon.Name = "ogrtelefon";
            this.ogrtelefon.Size = new System.Drawing.Size(45, 15);
            this.ogrtelefon.TabIndex = 16;
            this.ogrtelefon.Text = "Telefon";
            // 
            // ogrno
            // 
            this.ogrno.AutoSize = true;
            this.ogrno.Location = new System.Drawing.Point(10, 163);
            this.ogrno.Name = "ogrno";
            this.ogrno.Size = new System.Drawing.Size(68, 15);
            this.ogrno.TabIndex = 18;
            this.ogrno.Text = "Öğrenci No";
            // 
            // uyeözellikarama
            // 
            this.uyeözellikarama.FormattingEnabled = true;
            this.uyeözellikarama.Items.AddRange(new object[] {
            "Öğrenci ID",
            "Öğrenci ad",
            "Öğrenci soyad",
            "Öğrenci bölüm",
            ""});
            this.uyeözellikarama.Location = new System.Drawing.Point(398, 24);
            this.uyeözellikarama.Name = "uyeözellikarama";
            this.uyeözellikarama.Size = new System.Drawing.Size(205, 23);
            this.uyeözellikarama.TabIndex = 19;
            // 
            // aramakutucuk
            // 
            this.aramakutucuk.Location = new System.Drawing.Point(628, 24);
            this.aramakutucuk.Name = "aramakutucuk";
            this.aramakutucuk.Size = new System.Drawing.Size(166, 23);
            this.aramakutucuk.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Arama";
            // 
            // UyeListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(816, 425);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aramakutucuk);
            this.Controls.Add(this.uyeözellikarama);
            this.Controls.Add(this.ogrno);
            this.Controls.Add(this.ogrtelefon);
            this.Controls.Add(this.ogreposta);
            this.Controls.Add(this.ogrbolumad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ograd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txt_tlf);
            this.Controls.Add(this.txt_blm);
            this.Controls.Add(this.txt_no3);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.txt_mail);
            this.Name = "UyeListesi";
            this.Text = "UyeListesi";
            this.Load += new System.EventHandler(this.UyeListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_mail;
        private TextBox txt_ad;
        private TextBox txt_soyad;
        private TextBox txt_no3;
        private TextBox txt_blm;
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
        private ComboBox uyeözellikarama;
        private TextBox aramakutucuk;
        private Label label1;
    }
}