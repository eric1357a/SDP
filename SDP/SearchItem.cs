using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP
{
    public partial class SearchItem : Form
    {
        private Form BackToMenu;
        private DataTable Table;
        private DataTable Table_Temp;
        String oprice = "";
        public SearchItem(Form parent)
        {
            BackToMenu = parent;
            InitializeComponent();
            this.orderqty_textbox.KeyPress += new KeyPressEventHandler(orderqty_textbox_KeyPress);
            timer1.Enabled = true;
            timer1.Interval = 100;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label13.Text = DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString();
            Table = Connect.query("SELECT Product.Product_ID AS [Product ID], Product.Product_Name AS [Product Name], Product.Product_Price AS [Price], Product.Discounts AS [Discount], Stock.Category_ID AS [Category], Stock.Quantity AS [Quantity], Stock.Reordering_level AS [Reordering level], Stock.Shelf_location AS [Shelf Location], Stock.Description, Stock.Dimension from Product left join Stock on Product.Product_ID = Stock.Product_ID WHERE Deleted = False;");
            dataGridView1.DataSource = Table;
            label3.Text = getVar.name;


            //this.productTableAdapter.Fill(this.dbDataSet.Product);


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label13.Text = DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString();

        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbDataSet);

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            BackToMenu.Show();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.product_CategoryTableAdapter.FillBy(this.dbDataSet.Product_Category);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            { dataGridView1.DataSource = Table; }
            else
            {
                if (e.RowIndex < Table.Rows.Count)
                {
                    product_IDTextBox.Text = Table.Rows[e.RowIndex]["Product ID"].ToString();
                    dimensionTextBox.Text = Table.Rows[e.RowIndex]["Dimension"].ToString();
                    reordering_levelTextBox.Text = Table.Rows[e.RowIndex]["Reordering level"].ToString();
                    product_NameTextBox.Text = Table.Rows[e.RowIndex]["Product Name"].ToString();
                    discountsTextBox.Text = Table.Rows[e.RowIndex]["Discount"].ToString();
                    product_PriceTextBox.Text = Table.Rows[e.RowIndex]["Price"].ToString();
                    shelf_locationTextBox.Text = Table.Rows[e.RowIndex]["Shelf location"].ToString();
                    quantity_textbox.Text = Table.Rows[e.RowIndex]["Quantity"].ToString();
                    descriptionRichTextBox.Text = Table.Rows[e.RowIndex]["Description"].ToString();
                    if(Int32.Parse(discountsTextBox.Text) != 0)
                    product_PriceTextBox.Text = (Int32.Parse(product_PriceTextBox.Text) * Int32.Parse(discountsTextBox.Text) / 100).ToString();
                    oprice = product_PriceTextBox.Text.ToString();

                }
                else product_IDTextBox.Text = "";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                dataGridView1.DataSource = Table;
                
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (orderqty_textbox.Text != "" && quantity_textbox.Text != "" && (Int32.Parse(quantity_textbox.Text) >= Int32.Parse(orderqty_textbox.Text)))
            {
                Table_Temp = Connect.query("SELECT max(Invoice_No) FROM Invoice WHERE (Pay_Status=False AND Using_Status=True);");
                getVar.invoice_no = Table_Temp.Rows[0][0].ToString();
                Table_Temp = Connect.query("SELECT max(Invoice_No)+1 FROM Invoice WHERE (Pay_Status=True AND Using_Status=True);");
                string old_invoice_no = Table_Temp.Rows[0][0].ToString();
                if (getVar.invoice_no == "" && old_invoice_no == "")
                {
                    getVar.invoice_no = "1";
                    quantity_textbox.Text = (Int32.Parse(quantity_textbox.Text) - Int32.Parse(orderqty_textbox.Text)).ToString();
                  
                    Connect.exec("INSERT INTO Invoice(Invoice_No,Store_ID,Using_Status) VALUES ('" + getVar.invoice_no.ToString() + "','" + getVar.storeID.ToString() + "',True)");
                  
                    Connect.exec("INSERT INTO Product_Invoice( Invoice_No,Product_ID,Quantity,Deposit ) VALUES ('" + getVar.invoice_no.ToString() + "','" + product_IDTextBox.Text + "','" + orderqty_textbox.Text + "','" + product_PriceTextBox.Text + "')");
              
                    Connect.exec("UPDATE Stock SET Quantity='" + quantity_textbox.Text + "' WHERE Product_ID = " + product_IDTextBox.Text + ";");
                    MessageBox.Show("Add order complete!");
                }
                else if ((old_invoice_no.ToString() == "") && (getVar.invoice_no == "1"))
                {
                    quantity_textbox.Text = (Int32.Parse(quantity_textbox.Text) - Int32.Parse(orderqty_textbox.Text)).ToString();
             
                    Table_Temp = Connect.query("SELECT Quantity FROM Product_Invoice WHERE (Invoice_No = " + getVar.invoice_no.ToString() + " AND Product_ID= " + product_IDTextBox.Text + ");");
                    if (!(Table_Temp.Rows.Count == 0))
                    {
                        int temp = Int32.Parse(Table_Temp.Rows[0][0].ToString()) + Int32.Parse(orderqty_textbox.Value.ToString());


       
                        Connect.exec("UPDATE Product_invoice SET Quantity='" + temp + "' WHERE Product_ID = " + product_IDTextBox.Text + ";");

                        Connect.exec("UPDATE Stock SET Quantity='" + quantity_textbox.Text + "' WHERE Product_ID = " + product_IDTextBox.Text + ";");
                        MessageBox.Show("Add order complete!");
                    }
                    else
                    { //duplocate

                        Connect.exec("INSERT INTO Product_invoice(Quantity,Product_ID,Invoice_No,Deposit) VALUES('" + orderqty_textbox.Value.ToString() + "','" + product_IDTextBox.Text + "','" + getVar.invoice_no.ToString() + "','" + product_PriceTextBox.Text + "')");

                        Connect.exec("UPDATE Stock SET Quantity='" + quantity_textbox.Text + "' WHERE Product_ID = " + product_IDTextBox.Text + ";");
                        MessageBox.Show("Add order complete!");
                    }
                }

                else if ((getVar.invoice_no != "") && (old_invoice_no.ToString() != ""))
                {
                    Table_Temp = Connect.query("SELECT Quantity FROM Product_Invoice WHERE (Invoice_No = " + getVar.invoice_no.ToString() + " AND Product_ID= " + product_IDTextBox.Text + ");");
                    if (!(Table_Temp.Rows.Count == 0))
                    {
                        int temp = Int32.Parse(Table_Temp.Rows[0][0].ToString()) + Int32.Parse(orderqty_textbox.Value.ToString());



                        Connect.exec("UPDATE Product_invoice SET Quantity='" + temp + "' WHERE Product_ID = " + product_IDTextBox.Text + ";");

                        Connect.exec("UPDATE Stock SET Quantity='" + quantity_textbox.Text + "' WHERE Product_ID = " + product_IDTextBox.Text + ";");
                        MessageBox.Show("Add order complete!");
                    }
                    else
                    { 

                        Connect.exec("INSERT INTO Product_invoice(Quantity,Product_ID,Invoice_No,Deposit) VALUES('" + orderqty_textbox.Value.ToString() + "','" + product_IDTextBox.Text + "','" + old_invoice_no.ToString() + "','" + product_PriceTextBox.Text + "')");

                        Connect.exec("UPDATE Stock SET Quantity='" + quantity_textbox.Text + "' WHERE Product_ID = " + product_IDTextBox.Text + ";");
                        MessageBox.Show("Add order complete!");
                    }



                }
                else { 
            
     
                    Connect.exec("INSERT INTO Invoice(Invoice_No,Store_ID,Using_Status) VALUES ('" + old_invoice_no + "','" + getVar.storeID.ToString() + "',True)");
         
                    Connect.exec("INSERT INTO Product_Invoice( Product_ID,Quantity,Deposit,Invoice_No ) VALUES ('" + product_IDTextBox.Text + "','" + orderqty_textbox.Text + "','" + product_PriceTextBox.Text + "','" + old_invoice_no.ToString() + "')");
 
                    Connect.exec("UPDATE Stock SET Quantity='" + quantity_textbox.Text + "' WHERE Product_ID = " + product_IDTextBox.Text + ";");
                    Table_Temp = Connect.query("SELECT Quantity FROM Product_Invoice WHERE (Invoice_No = " + old_invoice_no.ToString() + " AND Product_ID= " + product_IDTextBox.Text + ");");
                    int temp = Int32.Parse(Table_Temp.Rows[0][0].ToString()) + Int32.Parse(orderqty_textbox.Value.ToString());
     
                    Connect.exec("UPDATE Product_invoice SET Quantity='" + temp + "' WHERE Product_ID = " + product_IDTextBox.Text + ";");
                    MessageBox.Show("Add order complete!");
                }
                    
                


            }
            else if ((Int32.Parse(orderqty_textbox.Text) < 0)) { MessageBox.Show("Please input postive number!"); }
            else if (quantity_textbox.Text.ToString() == "") { MessageBox.Show("Please select item"); }
            else if ((Int32.Parse(quantity_textbox.Text) < Int32.Parse(orderqty_textbox.Text))) { MessageBox.Show("Not enough stock!"); }
            Table = Connect.query("SELECT Product.Product_ID AS [Product ID], Product.Product_Name AS [Product Name], Product.Product_Price AS [Price], Product.Discounts AS [Discount], Stock.Category_ID AS [Category], Stock.Quantity AS [Quantity], Stock.Reordering_level AS [Reordering level], Stock.Shelf_location AS [Shelf Location], Stock.Description, Stock.Dimension from Product left join Stock on Product.Product_ID = Stock.Product_ID WHERE Deleted = False;");
            dataGridView1.DataSource = Table;
        }

        private void orderqty_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == 8);
        }

  

        private void orderqty_textbox_ValueChanged(object sender, EventArgs e)
        {
            if (quantity_textbox.Text.ToString() == "") { MessageBox.Show("Please select item first");}
            else
            product_PriceTextBox.Text = (Int32.Parse(oprice) * orderqty_textbox.Value).ToString();
        }

        private void product_CategoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
