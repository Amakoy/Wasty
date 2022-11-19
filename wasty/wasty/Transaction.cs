using System;
using System.Collections.Generic;
using System.Text;

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

        public void AddTransaction(string userName, int amountOfGoods, float totalPrice)
        {

        }
        // Jika barang dihitung per satuan berat 
        public float CalcPrice(float unitPrice, float wasteWeight)
        {
            TotalPrice = unitPrice * wasteWeight;
            return TotalPrice;
        }
        // Jika barang dihitung per buah 
        public float CalcPrice(float unitPrice, int wasteNum)
        {
            TotalPrice = unitPrice * wasteNum;
            return TotalPrice;
        }


        /*        public float CalculatePrice(string wasteType, float wasteWeight)
                {
                    float price = WastePrice(wasteType, "weight") * wasteWeight;
                    return price;
                }

                public float CalculatePrice(string wasteType, int wasteQty)
                {
                    float price = WastePrice(wasteType, "quantity") * wasteQty;
                    return price;
                }*/

        /*        private float WastePrice(string wasteType, string weightOrQty)
                {
                    if (weightOrQty == "weight")
                    {
                        return 0;
                    }

                    if (weightOrQty == "quantity")
                    {
                        return 0;
                    }
                    return 0;
                }*/
    }
}