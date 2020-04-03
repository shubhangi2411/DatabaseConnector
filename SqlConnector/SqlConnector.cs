using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DatabaseConnector
{
    public class SqlConnector
    {
        
        /// <summary>
        /// This method will get the data from Sql database
        /// </summary>
        /// <returns></returns>

        public List<QuarticEmployee> FetchDataFromSqlServer()
        {
            try
            {
                List<QuarticEmployee> lstEmployee = new List<QuarticEmployee>();
                using (var connection =new SqlConnection(QuarticEmployee.SqlConnectionString))
                {
                    connection.Open();
                    lstEmployee = connection.Query<QuarticEmployee>(QuarticEmployee.Query).ToList();
                    connection.Close();
                }


                return lstEmployee;
            }
            catch (Exception ex)
            {
                return null;
            }


        }

       
    }
}
