public class Account
{
    private string _name;
    private int _code;
    private double _amount;

    public Account(string name, int code)
    {
        _name = name;
        _code = code;
        _amount = 0;
    }

    public virtual void RecordEvent(double paymentAmount)
    {
        _amount += paymentAmount;
    }

    public virtual string GetDetailsString()
    {
        return $"Name: {_name}, Code: {_code}, Amount: {_amount}";
    }
}