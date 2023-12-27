using SixthApp.FirstProgram;
using SixthApp.SecondProgram;

namespace SixthApp
{
    public class Program
    {
        static void Main()
        {
            var anonymousTypeExample = new AnonymousTypeExample();
            anonymousTypeExample.СomparisonWithVenus();

            var catalog = new PlanetCatalog();

            var firsPlanet = catalog.GetPlanet("Earth");
            var secondPlanet = catalog.GetPlanet("Limonia");
            var thirdPlanet = catalog.GetPlanet("Mars");


            var earth = catalog.GetPlanet("earth", catalog.Validate);
            var limonia = catalog.GetPlanet("Limonia", catalog.Validate);
            var mars = catalog.GetPlanet("Mars", catalog.Validate);

            

            var checkPlanet = (string x) =>
            {
                if (x == "Limonia")
                {
                    Console.WriteLine("Это запретная планета");
                    return "Это запретная планета";
                }
                return null;
            };

            var checkLimonia = checkPlanet("Limonia");
            var checkEarth = checkPlanet("earth");
            var checkMArs = checkPlanet("Mars");


        }
    }
}