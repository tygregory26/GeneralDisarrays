﻿namespace FeatureInterface
{
    partial class AccessoriesPage
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
            tableLayoutPanel1 = new TableLayoutPanel();
            NavPanel = new Panel();
            secNavButton = new Button();
            vehNavButton = new Button();
            driverNavButton = new Button();
            forwardButton = new Button();
            logButton = new Button();
            camButton = new Button();
            statusButton = new Button();
            accButton = new Button();
            gpsButton = new Button();
            backButton = new Button();
            homeButton = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            allDownButton = new Button();
            allUpButton = new Button();
            tableLayoutPanel7 = new TableLayoutPanel();
            downFrontPassengerButton = new Button();
            upFrontPassengerButton = new Button();
            tableLayoutPanel6 = new TableLayoutPanel();
            downRearDriverButton = new Button();
            upRearDriverButton = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            downRearPassengerButton = new Button();
            upRearPassengerButton = new Button();
            tableLayoutPanel8 = new TableLayoutPanel();
            upFrontDriverButton = new Button();
            downFrontDriverButton = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            pictureBoxRearDriver = new PictureBox();
            pictureBoxRearPassenger = new PictureBox();
            pictureBoxFrontDriver = new PictureBox();
            pictureBoxFrontPassenger = new PictureBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            doorsTextBox = new TextBox();
            tableLayoutPanel9 = new TableLayoutPanel();
            unlockDoorsButton = new Button();
            lockDoorsButton = new Button();
            tableLayoutPanel10 = new TableLayoutPanel();
            remoteStartStatusTextBox = new TextBox();
            changeRemoteStatusButton = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            stopRemoteStartButton = new Button();
            startRemoteStartButton = new Button();
            remoteStartTextBox = new TextBox();
            remoteStartOutputListBox = new ListBox();
            textBox1 = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            NavPanel.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRearDriver).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRearPassenger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFrontDriver).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFrontPassenger).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(NavPanel, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 3);
            tableLayoutPanel1.Controls.Add(textBox1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.9230766F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.0769234F));
            tableLayoutPanel1.Size = new Size(812, 635);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // NavPanel
            // 
            NavPanel.AutoSize = true;
            NavPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.SetColumnSpan(NavPanel, 2);
            NavPanel.Controls.Add(secNavButton);
            NavPanel.Controls.Add(vehNavButton);
            NavPanel.Controls.Add(driverNavButton);
            NavPanel.Controls.Add(forwardButton);
            NavPanel.Controls.Add(logButton);
            NavPanel.Controls.Add(camButton);
            NavPanel.Controls.Add(statusButton);
            NavPanel.Controls.Add(accButton);
            NavPanel.Controls.Add(gpsButton);
            NavPanel.Controls.Add(backButton);
            NavPanel.Controls.Add(homeButton);
            NavPanel.Dock = DockStyle.Top;
            NavPanel.Location = new Point(3, 2);
            NavPanel.Margin = new Padding(3, 2, 3, 2);
            NavPanel.Name = "NavPanel";
            NavPanel.Size = new Size(806, 36);
            NavPanel.TabIndex = 14;
            // 
            // secNavButton
            // 
            secNavButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            secNavButton.Location = new Point(688, 7);
            secNavButton.Margin = new Padding(3, 2, 3, 2);
            secNavButton.Name = "secNavButton";
            secNavButton.Size = new Size(71, 28);
            secNavButton.TabIndex = 21;
            secNavButton.Text = "Security";
            secNavButton.UseVisualStyleBackColor = true;
            secNavButton.Click += secNavButton_Click;
            // 
            // vehNavButton
            // 
            vehNavButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            vehNavButton.Location = new Point(612, 7);
            vehNavButton.Margin = new Padding(3, 2, 3, 2);
            vehNavButton.Name = "vehNavButton";
            vehNavButton.Size = new Size(71, 28);
            vehNavButton.TabIndex = 20;
            vehNavButton.Text = "Vehicles";
            vehNavButton.UseVisualStyleBackColor = true;
            vehNavButton.Click += vehNavButton_Click;
            // 
            // driverNavButton
            // 
            driverNavButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            driverNavButton.Location = new Point(536, 7);
            driverNavButton.Margin = new Padding(3, 2, 3, 2);
            driverNavButton.Name = "driverNavButton";
            driverNavButton.Size = new Size(71, 28);
            driverNavButton.TabIndex = 14;
            driverNavButton.Text = "Drivers";
            driverNavButton.UseVisualStyleBackColor = true;
            driverNavButton.Click += driverNavButton_Click;
            // 
            // forwardButton
            // 
            forwardButton.Dock = DockStyle.Right;
            forwardButton.Location = new Point(766, 0);
            forwardButton.Margin = new Padding(3, 2, 3, 2);
            forwardButton.Name = "forwardButton";
            forwardButton.Size = new Size(40, 36);
            forwardButton.TabIndex = 13;
            forwardButton.Text = "-->";
            forwardButton.UseVisualStyleBackColor = true;
            // 
            // logButton
            // 
            logButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            logButton.Location = new Point(472, 7);
            logButton.Margin = new Padding(3, 2, 3, 2);
            logButton.Name = "logButton";
            logButton.Size = new Size(58, 28);
            logButton.TabIndex = 12;
            logButton.Text = "Logs";
            logButton.UseVisualStyleBackColor = true;
            logButton.Click += logButton_Click;
            // 
            // camButton
            // 
            camButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            camButton.Location = new Point(396, 7);
            camButton.Margin = new Padding(3, 2, 3, 2);
            camButton.Name = "camButton";
            camButton.Size = new Size(71, 28);
            camButton.TabIndex = 12;
            camButton.Text = "Cameras";
            camButton.UseVisualStyleBackColor = true;
            camButton.Click += camButton_Click;
            // 
            // statusButton
            // 
            statusButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            statusButton.Location = new Point(315, 7);
            statusButton.Margin = new Padding(3, 2, 3, 2);
            statusButton.Name = "statusButton";
            statusButton.Size = new Size(76, 28);
            statusButton.TabIndex = 12;
            statusButton.Text = "Status";
            statusButton.UseVisualStyleBackColor = true;
            statusButton.Click += statusButton_Click;
            // 
            // accButton
            // 
            accButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            accButton.Location = new Point(226, 7);
            accButton.Margin = new Padding(3, 2, 3, 2);
            accButton.Name = "accButton";
            accButton.Size = new Size(84, 28);
            accButton.TabIndex = 3;
            accButton.Text = "Accessories";
            accButton.UseVisualStyleBackColor = true;
            accButton.Click += accButton_Click;
            // 
            // gpsButton
            // 
            gpsButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gpsButton.Location = new Point(134, 7);
            gpsButton.Margin = new Padding(3, 2, 3, 2);
            gpsButton.Name = "gpsButton";
            gpsButton.Size = new Size(87, 28);
            gpsButton.TabIndex = 2;
            gpsButton.Text = "GPS";
            gpsButton.UseVisualStyleBackColor = true;
            gpsButton.Click += gpsButton_Click;
            // 
            // backButton
            // 
            backButton.Dock = DockStyle.Left;
            backButton.Location = new Point(0, 0);
            backButton.Margin = new Padding(3, 2, 3, 2);
            backButton.Name = "backButton";
            backButton.Size = new Size(38, 36);
            backButton.TabIndex = 1;
            backButton.Text = "<--";
            backButton.UseVisualStyleBackColor = true;
            // 
            // homeButton
            // 
            homeButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            homeButton.Location = new Point(46, 7);
            homeButton.Margin = new Padding(3, 2, 3, 2);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(82, 28);
            homeButton.TabIndex = 0;
            homeButton.Text = "Home";
            homeButton.UseVisualStyleBackColor = true;
            homeButton.Click += homeButton_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel2, 2);
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 86F));
            tableLayoutPanel2.Controls.Add(allDownButton, 2, 0);
            tableLayoutPanel2.Controls.Add(allUpButton, 1, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel7, 2, 2);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel6, 1, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel5, 1, 2);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel8, 2, 1);
            tableLayoutPanel2.Controls.Add(textBox2, 3, 0);
            tableLayoutPanel2.Controls.Add(textBox3, 0, 0);
            tableLayoutPanel2.Controls.Add(textBox4, 4, 1);
            tableLayoutPanel2.Controls.Add(textBox5, 4, 2);
            tableLayoutPanel2.Controls.Add(pictureBoxRearDriver, 0, 1);
            tableLayoutPanel2.Controls.Add(pictureBoxRearPassenger, 0, 2);
            tableLayoutPanel2.Controls.Add(pictureBoxFrontDriver, 3, 1);
            tableLayoutPanel2.Controls.Add(pictureBoxFrontPassenger, 3, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 83);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(806, 282);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // allDownButton
            // 
            allDownButton.Dock = DockStyle.Fill;
            allDownButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            allDownButton.Location = new Point(363, 3);
            allDownButton.Name = "allDownButton";
            allDownButton.Size = new Size(54, 24);
            allDownButton.TabIndex = 6;
            allDownButton.Text = "DOWN";
            allDownButton.UseVisualStyleBackColor = true;
            allDownButton.Click += allDownButton_Click;
            // 
            // allUpButton
            // 
            allUpButton.Dock = DockStyle.Fill;
            allUpButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            allUpButton.Location = new Point(303, 3);
            allUpButton.Name = "allUpButton";
            allUpButton.Size = new Size(54, 24);
            allUpButton.TabIndex = 5;
            allUpButton.Text = "ALL UP";
            allUpButton.UseVisualStyleBackColor = true;
            allUpButton.Click += allUpButton_Click;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(downFrontPassengerButton, 0, 1);
            tableLayoutPanel7.Controls.Add(upFrontPassengerButton, 0, 0);
            tableLayoutPanel7.Location = new Point(363, 159);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(54, 71);
            tableLayoutPanel7.TabIndex = 1;
            // 
            // downFrontPassengerButton
            // 
            downFrontPassengerButton.Dock = DockStyle.Fill;
            downFrontPassengerButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            downFrontPassengerButton.Location = new Point(3, 38);
            downFrontPassengerButton.Name = "downFrontPassengerButton";
            downFrontPassengerButton.Size = new Size(48, 30);
            downFrontPassengerButton.TabIndex = 2;
            downFrontPassengerButton.Text = "Down";
            downFrontPassengerButton.UseVisualStyleBackColor = true;
            downFrontPassengerButton.Click += downFrontPassengerButton_Click;
            // 
            // upFrontPassengerButton
            // 
            upFrontPassengerButton.Dock = DockStyle.Fill;
            upFrontPassengerButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            upFrontPassengerButton.Location = new Point(3, 3);
            upFrontPassengerButton.Name = "upFrontPassengerButton";
            upFrontPassengerButton.Size = new Size(48, 29);
            upFrontPassengerButton.TabIndex = 1;
            upFrontPassengerButton.Text = "Up";
            upFrontPassengerButton.UseVisualStyleBackColor = true;
            upFrontPassengerButton.Click += upFrontPassengerButton_Click;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel6.Controls.Add(downRearDriverButton, 0, 1);
            tableLayoutPanel6.Controls.Add(upRearDriverButton, 0, 0);
            tableLayoutPanel6.Location = new Point(303, 33);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(54, 72);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // downRearDriverButton
            // 
            downRearDriverButton.Dock = DockStyle.Fill;
            downRearDriverButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            downRearDriverButton.Location = new Point(3, 39);
            downRearDriverButton.Name = "downRearDriverButton";
            downRearDriverButton.Size = new Size(54, 30);
            downRearDriverButton.TabIndex = 2;
            downRearDriverButton.Text = "Down";
            downRearDriverButton.UseVisualStyleBackColor = true;
            downRearDriverButton.Click += downRearDriverButton_Click;
            // 
            // upRearDriverButton
            // 
            upRearDriverButton.Dock = DockStyle.Fill;
            upRearDriverButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            upRearDriverButton.Location = new Point(3, 3);
            upRearDriverButton.Name = "upRearDriverButton";
            upRearDriverButton.Size = new Size(54, 30);
            upRearDriverButton.TabIndex = 1;
            upRearDriverButton.Text = "Up";
            upRearDriverButton.UseVisualStyleBackColor = true;
            upRearDriverButton.Click += upRearDriverButton_Click;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(downRearPassengerButton, 0, 1);
            tableLayoutPanel5.Controls.Add(upRearPassengerButton, 0, 0);
            tableLayoutPanel5.Location = new Point(303, 159);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(54, 71);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // downRearPassengerButton
            // 
            downRearPassengerButton.Dock = DockStyle.Fill;
            downRearPassengerButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            downRearPassengerButton.Location = new Point(3, 38);
            downRearPassengerButton.Name = "downRearPassengerButton";
            downRearPassengerButton.Size = new Size(48, 30);
            downRearPassengerButton.TabIndex = 2;
            downRearPassengerButton.Text = "Down";
            downRearPassengerButton.UseVisualStyleBackColor = true;
            downRearPassengerButton.Click += downRearPassengerButton_Click;
            // 
            // upRearPassengerButton
            // 
            upRearPassengerButton.Dock = DockStyle.Fill;
            upRearPassengerButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            upRearPassengerButton.Location = new Point(3, 3);
            upRearPassengerButton.Name = "upRearPassengerButton";
            upRearPassengerButton.Size = new Size(48, 29);
            upRearPassengerButton.TabIndex = 1;
            upRearPassengerButton.Text = "Up";
            upRearPassengerButton.UseVisualStyleBackColor = true;
            upRearPassengerButton.Click += upRearPassengerButton_Click;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(upFrontDriverButton, 0, 0);
            tableLayoutPanel8.Controls.Add(downFrontDriverButton, 0, 1);
            tableLayoutPanel8.Location = new Point(363, 33);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel8.Size = new Size(54, 72);
            tableLayoutPanel8.TabIndex = 2;
            // 
            // upFrontDriverButton
            // 
            upFrontDriverButton.Dock = DockStyle.Fill;
            upFrontDriverButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            upFrontDriverButton.Location = new Point(3, 3);
            upFrontDriverButton.Name = "upFrontDriverButton";
            upFrontDriverButton.Size = new Size(48, 30);
            upFrontDriverButton.TabIndex = 0;
            upFrontDriverButton.Text = "Up";
            upFrontDriverButton.UseVisualStyleBackColor = true;
            upFrontDriverButton.Click += upFrontDriverButton_Click;
            // 
            // downFrontDriverButton
            // 
            downFrontDriverButton.Dock = DockStyle.Fill;
            downFrontDriverButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            downFrontDriverButton.Location = new Point(3, 39);
            downFrontDriverButton.Name = "downFrontDriverButton";
            downFrontDriverButton.Size = new Size(48, 30);
            downFrontDriverButton.TabIndex = 1;
            downFrontDriverButton.Text = "Down";
            downFrontDriverButton.UseVisualStyleBackColor = true;
            downFrontDriverButton.Click += downFrontDriverButton_Click;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Dock = DockStyle.Fill;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(423, 3);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(294, 22);
            textBox2.TabIndex = 3;
            textBox2.TabStop = false;
            textBox2.Text = "Front";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Dock = DockStyle.Fill;
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(3, 3);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(294, 22);
            textBox3.TabIndex = 4;
            textBox3.TabStop = false;
            textBox3.Text = "Rear";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(723, 82);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(80, 22);
            textBox4.TabIndex = 7;
            textBox4.TabStop = false;
            textBox4.Text = "Driver";
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(723, 209);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(80, 20);
            textBox5.TabIndex = 8;
            textBox5.TabStop = false;
            textBox5.Text = "Passenger";
            // 
            // pictureBoxRearDriver
            // 
            pictureBoxRearDriver.Dock = DockStyle.Fill;
            pictureBoxRearDriver.Location = new Point(3, 33);
            pictureBoxRearDriver.Name = "pictureBoxRearDriver";
            pictureBoxRearDriver.Size = new Size(294, 120);
            pictureBoxRearDriver.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxRearDriver.TabIndex = 9;
            pictureBoxRearDriver.TabStop = false;
            // 
            // pictureBoxRearPassenger
            // 
            pictureBoxRearPassenger.Dock = DockStyle.Fill;
            pictureBoxRearPassenger.Location = new Point(3, 159);
            pictureBoxRearPassenger.Name = "pictureBoxRearPassenger";
            pictureBoxRearPassenger.Size = new Size(294, 120);
            pictureBoxRearPassenger.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxRearPassenger.TabIndex = 10;
            pictureBoxRearPassenger.TabStop = false;
            // 
            // pictureBoxFrontDriver
            // 
            pictureBoxFrontDriver.Dock = DockStyle.Fill;
            pictureBoxFrontDriver.Location = new Point(423, 33);
            pictureBoxFrontDriver.Name = "pictureBoxFrontDriver";
            pictureBoxFrontDriver.Size = new Size(294, 120);
            pictureBoxFrontDriver.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFrontDriver.TabIndex = 11;
            pictureBoxFrontDriver.TabStop = false;
            // 
            // pictureBoxFrontPassenger
            // 
            pictureBoxFrontPassenger.Dock = DockStyle.Fill;
            pictureBoxFrontPassenger.Location = new Point(423, 159);
            pictureBoxFrontPassenger.Name = "pictureBoxFrontPassenger";
            pictureBoxFrontPassenger.Size = new Size(294, 120);
            pictureBoxFrontPassenger.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFrontPassenger.TabIndex = 12;
            pictureBoxFrontPassenger.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(doorsTextBox, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel9, 1, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel10, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 371);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(400, 261);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // doorsTextBox
            // 
            doorsTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            doorsTextBox.BackColor = SystemColors.Menu;
            doorsTextBox.BorderStyle = BorderStyle.None;
            doorsTextBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            doorsTextBox.Location = new Point(3, 47);
            doorsTextBox.Name = "doorsTextBox";
            doorsTextBox.ReadOnly = true;
            doorsTextBox.Size = new Size(194, 36);
            doorsTextBox.TabIndex = 13;
            doorsTextBox.TabStop = false;
            doorsTextBox.Text = "Doors";
            doorsTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Controls.Add(unlockDoorsButton, 0, 1);
            tableLayoutPanel9.Controls.Add(lockDoorsButton, 0, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(203, 3);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 2;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Size = new Size(194, 124);
            tableLayoutPanel9.TabIndex = 14;
            // 
            // unlockDoorsButton
            // 
            unlockDoorsButton.Dock = DockStyle.Fill;
            unlockDoorsButton.Font = new Font("Segoe UI", 20.25F);
            unlockDoorsButton.Location = new Point(3, 65);
            unlockDoorsButton.Name = "unlockDoorsButton";
            unlockDoorsButton.Size = new Size(188, 56);
            unlockDoorsButton.TabIndex = 1;
            unlockDoorsButton.Text = "Unlock";
            unlockDoorsButton.UseVisualStyleBackColor = true;
            unlockDoorsButton.Click += unlockDoorsButton_Click;
            // 
            // lockDoorsButton
            // 
            lockDoorsButton.Dock = DockStyle.Fill;
            lockDoorsButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lockDoorsButton.Location = new Point(3, 3);
            lockDoorsButton.Name = "lockDoorsButton";
            lockDoorsButton.Size = new Size(188, 56);
            lockDoorsButton.TabIndex = 0;
            lockDoorsButton.Text = "Locked";
            lockDoorsButton.UseVisualStyleBackColor = true;
            lockDoorsButton.Click += lockDoorsButton_Click;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 1;
            tableLayoutPanel3.SetColumnSpan(tableLayoutPanel10, 2);
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Controls.Add(remoteStartStatusTextBox, 0, 0);
            tableLayoutPanel10.Controls.Add(changeRemoteStatusButton, 0, 1);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(3, 133);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 2;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Size = new Size(394, 125);
            tableLayoutPanel10.TabIndex = 15;
            // 
            // remoteStartStatusTextBox
            // 
            remoteStartStatusTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            remoteStartStatusTextBox.BackColor = SystemColors.Menu;
            remoteStartStatusTextBox.BorderStyle = BorderStyle.None;
            remoteStartStatusTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            remoteStartStatusTextBox.Location = new Point(3, 17);
            remoteStartStatusTextBox.Name = "remoteStartStatusTextBox";
            remoteStartStatusTextBox.ReadOnly = true;
            remoteStartStatusTextBox.Size = new Size(388, 28);
            remoteStartStatusTextBox.TabIndex = 0;
            remoteStartStatusTextBox.TabStop = false;
            remoteStartStatusTextBox.Text = "Remote Start is: Enabled";
            remoteStartStatusTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // changeRemoteStatusButton
            // 
            changeRemoteStatusButton.Dock = DockStyle.Fill;
            changeRemoteStatusButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            changeRemoteStatusButton.Location = new Point(3, 65);
            changeRemoteStatusButton.Name = "changeRemoteStatusButton";
            changeRemoteStatusButton.Size = new Size(388, 57);
            changeRemoteStatusButton.TabIndex = 1;
            changeRemoteStatusButton.TabStop = false;
            changeRemoteStatusButton.Text = "Disable";
            changeRemoteStatusButton.UseVisualStyleBackColor = true;
            changeRemoteStatusButton.Click += changeRemoteStatusButton_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(stopRemoteStartButton, 1, 1);
            tableLayoutPanel4.Controls.Add(startRemoteStartButton, 0, 1);
            tableLayoutPanel4.Controls.Add(remoteStartTextBox, 0, 0);
            tableLayoutPanel4.Controls.Add(remoteStartOutputListBox, 0, 2);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(409, 371);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel4.Size = new Size(400, 261);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // stopRemoteStartButton
            // 
            stopRemoteStartButton.BackColor = Color.Red;
            stopRemoteStartButton.Dock = DockStyle.Fill;
            stopRemoteStartButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stopRemoteStartButton.Location = new Point(203, 55);
            stopRemoteStartButton.Name = "stopRemoteStartButton";
            stopRemoteStartButton.Size = new Size(194, 46);
            stopRemoteStartButton.TabIndex = 16;
            stopRemoteStartButton.Text = "Stop";
            stopRemoteStartButton.UseVisualStyleBackColor = false;
            stopRemoteStartButton.Click += stopRemoteStartButton_Click;
            // 
            // startRemoteStartButton
            // 
            startRemoteStartButton.BackColor = Color.Lime;
            startRemoteStartButton.Dock = DockStyle.Fill;
            startRemoteStartButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startRemoteStartButton.Location = new Point(3, 55);
            startRemoteStartButton.Name = "startRemoteStartButton";
            startRemoteStartButton.Size = new Size(194, 46);
            startRemoteStartButton.TabIndex = 15;
            startRemoteStartButton.Text = "Start";
            startRemoteStartButton.UseVisualStyleBackColor = false;
            startRemoteStartButton.Click += startRemoteStartButton_Click;
            // 
            // remoteStartTextBox
            // 
            remoteStartTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            remoteStartTextBox.BackColor = SystemColors.Menu;
            remoteStartTextBox.BorderStyle = BorderStyle.None;
            tableLayoutPanel4.SetColumnSpan(remoteStartTextBox, 2);
            remoteStartTextBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            remoteStartTextBox.Location = new Point(3, 8);
            remoteStartTextBox.Name = "remoteStartTextBox";
            remoteStartTextBox.ReadOnly = true;
            remoteStartTextBox.Size = new Size(394, 36);
            remoteStartTextBox.TabIndex = 14;
            remoteStartTextBox.TabStop = false;
            remoteStartTextBox.Text = "Remote Start";
            remoteStartTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // remoteStartOutputListBox
            // 
            tableLayoutPanel4.SetColumnSpan(remoteStartOutputListBox, 2);
            remoteStartOutputListBox.Dock = DockStyle.Fill;
            remoteStartOutputListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            remoteStartOutputListBox.FormattingEnabled = true;
            remoteStartOutputListBox.ItemHeight = 21;
            remoteStartOutputListBox.Location = new Point(3, 107);
            remoteStartOutputListBox.Name = "remoteStartOutputListBox";
            remoteStartOutputListBox.SelectionMode = SelectionMode.None;
            remoteStartOutputListBox.Size = new Size(394, 151);
            remoteStartOutputListBox.TabIndex = 17;
            remoteStartOutputListBox.TabStop = false;
            // 
            // textBox1
            // 
            tableLayoutPanel1.SetColumnSpan(textBox1, 2);
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(3, 43);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(806, 43);
            textBox1.TabIndex = 0;
            textBox1.Text = "Control Accessories";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // AccessoriesPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 635);
            Controls.Add(tableLayoutPanel1);
            Name = "AccessoriesPage";
            Text = "Accessories";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            NavPanel.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxRearDriver).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRearPassenger).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFrontDriver).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFrontPassenger).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel8;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button allDownButton;
        private Button allUpButton;
        private Button downFrontPassengerButton;
        private Button upFrontPassengerButton;
        private Button downRearDriverButton;
        private Button upRearDriverButton;
        private Button downRearPassengerButton;
        private Button upRearPassengerButton;
        private Button upFrontDriverButton;
        private Button downFrontDriverButton;
        private TextBox textBox4;
        private TextBox textBox5;
        private PictureBox pictureBoxRearDriver;
        private PictureBox pictureBoxRearPassenger;
        private PictureBox pictureBoxFrontDriver;
        private PictureBox pictureBoxFrontPassenger;
        private TextBox doorsTextBox;
        private TableLayoutPanel tableLayoutPanel9;
        private Button unlockDoorsButton;
        private Button lockDoorsButton;
        private TableLayoutPanel tableLayoutPanel10;
        private TextBox remoteStartStatusTextBox;
        private TextBox remoteStartTextBox;
        private Button stopRemoteStartButton;
        private Button startRemoteStartButton;
        private ListBox remoteStartOutputListBox;
        private Button changeRemoteStatusButton;
        private Panel NavPanel;
        private Button secNavButton;
        private Button vehNavButton;
        private Button driverNavButton;
        private Button forwardButton;
        private Button logButton;
        private Button camButton;
        private Button statusButton;
        private Button accButton;
        private Button gpsButton;
        private Button backButton;
        private Button homeButton;
    }
}