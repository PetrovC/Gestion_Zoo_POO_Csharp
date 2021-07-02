using Projet_Zoo.Models;
using System;

namespace Console_Zoo_Test
{
    class Test_Zoo
    {
        static void Main(string[] args)
        {
            bool choix = true;
            int choixActions;
            Zoo monZoo;
            while (choix)
            {
                Console.Clear();
                try
                {
                    do
                    {
                        Console.WriteLine("Bonjour dans gestion Zoo :");
                        Console.WriteLine("Editez votre Zoo tapez '0'");
                        Console.WriteLine("Pour crée un Enclo tapez '1'");
                        Console.WriteLine("Pour crée un Animal tapez '2'");
                    } while (!int.TryParse(Console.ReadLine(), out choixActions));
                    switch (choixActions)
                    {
                        case 0:
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
