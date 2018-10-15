using System;

namespace Settelment
{
    public class Resurses
    {
        private int _Colected;

        private string _NameOfSettelment;

        private float _Weight;

        private int _CollectionRate;

        private int _MaxStorage;

        private int _FreeWorkers;

        public Resurses(string NameOfSettelment, float Weight, int CollectionRate, int Colected, int MaxStorage)
        {
            this._NameOfSettelment = NameOfSettelment;
            this._Weight = Weight;
            this._CollectionRate = CollectionRate;
            _Colected = Colected;
            this._MaxStorage = MaxStorage;
        }

        public Resurses(string NameOfSettelment, float Weight, int CollectionRate, int Colected, int MaxStorage, int FreeWorkers)
        {
            this._NameOfSettelment = NameOfSettelment;
            this._Weight = Weight;
            this._CollectionRate = CollectionRate;
            _Colected = Colected;
            this._MaxStorage = MaxStorage;
            this._FreeWorkers = FreeWorkers;
        }


   

        public void OutputAll()
        {
            Console.WriteLine("_NameOfSettelment: " + NameOfSettelment + " weight: " + Convert.ToString(Weight) + " collectionRate: " +
                              Convert.ToString(CollectionRate) + " collectes: " + Convert.ToString(Colected) +
                              " maxstorage: " + MaxStorage + " freeWorkers: " + Convert.ToString(FreeWorkers));
        }

        public int Colected
        {
            get => _Colected;
            set
            {
                if (_Colected + value > MaxStorage)
                {
                    Console.WriteLine("Lager voll");
                    _Colected = MaxStorage;
                }
                else
                {
                    _Colected = value;
                }
            }
        }
        

        public string NameOfSettelment
        {
            get => _NameOfSettelment;
            set => _NameOfSettelment = value;
        }

        public float Weight
        {
            get => _Weight;
            set => _Weight = value;
        }

        public int CollectionRate
        {
            get => _CollectionRate;
            set => _CollectionRate = value;
        }

        public int MaxStorage
        {
            get => _MaxStorage;
            set => _MaxStorage = value;
        }

        public int FreeWorkers
        {
            get => _FreeWorkers;
            set => _FreeWorkers = value;
        }
    }
}