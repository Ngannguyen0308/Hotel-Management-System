﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "vnuk" && txtPassword.Text == "123")
            {
                labelError.Visible = false;
                Dashboard ds = new Dashboard();
                this.Hide();
                ds.Show();
            }
            else
            {
                labelError.Visible = true;
                txtPassword.Clear();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void labelError_Click(object sender, EventArgs e)
        {
            Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}