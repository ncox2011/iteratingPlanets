using System;
using System.Collections.Generic;

namespace IteratingPlanets
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            List<string> lastPlanets = new List<string>() { "Uranus", "Neptune"};

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            planetList.AddRange( lastPlanets );
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            planetList.Add("Pluto");


            List<> planetProbes = new List<>() {
                Dictionary<string, string> probes = new Dictionary<string, string>();
                {"Mariner 10", "Mercury"}
            }


        }
    }
}
