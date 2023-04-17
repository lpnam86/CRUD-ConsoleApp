using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CRUD_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            SqlConnection sqlConnection;
            String connectionString = @"Data Source=NARPAVI;Initial Catalog=CoDb;Integrated Security=True";
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                Console.WriteLine("Database connected succesfully!");
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }

            Console.ReadKey();
        }
    }
}
