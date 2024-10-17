using System;
using System.Collections;
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
    public partial class UC_Dashboard : UserControl
    {
        function fn = new function();
        String query;
        DataSet medic;
        Int64 count;

        public UC_Dashboard()
        {
            InitializeComponent();
        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {
            loadChart();
        }

        public void loadChart()
        {
            query = " select count(mname) from medic where eDate > getDate() ";
            medic = fn.getData(query);
            count = Int64.Parse(medic.Tables[0].Rows[0][0].ToString());
            this.chart1.Series["Valid Medicines"].Points.AddXY("Medicine Validity Chart", count);

            query = " select count(mname) from medic where eDate <= getDate() ";
            medic = fn.getData(query);
            count = Int64.Parse(medic.Tables[0].Rows[0][0].ToString());
            this.chart1.Series["Expired Medicines"].Points.AddXY("Medicine Validity Chart", count);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            this.chart1.Series["Valid Medicines"].Points.Clear();
            this.chart1.Series["Expired Medicines"].Points.Clear();
            loadChart();
        }

        private void btbReload_Click(object sender, EventArgs e)
        {
            UC_Dashboard_Load(this, null);
        }
    }
}