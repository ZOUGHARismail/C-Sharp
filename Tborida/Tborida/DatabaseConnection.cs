using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Tborida
{
    public class DatabaseConnection
    {
        public static SqlConnection connection = new SqlConnection("server=DESKTOP-NMHS2UI\\SQLEXPRESS;database=tborida;integrated security=true");
    }
}
