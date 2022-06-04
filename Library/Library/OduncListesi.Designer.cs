namespace Library
{
    partial class OduncListesi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.lbl_Kitap = new System.Windows.Forms.Label();
            this.lbl_Ogrenci = new System.Windows.Forms.Label();
            this.txt_Ogr1 = new System.Windows.Forms.TextBox();
            this.lbl_Yazar = new System.Windows.Forms.Label();
            this.txt_Ogrno = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(309, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(835, 324);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.AllowUserToAddRowsChanged += new System.EventHandler(this.OduncListesi_Load);
            this.dataGridView1.AllowUserToDeleteRowsChanged += new System.EventHandler(this.OduncListesi_Load);
            this.dataGridView1.AllowUserToOrderColumnsChanged += new System.EventHandler(this.OduncListesi_Load);
            this.dataGridView1.AutoSizeRowsModeChanged += new System.Windows.Forms.DataGridViewAutoSizeModeEventHandler(this.dataGridView1_AutoSizeRowsModeChanged);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(600, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Teslim Verilen Kitaplar";
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // lbl_Kitap
            // 
            this.lbl_Kitap.AutoSize = true;
            this.lbl_Kitap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Kitap.Location = new System.Drawing.Point(29, 73);
            this.lbl_Kitap.Name = "lbl_Kitap";
            this.lbl_Kitap.Size = new System.Drawing.Size(97, 28);
            this.lbl_Kitap.TabIndex = 3;
            this.lbl_Kitap.Text = "Kitap Adı:";
            this.lbl_Kitap.Click += new System.EventHandler(this.lbl_Kitap_Click);
            // 
            // lbl_Ogrenci
            // 
            this.lbl_Ogrenci.AutoSize = true;
            this.lbl_Ogrenci.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Ogrenci.Location = new System.Drawing.Point(29, 172);
            this.lbl_Ogrenci.Name = "lbl_Ogrenci";
            this.lbl_Ogrenci.Size = new System.Drawing.Size(120, 28);
            this.lbl_Ogrenci.TabIndex = 4;
            this.lbl_Ogrenci.Text = "Öğrenci Adı:";
            // 
            // txt_Ogr1
            // 
            this.txt_Ogr1.Location = new System.Drawing.Point(155, 176);
            this.txt_Ogr1.Name = "txt_Ogr1";
            this.txt_Ogr1.Size = new System.Drawing.Size(121, 27);
            this.txt_Ogr1.TabIndex = 6;
            this.txt_Ogr1.TextChanged += new System.EventHandler(this.txt_Ogr1_TextChanged);
            // 
            // lbl_Yazar
            // 
            this.lbl_Yazar.AutoSize = true;
            this.lbl_Yazar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Yazar.Location = new System.Drawing.Point(30, 127);
            this.lbl_Yazar.Name = "lbl_Yazar";
            this.lbl_Yazar.Size = new System.Drawing.Size(117, 28);
            this.lbl_Yazar.TabIndex = 7;
            this.lbl_Yazar.Text = "Öğrenci No:";
            // 
            // txt_Ogrno
            // 
            this.txt_Ogrno.Location = new System.Drawing.Point(155, 127);
            this.txt_Ogrno.Name = "txt_Ogrno";
            this.txt_Ogrno.Size = new System.Drawing.Size(121, 27);
            this.txt_Ogrno.TabIndex = 8;
            this.txt_Ogrno.TextChanged += new System.EventHandler(this.txt_Yazar1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(152, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(124, 28);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // OduncListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(138)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(1221, 453);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txt_Ogrno);
            this.Controls.Add(this.lbl_Yazar);
            this.Controls.Add(this.txt_Ogr1);
            this.Controls.Add(this.lbl_Ogrenci);
            this.Controls.Add(this.lbl_Kitap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OduncListesi";
            this.Text = "OduncListesi";
            this.Load += new System.EventHandler(this.OduncListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private Label lbl_Kitap;
        private Label lbl_Ogrenci;
        private TextBox txt_Ogr1;
        private Label lbl_Yazar;
        private TextBox txt_Ogrno;
        private ComboBox comboBox1;
    }
}