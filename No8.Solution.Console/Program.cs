using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace No8.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinterManager printerManager = new PrinterManager();

            string fileName = "123.txt";

            while (true)
            {
                System.Console.WriteLine("\nSelect your choice:");
                System.Console.WriteLine("1:Add new printer");
                System.Console.WriteLine("2:Print on Canon");
                System.Console.WriteLine("3:Print on Epson");

                var key = System.Console.ReadKey();

                if (key.Key == ConsoleKey.D1)
                {
                    System.Console.WriteLine("\nEnter Name: ");
                    string name = System.Console.ReadLine();
                    System.Console.WriteLine("Enter Model: ");
                    string model = System.Console.ReadLine();
                    printerManager.CreatePrinter(name, model);
                }

                if (key.Key == ConsoleKey.D2)
                {
                    printerManager.Print("Canon", fileName);
                }

                if (key.Key == ConsoleKey.D3)
                {
                    printerManager.Print("Epson", fileName);
                }

            }
        }   
    }
}
