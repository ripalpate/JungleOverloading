using System;
using System.Collections.Generic;
using System.Text;

namespace JungleOverloading
{
   class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        List<string> restaurants = new List<string>
        {
            "O'Charleys",
            "Red Robbin",
            "Taj Mahal",
            "Azteca",
            "Ruby Tuesday"
        };
        public List<Employee> ListOfEmployees = new List<Employee>();

        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void AddEmployees(Employee newEmployee)
        {
            ListOfEmployees.Add(newEmployee);
        }

        public string RandomRestaurant()
        {
            Random rand = new Random();
            int randRestaurant = rand.Next(restaurants.Count);

            return (restaurants[randRestaurant]);
        }

        public void Eat()
        {
           
            Console.WriteLine($"Employee is at the {RandomRestaurant()}");
        }
       

        public void Eat(string food)
        {
            Console.WriteLine($"{FirstName} ate {food} at the office");
        }

        public void Eat(List<Employee> companions)
        {
            for (var i = 0; i < companions.Count; i++)
            {
                var j = 0;
                if (i < companions.Count-1)
                {
                    j = i+1;
         
                }
             
                Console.WriteLine($"{companions[i].FirstName} is at the {RandomRestaurant()} with {companions[j].FirstName}" );
            }           
        }
        public void Eat(string food, List<Employee> companions)
        {
            for (var i = 0; i < companions.Count; i++)
            {
                var j = 0;
                if (i < companions.Count - 1)
                {
                    j = i + 1;

                }

                Console.WriteLine($"{companions[i].FirstName} is at the {RandomRestaurant()}  and ordered {food} with {companions[j].FirstName}");
            }
        }
    }
}
