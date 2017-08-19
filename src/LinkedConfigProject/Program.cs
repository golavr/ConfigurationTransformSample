using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedConfigProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var shared = ConfigurationManager.AppSettings["shared"];
            Console.WriteLine(shared);
            Console.Read();
        }
    }
}
