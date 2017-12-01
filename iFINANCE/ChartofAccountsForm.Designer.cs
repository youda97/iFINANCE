namespace iFINANCE
{
    partial class ChartofAccountsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.nodeContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changeNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addAccountBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.oAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.accountName = new System.Windows.Forms.TextBox();
            this.gNameLable = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.acNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.nodeContextMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(269, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chart of Accounts Form";
            // 
            // nodeContextMenu
            // 
            this.nodeContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeNameToolStripMenuItem,
            this.addAccountToolStripMenuItem,
            this.removeAccountToolStripMenuItem});
            this.nodeContextMenu.Name = "nodeContextMenu";
            this.nodeContextMenu.Size = new System.Drawing.Size(166, 70);
            // 
            // changeNameToolStripMenuItem
            // 
            this.changeNameToolStripMenuItem.Name = "changeNameToolStripMenuItem";
            this.changeNameToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.changeNameToolStripMenuItem.Text = "Change Name";
            // 
            // addAccountToolStripMenuItem
            // 
            this.addAccountToolStripMenuItem.Name = "addAccountToolStripMenuItem";
            this.addAccountToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.addAccountToolStripMenuItem.Text = "Add Account";
            // 
            // removeAccountToolStripMenuItem
            // 
            this.removeAccountToolStripMenuItem.Name = "removeAccountToolStripMenuItem";
            this.removeAccountToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.removeAccountToolStripMenuItem.Text = "Remove Account";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addAccountBtn);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.oAmount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.accountName);
            this.groupBox1.Controls.Add(this.gNameLable);
            this.groupBox1.Location = new System.Drawing.Point(791, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 386);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Account";
            // 
            // addAccountBtn
            // 
            this.addAccountBtn.Location = new System.Drawing.Point(92, 338);
            this.addAccountBtn.Name = "addAccountBtn";
            this.addAccountBtn.Size = new System.Drawing.Size(75, 23);
            this.addAccountBtn.TabIndex = 8;
            this.addAccountBtn.Text = "Add";
            this.addAccountBtn.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(19, 241);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 26);
            this.comboBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Group Names";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oAmount
            // 
            this.oAmount.Location = new System.Drawing.Point(21, 162);
            this.oAmount.Name = "oAmount";
            this.oAmount.Size = new System.Drawing.Size(149, 24);
            this.oAmount.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Opening Amount";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // accountName
            // 
            this.accountName.Location = new System.Drawing.Point(19, 89);
            this.accountName.Name = "accountName";
            this.accountName.Size = new System.Drawing.Size(149, 24);
            this.accountName.TabIndex = 1;
            // 
            // gNameLable
            // 
            this.gNameLable.AutoSize = true;
            this.gNameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gNameLable.Location = new System.Drawing.Point(16, 60);
            this.gNameLable.Name = "gNameLable";
            this.gNameLable.Size = new System.Drawing.Size(96, 16);
            this.gNameLable.TabIndex = 0;
            this.gNameLable.Text = "Account Name";
            this.gNameLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(791, 462);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(188, 26);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.acNo,
            this.name,
            this.amount1,
            this.amount2,
            this.groupName});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridView1.Location = new System.Drawing.Point(30, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(741, 419);
            this.dataGridView1.TabIndex = 7;
            // 
            // acNo
            // 
            this.acNo.Frozen = true;
            this.acNo.HeaderText = "Account #";
            this.acNo.Name = "acNo";
            // 
            // name
            // 
            this.name.Frozen = true;
            this.name.HeaderText = "Account Name";
            this.name.Name = "name";
            this.name.Width = 200;
            // 
            // amount1
            // 
            this.amount1.Frozen = true;
            this.amount1.HeaderText = "Opening Amount";
            this.amount1.Name = "amount1";
            this.amount1.ReadOnly = true;
            // 
            // amount2
            // 
            this.amount2.Frozen = true;
            this.amount2.HeaderText = "Closing Amount";
            this.amount2.Name = "amount2";
            this.amount2.ReadOnly = true;
            // 
            // groupName
            // 
            this.groupName.Frozen = true;
            this.groupName.HeaderText = "Group Name";
            this.groupName.Name = "groupName";
            this.groupName.ReadOnly = true;
            this.groupName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.groupName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.groupName.Width = 200;
            // 
            // ChartofAccountsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 528);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChartofAccountsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ChartofAccounts";
            this.nodeContextMenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip nodeContextMenu;
        private System.Windows.Forms.ToolStripMenuItem changeNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAccountToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
       
        private System.Windows.Forms.TextBox accountName;
        private System.Windows.Forms.Label gNameLable;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox oAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button addAccountBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount1;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount2;
        private System.Windows.Forms.DataGridViewComboBoxColumn groupName;
    }
}