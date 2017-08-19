using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var env = ConfigurationManager.AppSettings["env"];
            Console.WriteLine(env);
            Console.Read();
        }
    }
}
