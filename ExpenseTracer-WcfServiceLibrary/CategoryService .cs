using ExpenseTracer_WcfServiceLibrary.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracer_WcfServiceLibrary
{
    public class CategoryService : ICategoryService
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ExpenseTracker;Integrated Security=True;Connect Timeout=30000;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        bool ICategoryService.AddCategory(string category, int UserId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO [Category] (CategoryName, UserId) VALUES (@CategoryName, @UserId)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CategoryName", category);
                command.Parameters.AddWithValue("@UserId", UserId);
                connection.Open();
                command.ExecuteNonQuery();
            }

            return true;
        }

        DataSet ICategoryService.GetAllCategories()
        {
            DataSet dataSet = new DataSet();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT UserId, CategoryName FROM [Category]";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                connection.Open();
                adapter.Fill(dataSet);
            }
            return dataSet;
        }

        DataSet ICategoryService.GetCategories(int userId)
        {
            DataSet dataSet = new DataSet();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT UserId, CategoryName FROM [Category] WHERE UserId = @UserId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", userId);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                connection.Open();
                adapter.Fill(dataSet);
            }
            return dataSet;
        }

    }
}
