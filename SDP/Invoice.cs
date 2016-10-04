using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace SDP
{
    public partial class Invoice : Form
    {
        private bool BrowserDIdLoad = false;
        private DataTable Table;
        string path = "";
        int i = 0;
        public Invoice()
        {
          
            InitializeComponent();

        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            DirectoryInfo di = new 
            DirectoryInfo(Assembly.GetExecutingAssembly().ToString());
            path = di.Parent.FullName;
            Uri uri = new Uri(Path.Combine(path,"Invoice.html"));
            wb.Navigate(uri.ToString());
            
        }

        private void wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (BrowserDIdLoad) return;
            BrowserDIdLoad = true;
            Table = Connect.query("SELECT Product_Invoice.Invoice_No, Invoice.Customer_Name, Invoice.Invoice_Date, Store.Location, Store.Phone_number, Product_Invoice.Product_ID, Product.Product_Name, Product.Product_Price, Product_Invoice.Quantity, Product_Invoice.Deposit, Invoice.Total_amount FROM(Store INNER JOIN Staff ON Store.Store_ID = Staff.Store_ID) INNER JOIN(Invoice INNER JOIN (Product INNER JOIN Product_Invoice ON Product.Product_ID = Product_Invoice.Product_ID) ON Invoice.Invoice_No = Product_Invoice.Invoice_No) ON Store.Store_ID = Invoice.Store_ID WHERE (((Product_Invoice.Invoice_No)=1));");
            for ( i = 0; i != Table.Rows.Count; i++)
            {
                string location = Table.Rows[i]["Location"].ToString();
                string telephone = Table.Rows[i]["Phone_number"].ToString();
                string invoiceno = Table.Rows[i]["Invoice_no"].ToString();
                string customername = Table.Rows[i]["Customer_Name"].ToString();
                string date = Table.Rows[i]["Invoice_Date"].ToString();
                string productid = Table.Rows[i]["Product_ID"].ToString();
                string productname = Table.Rows[i]["Product_Name"].ToString();
                string oneprice = Table.Rows[i]["Deposit"].ToString();
                string qty = Table.Rows[i]["Quantity"].ToString();
                string price = Table.Rows[i]["Product_price"].ToString();
                string total = Table.Rows[i]["Total_amount"].ToString();
            
            
                
                    wb.Document.Body.InnerHtml = wb.Document.Body.InnerHtml.Replace("./", path);
                    wb.Document.Body.InnerHtml = wb.Document.Body.InnerHtml.Replace("[INVOICENO]", invoiceno);
                    wb.Document.Body.InnerHtml = wb.Document.Body.InnerHtml.Replace("[LOCATION]", location);
                    wb.Document.Body.InnerHtml = wb.Document.Body.InnerHtml.Replace("[TELEPHONE]", telephone);
                    wb.Document.Body.InnerHtml = wb.Document.Body.InnerHtml.Replace("[INVOICENO]", invoiceno);
                    wb.Document.Body.InnerHtml = wb.Document.Body.InnerHtml.Replace("[CUSTOMERNAME]", customername);
                    wb.Document.Body.InnerHtml = wb.Document.Body.InnerHtml.Replace("[DATE]", date);
                    wb.Document.Body.InnerHtml = wb.Document.Body.InnerHtml.Replace("[PRODUCTID" + i + "]", productid);
                    wb.Document.Body.InnerHtml = wb.Document.Body.InnerHtml.Replace("[PRODUCTNAME" + i + "]", productname);
                    wb.Document.Body.InnerHtml = wb.Document.Body.InnerHtml.Replace("[ONEPRICE" + i + "]", oneprice);
                    wb.Document.Body.InnerHtml = wb.Document.Body.InnerHtml.Replace("[QUANTITY" + i + "]", qty);
                    wb.Document.Body.InnerHtml = wb.Document.Body.InnerHtml.Replace("[PRICE" + i + "]", price);
                    wb.Document.Body.InnerHtml = wb.Document.Body.InnerHtml.Replace("[TOTAL]", total);

                if (Table.Rows.Count < 4)
                {
                    for (int o = Table.Rows.Count; o != 4; o++)
                    {
                        wb.Document.Body.InnerHtml = wb.Document.Body.InnerHtml.Replace("[PRODUCTID" + o + "]", "");
                        wb.Document.Body.InnerHtml = wb.Document.Body.InnerHtml.Replace("[PRODUCTNAME" + o + "]", "");
                        wb.Document.Body.InnerHtml = wb.Document.Body.InnerHtml.Replace("[ONEPRICE" + o + "]", "");
                        wb.Document.Body.InnerHtml = wb.Document.Body.InnerHtml.Replace("[QUANTITY" + o + "]", "");
                        wb.Document.Body.InnerHtml = wb.Document.Body.InnerHtml.Replace("[PRICE" + o + "]", "");
                    }
            
                } }
        }
    }
}
