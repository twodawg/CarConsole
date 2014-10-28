using System;

using CarConsole.Models;

namespace CarConsole.Views
{
    class CarView
    {
        CarViewModel _CarViewModel;

        public CarView(CarViewModel carviewmodel)
        {
            _CarViewModel = carviewmodel;
        }
        public override string ToString()
        {
            if (_CarViewModel.NumberPassengers > 0)
            {
                return CommonCarText() + _CarViewModel.Passengers +
                    "are the current passengers";
            }
            else
            {
                return CommonCarText() +
                    "There are no passengers";
            }
        }

        private string CommonCarText()
        {
            return "The car model, " + _CarViewModel.Model +
                                " has " + _CarViewModel.Doors +
                                " doors. ";
        }
    }
}
