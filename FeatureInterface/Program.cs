using Ty;

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

            Status statusForm = new Status();
            Home homeForm = new Home();
            Owner ownerForm = new Owner();
            Drivers driverForm = new Drivers();
            ManageVehicles manageVehiclesForm = new ManageVehicles();

            //form1.Show();
            //ownerForm.Show();
            Application.Run(driverForm);
        }
    }

    enum Screen
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