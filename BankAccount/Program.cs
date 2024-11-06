using BankAccount;

Console.WriteLine("Välkommen till banken!");

Account account = null;

while (true)
{
    Console.WriteLine("[1] Skapa nytt konto");
    Console.WriteLine("[2] Visa saldo");
    Console.WriteLine("[3] Sätt in pengar");
    Console.WriteLine("[4] Ta ut pengar");
    Console.WriteLine("[5] Avsluta");
    
    var input  = Console.ReadLine();

    switch (input)
    {
        case "1":
            account = Account.CreateBankAccount();
            Console.ReadLine();
            break;
        case "2":
            new Account().ShowBalance(account);
            Console.ReadLine();
            break;
            
            
    }
    
    
}



