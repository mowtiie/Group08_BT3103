using Saleling.Model;
using Saleling.Util;
using System.Data;
using System.Data.SqlClient;

namespace Saleling.Repository
{
    public delegate UserModel ValidateUserDelegate(string Username, string Password);

    public class UserRepository
    {
        private readonly string connectionString;

        public UserRepository()
        {
            this.connectionString = DatabaseUtil.GetConnectionString();
        }

        public UserModel ValidateAdmin(string Username, string Password)
        {
            try
            {
                UserModel matchingUser = new UserModel();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Admin WHERE Username = @username AND Password = @password";
                    
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", Username);
                    command.Parameters.AddWithValue("@password", Password);


                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count >= 1)
                    {
                        matchingUser = new UserModel
                        {
                            Username = Username,
                            Password = Password
                        };

                        return matchingUser;
                    }
                }
            }

            catch (Exception EX)
            {
                Console.WriteLine(EX.Message);
            }

            return null;
        }

        public UserModel ValidateCashier(string Username, string Password)
        {
            try
            {
                UserModel matchingUser = new UserModel();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Cashier WHERE Username = @username AND Password = @password";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", Username);
                    command.Parameters.AddWithValue("@password", Password);


                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count >= 1)
                    {
                        matchingUser = new UserModel
                        {
                            Username = Username,
                            Password = Password
                        };

                        return matchingUser;
                    }
                }
            }

            catch (Exception EX)
            {
                Console.WriteLine(EX.Message);
            }

            return null;
        }
    }
}
