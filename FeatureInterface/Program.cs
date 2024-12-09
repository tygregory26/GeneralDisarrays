

namespace FeatureInterface
{
    internal static class Program
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

            MainWindow mainPage = new MainWindow();
       
            Application.Run(mainPage.driversForm);
        }
    }

    public class MainWindow
    {
        public Status statusForm;
        public Home homeForm;
        public GPS gpsForm;
        public Drivers driversForm;
        public ManageVehicles manageVehiclesForm;
        public LogsPage logsForm;
        //AccessoryPage accForm;
        //SecurityPage securityForm;
        //CamerasPage camerasForm;

        public MainWindow()
        {
            statusForm = new Status(this);
            homeForm = new Home(this);
            gpsForm = new GPS();
            driversForm = new Drivers(this);
            driversForm.Show();
            manageVehiclesForm = new ManageVehicles(this);
            logsForm = new LogsPage(this);
            //accForm = new AccessoryPage();
            //securityForm = new SecurityPage();
            //camerasForm = new CamerasPage();
        }

        public void SwitchScreen(Enum newScreen)
        {
            switch (newScreen)
            {
                case ScreenPage.HOME:
                    homeForm.Show();
                    statusForm.Hide();
                    driversForm.Hide();
                    gpsForm.Hide();
                    manageVehiclesForm.Hide();
                    logsForm.Hide();
                    //accForm.Hide();
                    //securityForm.Hide();
                    //camerasForm.Hide();
                    break;
                case ScreenPage.GPS:
                    gpsForm.Show();
                    homeForm.Hide();
                    statusForm.Hide();
                    driversForm.Hide();
                    manageVehiclesForm.Hide();
                    logsForm.Hide();
                    //accForm.Hide();
                    //securityForm.Hide();
                    //camerasForm.Hide();
                    break;
                case ScreenPage.STATUS:
                    statusForm.Show();
                    gpsForm.Hide();
                    homeForm.Hide();
                    driversForm.Hide();
                    manageVehiclesForm.Hide();
                    logsForm.Hide();
                    //accForm.Hide();
                    //securityForm.Hide();
                    //camerasForm.Hide();
                    break;
                case ScreenPage.DRIVERS:
                    driversForm.Show();
                    gpsForm.Hide();
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
                    gpsForm.Hide();
                    homeForm.Hide();
                    statusForm.Hide();
                    driversForm.Hide();
                    logsForm.Hide();
                    //accForm.Hide();
                    //securityForm.Hide();
                    //camerasForm.Hide();
                    break;
                case ScreenPage.LOGS:
                    logsForm.Show();
                    gpsForm.Hide();
                    homeForm.Hide();
                    statusForm.Hide();
                    driversForm.Hide();
                    manageVehiclesForm.Hide();
                    //accForm.Hide();
                    //securityForm.Hide();
                    //camerasForm.Hide();
                    break;
                case ScreenPage.CAMERAS:
                    //camerasForm.Show();
                    gpsForm.Hide();
                    homeForm.Hide();
                    statusForm.Hide();
                    driversForm.Hide();
                    manageVehiclesForm.Hide();
                    logsForm.Hide();
                    //accForm.Hide();
                    //securityForm.Hide();
                    break;
                case ScreenPage.ACCESSORY:
                    //accForm.Show();
                    gpsForm.Hide();
                    homeForm.Hide();
                    statusForm.Hide();
                    driversForm.Hide();
                    manageVehiclesForm.Hide();
                    logsForm.Hide();
                    //securityForm.Hide();
                    //camerasForm.Hide();
                    break;
                case ScreenPage.SECURITY:
                    //securityForm.Show();
                    gpsForm.Hide();
                    homeForm.Hide();
                    statusForm.Hide();
                    driversForm.Hide();
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
            GPS,
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