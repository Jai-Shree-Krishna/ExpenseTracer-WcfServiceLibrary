using ExpenseTracer_WcfServiceLibrary.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ExpenseTracer_WcfServiceLibrary
{
    public class AuthService : IAuthService
    {
        string connectionString = @"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ExpenseTracker;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        int IAuthService.SignIn(string email, string password)
        {
            int userId = -1;

            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT Id FROM User WHERE EmailId = @Email AND Password = @Password";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Password", password);

            connection.Open();
            object result = command.ExecuteScalar();
            connection.Close();
            if (result != null && result != DBNull.Value)
            {
                userId = (int)result;
            }
            

            return userId;
        }


        DataSet IAuthService.GetAllUser()
        {
            SqlDataAdapter da = new SqlDataAdapter("select id, emailid, password, username from user", connectionString);
            
            DataSet ds = new DataSet();

            da.Fill(ds, "user");
            return ds;
        }

        int IAuthService.SignUp(string email, string password, string username)
        {
            int userId = -1;
            
            Console.WriteLine("-*/**/*/*/*/*/*//*/*/*/*/*/*/*/*/*/*/*/**/*/*/*/*/");
            Console.WriteLine(email, password, username);
            Console.WriteLine("-*/**/*/*/*/*/*//*/*/*/*/*/*/*/*/*/*/*/**/*/*/*/*/");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO User (EmailId, Password, Username) OUTPUT INSERTED.UserId VALUES (@Email, @Password, @Username)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Username", username);

                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    userId = (int)result;
                }
            }

            return userId;
        }
    }
}
