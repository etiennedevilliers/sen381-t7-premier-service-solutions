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
            testRequests();

            Console.ReadLine();
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

            Console.WriteLine("Creating ComplaintRequest");
            ComplaintRequestController complaintRequestController = new ComplaintRequestController();
            ComplaintRequest complaintRequest = new ComplaintRequest(DateTime.Now, DateTime.Now, callLog, "description!!!");
            complaintRequestController.Create(complaintRequest);


            Console.WriteLine("Reading requests");
            List<Request> requests = new List<Request>();
            requests.AddRange(newClientRequestController.Read());
            requests.AddRange(complaintRequestController.Read());


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
    }
}
