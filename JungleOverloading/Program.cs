using System;
using System.Collections.Generic;

namespace JungleOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            var randRestaurant = new Employee("Mary", "smith");
            
            var employeeMary = new Employee("Mary", "Smith");
            randRestaurant.AddEmployees(employeeMary);
            var employeeBarny = new Employee("Barny", "White");
            randRestaurant.AddEmployees(employeeBarny);
            var employeeGrace = new Employee("Grace", "Lee");
            randRestaurant.AddEmployees(employeeGrace);

            randRestaurant.Eat();
            randRestaurant.Eat("salad");
            randRestaurant.Eat(randRestaurant.ListOfEmployees);
            randRestaurant.Eat("dosa", randRestaurant.ListOfEmployees);
            Console.ReadLine();
        }
    }
}
