namespace Saleling.Util
{
    public class SecurityUtil
    {
        private const int DEFAULT_WORK_FACTOR = 12;

        public static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password, DEFAULT_WORK_FACTOR);
        }

        public static bool VerifyPassword(string plainTextPassword, string storedHash)
        {
            return BCrypt.Net.BCrypt.Verify(plainTextPassword, storedHash);
        }
    }
}
