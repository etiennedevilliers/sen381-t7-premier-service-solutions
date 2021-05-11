using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Layer.Controller;
using Data.Layer.Objects;

namespace Logic
{
    class ClientMaintenanceLogic
    {
        private static char GetRandomCharacter(string text, Random rng)
        {
            int index = rng.Next(text.Length);
            return text[index];
        }
        public static string GenerateUniqueClientID()
        {
            IndividualClientController clientController = new IndividualClientController();
            BusinessClientController businessClientController = new BusinessClientController();
            Random random = new Random();

            List<Client> clients = new List<Client>();
            clients.AddRange(clientController.Read());
            clients.AddRange(businessClientController.Read());


            Boolean done = false;
            string a = "";

            while (!done)
            {
                int i = random.Next(0,99999999);
                string chars = "ABCDE";
                a = String.Format("{0}{1:00000000}", GetRandomCharacter(chars, random), i);
                done = true;

                foreach (Client c in clients)
                {
                    if (a.Equals(c.ClientIdentifier)) {
                        done = false;
                    }
                }
            }
            
            return a;
        }
    
        public static void AddEquipmentToClient(Client client, Equipment equipment)
        {
            ClientController clientController = new ClientController();

            clientController.equipment.Add(equipment, client);
        }

        public static void RemoveEquipmentFromClient(Client client, Equipment equipment)
        {
            ClientController clientController = new ClientController();

            clientController.equipment.Remove(equipment, client);
        }
    }
}
