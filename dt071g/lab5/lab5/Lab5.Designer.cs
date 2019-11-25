namespace lab5
{
    partial class Lab5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab5));
            this.FireButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolTip = new System.Windows.Forms.ToolStripMenuItem();
            this.nyttSpelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inställningarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avslutaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.panel = new System.Windows.Forms.Panel();
            this.goalSprite = new System.Windows.Forms.PictureBox();
            this.ShootProgress = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goalSprite)).BeginInit();
            this.SuspendLayout();
            // 
            // FireButton
            // 
            this.FireButton.Location = new System.Drawing.Point(12, 345);
            this.FireButton.Name = "FireButton";
            this.FireButton.Size = new System.Drawing.Size(75, 23);
            this.FireButton.TabIndex = 0;
            this.FireButton.Text = "Aim...";
            this.FireButton.UseVisualStyleBackColor = true;
            this.FireButton.Click += new System.EventHandler(this.FireButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolTip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1311, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolTip
            // 
            this.menuToolTip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nyttSpelToolStripMenuItem,
            this.inställningarToolStripMenuItem,
            this.avslutaToolStripMenuItem1});
            this.menuToolTip.Name = "menuToolTip";
            this.menuToolTip.Size = new System.Drawing.Size(50, 20);
            this.menuToolTip.Text = "Menu";
            this.menuToolTip.Click += new System.EventHandler(this.avslutaToolStripMenuItem_Click);
            // 
            // nyttSpelToolStripMenuItem
            // 
            this.nyttSpelToolStripMenuItem.Name = "nyttSpelToolStripMenuItem";
            this.nyttSpelToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.nyttSpelToolStripMenuItem.Text = "New Game";
            // 
            // inställningarToolStripMenuItem
            // 
            this.inställningarToolStripMenuItem.Name = "inställningarToolStripMenuItem";
            this.inställningarToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.inställningarToolStripMenuItem.Text = "Settings";
            // 
            // avslutaToolStripMenuItem1
            // 
            this.avslutaToolStripMenuItem1.Name = "avslutaToolStripMenuItem1";
            this.avslutaToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.avslutaToolStripMenuItem1.Text = "Quit";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.goalSprite);
            this.panel.Location = new System.Drawing.Point(0, 27);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1311, 302);
            this.panel.TabIndex = 2;
            // 
            // goalSprite
            // 
            this.goalSprite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("goalSprite.BackgroundImage")));
            this.goalSprite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.goalSprite.Location = new System.Drawing.Point(1177, 99);
            this.goalSprite.Name = "goalSprite";
            this.goalSprite.Size = new System.Drawing.Size(131, 200);
            this.goalSprite.TabIndex = 0;
            this.goalSprite.TabStop = false;
            this.goalSprite.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ShootProgress
            // 
            this.ShootProgress.Location = new System.Drawing.Point(105, 345);
            this.ShootProgress.Name = "ShootProgress";
            this.ShootProgress.Size = new System.Drawing.Size(225, 23);
            this.ShootProgress.TabIndex = 1;
            this.ShootProgress.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // Lab5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 380);
            this.Controls.Add(this.ShootProgress);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.FireButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Lab5";
            this.Text = "Lab5";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.goalSprite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FireButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolTip;
        private System.Windows.Forms.ToolStripMenuItem inställningarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avslutaToolStripMenuItem1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem nyttSpelToolStripMenuItem;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox goalSprite;
        private System.Windows.Forms.ProgressBar ShootProgress;
    }
}

