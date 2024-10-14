using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PharmacyManagementSystem.PharmacistUC
{
    public partial class UC_ModifyMed : UserControl
    {
        function fn = new function();
        String query;
        public UC_ModifyMed()
        {
            InitializeComponent();
        }

        private void UC_ModifyMed_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(txtMedId.Text != "")
            {
                query = " select * from medic where mid = '"+txtMedId.Text+"' ";
                DataSet med = fn.getData(query);
                if (med.Tables[0].Rows.Count != 0)
                {
                    txtMedName.Text = med.Tables[0].Rows[0][2].ToString();
                    txtMedNo.Text = med.Tables[0].Rows[0][3].ToString();
                    txtMFG.Text = med.Tables[0].Rows[0][4].ToString();
                    txtExp.Text = med.Tables[0].Rows[0][5].ToString();
                    txtQuantity.Text = med.Tables[0].Rows[0][6].ToString();
                    txtPricePU.Text = med.Tables[0].Rows[0][7].ToString();
                }
                else
                {
                    MessageBox.Show("No medicine with the id: '" + txtMedId.Text + "' exist. ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                clearAll();
            }
        }

        private void clearAll()
        {
            txtMedName.Clear();
            txtMedNo.Clear();
            txtMFG.ResetText();
            txtExp.ResetText();
            txtQuantity.Text = "";
            txtPricePU.Clear();
            txtAddQnt.Text = "0";
            //if(txtAddQnt.Text != "0")
            //{
            //    txtAddQnt.Text = "0";
            //}
            //else
            //{
            //    txtAddQnt.Text = "0";
            //}

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnAddMdcn_Click(object sender, EventArgs e)
        {
            if (txtMedId.Text != "")
            {
                try
                {
                    String mid = txtMedId.Text;
                    String mname = txtMedName.Text;
                    String mnumber = txtMedNo.Text;
                    String mDate = txtMFG.Text;
                    String eDate = txtExp.Text;
                    Int64 quantity = Int64.Parse(txtQuantity.Text);
                    Int64 addQuant = Int64.Parse(txtAddQnt.Text);
                    Int64 perUnit = Int64.Parse(txtPricePU.Text);

                    Int64 ttlQnt = quantity + addQuant;

                    query = " update medic set mname = '" + mname + "', mnumber = '" + mnumber + "', mDate = '" + mDate + "', eDate = '" + eDate + "', quantity = " + ttlQnt + ", perUnit = " + perUnit + " where mid = '" + mid + "'";
                    fn.setData(query, "Medicine details updated");
                }
                catch
                {
                    MessageBox.Show("Sorry, Something went wrong", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No medicine selcted for update", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
