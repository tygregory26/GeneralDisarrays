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
    public partial class AccessoriesPage : Form
    {
        bool vehicleRunning = false;
        bool doorsLocked = true;
        bool remoteStartEnabled = true;
        bool rearDriverUp = false, rearDriverDown = false, rearPassengerUp = false, rearPassengerDown = false;
        bool frontDriverUp = false, frontDriverDown = false, frontPassengerUp = false, frontPassengerDown = false;
        String windowMid = "C:\\Users\\Razor\\source\\repos\\GeneralDisarrays\\CSCI363_GeneralDisarrays_JonsWindow1\\WIndowForSecurityPane.png";
        String windowClosed = "C:\\Users\\Razor\\source\\repos\\GeneralDisarrays\\CSCI363_GeneralDisarrays_JonsWindow1\\WIndowForSecurityPaneClosed.png";
        String windowOpen = "C:\\Users\\Razor\\source\\repos\\GeneralDisarrays\\CSCI363_GeneralDisarrays_JonsWindow1\\WIndowForSecurityPaneOpen.png";
        public AccessoriesPage()
        {
            InitializeComponent();
        }

        private void upRearDriverButton_Click(object sender, EventArgs e)
        {
            //increment window up one level per click (down to mid to up)
            if (rearDriverUp)
            {
                //already up so do nothing
            }
            else if (rearDriverDown)
            {
                rearDriverDown = false;
                pictureBoxRearDriver.Load(windowMid);
            }
            else
            {
                rearDriverUp = true;
                pictureBoxRearDriver.Load(windowClosed);
            }
        }

        private void upRearPassengerButton_Click(object sender, EventArgs e)
        {
            //increment window up one level per click (down to mid to up)
            if (rearPassengerUp)
            {
                //already up so do nothing
            }
            else if (rearPassengerDown)
            {
                rearPassengerDown = false;
                pictureBoxRearPassenger.Load(windowMid);
            }
            else
            {
                rearPassengerUp = true;
                pictureBoxRearPassenger.Load(windowClosed);
            }
        }

        private void upFrontDriverButton_Click(object sender, EventArgs e)
        {
            //increment window up one level per click (down to mid to up)
            if (frontDriverUp)
            {
                //already up so do nothing
            }
            else if (frontDriverDown)
            {
                frontDriverDown = false;
                pictureBoxFrontDriver.Load(windowMid);
            }
            else
            {
                frontDriverUp = true;
                pictureBoxFrontDriver.Load(windowClosed);
            }
        }

        private void upFrontPassengerButton_Click(object sender, EventArgs e)
        {
            //increment window up one level per click (down to mid to up)
            if (frontPassengerUp)
            {
                //already up so do nothing
            }
            else if (frontPassengerDown)
            {
                frontPassengerDown = false;
                pictureBoxFrontPassenger.Load(windowMid);
            }
            else
            {
                frontPassengerUp = true;
                pictureBoxFrontPassenger.Load(windowClosed);
            }
        }

        private void downRearDriverButton_Click(object sender, EventArgs e)
        {
            //increment window down one level per click (up to mid to down)
            if (rearDriverDown)
            {
                //already down so do nothing
            }
            else if (rearDriverUp)
            {
                rearDriverUp = false;
                pictureBoxRearDriver.Load(windowMid);
            }
            else
            {
                rearDriverDown = true;
                pictureBoxRearDriver.Load(windowOpen);
            }
        }

        private void downRearPassengerButton_Click(object sender, EventArgs e)
        {
            //increment window down one level per click (up to mid to down)
            if (rearPassengerDown)
            {
                //already down so do nothing
            }
            else if (rearPassengerUp)
            {
                rearPassengerUp = false;
                pictureBoxRearPassenger.Load(windowMid);
            }
            else
            {
                rearPassengerDown = true;
                pictureBoxRearPassenger.Load(windowOpen);
            }
        }

        private void downFrontDriverButton_Click(object sender, EventArgs e)
        {
            //increment window down one level per click (up to mid to down)
            if (frontDriverDown)
            {
                //already down so do nothing
            }
            else if (frontDriverUp)
            {
                frontDriverUp = false;
                pictureBoxFrontDriver.Load(windowMid);
            }
            else
            {
                frontDriverDown = true;
                pictureBoxFrontDriver.Load(windowOpen);
            }
        }

        private void downFrontPassengerButton_Click(object sender, EventArgs e)
        {
            //increment window down one level per click (up to mid to down)
            if (frontPassengerDown)
            {
                //already down so do nothing
            }
            else if (frontPassengerUp)
            {
                frontPassengerUp = false;
                pictureBoxFrontPassenger.Load(windowMid);
            }
            else
            {
                frontPassengerDown = true;
                pictureBoxFrontPassenger.Load(windowOpen);
            }
        }

        private void allUpButton_Click(object sender, EventArgs e)
        {
            //Change all windows to fully closed
            pictureBoxFrontPassenger.Load(windowClosed);
            pictureBoxFrontDriver.Load(windowClosed);
            pictureBoxRearPassenger.Load(windowClosed);
            pictureBoxRearDriver.Load(windowClosed);
            rearDriverDown = false;
            rearDriverUp = true;
            frontDriverDown = false;
            frontDriverUp = true;
            rearPassengerDown = false;
            rearPassengerUp = true;
            frontPassengerDown = false;
            frontPassengerUp = true;
        }

        private void allDownButton_Click(object sender, EventArgs e)
        {
            //Change all windows to fully open
            pictureBoxFrontPassenger.Load(windowOpen);
            pictureBoxFrontDriver.Load(windowOpen);
            pictureBoxRearPassenger.Load(windowOpen);
            pictureBoxRearDriver.Load(windowOpen);
            rearDriverDown = true;
            rearDriverUp = false;
            frontDriverDown = true;
            frontDriverUp = false;
            rearPassengerDown = true;
            rearPassengerUp = false;
            frontPassengerDown = true;
            frontPassengerUp = false;
        }

        private void changeRemoteStatusButton_Click(object sender, EventArgs e)
        {
            //Toggle if the remote start system is enabled or disabled and update the labels as needed
            if (remoteStartEnabled)
            {
                remoteStartEnabled = false;
                changeRemoteStatusButton.Text = ("Enable");
                remoteStartStatusTextBox.Text = ("Remote Start is: Disabled");
            }
            else
            {
                remoteStartEnabled = true;
                changeRemoteStatusButton.Text = ("Disable");
                remoteStartStatusTextBox.Text = ("Remote Start is: Enabled");
            }
        }

        private void lockDoorsButton_Click(object sender, EventArgs e)
        {
            //Change font to bold to show selected choice, unbold the other
            doorsLocked = true;
            lockDoorsButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            unlockDoorsButton.Font = new Font("Segoe UI", 20.25F);
        }

        private void unlockDoorsButton_Click(object sender, EventArgs e)
        {
            //Change font to bold to show selected choice, unbold the other
            doorsLocked = false;
            unlockDoorsButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lockDoorsButton.Font = new Font("Segoe UI", 20.25F);
        }

        private void startRemoteStartButton_Click(object sender, EventArgs e)
        {
            if (vehicleRunning)
            {
                remoteStartOutputListBox.Items.Add("Vehicle is already running...");
            }
            else
            {
                remoteStartOutputListBox.Items.Add("Attempting to start vehicle...");
                remoteStartOutputListBox.Items.Add("Vehicle started successfully!");
                vehicleRunning = true;
            }

        }

        private void stopRemoteStartButton_Click(object sender, EventArgs e)
        {
            if (vehicleRunning)
            {
                remoteStartOutputListBox.Items.Add("Attempting to stop vehicle...");
                remoteStartOutputListBox.Items.Add("Vehicle is off.");
                vehicleRunning = false;
            }
            else
            {
                remoteStartOutputListBox.Items.Add("Vehicle is not currently running...");
            }
        }
    }
}
