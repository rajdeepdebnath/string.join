using System;
using System.Collections.Generic;

namespace stringjoin
{
    class Item
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var a = new List<Item>();
            a.Add(new Item{ FirstName="Ram", LastName="Mozi"});
            a.Add(new Item{ FirstName="Sanu", LastName="Rock"});
            a.Add(new Item{ FirstName="Tim", LastName="Bik"});
            var result = string.Join(", ", a);
            Console.WriteLine(result); //Ram Mozi, Sanu Rock, Tim Bik
        }
    }
}
