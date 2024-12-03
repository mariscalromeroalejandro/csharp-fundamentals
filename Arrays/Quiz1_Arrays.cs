namespace HelloWorld.Arrays
{
    using System;

    public class Quiz1_Arrays
    {
        public static void Run()
        {
            int[] production = {50, 60, 55, 70, 65, 80, 75};
            int[] consumption = {45, 65, 60, 60, 70, 75, 80};
            int[] balance = new int[7];

            Console.WriteLine("Day   Production (MWh)   Consumption (MWh)   Balance (MWh)");
            Console.WriteLine("-----------------------------------------------");

            for (int i = 0; i < production.Length; i++)
            {
                balance[i] = production[i] - consumption[i];
                Console.WriteLine($"{i + 1,3}   {production[i],-18} {consumption[i],-18} {balance[i],-10}");
            }
        }
    }
}