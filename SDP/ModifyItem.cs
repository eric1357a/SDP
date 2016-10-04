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
    public partial class ModifyItem : Form
    {
        private Form BackToMenu;
        private DataTable Table;
        public ModifyItem(Form parent)
        {
            BackToMenu = parent;
            InitializeComponent();
            this.product_IDTextBox.KeyPress += new KeyPressEventHandler(product_IDTextBox_KeyPress);
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        public ModifyItem()
        {
            // TODO: Complete member initialization
        }

        private void product_CategoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.product_CategoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString();
            Table = Connect.query("SELECT Product.Product_ID AS [Product ID], Product.Product_Name AS [Product Name], Product.Product_Price, Product.Discounts, Category.Category_Name AS Category, Stock.Quantity, Stock.Reordering_level, Stock.Shelf_location, Stock.Description, Stock.Dimension from(Product left join Stock on Product.Product_ID = Stock.Product_ID) left join Category on Stock.Category_ID = Category.Category_ID WHERE Deleted = False;");
            product_CategoryDataGridView.DataSource = Table;
            label3.Text = getVar.name;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BackToMenu.Show();
            Close();
        }

        private void product_CategoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                
                product_CategoryDataGridView.DataSource = Table;

            }
            else
            {
                product_CategoryDataGridView.Rows[e.RowIndex].Selected = true;
                String id = product_CategoryDataGridView.SelectedCells[0].Value.ToString();
                Modify_detail detail = new Modify_detail(id);
                detail.Show();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ModifyItem_FormClosed(object sender, FormClosedEventArgs e)
        {
            BackToMenu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (product_IDTextBox.Text == "") {

                Table = Connect.query("SELECT Product.Product_ID, Product.Product_Name, Product.Product_Price, Product.Discounts, Category.Category_Name AS Category, Stock.Quantity, Stock.Reordering_level, Stock.Shelf_location, Stock.Description, Stock.Dimension from(Product left join Stock on Product.Product_ID = Stock.Product_ID) left join Category on Stock.Category_ID = Category.Category_ID WHERE Category.Category_Name ='" + comboBox1.Text + "'AND Deleted = False;"); }
        else {
      
                Table = Connect.query("SELECT Product.Product_ID, Product.Product_Name, Product.Product_Price, Product.Discounts, Category.Category_Name AS Category, Stock.Quantity, Stock.Reordering_level, Stock.Shelf_location, Stock.Description, Stock.Dimension from(Product left join Stock on Product.Product_ID = Stock.Product_ID) left join Category on Stock.Category_ID = Category.Category_ID WHERE Product.Product_ID =" + product_IDTextBox.Text + "AND Deleted = False;");
            }
            product_CategoryDataGridView.DataSource = Table;
        }

        private void ModifyItem_Activated(object sender, EventArgs e)
        {
            Table = Connect.query("SELECT Product.Product_ID, Product.Product_Name, Product.Product_Price, Product.Discounts, Category.Category_Name AS Category, Stock.Quantity, Stock.Reordering_level, Stock.Shelf_location, Stock.Description, Stock.Dimension from(Product left join Stock on Product.Product_ID = Stock.Product_ID) left join Category on Stock.Category_ID = Category.Category_ID WHERE Deleted = False;");

            product_CategoryDataGridView.DataSource = Table;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void product_IDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == 8);
        }
    }
}
