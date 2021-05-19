using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Dapper;

namespace P4_PROJEKT_NR_1.Tables
{
    public class myDB
    {
        private IDbConnection _dbConnection;

        public myDB(string connectionString)
        {
            _dbConnection = new SqlConnection(connectionString);
            //sql myDBconection = new myDB(ConfigurationManager.ConnectionStrings["EWUDatabase"].ConnectionString))
        }

        public IEnumerable<Pracownicy> GetPracownicy()
        {
            return _dbConnection.Query<Pracownicy>("SELECT * FROM ewu.pracownicy");
        }
    }
}
