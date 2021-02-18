using ConsoleUI;
using System;
using System.Collections.Generic;
using System.Linq;

var temp = new List<int> {1,3,4,6};
string result;

foreach (var item in temp)
{
    //switch (item)
    //{
    //    case 1:
    //        Console.WriteLine("Jeden");
    //        break;
    //    default:
    //        break;
    //}
    result = item switch
    {
        < 2  => "mniej niż dwa",
        >= 3 => "więcej niż dwa",
        _    => "nieznane"
    };
    Console.WriteLine(result);
}

