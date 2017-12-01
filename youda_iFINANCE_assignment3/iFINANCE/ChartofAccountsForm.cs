using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iFINANCE
{
    public partial class ChartofAccountsForm : Form
    {
        ChartofAccountsControl accountsControl; // set the link to the control
        public ChartofAccountsForm()
        {
            InitializeComponent();

            accountsControl = new ChartofAccountsControl();
            this.Load += new System.EventHandler(accountsControl.ChartofAccounts_Load);
            this.exitBtn.Click += new System.EventHandler(accountsControl.exitBtn_Click);
            this.addAccountBtn.Click += new System.EventHandler(accountsControl.addAccountBtn_Click);
            this.removeAccountToolStripMenuItem.Click += new System.EventHandler(accountsControl.removeAccountToolStripMenuItem_Click);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(accountsControl.dataGridView1_CellEndEdit);
            this.changeNameToolStripMenuItem.Click += new System.EventHandler(accountsControl.changNameItem_Click);
            this.addAccountToolStripMenuItem.Click += new System.EventHandler(accountsControl.addItem_Click);

        }
        public double openingAmount
        {
            get
            {
                return double.Parse(this.oAmount.Text);
            }
            set
            {
                this.oAmount.Text = value.ToString();
            }
        }

        public DataGridView Grid()
        {
            return this.dataGridView1;
        }

        public int getGroupID()
        {
            return Convert.ToInt32(comboBox1.SelectedValue.ToString());
        }

        private void setContextMenu(DataGridView dataGrid)
        {
            foreach (DataGridView tn in dataGrid.Rows)
            {
                tn.ContextMenuStrip = this.nodeContextMenu;
                setContextMenu(tn);
            }
        }

        public void addRow(int row, int ID, String Name, double oAmount, double cAmount, int id)
        {
            if (dataGridView1.Rows.Count == 0) row = 0;
            
            dataGridView1.Rows.Add(ID.ToString(), Name, oAmount.ToString(), cAmount.ToString());
            DataGridViewComboBoxCell groupCell = (DataGridViewComboBoxCell)(this.dataGridView1.Rows[row].Cells["groupName"]);
            groupCell.Value = id;
            dataGridView1.Rows[row].ContextMenuStrip = nodeContextMenu;
        }
        public String getMasterAccountName()
        {
            return this.accountName.Text;
        }
       

        public void removeRow(DataGridViewSelectedRowCollection row)
        {
            dataGridView1.Rows.RemoveAt(row[0].Index);
        }

        public void showErrorMessage(String msg)
        {
            MessageBox.Show(msg, "Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ComboBoxGrid(List<Group> data){
            this.groupName.ValueMember = "ID";
            this.groupName.DisplayMember = "name";
            this.groupName.DataSource = data;
        }
        public void ComboBoxList(List<Group> data)
        {
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "name";
            comboBox1.DataSource = data;
        }
        public void setFocusAdd()
        {
            this.accountName.Focus();
        }
    }
}
