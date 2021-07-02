using Projet_Zoo.Models.Enum;
using Projet_Zoo.Models.Inteface;
using System;

namespace Projet_Zoo.Models.ClassAnimaux
{
    public class Requins : Animaux, IEnclo, IAquarium
    {
        private readonly double _temperature;
        private readonly double _longueur;
        private readonly double _largeur;
        private readonly double _profondeur;
        private readonly double _salinite;
        public double Profondeur { get { return _profondeur; } }
        public double Salinite { get { return _salinite; } }
        public double Temperature { get { return _temperature; } }
        public double Longueur { get { return _longueur; } }
        public double Largeur { get { return _largeur; } }
        public Requins(string nom, double poids, double taille, Enum_Sexe sexe, DateTime datenaissance, ushort age, DateTime entreecage) : base(nom, poids, taille, sexe, datenaissance, age, entreecage)
        {
            _temperature = 8;
            _longueur = 2;
            _largeur = 2;
            _profondeur = 2;
            _salinite = 0.5;
        }
    }
}
