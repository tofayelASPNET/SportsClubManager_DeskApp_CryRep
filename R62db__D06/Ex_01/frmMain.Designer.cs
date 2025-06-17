namespace Ex_01
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editDeleteShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerInfoReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coachInformationReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRUDSPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEditDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.stuToolStripMenuItem,
            this.coachToolStripMenuItem,
            this.cRUDSPToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1027, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // stuToolStripMenuItem
            // 
            this.stuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editDeleteShowToolStripMenuItem});
            this.stuToolStripMenuItem.Name = "stuToolStripMenuItem";
            this.stuToolStripMenuItem.Size = new System.Drawing.Size(75, 29);
            this.stuToolStripMenuItem.Text = "Player";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(252, 34);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editDeleteShowToolStripMenuItem
            // 
            this.editDeleteShowToolStripMenuItem.Name = "editDeleteShowToolStripMenuItem";
            this.editDeleteShowToolStripMenuItem.Size = new System.Drawing.Size(252, 34);
            this.editDeleteShowToolStripMenuItem.Text = "Edit/Delete/Show";
            this.editDeleteShowToolStripMenuItem.Click += new System.EventHandler(this.editDeleteShowToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerInfoReportToolStripMenuItem,
            this.coachInformationReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // playerInfoReportToolStripMenuItem
            // 
            this.playerInfoReportToolStripMenuItem.Name = "playerInfoReportToolStripMenuItem";
            this.playerInfoReportToolStripMenuItem.Size = new System.Drawing.Size(320, 34);
            this.playerInfoReportToolStripMenuItem.Text = "Player Info Report";
            this.playerInfoReportToolStripMenuItem.Click += new System.EventHandler(this.playerInfoReportToolStripMenuItem_Click);
            // 
            // coachInformationReportToolStripMenuItem
            // 
            this.coachInformationReportToolStripMenuItem.Name = "coachInformationReportToolStripMenuItem";
            this.coachInformationReportToolStripMenuItem.Size = new System.Drawing.Size(320, 34);
            this.coachInformationReportToolStripMenuItem.Text = "Coach Information Report";
            this.coachInformationReportToolStripMenuItem.Click += new System.EventHandler(this.coachInformationReportToolStripMenuItem_Click);
            // 
            // coachToolStripMenuItem
            // 
            this.coachToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.editToolStripMenuItem});
            this.coachToolStripMenuItem.Name = "coachToolStripMenuItem";
            this.coachToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.coachToolStripMenuItem.Text = "Coach";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(201, 34);
            this.addToolStripMenuItem1.Text = "Add";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(201, 34);
            this.editToolStripMenuItem.Text = "Edit/Delete";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // cRUDSPToolStripMenuItem
            // 
            this.cRUDSPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEditDeleteToolStripMenuItem});
            this.cRUDSPToolStripMenuItem.Name = "cRUDSPToolStripMenuItem";
            this.cRUDSPToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.cRUDSPToolStripMenuItem.Text = "CRUD_SP";
            // 
            // addEditDeleteToolStripMenuItem
            // 
            this.addEditDeleteToolStripMenuItem.Name = "addEditDeleteToolStripMenuItem";
            this.addEditDeleteToolStripMenuItem.Size = new System.Drawing.Size(242, 34);
            this.addEditDeleteToolStripMenuItem.Text = "Add/Edit/Delete";
            this.addEditDeleteToolStripMenuItem.Click += new System.EventHandler(this.addEditDeleteToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Font = new System.Drawing.Font("Century", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label1.Location = new System.Drawing.Point(334, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(654, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Player and sports data source";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1027, 641);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editDeleteShowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerInfoReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coachInformationReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRUDSPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEditDeleteToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}