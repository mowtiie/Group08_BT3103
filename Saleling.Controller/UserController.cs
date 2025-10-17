using Saleling.Model;
using Saleling.Repository;
using Saleling.Util;

namespace Saleling.Controller
{
    public class UserController
    {
        private readonly UserRepository userRepository;

        public UserController()
        {
            this.userRepository = new UserRepository();
        }

        public async Task<UserModel> AuthenticateUserAsync(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new Exception("Please enter both a username and password");
            }

            UserModel? matchedUser = await userRepository.GetByUsernameAsync(username);
            if (matchedUser == null)
            {
                throw new Exception("The user does not exist");
            }

            bool didpPasswordMatch = SecurityUtil.VerifyPassword(password, matchedUser.HashedPassword);
            if (didpPasswordMatch)
            {
                return matchedUser;
            }
            else
            {
                throw new Exception("Invalid credentials");
            }
        }
    }
}
