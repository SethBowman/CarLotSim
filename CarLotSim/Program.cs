using CarLotSim;

var carLot = new CarLot();

Car car1 = new Car()
{
    Year = 2021,
    Make = "Toyota",
    Model = "Camry",
    EngineNoise = "Vroom",
    HonkNoise = "Beep",
    IsDriveable = true
};


Console.WriteLine($"Number of cars in car lot: {CarLot._numberOfCars}\n");

Car car2 = new Car();
car2.Year = 2022;
car2.Make = "Honda";
car2.Model = "Accord";
car2.EngineNoise = "Roar";
car2.HonkNoise = "Honk";
car2.IsDriveable = true;

Console.WriteLine($"Number of cars in car lot: {CarLot._numberOfCars}\n");

Car car3 = new Car(2023, "Ford", "Mustang", "Rumble", "Beep Beep", true);


Console.WriteLine($"Number of cars in car lot: {CarLot._numberOfCars} \n");

carLot.Cars.Add(car1);
carLot.Cars.Add(car2);
carLot.Cars.Add(car3);

foreach (Car car in carLot.Cars)
{
    Console.WriteLine($"Year: {car.Year}, Make: {car.Make}, Model: {car.Model}");    

    // Calling methods for each car
    car.MakeEngineNoise(car.EngineNoise);
    car.MakeHonkNoise($"{car.HonkNoise}\n");
}

