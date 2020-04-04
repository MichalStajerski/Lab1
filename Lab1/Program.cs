using System;
using System.Text.Json;
using System.Data.SqlClient;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new DB();
            var connectionString = "Data Source=(localdb)/MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using var connection = new SqlConnection(connectionString);

            connection.Open();

            db.Select(connection);
            db.Insert(connection, 11, "Bielsko");
            db.Delete(connection,11);

            connection.Close();
        }
    }
}
