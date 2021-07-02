using Projet_Zoo.Models.Class;
using Projet_Zoo.Models.Struct;
using System;
using System.Collections.Generic;

namespace Projet_Zoo.Models
{
    public class Zoo
    {
        private string _name;
        private StructAdresse _adresse;
        private readonly Dictionary<string, Enclos> _enclos;
        public Dictionary<string, Enclos> Enclos { get { return _enclos; } }
        public string Name { get { return _name; } set { _name = value; } }
        public StructAdresse Adresse { get { return _adresse; } set { _adresse = value; } }
        public double SuperficieTotale
        {
            get
            {
                if (_enclos is null) throw new ArgumentNullException("No values");
                double superficieZoo = 0;
                foreach (KeyValuePair<string, Enclos> item in _enclos)
                {
                    superficieZoo += item.Value.Mesures.Superficie * 2.2;
                }
                return superficieZoo;
            }
        }
        public Zoo(string nom)
        {
            _name = nom;
            _enclos = new Dictionary<string, Enclos>();
        }
        public Zoo(string nom, string rue, string numero, string codepostal, string localite, string pays) : this(nom)
        {
            _adresse.Rue = rue;
            _adresse.Numero = numero;
            _adresse.CodePostal = codepostal;
            _adresse.Localite = localite;
            _adresse.Pays = pays;
        }
        public void AjouterEnclo(Enclos enclo)
        {
            if (_enclos.ContainsKey(enclo.Nom)) throw new ArgumentException("L'enclos existe déjà.");
            _enclos.Add(enclo.Nom, enclo);
        }
        public void SupprimerEnclo(Enclos enclo)
        {
            if (_enclos.Count == 0) throw new ArgumentNullException("Dictionaire vide");
            if (!(_enclos.ContainsKey(enclo.Nom))) throw new ArgumentNullException("No value in dictionary");
            _enclos.Remove(enclo.Nom);
        }
    }
}
