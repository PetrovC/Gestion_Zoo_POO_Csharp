using Projet_Zoo.Models;
using Projet_Zoo.Models.ClassAnimaux;
using Projet_Zoo.Models.ClassEnclo;
using Projet_Zoo.Models.Enum;
using Projet_Zoo.Models.Struct;
using System;

namespace Console_Zoo_Test
{
    class Test_Zoo
    {
        static void Main(string[] args)
        {
            bool choix = true;
            int choixActions;
            Zoo monZoo = new Zoo();
            Classique monClassique = new Classique();
            Tigres monTigre = new Tigres("salut", 125, 2, Enum_Sexe.Male, DateTime.Now, 10, DateTime.Now);
            monZoo.AjouterEnclo(monClassique);
            monClassique.AjouterIndividu(monTigre);
            while (choix)
            {
                Console.Clear();
                try
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Bonjour dans gestion Zoo :");
                        Console.WriteLine("Editez votre Zoo tapez '0'");
                        Console.WriteLine("Pour crée un Enclo tapez '1'");
                        Console.WriteLine("Pour crée un Animal tapez '2'");
                    } while (!int.TryParse(Console.ReadLine(), out choixActions));
                    switch (choixActions)
                    {
                        case 0:
                            Console.WriteLine("Entrez le nom de votre Zoo :");
                            monZoo.Name = Console.ReadLine();
                            Console.WriteLine("Entrez l'adresse de votre Zoo :");
                            StructAdresse adresse = new StructAdresse();
                            Console.WriteLine("Entrez la rue de votre Zoo :");
                            adresse.Rue = Console.ReadLine();
                            Console.WriteLine("Entrez le numero de votre Zoo :");
                            adresse.Numero = Console.ReadLine();
                            Console.WriteLine("Entrez le code postal de votre Zoo :");
                            adresse.CodePostal = Console.ReadLine();
                            Console.WriteLine("Entrez la localite de votre Zoo :");
                            adresse.Localite = Console.ReadLine();
                            Console.WriteLine("Entrez le pays de votre Zoo :");
                            adresse.Pays = Console.ReadLine();
                            monZoo.Adresse = adresse;
                            Console.Clear();
                            break;
                        case 1:
                            break;
                        case 2:
                            break;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}
