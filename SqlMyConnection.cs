using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HastaneYonetim
{
    public class SqlMyConnection
    {
        public SqlConnection sqlConnection()
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-5CQC2MM;Initial Catalog=HastaneProje;Integrated Security=True");
            connection.Open();
            return connection;
        }
    }
}
