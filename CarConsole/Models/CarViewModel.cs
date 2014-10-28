using System;
using System.Collections.Generic;
using System.Linq;

namespace CarConsole.Models
{
    class CarViewModel
    {
        Car _Car;

        public CarViewModel(Car car)
        {
            _Car = car;
        }
        public string Model
        {
            get
            {
                return _Car.Model;
            }
        }
        public string Doors
        {
            get
            {
                return _Car.Doors.ToString();
            }
        }
        public string Passengers
        {
            get
            {
                string passengersCombined = "";
                foreach (string passenger in _Car.Passengers)
                {
                    passengersCombined = passengersCombined + passenger + ", ";
                }
                return passengersCombined;
            }
        }
        public int NumberPassengers
        {
            get
            {
                return _Car.Passengers.Count();
            }
        }
    }
}
