using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Tax_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> vehicles = Console.ReadLine()
                .Split(">>", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
                int familyCarTax = 0;
                int heavyDutyCarTax = 0;
                int sportsCarTax = 0;
                int total = 0;

            for (int i = 0; i < vehicles.Count; i++)
            {
                List<string> carArgs = vehicles[i].Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                string carType = carArgs[0];
                int yearsToPay = int.Parse(carArgs[1]);
                int kilometers = int.Parse(carArgs[2]);

                if(carType == "family")
                {
                    int kilometersTax = kilometers / 3000;
                    familyCarTax = kilometersTax * 12 + (50 - yearsToPay * 5);
                    total += familyCarTax;
                    Console.WriteLine($"A {carType} car will pay {familyCarTax:F2} euros in taxes.");
                }
                else if(carType == "heavyDuty")
                {
                    int kilometersTax = kilometers / 9000;
                    heavyDutyCarTax = kilometersTax * 14 + (80 - yearsToPay * 8);
                    total += heavyDutyCarTax;
                    Console.WriteLine($"A {carType} car will pay {heavyDutyCarTax:F2} euros in taxes.");
                }
                else if(carType == "sports")
                {
                    int kilometersTax = kilometers / 2000;
                    sportsCarTax = kilometersTax * 18 + (100 - yearsToPay * 9);
                    total += sportsCarTax;
                    Console.WriteLine($"A {carType} car will pay {sportsCarTax:F2} euros in taxes.");
                }
                else
                {
                    Console.WriteLine("Invalid car type.");    
                }
            }

            Console.WriteLine($"The National Revenue Agency will collect {total:F2} euros in taxes.");
        }
    }
}
