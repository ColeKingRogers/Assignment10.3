using Assignment10._3.Data;
using Microsoft.EntityFrameworkCore;

namespace Assignment10._3
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
            Records.context = new CarsContext();
            Records.context.Database.EnsureCreated();
            Records.context.Manufacturer.Load();
            Records.context.Cars.Load();
            Application.Run(new MainUi());
        }
    }
}