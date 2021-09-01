using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketStatz.Helpers
{
    public class SQLInfo
    {
        public static string server = "34.72.56.63";
        public static string username = "basketstatz";
        public static string password = "B@sk3tSt@tz";
        public static string database = "BasketStatz";
        public static string fullConnection = $"server={server};uid={username};" +
                                            $"pwd={password};database={database}";
    }
}
