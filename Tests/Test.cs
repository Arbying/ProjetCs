using System;
using System.Reflection;
using Modele;

namespace Test
{
    class Test
    {
        static void Main(string[] args)
        {
            // Création d'un objet Personne avec le constructeur par défaut
            Modele.Personne personne1 = new Modele.Personne();

            // Affichage des propriétés de l'objet Personne
            Console.WriteLine("Personne 1 : " + personne1.ToString());

            // Modification des propriétés de l'objet Personne
            personne1.Nom = "Banushi";
            personne1.Prenom = "Arber";
            personne1.DateNaissance = new DateTime(1995, 3, 1);

            // Affichage des propriétés de l'objet Personne après modification
            Console.WriteLine("Personne 1 (après modification) : " + personne1.ToString());

            // Création d'un autre objet Personne avec le constructeur avec paramètres
            Modele.Personne personne2 = new Modele.Personne("Reinders", "Sebastien", new DateTime(1988, 7, 15));

            // Affichage des propriétés de l'objet Personne
            Console.WriteLine("Personne 2 : " + personne2.ToString());

            // Comparaison des deux objets Personne avec la méthode Equals
            bool isEqual = personne1.Equals(personne2);
            Console.WriteLine("Personne 1 est égale à Personne 2 ? " + isEqual);

            Console.ReadKey();
        }
    }
}
