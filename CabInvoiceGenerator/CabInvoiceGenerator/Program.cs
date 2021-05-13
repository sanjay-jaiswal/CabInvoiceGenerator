using System;

namespace CabInvoiceGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|**********************************************************************************************************************|");
            Console.WriteLine("|===================================== WELCOME TO CAB INVOICE GENERATOR ===============================================|");
            Console.WriteLine("|______________________________________________________________________________________________________________________|");

            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double fare = invoiceGenerator.CalculateFare(2.0, 5);
            Console.WriteLine($"Fare =  +{ fare}");
        }
    }
}
