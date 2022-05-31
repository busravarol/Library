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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kitaplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciDetayıGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ıssueBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iadeKitaplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapDetaylarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istatistikVerilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teslimAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(198)))), ((int)(((byte)(244)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitaplarToolStripMenuItem,
            this.öğrenciToolStripMenuItem,
            this.ıssueBookToolStripMenuItem,
            this.iadeKitaplarToolStripMenuItem,
            this.kitapDetaylarıToolStripMenuItem,
            this.istatistikVerilerToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1150, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kitaplarToolStripMenuItem
            // 
            this.kitaplarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapEkleToolStripMenuItem});
            this.kitaplarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kitaplarToolStripMenuItem.Image")));
            this.kitaplarToolStripMenuItem.Name = "kitaplarToolStripMenuItem";
            this.kitaplarToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.kitaplarToolStripMenuItem.Text = "Kitaplar";
            // 
            // kitapEkleToolStripMenuItem
            // 
            this.kitapEkleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kitapEkleToolStripMenuItem.Image")));
            this.kitapEkleToolStripMenuItem.Name = "kitapEkleToolStripMenuItem";
            this.kitapEkleToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.kitapEkleToolStripMenuItem.Text = "Kitap Ekle";
            this.kitapEkleToolStripMenuItem.Click += new System.EventHandler(this.kitapEkleToolStripMenuItem_Click);
            // 
            // öğrenciToolStripMenuItem
            // 
            this.öğrenciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciEkleToolStripMenuItem,
            this.öğrenciDetayıGörüntüleToolStripMenuItem});
            this.öğrenciToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("öğrenciToolStripMenuItem.Image")));
            this.öğrenciToolStripMenuItem.Name = "öğrenciToolStripMenuItem";
            this.öğrenciToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.öğrenciToolStripMenuItem.Text = "Öğrenci";
            this.öğrenciToolStripMenuItem.Click += new System.EventHandler(this.öğrenciToolStripMenuItem_Click);
            // 
            // öğrenciEkleToolStripMenuItem
            // 
            this.öğrenciEkleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("öğrenciEkleToolStripMenuItem.Image")));
            this.öğrenciEkleToolStripMenuItem.Name = "öğrenciEkleToolStripMenuItem";
            this.öğrenciEkleToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.öğrenciEkleToolStripMenuItem.Text = "Öğrenci Ekle";
            this.öğrenciEkleToolStripMenuItem.Click += new System.EventHandler(this.öğrenciEkleToolStripMenuItem_Click);
            // 
            // öğrenciDetayıGörüntüleToolStripMenuItem
            // 
            this.öğrenciDetayıGörüntüleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("öğrenciDetayıGörüntüleToolStripMenuItem.Image")));
            this.öğrenciDetayıGörüntüleToolStripMenuItem.Name = "öğrenciDetayıGörüntüleToolStripMenuItem";
            this.öğrenciDetayıGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.öğrenciDetayıGörüntüleToolStripMenuItem.Text = "Öğrenci Detayı Görüntüle";
            this.öğrenciDetayıGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.öğrenciDetayıGörüntüleToolStripMenuItem_Click);
            // 
            // ıssueBookToolStripMenuItem
            // 
            this.ıssueBookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ıssueBookToolStripMenuItem.Image")));
            this.ıssueBookToolStripMenuItem.Name = "ıssueBookToolStripMenuItem";
            this.ıssueBookToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.ıssueBookToolStripMenuItem.Text = "Kitap Listesi";
            this.ıssueBookToolStripMenuItem.Click += new System.EventHandler(this.ıssueBookToolStripMenuItem_Click);
            // 
            // iadeKitaplarToolStripMenuItem
            // 
            this.iadeKitaplarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teslimAlToolStripMenuItem});
            this.iadeKitaplarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("iadeKitaplarToolStripMenuItem.Image")));
            this.iadeKitaplarToolStripMenuItem.Name = "iadeKitaplarToolStripMenuItem";
            this.iadeKitaplarToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.iadeKitaplarToolStripMenuItem.Text = "İade Kitaplar";
            this.iadeKitaplarToolStripMenuItem.Click += new System.EventHandler(this.iadeKitaplarToolStripMenuItem_Click);
            // 
            // kitapDetaylarıToolStripMenuItem
            // 
            this.kitapDetaylarıToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kitapDetaylarıToolStripMenuItem.Image")));
            this.kitapDetaylarıToolStripMenuItem.Name = "kitapDetaylarıToolStripMenuItem";
            this.kitapDetaylarıToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.kitapDetaylarıToolStripMenuItem.Text = "Kitap Detayları";
            this.kitapDetaylarıToolStripMenuItem.Click += new System.EventHandler(this.kitapDetaylarıToolStripMenuItem_Click);
            // 
            // istatistikVerilerToolStripMenuItem
            // 
            this.istatistikVerilerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("istatistikVerilerToolStripMenuItem.Image")));
            this.istatistikVerilerToolStripMenuItem.Name = "istatistikVerilerToolStripMenuItem";
            this.istatistikVerilerToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.istatistikVerilerToolStripMenuItem.Text = "İstatistik Veriler";
            this.istatistikVerilerToolStripMenuItem.Click += new System.EventHandler(this.istatistikVerilerToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.exitToolStripMenuItem.Text = "Çıkış";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // teslimAlToolStripMenuItem
            // 
            this.teslimAlToolStripMenuItem.Name = "teslimAlToolStripMenuItem";
            this.teslimAlToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.teslimAlToolStripMenuItem.Text = "Teslim Al";
            this.teslimAlToolStripMenuItem.Click += new System.EventHandler(this.teslimAlToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1150, 695);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "anasayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem kitaplarToolStripMenuItem;
        private ToolStripMenuItem kitapEkleToolStripMenuItem;
        private ToolStripMenuItem öğrenciToolStripMenuItem;
        private ToolStripMenuItem öğrenciEkleToolStripMenuItem;
        private ToolStripMenuItem öğrenciDetayıGörüntüleToolStripMenuItem;
        private ToolStripMenuItem ıssueBookToolStripMenuItem;
        private ToolStripMenuItem iadeKitaplarToolStripMenuItem;
        private ToolStripMenuItem kitapDetaylarıToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem istatistikVerilerToolStripMenuItem;
        private ToolStripMenuItem teslimAlToolStripMenuItem;
    }
}