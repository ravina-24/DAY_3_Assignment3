﻿using System;

namespace DAY_3_Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLoan c = new CarLoan();
            c.CalculateLoan();

            DayOfWeek d = new DayOfWeek();
            d.FindDayOfWeek();

            WindChill w = new WindChill();
            w.CalculateWindChill();
        }
    }
}
