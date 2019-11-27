using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Classes
{
    class Class1
    {
        public static string LogFileName = "C:\\Vjezba.log";

        public static void Log(string LogMessage)
        {
            using (StreamWriter file = new StreamWriter(LogFileName, true))
            {
                file.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss K"));
                file.WriteLine(LogMessage);
                file.WriteLine("********");
                file.WriteLine();

            }
        }
    }
}
