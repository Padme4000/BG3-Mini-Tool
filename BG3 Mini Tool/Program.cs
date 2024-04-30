namespace BG3_Mini_Tool
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

            // Configure the application to properly scale on high DPI displays by setting the HighDpiMode to DpiUnaware.
            // This ensures consistent scaling behavior without adjusting for DPI changes.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetHighDpiMode(HighDpiMode.DpiUnaware);

            Application.Run(new Form1());
        }
    }
}