using System;

namespace _01._The_Biscuit_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int biscuitsPerWorker = int.Parse(Console.ReadLine());
            int workersCount = int.Parse(Console.ReadLine());
            long competingFactoryBiscuits = long.Parse(Console.ReadLine());
            decimal totalBiscuits = 0;

            for (int i = 1; i <= 30; i++)
            {
                decimal biscuitsPerDay = biscuitsPerWorker * workersCount;

                if (i % 3 == 0)
                {
                    biscuitsPerDay = Math.Floor(biscuitsPerDay * 0.75m);
                }

                totalBiscuits += biscuitsPerDay;
            }

            decimal diff = (Math.Abs(totalBiscuits - competingFactoryBiscuits) / competingFactoryBiscuits) * 100;
            Console.WriteLine($"You have produced {(int)totalBiscuits} biscuits for the past month.");
            if(totalBiscuits >= competingFactoryBiscuits)
            {
                Console.WriteLine($"You produce {diff:F2} percent more biscuits.");
            }
            else
            {
                Console.WriteLine($"You produce {diff:F2} percent less biscuits.");
            }
        }
    }
}
