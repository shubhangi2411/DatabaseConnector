using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace DatabaseConnector
{
    public class MysqlConnector
    {
       

        /// <summary>
        /// This method will get the data from Mysql database
        /// </summary>
        /// <returns></returns>
        public List<QuarticEmployee> FetchDataFromMysql()
        {

            List<QuarticEmployee> lstEmployee = new List<QuarticEmployee>();
            using (var connection = new MySqlConnection(QuarticEmployee.MysqlConnectionString))
            {
                connection.Open();
                lstEmployee = connection.Query<QuarticEmployee>(QuarticEmployee.Query).ToList();
                connection.Close();
            }


            return lstEmployee;
        }
    }
}
