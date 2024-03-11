using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracer_WcfServiceLibrary
{
    public class ExpenseService : IExpenseService
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ExpenseTracker;Integrated Security=True;Connect Timeout=30000;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public bool AddExpense(float amount, string category, string description, int userId, string paymentMethod)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Expense (Amount, Category, Description, UserId, PaymentMethod) VALUES (@Amount, @Category, @Description, @UserId, @PaymentMethod)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Amount", amount);
                command.Parameters.AddWithValue("@Category", category);
                command.Parameters.AddWithValue("@Description", description);
                command.Parameters.AddWithValue("@UserId", userId);
                command.Parameters.AddWithValue("@PaymentMethod", paymentMethod);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                return true;
            }
        }

        public DataSet GetAllExpenses()
        {
            DataSet dataSet = new DataSet();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Expense";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dataSet);
            }
            return dataSet;
        }

        public DataSet GetExpensesByUserId(int userId)
        {
            DataSet dataSet = new DataSet();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Expense WHERE UserId = @UserId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", userId);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataSet);
            }
            return dataSet;
        }
    }
}
