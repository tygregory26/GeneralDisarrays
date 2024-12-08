namespace FeatureInterface
{
    partial class LogsPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox3 = new TextBox();
            NavPanel = new Panel();
            button5 = new Button();
            button6 = new Button();
            forwardButton = new Button();
            logButton = new Button();
            camButton = new Button();
            statusButton = new Button();
            accButton = new Button();
            gpsButton = new Button();
            backButton = new Button();
            homeButton = new Button();
            helpProvider1 = new HelpProvider();
            NavPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(71, 74);
            label1.Name = "label1";
            label1.Size = new Size(172, 38);
            label1.TabIndex = 0;
            label1.Text = "Activity Logs";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 177);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 1;
            label2.Text = "Search";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(160, 144);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 2;
            label3.Text = "From";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(276, 145);
            label4.Name = "label4";
            label4.Size = new Size(25, 20);
            label4.TabIndex = 3;
            label4.Text = "To";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(161, 170);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(80, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(276, 170);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(106, 27);
            textBox2.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(498, 235);
            button1.Name = "button1";
            button1.Size = new Size(139, 51);
            button1.TabIndex = 6;
            button1.Text = "Today";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(498, 292);
            button2.Name = "button2";
            button2.Size = new Size(139, 56);
            button2.TabIndex = 7;
            button2.Text = "Previous Week";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(498, 354);
            button3.Name = "button3";
            button3.Size = new Size(139, 33);
            button3.TabIndex = 8;
            button3.Text = "Previous Month";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(498, 393);
            button4.Name = "button4";
            button4.Size = new Size(139, 51);
            button4.TabIndex = 9;
            button4.Text = "Previous Reset";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(71, 228);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(406, 245);
            textBox3.TabIndex = 10;
            // 
            // NavPanel
            // 
            NavPanel.AutoSize = true;
            NavPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            NavPanel.Controls.Add(button5);
            NavPanel.Controls.Add(button6);
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
            NavPanel.Size = new Size(954, 49);
            NavPanel.TabIndex = 15;
            // 
            // button5
            // 
            button5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button5.Location = new Point(699, 9);
            button5.Name = "button5";
            button5.Size = new Size(81, 37);
            button5.TabIndex = 20;
            button5.Text = "Vehicles";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button6.Location = new Point(612, 9);
            button6.Name = "button6";
            button6.Size = new Size(81, 37);
            button6.TabIndex = 14;
            button6.Text = "Drivers";
            button6.UseVisualStyleBackColor = true;
            // 
            // forwardButton
            // 
            forwardButton.Dock = DockStyle.Right;
            forwardButton.Location = new Point(908, 0);
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
            // LogsPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 627);
            Controls.Add(NavPanel);
            Controls.Add(textBox3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LogsPage";
            Text = "Features";
            NavPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox3;
        private Panel NavPanel;
        private Button button5;
        private Button button6;
        private Button forwardButton;
        private Button logButton;
        private Button camButton;
        private Button statusButton;
        private Button accButton;
        private Button gpsButton;
        private Button backButton;
        private Button homeButton;
        private HelpProvider helpProvider1;
    }
}
