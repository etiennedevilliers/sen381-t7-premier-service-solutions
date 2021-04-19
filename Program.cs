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

            testServiceContractAndPackage();

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

        static void testServiceContractAndPackage()
        {
            ServiceContractController serviceContractController = new ServiceContractController();
            PackageController packagecontroler = new PackageController();
            ServiceLevelAgreementController serviceLevelAgreementController = new ServiceLevelAgreementController();
            ServiceController serviceController = new ServiceController();
            ServiceRequestController serviceRequestController = new ServiceRequestController();
            CallLogController callLogController = new CallLogController();

            Service cpurepairs = new Service(
                  4,
                  "CPU related repairs"
              );
            
            Service gpuReplacement = new Service(
                4,
                "GPU replacements"
            );

            ServiceLevelAgreement Sla = new ServiceLevelAgreement(
                "50 char limit"
            );

            Package cpuPackage = new Package(
                "CPU Repairs",
                "Anny CPU maintenance , replacemnet , servicing",
                cpurepairs,
                Sla
            );

            Package gpuPackage = new Package(
                "GPU replacement",
                "Anny gpu maintenance , replacemnet , servicing",
                gpuReplacement,
                Sla
            );

            ServiceContract serviceContract = new ServiceContract(
                "PC Repair",
                1000.00,
                DateTime.Now,
                DateTime.Now,
                "normal"
            );

            CallLog callLog = new CallLog(DateTime.Now, DateTime.Now, false);

            ServiceRequest serviceRequest = new ServiceRequest(
                DateTime.Now,
                DateTime.Now,
                callLog,
                "Repair for broken PC",
                DateTime.Now
            );

            Console.WriteLine("Creating CPU Service");
            serviceController.Create(cpurepairs);
            Console.WriteLine("Creating GPU Service");
            serviceController.Create(gpuReplacement);

            Console.WriteLine("Creating SLA");
            serviceLevelAgreementController.Create(Sla);

            Console.WriteLine("Creating CPU Package");
            packagecontroler.Create(cpuPackage);
            Console.WriteLine("Creating CPU Package");
            packagecontroler.Create(gpuPackage);

            Console.WriteLine("Creating serviceContract");
            serviceContractController.Create(serviceContract);
            Console.WriteLine("Adding CPU package to serviceContract");
            serviceContractController.Add(cpuPackage, serviceContract);
            Console.WriteLine("Adding GPU package to serviceContract");
            serviceContractController.Add(gpuPackage, serviceContract);

            Console.WriteLine("Creating CallLog");
            callLogController.Create(callLog);
            Console.WriteLine("Creating ServiceRequest");
            serviceRequestController.Create(serviceRequest);
            Console.WriteLine("Setting service contract TO service request");
            serviceRequestController.Set(serviceContract, serviceRequest);


            Console.WriteLine("Reading Service contracts");
            foreach (ServiceContract contract in serviceContractController.Read())
            {
                Console.WriteLine(contract);
            }

            Console.WriteLine("Reading Service Requests Controller");

            foreach (Request req in serviceRequestController.Read()) {
                Console.WriteLine(req);
            }
        }
    }
}
