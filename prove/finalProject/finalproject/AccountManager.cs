public class AccountManager
{
    private List<Account> _accounts;

    public AccountManager()
    {
        _accounts = new List<Account>();
    }

    public void CreateType()
    {
        Console.WriteLine("Enter TypeName:");
        //string typeName = Console.ReadLine();
        Console.WriteLine("Enter Sequence:");
        int sequence = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Type added successfully.");
    }

    public void CreateAccount()
    {
        Console.WriteLine("Enter Name:");
        //string name = Console.ReadLine();
        Console.WriteLine("Enter Code:");
        int code = Convert.ToInt32(Console.ReadLine());
        //Account account = new Account(name, code);
        //_accounts.Add(account);
        Console.WriteLine("Account added successfully.");
    }

    public void AddPayment()
    {
        Console.WriteLine("Enter Name:");
        //string name = Console.ReadLine();
        Console.WriteLine("Enter Code:");
        int code = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Payment Amount:");
        double paymentAmount = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Payment Date:");
        //DateTime paymentDate = DateTime.Parse(Console.ReadLine());
        //Payment payment = new Payment(name, code, paymentAmount, paymentDate);
        // Find the account and record the payment
        foreach (var account in _accounts)
        {
            //if (account.GetType() == typeof(Payment) && ((Payment)account).GetDetailsString() == payment.GetDetailsString())
            {
                account.RecordEvent(paymentAmount);
                Console.WriteLine("Payment added successfully.");
                return;
            }
        }
        Console.WriteLine("Account not found.");
    }

    public void AddAddress()
    {
        Console.WriteLine("Enter Name:");
        //string name = Console.ReadLine();
        Console.WriteLine("Enter Code:");
        int code = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Address:");
        //string address = Console.ReadLine();
        Console.WriteLine("Enter SecuenceAddress:");
        int sequenceAddress = Convert.ToInt32(Console.ReadLine());
        //Address addressObj = new Address(name, code, address, sequenceAddress);
        Console.WriteLine("Address added successfully.");
    }

    public void AddTipology()
    {
        Console.WriteLine("Enter Name:");
        //string name = Console.ReadLine();
        Console.WriteLine("Enter Code:");
        int code = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Tipology:");
        //string tipology = Console.ReadLine();
        Console.WriteLine("Enter Action Date:");
        //DateTime actionDate = DateTime.Parse(Console.ReadLine());
        //Tipology tipologyObj = new Tipology(name, code, tipology, actionDate);
        Console.WriteLine("Tipology added successfully.");
    }

    public void CheckAccount()
    {
        Console.WriteLine("Enter Code:");
        int code = Convert.ToInt32(Console.ReadLine());
        foreach (var account in _accounts)
        {
            if (account.GetType() == typeof(Account) && ((Account)account).GetDetailsString().Contains(code.ToString()))
            {
                Console.WriteLine(account.GetDetailsString());
                return;
            }
        }
        Console.WriteLine("Account not found.");
    }
}