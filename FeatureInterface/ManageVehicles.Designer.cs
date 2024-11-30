namespace FeatureInterface
{
    partial class ManageVehicles
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
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            NavPanel.SuspendLayout();
            SuspendLayout();
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
            NavPanel.Size = new Size(833, 49);
            NavPanel.TabIndex = 14;
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
            forwardButton.Location = new Point(787, 0);
            forwardButton.Name = "forwardButton";
            forwardButton.Size = new Size(46, 49);
            forwardButton.TabIndex = 13;
            forwardButton.Text = "-->";
            forwardButton.UseVisualStyleBackColor = true;
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
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(286, 75);
            label1.Name = "label1";
            label1.Size = new Size(194, 32);
            label1.TabIndex = 15;
            label1.Text = "Manage Vehicles";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Mine - Jeep Cherokee", "Wife's - Chevy Silverado" });
            comboBox1.Location = new Point(143, 142);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(558, 28);
            comboBox1.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 256);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 17;
            label2.Text = "Make";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(143, 308);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 18;
            label3.Text = "Model";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(143, 358);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 19;
            label4.Text = "Year";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(414, 201);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 20;
            label5.Text = "Color";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(143, 201);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 21;
            label6.Text = "Nickname";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(414, 256);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 22;
            label7.Text = "Plate #";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(414, 308);
            label8.Name = "label8";
            label8.Size = new Size(33, 20);
            label8.TabIndex = 23;
            label8.Text = "VIN";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(143, 224);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(226, 27);
            textBox1.TabIndex = 24;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(143, 279);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(226, 27);
            textBox2.TabIndex = 25;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(143, 328);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(226, 27);
            textBox3.TabIndex = 26;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(143, 381);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(226, 27);
            textBox4.TabIndex = 27;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(414, 224);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(226, 27);
            textBox5.TabIndex = 28;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(414, 278);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(226, 27);
            textBox6.TabIndex = 29;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(414, 331);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(226, 27);
            textBox7.TabIndex = 30;
            // 
            // button3
            // 
            button3.Location = new Point(414, 375);
            button3.Name = "button3";
            button3.Size = new Size(120, 33);
            button3.TabIndex = 31;
            button3.Text = "Update Vehicle";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(143, 433);
            button4.Name = "button4";
            button4.Size = new Size(129, 42);
            button4.TabIndex = 32;
            button4.Text = "Delete Vehicle";
            button4.UseVisualStyleBackColor = true;
            // 
            // ManageVehicles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 503);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(NavPanel);
            Name = "ManageVehicles";
            Text = "ManageVehicles";
            NavPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel NavPanel;
        private Button button2;
        private Button button1;
        private Button forwardButton;
        private Button logButton;
        private Button camButton;
        private Button statusButton;
        private Button accButton;
        private Button gpsButton;
        private Button backButton;
        private Button homeButton;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button button3;
        private Button button4;
    }
}