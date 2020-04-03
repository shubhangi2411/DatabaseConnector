using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseConnector
{
   public  class QuarticEmployee
    {

        #region readonly variables
        public static readonly string SqlConnectionString = @"Server=(localdb)\MyInstance;Integrated Security=true;Database=quartic";
        public static readonly string MysqlConnectionString = "Server=127.0.0.1;Port=3306;database=quartic;Uid=root;Pwd=password";
        public static readonly string OracleConnectionString = "Server=;Database=quartic";
        public static readonly string Query = "select name,Role_Assigned,Location,Tech_Field from quarticEmployee";

        #endregion
        public string Name { get; set; }

        public string Role_Assigned { get; set; }

        public string Location { get; set; }

        public string Tech_Field { get; set; }
    }
}
