using Squeaky_Clean.Entity;

// Task 1 
Console.WriteLine(Identifier.Clean("my   Id"));

// Task 2 
Console.WriteLine(Identifier.Clean("my\0Id"));

// Task 3
Console.WriteLine(Identifier.Clean("à-ḃç"));

// Task 4 
Console.WriteLine(Identifier.Clean("1😀2😀3😀"));

// Task 5
Console.WriteLine(Identifier.Clean("MyΟβιεγτFinder"));
