﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
namespace ADO.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1) Берем строку подключения
            //const int PADDING = 35;
            //const string CONECTION_STRING = 
            //    "Data Source=(localdb)\\MSSQLLocalDB;" +
            //    "Initial Catalog=Movies;" +
            //    "Integrated Security=True;" +
            //    "Connect Timeout=30;" +
            //    "Encrypt=False;" +
            //    "TrustServerCertificate=False;" +
            //    "ApplicationIntent=ReadWrite;" +
            //    "MultiSubnetFailover=False";
            //Console.WriteLine(CONECTION_STRING);
            ////2) Создаем подключения к серверу
            //SqlConnection connection = new SqlConnection(CONECTION_STRING);
            ////на данный момент подключение является закрытым, мы его не открывали а только создали

            ////3) создаем команду которую нужно выполнить на сервере
            //string cmd = "SELECT title, release_date, FORMATMESSAGE(N'%s %s', first_name, last_name) FROM Movies, Directors  WHERE director = director_id";
            //SqlCommand command = new SqlCommand(cmd, connection);
            ////4) Получаем результаты выполнения команды
            //connection.Open();
            //SqlDataReader reader = command.ExecuteReader();
            ////5) Обрабатываем результаты запроса:
            //if(reader.HasRows)
            //{
            //    Console.WriteLine("===================================");
            //    for (int i = 0; i < reader.FieldCount; i++)
            //        Console.Write(reader.GetName(i).PadRight(PADDING));
            //    Console.WriteLine();
            //    Console.WriteLine("===================================");
            //    while(reader.Read())
            //    {
            //        for(int i=0; i< reader.FieldCount; i++)
            //        {
            //            Console.Write(reader[i].ToString().PadRight(PADDING));
            //        }
            //        Console.WriteLine();
            //        //Console.WriteLine($"{reader[0]}\t{reader[1]}\t{reader[2]}");
            //    }
            //}
            ////6)закрываем SqlDataReader 
            //reader.Close();
            //connection.Close();
            //Console.Read();
            Connector.SelectMovies();
            
        }
    }
}
