using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Bebek
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthdate { get; set; }


        // 1. Parametre Almayan Default Constructor 
        public Bebek() 
        {
            Console.WriteLine("Ingaaaa");
           Birthdate = DateTime.Now;
        }

        // 2. Parametre alan Constructor

        public Bebek (string name, string surname)
        {
            Name = name;
            Surname = surname;
            Birthdate = DateTime.Now;
        }

    }
}
