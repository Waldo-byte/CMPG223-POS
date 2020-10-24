﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPG223_POS
{
    public partial class WaiterAddForm : Form
    {
        public WaiterAddForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string pass = txtPassword.Text;
            string confirm_pass = txtConfirmPassword.Text;
            if (1==1)
            {
                if (txtConfirmPassword.Text != txtPassword.Text)
                {
                    MessageBox.Show("E");
                }
                else
                {
                    if(chkboxadmin.Checked)
                    {
                        try
                        {
                            funcClass f1 = new funcClass();
                            f1.addWaiter(pass, DateTime.Now.TimeOfDay, name, txtSurname.Text, true);
                            MessageBox.Show("Added");
                        }
                        catch(Exception es)
                        {
                            MessageBox.Show(es.Message);
                        }
                    }
                    else
                    {
                        try
                        {
                            funcClass f1 = new funcClass();
                            f1.addWaiter(txtPassword.Text, DateTime.Now.TimeOfDay, txtName.Text, txtSurname.Text, false);
                            MessageBox.Show("Added");
                        }
                        catch (Exception es)
                        {
                            MessageBox.Show(es.Message);
                        }
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("E");
            }
            
        }
    }
}
