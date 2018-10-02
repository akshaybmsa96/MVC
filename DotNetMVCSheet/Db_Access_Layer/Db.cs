using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace DotNetMVCSheet.Db_Access_Layer
{
    public class Db
    {
        public SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Akki\source\repos\DotNetMVCSheet\DotNetMVCSheet\App_Data\Database1.mdf;Integrated Security = True");

    }
}