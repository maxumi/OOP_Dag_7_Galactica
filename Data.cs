using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica
{
    internal class Data
    {
        public Star star = new Star();
        public Data()
        {
            Star sun = new Star();//Creates the "sun" object and gives it info.
            sun.Name = "Sun";
            sun.Id= 0;
            sun.Temperature = 400;
            sun.Type = Star.Startype.RedGiant;

            //Creates data for all planets.
            sun.Planets.Add(new Planet() {
                Name = "Mercury",
                Id= 0,
                Diameter= 42,
                RotationPeriod = 1,
                planetType = Planet.PlanetType.Gas_Giant
            });
            sun.Planets[0].PositionNew.X = 20;
            sun.Planets[0].PositionNew.Y = 29;

            sun.Planets.Add(new Planet() {
                Name = "Venus",
                Id= 1,
                Diameter= 34,
                RotationPeriod= 2,
                planetType = Planet.PlanetType.Giant
            });
            sun.Planets[1].PositionNew.X= 13;
            sun.Planets[1].PositionNew.Y= 30;

            sun.Planets.Add(new Planet()
            {
                Name = "Earth",
                Id = 2,
                Diameter = 43,
                RotationPeriod = 3,
                planetType = Planet.PlanetType.Dwarf
            });
            sun.Planets[2].PositionNew.X = 5;
            sun.Planets[2].PositionNew.Y = 10;

            sun.Planets.Add(new Planet() {
                Name = "Mars",
                Id= 3,
                Diameter = 50,
                RotationPeriod= 4,
                planetType = Planet.PlanetType.Terrestrial
            });
            sun.Planets[3].PositionNew.X = 7;
            sun.Planets[3].PositionNew.Y = 12;

            sun.Planets.Add(new Planet() {
                Name = "Jupiter",
                Id= 4,
                Diameter = 22,
                RotationPeriod= 14,
                planetType = Planet.PlanetType.Giant
            });
            sun.Planets[4].PositionNew.X = 8;
            sun.Planets[4].PositionNew.Y = 9;

            sun.Planets.Add(new Planet() {
                Name = "Saturn",
                Id= 5,
                Diameter = 22,
                RotationPeriod= 15,
                planetType = Planet.PlanetType.Terrestrial
            });
            sun.Planets[5].PositionNew.X = 9;
            sun.Planets[5].PositionNew.Y = 10;

            sun.Planets.Add(new Planet() {
                Name = "Uranus",
                Id= 6,
                Diameter= 12,
                RotationPeriod= 13,
                planetType = Planet.PlanetType.Gas_Giant
            });
            sun.Planets[6].PositionNew.X = 22;
            sun.Planets[6].PositionNew.Y= 21;

            sun.Planets.Add(new Planet() {
                Name = "Neptune",
                Id= 7,
                Diameter = 4,
                RotationPeriod= 6,
                planetType = Planet.PlanetType.Terrestrial
            });
            sun.Planets[7].PositionNew.X = 9;
            sun.Planets[7].PositionNew.Y = 14;

            //Create Data for each moon.
            sun.Planets[0].Moons.Add(new Moon() {
                Name = "Luna",
                Id = 0,
                Orbiting = Moon.PlanetType.Giant});
            sun.Planets[0].Moons[0].PositionNew.X = 7;
            sun.Planets[0].Moons[0].PositionNew.Y =15;

            sun.Planets[1].Moons.Add(new Moon() {
                Name = "Titan",
                Id = 1, Orbiting = Moon.PlanetType.Dwarf});
            sun.Planets[1].Moons[0].PositionNew.X= 8;
            sun.Planets[1].Moons[0].PositionNew.Y=15;

            sun.Planets[2].Moons.Add(new Moon() {
                Name = "Phobos",
                Id= 2, Orbiting = Moon.PlanetType.Terrestrial });
            sun.Planets[2].Moons[0].PositionNew.X= 12;
            sun.Planets[2].Moons[0].PositionNew.Y = 13;

            sun.Planets[3].Moons.Add(new Moon() {
                Name = "Europe",
                Id = 3, Orbiting = Moon.PlanetType.Terrestrial});
            sun.Planets[3].Moons[0].PositionNew.X = 9;
            sun.Planets[3].Moons[0].PositionNew.Y = 9;

            sun.Planets[4].Moons.Add(new Moon() {
                Name = "Deimos",
                Id = 4, Orbiting = Moon.PlanetType.Giant});
            sun.Planets[4].Moons[0].PositionNew.X = 24;
            sun.Planets[4].Moons[0].PositionNew.Y = 6;

            sun.Planets[5].Moons.Add(new Moon() {
                Name = "Ganymedes",
                Id = 5,Orbiting = Moon.PlanetType.Terrestrial});
            sun.Planets[5].Moons[0].PositionNew.X = 10;
            sun.Planets[5].Moons[0].PositionNew.Y = 9;

            sun.Planets[6].Moons.Add(new Moon() {
                Name = "Io",
                Id = 6, Orbiting = Moon.PlanetType.Giant});
            sun.Planets[6].Moons[0].PositionNew.X+= 39;
            sun.Planets[6].Moons[0].PositionNew.Y+= 10;

            sun.Planets[7].Moons.Add(new Moon() {
                Name = "Mimas",
                Id = 7, Orbiting = Moon.PlanetType.Giant });
            sun.Planets[7].Moons[0].PositionNew.X = 15;
            sun.Planets[7].Moons[0].PositionNew.Y = 10;

            star = sun;



        }
    }
}
