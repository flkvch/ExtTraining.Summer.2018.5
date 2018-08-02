using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No8.Solution
{
    internal class Logger : ILogger
    {
        public void Info(string message)
        { 
            Console.WriteLine("Info: " + message);
        }

        public void Warn(string message)
        {
            Console.WriteLine("Warn: " + message);
        }
    }
}
