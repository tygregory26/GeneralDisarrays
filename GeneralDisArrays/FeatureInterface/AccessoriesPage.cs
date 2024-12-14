//using CSCI363_GeneralDisarrays_JonsWindow1.Properties;
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
    public partial class AccessoriesPage : Form
    {
        MainWindow mainPage;
        bool vehicleRunning = false;
        bool doorsLocked = true;
        bool remoteStartEnabled = true;
        bool rearDriverUp = false, rearDriverDown = false, rearPassengerUp = false, rearPassengerDown = false;
        bool frontDriverUp = false, frontDriverDown = false, frontPassengerUp = false, frontPassengerDown = false;

        string startupPath = (Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName);
        string windowMid = "\\Resources\\WIndowForSecurityPane.png";
        string windowClosed = "\\Resources\\WIndowForSecurityPaneClosed.png";
        string windowOpen = "\\Resources\\WIndowForSecurityPaneOpen.png";

        //string windowMid = @"C:\Users\Razor\source\repos\GeneralDisarrays\CSCI363_GeneralDisarrays_JonsWindow1\WIndowForSecurityPane.png";
        //string windowClosed = @"C:\Users\Razor\source\repos\GeneralDisarrays\CSCI363_GeneralDisarrays_JonsWindow1\WIndowForSecurityPaneClosed.png";
        //string windowOpen = @"C:\Users\Razor\source\repos\GeneralDisarrays\CSCI363_GeneralDisarrays_JonsWindow1\WIndowForSecurityPaneOpen.png";

        //string fullPathWindowMid = (startupPath + windowMid);

        public AccessoriesPage(MainWindow mainPage)
        {

            InitializeComponent();
            this.mainPage = mainPage;
            pictureBoxFrontPassenger.Load(startupPath + windowMid);
            pictureBoxFrontDriver.Load(startupPath + windowMid);
            pictureBoxRearPassenger.Load(startupPath + windowMid);
            pictureBoxRearDriver.Load(startupPath + windowMid);
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
                pictureBoxRearDriver.Load(startupPath + windowMid);
            }
            else
            {
                rearDriverUp = true;
                pictureBoxRearDriver.Load(startupPath + windowClosed);
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
                pictureBoxRearPassenger.Load(startupPath + windowMid);
            }
            else
            {
                rearPassengerUp = true;
                pictureBoxRearPassenger.Load(startupPath + windowClosed);
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
                pictureBoxFrontDriver.Load(startupPath + windowMid);
            }
            else
            {
                frontDriverUp = true;
                pictureBoxFrontDriver.Load(startupPath + windowClosed);
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
                pictureBoxFrontPassenger.Load(startupPath + windowMid);
            }
            else
            {
                frontPassengerUp = true;
                pictureBoxFrontPassenger.Load(startupPath + windowClosed);
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
                pictureBoxRearDriver.Load(startupPath + windowMid);
            }
            else
            {
                rearDriverDown = true;
                pictureBoxRearDriver.Load(startupPath + windowOpen);
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
                pictureBoxRearPassenger.Load(startupPath + windowMid);
            }
            else
            {
                rearPassengerDown = true;
                pictureBoxRearPassenger.Load(startupPath + windowOpen);
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
                pictureBoxFrontDriver.Load(startupPath + windowMid);
            }
            else
            {
                frontDriverDown = true;
                pictureBoxFrontDriver.Load(startupPath + windowOpen);
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
                pictureBoxFrontPassenger.Load(startupPath + windowMid);
            }
            else
            {
                frontPassengerDown = true;
                pictureBoxFrontPassenger.Load(startupPath + windowOpen);
            }
        }

        private void allUpButton_Click(object sender, EventArgs e)
        {
            //Change all windows to fully closed
            pictureBoxFrontPassenger.Load(startupPath + windowClosed);
            pictureBoxFrontDriver.Load(startupPath + windowClosed);
            pictureBoxRearPassenger.Load(startupPath + windowClosed);
            pictureBoxRearDriver.Load(startupPath + windowClosed);
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
            pictureBoxFrontPassenger.Load(startupPath + windowOpen);
            pictureBoxFrontDriver.Load(startupPath + windowOpen);
            pictureBoxRearPassenger.Load(startupPath + windowOpen);
            pictureBoxRearDriver.Load(startupPath + windowOpen);
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
            lockDoorsButton.Text = ("Locked");
            unlockDoorsButton.Text = ("Unlock");
            lockDoorsButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            unlockDoorsButton.Font = new Font("Segoe UI", 20.25F);
        }

        private void unlockDoorsButton_Click(object sender, EventArgs e)
        {
            //Change font to bold to show selected choice, unbold the other
            doorsLocked = false;
            lockDoorsButton.Text = ("Lock");
            unlockDoorsButton.Text = ("Unlocked");
            unlockDoorsButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lockDoorsButton.Font = new Font("Segoe UI", 20.25F);
        }

        private void startRemoteStartButton_Click(object sender, EventArgs e)
        {
            //remoteStartOutputListBox.Items.Add(startupPath + windowMid); //TEST CODE
            if (remoteStartEnabled)
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
            else
            {
                remoteStartOutputListBox.Items.Add("Remote start is disabled.");
            }

        }

        private void stopRemoteStartButton_Click(object sender, EventArgs e)
        {
            //remoteStartOutputListBox.Items.Add(startupPath + windowMid); //TEST CODE
            if (remoteStartEnabled)
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
            else
            {
                remoteStartOutputListBox.Items.Add("Remote start is disabled.");
            }
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

