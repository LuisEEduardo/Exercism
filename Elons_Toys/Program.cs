using Elons_Toys.Entity;

// Task 1
var car = RemoteControlCar.Buy();

Console.WriteLine(car.metersDriven);
Console.WriteLine(car.totalBatery);

// Taks 2
Console.WriteLine(car.DistanceDisplay());

// Task 3
Console.WriteLine(car.BatteryDisplay());

// Task 4
car.Drive();
car.Drive();
Console.WriteLine(car.DistanceDisplay());

// Task 5
Console.WriteLine(car.BatteryDisplay());
