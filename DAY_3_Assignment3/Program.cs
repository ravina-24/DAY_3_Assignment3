﻿using System;

namespace DAY_3_Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {

            int input;
            Console.WriteLine("Enter input = \n" +
                "1.Calculate loan \n" +
                "2.FindDayOfWeek\n" +
                "3.CalculateWindChill\n" +
                "4.CalculateAverage");
            input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
              CarLoan c = new CarLoan();
              c.CalculateLoan();
                    break;

                case 2:
               DayOfWeek d = new DayOfWeek();
               d.FindDayOfWeek();
                    break;

                case 3:
              WindChill w = new WindChill();
               w.CalculateWindChill();
                    break;


                case 4:
              Stats5 s = new Stats5();
              s.CalulateAverage();
                    break;

                default:                 
                        Console.WriteLine("Enter proper input");
                    
                    break;
            }


            Console.ReadLine();

        }
    }
}
