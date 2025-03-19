using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADO.NET
{
    class Connector
    {
        const string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;" +
                "Initial Catalog=Movies;" +
                "Integrated Security=True;" +
                "Connect Timeout=30;" +
                "Encrypt=False;" +
                "TrustServerCertificate=False;" +
                "ApplicationIntent=ReadWrite;" +
                "MultiSubnetFailover=False";
       static SqlConnection connection;

        static Connector()
        {
            Console.WriteLine(connectionString);
            connection = new SqlConnection(connectionString);
        }
        public static void SelectMovies()
        {
           string cmd = "SELECT title, release_date, FORMATMESSAGE(N'%s %s', first_name, last_name) FROM Movies, Directors  WHERE director = director_id";
           SqlCommand command = new SqlCommand(cmd, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                int padding = 30;
                Console.WriteLine("==============================================================================");
                for (int i = 0; i < reader.FieldCount; i++)
                    Console.Write(reader.GetName(i).PadRight(padding));
                Console.WriteLine();
                Console.WriteLine("==============================================================================");
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write(reader[i].ToString().PadRight(padding));
                    }
                    Console.WriteLine();
                }

                   
            }
            reader.Close();
            connection.Close();
            Console.Read();

        }
    }
    
    
}
