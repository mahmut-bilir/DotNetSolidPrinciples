public class CreditCardPayment : IPayment
{
    public void Pay() => Console.WriteLine("Payment was made by credit card");

}