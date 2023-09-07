using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal class CarLot
    {
        public List<Car>ListOfCars = new List<Car>();

        public static int numberOfCars = 0;
        public static void IncrementCarValue()
        {
            numberOfCars++;
        }
        public static int GetNumberOfCars()
        {
            return numberOfCars;
        }



    }
}
