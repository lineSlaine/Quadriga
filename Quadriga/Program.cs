namespace Quadriga
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
            if (DatabaseHelper.SetDatabase())
            {
                //Authentication a = new Authentication();
                //a.M();
                Application.Run(new FormMain());
            }
            else MessageBox.Show("Error");

        }
    }
}