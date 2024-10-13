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
    public partial class UC_ViewUser : UserControl
    {
        function fn = new function();
        String query;
        String username;
        String currentUser = "";

        public UC_ViewUser()
        {
            InitializeComponent();
        }

        public string ID
        {
            set { currentUser = value; }
        }

        private void UC_ViewUser_Load(object sender, EventArgs e)
        {
            query = " select * from users ";
            DataSet users = fn.getData(query);
            guna2DataGridView1.DataSource = users.Tables[0];
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = " select * from users where username like '" + txtSearch.Text + "%' ";
            DataSet users = fn.getData(query);
            guna2DataGridView1.DataSource = users.Tables[0];
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UC_ViewUser_Load(this, null);
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                username = guna2DataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            
            } catch
            {

            }
        }

        private void btnDlt_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this profile?", "Delete Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if(currentUser != username)
                {
                    query = "delete from users where username = '" + username + "'";
                    fn.setData(query, "USer record deleted!");
                    UC_ViewUser_Load(this, null);
                }
                else
                {
                    MessageBox.Show("You are trying to delete\n your own profile!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
