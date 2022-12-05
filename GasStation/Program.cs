using GasStation.Models;
using GasStation.Persistence.DAL;
using GasStation.View.Pump;
using GasStation.View.Sale;
using GasStation.View.User;

namespace GasStation
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
            Application.Run(new telaInicial());
        }
    }
}