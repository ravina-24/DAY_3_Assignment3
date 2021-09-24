using System;
using System.Collections.Generic;
using System.Text;

namespace DAY_3_Assignment3
{
    class Stats5
    {
          

        public void CalulateAverage()
        {

            int n = 5;

            Random random = new Random();

            double N1 = (double)random.NextDouble();
            double N2 = (double)random.NextDouble();
            double N3 = (double)random.NextDouble();
            double N4 = (double)random.NextDouble();
            double N5 = (double)random.NextDouble();


            double average = N1 + N2 + N3 + N4 + N5 / n;

            Console.WriteLine("Average of five random numbers are = " +average);
            Console.ReadLine();
        }

    }
}
