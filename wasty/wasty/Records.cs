class records
{
    private string _recordId;
    private string _accountID;
    private DateTime _date;
    private int _amountOfGoods;
    private float _totalPrice;

    public string RecordID
    {
        get { return _recordId; }
        set { _recordId = value; }
    }

    public string AccountID
    {
        get { return _accountID; }
        set { _accountID = value; }
    }
    public DateTime Date
    {
        get { return _date; }
        set { _date = value; }
    }

    public int AmountOfGood
    {
        get { return _amountOfGoods; }
        set { _amountOfGoods = value; }
    }

    public float TotalPrice
    {
        get { return _totalPrice; }
        set { _totalPrice = value; }
    }

}