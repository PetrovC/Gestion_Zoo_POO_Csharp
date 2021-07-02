using Projet_Zoo.Models.Enum;
using Projet_Zoo.Models.Inteface;
using System;

namespace Projet_Zoo.Models.ClassAnimaux
{
    public class Girafes : Animaux, IEnclo, IClassique
    {
        private readonly double _temperature;
        private readonly double _longueur;
        private readonly double _largeur;
        private readonly bool _bassin;
        private readonly Enum_Environnements _environnementType;
        private readonly double _hauteurGrillage;
        public double LargeurBassin { get { return default; } }
        public double LongueurBassin { get { return default; } }
        public double PronfondeurBassin { get { return default; } }
        public double Temperature { get { return _temperature; } }
        public double Longueur { get { return _longueur; } }
        public double Largeur { get { return _largeur; } }
        public bool Bassin { get { return _bassin; } }
        public Enum_Environnements EnvironnementType { get { return _environnementType; } }
        public double HauteurGrillage { get { return _hauteurGrillage; } }
        public Girafes(string nom, double poids, double taille, Enum_Sexe sexe, DateTime datenaissance, ushort age, DateTime entreecage) : base(nom, poids, taille, sexe, datenaissance, age, entreecage)
        {
            _temperature = 22;
            _longueur = 3;
            _largeur = 3;
            _bassin = false;
            _environnementType = Enum_Environnements.Plaine;
            _hauteurGrillage = 10;
        }
    }
}
