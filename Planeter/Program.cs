﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planeter
{
    class Program
    {
        public static void AddPlanets()
        {   /* All planet details         PlanetName     Mass           Diameter    Density     Gravity     RotationPeriod   LengthOfDay   DistanceFromSun    OrbitalPeriod     OrbitalVelocity   MeanTemperature   NumberOfMoons   RingSystem      */
            Planet.Planets.Add(new Planet("Mercury",     0.330,         4879,       5427,       3.7,        1407.6,          4222.6,       57.9,              88.0,             47.4,             167,              0,              false));

            Planet.Planets.Add(new Planet("Earth",       5.97,          12756,      5514,       9.8,        23.9,            24.0,         149.6,             365.2,            29.8,             15,               1,              false));

            Planet.Planets.Add(new Planet("Mars",        0.642,         6792,       3933,       3.7,        24.6,            24.7,         227.9,             687.0,            24.1,             -65,              2,              false));
                
            Planet.Planets.Add(new Planet("Juptier",     1898,          142984,     1326,       23.1,       9.9,             9.9,          778.6,             4331,             13.1,             -110,             67,             true));

            Planet.Planets.Add(new Planet("Saturn",      568,           120536,     687,        9.0,        10.7,            10.7,         1433.5,            10747,            9.7,              -140,             62,             true));
                 
            Planet.Planets.Add(new Planet("Uranus",      86.8,          51118,      1271,       8.7,        -17.2,           17.2,         2872.5,            30589,            6.8,              -195,             27,             true));
             
            Planet.Planets.Add(new Planet("Neptune",     102,           49528,      1638,       11.0,       16.1,            16.1,         4495.1,            59.8,             5.4,              -200,             14,             true));

            Planet.Planets.Add(new Planet("Pluto",       0.0146,        2370,       2095,       0.7,        -153.3,          153.3,        5906.4,            90.56,            4.7,              -225,             5,              true));
        } 
        
        static void Main(string[] args)
        {
            AddPlanets();

            
            int count = 0;

            //Inserts Venus at Index value number 1.
            /* All planet details               PlanetName     Mass           Diameter    Density     Gravity     RotationPeriod   LengthOfDay   DistanceFromSun    OrbitalPeriod     OrbitalVelocity   MeanTemperature   NumberOfMoons   RingSystem      */
            Planet.Planets.Insert(1, new Planet("Venus",       4.87,          12104,      5243,       8.9,        -5832.5,         2802.0,       108.2,             224.7,            35.0,             464,              0,              false));
            
            //Here I make some ConsoleWriteLines for all the planets so they show in the console and a planet counter.
            foreach (Planet item in Planet.Planets)
            {
                count++;
                
                Console.WriteLine("------");
                
                Console.WriteLine($"Planet Name:        {item.Name}");
                
                Console.WriteLine($"Mass:               {item.Mass}");
                
                Console.WriteLine($"Diameter:           {item.Diameter}");
                
                Console.WriteLine($"Density:            {item.Density}");
                
                Console.WriteLine($"Gravity:            {item.Gravity}");
                
                Console.WriteLine($"Rotation Period:    {item.RotationPeriod}");
                
                Console.WriteLine($"Length Of Day:      {item.LengthOfDays}");
                
                Console.WriteLine($"Distance from Sun:  {item.DistanceFromSun}");
                
                Console.WriteLine($"Orbital Period:     {item.OrbitalPeriod}");
                
                Console.WriteLine($"Orbital Velocity:   {item.OrbitalVelocity}");
                
                Console.WriteLine($"Mean Temperature:   {item.MeanTemprature}");
                
                Console.WriteLine($"Number of moons:    {item.NumberOfMoons}");
                
                Console.WriteLine($"Ring System:        {item.RingSystem}\n\n\n");
            }

            Console.WriteLine("Number of Planets: " + count);

            //Here I remove Pluto as statet in the asignment.
            Planet.RemovePlanet("Pluto");

            //Here I add Pluto back as stated in the asignment.
            Planet.AddPluto();

            //Here I add all planets that have a Mean Temperature of bellow 0 to a new list.
            foreach (Planet item2 in Planet.Planets)
            {
                if(item2.MeanTemprature < 0)
                {
                    
                    Planet.PlanetsMeanTemp.Add(item2);
                }
            }

            //Here I add all planets that have a diameter larger than 10.000 and lower than 50.000
            foreach(Planet item3 in Planet.Planets)
            {
                if(item3.Diameter > 10000 && item3.Diameter < 50000) 
                {
                    
                    Planet.PlanetsDiameter.Add(item3);
                }
            }

            Planet.RemovePlanets();


            Console.ReadKey();
        }

        
    }
}
