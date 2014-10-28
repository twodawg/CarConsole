using System;
using System.Collections.Generic;

namespace CarConsole.Models
{
    class Car
    {
        private List<string> _passengers;

        public Car(string pModel, int pDoors)
        {
            Model = pModel;
            Doors = pDoors;
            _passengers = new List<string>();
        }

        public string Model { get; private set; }
        public int Doors { get; private set; }

        public int Wheels
        {
            get { return 4; }
        }


        public List<string> Passengers
        {
            get
            {
                return _passengers;
            }
        }
    }
}
