
namespace SixthApp
{
    public class Planet
    {
        public string Name { get; set; }
        public int OrdinalNumber { get; set; }
        public int EquatorLength { get; set; }
        public Planet? PreviousPlanet { get; set; }

        public Planet(string name, int ordinalNumber, int equatorLength, Planet previousPlanet)
        {
            Name = name;
            OrdinalNumber = ordinalNumber;
            EquatorLength = equatorLength;
            PreviousPlanet = previousPlanet;
        }

        public Planet()
        {
        }
    }
}
