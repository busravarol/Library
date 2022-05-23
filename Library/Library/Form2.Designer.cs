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
            this.kitapListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciDetayıGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ıssueBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iadeKitaplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapDetaylarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.BackColor = System.Drawing.Color.Chocolate;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitaplarToolStripMenuItem,
            this.öğrenciToolStripMenuItem,
            this.ıssueBookToolStripMenuItem,
            this.iadeKitaplarToolStripMenuItem,
            this.kitapDetaylarıToolStripMenuItem,
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
            this.kitapEkleToolStripMenuItem,
            this.kitapListesiToolStripMenuItem});
            this.kitaplarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kitaplarToolStripMenuItem.Image")));
            this.kitaplarToolStripMenuItem.Name = "kitaplarToolStripMenuItem";
            this.kitaplarToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.kitaplarToolStripMenuItem.Text = "Kitaplar";
            // 
            // kitapEkleToolStripMenuItem
            // 
            this.kitapEkleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kitapEkleToolStripMenuItem.Image")));
            this.kitapEkleToolStripMenuItem.Name = "kitapEkleToolStripMenuItem";
            this.kitapEkleToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.kitapEkleToolStripMenuItem.Text = "Kitap Ekle";
            this.kitapEkleToolStripMenuItem.Click += new System.EventHandler(this.kitapEkleToolStripMenuItem_Click);
            // 
            // kitapListesiToolStripMenuItem
            // 
            this.kitapListesiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kitapListesiToolStripMenuItem.Image")));
            this.kitapListesiToolStripMenuItem.Name = "kitapListesiToolStripMenuItem";
            this.kitapListesiToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.kitapListesiToolStripMenuItem.Text = "Kitap Listesi";
            this.kitapListesiToolStripMenuItem.Click += new System.EventHandler(this.kitapListesiToolStripMenuItem_Click);
            // 
            // öğrenciToolStripMenuItem
            // 
            this.öğrenciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciEkleToolStripMenuItem,
            this.öğrenciDetayıGörüntüleToolStripMenuItem});
            this.öğrenciToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("öğrenciToolStripMenuItem.Image")));
            this.öğrenciToolStripMenuItem.Name = "öğrenciToolStripMenuItem";
            this.öğrenciToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.öğrenciToolStripMenuItem.Text = "Öğrenci";
            this.öğrenciToolStripMenuItem.Click += new System.EventHandler(this.öğrenciToolStripMenuItem_Click);
            // 
            // öğrenciEkleToolStripMenuItem
            // 
            this.öğrenciEkleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("öğrenciEkleToolStripMenuItem.Image")));
            this.öğrenciEkleToolStripMenuItem.Name = "öğrenciEkleToolStripMenuItem";
            this.öğrenciEkleToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.öğrenciEkleToolStripMenuItem.Text = "Öğrenci Ekle";
            this.öğrenciEkleToolStripMenuItem.Click += new System.EventHandler(this.öğrenciEkleToolStripMenuItem_Click);
            // 
            // öğrenciDetayıGörüntüleToolStripMenuItem
            // 
            this.öğrenciDetayıGörüntüleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("öğrenciDetayıGörüntüleToolStripMenuItem.Image")));
            this.öğrenciDetayıGörüntüleToolStripMenuItem.Name = "öğrenciDetayıGörüntüleToolStripMenuItem";
            this.öğrenciDetayıGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.öğrenciDetayıGörüntüleToolStripMenuItem.Text = "Öğrenci Detayı Görüntüle";
            // 
            // ıssueBookToolStripMenuItem
            // 
            this.ıssueBookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ıssueBookToolStripMenuItem.Image")));
            this.ıssueBookToolStripMenuItem.Name = "ıssueBookToolStripMenuItem";
            this.ıssueBookToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.ıssueBookToolStripMenuItem.Text = "Kitap Listesi";
            // 
            // iadeKitaplarToolStripMenuItem
            // 
            this.iadeKitaplarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("iadeKitaplarToolStripMenuItem.Image")));
            this.iadeKitaplarToolStripMenuItem.Name = "iadeKitaplarToolStripMenuItem";
            this.iadeKitaplarToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.iadeKitaplarToolStripMenuItem.Text = "İade Kitaplar";
            // 
            // kitapDetaylarıToolStripMenuItem
            // 
            this.kitapDetaylarıToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kitapDetaylarıToolStripMenuItem.Image")));
            this.kitapDetaylarıToolStripMenuItem.Name = "kitapDetaylarıToolStripMenuItem";
            this.kitapDetaylarıToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.kitapDetaylarıToolStripMenuItem.Text = "Kitap Detayları";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.exitToolStripMenuItem.Text = "Çıkış";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1150, 695);
            this.Controls.Add(this.menuStrip1);
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
        private ToolStripMenuItem kitapListesiToolStripMenuItem;
        private ToolStripMenuItem öğrenciToolStripMenuItem;
        private ToolStripMenuItem öğrenciEkleToolStripMenuItem;
        private ToolStripMenuItem öğrenciDetayıGörüntüleToolStripMenuItem;
        private ToolStripMenuItem ıssueBookToolStripMenuItem;
        private ToolStripMenuItem iadeKitaplarToolStripMenuItem;
        private ToolStripMenuItem kitapDetaylarıToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}