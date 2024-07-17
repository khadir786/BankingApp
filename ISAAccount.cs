﻿public class ISAAccount : Account
{
    private const decimal InterestRate = 0.0275m;
    private decimal _allottedBalance = 20000;


    public ISAAccount(string accountName, int accountNumber, decimal accountBalance, string creationDate)
        : base(accountName, accountNumber, accountBalance, creationDate)
    { }

    public bool Withdraw(decimal amount)
    {
        if (AccountBalance < 0)
        {
            return false;
        }

        if (amount < 0)
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
        return true;
    }


    /* check tax year for specific deposit transaction using its associated date
     if current deposit transaction's tax year is the same,  
        if (allotted balance - amount) > 0,
          allotted balance -= amount
          current balance += current balance + amount
     otherwise, 
     allotted balance = 20000
    */
    public bool Deposit(decimal amount)
    {


        if (amount <= 0)
        {
            Console.WriteLine("Invalid input: Cannot deposit this amount");
        }

        if (amount > _allottedBalance)
        {
            Console.WriteLine($"Cannot deposit more than allotted balance: {_allottedBalance:C2}");
            return false;
        }

        AccountBalance += amount;
        Console.WriteLine($"Deposited: {amount:C2}");

        return true;
    }


    public void DisplayBalance()
    {
        Console.WriteLine(AccountBalance);
    }

    private DateTime GetTaxYear(DateTime date)
    {


        return default;
    }

}

