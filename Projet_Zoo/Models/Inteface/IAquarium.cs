namespace Projet_Zoo.Models.Inteface
{
    public interface IAquarium : IEnclo
    {
        public double Profondeur { get; }
        public double Salinite { get; }
    }
}
