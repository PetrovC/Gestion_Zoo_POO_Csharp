using Projet_Zoo.Models.Enum;
using System;

namespace Projet_Zoo.Models.ClassAnimaux
{
    public abstract class Animaux
    {
        private string _nom;
        private double _poids;
        private double _taille;
        private Enum_Sexe _sexe;
        private DateTime _dateNaissance;
        private ushort _age;
        private DateTime _entreeCage;
        public DateTime EntreeCage { get { return _entreeCage; } }
        public ushort Age { get { return _age; } }
        public DateTime DateNaissance { get { return _dateNaissance; } }
        public Enum_Sexe Sexe { get { return _sexe; } }
        public double Taille { get { return _taille; } }
        public double Poids { get { return _poids; } }
        public string Nom { get { return _nom; } }
        public Animaux(string nom, double poids, double taille, Enum_Sexe sexe, DateTime datenaissance, ushort age, DateTime entreecage)
        {
            _nom = nom;
            _poids = poids;
            _taille = taille;
            _sexe = sexe;
            _dateNaissance = datenaissance;
            _age = age;
            _entreeCage = entreecage;
        }
    }
}
