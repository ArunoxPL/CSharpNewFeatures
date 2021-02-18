using ConsoleUI;
using System;

PersonModel p = new () { Id = 1, FirstName = "Grzesiek", LastName = "Malek" };
PersonModel p2 = new(2, "Paweł", "Kropka");


//p.Id = 2;
//p.FirstName = "Grzegorz";

Console.WriteLine($"Hello {p.FirstName} {p.LastName} ({p.Id})");

