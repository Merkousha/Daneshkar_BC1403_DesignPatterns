// Patterns/Singleton/DatabaseConnection.cs
using System;

namespace BookStore.Patterns.Singleton
{
    public class DatabaseConnection
    {
        private static DatabaseConnection _instance;

        // Private constructor
        private DatabaseConnection()
        {
            Console.WriteLine("Database connection established.");
        }

        // Global access point
        public static DatabaseConnection Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DatabaseConnection();
                }
                return _instance;
            }
        }

        public void Query(string sql)
        {
            Console.WriteLine($"Executing query: {sql}");
            // Actual implementation of query execution
        }
    }
}
