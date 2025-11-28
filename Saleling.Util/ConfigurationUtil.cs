using System.Configuration;

namespace Saleling.Util
{
    public class ConfigurationUtil
    {
        private static readonly string CONNECTION_STRING_NAME = "SalelingDB";

        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings[CONNECTION_STRING_NAME].ConnectionString;
        }
    }
}
