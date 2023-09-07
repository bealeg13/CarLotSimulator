using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
     class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public string MakeEngineNoise(string noise)
        {
            EngineNoise = noise;
            return EngineNoise;
        }

        public string MakeHonkNoise(string noise)
        {
            HonkNoise = noise;
            return HonkNoise;
        }
        public Car(int year, string make, string model,bool isDriveable)
        {
            this.Year = year;
            this.Make = make;
            this.Model = model;        
            IsDriveable = isDriveable;
        }
        public Car()
        {

        }

    }

}
