using System;
using System.Collections.Generic;

using CarConsole.Models;
using CarConsole.Views;

namespace CarConsole.Controllers
{
    class CarController
    {
        public CarController()
        {
            Car cardata = new Car("Buick", 4);

            CarViewModel carviewmodel = new CarViewModel(cardata);

            CarView carview = new CarView(carviewmodel);

            Console.WriteLine(carview);

            cardata.Passengers.Add("Mike Twohey");

            cardata.Passengers.Add("Casey");

            cardata.Passengers.Add("John");

            Console.WriteLine(carview);

            cardata.Passengers.Clear();

            Console.WriteLine(carview);

            // Switch to a Tesla
            
            cardata = new Car("Tesla", 2);

            carviewmodel = new CarViewModel(cardata);

            carview = new CarView(carviewmodel);

            Console.WriteLine(carview);
        }
    }
}
