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
    public partial class StockForm : Form
    {
        public StockForm()
        {
            InitializeComponent();
        }
        MyMessageBox mbox = new MyMessageBox();
        public void buttonStyle(Control source)
        {
            foreach (Control con in source.Controls)
            {
                if (con is Button)
                {
                    Button but = con as Button;
                    but.BackColor = Color.FromArgb(225, 225, 225);
                    but.FlatAppearance.BorderColor = Color.FromArgb(175, 175, 175);
                    but.MouseEnter += new EventHandler(this.allButton_mouseEnter);
                    but.MouseLeave += new EventHandler(this.allButton_mouseLeave);
                    but.FlatStyle = FlatStyle.Flat;
                    //but.Margin = new Padding(3, 3, 3, 0);
                    but.Size = new Size((buttonContainer.Width - 36) / 5, buttonContainer.Height - 12);
                }
                else
                {
                    buttonStyle(con);
                }
            }
        }

        private void allButton_mouseEnter(object sender, System.EventArgs e)
        {
            Button but = (Button)sender;
            but.FlatAppearance.MouseOverBackColor = Color.FromArgb(229, 251, 241);
            but.FlatAppearance.BorderColor = Color.FromArgb(50, 225, 120);
        }

        private void allButton_mouseLeave(object sender, System.EventArgs e)
        {
            Button but = (Button)sender;
            but.FlatAppearance.BorderColor = Color.FromArgb(175, 175, 175);

        }

        public int admin;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtItemID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("E");
            }
            else if (Convert.ToInt32(numUpDownStock.Value) == 0)
            {
                MessageBox.Show("E");
            }
            else
            {
                funcClass f1 = new funcClass();
                f1.updateStock(int.Parse(txtItemID.Text),Convert.ToInt32(numUpDownStock.Value));
                //f1.populateBought();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtItemID.Text.Trim() == string.Empty)
                {
                    mbox.ShowMessageBox("Please Enter a valid ID to delete", "Field filled error", "", "Error");
                    mbox.ShowDialog();
                }
                else if (Convert.ToInt32(txtItemID.Text) <= 0)
                {
                    mbox.ShowMessageBox("ID must be an integer value more than 0.", "Invalid Input", "", "Error");
                    mbox.ShowDialog();
                }
                else
                {
                    funcClass f1 = new funcClass();
                    f1.removeStock(int.Parse(txtItemID.Text));
                    f1.populateBought();
                    mbox.ShowMessageBox("Stock successfully deleted.", "Sucess!", "", "");
                    mbox.ShowDialog();
                    txtDescription.Text = "";
                    txtItemID.Text = "";
                    txtStockPrice.Text = "";
                    numUpDownStock.Value = 0;
                }
            }
            catch (Exception)
            {
                mbox.ShowMessageBox("Please enter an integer value for ID", "Invalid Input", "", "Error");
                mbox.ShowDialog();
            }
            
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try 
            {
                if (txtItemID.Text.Trim() == string.Empty)
                {
                    mbox.ShowMessageBox("Please ensure all text fields are filled", "Field filled error", "", "Error");
                    mbox.ShowDialog();
                }
                else if (Convert.ToInt32(txtItemID.Text) <= 0)
                {
                    mbox.ShowMessageBox("ID must be an integer value more than 0.", "Invalid Input", "", "Error");
                    mbox.ShowDialog();
                }
                else if (txtDescription.Text.Trim() == string.Empty || txtStockPrice.Text.Trim() == string.Empty)
                {
                    mbox.ShowMessageBox("Please ensure all text fields are filled", "Field filled error", "", "Error");
                    mbox.ShowDialog();
                }
                else if (Convert.ToInt32(txtStockPrice.Text) <= 0)
                {
                    mbox.ShowMessageBox("Price must be more than 0.", "Invalid Input", "", "Error");
                    mbox.ShowDialog();
                }
                else if (Convert.ToInt32(numUpDownStock.Value) == 0)
                {
                    mbox.ShowMessageBox("Amount value cannot be 0.", "Invalid Input", "", "Error");
                    mbox.ShowDialog();
                }
                else
                {
                    funcClass f1 = new funcClass();
                    f1.addStock(int.Parse(txtItemID.Text), txtDescription.Text, double.Parse(txtStockPrice.Text), Convert.ToInt32(numUpDownStock.Value));
                    f1.populateBought();
                    mbox.ShowMessageBox("Stock successfully added.", "Sucess!", "", "");
                    mbox.ShowDialog();
                    txtDescription.Text = "";
                    txtItemID.Text = "";
                    txtStockPrice.Text = "";
                    numUpDownStock.Value = 0;
                }
            }
            catch (Exception)
            {
                mbox.ShowMessageBox("Please enter an integer value for ID and Price", "Invalid Input", "", "Error");
                mbox.ShowDialog();
            }
            
        }

        private void StockForm_Load(object sender, EventArgs e)
        {
            funcClass f1 = new funcClass();
            f1.populateStock();
            buttonStyle(this);
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            funcClass f1 = new funcClass();
            f1.backupdb();
        }

        private void btn_Restore_Click(object sender, EventArgs e)
        {
            funcClass f1 = new funcClass();
            f1.restoredb();
        }
    }
}
