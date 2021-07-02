using Projet_Zoo.Models.ClassAnimaux;
using Projet_Zoo.Models.Inteface;
using Projet_Zoo.Models.Struct;
using System;
using System.Collections.Generic;

namespace Projet_Zoo.Models.Class
{
    public abstract class Enclos
    {
        private readonly string _nom;
        protected double _temperature;
        protected StructMesure _mesures;
        protected Dictionary<string, Animaux> _individus;
        public Dictionary<string, Animaux> Individus { get { return _individus; } }
        public StructMesure Mesures { get { return _mesures; } }
        public double Temperature { get { return _temperature; } set { _temperature = value; } }
        public string Nom { get { return _nom; } }
        public Enclos() { _individus = new Dictionary<string, Animaux>(); }
        public Enclos(string nom, double temperature, double longueur, double largeur)
        {
            if (longueur < 2 && largeur < 2) throw new ArgumentOutOfRangeException("Bad Value 2 mètres min");
            _nom = nom;
            _temperature = temperature;
            _mesures.Longueur = longueur;
            _mesures.Largeur = largeur;
            _individus = new Dictionary<string, Animaux>();
        }
        public abstract void AjouterIndividu<T>(ref T Individu) where T : Animaux, IEnclo, IClassique, IAquarium;
        public abstract void SupprimerIndividu<T>(ref T Individu) where T : Animaux, IEnclo, IClassique, IAquarium;
    }
}
