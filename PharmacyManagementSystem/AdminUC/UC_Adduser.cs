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
        public UC_Adduser()
        {
            InitializeComponent();
        }

        private void resetbtn_Click_1(object sender, EventArgs e)
        {
            role.SelectedIndex = -1;
            naame.Clear();
            dob.ResetText();
            mobile.Clear();
            email.Clear();
            usrname.Clear();
            pswrd.Clear();
        }
    }
}
