using Bird_Watcher.Entity;

int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };

// Task 1
Console.WriteLine(BirdCount.LastWeek());

// Task 2
var birdCount = new BirdCount(birdsPerDay);
Console.WriteLine(birdCount.Today());

// Task 3 
birdCount.IncrementTodaysCount();
Console.WriteLine(birdCount.Today());

// Task 4 
Console.WriteLine(birdCount.HasDayWithoutBirds());

// Task 5 
Console.WriteLine(birdCount.CountForFirstDays(4));

// Task 6 
Console.WriteLine(birdCount.BusyDays());

