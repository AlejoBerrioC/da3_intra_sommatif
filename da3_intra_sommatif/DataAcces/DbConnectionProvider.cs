using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace da3_intra_sommatif.DataAcces
{
    internal class DbConnectionProvider
    {
        private static string connecionString = "Server= .\\SQL2022DEV;Integrated Security=true;Database=da3_intra_sommatif;TrustServerCertificate=true;";;
        private static SqlConnection? connection;

        public static SqlConnection GetConnection()
        {
            connection ??= new SqlConnection(connecionString);
            return connection;
        }
    }
}
