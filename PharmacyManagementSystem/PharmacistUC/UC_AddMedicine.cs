using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;

namespace PharmacyManagementSystem.PharmacistUC
{
    public partial class UC_AddMedicine : UserControl
    {

        function fn = new function();
        String query;
        public UC_AddMedicine()
        {
            InitializeComponent();
        }

        private void btnAddMdcn_Click(object sender, EventArgs e)
        {

            if ( txtMedId.Text!="" && txtMedName.Text!="" && txtMedNo.Text!="" && txtQuantity.Text!="" && txtPricePU.Text!="")
            {
                String mid = txtMedId.Text;
                String mname = txtMedName.Text;
                String mnumber = txtMedNo.Text;
                String mDate = txtMFG.Text;
                String eDate = txtExp.Text;
                Int64 quantity = Int64.Parse(txtQuantity.Text);
                Int64 perUnit = Int64.Parse(txtPricePU.Text);

                query = " insert into medic (mid, mname, mnumber, mDate, eDate, quantity, perUnit) values ( '" + mid + "', '" + mname + "', '" + mnumber + "', '" + mDate + "', '" + eDate + "', " + quantity + ", " + perUnit + ") ";
                fn.setData(query, "Medcine Added ✅");
            }
            else
            {
                MessageBox.Show("All fields are required!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMedId.Clear();
            txtMedName.Clear();
            txtMedNo.Clear();
            txtMFG.ResetText();
            txtExp.ResetText();
            txtQuantity.Clear();
            txtPricePU.Clear();
        }
    }
}
