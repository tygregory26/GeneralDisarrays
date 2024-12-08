using Ty;

namespace FeatureInterface
{
    public class Program : Form
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            //form1.Show();
            //ownerForm.Show();
            Application.Run(new Program());
        }

        static Status statusForm;
        static Home homeForm;
        static Owner ownerForm;
        static Drivers driverForm;
        static ManageVehicles manageVehiclesForm;
        static LogsPage logsForm;
        //AccessoryPage accForm;
        //SecurityPage securityForm;
        //CamerasPage camerasForm;
        public Program()
        {
            statusForm = new Status();
            homeForm = new Home();
            driverForm = new Drivers();
            ownerForm = new Owner();
            manageVehiclesForm = new ManageVehicles();
            logsForm = new LogsPage();
            //accForm = new AccessoryPage();
            //securityForm = new SecurityPage();
            //camerasForm = new CamerasPage();
        }

        public static void SwitchScreen(Enum newScreen)
        {
            switch (newScreen)
            {
                case ScreenPage.HOME:
                    homeForm.Show();
                    statusForm.Hide();
                    driverForm.Hide();
                    ownerForm.Hide();
                    manageVehiclesForm.Hide();
                    logsForm.Hide();
                    //accForm.Hide();
                    //securityForm.Hide();
                    //camerasForm.Hide();
                    break;
                case ScreenPage.OWNER:
                    ownerForm.Show();
                    homeForm.Hide();
                    statusForm.Hide();
                    driverForm.Hide();
                    manageVehiclesForm.Hide();
                    logsForm.Hide();
                    //accForm.Hide();
                    //securityForm.Hide();
                    //camerasForm.Hide();
                    break;
                case ScreenPage.STATUS:
                    statusForm.Show();
                    ownerForm.Hide();
                    homeForm.Hide();
                    driverForm.Hide();
                    manageVehiclesForm.Hide();
                    logsForm.Hide();
                    //accForm.Hide();
                    //securityForm.Hide();
                    //camerasForm.Hide();
                    break;
                case ScreenPage.DRIVERS:
                    driverForm.Show();
                    ownerForm.Hide();
                    homeForm.Hide();
                    statusForm.Hide();
                    manageVehiclesForm.Hide();
                    logsForm.Hide();
                    //accForm.Hide();
                    //securityForm.Hide();
                    //camerasForm.Hide();
                    break;
                case ScreenPage.VEHICLES:
                    manageVehiclesForm.Show();
                    ownerForm.Hide();
                    homeForm.Hide();
                    statusForm.Hide();
                    driverForm.Hide();
                    logsForm.Hide();
                    //accForm.Hide();
                    //securityForm.Hide();
                    //camerasForm.Hide();
                    break;
                case ScreenPage.LOGS:
                    logsForm.Show();
                    ownerForm.Hide();
                    homeForm.Hide();
                    statusForm.Hide();
                    driverForm.Hide();
                    manageVehiclesForm.Hide();
                    //accForm.Hide();
                    //securityForm.Hide();
                    //camerasForm.Hide();
                    break;
                case ScreenPage.CAMERAS:
                    //camerasForm.Show();
                    ownerForm.Hide();
                    homeForm.Hide();
                    statusForm.Hide();
                    driverForm.Hide();
                    manageVehiclesForm.Hide();
                    logsForm.Hide();
                    //accForm.Hide();
                    //securityForm.Hide();
                    break;
                case ScreenPage.ACCESSORY:
                    //accForm.Show();
                    ownerForm.Hide();
                    homeForm.Hide();
                    statusForm.Hide();
                    driverForm.Hide();
                    manageVehiclesForm.Hide();
                    logsForm.Hide();
                    //securityForm.Hide();
                    //camerasForm.Hide();
                    break;
                case ScreenPage.SECURITY:
                    //securityForm.Show();
                    ownerForm.Hide();
                    homeForm.Hide();
                    statusForm.Hide();
                    driverForm.Hide();
                    manageVehiclesForm.Hide();
                    logsForm.Hide();
                    //accForm.Hide();
                    //camerasForm.Hide();
                    break;
            }
        }


        public enum ScreenPage
        {
            HOME,
            OWNER,
            STATUS,
            DRIVERS,
            VEHICLES,
            LOGS,
            CAMERAS,
            ACCESSORY,
            SECURITY
        }
    }
}