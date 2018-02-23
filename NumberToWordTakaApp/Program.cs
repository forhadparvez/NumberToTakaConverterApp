using NumberToWordTakaApp.Models;
using System;

namespace NumberToWordTakaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number to convert to currency");
            string number = Console.ReadLine();
            number = Convert.ToDouble(number).ToString();

            Console.WriteLine(NumberToTaka.ConvertNumberToWordTaka(number));


            Console.ReadLine();

        }
    }
}
