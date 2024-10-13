using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class Admin : Form
    {

        String user = "";
        public Admin()
        {
            InitializeComponent();
        }

        public string ID
        {
            get { return user.ToString(); }
        }

        public Admin(String username)
        {
            InitializeComponent();
            lblUsrname.Text = username;
            user = username;
            uC_ViewUser1.ID = ID;
            uC_Profile1.ID = ID;
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible = false;
            uC_Adduser1.Visible = false;
            uC_ViewUser1.Visible = false;
            uC_Profile1.Visible = false;
            dshbrdBtn.PerformClick();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            uC_ViewUser1.Visible = true;
            uC_ViewUser1.BringToFront();
        }

        private void lgoutBtn_Click(object sender, EventArgs e)
        {
            Form1 signin = new Form1();
            signin.Show();
            this.Hide();
        }

        private void dshbrdBtn_Click(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible = true;
            uC_Dashboard1.BringToFront();
        }

        private void uC_Dashboard1_Load(object sender, EventArgs e)
        {

        }

        private void addUsrBtn_Click(object sender, EventArgs e)
        {
            uC_Adduser1.Visible = true;
            uC_Adduser1.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void prflBtn_Click(object sender, EventArgs e)
        {
            uC_Profile1.Visible = true;
            uC_Profile1.BringToFront();
        }
    }
}
