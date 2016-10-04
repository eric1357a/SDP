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
    public partial class Menu : Form
    {
        private Form BackToLogin;
        public Menu(Form parent)
        {
            BackToLogin = parent;
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString();
            label5.Text = getVar.name;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            BackToLogin.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddItem addnewitem = new AddItem(this);
            addnewitem.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModifyItem modifyitem = new ModifyItem(this);
            modifyitem.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchItem searchitem = new SearchItem(this);
            searchitem.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TakeOrder takeorder = new TakeOrder(this);
            takeorder.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Genreport gen = new Genreport(this);
            gen.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Genreport order = new Genreport(this);
            order.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
