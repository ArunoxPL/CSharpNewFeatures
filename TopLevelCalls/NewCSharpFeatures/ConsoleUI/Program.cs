using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Record1 r1a = new ("Grzesiek", "Małek");
            Record1 r1b = new ("Grzesiek", "Małek");
            Record1 r1c = new ("Paweł", "Robak");

            Class1 c1a = new ("Grzesiek", "Małek");
            Class1 c1b = new ("Grzesiek", "Małek");
            Class1 c1c = new ("Paweł", "Robak");

            Console.WriteLine("Record Type:");
            Console.WriteLine($"To String: {r1a}");
            Console.WriteLine($"Czy obiekty są równe: {Equals(r1a,r1b)}");
            Console.WriteLine($"Czy obiekty są referencyjnie równe: {ReferenceEquals(r1a,r1b)}");
            Console.WriteLine($"Czy obiekty są równe ==: {r1a == r1b}");
            Console.WriteLine($"Czy obiekty są równe !=: {r1a != r1c}");
            Console.WriteLine($"Hash code obiektu A: {r1a.GetHashCode()}");
            Console.WriteLine($"Hash code obiektu B: {r1b.GetHashCode()}");
            Console.WriteLine($"Hash code obiektu C: {r1c.GetHashCode()}");

            Console.WriteLine("***********************************");

            Console.WriteLine("Class Type:");
            Console.WriteLine($"To String: {c1a}");
            Console.WriteLine($"Czy obiekty są równe: {Equals(c1a, c1b)}");
            Console.WriteLine($"Czy obiekty są referencyjnie równe: {ReferenceEquals(c1a, c1b)}");
            Console.WriteLine($"Czy obiekty są równe ==: {c1a == c1b}");
            Console.WriteLine($"Czy obiekty są równe !=: {c1a != c1c}");
            Console.WriteLine($"Hash code obiektu A: {c1a.GetHashCode()}");
            Console.WriteLine($"Hash code obiektu B: {c1b.GetHashCode()}");
            Console.WriteLine($"Hash code obiektu C: {c1c.GetHashCode()}");

            //Record1 r1d = r1a with
            //{
            //    FirstName = "Bartosz"
            //};

            //Console.WriteLine();

            //Console.WriteLine($"Record Bartosza: {r1d}");

            //Console.WriteLine();

            //Record2 r2a = new ( "Dominika", "Łoś" );
            //Console.WriteLine(r2a.SayHello());
        }
    }


    // typ wartosciowy
    // wartości nie mogą zostać zmienione, taka klasa tylko do odczytu
    public record Record1(string FirstName, string LastName);

    //public record User1(int Id, string FirstName, string LastName) : Record1(FirstName, LastName);

    //public record Record2(string FirstName, string LastName)
    //{
    //    public string SayHello()
    //    {
    //        return $"Hello { FirstName}";
    //    }
    //}

    public class Class1
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }

        public Class1(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }

    /*
     * Benefity recordów:
     * - Łatwe deklarowanie
     * - bezpieczny dla wątków
     * - łatwy/bezpieczny do przekazywania
     * 
     * Kiedy Używaćrecordów:
     * - przechwytywania zewnętrznych danych które sięnie zmieniają
     * - Wywołania API
     * - dla danych tylko do odczytu
     * 
     * Kiedy nie używać recordów
     * - kiedy trzeba zmieniaćdane
     * 
     */
}
