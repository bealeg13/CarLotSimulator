using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            CarLot myCarLot = new CarLot();
            
            Car car1 = new Car();
            car1.Year = 1995;
            car1.Make = "Toyota";
            car1.Model = "Camry";           
            car1.IsDriveable = true;

            car1.MakeEngineNoise("Vroom");
            car1.MakeHonkNoise("beep");
            Console.WriteLine(car1.EngineNoise);
            Console.WriteLine(car1.HonkNoise);
            myCarLot.ListOfCars.Add(car1);
            
            Car car2 = new Car() { Year = 2008, Make = "Honda", Model = "Civic", IsDriveable = true };
            
            car2.MakeEngineNoise("grrrrr");
            car2.MakeHonkNoise("booooop");
            myCarLot.ListOfCars.Add(car2);

            Car car3 = new Car(2015, "Ford", "Mustang", true);
            
            car3.MakeEngineNoise("Pooow");
            car3.MakeHonkNoise("cliiiick");
            myCarLot.ListOfCars.Add(car3);

            foreach (var car in myCarLot.ListOfCars)
            {
                Console.WriteLine(car.Year);
                Console.WriteLine(car.Make);
                Console.WriteLine(car.Model);
                Console.WriteLine();
                Console.WriteLine();

            }

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
