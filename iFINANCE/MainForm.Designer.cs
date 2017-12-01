﻿namespace iFINANCE
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageAccountGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.function2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.function3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financialReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.andSoOnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.manageAccountGroupToolStripMenuItem,
            this.function2ToolStripMenuItem,
            this.function3ToolStripMenuItem,
            this.financialReportsToolStripMenuItem,
            this.andSoOnToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.windowToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1308, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // manageAccountGroupToolStripMenuItem
            // 
            this.manageAccountGroupToolStripMenuItem.Checked = true;
            this.manageAccountGroupToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.manageAccountGroupToolStripMenuItem.Name = "manageAccountGroupToolStripMenuItem";
            this.manageAccountGroupToolStripMenuItem.Size = new System.Drawing.Size(146, 20);
            this.manageAccountGroupToolStripMenuItem.Text = "Manage Account Group";
            this.manageAccountGroupToolStripMenuItem.Click += new System.EventHandler(this.manageAccountGroupToolStripMenuItem_Click);
            // 
            // function2ToolStripMenuItem
            // 
            this.function2ToolStripMenuItem.Name = "function2ToolStripMenuItem";
            this.function2ToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.function2ToolStripMenuItem.Text = "Chart of Accounts";
            this.function2ToolStripMenuItem.Click += new System.EventHandler(this.ChartofAccountsToolStripMenuItem_Click);
            // 
            // function3ToolStripMenuItem
            // 
            this.function3ToolStripMenuItem.Name = "function3ToolStripMenuItem";
            this.function3ToolStripMenuItem.Size = new System.Drawing.Size(159, 20);
            this.function3ToolStripMenuItem.Text = "Double-Entry Transactions";
            // 
            // financialReportsToolStripMenuItem
            // 
            this.financialReportsToolStripMenuItem.Name = "financialReportsToolStripMenuItem";
            this.financialReportsToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.financialReportsToolStripMenuItem.Text = "Financial Reports";
            // 
            // andSoOnToolStripMenuItem
            // 
            this.andSoOnToolStripMenuItem.Name = "andSoOnToolStripMenuItem";
            this.andSoOnToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.andSoOnToolStripMenuItem.Text = "Change Password";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.tileVerticalToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "&Window";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.cascadeToolStripMenuItem.Text = "Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.tileHorizontalToolStripMenuItem.Text = "TileHorizontal";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.tileHorizontalToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.tileVerticalToolStripMenuItem.Text = "TileVertical";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.tileVerticalToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iFINANCE.Properties.Resources.western_background;
            this.ClientSize = new System.Drawing.Size(1308, 805);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "iFINANCE";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageAccountGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem function2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem function3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem andSoOnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financialReportsToolStripMenuItem;
    }
}

