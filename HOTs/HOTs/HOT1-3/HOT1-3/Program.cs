using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOT1_3
{
    internal class Program
    {
        const decimal TSHIRTPRICE = 14.99m;
        const decimal TAXRATE = .08m;
        static void Main(string[] args)
        {
            string Name;
            string Address;
            string City;
            string State;
            string ZipCode;
            int numTShirtsBought;
            decimal subtotal;
            decimal taxtotal;
            decimal finalTotal;

            Console.Write("Enter Name:");
            Name = Console.ReadLine();

            Console.Write("Enter Address:");
            Address = Console.ReadLine();

            Console.Write("Enter City:");
            City = Console.ReadLine();

            Console.Write("Enter State:");
            State = Console.ReadLine();

            Console.Write("Enter ZipCode:");
            ZipCode = Console.ReadLine();

            Console.Write("Enter Number of T-Shirts:");
            numTShirtsBought = Convert.ToInt32(Console.ReadLine());

            Console.ReadLine();

            subtotal = numTShirtsBought * TSHIRTPRICE;
            taxtotal = subtotal * TAXRATE;
            finalTotal = subtotal + taxtotal;

            Console.WriteLine("\n\nT-Shirt Receipt");
            Console.WriteLine("\nName:" + Name);
            Console.WriteLine("Address:\t" + Address);
            Console.WriteLine("City:\t\t" + City);
            Console.WriteLine("State:\t\t" + State);
            Console.WriteLine("ZipCode:\t" + ZipCode);
            Console.WriteLine("#T-Shirts:\t\t" + numTShirtsBought);
            Console.WriteLine("\nSubtotal:\t" + subtotal.ToString("c"));
            Console.WriteLine("\nTax Total:\t" + taxtotal.ToString("c"));
            Console.WriteLine("---------------");
            Console.WriteLine("\nFinal Total\t:" + finalTotal.ToString("c"));
            Console.ReadLine();
        }
    }
}
