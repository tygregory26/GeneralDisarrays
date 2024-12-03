using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCI363_GeneralDisarrays_JonsWindow1
{
    public partial class SecurityPage : Form
    {
        //flags to track and toggle state
        bool lockedDoors = true, armedAlarm = true, enabledRemoteStart = true, alarmActivated = true;
        public Form2()
        {
            InitializeComponent();
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
    }
}
