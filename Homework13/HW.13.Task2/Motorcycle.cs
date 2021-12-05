using Serilog;
using System.Data;
using System.Data.SqlClient;

namespace HW._13.Task2
{
    internal class Motorcycle : IMotorcycleRepository
    {
        private static List<Motorcycle> _motoList = new List<Motorcycle>();
        int id;
        string model;
        string name;
        int year;
        int odometer;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <param name="name"></param>
        /// <param name="year"></param>
        /// <param name="odometer"></param>
        /// <param name="id"></param>
        internal Motorcycle(string model, string name, int year, int odometer, int id)
        {
            this.id = id;
            this.model = model;
            this.name = name;
            this.year = year;
            this.odometer = odometer;
        }

        public static void CreateMotorcycle(Motorcycle moto)
        {
            _motoList.Add(moto);
            Log.Information($"Motorcycle {moto.ToString()} has been created");
        }

        public static void DeleteMotorcycle(int id)
        {
            foreach (var item in _motoList)
            {
                if ((item as Motorcycle).id == id)
                {
                    _motoList.Remove(item);
                    Log.Information($"Motorcycle {(item as Motorcycle).ToString()} has been removed");
                    return;
                }      
            }
            throw new MotorcycleNotFoundException("Motorcycle not found");
        }

        public static void GetMotorcycles()
        {
            Log.Information($"Motorcycle list begins writing on console");
            foreach (var item in _motoList)
            {
                Console.WriteLine((item as Motorcycle).ToString());
                Log.Information($"Motorcycle {(item as Motorcycle).ToString()} has been readed");
            }
        }

        public static void UpdateMotorcycle(Motorcycle moto)
        {
            foreach (var item in _motoList)
            {
                if ((item as Motorcycle).id == moto.id)
                {
                    _motoList.Remove(item);
                    _motoList.Add(moto);
                    Log.Information($"Motorcycle {moto.ToString} has been updated");
                    return;
                } 
            }
            throw new MotorcycleNotFoundException("Motorcycle not found");
        }

        public static Motorcycle GetMotorcycleByID(int id)
        {
            foreach (var item in _motoList)
            {
                if ((item as Motorcycle).id == id)
                    return (item as Motorcycle);
            }
            throw new MotorcycleNotFoundException("Motorcycle not found");
        }

        public override string ToString()
        {
            return ($"Model: {this.model}, name: {this.name}, id: {this.id}, odometer: {this.odometer}, year: {this.year}");
        }

        public static async Task CreateDB()
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=master;Trusted_Connection=True;";
            string sqlExpression = "CREATE DATABASE Motorcycles";
            // создаем базу данных
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                await command.ExecuteNonQueryAsync();
                Console.WriteLine("База данных создана");
            }
 
            connectionString = "Server=(localdb)\\mssqllocaldb;Database=Motorcycles;Trusted_Connection=True;";
            sqlExpression = @"CREATE TABLE Motorcycles 
                                (Id INT PRIMARY KEY IDENTITY, 
                                 Name VARCHAR(50) NOT NULL, 
                                 Model VARCHAR(50) NOT NULL,
                                 Year int,
                                 Odometer int)";

            // создаем таблицу
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                await command.ExecuteNonQueryAsync();
                Log.Information("Таблица motorcycles создана");
            }
 
            Console.Read();
        }
        

        public static async Task WriteTOSqlAsync()
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=Motorcycles;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Motorcycles(Id, Name, Model, Year, Odometer) VALUES (@Id, @Name, @Model, @Year, @Odometer)";
                command.Parameters.Add("@Id", SqlDbType.Int);
                command.Parameters.Add("@Name", SqlDbType.VarChar, 50);
                command.Parameters.Add("@Model", SqlDbType.VarChar, 50);
                command.Parameters.Add("@Year", SqlDbType.Int);
                command.Parameters.Add("@Odometer", SqlDbType.Int);

                foreach (var item in _motoList)
                {
                    command.Parameters["@Id"].Value = item.id;
                    command.Parameters["@Name"].Value = item.name;
                    command.Parameters["@Model"].Value = item.model;
                    command.Parameters["@Year"].Value = item.year;
                    command.Parameters["@Odometer"].Value = item.odometer;
                    break;
                }

                await command.ExecuteNonQueryAsync();
                Log.Information("Файл сохранен");
            }
        }
    }   
}
