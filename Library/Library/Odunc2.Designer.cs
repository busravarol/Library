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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Kitap = new System.Windows.Forms.TextBox();
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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_Kitap);
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
            this.panel1.Location = new System.Drawing.Point(37, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 347);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(335, 206);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(112, 23);
            this.dateTimePicker1.TabIndex = 19;
            this.dateTimePicker1.Value = new System.DateTime(2022, 5, 26, 3, 1, 47, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(257, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Verliş Tarihi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(258, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Kitap Adı";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txt_Kitap
            // 
            this.txt_Kitap.Location = new System.Drawing.Point(337, 174);
            this.txt_Kitap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Kitap.Name = "txt_Kitap";
            this.txt_Kitap.Size = new System.Drawing.Size(110, 23);
            this.txt_Kitap.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ogrenci No";
            // 
            // txt_No
            // 
            this.txt_No.Location = new System.Drawing.Point(43, 116);
            this.txt_No.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_No.Name = "txt_No";
            this.txt_No.Size = new System.Drawing.Size(110, 23);
            this.txt_No.TabIndex = 14;
            // 
            // btn_Teslim
            // 
            this.btn_Teslim.Location = new System.Drawing.Point(337, 245);
            this.btn_Teslim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Teslim.Name = "btn_Teslim";
            this.btn_Teslim.Size = new System.Drawing.Size(82, 22);
            this.btn_Teslim.TabIndex = 13;
            this.btn_Teslim.Text = "Teslim Ver";
            this.btn_Teslim.UseVisualStyleBackColor = true;
            this.btn_Teslim.Click += new System.EventHandler(this.btn_Teslim_Click);
            // 
            // btnarama
            // 
            this.btnarama.Location = new System.Drawing.Point(53, 143);
            this.btnarama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnarama.Name = "btnarama";
            this.btnarama.Size = new System.Drawing.Size(82, 22);
            this.btnarama.TabIndex = 12;
            this.btnarama.Text = "Arama";
            this.btnarama.UseVisualStyleBackColor = true;
            this.btnarama.Click += new System.EventHandler(this.btnarama_Click);
            // 
            // txt_blm
            // 
            this.txt_blm.Location = new System.Drawing.Point(337, 143);
            this.txt_blm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_blm.Name = "txt_blm";
            this.txt_blm.ReadOnly = true;
            this.txt_blm.Size = new System.Drawing.Size(110, 23);
            this.txt_blm.TabIndex = 11;
            // 
            // txt_posta
            // 
            this.txt_posta.Location = new System.Drawing.Point(337, 118);
            this.txt_posta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_posta.Name = "txt_posta";
            this.txt_posta.ReadOnly = true;
            this.txt_posta.Size = new System.Drawing.Size(110, 23);
            this.txt_posta.TabIndex = 10;
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Location = new System.Drawing.Point(337, 69);
            this.txt_Soyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.ReadOnly = true;
            this.txt_Soyad.Size = new System.Drawing.Size(110, 23);
            this.txt_Soyad.TabIndex = 9;
            // 
            // txt_tlf
            // 
            this.txt_tlf.Location = new System.Drawing.Point(337, 94);
            this.txt_tlf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tlf.Name = "txt_tlf";
            this.txt_tlf.ReadOnly = true;
            this.txt_tlf.Size = new System.Drawing.Size(110, 23);
            this.txt_tlf.TabIndex = 8;
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(337, 44);
            this.txt_Ad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.ReadOnly = true;
            this.txt_Ad.Size = new System.Drawing.Size(110, 23);
            this.txt_Ad.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Bölüm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "E-posta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Öğrenci Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Öğrenci Ad";
            // 
            // Odunc2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 382);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Odunc2";
            this.Text = "Odunc2";
            this.Load += new System.EventHandler(this.Odunc2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private TextBox txt_Kitap;
        private Label label7;
        private TextBox txt_No;
        private Button btn_Teslim;
        private Button btnarama;
        protected internal DateTimePicker dateTimePicker1;
    }
}