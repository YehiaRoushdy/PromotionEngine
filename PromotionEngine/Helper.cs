using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public static class Helper
    {
        public static string str = "server=(local);database=PromotionEngineDB;persist security info=True;" +
                    "Integrated Security = SSPI";
        public static SqlConnection Con;
    }
}
