﻿using BankingApp;
public class Program
{
    public static void Main()
    {
        var businessAccount = new BusinessAccount("MyBusinessAccount", 12123, 1000m, "17-07-2024", "Warner Bros",
            BusinessType.Partnership, null, 1234512, 1000, "#1234", 4.5m);
        businessAccount.DisplayAccountInformation();
        //Customer cus = new Customer("George", "Wilson", 100, 100, "24/01/2003");
        //Console.WriteLine(cus.ToString());

        // Test transaction list
        //businessAccount.DisplayBalance();
        //businessAccount.Withdraw(333.33m);
        //businessAccount.DisplayBalance();
        //businessAccount.Deposit(111.11m);
        //businessAccount.DisplayBalance();
        //businessAccount.DisplayAccountTransactions();


        // // Uncomment this to test the data parser
        // string workingDirectory = Environment.CurrentDirectory;
        // string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
        // Console.WriteLine(projectDirectory);
        // var businessAccountData = DataParser.ReadDataFromCSV(projectDirectory + "/Data/BusinessSampleData.csv");
        // foreach (var account in businessAccountData)
        // {
        //     Console.WriteLine(account["AccountName"]);
        //     Console.WriteLine(account["AccountBalance"]);
        //     
        // }

        // Example of Transaction instantiation:
        //string dateString = "12/07/2012";
        //DateTime date = DateTime.Parse(dateString);

        //Transaction a = new Transaction("StandingOrder", date);
        //Transaction b = new Transaction("StandingOrder");

        //a.ShowTransactionDetails();
        //b.ShowTransactionDetails();



    }
}
