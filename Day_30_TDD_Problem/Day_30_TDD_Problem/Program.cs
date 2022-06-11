using System;

namespace Day_30_TDD_Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            Console.WriteLine(invoiceGenerator.CalculateFare(5, 6));
            Console.ReadLine();
        }
    }
}
