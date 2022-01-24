using System;

namespace ConsoleApp1
{
    static class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 0, 2675, -3, 785, -5, -666, 13, 5 };

            arr.GetMaxValues(out int max, out int min);
            
            Console.WriteLine($"max: {max} and min: {min}");
        }

        private static void GetMaxValues(this int[] arr, out int max , out int min)
        {
            if (arr.Length == 0) 
                throw new ArgumentException("Can't get values!");
            
            int currentMax = arr[0];
            int currentMin = arr[0];
            
            for (var i = 0; i < arr.Length - 1 ; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    if (currentMax > arr[i]) 
                        continue;

                    currentMax = arr[i];
                }
                else
                {
                    if(currentMin < arr[i])
                        continue;
                        
                    currentMin = arr[i];
                }
            } 

            max = currentMax;
            min = currentMin;
        }
    }
}