using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCSIntS5
{
    class Program
    {
        static void Main(string[] args)
        {
            DbCommand sqlCommand = new DbCommand(new SqlConnection("SQL Connection"), "SQL Instruction");
            sqlCommand.Execute();

            DbCommand oracleCommand = new DbCommand(new OracleConnection("Oracle Connection"), "Oracle Instruction");
            oracleCommand.Execute();
        }
    }
}