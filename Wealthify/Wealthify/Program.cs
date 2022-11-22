namespace Wealthify
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
///HEAD
            Application.Run(new Login());
/*
            Application.Run(new Laporan());
>>>>>>> d36e428fcaa79009e77b9e0ae9f0990a06808b3b
*/
        }
    }
}
