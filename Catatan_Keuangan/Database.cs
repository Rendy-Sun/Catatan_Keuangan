using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace Catatan_Keuangan
{
    class Database
    {
        public static string getConnection() {
            return ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
        }
    }
}
