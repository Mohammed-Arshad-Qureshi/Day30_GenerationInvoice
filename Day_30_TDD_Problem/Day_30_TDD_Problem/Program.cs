using System;

namespace Day_30_TDD_Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            Console.WriteLine(invoiceGenerator.CalculateFare(5, 6));
            Ride[] rides = { new Ride(3, 25), new Ride(0.5, 10) };
            InvoiceSummary actual = invoiceGenerator.CalculateFare(rides);
            Console.ReadLine();
        }
    }
}
