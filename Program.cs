using SixthApp.FirstProgram;
using SixthApp.SecondProgram;

namespace SixthApp
{
    public class Program
    {
        static void Main()
        {
            var callCounter = 0;
            var anonymousTypeExample = new AnonymousTypeExample();
            anonymousTypeExample.СomparisonWithVenus();

            var catalog = new PlanetCatalog();

            var firsPlanet = catalog.GetPlanet("Earth");
            var secondPlanet = catalog.GetPlanet("Limonia");
            var thirdPlanet = catalog.GetPlanet("Mars");

            var earth = catalog.GetPlanet("earth", catalog.Validate);
            var limonia = catalog.GetPlanet("Limonia", catalog.Validate);
            var mars = catalog.GetPlanet("Mars", catalog.Validate);


            //var checkPlanet = (string x) =>
            //{
            //    if (x == "Limonia")
            //    {
            //        Console.WriteLine("Это запретная планета");
            //        return "Это запретная планета";
            //    }
            //    return null;
            //};
            var earth1 = catalog.GetPlanet("Earth", (string x) =>
            {
                callCounter++;

                if (callCounter == 3)
                {
                    callCounter = 0;
                    return ("Вы спрашиваете слишком часто");
                }

                var planet = catalog.PlanetList.Where(i => i.Name.ToUpper() == "Mars");

                if (planet != null)
                {
                    return ("");
                }

                return ("Не удалось найти планету");
            });
            var limonia1 = catalog.GetPlanet("Limonia", (string x) =>
            {
                callCounter++;

                if (callCounter == 3)
                {
                    callCounter = 0;
                    return ("Вы спрашиваете слишком часто");
                }

                var planet = catalog.PlanetList.Where(i => i.Name.ToUpper() == "Mars");

                if (planet != null)
                {
                    return ("");
                }

                return ("Не удалось найти планету");
            });
            var mars1 = catalog.GetPlanet("Mars", (string x) =>
            {
                callCounter++;

                if (callCounter == 3)
                {
                    callCounter = 0;
                    return ("Вы спрашиваете слишком часто");
                }

                var planet = catalog.PlanetList.Where(i => i.Name.ToUpper() == "Mars");

                if (planet != null)
                {
                    return ("");
                }

                return ("Не удалось найти планету");
            });

            var checkEarth = catalog.GetPlanet("Earth", (string x) =>
            {
                if (x == "Limonia")
                {
                    Console.WriteLine("Это запретная планета");
                    return "Это запретная планета";
                }
                return null;
            });

            var checkLimonia = catalog.GetPlanet("Limonia", (string x) =>
            {
                if (x == "Limonia")
                {
                    Console.WriteLine("Это запретная планета");
                    return "Это запретная планета";
                }
                return null;
            });

            var checkMars = catalog.GetPlanet("Mars", (string x) =>
            {
                if (x == "Limonia")
                {
                    Console.WriteLine("Это запретная планета");
                    return "Это запретная планета";
                }
                return null;
            });
        }
    }
}