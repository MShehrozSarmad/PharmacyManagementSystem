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
    public partial class UC_Dashboard : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
        public UC_Dashboard()
        {
            InitializeComponent();
        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {
            query = " select count(userRole) from users where userRole='Admin' ";
            ds = fn.getData(query);
            setLable(ds, adminLbl);

            query = " select count(userRole) from users where userRole='Pharmacist' ";
            ds = fn.getData(query);
            setLable(ds, pharmaLbl);
        }

        private void setLable(DataSet ds, Label lbl)
        {
            if (ds.Tables[0].Rows.Count != 0)
            {
                lbl.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                lbl.Text = "0";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            UC_Dashboard_Load(this, null);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
