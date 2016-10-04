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
    public partial class Genreport : Form
    {
        private Form BackToMenu;
        private DataTable Table;
        public Genreport(Form parent)
        {
            BackToMenu = parent;
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        private void product_CategoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.product_CategoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbDataSet);

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString();
        }

        private void reorder_checkToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.product_CategoryTableAdapter.reorder_check(this.dbDataSet.Product_Category);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void Genreport_FormClosed(object sender, FormClosedEventArgs e)
        {
            BackToMenu.Show();
        }

        private void Genreport_Load(object sender, EventArgs e)
        {
            // TODO:  這行程式碼會將資料載入 'dbDataSet1.Category' 資料表。您可以視需要進行移動或移除。
            label5.Text = DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString();
            label3.Text = getVar.name;
            Table = Connect.query("SELECT Product.Product_ID AS ID, Product.Product_Name AS[Product Name], Stock.Quantity, Stock.Reordering_level - Stock.Quantity AS NEED FROM Product INNER JOIN Stock ON Product.Product_ID = Stock.Product_ID WHERE(((Stock.Reordering_level) >[Stock].[Quantity]) AND((Product.Deleted) = False)) ORDER BY Product.Product_ID;");
            product_CategoryDataGridView.DataSource = Table;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reoderreport reorder = new reoderreport();
            reorder.Show();
        }
    }
}
