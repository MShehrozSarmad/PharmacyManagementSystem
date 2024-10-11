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
    public partial class UC_Adduser : UserControl
    {
        function fn = new function();
        String query;
        public UC_Adduser()
        {
            InitializeComponent();
        }

        private void resetbtn_Click_1(object sender, EventArgs e)
        {
            txtRole.SelectedIndex = -1;
            txtName.Clear();
            txtDob.ResetText();
            txtMobile.Clear();
            txtEmail.Clear();
            txtUsrname.Clear();
            txtPswrd.Clear();
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            String role = txtRole.Text;
            String name = txtName.Text;
            String dob = txtDob.Text;
            Int64 mobile = Int64.Parse(txtMobile.Text);
            String email = txtEmail.Text;
            String username = txtUsrname.Text;
            String pass = txtPswrd.Text;

            try
            {
                query = "insert into users (userRole, name, dob, mobile, email, username, pass) values ('"+role+"', '"+name+"', '"+dob+"', "+mobile+", '"+email+"', '"+username+"', '"+pass+"')";
                fn.setData(query, "Sign up successfull");
            }
            catch (Exception)
            {
                MessageBox.Show("User already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
