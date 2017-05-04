using System;

namespace UdemyCSIntS5
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public abstract void Open();
        public abstract void Close();

        public DbConnection(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
                throw new ArgumentNullException(nameof(connectionString));

            this.ConnectionString = connectionString;
        }
    }
}