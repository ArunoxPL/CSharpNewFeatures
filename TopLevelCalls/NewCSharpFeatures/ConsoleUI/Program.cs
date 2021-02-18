using ConsoleUI;
using System;

Console.WriteLine("Hello World!");
Console.WriteLine(Add(4,3));


PersonModel p = new PersonModel { Id = 1, FirstName = "Grzesiek", LastName = "Malek" };

//p.Id = 2;
//p.FirstName = "Grzegorz";

Console.WriteLine($"Hello {p.FirstName} {p.LastName} ({p.Id})");

static double Add(double x, double y)
{
    return x + y;
}
