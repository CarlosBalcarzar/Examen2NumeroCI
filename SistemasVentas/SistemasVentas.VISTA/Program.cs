

namespace SistemasVentas.VISTA
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
            Application.Run(new consulta1.consulta1());
            Application.Run(new consulta2.consulta2());
            Application.Run(new consulta3.consulta3());
            Application.Run(new consulta4.consulta4());
            Application.Run(new consulta5.consulta5());
            Application.Run(new consulta6.consulta6());
            Application.Run(new consulta7.consulta7());
            Application.Run(new consulta8.consulta8());
            Application.Run(new consulta9.consulta9());
            Application.Run(new consulta10.consulta10());
        }
    }
}