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
    public partial class Modify_detail : Form
    {
        String PID;

        public Modify_detail()
        {
            InitializeComponent();
            this.product_PriceTextBox.KeyPress += new KeyPressEventHandler(product_PriceTextBox_KeyPress);
        }
        public Modify_detail(String id)
        {
            InitializeComponent();
            this.PID = id;

        }

        private void Modify_detail_Load(object sender, EventArgs e)
        {
            DataTable Table;
            Table = Connect.query("SELECT Product.Product_ID, Product.Product_Name, Product.Product_Price, Product.Discounts, Stock.Category_ID, Stock.Quantity, Stock.Reordering_level, Stock.Shelf_location, Stock.Description, Stock.Dimension from Product left join Stock on Product.Product_ID = Stock.Product_ID WHERE Product.Product_ID =" + Int32.Parse(PID) + " AND Deleted = False;");
            product_IDTextBox.Text = Table.Rows[0]["Product_ID"].ToString();
            dimensionTextBox.Text = Table.Rows[0]["Dimension"].ToString();
            reordering_levelTextBox.Text = Table.Rows[0]["Reordering_level"].ToString();
            product_NameTextBox.Text = Table.Rows[0]["Product_Name"].ToString();
            discountsTextBox.Text = Table.Rows[0]["Discounts"].ToString();
            product_PriceTextBox.Text = Table.Rows[0]["Product_Price"].ToString();
            shelf_locationTextBox.Text = Table.Rows[0]["Shelf_location"].ToString();
            quantity_textbox.Text = Table.Rows[0]["Quantity"].ToString();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Are you sure you want to delete this item?",
            "Warning",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);
            if (result1 == DialogResult.Yes)
            {
                Connect.exec("UPDATE Product SET Deleted=True WHERE Product.Product_ID = " + product_IDTextBox.Text + ";");
                Close();
            }
        }

        private void confirm_button_Click(object sender, EventArgs e)
        {
            Connect.exec("UPDATE Product SET Product_Name='" + product_NameTextBox.Text + "' ,Discounts= '" + discountsTextBox.Text + "',Product_Price= '" + product_PriceTextBox.Text + "' WHERE Product_ID = " + product_IDTextBox.Text + ";");
            Connect.exec("UPDATE Stock SET Quantity='" +quantity_textbox.Text+ "',Reordering_level= '" + reordering_levelTextBox.Text + "',Shelf_location = '"+shelf_locationTextBox.Text+"',Description= '"+ descriptionRichTextBox.Text +"',Dimension= '"+dimensionTextBox.Text+"' WHERE Product_ID = " +product_IDTextBox.Text + ";");
            MessageBox.Show("Update Success!");
        }

        private void product_PriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == 8);
        }
    }
}
