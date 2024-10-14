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
    public partial class UC_ViewMedicines : UserControl
    {
        function fn = new function();
        String query;
        String MediID;
        public UC_ViewMedicines()
        {
            InitializeComponent();
        }

        private void UC_ViewMedicines_Load(object sender, EventArgs e)
        {
            query = " select * from medic ";
            setDataGridView(query);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = " select * from medic where mname like '" + txtSearch.Text + "%' ";
            setDataGridView(query);

        }

        private void setDataGridView( String query )
        {
            DataSet medic = fn.getData(query);
            guna2DataGridView1.DataSource = medic.Tables[0];
        }

        private void btbReload_Click(object sender, EventArgs e)
        {
            UC_ViewMedicines_Load(this, null);
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MediID = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Something went wrong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDlt_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Medicine?", "Delete Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = " delete from medic where mid = '" + MediID + "' ";
                fn.setData(query, "Medicine Deleted ✅");
                UC_ViewMedicines_Load(this, null);
            }
        }
    }
}
