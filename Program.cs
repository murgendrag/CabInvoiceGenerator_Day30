using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    class Program
    {
         static void Main(string[] args)
         {
                Console.WriteLine("Welcome to Cab Invoice Gernerator");

                InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.PREMIUM);

                double fare = invoiceGenerator.CalculateFare(2.0, 5);

                Console.WriteLine(fare);
         }
       
    }
}