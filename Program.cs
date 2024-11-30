using System;
using System.Windows.Forms;

namespace Ty
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 form1 = new Form1();
            Home homeForm = new Home();
            Owner ownerForm = new Owner();

            form1.Show();
            ownerForm.Show();

            Application.Run(homeForm);
        }
    }
}
