using System;

namespace BasicClassesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var MyCar = new Car();
            MyCar.Make = "Buick";
            MyCar.Model = "Encore";
            MyCar.Year = 2017;
            
            Console.WriteLine($"I have a {MyCar.Year} {MyCar.Make} {MyCar.Model}.");
        }
    }
}
