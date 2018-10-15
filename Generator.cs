using System.Collections.Generic;
using HuntAndFarm.Models.BuildingFunktion;
using Settelment.BuildingFunktion;

namespace Settelment
{
    public class Generator
    {
        public static Dictionary<string, Resurses> ResursesList { get; set; } = new Dictionary<string, Resurses>();

        public static Dictionary<string, Buildings> Buildings { get; set; } = new Dictionary<string, Buildings>();

        public static void GeneratAll()
        {
            GeneratBuildings();
            GenereatResurses();
        }

        public static void GeneratBuildings()
        {
            Buildings.Add("timberyard", new StorageStructer("Timberyard", "storage", "wood", 500, 100, 50, 0,true));
            Buildings.Add("stonecamp", new StorageStructer("Stonecamp", "storage", "stone", 500, 100, 50, 0,true));
            Buildings.Add("stonemason", new ColecterStructure("Stonemason", "collecting", "stone", 50, 200, 100, 5,true));
            Buildings.Add("timber", new ColecterStructure("Timber", "collecting", "wood", 100, 200, 100, 3,true));
            Buildings.Add("smallhouse", new StorageStructer("Smallhouse", "storage", "vilager", 100, 100, 50, 0,true));
            // Buildings.Add("goldmine", new Buildings("Goldmine",));
        }

        public static void GenereatResurses()
        {
            ResursesList.Add("stone", new Resurses("Stone", 50, 50, 0, 200));
            ResursesList.Add("wood", new Resurses("Wood", 50, 100, 0, 200));
            ResursesList.Add("vilager", new Resurses("Vilager", 0, 1, 10, 0, 0));
            ResursesList.Add("gold", new Resurses("Gold", 0, 0, 0, 0));
        }
    }
}