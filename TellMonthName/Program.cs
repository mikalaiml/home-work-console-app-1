using System;

namespace TellMonthName
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Hi, enter current month number: ");
            var monthNumber = Convert.ToInt32(Console.ReadLine());

            if (monthNumber is > 0 and < 13)
            {
                var monthName = monthNumber switch
                {
                    1 => "January",
                    2 => "February",
                    3 => "March",
                    4 => "April",
                    5 => "May",
                    6 => "June",
                    7 => "July",
                    8 => "August",
                    9 => "September",
                    10=>"October",
                    11=>"November",
                    12=>"December",
                    _ => string.Empty
                };

                Console.WriteLine($"Current month is {monthName}.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"There is no month with number {monthNumber}.");
            }
        }
    }
}
