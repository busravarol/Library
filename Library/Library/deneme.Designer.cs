namespace Library
{
    partial class kitap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kitap));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.txt_Yazar = new System.Windows.Forms.TextBox();
            this.txt_Ss = new System.Windows.Forms.TextBox();
            this.txt_Yayinevi = new System.Windows.Forms.TextBox();
            this.txt_ISBN = new System.Windows.Forms.TextBox();
            this.txt_Kategori = new System.Windows.Forms.TextBox();
            this.txt_Tarih = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitabın Adı:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kitabın Yazarı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sayfa Sayısı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Yayınevi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "ISBN:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Kategori:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(269, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Eklendiği Tarih:";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(62, 53);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(125, 27);
            this.txt_ID.TabIndex = 8;
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(269, 53);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(125, 27);
            this.txt_Ad.TabIndex = 9;
            // 
            // txt_Yazar
            // 
            this.txt_Yazar.Location = new System.Drawing.Point(63, 140);
            this.txt_Yazar.Name = "txt_Yazar";
            this.txt_Yazar.Size = new System.Drawing.Size(125, 27);
            this.txt_Yazar.TabIndex = 10;
            // 
            // txt_Ss
            // 
            this.txt_Ss.Location = new System.Drawing.Point(269, 131);
            this.txt_Ss.Name = "txt_Ss";
            this.txt_Ss.Size = new System.Drawing.Size(125, 27);
            this.txt_Ss.TabIndex = 11;
            // 
            // txt_Yayinevi
            // 
            this.txt_Yayinevi.Location = new System.Drawing.Point(63, 210);
            this.txt_Yayinevi.Name = "txt_Yayinevi";
            this.txt_Yayinevi.Size = new System.Drawing.Size(125, 27);
            this.txt_Yayinevi.TabIndex = 12;
            // 
            // txt_ISBN
            // 
            this.txt_ISBN.Location = new System.Drawing.Point(269, 210);
            this.txt_ISBN.Name = "txt_ISBN";
            this.txt_ISBN.Size = new System.Drawing.Size(125, 27);
            this.txt_ISBN.TabIndex = 13;
            // 
            // txt_Kategori
            // 
            this.txt_Kategori.Location = new System.Drawing.Point(63, 282);
            this.txt_Kategori.Name = "txt_Kategori";
            this.txt_Kategori.Size = new System.Drawing.Size(125, 27);
            this.txt_Kategori.TabIndex = 14;
            // 
            // txt_Tarih
            // 
            this.txt_Tarih.Location = new System.Drawing.Point(269, 282);
            this.txt_Tarih.Name = "txt_Tarih";
            this.txt_Tarih.Size = new System.Drawing.Size(125, 27);
            this.txt_Tarih.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(138)))), ((int)(((byte)(185)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(21, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 80);
            this.button1.TabIndex = 16;
            this.button1.Text = "KİTAP EKLE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(138)))), ((int)(((byte)(185)))));
            this.button2.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(162, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 78);
            this.button2.TabIndex = 17;
            this.button2.Text = "KİTAP SİL";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(138)))), ((int)(((byte)(185)))));
            this.button3.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(311, 343);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 78);
            this.button3.TabIndex = 18;
            this.button3.Text = "KİTAP GÜNCELLE";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(581, 486);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(198)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.txt_ID);
            this.panel1.Controls.Add(this.txt_Ss);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.txt_Kategori);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_Tarih);
            this.panel1.Controls.Add(this.txt_ISBN);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_Ad);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_Yazar);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_Yayinevi);
            this.panel1.Location = new System.Drawing.Point(116, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 484);
            this.panel1.TabIndex = 20;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-1, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 106);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // kitap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(138)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(706, 605);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "kitap";
            this.Text = "kitap";
            this.Load += new System.EventHandler(this.deneme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txt_ID;
        private TextBox txt_Ad;
        private TextBox txt_Yazar;
        private TextBox txt_Ss;
        private TextBox txt_Yayinevi;
        private TextBox txt_ISBN;
        private TextBox txt_Kategori;
        private TextBox txt_Tarih;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
    }
}