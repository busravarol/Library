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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Yazar = new System.Windows.Forms.TextBox();
            this.txt_Ss = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_kitap = new System.Windows.Forms.TextBox();
            this.yayın_Box = new System.Windows.Forms.ComboBox();
            this.kategori_Box = new System.Windows.Forms.ComboBox();
            this.txt_Tarih = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitabın Adı:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kitabın Yazarı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sayfa Sayısı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Yayınevi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Kategori:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Basım Yılı:";
            // 
            // txt_Yazar
            // 
            this.txt_Yazar.Location = new System.Drawing.Point(178, 27);
            this.txt_Yazar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Yazar.Name = "txt_Yazar";
            this.txt_Yazar.Size = new System.Drawing.Size(139, 23);
            this.txt_Yazar.TabIndex = 10;
            // 
            // txt_Ss
            // 
            this.txt_Ss.Location = new System.Drawing.Point(178, 77);
            this.txt_Ss.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Ss.Name = "txt_Ss";
            this.txt_Ss.Size = new System.Drawing.Size(139, 23);
            this.txt_Ss.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(178, 215);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 46);
            this.button1.TabIndex = 16;
            this.button1.Text = "KİTAP EKLE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(99)))));
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_kitap);
            this.panel1.Controls.Add(this.yayın_Box);
            this.panel1.Controls.Add(this.kategori_Box);
            this.panel1.Controls.Add(this.txt_Tarih);
            this.panel1.Controls.Add(this.txt_Ss);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_Yazar);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(247, 156);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 354);
            this.panel1.TabIndex = 20;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txt_kitap
            // 
            this.txt_kitap.Location = new System.Drawing.Point(12, 27);
            this.txt_kitap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_kitap.Name = "txt_kitap";
            this.txt_kitap.Size = new System.Drawing.Size(139, 23);
            this.txt_kitap.TabIndex = 22;
            // 
            // yayın_Box
            // 
            this.yayın_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yayın_Box.FormattingEnabled = true;
            this.yayın_Box.Location = new System.Drawing.Point(12, 77);
            this.yayın_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yayın_Box.Name = "yayın_Box";
            this.yayın_Box.Size = new System.Drawing.Size(139, 23);
            this.yayın_Box.TabIndex = 22;
            this.yayın_Box.SelectedIndexChanged += new System.EventHandler(this.yayın_Box_SelectedIndexChanged);
            // 
            // kategori_Box
            // 
            this.kategori_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kategori_Box.FormattingEnabled = true;
            this.kategori_Box.Location = new System.Drawing.Point(12, 128);
            this.kategori_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kategori_Box.Name = "kategori_Box";
            this.kategori_Box.Size = new System.Drawing.Size(139, 23);
            this.kategori_Box.TabIndex = 23;
            this.kategori_Box.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_Tarih
            // 
            this.txt_Tarih.Location = new System.Drawing.Point(12, 176);
            this.txt_Tarih.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Tarih.Name = "txt_Tarih";
            this.txt_Tarih.Size = new System.Drawing.Size(139, 23);
            this.txt_Tarih.TabIndex = 22;
            this.txt_Tarih.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Dolap No:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 232);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 23);
            this.textBox1.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Raf No:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 279);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(139, 23);
            this.textBox2.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(178, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 15);
            this.label9.TabIndex = 28;
            this.label9.Text = "Stok Sayısı:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(178, 128);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(139, 23);
            this.textBox3.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 15);
            this.label10.TabIndex = 30;
            this.label10.Text = "Dil:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(178, 176);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(139, 23);
            this.textBox4.TabIndex = 31;
            // 
            // kitap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1355, 616);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "kitap";
            this.Text = "kitap";
            this.Load += new System.EventHandler(this.deneme_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private TextBox txt_Yazar;
        private TextBox txt_Ss;
        private Button button1;
        private Panel panel1;
        private TextBox txt_Tarih;
        private ComboBox kategori_Box;
        private ComboBox yayın_Box;
        private TextBox txt_kitap;
        private TextBox textBox4;
        private Label label10;
        private TextBox textBox3;
        private Label label9;
        private TextBox textBox2;
        private Label label6;
        private TextBox textBox1;
        private Label label1;
    }
}