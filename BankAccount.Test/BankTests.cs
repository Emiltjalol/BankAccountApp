
namespace BankAccount.Test;

public class BankTests
{
    [Theory]
    [InlineData("TestaccountOne", "12345678", 10000, true)]
    [InlineData("TestaccountTwo", "312412312", 24090, true)]
    [InlineData("Testaccount", "12345678", -10000, false)]
    [InlineData("Testaccount123", "12345678", 10000, false)]
    [InlineData("Testaccount", "HEJSAN", 10000, false)]
    public void CanCreateBankAccount(string accountName, string accountNumber, decimal balance, bool expectedResult)
    {

        // Arrange
        var sut = new Account();
        
        sut.AccountName = accountName;
        sut.AccountNumber = accountNumber;
        sut.Balance = balance;
        
        //Act

        var actual = sut.CreateBankAccountTest();
        
        Assert.Equal(expectedResult, actual);

        //Assert

    }
    
}