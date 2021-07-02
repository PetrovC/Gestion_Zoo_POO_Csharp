namespace Projet_Zoo.Models.Struct
{
    public struct StructMesure
    {
        public double Longueur { get; set; }
        public double Largeur { get; set; }
        public double Hauteur { get; set; }
        public double Superficie { get { return Longueur * Largeur; } }
        public double Volume { get { return Longueur * Largeur * Hauteur; } }
    }
}
