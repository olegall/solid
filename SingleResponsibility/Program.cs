using System;

namespace SingleResponsibility
{
    interface IPrinter
    {
        void Print(string text);
    }

    class ConsolePrinter : IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
    }

    class Report
    {
        public string Text { get; set; }
        public void GoToFirstPage()
        {
            Console.WriteLine("Переход к первой странице");
        }

        public void GoToLastPage()
        {
            Console.WriteLine("Переход к последней странице");
        }

        public void GoToPage(int pageNumber)
        {
            Console.WriteLine("Переход к странице {0}", pageNumber);
        }

        public void Print()
        {
            Console.WriteLine("Печать отчета");
            Console.WriteLine(Text);
        }

        public void Print(IPrinter printer)
        {
            printer.Print(this.Text);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IPrinter printer = new ConsolePrinter();
            Report report = new Report();
            report.Text = "Hello Wolrd";
            report.Print(printer);

            MobileStore store = new MobileStore(new ConsolePhoneReader(), new GeneralPhoneBinder(), new GeneralPhoneValidator(), new TextPhoneSaver());
            store.Process();
        }
    }
}
