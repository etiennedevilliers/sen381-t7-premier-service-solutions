using System;
using Data.Layer.Objects;
using data.layer.controller;

namespace sen381_t7_premier_service_solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualClient ind = new IndividualClient("0829038430", "Piet", "Broos");
            IndividualClientController cntr = new IndividualClientController();
            ind.id = 17;

            cntr.Delete(ind);

            foreach (Client i in cntr.Read())
            {
                Console.WriteLine(i.ToString());
            }
            
            Console.ReadLine();
        }
    }
}
