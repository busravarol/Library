namespace Library
{
    partial class TeslimAl
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_no = new System.Windows.Forms.TextBox();
            this.btn_Ara = new System.Windows.Forms.Button();
            this.btn_yenile = new System.Windows.Forms.Button();
            this.btn_al = new System.Windows.Forms.Button();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_kiad = new System.Windows.Forms.TextBox();
            this.txt_vetarih = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_yenile);
            this.panel1.Controls.Add(this.btn_Ara);
            this.panel1.Controls.Add(this.txt_no);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(31, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 345);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.txt_vetarih);
            this.panel2.Controls.Add(this.txt_kiad);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_iptal);
            this.panel2.Controls.Add(this.btn_al);
            this.panel2.Location = new System.Drawing.Point(369, 414);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 178);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(369, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(596, 345);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ögrenci No";
            // 
            // txt_no
            // 
            this.txt_no.Location = new System.Drawing.Point(55, 170);
            this.txt_no.Name = "txt_no";
            this.txt_no.Size = new System.Drawing.Size(159, 27);
            this.txt_no.TabIndex = 1;
            this.txt_no.TextChanged += new System.EventHandler(this.txt_no_TextChanged);
            // 
            // btn_Ara
            // 
            this.btn_Ara.Location = new System.Drawing.Point(77, 225);
            this.btn_Ara.Name = "btn_Ara";
            this.btn_Ara.Size = new System.Drawing.Size(107, 29);
            this.btn_Ara.TabIndex = 2;
            this.btn_Ara.Text = "Öğrenci Ara";
            this.btn_Ara.UseVisualStyleBackColor = true;
            this.btn_Ara.Click += new System.EventHandler(this.btn_Ara_Click);
            // 
            // btn_yenile
            // 
            this.btn_yenile.Location = new System.Drawing.Point(77, 287);
            this.btn_yenile.Name = "btn_yenile";
            this.btn_yenile.Size = new System.Drawing.Size(107, 29);
            this.btn_yenile.TabIndex = 3;
            this.btn_yenile.Text = "Yenile";
            this.btn_yenile.UseVisualStyleBackColor = true;
            this.btn_yenile.Click += new System.EventHandler(this.btn_yenile_Click);
            // 
            // btn_al
            // 
            this.btn_al.Location = new System.Drawing.Point(381, 73);
            this.btn_al.Name = "btn_al";
            this.btn_al.Size = new System.Drawing.Size(94, 29);
            this.btn_al.TabIndex = 0;
            this.btn_al.Text = "Teslim Al";
            this.btn_al.UseVisualStyleBackColor = true;
            this.btn_al.Click += new System.EventHandler(this.btn_al_Click);
            // 
            // btn_iptal
            // 
            this.btn_iptal.Location = new System.Drawing.Point(381, 117);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(94, 29);
            this.btn_iptal.TabIndex = 1;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.UseVisualStyleBackColor = true;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kitap Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Teslim Verilen Tarih";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Teslim Alınan Tarih";
            // 
            // txt_kiad
            // 
            this.txt_kiad.Location = new System.Drawing.Point(171, 26);
            this.txt_kiad.Name = "txt_kiad";
            this.txt_kiad.Size = new System.Drawing.Size(125, 27);
            this.txt_kiad.TabIndex = 5;
            // 
            // txt_vetarih
            // 
            this.txt_vetarih.Location = new System.Drawing.Point(209, 66);
            this.txt_vetarih.Name = "txt_vetarih";
            this.txt_vetarih.Size = new System.Drawing.Size(125, 27);
            this.txt_vetarih.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(209, 112);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(140, 27);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // TeslimAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 607);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TeslimAl";
            this.Text = "TeslimAl";
            this.Load += new System.EventHandler(this.TeslimAl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Button btn_yenile;
        private Button btn_Ara;
        private TextBox txt_no;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private TextBox txt_vetarih;
        private TextBox txt_kiad;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btn_iptal;
        private Button btn_al;
    }
}