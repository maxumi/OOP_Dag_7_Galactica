namespace Galactica
{
    class program
    {
        static void Main(string[] args)
        {
            Data data = new Data();//Creates the data.
            Star sun = new Star();//Creates a star object.
            sun = data.star;//The new sun object is equal to the star object in the data class.
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("STAR:");
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.WriteLine("Star Name: " + sun.Name);//writes the name of the star.
            Console.WriteLine("Type: " + sun.Type+"\n");//And type

            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("PLANETS:");
            Console.ForegroundColor= ConsoleColor.Blue;
            foreach (Planet planet in sun.Planets)//Gets all planets in the sun object.
            {//Writes the information.
                Console.WriteLine("Id: "+planet.Id);
                Console.WriteLine("Name: "+planet.Name);
                Console.WriteLine("Planet type: "+planet.planetType);
                Console.WriteLine("Rotation Period: "+planet.RotationPeriod);
                Console.WriteLine("Diameter: "+planet.Diameter);
                planet.distance(sun);//Uses the distance method to calculate the distance between the star and the planet.
                Console.WriteLine();
            }
            //Foreach loop to print out the moons tied to the planets.
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("MOONS:");
            Console.ForegroundColor= ConsoleColor.Blue;
            foreach (Planet planet in sun.Planets)//Gets all planets in the object.
            {
                foreach (Moon moon in planet.Moons)//Gets the moon for each planet.
                {//Moon info.
                    Console.WriteLine("Id: " + moon.Id);
                    Console.WriteLine("Name: " + moon.Name);
                    Console.WriteLine("Rotation Period: " + moon.RotationPeriod);
                    Console.WriteLine("Diameter: " + moon.Diameter);
                    Console.WriteLine("Orbiting: " + planet.Name);
                    moon.distance(planet);
                    Console.WriteLine();
                }
            }
        }
    }
}