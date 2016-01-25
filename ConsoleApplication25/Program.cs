using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{
    class Program
    {
        static void Main(string[] args)
        {
            string price;
            double x = 0;
            Console.WriteLine("Starting Stok Market Program");
            List<double> stockList = new List<double>();

            System.IO.StreamReader file = new System.IO.StreamReader("C:\\Users\\Aziz\\Desktop\\ST.txt");
            while((price = file.ReadLine()) != null)
            {
                x = Convert.ToDouble(price);
                stockList.Add(x);
            }
            Console.WriteLine("Ending phase");

            Console.ReadKey();

        }
    }
}
