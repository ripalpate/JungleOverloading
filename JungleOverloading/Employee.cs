using System;
using System.Collections.Generic;
using System.Text;

namespace JungleOverloading
{
   class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        string[] restaurants = new[]
        {
            "O'Charleys",
            "Red Robbin",
            "Taj Mahal",
            "Azteca",
            "Ruby Tuesday"
        };
        public string Eat()
        {
            //var restaurants = new List<string>
            //{
            //    "o'charleys",
            //    "red robbin",
            //    "taj mahal",
            //    "azteca",
            //    "ruby tuesday"
            //};
            Random rand = new Random();
            int randRestaurant = rand.Next(restaurants.Length);
            Console.WriteLine($"Employee is at the {restaurants[randRestaurant]}");
            return (restaurants[randRestaurant]);
        }
    }
}
