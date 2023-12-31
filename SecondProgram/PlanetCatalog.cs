
namespace SixthApp.SecondProgram
{
    public class PlanetCatalog
    {
        public List<Planet> PlanetList { get; set; } = new List<Planet>();
        private Planet _firstPlanet;
        private int _callСounter;
        public delegate string PlanetValidator(string planetName);

        public PlanetCatalog()
        {
            _firstPlanet = new Planet()
            {
                Name = "Venus",
                OrdinalNumber = 2,
                EquatorLength = 38025
            };

            PlanetList.Add(_firstPlanet);

            var temp = _firstPlanet;

            var secondPlanet = new Planet()
            {
                Name = "Earth",
                OrdinalNumber = 3,
                EquatorLength = 40075
            };

            PlanetList.Add(secondPlanet);

            secondPlanet.PreviousPlanet = temp;

            var thirdPlanet = new Planet()
            {
                Name = "Mars",
                OrdinalNumber = 4,
                EquatorLength = 10600
            };

            PlanetList.Add(thirdPlanet);
            temp = secondPlanet;
            thirdPlanet.PreviousPlanet = temp;
        }

        public string Validate(string planetName)
        {
            _callСounter++;
            if (_callСounter == 3)
            {
                _callСounter = 0;
                return ("Вы спрашиваете слишком часто");
            }

            var planet = PlanetList.Where(i => i.Name.ToUpper() == planetName.ToUpper()).FirstOrDefault();

            if (planet != null)
            {
                return ("");
            }

            return ("Не удалось найти планету");
        }

        public (int, int, string) GetPlanet(string planetName)
        {
            _callСounter++;
            if (_callСounter == 3)
            {
                Console.WriteLine("Вы спрашиваете слишком часто");
                _callСounter = 0;
                return (0, 0, "Вы спрашиваете слишком часто");
            }
            var planet = PlanetList.Where(i => i.Name.ToUpper() == planetName.ToUpper()).FirstOrDefault();

            if (planet != null)
            {
                Console.WriteLine($"Планета:{planet.Name};Порядковый номер планеты:{planet.OrdinalNumber};Длинна экватора:{planet.EquatorLength}км");
                return (planet.OrdinalNumber, planet.EquatorLength, "");
            }

            Console.WriteLine("Не удалось найти планету");
            return (0, 0, "Не удалось найти планету");
        }



        public (int, int, string) GetPlanet(string planetName, PlanetValidator planetValidator)
        {
            var planet = PlanetList.Where(i => i.Name.ToUpper() == planetName.ToUpper()).FirstOrDefault();
            var result = planetValidator(planetName);
            if (result != "")
            {
                Console.WriteLine(result);
                return (0, 0, result);
            }
            if (planet != null)
            {
                Console.WriteLine($"Планета:{planet.Name};Порядковый номер планеты:{planet.OrdinalNumber};Длинна экватора:{planet.EquatorLength}км");
                return (planet.OrdinalNumber, planet.EquatorLength, result);
            }
            return (0, 0, result);
        }
    }
}
