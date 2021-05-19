using Data.Layer.Controller;
using Data.Layer.Objects;
using Logic.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ClientMaintenance
{
    class ClientLogic
    {
        IndividualClientController indCtr = new IndividualClientController();
        BusinessClientController busCtr = new BusinessClientController();
        ClientController clientCtr = new ClientController();

        GeneralLogic genLogic = new GeneralLogic();

        public void DeleteClient(Client client)
        {
            //Delete Children

            if (client is IndividualClient)
            {
                indCtr.Delete((IndividualClient) client);
            }
            else
            {
                busCtr.Delete((BusinessClient) client);
            }
        }

        public void CreateClient(Client client)
        {
            if (client is IndividualClient)
            {
                indCtr.Create((IndividualClient) client);
            }
            else
            {
                BusinessClient bus = (BusinessClient) client;
                busCtr.Create(bus);

                foreach (Employee i in bus.Employees)
                {
                    busCtr.Add(i, bus);
                }
            }

            foreach (Equipment i in client.Equipment)
            {
                clientCtr.equipment.Add(i, client);
            }

            foreach (Address i in client.Addresses)
            {
                clientCtr.address.Add(i, client);
            }
        }

        public void UpdateIndClient(Client client, List<Equipment> oldEquipment, List<Address> oldAddresses)
        { 
            indCtr.Update((IndividualClient) client);

            foreach (Equipment i in genLogic.GetAddedItems(oldEquipment, client.Equipment))
            {
                clientCtr.equipment.Add(i, client);
            }

            foreach (Equipment i in genLogic.GetRemovedItems(oldEquipment, client.Equipment))
            {
                clientCtr.equipment.Remove(i, client);
            }

            foreach (Address i in genLogic.GetAddedItems(oldAddresses, client.Addresses))
            {
                clientCtr.address.Add(i, client);
            }

            foreach (Address i in genLogic.GetRemovedItems(oldAddresses, client.Addresses))
            {
                clientCtr.address.Remove(i, client);
            }
        }

        public void UpdateBusClient(Client client, List<Equipment> oldEquipment, List<Address> oldAddresses, List<Employee> oldEmployees)
        {
            BusinessClient bus = (BusinessClient) client;
            busCtr.Update(bus);

            foreach (Employee i in genLogic.GetAddedItems(oldEmployees, bus.Employees))
            {
                busCtr.Add(i, bus);
            }

            foreach (Employee i in genLogic.GetRemovedItems(oldEmployees, bus.Employees))
            {
                busCtr.Remove(i, bus);
            }

            foreach (Equipment i in genLogic.GetAddedItems(oldEquipment, client.Equipment))
            {
                clientCtr.equipment.Add(i, client);
            }

            foreach (Equipment i in genLogic.GetRemovedItems(oldEquipment, client.Equipment))
            {
                clientCtr.equipment.Remove(i, client);
            }

            foreach (Address i in genLogic.GetAddedItems(oldAddresses, client.Addresses))
            {
                clientCtr.address.Add(i, client);
            }

            foreach (Address i in genLogic.GetRemovedItems(oldAddresses, client.Addresses))
            {
                clientCtr.address.Remove(i, client);
            }
        }

        private char GetRandomCharacter(string text, Random rng)
        {
            int index = rng.Next(text.Length);
            return text[index];
        }

        public string GenerateUniqueClientID()
        {
            IndividualClientController clientController = new IndividualClientController();
            BusinessClientController businessClientController = new BusinessClientController();
            Random random = new Random();

            List<Client> clients = new List<Client>();
            clients.AddRange(clientController.Read());
            clients.AddRange(businessClientController.Read());

            bool done = false;
            string a = "";

            while (!done)
            {
                int i = random.Next(0, 99999999);
                string chars = "ABCDE";
                a = string.Format("{0}{1:00000000}", GetRandomCharacter(chars, random), i);
                done = true;

                foreach (Client c in clients)
                {
                    if (a.Equals(c.ClientIdentifier))
                    {
                        done = false;
                    }
                }
            }

            return a;
        }

        public void AddServiceContract(NewContractRequest req, DateTime startDate, DateTime endDate)
        {
            ClientServiceContract child = new ClientServiceContract(startDate, endDate, req.ServiceContract);

            clientCtr.serviceContract.Add(child, req.Client);
        }
    }
}
