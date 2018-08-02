using No8.Solution.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No8.Solution
{
    internal class PrinterCreator
    {
        internal Printer CreatePrinter(string name, string model)
        {
            switch (name)
            {
                case "Canon":
                    {
                        if (model == "123x")
                        {
                            return new CanonPrinter();
                        }
                        else
                        {
                            throw new PrinterModelException(nameof(model));
                        }
                    }
                case "Epson":
                    {
                        if (model == "231")
                        {
                            return new EpsonPrinter();
                        }
                        else
                        {
                            throw new PrinterModelException(nameof(model));
                        }
                    }
                default:
                    {
                        throw new PrinterNameException(nameof(name));
                    }
            }
        }

    }
}
