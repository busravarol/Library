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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(60, 55);
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
            this.label2.Location = new System.Drawing.Point(347, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Toplam Kitap Sayısı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(60, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "En Çok Okunan 5 Kitap:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(347, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "En Çok Kitap Okuyan:";
            // 
            // toplam_Ogrenci
            // 
            this.toplam_Ogrenci.AutoSize = true;
            this.toplam_Ogrenci.Location = new System.Drawing.Point(71, 100);
            this.toplam_Ogrenci.Name = "toplam_Ogrenci";
            this.toplam_Ogrenci.Size = new System.Drawing.Size(25, 20);
            this.toplam_Ogrenci.TabIndex = 4;
            this.toplam_Ogrenci.Text = "00";
            // 
            // toplam_Kitap
            // 
            this.toplam_Kitap.AutoSize = true;
            this.toplam_Kitap.Location = new System.Drawing.Point(390, 100);
            this.toplam_Kitap.Name = "toplam_Kitap";
            this.toplam_Kitap.Size = new System.Drawing.Size(25, 20);
            this.toplam_Kitap.TabIndex = 5;
            this.toplam_Kitap.Text = "00";
            // 
            // lblCokOkunan
            // 
            this.lblCokOkunan.AutoSize = true;
            this.lblCokOkunan.Location = new System.Drawing.Point(71, 247);
            this.lblCokOkunan.Name = "lblCokOkunan";
            this.lblCokOkunan.Size = new System.Drawing.Size(25, 20);
            this.lblCokOkunan.TabIndex = 6;
            this.lblCokOkunan.Text = "00";
            // 
            // lblCokOkuyan
            // 
            this.lblCokOkuyan.AutoSize = true;
            this.lblCokOkuyan.Location = new System.Drawing.Point(390, 257);
            this.lblCokOkuyan.Name = "lblCokOkuyan";
            this.lblCokOkuyan.Size = new System.Drawing.Size(25, 20);
            this.lblCokOkuyan.TabIndex = 7;
            this.lblCokOkuyan.Text = "00";
            // 
            // istatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(138)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(596, 394);
            this.Controls.Add(this.lblCokOkuyan);
            this.Controls.Add(this.lblCokOkunan);
            this.Controls.Add(this.toplam_Kitap);
            this.Controls.Add(this.toplam_Ogrenci);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "istatistik";
            this.Text = "istatistik";
            this.Load += new System.EventHandler(this.istatistik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}