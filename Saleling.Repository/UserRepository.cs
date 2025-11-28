using Saleling.Model;
using Saleling.Util;
using System.Data;
using System.Data.SqlClient;

namespace Saleling.Repository
{
    public class UserRepository
    {
        private readonly string connectionString;

        public UserRepository()
        {
            this.connectionString = ConfigurationUtil.GetConnectionString();
        }

        public async Task<UserModel?> GetByUsernameAsync(string username)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                await sqlConnection.OpenAsync();

                string query = "SELECT * FROM Users WHERE Username = @Username";
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@Username", username);
                    using (SqlDataReader sqlDataReader = await sqlCommand.ExecuteReaderAsync())
                    {
                        if (await sqlDataReader.ReadAsync())
                        {
                            UserModel user = new UserModel
                            {
                                UserID = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("UserID")),
                                FirstName = sqlDataReader.GetString(sqlDataReader.GetOrdinal("FirstName")),
                                LastName = sqlDataReader.GetString(sqlDataReader.GetOrdinal("LastName")),
                                Username = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Username")),
                                HashedPassword = sqlDataReader.GetString(sqlDataReader.GetOrdinal("HashedPassword")),
                                Role = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Role"))
                            };
                            return user;
                        }
                    }
                }
            }
            return null;
        }
    }
}
