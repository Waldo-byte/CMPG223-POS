﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CMPG223_POS
{
    public partial class SignUp : Form
    {

        static string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\Waldo-byte\CMPG223-POS\CMPG223-POS\CMPG223-POS\Route96.mdf;Integrated Security=True";
        SqlConnection conn = new SqlConnection(constr);
        SqlCommand comm;
        SqlDataAdapter adap;
        DataSet ds;
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignUp_MouseEnter(object sender, EventArgs e)
        {
            btnSignUp.FlatAppearance.BorderColor = Color.FromArgb(50, 225, 120);
            btnSignUp.BackColor = Color.FromArgb(229, 251, 241);
            btnSignUp.ForeColor = Color.FromArgb(7, 75, 30);
        }

        private void btnSignUp_MouseLeave(object sender, EventArgs e)
        {
            btnSignUp.FlatAppearance.BorderColor = Color.FromArgb(175, 175, 175);
            btnSignUp.FlatAppearance.BorderSize = 1;
            btnSignUp.BackColor = Color.FromArgb(225, 225, 225);
            btnSignUp.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void btnCancel_MouseEnter(object sender, EventArgs e)
        {
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(225, 120, 50);
            btnCancel.BackColor = Color.FromArgb(229, 251, 241);
            btnCancel.ForeColor = Color.FromArgb(7, 75, 30);
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(175, 175, 175);
            btnCancel.FlatAppearance.BorderSize = 1;
            btnCancel.BackColor = Color.FromArgb(225, 225, 225);
            btnCancel.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string sql = @"INSERT INTO ClienTable (LastName, FirstName,PhoneNumber) VALUES('" + txtSurname.Text + "' , '" + txtName.Text + "' , '" + txtPhoneNumber.Text + "'";
            comm = new SqlCommand(sql, conn);
            adap = new SqlDataAdapter();
            ds = new DataSet();

            adap.SelectCommand = comm;
            adap.Fill(ds);
        }
    }
}
