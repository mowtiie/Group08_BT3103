using Saleling.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saleling.Util
{
    public class SessionUtil
    {
        private static readonly SessionUtil instance = new SessionUtil();

        private SessionUtil() { }

        public static SessionUtil Instance
        {
            get
            {
                return instance;
            }
        }

        public UserModel CurrentUser { get; private set; }

        public void SetCurrentUser(UserModel user)
        {
            this.CurrentUser = user;
        }

        public void Logout()
        {
            this.CurrentUser = null;
        }
    }
}
