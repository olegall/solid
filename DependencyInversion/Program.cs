using System;

namespace DependencyInversion
{
    #region Before
    class Book
    {
        public string Text { get; set; }
        public ConsolePrinter Printer { get; set; }

        public void Print()
        {
            Printer.Print(Text);
        }
    }

    class ConsolePrinter
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
    #endregion

    #region After
    interface IPrinter
    {
        void Print(string text);
    }

    class BookDI
    {
        public string Text { get; set; }
        public IPrinter Printer { get; set; }

        public BookDI(IPrinter printer)
        {
            this.Printer = printer;
        }

        public void Print()
        {
            Printer.Print(Text);
        }
    }

    class ConsolePrinterDI : IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine("Печать на консоли");
        }
    }

    class HtmlPrinter : IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine("Печать в html");
        }
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            BookDI book = new BookDI(new ConsolePrinterDI());
            book.Print();
            book.Printer = new HtmlPrinter();
            book.Print();
        }
    }
}
