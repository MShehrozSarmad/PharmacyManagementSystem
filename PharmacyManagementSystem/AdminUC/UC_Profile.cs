using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem.AdminUC
{
    public partial class UC_Profile : UserControl
    {
        function fn = new function();
        String query;

        public UC_Profile()
        {
            InitializeComponent();
        }

        public string ID
        {
            set { lblUsername.Text = value; }
        }

        private void UC_Profile_Load(object sender, EventArgs e)
        {

        }

        private void UC_Profile_Enter(object sender, EventArgs e)
        {
            query = " select * from users where username = '" + lblUsername.Text + "' ";
            DataSet user = fn.getData(query);
            txtRole.Text = user.Tables[0].Rows[0][1].ToString();
            txtName.Text = user.Tables[0].Rows[0][2].ToString();
            txtDob.Text = user.Tables[0].Rows[0][3].ToString();
            txtMobile.Text = user.Tables[0].Rows[0][4].ToString();
            txtEmail.Text = user.Tables[0].Rows[0][5].ToString();
            txtPswrd.Text = user.Tables[0].Rows[0][7].ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            UC_Profile_Enter(this, null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String role = txtRole.Text;
            String name = txtName.Text;
            String dob = txtDob.Text ;
            String mobile = txtMobile.Text ;
            String email = txtEmail.Text ;
            String username = lblUsername.Text ;
            String pass = txtPswrd.Text ;

            query = " update users set userRole='" + role + "', name = '" + name + "', dob='" + dob + "', mobile=" + mobile + ", email='" + email + "', username='" + username + "', pass='" + pass + "' where username = '"+username+"' ";
            fn.setData(query, "Profile Update ✅");
        }
    }
}
