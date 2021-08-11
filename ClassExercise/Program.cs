using System;

namespace ClassExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Car firstCar = new Car();
            firstCar.Make = "Izuzu";
            firstCar.Model = "Spacecab";
            firstCar.Year = 1992;

            Console.WriteLine($"My first car was a {firstCar.Year} {firstCar.Make} {firstCar.Model}!");
        }
    }
}
