using ConsoleUI;
using System;

PersonModel p = new PersonModel { Id = 1, FirstName = "Grzesiek", LastName = "Malek" };

//p.Id = 2;
//p.FirstName = "Grzegorz";

Console.WriteLine($"Hello {p.FirstName} {p.LastName} ({p.Id})");

