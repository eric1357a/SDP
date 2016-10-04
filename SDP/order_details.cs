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
    public partial class order_details : Form
    {
        private DataTable Table;
        public order_details()
        {
            InitializeComponent();
        }


        private void order_details_Load(object sender, EventArgs e)
        {

            Table = Connect.query("SELECT Sum(Product_Invoice.Deposit) FROM Invoice INNER JOIN Product_Invoice ON Invoice.Invoice_No = Product_Invoice.Invoice_No WHERE Invoice.Invoice_No = "+getVar.invoice_no+";");
            total_textbox.Text = Table.Rows[0][0].ToString();
          
            invoice_id.Text = getVar.invoice_no;
            PayControl.TabPages[0].Text = "Credit Card";
            PayControl.TabPages[1].Text = "Cash";
            change_textbox.Text = "0";
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (((customer_name_textbox.Text != "") && customer_phoneno_textbox.Text != ""))
            {
                Connect.exec("UPDATE Invoice SET Invoice_Date = Now() WHERE Invoice_No = " + getVar.invoice_no + ";");
                Connect.exec("UPDATE Invoice SET Customer_ID = '1' WHERE Invoice_No = " + getVar.invoice_no + ";");
                Connect.exec("UPDATE Invoice SET Customer_Name = '" + customer_name_textbox.Text + "' WHERE Invoice_No = " + getVar.invoice_no + ";");
                Connect.exec("UPDATE Invoice SET Total_amount = " + total_textbox.Text + " WHERE Invoice_No = " + getVar.invoice_no + ";");

                Connect.exec("UPDATE Invoice SET Cus_Phoneno = '" + customer_phoneno_textbox.Text + "' WHERE Invoice_No = " + getVar.invoice_no + ";");

                Connect.exec("UPDATE Invoice SET Pay_Status = True WHERE Invoice_No = " + getVar.invoice_no + ";");

                paystatus.Text = "Contacting to the card company";
                progressBar1.Value = 50;
                await Task.Delay(2000);
                paystatus.Text = "Payment complete";
                progressBar1.Value = 100;
                Invoice report = new Invoice();
                report.Show();
            }
            else {MessageBox.Show("Please fill in all the information!");}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void receive_textbox_TextChanged(object sender, EventArgs e)
        {
            if (receive_textbox.Text != "" && (Int32.Parse(receive_textbox.Text) > Int32.Parse(total_textbox.Text)))
                change_textbox.Text = (Int32.Parse(receive_textbox.Text) - Int32.Parse(total_textbox.Text)).ToString();
            else change_textbox.Text = "0";
        }
    }
}
