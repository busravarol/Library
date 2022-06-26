namespace Library
{
    partial class istatistik
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toplam_Ogrenci = new System.Windows.Forms.Label();
            this.toplam_Kitap = new System.Windows.Forms.Label();
            this.lblCokOkunan = new System.Windows.Forms.Label();
            this.lblCokOkuyan = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toplam Öğrenci Sayısı:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Toplam Kitap Sayısı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "En Çok Okunan Kitap:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(377, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "En Çok Kitap Okuyan:";
            // 
            // toplam_Ogrenci
            // 
            this.toplam_Ogrenci.AutoSize = true;
            this.toplam_Ogrenci.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toplam_Ogrenci.Location = new System.Drawing.Point(227, 19);
            this.toplam_Ogrenci.Name = "toplam_Ogrenci";
            this.toplam_Ogrenci.Size = new System.Drawing.Size(40, 31);
            this.toplam_Ogrenci.TabIndex = 4;
            this.toplam_Ogrenci.Text = "00";
            // 
            // toplam_Kitap
            // 
            this.toplam_Kitap.AutoSize = true;
            this.toplam_Kitap.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toplam_Kitap.Location = new System.Drawing.Point(227, 68);
            this.toplam_Kitap.Name = "toplam_Kitap";
            this.toplam_Kitap.Size = new System.Drawing.Size(40, 31);
            this.toplam_Kitap.TabIndex = 5;
            this.toplam_Kitap.Text = "00";
            // 
            // lblCokOkunan
            // 
            this.lblCokOkunan.AutoSize = true;
            this.lblCokOkunan.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCokOkunan.Location = new System.Drawing.Point(90, 163);
            this.lblCokOkunan.Name = "lblCokOkunan";
            this.lblCokOkunan.Size = new System.Drawing.Size(40, 31);
            this.lblCokOkunan.TabIndex = 6;
            this.lblCokOkunan.Text = "00";
            this.lblCokOkunan.Click += new System.EventHandler(this.lblCokOkunan_Click);
            // 
            // lblCokOkuyan
            // 
            this.lblCokOkuyan.AutoSize = true;
            this.lblCokOkuyan.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCokOkuyan.Location = new System.Drawing.Point(467, 163);
            this.lblCokOkuyan.Name = "lblCokOkuyan";
            this.lblCokOkuyan.Size = new System.Drawing.Size(40, 31);
            this.lblCokOkuyan.TabIndex = 7;
            this.lblCokOkuyan.Text = "00";
            this.lblCokOkuyan.Click += new System.EventHandler(this.lblCokOkuyan_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.toplam_Ogrenci);
            this.panel1.Controls.Add(this.lblCokOkunan);
            this.panel1.Controls.Add(this.lblCokOkuyan);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.toplam_Kitap);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(109, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 395);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(343, 207);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(275, 113);
            this.dataGridView2.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 206);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(270, 114);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // istatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(1134, 586);
            this.Controls.Add(this.panel1);
            this.Name = "istatistik";
            this.Text = "istatistik";
            this.Load += new System.EventHandler(this.istatistik_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label toplam_Ogrenci;
        private Label toplam_Kitap;
        private Label lblCokOkunan;
        private Label lblCokOkuyan;
        private Panel panel1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
    }
}