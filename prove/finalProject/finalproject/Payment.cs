public class Payment : Account
{
    private double _paymentAmount;
    private DateTime _paymentDate;

    public Payment(string name, int code, double paymentAmount, DateTime paymentDate) : base(name, code)
    {
        _paymentAmount = paymentAmount;
        _paymentDate = paymentDate;
    }

    public override void RecordEvent(double paymentAmount)
    {
        base.RecordEvent(paymentAmount);
    }
}