using System;
using System.Linq;
using System.Runtime.Remoting.Contexts;

namespace AirFranceCompagnie
{
    internal class Program
    {
        class Pilote
        {
            public Guid IdPilote { get; set; }
            public string Nom { get; set; }
            public string Prenom { get; set; }
            public DateTime DateNaissance { get; set; }
        }
        class Avion
        {
            public Guid IdAvion { get; set; }
            public string Modele { get; set; }
            public string Compagnie { get; set; }
        }
        class Vol
        {
            public Guid IdVol { get; set; }
            public DateTime DateDepart { get; set; }
            public DateTime DateArrive { get; set; }
            public Guid IdAvion { get; set; }
            public Guid IdPilote { get; set; }
            public string LieuDepart { get; set; }
            public string LieuArrivee { get; set; }
        }
        static void Main(string[] args)
        {
            //addPilote();
            //addAvion();
            //addVol();
            var context = new AirFranceEntities1();
            var toutLesPilotes = context.Pilote.Select(idPilote => idPilote).ToList();
            var toutLesAvions = context.Avion.Select(idAvion => idAvion).ToList();
            Guid test = new Guid("EE018F1D-AFA9-4277-8098-035B97D13C59");
            searchPilote(test);
        }

        private static void searchPilote(Guid IdPilote)
        {
            var context = new AirFranceEntities1();
            var toutLesVol = context.Vol.Where(vol => vol.IdPilote == IdPilote).ToList();
            var volTrouver = toutLesVol.Select(x => x.IdVol);
            var index = 1;
            Console.WriteLine("Les vols pour le pilote : " + IdPilote + " sont les suivants : ");
            foreach (var vol in volTrouver)
            {
                Console.WriteLine("Vol " + index + " " + vol);
                index++;

            }
            Console.ReadLine();
        }

        private static void addVol()
        {
            // Créer un tableau de 5 vols
            Vol[] vols = new Vol[5];
            var context = new AirFranceEntities1();

            var toutLesAvions = context.Avion.Select(idAvion => idAvion.IdAvion).ToList();
            var avion0 = toutLesAvions[0];
            var avion1 = toutLesAvions[1];
            var avion2 = toutLesAvions[2];
            var avion3 = toutLesAvions[3];
            var avion4 = toutLesAvions[4];

            var toutLesPilotes = context.Pilote.Select(idPilote => idPilote.IdPilote).ToList();
            var pilote0 = toutLesPilotes[0];
            var pilote1 = toutLesPilotes[1];
            var pilote2 = toutLesPilotes[2];
            var pilote3 = toutLesPilotes[3];
            var pilote4 = toutLesPilotes[4];

            var dateDepart = new DateTime(2023, 1, 7);
            var dateDepart1 = new DateTime(2023, 1, 7).AddDays(+1);
            var dateDepart2 = new DateTime(2023, 1, 7).AddDays(+2);
            var dateDepart3 = new DateTime(2023, 1, 7).AddDays(+3);
            var dateDepart4 = new DateTime(2023, 1, 7).AddDays(+1);

            var dateArrivee = dateDepart.AddHours(3);
            var dateArrivee1 = dateDepart1.AddHours(3);
            var dateArrivee2 = dateDepart2.AddHours(3);
            var dateArrivee3 = dateDepart3.AddHours(3);
            var dateArrivee4 = dateDepart4.AddHours(3);


            // Ajouter les vols avec leurs paramètres
            vols[0] = new Vol() { IdVol = Guid.NewGuid(), DateDepart = dateDepart, DateArrive = dateArrivee, IdAvion = avion0, IdPilote = pilote0, LieuDepart = "Paris", LieuArrivee = "Londre" };
            vols[1] = new Vol() { IdVol = Guid.NewGuid(), DateDepart = dateDepart1, DateArrive = dateArrivee1, IdAvion = avion1, IdPilote = pilote1, LieuDepart = "Lyon", LieuArrivee = "Paris" };
            vols[2] = new Vol() { IdVol = Guid.NewGuid(), DateDepart = dateDepart2, DateArrive = dateArrivee2, IdAvion = avion2, IdPilote = pilote2, LieuDepart = "Dublin", LieuArrivee = "Courthézon" };
            vols[3] = new Vol() { IdVol = Guid.NewGuid(), DateDepart = dateDepart3, DateArrive = dateArrivee3, IdAvion = avion3, IdPilote = pilote3, LieuDepart = "Madrid", LieuArrivee = "Marseille" };
            vols[4] = new Vol() { IdVol = Guid.NewGuid(), DateDepart = dateDepart4, DateArrive = dateArrivee4, IdAvion = avion4, IdPilote = pilote4, LieuDepart = "Berlin", LieuArrivee = "Miami" };

            // Ajouter chaque vol à la table vols de la base de données
            foreach (Vol vol in vols)
            {
                AirFranceCompagnie.Vol airFranceVol = new AirFranceCompagnie.Vol()
                {
                    IdVol = vol.IdVol,
                    DateDepart = vol.DateDepart,
                    DateArrive = vol.DateArrive,
                    IdAvion = vol.IdAvion,
                    IdPilote = vol.IdPilote,
                    LieuDepart = vol.LieuDepart,
                    LieuArrivee = vol.LieuArrivee
                };
                // Ajouter l'objet AirFranceCompagnie.vol à la table vol de la base de données
                context.Vol.Add(airFranceVol);
            }

            // Enregistrer les modifications dans la base de données
            context.SaveChanges();
        }

