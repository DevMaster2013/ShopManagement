using ShopWinApplication.Data;
using ShopWinApplication.Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopWinApplication.Forms.Customers
{
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
            OpenForms.AddOpenedForm(this);
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            customerBindingSource.DataSource = DBManagement.GetDB().Customers.ToList();
            if (customerBindingSource.List.Count <= 0)
            {
                dtGridCustomers.Visible = false;
                lblError.Visible = true;
            }
            else
            {
                dtGridCustomers.Visible = true;
                lblError.Visible = false;
            }
        }

        private void linkAddNewCustomer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddCustomer frm = new frmAddCustomer();
            frm.Show();
        }

        private void frmCustomers_FormClosed(object sender, FormClosedEventArgs e)
        {
            OpenForms.RemoveForm(this);
        }

        private void dtGridCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn && e.RowIndex >= 0)
            {                
                if (senderGrid.Columns[e.ColumnIndex].Name == "Edit")
                {
                    HandleEditButton(e.RowIndex);
                }
                else if (senderGrid.Columns[e.ColumnIndex].Name == "Details")
                {
                    HandleDetailsButton(e.RowIndex);
                }
                else if (senderGrid.Columns[e.ColumnIndex].Name == "Delete")
                {
                    HandleDeleteButton(e.RowIndex);
                }
            }
        }

        private void HandleEditButton(int rowIndex)
        {
            Customer cust = customerBindingSource.List[rowIndex] as Customer;
            frmEditCustomer frm = new frmEditCustomer(cust);
            frm.Show();
        }

        private void HandleDetailsButton(int rowIndex)
        {
            Customer cust = customerBindingSource.List[rowIndex] as Customer;
            frmViewCustomer frm = new frmViewCustomer(cust);
            frm.Show();
        }

        private void HandleDeleteButton(int rowIndex)
        {
            if (MessageManager.YesNoMessage("هل تريد مسح هذا السجل؟"))
            {
                Customer cust = customerBindingSource.List[rowIndex] as Customer;
                DBManagement.GetDB().Customers.Remove(cust);
                if (DBManagement.GetDB().SaveChanges() > 0)
                {
                    MessageManager.SaveDataSuccessMessage("لقد تم مسح البيانات بنجاح");
                    customerBindingSource.DataSource = DBManagement.GetDB().Customers.ToList();
                }
                else
                    MessageManager.SaveDataFailureMessage("لم يتم مسح البانات");
            }
        }
    }
}
