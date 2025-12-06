using System.Globalization;

namespace Saleling.UI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            CultureInfo phCulture = new CultureInfo("en-PH");
            CultureInfo.DefaultThreadCurrentCulture = phCulture;
            CultureInfo.DefaultThreadCurrentUICulture = phCulture;

            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}