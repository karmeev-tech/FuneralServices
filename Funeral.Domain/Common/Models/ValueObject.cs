namespace Funeral.Domain.Common.Models;

public abstract class ValueObject
{
    public abstract IEnumerable<object> GetEqualityComponents();
}

public class Price : ValueObject
{
    public decimal Amount {get; private set; }
    public string Currency {get; private set; }

     public Price(decimal amount, string currency)
     {
         Amount = amount;
         Currency = currency;
     }
     public override IEnumerable<object> GetEqualityComponents()
     {
        yield return Amount;
     };
}