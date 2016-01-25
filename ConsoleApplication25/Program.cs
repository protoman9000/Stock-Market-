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
            Console.WriteLine("Starting Stok Market Program");
            List<int> stockList = new List<int>();

            System.IO.StreamReader file = new System.IO.StreamReader("C:\\Users\\Aziz\\Desktop\\ST.txt");
            while((price = file.ReadLine()) != null)
            {
                int x = Convert.ToInt16(price);
                stockList.Add(x);
            }

        }
    }
}
