using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ty;

namespace FeatureInterface
{
    public partial class Drivers : Form
    {
        MainWindow mainPage;
        public Drivers(MainWindow mainPage)
        {
            this.mainPage = mainPage;
            InitializeComponent();
        }

        private void geoFencShortCutButton_Click(object sender, EventArgs e)
        {
            MainWindow.ScreenPage displayScreen = MainWindow.ScreenPage.GPS;
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

        private void button2_Click(object sender, EventArgs e)
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

        private void VehShortcutButton_Click(object sender, EventArgs e)
        {
            MainWindow.ScreenPage displayScreen = MainWindow.ScreenPage.VEHICLES;
            mainPage.SwitchScreen(displayScreen);
        }
    }
}
