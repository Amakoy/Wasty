using System;
using System.Collections.Generic;
using System.Text;

namespace wasty
{
    class Waste
    {
        private string _wasteID;
        private string _wasteType;
        private float _wastePrice;

        public string WasteID
        {
            get { return _wasteID; }
            set { _wasteID = value; }
        }
        public string WasteType
        {
            get { return _wasteType; }
            set { _wasteType = value; }
        }
        public float WastePrice
        {
            get { return _wastePrice; }
            set { _wastePrice = value; }
        }

        public void AddWaste(string wasteType, float wastePrice)
        {

        }
        public void ShowWasteList()
        {

        }
        public void DeleteWaste()
        {

        }
        public void UpdateList()
        {

        }
    }
}
