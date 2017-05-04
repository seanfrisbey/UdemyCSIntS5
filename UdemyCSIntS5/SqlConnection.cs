using System;

namespace UdemyCSIntS5
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
            // No implementation.
        }

        public override void Open()
        {
            Console.WriteLine("SQL connection opened.");
        }

        public override void Close()
        {
            Console.WriteLine("SQL connection closed.");
        }
    }
}