﻿using BankingApp;
public class Program
{
    public static void Main()
    {
        // var businessAccount = new BusinessAccount("MyBusinessAccount", "12123", 1000m, "17-07-2024", "Warner Bros",
        //     BusinessType.Partnership, null, "1234512", 1000, "#1234", 4.5m);
        // businessAccount.DisplayAccountInformation();
        // Customer cus = new Customer("George", "Wilson", 100, 100, "24/01/2003");
        // Console.WriteLine(cus.ToString());
        // Validator.ValidateDriversLicense(cus, "WILSO001243G99KT");

        // Test transaction list
        //businessAccount.DisplayBalance();
        //businessAccount.Withdraw(333.33m);
        //businessAccount.DisplayBalance();
        //businessAccount.Deposit(111.11m);
        //businessAccount.DisplayBalance();
        //businessAccount.DisplayAccountTransactions();

        // ===============================
        // BANK !!!!
        Bank bank = new Bank();

        //foreach (var account in bank.BusinessAccounts)
        //{
        //    account.DisplayAccountInformation();
        //    Console.WriteLine("");
        //}
        //foreach (var account in bank.PersonalAccounts)
        //{

        //    account.DisplayAccountInformation();
        //    Console.WriteLine("");
        //}
        //foreach (var account in bank.ISAAccounts)
        //{

        //    account.DisplayAccountInformation();
        //    Console.WriteLine("");
        //}
        // ===============================



        // Example of Transaction instantiation:
        //string dateString = "12/07/2012";
        //DateTime date = DateTime.Parse(dateString);

        //Transaction a = new Transaction("StandingOrder", date);
        //Transaction b = new Transaction("StandingOrder");

        //a.ShowTransactionDetails();
        //b.ShowTransactionDetails();






    }
}
