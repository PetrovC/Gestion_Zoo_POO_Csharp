using Projet_Zoo.Models.Enum;
using Projet_Zoo.Models.Struct;
using System;

namespace Projet_Zoo.Models.Class
{
    public class EnclosClassique : Enclos
    {
        private Enum_Environnements _environnementType;
        private bool _bassin;
        private double _grillagehauteur;
        private StructMesure _mesuresBassin;
        public StructMesure MesuresBassin { get { return _mesuresBassin; } }
        public double Grillage { get { return _grillagehauteur; } }
        public bool Bassin { get { return _bassin; } }
        public Enum_Environnements Environnement { get { return _environnementType; } }
        public EnclosClassique() : base()
        {
            _temperature = 0;
            _mesures.Longueur = 0;
            _mesures.Largeur = 0;
            _grillagehauteur = 0;
            _mesuresBassin.Longueur = 0;
            _mesuresBassin.Largeur = 0;
            _mesuresBassin.Hauteur = 0;
        }
        public EnclosClassique(string nom, double temperature, double longueur, double largeur, ushort environnement, double grillage) : base(nom, temperature, longueur, largeur)
        {
            _environnementType = (Enum_Environnements)environnement;
            _bassin = false;
            _grillagehauteur = grillage;
        }
        public EnclosClassique(string nom, double temperature, double longueur, double largeur, ushort environnement, double grillage, double longueurbassin, double largeurbassin, double hauteurbassin) : this(nom, temperature, longueur, largeur, environnement, grillage)
        {
            if (longueurbassin > longueur && largeurbassin > largeur) throw new ArgumentOutOfRangeException("Le bassin ne peut pas être plus grand que l'enclos");
            _bassin = true;
            _mesuresBassin.Hauteur = hauteurbassin;
            _mesuresBassin.Longueur = longueurbassin;
            _mesuresBassin.Largeur = largeurbassin;
        }
        public override void AjouterIndividu<T>(ref T Individu)
        {
            if (_individus.GetType() != Individu.GetType()) throw new Exception("Peut pas rajouter un animal de differente espece");
            if (_individus.ContainsKey(Individu.Nom)) throw new ArgumentException("L'animal existe déjà.");
            _individus.Add(Individu.Nom, Individu);
            _temperature += Individu.Temperature;
            _mesures.Longueur += Individu.Longueur;
            _mesures.Largeur += Individu.Largeur;
            _grillagehauteur += Individu.HauteurGrillage;
            _environnementType = Individu.EnvironnementType;
            _bassin = Individu.Bassin;
            if (_bassin)
            {
                _mesuresBassin.Longueur += Individu.LongueurBassin;
                _mesuresBassin.Largeur += Individu.LargeurBassin;
                _mesuresBassin.Hauteur += Individu.PronfondeurBassin;
            }
        }
        public override void SupprimerIndividu<T>(ref T Individu)
        {
            if (_individus.GetType() != Individu.GetType()) throw new Exception("Peut pas rajouter un animal de differente espece");
            if (_individus.ContainsKey(Individu.Nom)) throw new ArgumentException("L'animal existe déjà.");
            _individus.Add(Individu.Nom, Individu);
            _temperature -= Individu.Temperature;
            _mesures.Longueur -= Individu.Longueur;
            _mesures.Largeur -= Individu.Largeur;
            _grillagehauteur -= Individu.HauteurGrillage;
            _environnementType = Individu.EnvironnementType;
            _bassin = Individu.Bassin;
            if (_bassin)
            {
                _mesuresBassin.Longueur -= Individu.LongueurBassin;
                _mesuresBassin.Largeur -= Individu.LargeurBassin;
                _mesuresBassin.Hauteur -= Individu.PronfondeurBassin;
            }
        }
    }
}
