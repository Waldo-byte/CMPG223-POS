﻿namespace CMPG223_POS
{
    partial class Orders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            this.panelTitle = new System.Windows.Forms.Panel();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.lbClientID = new System.Windows.Forms.Label();
            this.lbOrders = new System.Windows.Forms.ListBox();
            this.panelDrinks = new System.Windows.Forms.Panel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBackDrinks = new System.Windows.Forms.Button();
            this.btnClearPreviousItemDrinks = new System.Windows.Forms.Button();
            this.panelFood = new System.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBackFood = new System.Windows.Forms.Button();
            this.btnClearPreviousItemFood = new System.Windows.Forms.Button();
            this.btnBeefBurger = new System.Windows.Forms.Button();
            this.btnChickenBurger = new System.Windows.Forms.Button();
            this.btnCheeseBurger = new System.Windows.Forms.Button();
            this.btnChickenSnitzel = new System.Windows.Forms.Button();
            this.btnSmallChips = new System.Windows.Forms.Button();
            this.btnMediumChips = new System.Windows.Forms.Button();
            this.btnLargeChips = new System.Windows.Forms.Button();
            this.btnRegularWings = new System.Windows.Forms.Button();
            this.btnMildWings = new System.Windows.Forms.Button();
            this.btnHotWings = new System.Windows.Forms.Button();
            this.btnSwartkatLager = new System.Windows.Forms.Button();
            this.btnAfricaPilsner = new System.Windows.Forms.Button();
            this.btnWeisbeer = new System.Windows.Forms.Button();
            this.btnRedAle = new System.Windows.Forms.Button();
            this.btnGRTAle = new System.Windows.Forms.Button();
            this.btnStout = new System.Windows.Forms.Button();
            this.btnCraftGin = new System.Windows.Forms.Button();
            this.btnRum = new System.Windows.Forms.Button();
            this.panelOderHome = new System.Windows.Forms.Panel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.btnConfirmOrder = new System.Windows.Forms.Button();
            this.btnPayOrder = new System.Windows.Forms.Button();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.btnDrinks = new System.Windows.Forms.Button();
            this.btnFood = new System.Windows.Forms.Button();
            this.panelTitle.SuspendLayout();
            this.panelDrinks.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panelFood.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelOderHome.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.panelCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(24)))), ((int)(((byte)(22)))));
            this.panelTitle.Controls.Add(this.txtClientID);
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Controls.Add(this.lbClientID);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1184, 32);
            this.panelTitle.TabIndex = 0;
            // 
            // txtClientID
            // 
            this.txtClientID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(102)))), ((int)(((byte)(41)))));
            this.txtClientID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClientID.Location = new System.Drawing.Point(309, 6);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(167, 20);
            this.txtClientID.TabIndex = 5;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(102)))), ((int)(((byte)(41)))));
            this.labelTitle.Location = new System.Drawing.Point(3, 4);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(77, 25);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Orders";
            // 
            // lbClientID
            // 
            this.lbClientID.AutoSize = true;
            this.lbClientID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(102)))), ((int)(((byte)(41)))));
            this.lbClientID.Location = new System.Drawing.Point(229, 9);
            this.lbClientID.Name = "lbClientID";
            this.lbClientID.Size = new System.Drawing.Size(50, 13);
            this.lbClientID.TabIndex = 4;
            this.lbClientID.Text = "Client ID:";
            // 
            // lbOrders
            // 
            this.lbOrders.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbOrders.FormattingEnabled = true;
            this.lbOrders.Location = new System.Drawing.Point(928, 32);
            this.lbOrders.Name = "lbOrders";
            this.lbOrders.Size = new System.Drawing.Size(256, 671);
            this.lbOrders.TabIndex = 1;
            // 
            // panelDrinks
            // 
            this.panelDrinks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDrinks.Controls.Add(this.flowLayoutPanel4);
            this.panelDrinks.Controls.Add(this.flowLayoutPanel2);
            this.panelDrinks.Location = new System.Drawing.Point(8, 180);
            this.panelDrinks.Name = "panelDrinks";
            this.panelDrinks.Size = new System.Drawing.Size(446, 511);
            this.panelDrinks.TabIndex = 3;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel4.Controls.Add(this.btnSwartkatLager);
            this.flowLayoutPanel4.Controls.Add(this.btnAfricaPilsner);
            this.flowLayoutPanel4.Controls.Add(this.btnWeisbeer);
            this.flowLayoutPanel4.Controls.Add(this.btnRedAle);
            this.flowLayoutPanel4.Controls.Add(this.btnGRTAle);
            this.flowLayoutPanel4.Controls.Add(this.btnStout);
            this.flowLayoutPanel4.Controls.Add(this.btnCraftGin);
            this.flowLayoutPanel4.Controls.Add(this.btnRum);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(200, 0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(246, 511);
            this.flowLayoutPanel4.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.btnBackDrinks);
            this.flowLayoutPanel2.Controls.Add(this.btnClearPreviousItemDrinks);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(200, 511);
            this.flowLayoutPanel2.TabIndex = 1;
            this.flowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // btnBackDrinks
            // 
            this.btnBackDrinks.Location = new System.Drawing.Point(1, 1);
            this.btnBackDrinks.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.btnBackDrinks.Name = "btnBackDrinks";
            this.btnBackDrinks.Size = new System.Drawing.Size(198, 40);
            this.btnBackDrinks.TabIndex = 0;
            this.btnBackDrinks.Text = "Back";
            this.btnBackDrinks.UseVisualStyleBackColor = true;
            this.btnBackDrinks.Click += new System.EventHandler(this.btnBackDrinks_Click);
            // 
            // btnClearPreviousItemDrinks
            // 
            this.btnClearPreviousItemDrinks.Location = new System.Drawing.Point(1, 42);
            this.btnClearPreviousItemDrinks.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.btnClearPreviousItemDrinks.Name = "btnClearPreviousItemDrinks";
            this.btnClearPreviousItemDrinks.Size = new System.Drawing.Size(198, 40);
            this.btnClearPreviousItemDrinks.TabIndex = 1;
            this.btnClearPreviousItemDrinks.Text = "Clear Previous Item";
            this.btnClearPreviousItemDrinks.UseVisualStyleBackColor = true;
            this.btnClearPreviousItemDrinks.Click += new System.EventHandler(this.btnClearPreviousItemDrinks_Click);
            // 
            // panelFood
            // 
            this.panelFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFood.Controls.Add(this.flowLayoutPanel3);
            this.panelFood.Controls.Add(this.flowLayoutPanel1);
            this.panelFood.Location = new System.Drawing.Point(460, 179);
            this.panelFood.Name = "panelFood";
            this.panelFood.Size = new System.Drawing.Size(462, 512);
            this.panelFood.TabIndex = 4;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel3.Controls.Add(this.btnBeefBurger);
            this.flowLayoutPanel3.Controls.Add(this.btnChickenBurger);
            this.flowLayoutPanel3.Controls.Add(this.btnCheeseBurger);
            this.flowLayoutPanel3.Controls.Add(this.btnChickenSnitzel);
            this.flowLayoutPanel3.Controls.Add(this.btnSmallChips);
            this.flowLayoutPanel3.Controls.Add(this.btnMediumChips);
            this.flowLayoutPanel3.Controls.Add(this.btnLargeChips);
            this.flowLayoutPanel3.Controls.Add(this.btnRegularWings);
            this.flowLayoutPanel3.Controls.Add(this.btnMildWings);
            this.flowLayoutPanel3.Controls.Add(this.btnHotWings);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(200, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(262, 512);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.btnBackFood);
            this.flowLayoutPanel1.Controls.Add(this.btnClearPreviousItemFood);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 512);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnBackFood
            // 
            this.btnBackFood.Location = new System.Drawing.Point(1, 1);
            this.btnBackFood.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.btnBackFood.Name = "btnBackFood";
            this.btnBackFood.Size = new System.Drawing.Size(198, 40);
            this.btnBackFood.TabIndex = 0;
            this.btnBackFood.Text = "Back";
            this.btnBackFood.UseVisualStyleBackColor = true;
            this.btnBackFood.Click += new System.EventHandler(this.btnBackFood_Click);
            // 
            // btnClearPreviousItemFood
            // 
            this.btnClearPreviousItemFood.Location = new System.Drawing.Point(1, 42);
            this.btnClearPreviousItemFood.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.btnClearPreviousItemFood.Name = "btnClearPreviousItemFood";
            this.btnClearPreviousItemFood.Size = new System.Drawing.Size(198, 40);
            this.btnClearPreviousItemFood.TabIndex = 1;
            this.btnClearPreviousItemFood.Text = "Clear Previous Item";
            this.btnClearPreviousItemFood.UseVisualStyleBackColor = true;
            // 
            // btnBeefBurger
            // 
            this.btnBeefBurger.AutoSize = true;
            this.btnBeefBurger.BackgroundImage = global::CMPG223_POS.Properties.Resources.Beef_Burger;
            this.btnBeefBurger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBeefBurger.Location = new System.Drawing.Point(5, 5);
            this.btnBeefBurger.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.btnBeefBurger.Name = "btnBeefBurger";
            this.btnBeefBurger.Size = new System.Drawing.Size(200, 200);
            this.btnBeefBurger.TabIndex = 1;
            this.btnBeefBurger.UseVisualStyleBackColor = true;
            this.btnBeefBurger.Click += new System.EventHandler(this.btnBeefBurger_Click);
            // 
            // btnChickenBurger
            // 
            this.btnChickenBurger.AutoSize = true;
            this.btnChickenBurger.BackgroundImage = global::CMPG223_POS.Properties.Resources.Chicken_Burger;
            this.btnChickenBurger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChickenBurger.Location = new System.Drawing.Point(5, 210);
            this.btnChickenBurger.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.btnChickenBurger.Name = "btnChickenBurger";
            this.btnChickenBurger.Size = new System.Drawing.Size(200, 200);
            this.btnChickenBurger.TabIndex = 2;
            this.btnChickenBurger.UseVisualStyleBackColor = true;
            this.btnChickenBurger.Click += new System.EventHandler(this.btnChickenBurger_Click);
            // 
            // btnCheeseBurger
            // 
            this.btnCheeseBurger.AutoSize = true;
            this.btnCheeseBurger.BackgroundImage = global::CMPG223_POS.Properties.Resources.Cheese_Burger;
            this.btnCheeseBurger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCheeseBurger.Location = new System.Drawing.Point(5, 415);
            this.btnCheeseBurger.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.btnCheeseBurger.Name = "btnCheeseBurger";
            this.btnCheeseBurger.Size = new System.Drawing.Size(200, 200);
            this.btnCheeseBurger.TabIndex = 3;
            this.btnCheeseBurger.UseVisualStyleBackColor = true;
            this.btnCheeseBurger.Click += new System.EventHandler(this.btnCheeseBurger_Click);
            // 
            // btnChickenSnitzel
            // 
            this.btnChickenSnitzel.AutoSize = true;
            this.btnChickenSnitzel.BackgroundImage = global::CMPG223_POS.Properties.Resources.Chicken_Schnitzel;
            this.btnChickenSnitzel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChickenSnitzel.Location = new System.Drawing.Point(5, 620);
            this.btnChickenSnitzel.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.btnChickenSnitzel.Name = "btnChickenSnitzel";
            this.btnChickenSnitzel.Size = new System.Drawing.Size(200, 200);
            this.btnChickenSnitzel.TabIndex = 4;
            this.btnChickenSnitzel.UseVisualStyleBackColor = true;
            this.btnChickenSnitzel.Click += new System.EventHandler(this.btnChickenSnitzel_Click);
            // 
            // btnSmallChips
            // 
            this.btnSmallChips.AutoSize = true;
            this.btnSmallChips.BackgroundImage = global::CMPG223_POS.Properties.Resources.Small_Chips;
            this.btnSmallChips.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSmallChips.Location = new System.Drawing.Point(5, 825);
            this.btnSmallChips.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.btnSmallChips.Name = "btnSmallChips";
            this.btnSmallChips.Size = new System.Drawing.Size(200, 200);
            this.btnSmallChips.TabIndex = 5;
            this.btnSmallChips.UseVisualStyleBackColor = true;
            this.btnSmallChips.Click += new System.EventHandler(this.btnSmallChips_Click);
            // 
            // btnMediumChips
            // 
            this.btnMediumChips.BackgroundImage = global::CMPG223_POS.Properties.Resources.Medium_Chips;
            this.btnMediumChips.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMediumChips.Location = new System.Drawing.Point(5, 1030);
            this.btnMediumChips.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.btnMediumChips.Name = "btnMediumChips";
            this.btnMediumChips.Size = new System.Drawing.Size(200, 200);
            this.btnMediumChips.TabIndex = 9;
            this.btnMediumChips.UseVisualStyleBackColor = true;
            this.btnMediumChips.Click += new System.EventHandler(this.btnMediumChips_Click);
            // 
            // btnLargeChips
            // 
            this.btnLargeChips.BackgroundImage = global::CMPG223_POS.Properties.Resources.Large_Chips;
            this.btnLargeChips.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLargeChips.Location = new System.Drawing.Point(5, 1235);
            this.btnLargeChips.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.btnLargeChips.Name = "btnLargeChips";
            this.btnLargeChips.Size = new System.Drawing.Size(200, 200);
            this.btnLargeChips.TabIndex = 8;
            this.btnLargeChips.UseVisualStyleBackColor = true;
            // 
            // btnRegularWings
            // 
            this.btnRegularWings.AutoSize = true;
            this.btnRegularWings.BackgroundImage = global::CMPG223_POS.Properties.Resources.Regular_Wings;
            this.btnRegularWings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegularWings.Location = new System.Drawing.Point(5, 1440);
            this.btnRegularWings.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.btnRegularWings.Name = "btnRegularWings";
            this.btnRegularWings.Size = new System.Drawing.Size(200, 200);
            this.btnRegularWings.TabIndex = 6;
            this.btnRegularWings.UseVisualStyleBackColor = true;
            this.btnRegularWings.Click += new System.EventHandler(this.btnRegularWings_Click);
            // 
            // btnMildWings
            // 
            this.btnMildWings.BackColor = System.Drawing.Color.White;
            this.btnMildWings.BackgroundImage = global::CMPG223_POS.Properties.Resources.Mild_Wings;
            this.btnMildWings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMildWings.Location = new System.Drawing.Point(5, 1645);
            this.btnMildWings.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.btnMildWings.Name = "btnMildWings";
            this.btnMildWings.Size = new System.Drawing.Size(200, 200);
            this.btnMildWings.TabIndex = 10;
            this.btnMildWings.UseVisualStyleBackColor = false;
            // 
            // btnHotWings
            // 
            this.btnHotWings.BackgroundImage = global::CMPG223_POS.Properties.Resources.Hot_Wings;
            this.btnHotWings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHotWings.Location = new System.Drawing.Point(5, 1850);
            this.btnHotWings.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.btnHotWings.Name = "btnHotWings";
            this.btnHotWings.Size = new System.Drawing.Size(200, 200);
            this.btnHotWings.TabIndex = 7;
            this.btnHotWings.UseVisualStyleBackColor = true;
            this.btnHotWings.Click += new System.EventHandler(this.btnHotWings_Click);
            // 
            // btnSwartkatLager
            // 
            this.btnSwartkatLager.BackgroundImage = global::CMPG223_POS.Properties.Resources.SKL;
            this.btnSwartkatLager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSwartkatLager.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSwartkatLager.Location = new System.Drawing.Point(5, 5);
            this.btnSwartkatLager.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.btnSwartkatLager.Name = "btnSwartkatLager";
            this.btnSwartkatLager.Size = new System.Drawing.Size(200, 200);
            this.btnSwartkatLager.TabIndex = 0;
            this.btnSwartkatLager.UseVisualStyleBackColor = true;
            this.btnSwartkatLager.Click += new System.EventHandler(this.btnSwartkatLager_Click);
            // 
            // btnAfricaPilsner
            // 
            this.btnAfricaPilsner.BackgroundImage = global::CMPG223_POS.Properties.Resources.AP;
            this.btnAfricaPilsner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAfricaPilsner.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAfricaPilsner.Location = new System.Drawing.Point(5, 210);
            this.btnAfricaPilsner.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.btnAfricaPilsner.Name = "btnAfricaPilsner";
            this.btnAfricaPilsner.Size = new System.Drawing.Size(200, 200);
            this.btnAfricaPilsner.TabIndex = 1;
            this.btnAfricaPilsner.UseVisualStyleBackColor = true;
            this.btnAfricaPilsner.Click += new System.EventHandler(this.btnAfricaPilsner_Click);
            // 
            // btnWeisbeer
            // 
            this.btnWeisbeer.BackgroundImage = global::CMPG223_POS.Properties.Resources.WB;
            this.btnWeisbeer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWeisbeer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnWeisbeer.Location = new System.Drawing.Point(5, 415);
            this.btnWeisbeer.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.btnWeisbeer.Name = "btnWeisbeer";
            this.btnWeisbeer.Size = new System.Drawing.Size(200, 200);
            this.btnWeisbeer.TabIndex = 2;
            this.btnWeisbeer.UseVisualStyleBackColor = true;
            this.btnWeisbeer.Click += new System.EventHandler(this.btnWeisbeer_Click);
            // 
            // btnRedAle
            // 
            this.btnRedAle.BackgroundImage = global::CMPG223_POS.Properties.Resources.RA;
            this.btnRedAle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRedAle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRedAle.Location = new System.Drawing.Point(5, 620);
            this.btnRedAle.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.btnRedAle.Name = "btnRedAle";
            this.btnRedAle.Size = new System.Drawing.Size(200, 200);
            this.btnRedAle.TabIndex = 3;
            this.btnRedAle.UseVisualStyleBackColor = true;
            this.btnRedAle.Click += new System.EventHandler(this.btnRedAle_Click);
            // 
            // btnGRTAle
            // 
            this.btnGRTAle.BackgroundImage = global::CMPG223_POS.Properties.Resources.GRT;
            this.btnGRTAle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGRTAle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGRTAle.Location = new System.Drawing.Point(5, 825);
            this.btnGRTAle.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.btnGRTAle.Name = "btnGRTAle";
            this.btnGRTAle.Size = new System.Drawing.Size(200, 200);
            this.btnGRTAle.TabIndex = 4;
            this.btnGRTAle.UseVisualStyleBackColor = true;
            this.btnGRTAle.Click += new System.EventHandler(this.btnGRTAle_Click);
            // 
            // btnStout
            // 
            this.btnStout.BackgroundImage = global::CMPG223_POS.Properties.Resources.STOUT;
            this.btnStout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStout.Location = new System.Drawing.Point(5, 1030);
            this.btnStout.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.btnStout.Name = "btnStout";
            this.btnStout.Size = new System.Drawing.Size(200, 200);
            this.btnStout.TabIndex = 5;
            this.btnStout.UseVisualStyleBackColor = true;
            this.btnStout.Click += new System.EventHandler(this.btnStout_Click);
            // 
            // btnCraftGin
            // 
            this.btnCraftGin.BackgroundImage = global::CMPG223_POS.Properties.Resources.GIN;
            this.btnCraftGin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCraftGin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCraftGin.Location = new System.Drawing.Point(5, 1235);
            this.btnCraftGin.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.btnCraftGin.Name = "btnCraftGin";
            this.btnCraftGin.Size = new System.Drawing.Size(200, 200);
            this.btnCraftGin.TabIndex = 6;
            this.btnCraftGin.UseVisualStyleBackColor = true;
            this.btnCraftGin.Click += new System.EventHandler(this.btnCraftGin_Click);
            // 
            // btnRum
            // 
            this.btnRum.BackgroundImage = global::CMPG223_POS.Properties.Resources.RUM;
            this.btnRum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRum.Location = new System.Drawing.Point(5, 1440);
            this.btnRum.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.btnRum.Name = "btnRum";
            this.btnRum.Size = new System.Drawing.Size(200, 200);
            this.btnRum.TabIndex = 7;
            this.btnRum.UseVisualStyleBackColor = true;
            this.btnRum.Click += new System.EventHandler(this.btnRum_Click);
            // 
            // panelOderHome
            // 
            this.panelOderHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelOderHome.BackgroundImage")));
            this.panelOderHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelOderHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOderHome.Controls.Add(this.flowLayoutPanel5);
            this.panelOderHome.Controls.Add(this.panelCenter);
            this.panelOderHome.Location = new System.Drawing.Point(8, 38);
            this.panelOderHome.Name = "panelOderHome";
            this.panelOderHome.Size = new System.Drawing.Size(739, 135);
            this.panelOderHome.TabIndex = 2;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.flowLayoutPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel5.Controls.Add(this.btnCancelOrder);
            this.flowLayoutPanel5.Controls.Add(this.btnConfirmOrder);
            this.flowLayoutPanel5.Controls.Add(this.btnPayOrder);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(200, 133);
            this.flowLayoutPanel5.TabIndex = 3;
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Location = new System.Drawing.Point(1, 1);
            this.btnCancelOrder.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(198, 40);
            this.btnCancelOrder.TabIndex = 0;
            this.btnCancelOrder.Text = "Cancel Order";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.Location = new System.Drawing.Point(1, 42);
            this.btnConfirmOrder.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Size = new System.Drawing.Size(198, 40);
            this.btnConfirmOrder.TabIndex = 2;
            this.btnConfirmOrder.Text = "Confirm Order";
            this.btnConfirmOrder.UseVisualStyleBackColor = true;
            this.btnConfirmOrder.Click += new System.EventHandler(this.btnConfirmOrder_Click_1);
            // 
            // btnPayOrder
            // 
            this.btnPayOrder.Location = new System.Drawing.Point(1, 83);
            this.btnPayOrder.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.btnPayOrder.Name = "btnPayOrder";
            this.btnPayOrder.Size = new System.Drawing.Size(198, 40);
            this.btnPayOrder.TabIndex = 3;
            this.btnPayOrder.Text = "Pay Order";
            this.btnPayOrder.UseVisualStyleBackColor = true;
            this.btnPayOrder.Click += new System.EventHandler(this.btnPayOrder_Click);
            // 
            // panelCenter
            // 
            this.panelCenter.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelCenter.Controls.Add(this.btnDrinks);
            this.panelCenter.Controls.Add(this.btnFood);
            this.panelCenter.Location = new System.Drawing.Point(209, 42);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(523, 86);
            this.panelCenter.TabIndex = 2;
            // 
            // btnDrinks
            // 
            this.btnDrinks.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrinks.Location = new System.Drawing.Point(0, 0);
            this.btnDrinks.Margin = new System.Windows.Forms.Padding(0);
            this.btnDrinks.Name = "btnDrinks";
            this.btnDrinks.Size = new System.Drawing.Size(250, 86);
            this.btnDrinks.TabIndex = 0;
            this.btnDrinks.Text = "Drinks";
            this.btnDrinks.UseVisualStyleBackColor = true;
            this.btnDrinks.Click += new System.EventHandler(this.btnDrinks_Click);
            // 
            // btnFood
            // 
            this.btnFood.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFood.Location = new System.Drawing.Point(273, 0);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(250, 86);
            this.btnFood.TabIndex = 1;
            this.btnFood.Text = "Food";
            this.btnFood.UseVisualStyleBackColor = true;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 703);
            this.ControlBox = false;
            this.Controls.Add(this.panelFood);
            this.Controls.Add(this.panelDrinks);
            this.Controls.Add(this.panelOderHome);
            this.Controls.Add(this.lbOrders);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Orders";
            this.Text = "Orders";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Orders_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelDrinks.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panelFood.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelOderHome.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.panelCenter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Button btnDrinks;
        private System.Windows.Forms.Panel panelOderHome;
        private System.Windows.Forms.Panel panelDrinks;
        private System.Windows.Forms.Panel panelFood;
        private System.Windows.Forms.Button btnBackDrinks;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnBackFood;
        private System.Windows.Forms.Button btnClearPreviousItemFood;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button btnClearPreviousItemDrinks;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button btnMildWings;
        private System.Windows.Forms.Button btnBeefBurger;
        private System.Windows.Forms.Button btnChickenBurger;
        private System.Windows.Forms.Button btnCheeseBurger;
        private System.Windows.Forms.Button btnChickenSnitzel;
        private System.Windows.Forms.Button btnSmallChips;
        private System.Windows.Forms.Button btnRegularWings;
        private System.Windows.Forms.Button btnHotWings;
        private System.Windows.Forms.Button btnSwartkatLager;
        private System.Windows.Forms.Button btnAfricaPilsner;
        private System.Windows.Forms.Button btnWeisbeer;
        private System.Windows.Forms.Button btnRedAle;
        private System.Windows.Forms.Button btnGRTAle;
        private System.Windows.Forms.Button btnStout;
        private System.Windows.Forms.Button btnCraftGin;
        private System.Windows.Forms.Button btnRum;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        public System.Windows.Forms.ListBox lbOrders;
        private System.Windows.Forms.Button btnMediumChips;
        private System.Windows.Forms.Button btnLargeChips;
        private System.Windows.Forms.Button btnConfirmOrder;
        private System.Windows.Forms.Button btnPayOrder;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Label lbClientID;
        public System.Windows.Forms.Button btnCancelOrder;
    }
}