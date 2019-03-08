using System;
using System.Collections.Generic;
using System.Linq;
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
            var CompanionsName = "";
            var RandomEmployees = new Random().Next(0, companions.Count);
            List<Employee> buddy = ListOfEmployees.Where((employee, index) => companions[index].FirstName != companions[RandomEmployees].FirstName).ToList();

            var removeComma = buddy.Last();
            foreach (var companion in buddy)
            {
                CompanionsName += companion.FirstName;
                if (!companion.Equals(removeComma))
                {
                    CompanionsName += ", ";
                }
            }
            Console.WriteLine($"{companions[RandomEmployees].FirstName} is at the {RandomRestaurant()} with {CompanionsName}");
        }

        public void Eat(string food, List<Employee> companions)
        {
            var CompanionsName = "";
            var RandomEmployees = new Random().Next(0, companions.Count);
            List<Employee> buddy = ListOfEmployees.Where((employee, index) => companions[index].FirstName != companions[RandomEmployees].FirstName).ToList();

            var last = buddy.Last();
            foreach (var companion in buddy)
            {
                CompanionsName += companion.FirstName;
                if (!companion.Equals(last))
                {
                    CompanionsName += ", ";
                }
            }
                Console.WriteLine($"{companions[RandomEmployees].FirstName} is at the {RandomRestaurant()}  and ordered {food} with {CompanionsName}");
        }
        }
    }

