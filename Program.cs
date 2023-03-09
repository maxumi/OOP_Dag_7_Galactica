namespace Galactica
{
    class program
    {
        static void Main(string[] args)
        {
            Star sun= new Star();
            sun.Name = "Sun";

            sun.Planets.Add(new Planet() { Name = "Mercury" });
            sun.Planets.Add(new Planet() { Name = "Venus" });
            sun.Planets.Add(new Planet() { Name = "Earth" });
            sun.Planets.Add(new Planet() { Name = "Mars" });
            sun.Planets.Add(new Planet() { Name = "Jupiter" });
            sun.Planets.Add(new Planet() { Name = "Saturn" });
            sun.Planets.Add(new Planet() { Name = "Uranus" });
            sun.Planets.Add(new Planet() { Name = "Neptune" });


            sun.Planets[0].Moons.Add(new Moon() { Name = "Luna" });
            sun.Planets[1].Moons.Add(new Moon() { Name = "Titan" });
            sun.Planets[2].Moons.Add(new Moon() { Name = "Phobos" });
            sun.Planets[3].Moons.Add(new Moon() { Name = "Europe" });
            sun.Planets[4].Moons.Add(new Moon() { Name = "Deimos" });
            sun.Planets[5].Moons.Add(new Moon() { Name = "Ganymedes" });
            sun.Planets[6].Moons.Add(new Moon() { Name = "Io" });
            sun.Planets[7].Moons.Add(new Moon() { Name = "Mimas" });

            //Creates positions.
            sun.PositionNew.X = 13;
            sun.PositionNew.Y = 12;
            
            sun.Planets[0].PositionNew.X = 20;
            sun.Planets[0].PositionNew.Y = 29;
            sun.Planets[1].PositionNew.X = 42;
            sun.Planets[1].PositionNew.Y = 10;

            sun.Planets[0].PositionNew.X = 20;
            sun.Planets[0].PositionNew.Y = 29;

            //run distance from star and planet.
            Console.WriteLine($"Distance between {sun.Name} and {sun.Planets[0].Name}");
            sun.Planets[0].distance(sun);
            Console.WriteLine($"\nDistance between {sun.Name} and {sun.Planets[1].Name}");
            sun.Planets[1].distance(sun);

            Console.WriteLine($"\nDistance between {sun.Planets[0].Name} and {sun.Planets[0].Name}");
            sun.Planets[0].Moons[0].distance(sun.Planets[0]);
            Console.WriteLine($"\nDistance between {sun.Planets[1].Name} and {sun.Planets[1].Name}");
            sun.Planets[1].Moons[0].distance(sun.Planets[1]);
        }
    }
}