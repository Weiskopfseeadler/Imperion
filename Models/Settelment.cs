using System;
using System.Collections.Generic;

namespace Settelment
{
    public class Settelment
    {
        private bool _IsPlaying = true;

        private List<Buildings> _Buildings = new List<Buildings>();

        private Dictionary<string, Resurses> _ResursesList = new Dictionary<string, Resurses>();


        public void SetDefault()
        {
            ResursesList = Generator.ResursesList;
            Buildings.Add(new Buildings(Generator.Buildings["timber"]));
            Buildings.Add(new Buildings(Generator.Buildings["stonemason"]));
            Buildings.Add(new Buildings(Generator.Buildings["smallhouse"]));
            AktivatBuildings();
        }

        public void Start()
        {
            ShowBuildings();
            PrintResources();
            PrintMenu();
            CheckEntry(Console.ReadLine());
            Wait();
        }

        private void PrintResources()
        {
            /* Console.WriteLine("Sie haben {0} Steine von {1}", resursesList["stone"].Collected,
                 resursesList["stone"].MaxStorage);
             Console.WriteLine("Sie haben {0} Holz von {1}", resursesList["wood"].Collected,
                 resursesList["wood"].MaxStorage);*/
            ResursesList["stone"].OutputAll();
            ResursesList["wood"].OutputAll();
            ResursesList["vilager"].OutputAll();
        }

        private void PrintMenu()
        {
            Console.WriteLine("Taste [1] um ");
            Console.WriteLine("Taste [2] um ");
            Console.WriteLine("Taste [3] um gebäude zu bauen");

            Console.WriteLine("Taste [9] um das Spiel zu beenden");
        }

        private void CheckEntry(string Entry)
        {
            switch (Entry)
            {
                case "1":
                    
                    break;
                case "2": break;


                case "3":
                    ChoseBulding();
                    break;

                case "4":
                    ;
                    break;
                case "9":
                    IsPlaying = false;
                    break;

                default:
                    Console.WriteLine("Falsche Tasteneingabe");
                    break;
            }
        }

        private void ChoseBulding()
        {
            Console.WriteLine("1 Stein Lager" +
                              "\n2 Holz Lager" +
                              "\n3 Holtzfäler" +
                              "\n4 Steinmetz" +
                              "\n5 Kleines Haus" +
                              "\n6 Kaserne");
            var Build = "0";
            switch (Console.ReadLine())
            {
                case "1":
                    Build = "stonecamp";
                    break;
                case "2":
                    Build = "timberyard";
                    break;
                case "3":
                    Build = "timber";
                    break;
                case "4":
                    Build = "stonemason";
                    break;
                case "5":
                    Build = "smallhouse";
                    break;
                case "6":
                    Build = "";
                    break;
                default:
                    ;
                    break;
            }

            ConstructionOrder(Build);
        }

        private void ConstructionOrder(string Build)
        {
            if (Build.Length > 0)
            {
                if (Generator.Buildings[Build].Cost.CostStone <= ResursesList["stone"].Colected &&
                    Generator.Buildings[Build].Cost.CostWood <= ResursesList["wood"].Colected &&
                    Generator.Buildings[Build].Worker <= ResursesList["vilager"].FreeWorkers)
                {
                    Buildings.Add(new Buildings(Generator.Buildings[Build]));
                    ResursesList["wood"].Colected -= Generator.Buildings[Build].Cost.CostWood;
                    ResursesList["stone"].Colected -= -Generator.Buildings[Build].Cost.CostStone;
                }
                else
                {
                    Console.WriteLine("nicht genug Resursen");
                }
            }
        }

        private void ShowBuildings()
        {
            for (var I = 0; I < Buildings.Count; I++)
            {
                Console.WriteLine(Buildings[I].Name);
            }
        }

        private void AktivatBuildings()
        {
            int Worker = 0;
            foreach (Buildings VARIABLE in Buildings)
            {
                VARIABLE.Work(this);

                Worker += VARIABLE.Worker;
            }

            ResursesList["vilager"].CollectionRate =
                Convert.ToInt32(Math.Round(Convert.ToDouble(ResursesList["vilager"].MaxStorage) / 100));
            ResursesList["vilager"].FreeWorkers = ResursesList["vilager"].Colected - Worker;
        }

        private void Wait()
        {
         AktivatBuildings();   
        }

        public bool IsPlaying
        {
            get => _IsPlaying;
            set => _IsPlaying = value;
        }

        public List<Buildings> Buildings
        {
            get => _Buildings;
            set => _Buildings = value;
        }

        public Dictionary<string, Resurses> ResursesList
        {
            get => _ResursesList;
            set => _ResursesList = value;
        }
    }
}