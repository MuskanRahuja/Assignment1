// See https://aka.ms/new-console-template for more information


using Assignment1;

class Details
{


    static void Main(string[] args)
    {
        Account account = new Account();
        Console.WriteLine("enter id");
        account.Id = Byte.Parse(Console.ReadLine());
        Console.WriteLine("enter account type");
        account.AccountType = Console.ReadLine();
        Console.WriteLine("enter balance");
        account.Balance = Double.Parse(Console.ReadLine());
        Console.WriteLine("Enter amount to Withdraw");
        double amount = double.Parse(Console.ReadLine());   
        bool withDrawn = account.WithDraw(amount);
        Console.Write(account.GetDetails());
        if(withDrawn==true)
        {
            Console.WriteLine("New Balance is: " + account.Balance);
        }
        else
        {
            Console.WriteLine("Insufficient balance to withdraw");
        }

        List<Account> accountList = new List<Account>();
        {
            new Account { Id = 111, AccountType = "Saving", Balance = 50000 };
            new Account { Id = 112, AccountType = "Current", Balance = 20000 };
        };
        Console.WriteLine("Account details for all accounts:");
        foreach(var acc in accountList)
        {
            Console.WriteLine(acc.GetDetails());
        }

    }    
}
