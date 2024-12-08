namespace FeatureInterface
{
    partial class Drivers
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
            label1 = new Label();
            NavPanel = new Panel();
            button2 = new Button();
            button1 = new Button();
            forwardButton = new Button();
            logButton = new Button();
            camButton = new Button();
            statusButton = new Button();
            accButton = new Button();
            gpsButton = new Button();
            backButton = new Button();
            homeButton = new Button();
            label2 = new Label();
            comboBox1 = new ComboBox();
            VehShortcutButton = new Button();
            listBox1 = new ListBox();
            label3 = new Label();
            remDrivButton = new Button();
            AddDrivButton = new Button();
            geoFencShortCutButton = new Button();
            button3 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            NavPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(312, 63);
            label1.Name = "label1";
            label1.Size = new Size(212, 38);
            label1.TabIndex = 0;
            label1.Text = "Manage Drivers";
            // 
            // NavPanel
            // 
            NavPanel.AutoSize = true;
            NavPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            NavPanel.Controls.Add(button2);
            NavPanel.Controls.Add(button1);
            NavPanel.Controls.Add(forwardButton);
            NavPanel.Controls.Add(logButton);
            NavPanel.Controls.Add(camButton);
            NavPanel.Controls.Add(statusButton);
            NavPanel.Controls.Add(accButton);
            NavPanel.Controls.Add(gpsButton);
            NavPanel.Controls.Add(backButton);
            NavPanel.Controls.Add(homeButton);
            NavPanel.Dock = DockStyle.Top;
            NavPanel.Location = new Point(0, 0);
            NavPanel.Name = "NavPanel";
            NavPanel.Size = new Size(919, 49);
            NavPanel.TabIndex = 13;
            // 
            // button2
            // 
            button2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button2.Location = new Point(699, 9);
            button2.Name = "button2";
            button2.Size = new Size(81, 37);
            button2.TabIndex = 20;
            button2.Text = "Vehicles";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.Location = new Point(612, 9);
            button1.Name = "button1";
            button1.Size = new Size(81, 37);
            button1.TabIndex = 14;
            button1.Text = "Drivers";
            button1.UseVisualStyleBackColor = true;
            // 
            // forwardButton
            // 
            forwardButton.Dock = DockStyle.Right;
            forwardButton.Location = new Point(873, 0);
            forwardButton.Name = "forwardButton";
            forwardButton.Size = new Size(46, 49);
            forwardButton.TabIndex = 13;
            forwardButton.Text = "-->";
            forwardButton.UseVisualStyleBackColor = true;
            forwardButton.Click += forwardButton_Click;
            // 
            // logButton
            // 
            logButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            logButton.Location = new Point(540, 9);
            logButton.Name = "logButton";
            logButton.Size = new Size(66, 37);
            logButton.TabIndex = 12;
            logButton.Text = "Logs";
            logButton.UseVisualStyleBackColor = true;
            // 
            // camButton
            // 
            camButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            camButton.Location = new Point(453, 9);
            camButton.Name = "camButton";
            camButton.Size = new Size(81, 37);
            camButton.TabIndex = 12;
            camButton.Text = "Cameras";
            camButton.UseVisualStyleBackColor = true;
            // 
            // statusButton
            // 
            statusButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            statusButton.Location = new Point(360, 9);
            statusButton.Name = "statusButton";
            statusButton.Size = new Size(87, 37);
            statusButton.TabIndex = 12;
            statusButton.Text = "Status";
            statusButton.UseVisualStyleBackColor = true;
            // 
            // accButton
            // 
            accButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            accButton.Location = new Point(258, 9);
            accButton.Name = "accButton";
            accButton.Size = new Size(96, 37);
            accButton.TabIndex = 3;
            accButton.Text = "Accessories";
            accButton.UseVisualStyleBackColor = true;
            // 
            // gpsButton
            // 
            gpsButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gpsButton.Location = new Point(153, 9);
            gpsButton.Name = "gpsButton";
            gpsButton.Size = new Size(99, 37);
            gpsButton.TabIndex = 2;
            gpsButton.Text = "GPS";
            gpsButton.UseVisualStyleBackColor = true;
            gpsButton.Click += gpsButton_Click;
            // 
            // backButton
            // 
            backButton.Dock = DockStyle.Left;
            backButton.Location = new Point(0, 0);
            backButton.Name = "backButton";
            backButton.Size = new Size(44, 49);
            backButton.TabIndex = 1;
            backButton.Text = "<--";
            backButton.UseVisualStyleBackColor = true;
            // 
            // homeButton
            // 
            homeButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            homeButton.Location = new Point(53, 9);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(94, 37);
            homeButton.TabIndex = 0;
            homeButton.Text = "Home";
            homeButton.UseVisualStyleBackColor = true;
            homeButton.Click += homeButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(75, 151);
            label2.Name = "label2";
            label2.Size = new Size(111, 28);
            label2.TabIndex = 14;
            label2.Text = "For Vehicle:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Mine - Jeep Cherokee", "Wife's - Chevy Silverado" });
            comboBox1.Location = new Point(199, 155);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(403, 28);
            comboBox1.TabIndex = 15;
            // 
            // VehShortcutButton
            // 
            VehShortcutButton.Location = new Point(674, 152);
            VehShortcutButton.Name = "VehShortcutButton";
            VehShortcutButton.Size = new Size(148, 31);
            VehShortcutButton.TabIndex = 16;
            VehShortcutButton.Text = "Edit Vehicles";
            VehShortcutButton.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "Sarah", "Candice" });
            listBox1.Location = new Point(11, 286);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(204, 184);
            listBox1.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(11, 255);
            label3.Name = "label3";
            label3.Size = new Size(179, 28);
            label3.TabIndex = 18;
            label3.Text = "Authorized Drivers:";
            // 
            // remDrivButton
            // 
            remDrivButton.Location = new Point(11, 476);
            remDrivButton.Name = "remDrivButton";
            remDrivButton.Size = new Size(92, 58);
            remDrivButton.TabIndex = 19;
            remDrivButton.Text = "Remove Driver";
            remDrivButton.UseVisualStyleBackColor = true;
            // 
            // AddDrivButton
            // 
            AddDrivButton.Location = new Point(316, 476);
            AddDrivButton.Name = "AddDrivButton";
            AddDrivButton.Size = new Size(180, 53);
            AddDrivButton.TabIndex = 20;
            AddDrivButton.Text = "Accept";
            AddDrivButton.UseVisualStyleBackColor = true;
            // 
            // geoFencShortCutButton
            // 
            geoFencShortCutButton.Location = new Point(674, 189);
            geoFencShortCutButton.Name = "geoFencShortCutButton";
            geoFencShortCutButton.Size = new Size(148, 40);
            geoFencShortCutButton.TabIndex = 21;
            geoFencShortCutButton.Text = "Edit Geofences";
            geoFencShortCutButton.UseVisualStyleBackColor = true;
            geoFencShortCutButton.Click += geoFencShortCutButton_Click;
            // 
            // button3
            // 
            button3.Location = new Point(109, 478);
            button3.Name = "button3";
            button3.Size = new Size(105, 56);
            button3.TabIndex = 22;
            button3.Text = "Edit Driver";
            button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(316, 286);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 23;
            label4.Text = "First Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(316, 340);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 24;
            label5.Text = "Last Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(316, 393);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 25;
            label6.Text = "Nickname:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(315, 310);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(209, 27);
            textBox1.TabIndex = 26;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(316, 363);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(208, 27);
            textBox2.TabIndex = 27;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(315, 416);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(209, 27);
            textBox3.TabIndex = 28;
            // 
            // Drivers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 544);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(geoFencShortCutButton);
            Controls.Add(AddDrivButton);
            Controls.Add(remDrivButton);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Controls.Add(VehShortcutButton);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(NavPanel);
            Controls.Add(label1);
            Name = "Drivers";
            Text = "Drivers";
            NavPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel NavPanel;
        private Button forwardButton;
        private Button logButton;
        private Button camButton;
        private Button statusButton;
        private Button accButton;
        private Button gpsButton;
        private Button backButton;
        private Button homeButton;
        private Label label2;
        private ComboBox comboBox1;
        private Button VehShortcutButton;
        private ListBox listBox1;
        private Label label3;
        private Button remDrivButton;
        private Button button2;
        private Button button1;
        private Button AddDrivButton;
        private Button geoFencShortCutButton;
        private Button button3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}