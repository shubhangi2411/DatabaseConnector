
using ConsoleTables;
using DatabaseConnector;
using System;
using System.Collections.Generic;

namespace SqlConnector_POC
{
    class Program
    {
        static void Main(string[] args)

        {
            #region Sql Database
            SqlConnector sqlconn = new SqlConnector();
            Console.WriteLine("Fetching Data from Sql Database.......");
             List<QuarticEmployee> SqlOutput = sqlconn.FetchDataFromSqlServer();

            var table = new ConsoleTable("Name", "Role", "Location", "Technology");
            table.AddRow(SqlOutput[0].Name, SqlOutput[0].Role_Assigned, SqlOutput[0].Location, SqlOutput[0].Tech_Field);
            Console.Write(table);

            #endregion

            #region Mysql DataBase
            MysqlConnector mysqlconn = new MysqlConnector();
            Console.WriteLine("Fetching Data from MySql Database.......");
            List<QuarticEmployee> MysqlOutput = mysqlconn.FetchDataFromMysql();

            var table1 = new ConsoleTable("Name", "Role", "Location", "Technology");
            table1.AddRow(MysqlOutput[0].Name, MysqlOutput[0].Role_Assigned, MysqlOutput[0].Location, MysqlOutput[0].Tech_Field);
            Console.Write(table1);

            #endregion

            //#region Oracle DataBase
            //OracleConnector oracleconn = new OracleConnector();
            //Console.WriteLine("Fetching Data from Oracle Database.......");
            //List<QuarticEmployee> OracleOutput = oracleconn.FetchDataFromOracle();

            //var table2 = new ConsoleTable("Name", "Role", "Location", "Technology");
            //table2.AddRow(OracleOutput[0].Name, OracleOutput[0].Role_Assigned, OracleOutput[0].Location, OracleOutput[0].Tech_Field);
            //Console.Write(table2);

            //#endregion
        }
    }
}
