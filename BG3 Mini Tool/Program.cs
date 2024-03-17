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

            // Instead of using the default font and display settings,
            // we set the high DPI mode to DpiUnaware to allow the application to scale properly.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetHighDpiMode(HighDpiMode.DpiUnaware);
            
            Application.Run(new Form1());
        }
    }
}