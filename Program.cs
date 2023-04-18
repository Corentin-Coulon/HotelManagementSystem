using System.Collections;

namespace HotelManagementSystem
{
    internal class Program
    {
        class Client
        {
            // Propriétés
            public string Nom { get; set; }
            public string Prenom { get; set; }
            public string Courriel { get; set; }
            public string CarteCredit { get; set; }
            public int NumeroChambre { get; set; }

            // Constructeur
            public Client(string nom, string prenom, string courriel, string carteCredit, int numeroChambre)
            {
                Nom = nom;
                Prenom = prenom;
                Courriel = courriel;
                CarteCredit = carteCredit;
                NumeroChambre = numeroChambre;
            }
        }

        // Classe Hotel
        class Hotel
        {
            // Propriétés
            public ArrayList Clients { get; set; }

            // Constructeur
            public Hotel()
            {
                Clients = new ArrayList();
            }

            // Méthode pour ajouter un client
            public void AjouterClient(Client client)
            {
                Clients.Add(client);
            }
        }

        // Classe principale Program
        class ProgramHotel
        {
            static void Main(string[] args)
            {
                // Création d'un hôtel
                Hotel hotel = new Hotel();

                // Création de clients
                Client client1 = new Client("Johnson", "Maria", "maria.johnson@gmail.com", "1234567890123456", 101);
                Client client2 = new Client("Smith", "James", "james.smith@gmail.com", "9876543210987654", 202);

                // Ajout des clients à l'hôtel
                hotel.AjouterClient(client1);
                hotel.AjouterClient(client2);

                // Affichage des informations des clients dans la console
                Console.WriteLine("Liste des clients de l'hôtel :");
                foreach (Client client in hotel.Clients)
                {
                    Console.WriteLine($"Nom : {client.Nom}");
                    Console.WriteLine($"Prénom : {client.Prenom}");
                    Console.WriteLine($"Courriel : {client.Courriel}");
                    Console.WriteLine($"Carte de crédit : {client.CarteCredit}");
                    Console.WriteLine($"Numéro de chambre : {client.NumeroChambre}");
                    Console.WriteLine();
                }

                // Attente de l'appui sur une touche pour quitter
                Console.WriteLine("Appuyez sur une touche pour quitter...");
                Console.ReadKey();
            }
        }
        //modif master
    }
}