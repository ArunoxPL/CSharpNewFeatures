using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class PersonModel
    {
        public int Id { get; init; } // zmiana albo w konstruktorze albo podczas pierwszego wywołania 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public PersonModel()
        {
        }
        public PersonModel(int Id, string FirstName, string LastName)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
    }
}
