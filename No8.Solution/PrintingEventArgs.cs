using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No8.Solution
{
    internal class PrintingEventArgs : EventArgs
    {
        internal string Model { get; set; }
        internal string Name { get; set; }

        internal PrintingEventArgs(string typeOfPrinter, string nameOfPrinter)
        {
            Model = typeOfPrinter;
            Name = nameOfPrinter;
        }
    }
}
