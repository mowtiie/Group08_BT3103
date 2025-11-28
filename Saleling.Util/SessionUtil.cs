using Saleling.Model;

namespace Saleling.Util
{
    public class SessionUtil
    {
        private static readonly SessionUtil instance = new SessionUtil();

        private readonly object lockObject = new object();

        private UserModel currentUser;

        private SessionUtil() { }

        public static SessionUtil Instance { get { return instance; } }

        public UserModel CurrentUser
        {
            get { lock (lockObject) { return currentUser; } }
        }

        public void SetLoggedInUser(UserModel account)
        {
            lock (lockObject)
            {
                currentUser = account;
            }
        }

        public void Logout()
        {
            lock (lockObject)
            {
                currentUser = null;
            }
        }
    }
}
