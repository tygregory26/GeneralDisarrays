namespace FeatureInterface
{
    partial class SecurityPage
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
            tableLayoutPanel4 = new TableLayoutPanel();
            EnableDisableButton = new Button();
            RemoteStartStatusText = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            ArmDisarmButton = new Button();
            AlarmStatusText = new TextBox();
            textBox1 = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            DoorLockStatusText = new TextBox();
            LockUnlockButton = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            AlarmingTextIndicator = new TextBox();
            NotAlarmingTextIndicator = new TextBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            TriggerAlarmButton = new Button();
            SilenceAlarm = new Button();
            tableLayoutPanel1.SuspendLayout();
            NavPanel.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(NavPanel, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 4);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 3);
            tableLayoutPanel1.Controls.Add(textBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 1, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel6, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0000057F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(932, 553);
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
            NavPanel.Location = new Point(3, 3);
            NavPanel.Name = "NavPanel";
            NavPanel.Size = new Size(926, 49);
            NavPanel.TabIndex = 14;
            // 
            // secNavButton
            // 
            secNavButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            secNavButton.Location = new Point(786, 9);
            secNavButton.Name = "secNavButton";
            secNavButton.Size = new Size(81, 37);
            secNavButton.TabIndex = 21;
            secNavButton.Text = "Security";
            secNavButton.UseVisualStyleBackColor = true;
            secNavButton.Click += secNavButton_Click;
            // 
            // vehNavButton
            // 
            vehNavButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            vehNavButton.Location = new Point(699, 9);
            vehNavButton.Name = "vehNavButton";
            vehNavButton.Size = new Size(81, 37);
            vehNavButton.TabIndex = 20;
            vehNavButton.Text = "Vehicles";
            vehNavButton.UseVisualStyleBackColor = true;
            vehNavButton.Click += vehNavButton_Click;
            // 
            // driverNavButton
            // 
            driverNavButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            driverNavButton.Location = new Point(612, 9);
            driverNavButton.Name = "driverNavButton";
            driverNavButton.Size = new Size(81, 37);
            driverNavButton.TabIndex = 14;
            driverNavButton.Text = "Drivers";
            driverNavButton.UseVisualStyleBackColor = true;
            driverNavButton.Click += driverNavButton_Click;
            // 
            // forwardButton
            // 
            forwardButton.Dock = DockStyle.Right;
            forwardButton.Location = new Point(880, 0);
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
            logButton.Click += logButton_Click;
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
            camButton.Click += camButton_Click;
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
            statusButton.Click += statusButton_Click;
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
            accButton.Click += accButton_Click;
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
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(EnableDisableButton, 0, 1);
            tableLayoutPanel4.Controls.Add(RemoteStartStatusText, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 362);
            tableLayoutPanel4.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(460, 88);
            tableLayoutPanel4.TabIndex = 8;
            // 
            // EnableDisableButton
            // 
            EnableDisableButton.Dock = DockStyle.Fill;
            EnableDisableButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EnableDisableButton.Location = new Point(3, 47);
            EnableDisableButton.Name = "EnableDisableButton";
            EnableDisableButton.Size = new Size(454, 38);
            EnableDisableButton.TabIndex = 6;
            EnableDisableButton.Text = "Disable";
            EnableDisableButton.UseVisualStyleBackColor = true;
            EnableDisableButton.Click += EnableDisableButton_Click;
            // 
            // RemoteStartStatusText
            // 
            RemoteStartStatusText.Dock = DockStyle.Fill;
            RemoteStartStatusText.Font = new Font("Segoe UI", 12F);
            RemoteStartStatusText.Location = new Point(3, 3);
            RemoteStartStatusText.Name = "RemoteStartStatusText";
            RemoteStartStatusText.ReadOnly = true;
            RemoteStartStatusText.Size = new Size(454, 34);
            RemoteStartStatusText.TabIndex = 3;
            RemoteStartStatusText.TabStop = false;
            RemoteStartStatusText.Text = "Remote start is enabled";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(ArmDisarmButton, 0, 1);
            tableLayoutPanel3.Controls.Add(AlarmStatusText, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 266);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(460, 88);
            tableLayoutPanel3.TabIndex = 7;
            // 
            // ArmDisarmButton
            // 
            ArmDisarmButton.Dock = DockStyle.Fill;
            ArmDisarmButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ArmDisarmButton.Location = new Point(3, 47);
            ArmDisarmButton.Name = "ArmDisarmButton";
            ArmDisarmButton.Size = new Size(454, 38);
            ArmDisarmButton.TabIndex = 6;
            ArmDisarmButton.Text = "Disarm";
            ArmDisarmButton.UseVisualStyleBackColor = true;
            ArmDisarmButton.Click += ArmDisarmButton_Click;
            // 
            // AlarmStatusText
            // 
            AlarmStatusText.Dock = DockStyle.Fill;
            AlarmStatusText.Font = new Font("Segoe UI", 12F);
            AlarmStatusText.Location = new Point(3, 3);
            AlarmStatusText.Name = "AlarmStatusText";
            AlarmStatusText.ReadOnly = true;
            AlarmStatusText.Size = new Size(454, 34);
            AlarmStatusText.TabIndex = 2;
            AlarmStatusText.TabStop = false;
            AlarmStatusText.Text = "Alarm is armed";
            AlarmStatusText.TextChanged += textBox3_TextChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            tableLayoutPanel1.SetColumnSpan(textBox1, 2);
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(3, 74);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(926, 52);
            textBox1.TabIndex = 0;
            textBox1.TabStop = false;
            textBox1.Text = "Security";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(DoorLockStatusText, 0, 0);
            tableLayoutPanel2.Controls.Add(LockUnlockButton, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 170);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(460, 88);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // DoorLockStatusText
            // 
            DoorLockStatusText.Dock = DockStyle.Fill;
            DoorLockStatusText.Font = new Font("Segoe UI", 12F);
            DoorLockStatusText.Location = new Point(3, 3);
            DoorLockStatusText.Name = "DoorLockStatusText";
            DoorLockStatusText.ReadOnly = true;
            DoorLockStatusText.Size = new Size(454, 34);
            DoorLockStatusText.TabIndex = 1;
            DoorLockStatusText.TabStop = false;
            DoorLockStatusText.Text = "Doors are locked";
            // 
            // LockUnlockButton
            // 
            LockUnlockButton.Dock = DockStyle.Fill;
            LockUnlockButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LockUnlockButton.Location = new Point(3, 47);
            LockUnlockButton.Name = "LockUnlockButton";
            LockUnlockButton.Size = new Size(454, 38);
            LockUnlockButton.TabIndex = 5;
            LockUnlockButton.Text = "Unlock";
            LockUnlockButton.UseVisualStyleBackColor = true;
            LockUnlockButton.Click += button1_Click;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(AlarmingTextIndicator, 0, 1);
            tableLayoutPanel5.Controls.Add(NotAlarmingTextIndicator, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(469, 266);
            tableLayoutPanel5.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(460, 88);
            tableLayoutPanel5.TabIndex = 9;
            // 
            // AlarmingTextIndicator
            // 
            AlarmingTextIndicator.BackColor = Color.Red;
            AlarmingTextIndicator.Dock = DockStyle.Fill;
            AlarmingTextIndicator.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AlarmingTextIndicator.Location = new Point(3, 47);
            AlarmingTextIndicator.Name = "AlarmingTextIndicator";
            AlarmingTextIndicator.ReadOnly = true;
            AlarmingTextIndicator.Size = new Size(454, 34);
            AlarmingTextIndicator.TabIndex = 5;
            AlarmingTextIndicator.Text = "Alarming";
            AlarmingTextIndicator.TextAlign = HorizontalAlignment.Center;
            AlarmingTextIndicator.Visible = false;
            // 
            // NotAlarmingTextIndicator
            // 
            NotAlarmingTextIndicator.BackColor = Color.FromArgb(0, 192, 0);
            NotAlarmingTextIndicator.Dock = DockStyle.Fill;
            NotAlarmingTextIndicator.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NotAlarmingTextIndicator.ForeColor = SystemColors.WindowText;
            NotAlarmingTextIndicator.Location = new Point(3, 3);
            NotAlarmingTextIndicator.Name = "NotAlarmingTextIndicator";
            NotAlarmingTextIndicator.ReadOnly = true;
            NotAlarmingTextIndicator.Size = new Size(454, 34);
            NotAlarmingTextIndicator.TabIndex = 4;
            NotAlarmingTextIndicator.Text = "Not Alarming";
            NotAlarmingTextIndicator.TextAlign = HorizontalAlignment.Center;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(TriggerAlarmButton, 0, 0);
            tableLayoutPanel6.Controls.Add(SilenceAlarm, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(469, 362);
            tableLayoutPanel6.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(460, 88);
            tableLayoutPanel6.TabIndex = 11;
            // 
            // TriggerAlarmButton
            // 
            TriggerAlarmButton.BackColor = SystemColors.Window;
            TriggerAlarmButton.Dock = DockStyle.Fill;
            TriggerAlarmButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TriggerAlarmButton.ForeColor = Color.Red;
            TriggerAlarmButton.Location = new Point(3, 3);
            TriggerAlarmButton.Name = "TriggerAlarmButton";
            TriggerAlarmButton.Size = new Size(224, 38);
            TriggerAlarmButton.TabIndex = 11;
            TriggerAlarmButton.Text = "Trigger Alarm";
            TriggerAlarmButton.UseVisualStyleBackColor = false;
            TriggerAlarmButton.Click += TriggerAlarmButton_Click;
            // 
            // SilenceAlarm
            // 
            SilenceAlarm.BackColor = Color.Yellow;
            SilenceAlarm.Dock = DockStyle.Fill;
            SilenceAlarm.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SilenceAlarm.Location = new Point(233, 3);
            SilenceAlarm.Name = "SilenceAlarm";
            SilenceAlarm.Size = new Size(224, 38);
            SilenceAlarm.TabIndex = 10;
            SilenceAlarm.Text = "Silence Alarm";
            SilenceAlarm.UseVisualStyleBackColor = false;
            SilenceAlarm.Visible = false;
            SilenceAlarm.Click += button4_Click;
            // 
            // SecurityPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 553);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SecurityPage";
            Text = "Form2";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            NavPanel.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBox1;
        private TextBox DoorLockStatusText;
        private TextBox AlarmStatusText;
        private TextBox RemoteStartStatusText;
        private TextBox NotAlarmingTextIndicator;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel3;
        private Button LockUnlockButton;
        private TableLayoutPanel tableLayoutPanel2;
        private Button EnableDisableButton;
        private Button ArmDisarmButton;
        private TableLayoutPanel tableLayoutPanel5;
        private TextBox AlarmingTextIndicator;
        private TableLayoutPanel tableLayoutPanel6;
        private Button SilenceAlarm;
        private Button TriggerAlarmButton;
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