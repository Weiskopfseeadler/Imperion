namespace Settelment
{
    public class Cost
    {
        private int _CostStone;

        private int _CostWood;

        public Cost(int CostWood, int CostStone)
        {
            this._CostWood = CostWood;
            this._CostStone = CostStone;
        }

        public Cost(Cost Cost)
        {
            _CostStone = Cost.CostStone;
            _CostWood = Cost._CostWood;
        }

        public int CostStone
        {
            get => _CostStone;
            set => _CostStone = value;
        }

        public int CostWood
        {
            get => _CostWood;
            set => _CostWood = value;
        }
    }
}