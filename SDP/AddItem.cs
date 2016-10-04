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
    public partial class AddItem : Form
    {
        private DataTable Table;
        private Form BackToMenu;
        public AddItem(Form parent)
        {
            BackToMenu = parent;
            InitializeComponent();
            this.price.KeyPress += new KeyPressEventHandler(price_KeyPress);
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbDataSet1.Sub_Category' table. You can move, or remove it, as needed.
            this.sub_CategoryTableAdapter.Fill(this.dbDataSet1.Sub_Category);
            // TODO: This line of code loads data into the 'dbDataSet1.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.dbDataSet1.Category);
            time.Text = DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString();
            Table = Connect.query("SELECT max(Product_ID)+1 from Product WHERE Deleted = False;");
            product_id.Text = Table.Rows[0][0].ToString();
            label3.Text = getVar.name;
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            BackToMenu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BackToMenu.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Product_name.Text == "" || price.Text == "" || dimension.Text == "" || reorderinglevel.Text == "" || shelf_loc.Text == "" ||
                discount_tb.Text == "" || quantity.Text == "" || category.Text == "" || description.Text == "" || subCategory.Text == "") { MessageBox.Show("Please input all field!"); }
            else
            {
                String catID = "";
                Table = Connect.query("SELECT Category_ID from Category WHERE Category_Name = '" + category.Text + "'");
                catID = Table.Rows[0][0].ToString();
                Connect.exec("INSERT INTO Product( Product_ID, Product_Name,Product_Price,Discounts ) VALUES ('" + product_id.Text + "','" + Product_name.Text + "','" + price.Text + "','" + discount_tb.Text + "')");
                Connect.exec("INSERT INTO Stock(Product_ID, Category_ID,Quantity,Reordering_level,Shelf_location,Description,Dimension) VALUES ('" + product_id.Text + "','" + catID + "','" + quantity.Text + "', '" + reorderinglevel.Text + "','" + shelf_loc.Text + "', '" + description.Text + "', '" + dimension.Text + "')");  
                MessageBox.Show("Add successful");
                Product_name.Text = "";
                price.Text = "";
                dimension.Text = "";
                reorderinglevel.Text = "";
                shelf_loc.Text = "";
                discount_tb.Text = "";
                quantity.Text = "";
                description.Text = "";
                Table = Connect.query("SELECT max(Product_ID)+1 from Product WHERE Deleted = False;");
                product_id.Text = Table.Rows[0][0].ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Product_name.Text = "";
            price.Text = "";
            dimension.Text = "";
            reorderinglevel.Text = "";
            shelf_loc.Text = "";
            discount_tb.Text = "";
            quantity.Text = "";
            description.Text = "";
        }

        private void category_FontChanged(object sender, EventArgs e)
        {

        }

        private void category_Leave()
        {
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            
        }

        private void price_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == 8);
        }
    }
}
