using System;
using System.IO;

namespace No8.Solution
{
    public class EpsonPrinter : Printer
    {
        public EpsonPrinter()
        {
            Model = "231";
            Name = "Epson";
        }

        public override void Printing(Stream stream)
        {
            for (int i = 0; i < stream.Length; i++)
            {
                Console.WriteLine("Epson Printer");
                Console.WriteLine(stream.ReadByte());
            }
        }
    }
}