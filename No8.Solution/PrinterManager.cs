using System;
using System.Collections.Generic;
using System.IO;
using No8.Solution.Exceptions;

namespace No8.Solution
{
    public class PrinterManager
    {
        internal ILogger logger = new Logger();

        public PrinterManager()
        {
            Printers = new List<Printer>();
        }

        public static List<Printer> Printers { get; private set; }

        public void CreatePrinter(string name, string model)
        {
            try
            {
                Add(new PrinterCreator().CreatePrinter(name, model));
            }
            catch (PrinterNameException)
            {
                logger.Warn("The printer name is invalid");
            }
            catch (PrinterModelException)
            {
                logger.Warn("The printer model is invalid");
            }
            catch (ArgumentException)
            {
                logger.Warn("The printer is already added.");
            }

        }

        public void Print(string printName, string fileName)
        {
            Printer printer = Printers.Find(x => x.Name == printName);

            using (var f = File.OpenRead(fileName))
            {
                if (printer == null)
                {
                    logger.Warn("There are no added printer to print");
                    return;
                }

                printer.Print(f);
            }
        }

        internal void Add(Printer p1)
        {
            if (Printers.Contains(p1))
            {
                throw new ArgumentException();
            }

            Printers.Add(p1);
        }
    }
}