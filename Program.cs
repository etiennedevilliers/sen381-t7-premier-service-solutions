﻿using System;
using Data.Layer.Objects;
using data.layer.controller;
using System.Collections.Generic;

namespace sen381_t7_premier_service_solutions
{
    class Program
    {
        static void Main(string[] args)
        {

            testPackage();

        }

        static void testAgents() {
            AgentController agentController = new AgentController();
            NewClientRequestController newClientRequestController = new NewClientRequestController();
            CallLogController callLogController = new CallLogController();
            RequestController requestController = new RequestController();

            Agent kaylee = new Agent(
                "kaylee",
                "0605272390",
                "unknown",
                "unknown"
            );

            Agent johan = new Agent(
                "kaylee",
                "0605272390",
                "unknown",
                "unknown"
            );

            CallLog callLog = new CallLog(DateTime.Now, DateTime.Now, false);
            NewClientRequest request = new NewClientRequest(DateTime.Now, DateTime.Now, callLog);

            Console.WriteLine("Creating callLog...");
            callLogController.Create(callLog);
            Console.WriteLine("Creating newClientRequest...");
            newClientRequestController.Create(request);
            Console.WriteLine("Creating kaylee...");
            agentController.Create(kaylee);
            Console.WriteLine("Creating johan...");
            agentController.Create(johan); // not added to any request
            Console.WriteLine("Adding kaylee to request...");
            requestController.Add(kaylee, request);
            
            Console.WriteLine("Reading children of request...");
            foreach (Agent agent in requestController.ReadChildren(request))
            {
                Console.WriteLine(agent);
            }
        }

        static void testRequests() {
            NewClientRequestController newClientRequestController = new NewClientRequestController();
            NewContractRequestController newContractRequestController = new NewContractRequestController();
            ComplaintRequestController complaintRequestController = new ComplaintRequestController();
            ServiceRequestController serviceRequestController = new ServiceRequestController();
            CallLogController callLogController = new CallLogController();

            Console.WriteLine("Setup new objects");
            CallLog callLog = new CallLog(DateTime.Now, DateTime.Now, false);
            ServiceRequest serviceRequest = new ServiceRequest(DateTime.Now, DateTime.Now, callLog, "insert test", DateTime.Now);


            Console.WriteLine("Creating new objects in Database");
            callLogController.Create(callLog);
            serviceRequestController.Create(serviceRequest);

            
            

            Console.WriteLine("Reading requests");
            List<Request> requests = new List<Request>();
            requests.AddRange(newClientRequestController.Read());
            requests.AddRange(newContractRequestController.Read());
            requests.AddRange(complaintRequestController.Read());
            requests.AddRange(serviceRequestController.Read());

            foreach (Request req in requests) {
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
            ServiceLevelAgreementController serviceLevelAgreementController = new ServiceLevelAgreementController();
            ServiceController serviceController = new ServiceController();

            Service cpurepairs = new Service(
                  4,
                  "CPU related repairs"
              );

            ServiceLevelAgreement Sla = new ServiceLevelAgreement(
                "50 char limit"
            );

            Package package = new Package(
                    "CPU Repairs",
                    "Anny CPU maintenance , replacemnet , servicing",
                    cpurepairs,
                    Sla
                );

            Console.WriteLine("Creating Service");
            serviceController.Create(cpurepairs);
            Console.WriteLine("Creating SLA");
            serviceLevelAgreementController.Create(Sla);
            Console.WriteLine("Creating Package");
            packagecontroler.Create(package);

            Console.WriteLine("Reading packages");
            foreach (Package pack in packagecontroler.Read())
            {
                Console.WriteLine(pack);
            }


        }
    }
}
