using Dapper;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace DatabaseConnector
{
    public class OracleConnector
    {
       


        /// <summary>
        ///  This method will get the data from Oracle database
        /// </summary>
        /// <returns></returns>
        public List<QuarticEmployee> FetchDataFromOracle()
        {

            List<QuarticEmployee> lstEmployee = new List<QuarticEmployee>();
            using (var connection = new OracleConnection(QuarticEmployee.OracleConnectionString))
            {
                connection.Open();
                lstEmployee = connection.Query<QuarticEmployee>(QuarticEmployee.Query).ToList();
                connection.Close();
            }


            return lstEmployee;
        }
    }
}
