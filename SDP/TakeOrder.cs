using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP
{
    public partial class TakeOrder : Form
    {
        private Form BackToMenu;
        private DataTable Table;
        private DataTable Table_Temp;
        public TakeOrder(Form parent)
        {
            BackToMenu = parent;
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        private void invoiceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.invoiceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbDataSet);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString();
            Table = Connect.query("SELECT Invoice.Invoice_No, Product.Product_Name, Product_Invoice.Quantity, Product_Invoice.Deposit FROM Product INNER JOIN(Invoice INNER JOIN Product_Invoice ON Invoice.Invoice_No = Product_Invoice.Invoice_No) ON Product.Product_ID = Product_Invoice.Product_ID WHERE(([Invoice].[Pay_Status] = False And[Invoice].[Using_Status] = True));");
            invoiceDataGridView.DataSource = Table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackToMenu.Show();
            Close();
        }

        private void TakeOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            BackToMenu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Table_Temp = Connect.query("SELECT max(Invoice_No) FROM Invoice WHERE (Pay_Status=False AND Using_Status=True);");
            if (Table_Temp.Rows.Count < 1) {MessageBox.Show("No invoice can be generate yet!"); }
            else
            {
                getVar.invoice_no = Table_Temp.Rows[0][0].ToString();
                order_details orderdetails = new order_details();
                orderdetails.Show();
            }
        }

        private void TakeOrder_Load(object sender, EventArgs e)
        {
            Table_Temp = Connect.query("SELECT max(Invoice_No) FROM Invoice WHERE (Pay_Status=False AND Using_Status=True);");
            getVar.invoice_no = Table_Temp.Rows[0][0].ToString();
            label5.Text = DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString();
            label7.Text = "Invoice ID: "+getVar.invoice_no;
            label3.Text = getVar.name;
            Table = Connect.query("SELECT Invoice.Invoice_No, Product.Product_Name, Product_Invoice.Quantity, Product_Invoice.Deposit FROM Product INNER JOIN(Invoice INNER JOIN Product_Invoice ON Invoice.Invoice_No = Product_Invoice.Invoice_No) ON Product.Product_ID = Product_Invoice.Product_ID WHERE(([Invoice].[Pay_Status] = False And[Invoice].[Using_Status] = True));");
            invoiceDataGridView.DataSource = Table;
            
        }

        private void invoiceDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                invoiceDataGridView.DataSource = Table;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
