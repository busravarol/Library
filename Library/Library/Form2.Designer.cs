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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(138)))), ((int)(((byte)(185)))));
            this.button1.Location = new System.Drawing.Point(79, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(283, 91);
            this.button1.TabIndex = 2;
            this.button1.Text = "Kitap Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(138)))), ((int)(((byte)(185)))));
            this.button2.Location = new System.Drawing.Point(461, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(283, 91);
            this.button2.TabIndex = 3;
            this.button2.Text = "Öğrenci Detayı Görüntüle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(138)))), ((int)(((byte)(185)))));
            this.button3.Location = new System.Drawing.Point(461, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(283, 91);
            this.button3.TabIndex = 4;
            this.button3.Text = "Öğrenci Ekle";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(138)))), ((int)(((byte)(185)))));
            this.button4.Location = new System.Drawing.Point(79, 206);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(283, 91);
            this.button4.TabIndex = 5;
            this.button4.Text = "Kitap Listesi";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(138)))), ((int)(((byte)(185)))));
            this.button5.Location = new System.Drawing.Point(79, 332);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(283, 91);
            this.button5.TabIndex = 6;
            this.button5.Text = "İade Kitaplar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(138)))), ((int)(((byte)(185)))));
            this.button6.Location = new System.Drawing.Point(79, 464);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(283, 91);
            this.button6.TabIndex = 7;
            this.button6.Text = "Kitap Detayları";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(138)))), ((int)(((byte)(185)))));
            this.button7.Location = new System.Drawing.Point(826, 71);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(283, 91);
            this.button7.TabIndex = 8;
            this.button7.Text = "İstatistik Veriler";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(198)))), ((int)(((byte)(244)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1305, 695);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form2";
            this.Text = "anasayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}