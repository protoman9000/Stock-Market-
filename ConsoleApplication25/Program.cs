﻿using System;
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
            double ans1 = 0;
            double ans2 = 0;

            string low;
            string high;


            int j = 0;
            int count = 0;
            Console.WriteLine("Starting Stok Market Program");
            List<double> stockList = new List<double>();

            System.IO.StreamReader file = new System.IO.StreamReader("C:\\Users\\Aziz\\Desktop\\ST.txt");
            while((price = file.ReadLine()) != null)
            {
                x = Convert.ToDouble(price);
                stockList.Add(x);
                count++;
            }

            for (int k = 0; k < count; k++)
            {
                j = k + 1;
                double result = stockList[k] - stockList[j];
                if (result > 0 && ans1 == null)
                {
                    ans1 = stockList[k];
                }
                if (result > 0)
                {
                    ans2 = stockList[k];
                }
            }

            low = Convert.ToString(ans1);
            high = Convert.ToString(ans2);

            Console.WriteLine(low + " , " + high);

            Console.WriteLine("Ending phase");

            Console.ReadKey();

        }
    }
}
