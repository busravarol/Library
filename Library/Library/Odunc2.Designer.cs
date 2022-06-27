namespace Library
{
    partial class Odunc2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Kitap = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_No = new System.Windows.Forms.TextBox();
            this.btn_Teslim = new System.Windows.Forms.Button();
            this.btnarama = new System.Windows.Forms.Button();
            this.txt_blm = new System.Windows.Forms.TextBox();
            this.txt_posta = new System.Windows.Forms.TextBox();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.txt_tlf = new System.Windows.Forms.TextBox();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_no2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_Kitap1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.txt_Kitap);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_No);
            this.panel1.Controls.Add(this.btn_Teslim);
            this.panel1.Controls.Add(this.btnarama);
            this.panel1.Controls.Add(this.txt_blm);
            this.panel1.Controls.Add(this.txt_posta);
            this.panel1.Controls.Add(this.txt_Soyad);
            this.panel1.Controls.Add(this.txt_tlf);
            this.panel1.Controls.Add(this.txt_Ad);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(139, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 408);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txt_Kitap
            // 
            this.txt_Kitap.Location = new System.Drawing.Point(271, 248);
            this.txt_Kitap.Name = "txt_Kitap";
            this.txt_Kitap.Size = new System.Drawing.Size(146, 27);
            this.txt_Kitap.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(273, 293);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(143, 27);
            this.dateTimePicker1.TabIndex = 19;
            this.dateTimePicker1.Value = new System.DateTime(2022, 5, 26, 3, 1, 47, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(170, 301);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Verliş Tarihi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(170, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Kitap Adı";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ögrenci No";
            // 
            // txt_No
            // 
            this.txt_No.Location = new System.Drawing.Point(3, 67);
            this.txt_No.Name = "txt_No";
            this.txt_No.Size = new System.Drawing.Size(142, 27);
            this.txt_No.TabIndex = 14;
            // 
            // btn_Teslim
            // 
            this.btn_Teslim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.btn_Teslim.Location = new System.Drawing.Point(271, 340);
            this.btn_Teslim.Name = "btn_Teslim";
            this.btn_Teslim.Size = new System.Drawing.Size(146, 50);
            this.btn_Teslim.TabIndex = 13;
            this.btn_Teslim.Text = "Teslim Ver";
            this.btn_Teslim.UseVisualStyleBackColor = false;
            this.btn_Teslim.Click += new System.EventHandler(this.btn_Teslim_Click);
            // 
            // btnarama
            // 
            this.btnarama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.btnarama.Location = new System.Drawing.Point(0, 111);
            this.btnarama.Name = "btnarama";
            this.btnarama.Size = new System.Drawing.Size(145, 46);
            this.btnarama.TabIndex = 12;
            this.btnarama.Text = "Arama";
            this.btnarama.UseVisualStyleBackColor = false;
            this.btnarama.Click += new System.EventHandler(this.btnarama_Click);
            // 
            // txt_blm
            // 
            this.txt_blm.Location = new System.Drawing.Point(273, 200);
            this.txt_blm.Name = "txt_blm";
            this.txt_blm.ReadOnly = true;
            this.txt_blm.Size = new System.Drawing.Size(143, 27);
            this.txt_blm.TabIndex = 11;
            // 
            // txt_posta
            // 
            this.txt_posta.Location = new System.Drawing.Point(273, 148);
            this.txt_posta.Name = "txt_posta";
            this.txt_posta.ReadOnly = true;
            this.txt_posta.Size = new System.Drawing.Size(143, 27);
            this.txt_posta.TabIndex = 10;
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Location = new System.Drawing.Point(273, 64);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.ReadOnly = true;
            this.txt_Soyad.Size = new System.Drawing.Size(143, 27);
            this.txt_Soyad.TabIndex = 9;
            // 
            // txt_tlf
            // 
            this.txt_tlf.Location = new System.Drawing.Point(273, 108);
            this.txt_tlf.Name = "txt_tlf";
            this.txt_tlf.ReadOnly = true;
            this.txt_tlf.Size = new System.Drawing.Size(143, 27);
            this.txt_tlf.TabIndex = 8;
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(273, 20);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.ReadOnly = true;
            this.txt_Ad.Size = new System.Drawing.Size(143, 27);
            this.txt_Ad.TabIndex = 7;
            this.txt_Ad.TextChanged += new System.EventHandler(this.txt_Ad_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Bölüm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "E-posta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Öğrenci Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Öğrenci Ad";
            // 
            // txt_no2
            // 
            this.txt_no2.Location = new System.Drawing.Point(144, 27);
            this.txt_no2.Name = "txt_no2";
            this.txt_no2.Size = new System.Drawing.Size(147, 27);
            this.txt_no2.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Ögrenci No";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(160)))));
            this.panel2.Controls.Add(this.txt_Kitap1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txt_no2);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(625, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 408);
            this.panel2.TabIndex = 1;
            // 
            // txt_Kitap1
            // 
            this.txt_Kitap1.Location = new System.Drawing.Point(144, 69);
            this.txt_Kitap1.Name = "txt_Kitap1";
            this.txt_Kitap1.Size = new System.Drawing.Size(146, 27);
            this.txt_Kitap1.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.button1.Location = new System.Drawing.Point(144, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 48);
            this.button1.TabIndex = 24;
            this.button1.Text = "Teslim Al";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(144, 108);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(146, 27);
            this.dateTimePicker2.TabIndex = 24;
            this.dateTimePicker2.Value = new System.DateTime(2022, 5, 26, 3, 1, 47, 0);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Teslim Alış Tarihi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Kitap Adı";
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // Odunc2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(1047, 623);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Odunc2";
            this.Text = "Odunc2";
            this.Load += new System.EventHandler(this.Odunc2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox txt_blm;
        private TextBox txt_posta;
        private TextBox txt_Soyad;
        private TextBox txt_tlf;
        private TextBox txt_Ad;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txt_No;
        private Button btn_Teslim;
        private Button btnarama;
        protected internal DateTimePicker dateTimePicker1;
        private TextBox txt_no2;
        private Label label10;
        private Panel panel2;
        private Button button1;
        protected internal DateTimePicker dateTimePicker2;
        private Label label11;
        private Label label1;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private TextBox txt_Kitap;
        private TextBox txt_Kitap1;
    }
}