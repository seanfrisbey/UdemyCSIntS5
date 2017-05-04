using System;

namespace UdemyCSIntS5
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
            // No implementation.
        }

        public override void Open()
        {
            Console.WriteLine("Oracle connection opened.");
        }

        public override void Close()
        {
            Console.WriteLine("Oracle connection closed.");
        }
    }
}