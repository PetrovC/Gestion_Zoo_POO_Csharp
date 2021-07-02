using Projet_Zoo.Models.Enum;
using Projet_Zoo.Models.Inteface;
using System;

namespace Projet_Zoo.Models.ClassAnimaux
{
    public class Pingouins : Animaux, IEnclo, IClassique
    {
        private readonly double _temperature;
        private readonly double _longueur;
        private readonly double _largeur;
        private readonly bool _bassin;
        private readonly double _largeurBassin;
        private readonly double _longueurBassin;
        private readonly double _pronfondeurBassin;
        private readonly Enum_Environnements _environnementType;
        private readonly double _hauteurGrillage;
        public double LargeurBassin { get { return _largeurBassin; } }
        public double LongueurBassin { get { return _longueurBassin; } }
        public double PronfondeurBassin { get { return _pronfondeurBassin; } }
        public double Temperature { get { return _temperature; } }
        public double Longueur { get { return _longueur; } }
        public double Largeur { get { return _largeur; } }
        public bool Bassin { get { return _bassin; } }
        public Enum_Environnements EnvironnementType { get { return _environnementType; } }
        public double HauteurGrillage { get { return _hauteurGrillage; } }
        public Pingouins(string nom, double poids, double taille, Enum_Sexe sexe, DateTime datenaissance, ushort age, DateTime entreecage) : base(nom, poids, taille, sexe, datenaissance, age, entreecage)
        {
            _temperature = 2;
            _longueur = 4;
            _largeur = 5;
            _bassin = true;
            _largeurBassin = 3;
            _longueurBassin = 3;
            _pronfondeurBassin = 3;
            _environnementType = Enum_Environnements.Plaine;
            _hauteurGrillage = 3;
        }
    }
}
