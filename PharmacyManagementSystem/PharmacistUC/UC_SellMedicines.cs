using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem.PharmacistUC
{
    public partial class UC_SellMedicines : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;

        public UC_SellMedicines()
        {
            InitializeComponent();
        }

        private void UC_SellMedicines_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                query = " select mname from medic where eDate > getdate() and quantity > '0' ";
                ds = fn.getData(query);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void btbReload_Click(object sender, EventArgs e)
        {
            UC_SellMedicines_Load(this, null);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                query = " select mname from medic where mname like '" + txtSearch.Text + "%' and eDate > getdate() and quantity > '0'";
                ds = fn.getData(query);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNoOfUnts.Clear();
            txtPTotalPrc.Text = "";
            
            string mname = listBox1.GetItemText(listBox1.SelectedItem);

            try
            {
                query = " select mid, eDate, perUnit from medic where mname = '"+mname+"'";
                ds = fn.getData(query);
                txtMedName.Text = mname;
                txtMedId.Text = ds.Tables[0].Rows[0][0].ToString();
                txtExp.Text = ds.Tables[0].Rows[0][1].ToString();
                txtUnitPrc.Text = ds.Tables[0].Rows[0][2].ToString();
            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }

        }

        private void txtNoOfUnts_TextChanged(object sender, EventArgs e)
        {
            bill();
        }

        private void txtUnitPrc_TextChanged(object sender, EventArgs e)
        {
            bill();
        }
        private void bill()
        {
            txtPTotalPrc.Text = "";
            if (txtNoOfUnts.Text != "" && txtUnitPrc.Text !="")
            {
                Int64 unitPrice = Int64.Parse(txtUnitPrc.Text);
                Int64 noOfUnits = Int64.Parse(txtNoOfUnts.Text);
                Int64 totalPrice = unitPrice * noOfUnits;
                txtPTotalPrc.Text = totalPrice.ToString();
            }
        }

        protected int n, totalAmount = 0 ;
        protected Int64 quantity, newQuantity;
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if(txtMedId.Text != "")
            {
                try
                {
                    query = " select quantity from medic where mid='"+txtMedId.Text+"'";
                    ds = fn.getData(query);
                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("No data found.");
                    }
                }
                catch
                {
                    MessageBox.Show("Error fetching data");
                }
                quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                 newQuantity = quantity - Int64.Parse(txtNoOfUnts.Text);

                if (newQuantity >= 0)
                {
                    n = guna2DataGridView1.Rows.Add();
                    guna2DataGridView1.Rows[n].Cells[0].Value = txtMedId.Text;
                    guna2DataGridView1.Rows[n].Cells[1].Value = txtMedName.Text;
                    guna2DataGridView1.Rows[n].Cells[2].Value = txtExp.Text;
                    guna2DataGridView1.Rows[n].Cells[3].Value = txtUnitPrc.Text;
                    guna2DataGridView1.Rows[n].Cells[4].Value = txtNoOfUnts.Text;
                    guna2DataGridView1.Rows[n].Cells[5].Value = txtPTotalPrc.Text;

                    totalAmount = totalAmount + int.Parse(txtPTotalPrc.Text);
                    lblBill.Text = totalAmount.ToString();

                    try
                    {
                        query = " update medic set quantity = '" + newQuantity + "' where mid = '" + txtMedId.Text + "' ";
                        fn.setData(query, "Added to Cart");
                    }
                    catch
                    {
                        MessageBox.Show("Something went wrong while updating database");
                    }
                }
                else
                {
                    MessageBox.Show("Medicine is out of stock. \nOnly '" + quantity + "' left!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                clearAll();
                UC_SellMedicines_Load(this, null);
            }
            else
            {
                MessageBox.Show("Please select medicine");
            }
        }
        private void clearAll()
        {
            txtMedId.Text = "";
            txtMedName.Text = "";
            txtPTotalPrc.Text = "";
            txtExp.ResetText();
            txtNoOfUnts.Clear();
            txtUnitPrc.Clear();
        }

        int valueAmount;
        String valueID;

        protected Int64 noOfUnits;

        private void txtNoOfUnts_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the key pressed is a digit (0-9) or a control key (like backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // If the key is not a digit or a control key, cancel the event (disallow the input)
                e.Handled = true;
            }
        }

        private void txtUnitPrc_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the key pressed is a digit (0-9) or a control key (like backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // If the key is not a digit or a control key, cancel the event (disallow the input)
                e.Handled = true;
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valueAmount = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                valueID = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                noOfUnits = Int64.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(valueID != null)
            {
                try
                {
                    guna2DataGridView1.Rows.RemoveAt(this.guna2DataGridView1.SelectedRows[0].Index);
                }
                catch
                {
                    MessageBox.Show("Something went wrong");
                }
                finally
                {
                    query = " select quantity from medic where mid='" + valueID + "'";
                    ds = fn.getData(query);
                    quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

                    newQuantity = quantity + noOfUnits;

                    query = " update medic set quantity = '" + newQuantity + "' where mid = '" + valueID + "'";
                    fn.setData(query, "Medicine removed from cart.");
                    totalAmount = totalAmount - valueAmount;
                    lblBill.Text = totalAmount.ToString();
                }
                UC_SellMedicines_Load(this, null);
            }
            else
            {
                MessageBox.Show("Select the medicine from cart to remove");
            }
        }


        private void btnPurchase_Click(object sender, EventArgs e)
        {
            DGVPrinter print = new DGVPrinter();
            print.Title = "Medicine Bill";
            print.SubTitle = String.Format("Date: {0}", DateTime.Now.Date);
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "Total Papable Amount: " + lblBill.Text + "PKR";
            print.FooterSpacing = 15;
            print.PrintDataGridView(guna2DataGridView1);

            totalAmount = 0;
            lblBill.Text = "00";
            guna2DataGridView1.DataSource = 0;
        }
    }
}
