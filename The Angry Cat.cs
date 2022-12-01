using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._The_Angry_Cat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> itemsValue = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int entryPoint = int.Parse(Console.ReadLine());
            string typeOfItem = Console.ReadLine();
            int entryPointItem = itemsValue[entryPoint];
            int left = 0;
            int right = 0;

            if (typeOfItem == "cheap")
            {
                for (int i = 0; i < entryPoint; i++)
                {
                    if (itemsValue[i] < entryPointItem)
                    {
                        left += itemsValue[i];
                    }        
                }
                for (int i = entryPoint + 1; i < itemsValue.Count; i++)
                {
                    if (itemsValue[i] < entryPointItem)
                    {
                        right += itemsValue[i];
                    }
                }
            }
            else if(typeOfItem == "expensive")
            {
                for (int i = 0; i < entryPoint; i++)
                {
                    if (itemsValue[i] >= entryPointItem)
                    {
                        left += itemsValue[i];
                    }
                }
                for (int i = entryPoint + 1; i < itemsValue.Count; i++)
                {
                    if (itemsValue[i] >= entryPointItem)
                    {
                        right += itemsValue[i];
                    }
                }
            }
            if (right > left)
            {
                Console.WriteLine($"Right - {right}");
            }
            else if(right <= left)
            {
                Console.WriteLine($"Left - {left}");
            }

        }
    }
}
