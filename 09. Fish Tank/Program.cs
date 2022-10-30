using System;

namespace _09._Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
         int length = int.Parse(Console.ReadLine());
         int width = int.Parse(Console.ReadLine());
         int height = int.Parse(Console.ReadLine());
         double perecentage = double.Parse(Console.ReadLine());
            // calculate
            int volume = length * width * height;
            double maxLitres = volume / 1000.0;
            double percentagedividedByHundred = perecentage / 100;
            double neededLitres = maxLitres - (maxLitres * percentagedividedByHundred);
            // output
            Console.WriteLine(neededLitres);
            
           
        }
    }
}
