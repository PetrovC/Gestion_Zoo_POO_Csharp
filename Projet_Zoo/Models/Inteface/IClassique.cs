using Projet_Zoo.Models.Enum;

namespace Projet_Zoo.Models.Inteface
{
    public interface IClassique : IEnclo
    {
        public bool Bassin { get; }
        public double LargeurBassin { get; }
        public double LongueurBassin { get; }
        public double PronfondeurBassin { get; }
        public Enum_Environnements EnvironnementType { get; }
        public double HauteurGrillage { get; }
    }
}
