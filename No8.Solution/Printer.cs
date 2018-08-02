using System;
using System.IO;

namespace No8.Solution
{
    public abstract class Printer
    {
        internal event EventHandler<PrintingEventArgs> StartPrinting;

        internal event EventHandler<PrintingEventArgs> EndPrinting;

        public string Name { get; set; }

        public string Model { get; set; }

        public void Print(FileStream stream)
        {
            for (int i = 0; i < stream.Length; i++)
            {
                OnStartPrinting(this, new PrintingEventArgs(Name, Model));
                Printing(stream);
                OnEndPrinting(this, new PrintingEventArgs(Name, Model));
            }
        }

        public abstract void Printing(Stream stream);

        private void OnStartPrinting(object source, PrintingEventArgs e)
        {
            StartPrinting?.Invoke(this, e);
        }

        private void OnEndPrinting(object source, PrintingEventArgs e)
        {
            EndPrinting?.Invoke(this, e);
        }
    }
}