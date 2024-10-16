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
    public partial class Pharmacist : Form
    {
        public Pharmacist()
        {
            InitializeComponent();
        }

        private void Pharmacist_Load(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible = false;
            uC_AddMedicine1.Visible = false;
            uC_ViewMedicines1.Visible = false;
            uC_ModifyMed1.Visible = false;
            uC_SellMedicines1.Visible = false;
            btnDshbrd.PerformClick();
        }

        private void btnDshbrd_Click(object sender, EventArgs e)
        {
            uC_AddMedicine1.Visible = false;
            uC_ViewMedicines1.Visible = false;
            uC_ModifyMed1.Visible = false;
            uC_SellMedicines1.Visible = false;
            uC_Dashboard1.Visible = true;
            uC_Dashboard1.BringToFront();
        }

        private void btnAddMdcn_Click(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible = false;
            uC_ViewMedicines1.Visible = false;
            uC_ModifyMed1.Visible = false;
            uC_SellMedicines1.Visible = false;
            uC_AddMedicine1.Visible = true;
            uC_AddMedicine1.BringToFront();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 signin = new Form1();
            signin.Show();
            this.Hide();
        }

        private void btnViewMdcn_Click(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible = false;
            uC_AddMedicine1.Visible = false;
            uC_ModifyMed1.Visible = false;
            uC_ViewMedicines1.Visible = true;
            uC_SellMedicines1.Visible = false;
            uC_ViewMedicines1.BringToFront();
        }

        private void btnMdfMdcn_Click(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible = false;
            uC_AddMedicine1.Visible = false;
            uC_ViewMedicines1.Visible = false;
            uC_SellMedicines1.Visible = false;
            uC_ModifyMed1.Visible = true;
            uC_ModifyMed1.BringToFront();
        }

        private void btnSellMdcn_Click(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible = false;
            uC_AddMedicine1.Visible = false;
            uC_ViewMedicines1.Visible = false;
            uC_ModifyMed1.Visible = false;
            uC_SellMedicines1.Visible = true;
            uC_SellMedicines1.BringToFront();
        }
    }
}
