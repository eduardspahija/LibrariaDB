namespace Libraria
{
    partial class frmMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturatDalseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturatHyrëseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.regjistratToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libratToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.punëtorëtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shtëpitëBotueseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.queryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekzekutoQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.faturimiToolStripMenuItem,
            this.regjistratToolStripMenuItem,
            this.queryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(742, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // faturimiToolStripMenuItem
            // 
            this.faturimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.faturatDalseToolStripMenuItem,
            this.faturatHyrëseToolStripMenuItem,
            this.toolStripMenuItem1});
            this.faturimiToolStripMenuItem.Name = "faturimiToolStripMenuItem";
            this.faturimiToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.faturimiToolStripMenuItem.Text = "Fatur&imi";
            // 
            // faturatDalseToolStripMenuItem
            // 
            this.faturatDalseToolStripMenuItem.Name = "faturatDalseToolStripMenuItem";
            this.faturatDalseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.faturatDalseToolStripMenuItem.Text = "Faturat Dalse";
            this.faturatDalseToolStripMenuItem.Click += new System.EventHandler(this.faturatDalseToolStripMenuItem_Click);
            // 
            // faturatHyrëseToolStripMenuItem
            // 
            this.faturatHyrëseToolStripMenuItem.Name = "faturatHyrëseToolStripMenuItem";
            this.faturatHyrëseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.faturatHyrëseToolStripMenuItem.Text = "Faturat Hyrëse";
            this.faturatHyrëseToolStripMenuItem.Click += new System.EventHandler(this.faturatHyrëseToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Lista e faturave";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // regjistratToolStripMenuItem
            // 
            this.regjistratToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.libratToolStripMenuItem,
            this.personatToolStripMenuItem,
            this.punëtorëtToolStripMenuItem,
            this.shtëpitëBotueseToolStripMenuItem});
            this.regjistratToolStripMenuItem.Name = "regjistratToolStripMenuItem";
            this.regjistratToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.regjistratToolStripMenuItem.Text = "&Regjistrat";
            // 
            // libratToolStripMenuItem
            // 
            this.libratToolStripMenuItem.Name = "libratToolStripMenuItem";
            this.libratToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.libratToolStripMenuItem.Text = "Librat";
            this.libratToolStripMenuItem.Click += new System.EventHandler(this.libratToolStripMenuItem_Click);
            // 
            // personatToolStripMenuItem
            // 
            this.personatToolStripMenuItem.Name = "personatToolStripMenuItem";
            this.personatToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.personatToolStripMenuItem.Text = "Personat";
            this.personatToolStripMenuItem.Click += new System.EventHandler(this.personatToolStripMenuItem_Click);
            // 
            // punëtorëtToolStripMenuItem
            // 
            this.punëtorëtToolStripMenuItem.Name = "punëtorëtToolStripMenuItem";
            this.punëtorëtToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.punëtorëtToolStripMenuItem.Text = "Punëtorët";
            this.punëtorëtToolStripMenuItem.Click += new System.EventHandler(this.punëtorëtToolStripMenuItem_Click);
            // 
            // shtëpitëBotueseToolStripMenuItem
            // 
            this.shtëpitëBotueseToolStripMenuItem.Name = "shtëpitëBotueseToolStripMenuItem";
            this.shtëpitëBotueseToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.shtëpitëBotueseToolStripMenuItem.Text = "Shtëpitë Botuese";
            this.shtëpitëBotueseToolStripMenuItem.Click += new System.EventHandler(this.shtëpitëBotueseToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(742, 351);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // queryToolStripMenuItem
            // 
            this.queryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekzekutoQueryToolStripMenuItem});
            this.queryToolStripMenuItem.Name = "queryToolStripMenuItem";
            this.queryToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.queryToolStripMenuItem.Text = "Query";
            // 
            // ekzekutoQueryToolStripMenuItem
            // 
            this.ekzekutoQueryToolStripMenuItem.Name = "ekzekutoQueryToolStripMenuItem";
            this.ekzekutoQueryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ekzekutoQueryToolStripMenuItem.Text = "Ekzekuto query";
            this.ekzekutoQueryToolStripMenuItem.Click += new System.EventHandler(this.ekzekutoQueryToolStripMenuItem_Click);
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(742, 375);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainForm";
            this.Text = "Libraria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturatDalseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturatHyrëseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regjistratToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libratToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem punëtorëtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shtëpitëBotueseToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem queryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekzekutoQueryToolStripMenuItem;
    }
}