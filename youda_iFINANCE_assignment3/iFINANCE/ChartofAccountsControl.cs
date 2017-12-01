using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iFINANCE
{
    class ChartofAccountsControl
    {
        private static ChartofAccountsForm _view;     // set the link to the view
        private iFINANCEModel systemModel = new iFINANCEModel();  // set the link to the model

        public void exitBtn_Click(object sender, EventArgs e)
        {
            _view = (ChartofAccountsForm)((Button)sender).FindForm();
            _view.Close();
        }

        public void ChartofAccounts_Load(object sender, EventArgs e)
        {
            _view = (ChartofAccountsForm)sender;
            int row = 0;

            var ComboBoxGridDatabase = new List<Group>();
            var ComboBoxListDatabase = new List<Group>();

            foreach (var group in systemModel.Groups)
            {
                ComboBoxGridDatabase.Add(new Group() { ID = group.ID, name = group.name });
                ComboBoxListDatabase.Add(new Group() { ID = group.ID, name = group.name });
            }

            _view.ComboBoxGrid(ComboBoxGridDatabase);
            _view.ComboBoxList(ComboBoxListDatabase);

            foreach (var account in systemModel.MasterAccounts)
            {
                _view.addRow(row, account.ID, account.name, (double)account.openingAmount, (double)account.closingAmount, account.Group.ID);
                row++;

            }
        }

        public void addAccountBtn_Click(object sender, EventArgs e)
        {
            _view = (ChartofAccountsForm)((Button)sender).FindForm();
            int row = _view.Grid().Rows.Count;


            if (!System.Text.RegularExpressions.Regex.IsMatch(_view.Name, "^[a-zA-Z0-9]"))
            {
                _view.showErrorMessage("Invalid group name");
            }

            else
            {
                var parentGroup = systemModel.Groups.Find(Convert.ToInt32(_view.getGroupID()));

                MasterAccount account = new MasterAccount();
                account.name = _view.getMasterAccountName();
                account.openingAmount = _view.openingAmount;
                account.closingAmount = 0;
                account.Group = parentGroup;


                systemModel.MasterAccounts.Add(account);
                systemModel.SaveChanges();


                _view.addRow(row, account.ID, account.name, (double)account.openingAmount, (double)account.closingAmount, parentGroup.ID);

            }
        }


        public void removeAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _view = (ChartofAccountsForm)((ContextMenuStrip)(((ToolStripMenuItem)sender).Owner)).SourceControl.FindForm();
            DataGridViewSelectedRowCollection theRow = _view.Grid().SelectedRows;

            int count = theRow.Count;

            if (count == 0)
            {
                _view.showErrorMessage("No rows selected");
            }
            else
            {
                var theAccount = systemModel.MasterAccounts.Find(Convert.ToInt32(theRow[0].Cells["acNo"].Value));
                systemModel.MasterAccounts.Remove(theAccount);
                systemModel.SaveChanges();

                _view.removeRow(theRow);
            }
        }
        public void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView currentColumn = (DataGridView)sender;
            _view = (ChartofAccountsForm)((DataGridView)sender).FindForm();

            int ID = Convert.ToInt32(_view.Grid()[0, e.RowIndex].Value);
            String updated = _view.Grid()[e.ColumnIndex, e.RowIndex].Value.ToString();
            var account = systemModel.MasterAccounts.Find(ID);
            account.name = updated;
            systemModel.SaveChanges();
        }

        public void changNameItem_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection theRow = _view.Grid().SelectedRows;
            int count = theRow.Count;

            if (count == 0)
            {
                _view.showErrorMessage("No rows selected");
            }
            else
            {
                _view = (ChartofAccountsForm)((ContextMenuStrip)(((ToolStripMenuItem)sender).Owner)).SourceControl.FindForm();
                _view.Grid().CurrentCell = theRow[0].Cells["name"];
                _view.Grid().BeginEdit(true);
            }

        }

        public void addItem_Click(object sender, EventArgs e)
        {
            _view = (ChartofAccountsForm)((ContextMenuStrip)(((ToolStripMenuItem)sender).Owner)).SourceControl.FindForm();
            _view.setFocusAdd();
        }
    }
}

