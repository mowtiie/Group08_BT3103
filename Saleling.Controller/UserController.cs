using Saleling.Model;
using Saleling.Repository;

namespace Saleling.Controller
{
    public class UserController
    {
        private readonly UserRepository userRepository;

        public UserController()
        {
            this.userRepository = new UserRepository();
        }

        public UserModel ValidateAdmin(string Username, string Password)
        {
            try
            {
                if (string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(Username))
                {
                    throw new Exception("Username or Password must not be empty.");
                }
                else
                {
                    Console.WriteLine("Login Successful");
                }
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return userRepository.ValidateAdmin(Username, Password);
        }

        public UserModel ValidateCashier(string Username, string Password)
        {
            try
            {
                if (string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(Username))
                {
                    throw new Exception("Username or Password must not be empty.");
                }
                else
                {
                    Console.WriteLine("Login Successful");
                }
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return userRepository.ValidateCashier(Username, Password);
        }
    }
}
