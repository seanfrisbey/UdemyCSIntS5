using System;

namespace UdemyCSIntS5
{
    public class DbCommand
    {
        private DbConnection _dbConnection;
        private string _dbInstruction;

        public DbCommand(DbConnection connection, string instruction)
        {
            if (connection == null)
                throw new ArgumentNullException(nameof(connection));
            if (instruction == null)
                throw new ArgumentNullException(nameof(instruction));

            this._dbConnection = connection;
            this._dbInstruction = instruction;
        }

        public void Execute()
        {
            this._dbConnection.Open();
            Console.WriteLine(this._dbInstruction);
            this._dbConnection.Close();
        }
    }
}