using System;
using System.IO;

namespace No8.Solution
{
    internal class CanonPrinter : Printer
    {
        public CanonPrinter()
        {
            Name = "Canon";
            Model = "123x";
        }

        public override void Printing(Stream stream)
        {
            for (int i = 0; i < stream.Length; i++)
            {
                Console.WriteLine("Canon Printer");
                Console.WriteLine(stream.ReadByte());
            }
        }
    }
}