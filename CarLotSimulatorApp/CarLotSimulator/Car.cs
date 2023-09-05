using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
     class Car
    {
        public int year;
        public string make;
        public string model;
        public string EngineNoise;
        public string HonkNoise;
        public bool IsDriveable;

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
            this.year = year;
            this.make = make;
            this.model = model;        
            IsDriveable = isDriveable;
        }
        public Car()
        {

        }

    }

}