        static void addPilote()
        {
            // Créer un tableau de 5 pilotes
            Pilote[] pilotes = new Pilote[5];
            var context = new AirFranceEntities1();

            // Ajouter les pilotes avec leurs paramètres
            pilotes[0] = new Pilote() { IdPilote = Guid.NewGuid(), Nom = "Hamilton", Prenom = "Lewis", DateNaissance = new DateTime(1985, 1, 7) };
            pilotes[1] = new Pilote() { IdPilote = Guid.NewGuid(), Nom = "Verstappen", Prenom = "Max", DateNaissance = new DateTime(1997, 9, 30) };
            pilotes[2] = new Pilote() { IdPilote = Guid.NewGuid(), Nom = "Bottas", Prenom = "Valtteri", DateNaissance = new DateTime(1989, 8, 28) };
            pilotes[3] = new Pilote() { IdPilote = Guid.NewGuid(), Nom = "Norris", Prenom = "Lando", DateNaissance = new DateTime(1999, 11, 13) };
            pilotes[4] = new Pilote() { IdPilote = Guid.NewGuid(), Nom = "Leclerc", Prenom = "Charles", DateNaissance = new DateTime(1997, 10, 16) };

            // Ajouter chaque pilote à la table Pilote de la base de données
            foreach (Pilote pilote in pilotes)
            {
                AirFranceCompagnie.Pilote airFrancePilote = new AirFranceCompagnie.Pilote()
                {
                    IdPilote = pilote.IdPilote,
                    Nom = pilote.Nom,
                    Prenom = pilote.Prenom,
                    DateNaissance = pilote.DateNaissance
                };
                // Ajouter l'objet AirFranceCompagnie.Pilote à la table Pilote de la base de données
                context.Pilote.Add(airFrancePilote);
            }

            // Enregistrer les modifications dans la base de données
            context.SaveChanges();
        }

        static void addAvion()
        {
            // Créer un tableau de 5 avions
            Avion[] avions = new Avion[5];
            var context = new AirFranceEntities1();

            // Ajouter les avions avec leurs paramètres
            avions[0] = new Avion() { IdAvion = Guid.NewGuid(), Modele = "Airbus A320", Compagnie = "Air France" };
            avions[1] = new Avion() { IdAvion = Guid.NewGuid(), Modele = "Boeing 737", Compagnie = "Air France" };
            avions[2] = new Avion() { IdAvion = Guid.NewGuid(), Modele = "Airbus A380", Compagnie = "Air France" };
            avions[3] = new Avion() { IdAvion = Guid.NewGuid(), Modele = "Boeing 747", Compagnie = "Air France" };
            avions[4] = new Avion() { IdAvion = Guid.NewGuid(), Modele = "Embraer E-Jet", Compagnie = "Air France" };

            // Ajouter chaque avion à la table avion de la base de données
            foreach (Avion avion in avions)
            {
                AirFranceCompagnie.Avion airFranceAvion = new AirFranceCompagnie.Avion()
                {
                    IdAvion = avion.IdAvion,
                    Modele = avion.Modele,
                    Compagnie = avion.Compagnie
                };
                // Ajouter l'objet AirFranceCompagnie.avion à la table avion de la base de données
                context.Avion.Add(airFranceAvion);
            }

            // Enregistrer les modifications dans la base de données
            context.SaveChanges();
        }
    }
}
