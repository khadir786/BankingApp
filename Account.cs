using BankingApp;

public abstract class Account
{

    private string _accountName = "";
    private string _accountNumber = "";
    private decimal _accountBalance = 0;
    private string _accountType = "";
    private string _creationDate = "";
    // transaction list could be initialised from a file
    private List<Transaction?> _transactions = [];

    public Account(string accountName, string accountNumber, decimal accountBalance, string accountType, string creationDate)
    {
        _accountName = accountName;
        _accountNumber = accountNumber;
        _accountBalance = accountBalance;
        _accountType = accountType;
        _creationDate = creationDate;
    }

    public string AccountName { get => _accountName; set => _accountName = value; }
    public string AccountNumber { get => _accountNumber; }
    public decimal AccountBalance { get => _accountBalance; set => _accountBalance = value; }
    public string AccountType { get => _accountType; set => _accountType = value; }

    public string CreationDate { get => _creationDate; set => _creationDate = value; }
    public List<Transaction?> Transactions { get => _transactions; }

    public virtual bool Deposit(decimal amount)
    {
        AccountBalance += amount;
        Transactions.Add(new Transaction("deposit", amount));
        return true;
    }

    public bool Withdraw(decimal amount)
    {
        if (AccountBalance < 0)
        {
            return false;
        }

        if (amount <= 0)
        {
            Console.WriteLine("Invalid input: Amount must be greater than 0");
            return false;
        }

        if (amount > AccountBalance)
        {
            Console.WriteLine("Invalid input: Cannot withdraw more than the balance in the account");
            return false;
        }

        AccountBalance -= amount;
        Transactions.Add(new Transaction("withdrawal", amount));

        return true;
    }

    public void CreateStandingOrder(string payee, string reference, decimal amount, string interval)
    {
        switch (interval.ToUpper())
        {

            case "DAILY":
                break;

            case "WEEKLY":
                break;

            case "MONTHLY":
                break;

            case "QUARTERLY":
                break;

            case "YEARLY":
                break;

            default:
                throw new ArgumentException("Not a valid interval type");


        }

        Transactions.Add(new StandingOrder(payee, reference, amount, interval));

    }

    public void DisplayStandingOrders()
    {
        var standingOrders = Transactions.OfType<StandingOrder>().ToList();

        if (standingOrders.Count > 0)
        {
            foreach (var standingOrder in standingOrders)
            {
                standingOrder.ShowDetails();
                Console.WriteLine("");
                standingOrder.DisplayDetails();
            }

            return;
        }

        Console.WriteLine("There are no standing orders");
    }

    


    public void DisplayAccountTransactions()
    {
        foreach (var transaction in Transactions)
        {
            transaction.ShowDetails();
        }
    }

    public void DisplayBalance()
    {
        Console.WriteLine($"{AccountBalance:C2}");
    }

    public virtual void DisplayAccountInformation()
    {
        Console.WriteLine($"""
        Account Name : {_accountName}
        Account Number: {_accountNumber}
        Account Balance: {_accountBalance}
        Date of Creation : {_creationDate}
        """);
    }

}