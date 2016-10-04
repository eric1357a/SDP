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
    public partial class reoderreport : Form
    {
        private bool BrowserDIdLoad = false;
        private DataTable Table;
        string path = "";
        int i = 0;
        public reoderreport()
        {

            InitializeComponent();

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (BrowserDIdLoad) return;
            BrowserDIdLoad = true;
            Table = Connect.query("SELECT Store.Location, Store.Phone_number FROM Store WHERE(Store.Store_ID) = "+getVar.storeID+"; ");
            string location = Table.Rows[i]["Location"].ToString();
            string telephone = Table.Rows[i]["Phone_number"].ToString();
            wb.Document.Body.InnerHtml = wb.Document.Body.InnerHtml.Replace("[LOCATION]", location);
            wb.Document.Body.InnerHtml = wb.Document.Body.InnerHtml.Replace("[TELEPHONE]", telephone);
            Table = Connect.query("SELECT NOW() AS [DATE]; ");
            string date = Table.Rows[i]["DATE"].ToString();
            wb.Document.Body.InnerHtml = wb.Document.Body.InnerHtml.Replace("[DATE]", date);
            Table = Connect.query("SELECT Product.Product_ID AS ID, Product.Product_Name AS[Product Name], Stock.Quantity, Stock.Reordering_level - Stock.Quantity AS NEED FROM Product INNER JOIN Stock ON Product.Product_ID = Stock.Product_ID WHERE(((Stock.Reordering_level) >[Stock].[Quantity]) AND((Product.Deleted) = False)) ORDER BY Product.Product_ID;");
            for (i = 0; i != Table.Rows.Count; i++)
            {
                

                string productid = Table.Rows[i]["ID"].ToString();
                string productname = Table.Rows[i]["Product Name"].ToString();
                string qty = Table.Rows[i]["Quantity"].ToString();
                string total = Table.Rows[i]["NEED"].ToString();

                wb.Document.Body.InnerHtml = wb.Document.Body.InnerHtml.Replace("./", path);
                wb.Document.Body.InnerHtml = wb.Document.Body.InnerHtml.Replace("[PRODUCTID" + i + "]", productid);
                wb.Document.Body.InnerHtml = wb.Document.Body.InnerHtml.Replace("[PRODUCTNAME" + i + "]", productname);
                wb.Document.Body.InnerHtml = wb.Document.Body.InnerHtml.Replace("[QTY" + i + "]", qty);
                wb.Document.Body.InnerHtml = wb.Document.Body.InnerHtml.Replace("[NEED"+ i + "]", total);

                if (Table.Rows.Count < 4)
                {
                    for (int o = Table.Rows.Count; o != 4; o++)
                    {
                        wb.Document.Body.InnerHtml = wb.Document.Body.InnerHtml.Replace("[PRODUCTID" + o + "]", "");
                        wb.Document.Body.InnerHtml = wb.Document.Body.InnerHtml.Replace("[PRODUCTNAME" + o + "]", "");
                        wb.Document.Body.InnerHtml = wb.Document.Body.InnerHtml.Replace("[QTY" + o + "]", "");
                        wb.Document.Body.InnerHtml = wb.Document.Body.InnerHtml.Replace("[NEED" + o + "]", "");
                    }

                }
            }
        }

        private void reoderreport_Load(object sender, EventArgs e)
        {
            DirectoryInfo di = new
           DirectoryInfo(Assembly.GetExecutingAssembly().ToString());
            path = di.Parent.FullName;
            Uri uri = new Uri(Path.Combine(path, "report.html"));
            wb.Navigate(uri.ToString());
        }
    }
}
