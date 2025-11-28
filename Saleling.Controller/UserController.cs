using Saleling.Model;
using Saleling.Repository;
using Saleling.Util;

namespace Saleling.Controller
{
    public class UserController
    {
        private readonly UserRepository _userRepository;

        public UserController()
        {
            this._userRepository = new UserRepository();
        }

        public async Task<List<UserModel>> GetAllCashierAsync()
        {
            return await _userRepository.GetAllCashierAsync();
        }

        public async Task<UserModel> AuthenticateAsync(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new Exception("Please enter both a username and password");
            }

            UserModel? matchedUser = await _userRepository.GetByUsernameAsync(username);
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
