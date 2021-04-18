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
            testRequests();

            Console.ReadLine();

            testService();

            testSLA();


        }

        static void testRequests() {

            Console.WriteLine("Setup new objects");
            CallLog callLog = new CallLog(DateTime.Now, DateTime.Now, false);
            NewClientRequest newClientRequest = new NewClientRequest(DateTime.Now, DateTime.Now, callLog);

            Console.WriteLine("Creating callLog");
            new CallLogController().Create(callLog);
            NewClientRequestController newClientRequestController = new NewClientRequestController();

            Console.WriteLine("Creating newClientRequest");
            newClientRequestController.Create(newClientRequest);

            Console.WriteLine("newClientRequestController.Read()");
            foreach (NewClientRequest req in newClientRequestController.Read()) {
                Console.WriteLine(req);
            }
        
        }

        static void testClients() {
            
            BusinessClient bus = new BusinessClient("078234825", "Busi");
            BusinessClientController cntr = new BusinessClientController();

            List<BusinessClient> clients = cntr.Read();

            foreach (BusinessClient i in clients)
            {
                Console.WriteLine(i);
                foreach (Employee e in i.employees)
                {
                    Console.WriteLine(string.Format("\t-{0}", e));
                }

            }
        }


        static void testService()
        {
          
            ServiceController servicecontroler = new ServiceController();

            Service cpurepairs = new Service(
                    4,
                    "CPU related repairs"
                );

            Console.WriteLine("Creating CPU repair services ...");
            servicecontroler.Create(cpurepairs);

            foreach (Service service in servicecontroler.Read())
            {
                Console.WriteLine(service);
            }

        }

        static void testSLA()
        {
            ServiceLevelAgreementController SLAControler = new ServiceLevelAgreementController();
            ServiceLevelAgreement Sla = new ServiceLevelAgreement("CPU Repair service agreement between customer and corperation");

            Console.WriteLine("Creating the Service Level agreement");

            foreach (ServiceLevelAgreement sla in SLAControler.Read())
            {
                Console.WriteLine(sla);
            }
        }

        static void testPackage()
        {
            PackageController packagecontroler = new PackageController();

            Service cpurepairs = new Service(
                  4,
                  "CPU related repairs"
              );

            ServiceLevelAgreement Sla = new ServiceLevelAgreement("CPU Repair service agreement between customer and corperation");

            Package package = new Package(
                    2,
                    "CPU Repairs",
                    "Anny CPU maintenance , replacemnet , servicing",
                    cpurepairs,
                    Sla
                );


            foreach (Package pack in packagecontroler.Read())
            {
                Console.WriteLine();
            }


        }
    }
}
