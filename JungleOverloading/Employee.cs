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

        public void Eat()
        {
           
            Console.WriteLine($"Employee is at the {RandomRestaurant()}");
        }
        public string RandomRestaurant()
        {
            Random rand = new Random();
            int randRestaurant = rand.Next(restaurants.Count);
           
            return (restaurants[randRestaurant]);
        }

        public void Eat(string food)
        {
            Console.WriteLine($"{FirstName} ate {food} at the office");
        }

        public void Eat(List<Employee> buddy)
        {
            for (var i = 0; i < buddy.Count; i++)
            {
                var j = 0;
                if (i < buddy.Count-1) {
                    j = i+1;
         
                }
             
                Console.WriteLine($"{buddy[i].FirstName} is at the {RandomRestaurant()} with {buddy[j].FirstName}" );
            }           
     
        }
    }
}
