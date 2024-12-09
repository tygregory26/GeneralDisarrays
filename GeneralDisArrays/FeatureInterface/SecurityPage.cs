using FeatureInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeatureInterface
{
    public partial class SecurityPage : Form
    {
        MainWindow mainPage;
        //flags to track and toggle state
        bool lockedDoors = true, armedAlarm = true, enabledRemoteStart = true, alarmActivated = true;
        public SecurityPage(MainWindow mainPage)
        {
            InitializeComponent();
            this.mainPage = mainPage;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lockedDoors)
            {
                DoorLockStatusText.Text = ("Doors are unlocked");
                lockedDoors = false;
                LockUnlockButton.Text = ("Lock");
            }
            else
            {
                DoorLockStatusText.Text = ("Doors are locked");
                lockedDoors = true;
                LockUnlockButton.Text = ("Unlock");
            }
        }

        private void ArmDisarmButton_Click(object sender, EventArgs e)
        {
            if (armedAlarm)
            {
                AlarmStatusText.Text = ("Alarm is disarmed");
                armedAlarm = false;
                ArmDisarmButton.Text = ("Arm");
            }
            else
            {
                AlarmStatusText.Text = ("Alarm is armed");
                armedAlarm = true;
                ArmDisarmButton.Text = ("Disarm");
            }
        }

        private void EnableDisableButton_Click(object sender, EventArgs e)
        {
            if (enabledRemoteStart)
            {
                RemoteStartStatusText.Text = ("Remote start is disabled");
                enabledRemoteStart = false;
                EnableDisableButton.Text = ("Enable");
            }
            else
            {
                RemoteStartStatusText.Text = ("Remote start is enabled");
                enabledRemoteStart = true;
                EnableDisableButton.Text = ("Disable");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            alarmActivated = false;
            SilenceAlarm.Hide();
            AlarmingTextIndicator.Hide();
            NotAlarmingTextIndicator.Show();
        }

        private void TriggerAlarmButton_Click(object sender, EventArgs e)
        {
            alarmActivated = true;
            SilenceAlarm.Show();
            AlarmingTextIndicator.Show();
            NotAlarmingTextIndicator.Hide();
        }

        private void VehShortcutButton_Click(object sender, EventArgs e)
        {
            MainWindow.ScreenPage displayScreen = MainWindow.ScreenPage.VEHICLES;
            mainPage.SwitchScreen(displayScreen);
        }

        private void gpsButton_Click(object sender, EventArgs e)
        {
            MainWindow.ScreenPage display = MainWindow.ScreenPage.GPS;
            mainPage.SwitchScreen(display);
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            MainWindow.ScreenPage displayScreen = MainWindow.ScreenPage.HOME;
            mainPage.SwitchScreen(displayScreen);
        }

        private void accButton_Click(object sender, EventArgs e)
        {
            MainWindow.ScreenPage displayScreen = MainWindow.ScreenPage.ACCESSORY;
            mainPage.SwitchScreen(displayScreen);
        }

        private void vehNavButton_Click(object sender, EventArgs e)
        {
            MainWindow.ScreenPage displayScreen = MainWindow.ScreenPage.VEHICLES;
            mainPage.SwitchScreen(displayScreen);
        }

        private void secNavButton_Click(object sender, EventArgs e)
        {
            MainWindow.ScreenPage displayScreen = MainWindow.ScreenPage.SECURITY;
            mainPage.SwitchScreen(displayScreen);
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            MainWindow.ScreenPage displayScreen = MainWindow.ScreenPage.LOGS;
            mainPage.SwitchScreen(displayScreen);
        }

        private void statusButton_Click(object sender, EventArgs e)
        {
            MainWindow.ScreenPage displayScreen = MainWindow.ScreenPage.STATUS;
            mainPage.SwitchScreen(displayScreen);
        }

        private void camButton_Click(object sender, EventArgs e)
        {
            MainWindow.ScreenPage displayScreen = MainWindow.ScreenPage.CAMERAS;
            mainPage.SwitchScreen(displayScreen);
        }

        private void driverNavButton_Click(object sender, EventArgs e)
        {
            MainWindow.ScreenPage displayScreen = MainWindow.ScreenPage.DRIVERS;
            mainPage.SwitchScreen(displayScreen);
        }
    }
}
