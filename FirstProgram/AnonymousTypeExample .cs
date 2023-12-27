namespace SixthApp.FirstProgram
{
    public class AnonymousTypeExample
    {
        public string Name { get; set; }
        public int OrdinalNumber { get; set; }
        public int EquatorLength { get; set; }
        public string PreviousPlanet { get; set; }

        public void СomparisonWithVenus()
        {
            var venusFirst = new
            {
                Name = "Venus",
                OrdinalNumber = 2,
                EquatorLength = 38025,
                PreviousPlanet = "Mercury"
            };
            var earth = new
            {
                Name = "Earth",
                OrdinalNumber = 3,
                EquatorLength = 40075,
                PreviousPlanet = "Venus"
            };
            var mars = new
            {
                Name = "Mars",
                OrdinalNumber = 4,
                EquatorLength = 10600,
                PreviousPlanet = "Earth"
            };
            var venusSecond = new
            {
                Name = "Venus",
                OrdinalNumber = 2,
                EquatorLength = 38025,
                PreviousPlanet = "Mercury"
            };

            Console.WriteLine($"Планета:{venusFirst.Name}; Орбитальный номер:{venusFirst.OrdinalNumber};Длинна экватора:{venusFirst.EquatorLength}км; Ближайшая планета:{venusFirst.PreviousPlanet}; {(venusFirst.Equals(venusFirst) == true ? "Данные эквивалентны Венере" : "Данные не эквивалентны Венере")}");
            Console.WriteLine($"Планета:{earth.Name}; Орбитальный номер:{earth.OrdinalNumber};Длинна экватора:{earth.EquatorLength}км; Ближайшая планета:{earth.PreviousPlanet}; {(venusFirst.Equals(earth) == true ? "Данные эквивалентны Венере" : "Данные не эквивалентны Венере")}");
            Console.WriteLine($"Планета:{mars.Name}; Орбитальный номер:{mars.OrdinalNumber};Длинна экватора:{mars.EquatorLength}км; Ближайшая планета:{mars.PreviousPlanet}; {(venusFirst.Equals(mars) == true ? "Данные эквивалентны Венере" : "Данные не эквивалентны Венере")}");
            Console.WriteLine($"Планета:{venusSecond.Name}; Орбитальный номер:{venusSecond.OrdinalNumber};Длинна экватора:{venusSecond.EquatorLength}км; Ближайшая планета:{venusSecond.PreviousPlanet}; {(venusFirst.Equals(venusSecond) == true ? "Данные эквивалентны Венере" : "Данные не эквивалентны Венере")}");
        }
    }
}
