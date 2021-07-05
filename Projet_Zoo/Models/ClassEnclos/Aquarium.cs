using Projet_Zoo.Models.Inteface;
using System;

namespace Projet_Zoo.Models.ClassEnclo
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
            if (salinite < 0 && salinite > 1) throw new ArgumentOutOfRangeException("Bad value, must be between 0 and 1 ");
            _mesures.Hauteur = profondeur;
            _salinite = salinite;
        }
        public override void AjouterIndividu<A>(A Individu)
        {
            if (_individus.GetType() != Individu.GetType()) throw new Exception("Can not add an animal of different species");
            if (_individus.ContainsKey(Individu.Nom)) throw new ArgumentException("The animal already exists");
            _individus.Add(Individu.Nom, Individu);
            _temperature += Individu.Temperature;
            _mesures.Longueur += Individu.Longueur;
            _mesures.Largeur += Individu.Largeur;
            IAquarium Temp = Individu as IAquarium;
            _mesures.Hauteur += Temp.Profondeur;
            _salinite += Temp.Salinite;
        }
        public override void SupprimerIndividu<A>(A Individu)
        {
            if (_individus.Count == 0) throw new ArgumentNullException("Empty dictionary");
            if (!(_individus.ContainsKey(Individu.Nom))) throw new ArgumentNullException("Value does not exist in the dictionary");
            _individus.Remove(Individu.Nom);
            _temperature -= Individu.Temperature;
            _mesures.Longueur -= Individu.Longueur;
            _mesures.Largeur -= Individu.Largeur;
            IAquarium Temp = Individu as IAquarium;
            _mesures.Hauteur -= Temp.Profondeur;
            _salinite -= Temp.Salinite;
        }
    }
}
