using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;



namespace SDP
{
    public partial class LoginP : Form
    {
        public bool Login = false;
        public bool Staff = false;
        public LoginP()
        {
            InitializeComponent();
            Connect.init();
            timer1.Enabled = true;
            timer1.Interval = 1000;
            Login = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
             string sqlStr = "";
	         Login = false;
	
	if (txtUsername.Text.Length == 0 ||
			txtPassword.Text.Length == 0) {
		MessageBox.Show("Missing username or password. "
					+ "Please try again.");
		txtUsername.Clear();
		txtPassword.Clear();
	}
	else {
		try {
            DataTable dt = Connect.query("Select * from Staff WHERE Staff_ID = '"+txtUsername.Text+"' AND Password = '"+txtPassword.Text+"'");
			
                if (dt.Rows.Count > 0) {
                    if (dt.Rows[0]["Staff"].ToString().Equals("True"))
                    {
                        Staff = true;
                        Login = true;
                        getVar.name = "Login As:"+dt.Rows[0]["LastName"].ToString()+" "+dt.Rows[0]["FirstName"].ToString();
                            getVar.storeID = dt.Rows[0]["Store_ID"].ToString();
                    }
                    else
                    {
                        Staff = false;
                        Login = true;
                        getVar.name = "Login As:" + dt.Rows[0]["FirstName"].ToString();
                            getVar.storeID = dt.Rows[0]["Store_ID"].ToString();
                        }
                }
                else
                {
                    MessageBox.Show("Incorrect user name or password. "
                        + "Please try again.");
                    txtUsername.Clear();
                    txtPassword.Clear();
                }
			if (Login)
                if (Staff)
                {
                    Menu staffmenu = new Menu(this);
                    staffmenu.Show();
                    this.Hide();
                    txtUsername.Clear();
                    txtPassword.Clear();
                }
                else if(!Staff){
                    SearchItem nonstaffmenu = new SearchItem(this);
                    nonstaffmenu.Show();
                    this.Hide();
                    txtUsername.Clear();
                    txtPassword.Clear();
                }
		}
		catch (Exception ex) {
			 MessageBox.Show(ex.Message + "\nSQL: " + sqlStr);
		}
	}

}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void LoginP_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        }
    }

