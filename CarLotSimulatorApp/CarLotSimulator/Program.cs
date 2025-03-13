using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var carLotOne = new CarLot();
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            
            var carOne = new Car();
            carOne.Make = "Chrysler";
            carOne.Model = "Thunderbolt Roadster";
            carOne.Year = 1941;
            carOne.IsDrivable = true;

            carOne.MakeEngineNoise("Vroom");
            carOne.MakeHonkNoise("Honk");
            
            carLotOne.ParkingLot.Add(carOne);
            
            var carTwo = new Car()
            {
                Make = "Mercury",
                Model = "Club Coupe",
                Year = 1940,
                IsDrivable = true
            };
            
            carTwo.MakeEngineNoise("Roar");
            carTwo.MakeHonkNoise("Beep");
            
            carLotOne.ParkingLot.Add(carTwo);

            var carThree = new Car("Studebaker", "Champion", 1948, true);
            
            carThree.MakeEngineNoise("Vroom Vroom");
            carThree.MakeHonkNoise("Beep Beep");
            
            carLotOne.ParkingLot.Add(carThree);
            

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            
            carLotOne.CheckCars();
        }
    }
}
