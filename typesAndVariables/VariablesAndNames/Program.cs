﻿using System;

namespace VariablesAndNames
{
    class Program
    {
        private static void Main(string[] args)
        {
            int cars = 100;
            int seatsInACar = 40;
            int drivers = 30;
            int passengers = 90;
            int carsNotDriven = cars - drivers;
            int carsDriven = drivers;
            double carpoolCapacity = carsDriven * seatsInACar;
            double averagePassengersPerCar = passengers / carsDriven;

            Console.WriteLine($"There are {cars} cars available.");
            Console.WriteLine($"There are only {drivers} drivers available.");
            Console.WriteLine($"There will be {carsNotDriven} empty cars today.");
            Console.WriteLine($"We can transport {carpoolCapacity} people today.");
            Console.WriteLine($"We have {passengers} to carpool today.");
            Console.WriteLine($"We need to put about {averagePassengersPerCar} in each car.");

            Console.ReadKey();
        }
    }
}