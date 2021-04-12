using System;
using Data.Layer.Objects;
using data.layer.controller;
using System.Collections.Generic;

namespace sen381_t7_premier_service_solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessClient bus = new BusinessClient("078234825", "Busi");
            BusinessClientController cntr = new BusinessClientController();

            cntr.Create(bus);
            Console.WriteLine("Business client created");

            Employee emp = new Employee("Test", "Test", "Accountant", "0844353454");
            bus.AddEmployee(emp);

            Console.WriteLine("Employee created");

            List<BusinessClient> clients = cntr.Read();

            foreach (BusinessClient i in clients)
            {
                Console.WriteLine(i.GetEmployees());
            }

            Console.ReadLine();
        }
    }
}
