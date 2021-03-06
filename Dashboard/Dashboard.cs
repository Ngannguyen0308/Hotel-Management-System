using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_Employee1.Visible = false;
            uC_Addroom1.Visible = false;
            uC_CustomerRegistration1.Visible = false;
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uC_Addroom1.Visible = true;
            uC_Addroom1.BringToFront();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            uC_CustomerRegistration1.Visible=true;
            uC_CustomerRegistration1.BringToFront();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            uC_CustomerCheckOut1.Visible=true;
            uC_CustomerCheckOut1.BringToFront();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnCustomerDetails_Click(object sender, EventArgs e)
        {
            custumerDetails1.Visible = true;
            custumerDetails1.BringToFront();

        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            uC_Employee1.Visible = true;
            uC_Employee1.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            uC_Employee1.Visible = false;
            uC_Addroom1.Visible = false;
            uC_CustomerRegistration1.Visible = false;
        }
    }
}
