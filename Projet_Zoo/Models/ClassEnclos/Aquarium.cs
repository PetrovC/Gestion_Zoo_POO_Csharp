using System;

namespace Projet_Zoo.Models.Class
{
    public class Aquarium : Enclos
    {
        private double _salinite;
        public double Salinite { get { return _salinite; } set { _salinite = value; } }
        public double Volume { get { return _mesures.Volume; } }
        public double Profondeur { get { return _mesures.Hauteur; } }
        public Aquarium() : base()
        {
            _temperature = 0;
            _mesures.Longueur = 0;
            _mesures.Largeur = 0;
            _mesures.Hauteur = 0;
            _salinite = 0;
        }
        public Aquarium(string nom, double temperature, double longueur, double largeur, double profondeur, double salinite) : base(nom, temperature, longueur, largeur)
        {
            if (salinite < 0 && salinite > 1) throw new ArgumentOutOfRangeException("Bad Value la valeur doit être comprise entre 0 et 1");
            _mesures.Hauteur = profondeur;
            _salinite = salinite;
        }
        public override void AjouterIndividu<T>(ref T Individu)
        {
            if (_individus.GetType() != Individu.GetType()) throw new Exception("Peut pas rajouter un animal de differente espece");
            if (_individus.ContainsKey(Individu.Nom)) throw new ArgumentException("L'animal existe déjà.");
            _individus.Add(Individu.Nom, Individu);
            _temperature += Individu.Temperature;
            _mesures.Longueur += Individu.Longueur;
            _mesures.Largeur += Individu.Largeur;
            _mesures.Hauteur += Individu.Profondeur;
            _salinite += Individu.Salinite;
        }
        public override void SupprimerIndividu<T>(ref T Individu)
        {
            if (_individus.Count == 0) throw new ArgumentNullException("Dictionaire vide");
            if (!(_individus.ContainsKey(Individu.Nom))) throw new ArgumentNullException("No value in dictionary");
            _individus.Remove(Individu.Nom);
            _temperature -= Individu.Temperature;
            _mesures.Longueur -= Individu.Longueur;
            _mesures.Largeur -= Individu.Largeur;
            _mesures.Hauteur -= Individu.Profondeur;
            _salinite -= Individu.Salinite;
        }
    }
}
