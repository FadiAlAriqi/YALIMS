using YALIMS.Controller;

namespace YALIMS
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Connector.host = "localhost";
            Connector.port = "8080";
            ApplicationConfiguration.Initialize();
            Application.Run(new SelectLogin());
        }
    }
}