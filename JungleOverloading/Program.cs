using System;
using System.Collections.Generic;

namespace JungleOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            var randRestaurant = new Employee("Mary", "smith");
            randRestaurant.Eat();
            randRestaurant.Eat("salad");

            //List<Employee> companions = new List<Employee>();
            //companions.Add(randRestaurant);
            //randRestaurant.Eat(randRestaurant.ListOfEmployees);
            //Console.ReadLine();

            
            var employeeMary = new Employee("Mary", "Smith");
            randRestaurant.AddEmployees(employeeMary);
            var employeeBarny = new Employee("Barny", "White");
            randRestaurant.AddEmployees(employeeBarny);

            randRestaurant.Eat(randRestaurant.ListOfEmployees);
            Console.ReadLine();
        }
    }
}
