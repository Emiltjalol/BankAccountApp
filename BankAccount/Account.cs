namespace BankAccount;

public class Account
{
    public string AccountName { get; set; }
    public string AccountNumber { get; set; }
    public decimal Balance { get; set; }

    public bool CreateBankAccountTest()
    {
        if(AccountName.All(char.IsLetter) && AccountNumber.All(char.IsDigit) && Balance > 0 ) 
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static Account CreateBankAccount()
{
    var created = new Account();
    Console.WriteLine("Ange kontonamn");
    created.AccountName = Console.ReadLine();
    
    Console.WriteLine("Ange kontonummer");
    created.AccountNumber = Console.ReadLine();
    
    Console.WriteLine("Ange startsaldo");
    created.Balance = decimal.Parse(Console.ReadLine());
    
    if (created.AccountName.All(char.IsLetter) && created.AccountNumber.All(char.IsDigit) && created.Balance > 0)
    {
        Console.WriteLine("Kontot skapat!");
        return created;
    }
    else
    {
        Console.WriteLine("Felaktiva värden");
        return null;
    }
}

    public void ShowBalance(Account account)
    {
        if (account == null)
        {
            Console.WriteLine("Inget konto hittades");
            return;
        }
        Console.WriteLine($"Du har {account.Balance} kr på kontot");
    }
    
    
    
    
}

