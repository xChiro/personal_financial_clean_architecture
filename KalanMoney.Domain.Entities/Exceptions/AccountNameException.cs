namespace KalanMoney.Domain.Entities.ValueObjects;

public class AccountNameException : Exception
{
    public string InvalidName { get; }

    public AccountNameException(string invalidName)
    {
        InvalidName = invalidName;
    }
}