using System;
using Settelment.BuildingFunktion;

namespace Settelment
{
    public abstract class Buildings
    {
        private string _Name;

        private string _Funktion;

        private string _Resurs;

        private int _Value;

        private Cost _Cost;

        private int _Worker;

        private bool _IsAktiv;

        public Buildings(string Name, string Funktion, string Resurs, int Value, int CostWood, int CostStone,
            int Worker,bool IsAktiv)
        {
            this.Name = Name;
            this.Funktion = Funktion;
            this.Resurs = Resurs;
            this.Value = Value;
            this.Cost = new Cost(CostWood, CostStone);
            this.Worker = Worker;
            this.IsAktiv = IsAktiv;
        }

        public Buildings(Buildings ConstructionOrder)
        {
            Name = ConstructionOrder.Name;
            Funktion = ConstructionOrder.Funktion;
            Resurs = ConstructionOrder.Resurs;
            Value = ConstructionOrder.Value;
            Cost = new Cost(ConstructionOrder.Cost);
            Worker = ConstructionOrder.Worker;
        }

        public abstract void Work(Settelment Settelment, Buildings Buildings);
/*        {
            
            {
                switch (this._Funktion)
                {
                    case "storage":
                        if (IsAktiv)
                        {
                            Settelment.ResursesList[this.Resurs].MaxStorage += this.Value;
                            IsAktiv = false;
                        }

                        break;
                    case "collecting":
                     ColecterStructure.Work(Settelment,this);
                        break;
                    case "efficient":
                        Settelment.ResursesList[this.Resurs].CollectionRate *= this.Value;
                        ;
                        break;
                }

                
            }

 
        }*/
        public abstract void Use(Settelment Settelment);
        
        public abstract void Destroy(Settelment Settelment);

        public string Name
        {
            get => _Name;
            set => _Name = value;
        }

        public string Funktion
        {
            get => _Funktion;
            set => _Funktion = value;
        }

        public string Resurs
        {
            get => _Resurs;
            set => _Resurs = value;
        }

        public int Value
        {
            get => _Value;
            set => _Value = value;
        }

        public Cost Cost
        {
            get => _Cost;
            set => _Cost = value;
        }

        public int Worker
        {
            get => _Worker;
            set => _Worker = value;
        }

        public bool IsAktiv
        {
            get => _IsAktiv;
            set => _IsAktiv = value;
        }
    }
}