using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Lab1
{
    class DB
    {
        public void Select(SqlConnection connection)
        {
            var query = "SELECT * FROM Customers";
            var command = new SqlCommand(query, connection);
            using var reader = command.ExecuteReader(); 

            while (reader.Read())
            {
                Console.WriteLine(reader["CompanyName"]);

            }
        }

        public void Insert(SqlConnection connection, int id, string description)
        {
            var query = "INSERT INTO region(regionId, regionDescription) VALUES (@id,@description";

            var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("id", id);
            command.Parameters.AddWithValue("description", description);

            var affected = command.ExecuteNonQuery();
            Console.WriteLine($"{affected} rows affected");

        }

        public void Delete(SqlConnection connection, int id)
        {
            var query = "DELETE FROM Customers(FROM Custometrs WHERE regionId =id)";
            var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("id", id);

            var affected = command.ExecuteNonQuery();
            Console.WriteLine($"{affected} rows affected");



        }
    }


}
