using Projet_Zoo.Models.Enum;
using Projet_Zoo.Models.Inteface;
using Projet_Zoo.Models.Struct;
using System;

namespace Projet_Zoo.Models.ClassEnclo
{
    public class Classique : Enclos
    {
        private Enum_Environnements _environnementType;
        private bool _bassin;
        private double _grillagehauteur;
        private StructMesure _mesuresBassin;
        public StructMesure MesuresBassin { get { return _mesuresBassin; } }
        public double Grillage { get { return _grillagehauteur; } }
        public bool Bassin { get { return _bassin; } }
        public Enum_Environnements Environnement { get { return _environnementType; } }
        public Classique() : base()
        {
            _temperature = 0;
            _mesures.Longueur = 0;
            _mesures.Largeur = 0;
            _grillagehauteur = 0;
            _mesuresBassin.Longueur = 0;
            _mesuresBassin.Largeur = 0;
            _mesuresBassin.Hauteur = 0;
        }
        public Classique(string nom, double temperature, double longueur, double largeur, ushort environnement, double grillage) : base(nom, temperature, longueur, largeur)
        {
            _environnementType = (Enum_Environnements)environnement;
            _bassin = false;
            _grillagehauteur = grillage;
        }
        public Classique(string nom, double temperature, double longueur, double largeur, ushort environnement, double grillage, double longueurbassin, double largeurbassin, double hauteurbassin) : this(nom, temperature, longueur, largeur, environnement, grillage)
        {
            if (longueurbassin > longueur && largeurbassin > largeur) throw new ArgumentOutOfRangeException("The pond cannot be larger than the enclosure ");
            _bassin = true;
            _mesuresBassin.Hauteur = hauteurbassin;
            _mesuresBassin.Longueur = longueurbassin;
            _mesuresBassin.Largeur = largeurbassin;
        }
        public override void AjouterIndividu<A>(A Individu)
        {
            if (_individus.GetType() != Individu.GetType()) throw new Exception("Can not add an animal of different species");
            if (_individus.ContainsKey(Individu.Nom)) throw new ArgumentException("The animal already exists");
            _individus.Add(Individu.Nom, Individu);
            _temperature += Individu.Temperature;
            _mesures.Longueur += Individu.Longueur;
            _mesures.Largeur += Individu.Largeur;
            IClassique Temp = Individu as IClassique;
            _grillagehauteur += Temp.HauteurGrillage;
            _environnementType = Temp.EnvironnementType;
            _bassin = Temp.Bassin;
            if (_bassin)
            {
                _mesuresBassin.Longueur += Temp.LongueurBassin;
                _mesuresBassin.Largeur += Temp.LargeurBassin;
                _mesuresBassin.Hauteur += Temp.PronfondeurBassin;
            }
        }
        public override void SupprimerIndividu<A>(A Individu)
        {
            if (_individus.GetType() != Individu.GetType()) throw new Exception("Empty dictionary");
            if (_individus.ContainsKey(Individu.Nom)) throw new ArgumentException("Value does not exist in the dictionary");
            _individus.Add(Individu.Nom, Individu);
            _temperature -= Individu.Temperature;
            _mesures.Longueur -= Individu.Longueur;
            _mesures.Largeur -= Individu.Largeur;
            IClassique Temp = Individu as IClassique;
            _grillagehauteur -= Temp.HauteurGrillage;
            _environnementType = Temp.EnvironnementType;
            _bassin = Temp.Bassin;
            if (_bassin)
            {
                _mesuresBassin.Longueur -= Temp.LongueurBassin;
                _mesuresBassin.Largeur -= Temp.LargeurBassin;
                _mesuresBassin.Hauteur -= Temp.PronfondeurBassin;
            }
        }
    }
}
