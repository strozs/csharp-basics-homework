﻿using System;

namespace VariablesAndNames
{
    class Program
    {
        private static void Main(string[] args)
        {

<<<<<<< Updated upstream
            cars = 100; //cars
            seats_in_a_car = 4.0; //seats in a car
            drivers = 28; // drivers
            passengers = 90; // passengers
            cars_not_driven = cars - drivers; // free cars
            cars_driven = drivers; // cars driven at the moment
            carpool_capacity = cars_driven * seats_in_a_car; // carpool capacity
            average_passengers_per_car = passengers / cars_driven; // average passengers per car

            Console.WriteLine("There are " + cars + " cars available.");
            Console.WriteLine("There are only " + drivers + " drivers available.");
            Console.WriteLine("There will be " + cars_not_driven + " empty cars today.");
            Console.WriteLine("We can transport " + carpool_capacity + " people today.");
            Console.WriteLine("We have " + passengers + " to carpool today.");
            Console.WriteLine("We need to put about " + average_passengers_per_car + " in each car.");
=======

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

>>>>>>> Stashed changes
            Console.ReadKey();
        }
    }
}