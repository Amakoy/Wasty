namespace wasty
{
    class Transaction
    {
        private DateTime _date;
        private float _totalWeight;
        private float _totalPrice;

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public float TotalWeight
        {
            get { return _totalWeight; }
            set { _totalWeight = value; }
        }

        public float TotalPrice
        {
            get { return _totalPrice; }
            set { _totalPrice = value; }
        }

        public void addTransaction(string userName, int amountOfGoods, float totalPrice)
        {

        }

        public float calculatePrice(string wasteType, float wasteWeight)
        {

        }
    }
}