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
    public partial class Form1 : Form
    {
        function fn = new function();
        String query;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pswrdinput_TextChanged(object sender, EventArgs e)
        {

        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            usrnameinput.Clear();
            pswrdinput.Clear();
        }

        private void signinbtn_Click(object sender, EventArgs e)
        {
            query = "select * from users";
            ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count == 0) {
                if (usrnameinput.Text == "admin" && pswrdinput.Text == "admin") { 
                    Admin admn = new Admin(usrnameinput.Text);
                    admn.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Use default cridentials", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                query = "select * from users where username = '"+usrnameinput.Text+"' and pass = '"+pswrdinput.Text+"'";
                ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    String role = ds.Tables[0].Rows[0][1].ToString();
                    if (role == "Admin")
                    {
                        Admin admn = new Admin(usrnameinput.Text);
                        admn.Show();
                        this.Hide();
                    }
                    else if (role == "Pharmacist")
                    {
                        Pharmacist pharma = new Pharmacist();
                        pharma.Show();
                        this.Hide();
                    }
                    //MessageBox.Show("'"+usrnameinput.Text+"' and '"+pswrdinput.Text+"' and '"+role+"' ");
                }
                else
                {
                    MessageBox.Show("Invalid Cridentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
